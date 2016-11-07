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

namespace ChemistryApp.MyTeaching
{
    class MyTeachingItemManager
    {
        /// 用来存放所有的课件Item
        /// </summary>
        public List<Panel> listPanelItem;
        /// <summary>
        /// 用来存放所有课件item 位置，用于置顶
        /// </summary>
        public List<Point> listPanelItemPoint;
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
            listPanelItem = new List<Panel>();
            listPanelItemPoint = new List<Point>();
        }

        /// <summary>
        /// 创建item
        /// </summary>
        private void CreateTeachingItem()
        {

            Init();
            //从数据库中读取数据
            string sqlStr = "select * from MyTeaching"; //(select LessonContent from LessonList where ID = 1)";
            DataSet data = AccessDBConn.ExecuteQuery(sqlStr, "MyTeaching");
            DataRow[] dataRow = data.Tables["MyTeaching"].Select();
            //创建itempanel
            for (int i = 0; i < dataRow.Count(); i++)
            {
                
            }
        }
    }
}
