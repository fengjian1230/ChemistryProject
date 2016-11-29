using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using ChemistryApp.EnumType;

/// <summary>
/// 管理我的课表的item，使用单例
/// </summary>
namespace ChemistryApp.MyLesson
{
    class MyLessonItemManager
    {
        /// 用来存放所有的课件Item
        /// </summary>
        public List<Panel> listPanelItem;
        /// <summary>
        /// 课程折叠状态
        /// </summary>
        public LessonItemState state = LessonItemState.Open;
        /// <summary>
        /// 编辑状态
        /// </summary>
        public BianJiState bianjiState = BianJiState.Bianji;
        /// <summary>
        /// 当删除完成后
        /// </summary>
        public Action OnDeleteFinish;
        /// <summary>
        /// 如果删除第一个则最上面一个置顶
        /// </summary>
        public bool isDeleteFirstItem;
        /// <summary>
        /// 删除的字段名
        /// </summary>
        public string filedName;
        /// <summary>
        /// 课程的个数
        /// </summary>
        private Dictionary<string, int> childItemNum;
        public Dictionary<string, int> ChildItemNum
        {
            get { return childItemNum; }
        }

        /// <summary>
        /// 字段名
        /// </summary>
        private string _lessonFiledName;
        public string lessonFiledName
        {
            get { return _lessonFiledName; }
            set { _lessonFiledName = value; }
        }

        //实例
        private static MyLessonItemManager instance;
        public static MyLessonItemManager GetInstace
        {
            get
            {
                if (instance == null)
                {
                    instance = new MyLessonItemManager();
                }
                return instance;
            }
        }

        /// <summary>
        /// 初始化
        /// </summary>
        public void Init()
        {
            //实例化链表
            if (listPanelItem == null || childItemNum == null)
            {
                listPanelItem = new List<Panel>();
                childItemNum = new Dictionary<string, int>();
            }
        }


        /// <summary>
        /// 创建我的课表的item
        /// </summary>
        public void CreateMyLessonItem()
        {
            int _posIndex = 1;
            Init();
            listPanelItem.Clear();
            childItemNum.Clear();
            //从数据库中读取数据
            string sqlStr = "select * from LessonList ";//order by ListID asc"; //(select LessonContent from LessonList where ID = 1)";
            DataSet data = AccessDBConn.ExecuteQuery(sqlStr, "LessonList");
            DataRow[] dataRow = data.Tables["LessonList"].Select();
            //创建itempanel
            for (int i = 0; i < dataRow.Count(); i++)
            {
               
                MyLessonItem myLessonItem;
                //创建我的课表Item
                //把得到的值放入到链表里面
                if (dataRow[i]["IsTop"].ToString() == "true")
                {
                     myLessonItem = new MyLessonItem(10, 0, dataRow[i]["LessonTitle"].ToString(), dataRow[i]["Tips"].ToString(),false);
                }
                else
                {
                    myLessonItem = new MyLessonItem(10, _posIndex * (140 + 10), dataRow[i]["LessonTitle"].ToString(), dataRow[i]["Tips"].ToString(),false);
                    _posIndex++;
                   
                }
                listPanelItem.Add(myLessonItem);
                //从一个字段查询另外一个表
                //string _childStr = "select * from " + dataRow[i]["LessonContent"].ToString() + "";
                //DataSet childData = AccessDBConn.ExecuteQuery(_childStr, dataRow[i]["LessonContent"].ToString());
                //DataRow[] childDataRow = childData.Tables[dataRow[i]["LessonContent"].ToString()].Select();
                ////创建课表列表
                //for (int j = 0; j < childDataRow.Count(); j++)
                //{
                //    MyLessonChildItem childPanel = new MyLessonChildItem(0, 140 + j * 30, childDataRow[j]["Title"].ToString(), childDataRow[j]["Type"].ToString());
                //    childPanel.fieldName = dataRow[0]["LessonTitle"].ToString();
                //    childPanel.Name = "childPanel" + j.ToString();
                //    if (j % 2 == 0)
                //    {
                //        childPanel.BackColor = Color.FromArgb(245, 245, 247);
                //    }
                //    else
                //    {
                //        childPanel.BackColor = Color.White;
                //    }
                //    myLessonItem.Controls.Add(childPanel);
                //    childPanel.BringToFront();
                //}
                //childItemNum.Add(dataRow[i]["LessonTitle"].ToString(), childDataRow.Count());
            }
        }
    }
}
