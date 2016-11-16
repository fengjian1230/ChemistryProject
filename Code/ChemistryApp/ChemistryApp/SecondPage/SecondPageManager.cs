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
        /// <summary>
        /// 表名
        /// </summary>
        private string tableName;
        public string TableName
        {
            get { return tableName; }
            set { tableName = value; }
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
    }
}
