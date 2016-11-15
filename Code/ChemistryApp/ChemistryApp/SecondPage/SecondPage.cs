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
    class SecondPage : Panel
    {
        /// <summary>
        /// 一单元的按钮委托
        /// </summary>
        public EventHandler FirstPartButtonAction;
        /// <summary>
        /// 二单元的按钮委托
        /// </summary>
        public EventHandler SecondPartButtonAction;
        /// <summary>
        /// 三单元的按钮委托
        /// </summary>
        public EventHandler ThirdPartButtonAction;
        /// <summary>
        /// 四单元的按钮委托
        /// </summary>
        public EventHandler FourthPartButtonAction;


        public SecondPage()
        {
            
        }

        /// <summary>
        /// 初始化内容
        /// </summary>
        private void InitCompent()
        {

        }
    }
}
