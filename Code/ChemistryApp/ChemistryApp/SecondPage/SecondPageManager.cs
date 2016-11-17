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
using ChemistryApp.MyLesson;
using ChemistryApp.EnumType;
using ChemistryApp.MyTeaching;

namespace ChemistryApp.SecondPage
{
    class SecondPageManager
    {
        public List<Control> partBtnList;
        /// <summary>
        /// 表名
        /// </summary>
        private string tableName;
        public string TableName
        {
            get { return tableName; }
            set { tableName = value; }
        }

        /// <summary>
        /// 初始化
        /// </summary>
        public void Init()
        {
            if (partBtnList == null)
            {
                partBtnList = new List<Control>();
            }
        }

        //实例
        private static SecondPageManager instance;
        public static SecondPageManager GetInstace
        {
            get
            {
                if (instance == null)
                {
                    instance = new SecondPageManager();
                }
                return instance;
            }
        }

        /// <summary>
        /// 根据点击名字让按钮变换背景，其他按钮变成白色背景
        /// </summary>
        /// <param name="_name"></param>
        public void OnClickChangeBackGround(string _name)
        {
            foreach (Control item in partBtnList)
            {
                if (item.Name == _name)
                {
                    item.BackgroundImage = global::ChemistryApp.Properties.Resources.btnRedBg_down;
                }
                else
                {
                    item.BackgroundImage = global::ChemistryApp.Properties.Resources.btnWhiteBG_up;
                }
            }
        }
    }
}
