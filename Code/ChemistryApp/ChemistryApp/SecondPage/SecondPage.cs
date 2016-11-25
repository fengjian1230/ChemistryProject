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
    /// <summary>
    /// 二级页面的主背景
    /// </summary>
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
            this.Location = new System.Drawing.Point(100, 174);
            this.Name = "panel_secondPage";
            this.Size = new System.Drawing.Size(800, 460);
            this.TabIndex = 23;
            this.Visible = true;
            this.secondButtonPageBG.btn_one.Click += FirstPartButtonClick;
            this.secondButtonPageBG.btn_two.Click += SecondPartButtonClick;
            this.secondButtonPageBG.btn_three.Click += ThirdPartButtonClick;
            this.secondButtonPageBG.btn_four.Click += FourthPartButtonClick;
        }

        /// <summary>
        /// 第一单元按钮事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FirstPartButtonClick(object sender,EventArgs e)
        {
            this.secondContentBG.pageContent.RemoveAllControls();
            this.secondContentBG.pageContent.SelectContentByIndex(1);
            SecondPageManager.GetInstace.OnClickChangeBackGround(((Button)sender).Name);
        }

        /// <summary>
        /// 第一单元按钮事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SecondPartButtonClick(object sender, EventArgs e)
        {
            this.secondContentBG.pageContent.RemoveAllControls();
            this.secondContentBG.pageContent.SelectContentByIndex(2);
            SecondPageManager.GetInstace.OnClickChangeBackGround(((Button)sender).Name);
        }

        /// <summary>
        /// 第一单元按钮事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ThirdPartButtonClick(object sender, EventArgs e)
        {
            this.secondContentBG.pageContent.RemoveAllControls();
            this.secondContentBG.pageContent.SelectContentByIndex(3);
            SecondPageManager.GetInstace.OnClickChangeBackGround(((Button)sender).Name);
        }

        /// <summary>
        /// 第一单元按钮事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FourthPartButtonClick(object sender, EventArgs e)
        {
            this.secondContentBG.pageContent.RemoveAllControls();
            this.secondContentBG.pageContent.SelectContentByIndex(4);
            SecondPageManager.GetInstace.OnClickChangeBackGround(((Button)sender).Name);
        }
    }
}
