using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using ADOX;
using System.Data.OleDb;

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
        /// 用来存放所有课件item 位置，用于置顶
        /// </summary>
        public List<Point> listPanelItemPoint;
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
            listPanelItem = new List<Panel>();
            listPanelItemPoint = new List<Point>();
        }

        /// <summary>
        /// 创建我的课表的item
        /// </summary>
        public void CreateMyLessonItem()
        {
            Init();
            //从数据库中读取数据
            string sqlStr = "select * from LessonList"; //(select LessonContent from LessonList where ID = 1)";
            DataSet data = AccessDBConn.ExecuteQuery(sqlStr, "LessonList");
            DataRow[] dataRow = data.Tables["LessonList"].Select();
            //创建itempanel
            for (int i = 0; i < dataRow.Count(); i++)
            {
                //创建我的课表Item
                MyLessonItem myLessonItem = new MyLessonItem();
                listPanelItem.Add(myLessonItem.CreateControl(10, i * (140 + 10), dataRow[i]["LessonTitle"].ToString(), dataRow[i]["Tips"].ToString()));
                listPanelItemPoint.Add(new Point(10, i * (140 + 10)));
            }
            //OleDbDataReader oldr = AccessDBConn.ExecuteReader(sqlStr);
            //try
            //{
            //    while (oldr.Read())
            //    {
            //        string str = "select * from " + oldr["LessonContent"] + "";
            //        OleDbDataReader reader = AccessDBConn.ExecuteReader(str);
            //        while (reader.Read())
            //        {
            //            //for (int i = 0; i < reader.FieldCount; i++)
            //            //{
            //            //    myLessonItem.listPanelItem.Add(myLessonItem.CreateControl(10, j * (140 + 10),));
            //            //    this.panel_item.Controls.Add(myLessonItem.listPanelItem[i]);
            //            //}

            //        }

            //    }

            //}
            //catch (Exception es)
            //{

            //    MessageBox.Show(es.Message);
            //}

        }

    }
}
