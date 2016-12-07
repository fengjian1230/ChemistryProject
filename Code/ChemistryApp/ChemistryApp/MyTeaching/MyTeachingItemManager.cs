using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace ChemistryApp.MyTeaching
{
    class MyTeachingItemManager
    {
        /// 用来存放所有的课件Item
        /// </summary>
        public List<MyTeachingItem> listPanelItem;
        /// <summary>
        /// 用来存放所有课件item 位置，用于置顶
        /// </summary>
        public List<Point> listPanelItemPoint;
        /// <summary>
        /// 用于删除后刷新界面
        /// </summary>
        public Action OnItemDelete;
        //实例
        private static MyTeachingItemManager instance;
        public static MyTeachingItemManager GetInstace
        {
            get
            {
                if (instance == null)
                {
                    instance = new MyTeachingItemManager();
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
            if (listPanelItem == null || listPanelItemPoint == null)
            {
                listPanelItem = new List<MyTeachingItem>();
                listPanelItemPoint = new List<Point>();
            }
        }

        /// <summary>
        /// 创建item
        /// </summary>
        public void CreateTeachingItem()
        {
            GetInstace.Init();
            GetInstace.listPanelItem.Clear();
            GetInstace.listPanelItemPoint.Clear();
            //从数据库中读取数据
            string sqlStr = "select * from MyTeaching order by TeachingSort asc"; //(select LessonContent from LessonList where ID = 1)";
            DataSet data = AccessDBConn.ExecuteQuery(sqlStr, "MyTeaching");
            DataRow[] dataRow = data.Tables["MyTeaching"].Select();
            //创建itempanel
            for (int i = 0; i < dataRow.Count(); i++)
            {
                //在panel中显示出来
                MyTeachingItem teachingItem = new MyTeachingItem(20, i * (80 + 10) + 50, dataRow[i]["TeachingTitle"].ToString(), dataRow[i]["TeachingType"].ToString());
                teachingItem.Name = "panel_myTeachingItem" + i.ToString();
                GetInstace.listPanelItem.Add(teachingItem);
                GetInstace.listPanelItemPoint.Add(new Point(20, i * (80 + 10) + 50));
            }
        }

        /// <summary>
        /// 显示我的课表的个数
        /// </summary>
        /// <param name="mainForm"></param>
        public void ShowTeachingCount(MainForm mainForm)
        {
            string countSql = "select count(*) from MyTeaching";
            int myTeachingCountInt = AccessDBConn.ExecuteScalar(countSql);
            mainForm.myTeachingCount.Text = myTeachingCountInt.ToString();
            mainForm.countBG.Parent = mainForm.pic_myteachingMianban;
            mainForm.countBG.Location = new Point(13, 370);
            mainForm.myTeachingCount.Parent = mainForm.countBG;
            mainForm.myTeachingCount.Location = new Point(-2, -2);
            string teachingCountLength = myTeachingCountInt.ToString();
            switch (teachingCountLength.Length)
            {
                case 1:
                    mainForm.countBG.Size = new Size(15, 15);
                    mainForm.countBG.Image = global::ChemistryApp.Properties.Resources.countBG;
                    break;
                case 2:
                    mainForm.countBG.Size = new Size(22, 15);
                    mainForm.countBG.Location = new Point(7, 370);
                    mainForm.countBG.Image = global::ChemistryApp.Properties.Resources.countBG1;
                    break;
                case 3:
                    mainForm.countBG.Size = new Size(25, 15);
                    mainForm.countBG.Location = new Point(5, 370);
                    mainForm.countBG.Image = global::ChemistryApp.Properties.Resources.countBG2;
                    break;
                default:
                    break;
            }
        }
    }
}
