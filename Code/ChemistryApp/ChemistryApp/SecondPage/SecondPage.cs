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
    class SecondPageBackGroundPanel : Panel
    {
        SecondPageButtonPanle secondButtonPageBG;
        SecondPageContentBackGroundPanel secondContentBG;
        public SecondPageBackGroundPanel()
        {
            secondButtonPageBG = new SecondPageButtonPanle();
            secondContentBG = new SecondPageContentBackGroundPanel();
            InitCompent();
        }

        /// <summary>
        /// 初始化内容
        /// </summary>
        private void InitCompent()
        {
            // 
            // panel_secondPage
            // 
            this.Controls.Add(this.secondButtonPageBG);
            this.Controls.Add(this.secondContentBG);
            this.Location = new System.Drawing.Point(91, 174);
            this.Name = "panel_secondPage";
            this.Size = new System.Drawing.Size(810, 460);
            this.TabIndex = 23;
            this.Visible = true;
        }
    }
}
