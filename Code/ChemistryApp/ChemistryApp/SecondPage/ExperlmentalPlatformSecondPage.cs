﻿using System;
using System.Windows.Forms;


namespace ChemistryApp.SecondPage
{
    /// <summary>
    /// 实验平台
    /// </summary>
    class ExperlmentalPlatformSecondPage : OtherSecondPage
    {
        private System.Windows.Forms.PictureBox picBtn_EP;
        private System.Windows.Forms.PictureBox picBtn_VR;
        private System.Windows.Forms.PictureBox picBtn_EPoint;
        private System.Windows.Forms.PictureBox picBtn_IE;

        public ExperlmentalPlatformSecondPage()
        {
            this.picBtn_VR = new System.Windows.Forms.PictureBox();
            this.picBtn_EPoint = new System.Windows.Forms.PictureBox();
            this.picBtn_IE = new System.Windows.Forms.PictureBox();
            this.picBtn_EP = new System.Windows.Forms.PictureBox();
            InitCompent();
        }

        private void InitCompent()
        {
            base.Controls.Add(picBtn_VR);
            base.Controls.Add(picBtn_EPoint);
            base.Controls.Add(picBtn_IE);
            base.Controls.Add(picBtn_EP);
            // 
            // picBtn_VR
            // 
            this.picBtn_VR.BackColor = System.Drawing.Color.Transparent;
            this.picBtn_VR.BackgroundImage = global::ChemistryApp.Properties.Resources.VR_up;
            this.picBtn_VR.Location = new System.Drawing.Point(553, 131);
            this.picBtn_VR.Name = "picBtn_VR";
            this.picBtn_VR.Size = new System.Drawing.Size(141, 167);
            this.picBtn_VR.TabIndex = 3;
            this.picBtn_VR.TabStop = false;
            this.picBtn_VR.Cursor = Cursors.Hand;
            this.picBtn_VR.MouseEnter += new EventHandler(OnButtonMouseEnter);
            this.picBtn_VR.MouseLeave += new EventHandler(OnButtonMouseLeave);
            // 
            // picBtn_EPoint
            // 
            this.picBtn_EPoint.BackColor = System.Drawing.Color.Transparent;
            this.picBtn_EPoint.BackgroundImage = global::ChemistryApp.Properties.Resources.EPoint_up;
            this.picBtn_EPoint.Location = new System.Drawing.Point(412, 131);
            this.picBtn_EPoint.Name = "ExperimentalPoints";
            this.picBtn_EPoint.Size = new System.Drawing.Size(141, 167);
            this.picBtn_EPoint.TabIndex = 2;
            this.picBtn_EPoint.TabStop = false;
            this.picBtn_EPoint.Cursor = Cursors.Hand;
            this.picBtn_EPoint.MouseEnter += new EventHandler(OnButtonMouseEnter);
            this.picBtn_EPoint.MouseLeave += new EventHandler(OnButtonMouseLeave);
            this.picBtn_EPoint.Click += new EventHandler(OnButtonClick);
            // 
            // picBtn_IE
            // 
            this.picBtn_IE.BackColor = System.Drawing.Color.Transparent;
            this.picBtn_IE.BackgroundImage = global::ChemistryApp.Properties.Resources.IE_up;
            this.picBtn_IE.Location = new System.Drawing.Point(271, 131);
            this.picBtn_IE.Name = "IndependentExperiments";
            this.picBtn_IE.Size = new System.Drawing.Size(141, 167);
            this.picBtn_IE.TabIndex = 1;
            this.picBtn_IE.TabStop = false;
            this.picBtn_IE.Cursor = Cursors.Hand;
            this.picBtn_IE.MouseEnter += new EventHandler(OnButtonMouseEnter);
            this.picBtn_IE.MouseLeave += new EventHandler(OnButtonMouseLeave);
            this.picBtn_IE.Click += new EventHandler(OnButtonClick);
            // 
            // picBtn_EP
            // 
            this.picBtn_EP.BackColor = System.Drawing.Color.Transparent;
            this.picBtn_EP.BackgroundImage = global::ChemistryApp.Properties.Resources.EP_up;
            this.picBtn_EP.Location = new System.Drawing.Point(130, 131);
            this.picBtn_EP.Name = "ExperimentalPractices";
            this.picBtn_EP.Size = new System.Drawing.Size(141, 167);
            this.picBtn_EP.TabIndex = 0;
            this.picBtn_EP.TabStop = false;
            this.picBtn_EP.Cursor = Cursors.Hand;
            this.picBtn_EP.MouseEnter += new EventHandler(OnButtonMouseEnter);
            this.picBtn_EP.MouseLeave += new EventHandler(OnButtonMouseLeave);
            this.picBtn_EP.Click += new EventHandler(OnButtonClick);

        }
        #region 鼠标事件
        /// <summary>
        /// c元素鼠标进入事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnButtonMouseEnter(object sender, EventArgs e)
        {
            PictureBox pic = (PictureBox)sender;
            switch (pic.Name)
            {
                case "picBtn_VR":
                    pic.BackgroundImage = global::ChemistryApp.Properties.Resources.VR_down;
                    break;
                case "ExperimentalPoints":
                    pic.BackgroundImage = global::ChemistryApp.Properties.Resources.EPoint_down;
                    break;
                case "IndependentExperiments":
                    pic.BackgroundImage = global::ChemistryApp.Properties.Resources.IE_down;
                    break;
                case "ExperimentalPractices":
                    pic.BackgroundImage = global::ChemistryApp.Properties.Resources.EP_down;
                    break;
                default:
                    break;
            }

        }
        /// <summary>
        /// c元素鼠标离开事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnButtonMouseLeave(object sender, EventArgs e)
        {
            PictureBox pic = (PictureBox)sender;
            switch (pic.Name)
            {
                case "picBtn_VR":
                    pic.BackgroundImage = global::ChemistryApp.Properties.Resources.VR_up;
                    break;
                case "ExperimentalPoints":
                    pic.BackgroundImage = global::ChemistryApp.Properties.Resources.EPoint_up;
                    break;
                case "IndependentExperiments":
                    pic.BackgroundImage = global::ChemistryApp.Properties.Resources.IE_up;
                    break;
                case "ExperimentalPractices":
                    pic.BackgroundImage = global::ChemistryApp.Properties.Resources.EP_up;
                    break;
                default:
                    break;
            }

        }

        /// <summary>
        /// 点击按钮的时候触发
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnButtonClick(object sender,EventArgs e)
        {
            PictureBox picBox = (PictureBox)sender;

            SecondPageManager.GetInstace.TableName = picBox.Name;
            SecondPageBackGroundPanel secondPagePanel = new SecondPageBackGroundPanel();
            Panel mainPanel = picBox.Parent.Parent as Panel;
            MainForm mainForm = mainPanel.Parent as MainForm;
            mainPanel.Controls.Add(secondPagePanel);
            secondPagePanel.BringToFront();
            mainForm.ControlBringToFront();
        }
        #endregion
    }
}
