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
using ChemistryApp.MyLesson;
using ChemistryApp.EnumType;
using ChemistryApp.MyTeaching;

namespace ChemistryApp.SecondPage
{
    /// <summary>
    /// 知识回顾
    /// </summary>
    class KnowledgeReviewSecondPage : OtherSecondPage
    {
        private System.Windows.Forms.PictureBox picBtn_CE;
        private System.Windows.Forms.PictureBox picBtn_RE;
        private System.Windows.Forms.PictureBox picBtn_PS;

        public KnowledgeReviewSecondPage()
        {
            this.picBtn_RE = new System.Windows.Forms.PictureBox();
            this.picBtn_PS = new System.Windows.Forms.PictureBox();
            this.picBtn_CE = new System.Windows.Forms.PictureBox();
            InitCompent();
        }

        private void InitCompent()
        {
            base.Controls.Add(picBtn_RE);
            base.Controls.Add(picBtn_PS);
            base.Controls.Add(picBtn_CE);
            // 
            // picBtn_RS
            // 
            this.picBtn_RE.BackColor = System.Drawing.Color.Transparent;
            this.picBtn_RE.BackgroundImage = global::ChemistryApp.Properties.Resources.RE_up;
            this.picBtn_RE.Location = new System.Drawing.Point(544, 131);
            this.picBtn_RE.Name = "picBtn_RE";
            this.picBtn_RE.Size = new System.Drawing.Size(141, 167);
            this.picBtn_RE.TabIndex = 3;
            this.picBtn_RE.TabStop = false;
            this.picBtn_RE.Cursor = Cursors.Hand;
            this.picBtn_RE.MouseEnter += new EventHandler(OnButtonMouseEnter);
            this.picBtn_RE.MouseLeave += new EventHandler(OnButtonMouseLeave);
            // 
            // picBtn_PS
            // 
            this.picBtn_PS.BackColor = System.Drawing.Color.Transparent;
            this.picBtn_PS.BackgroundImage = global::ChemistryApp.Properties.Resources.PS_up;
            this.picBtn_PS.Location = new System.Drawing.Point(343, 131);
            this.picBtn_PS.Name = "picBtn_PS";
            this.picBtn_PS.Size = new System.Drawing.Size(141, 167);
            this.picBtn_PS.TabIndex = 1;
            this.picBtn_PS.TabStop = false;
            this.picBtn_PS.Cursor = Cursors.Hand;
            this.picBtn_PS.MouseEnter += new EventHandler(OnButtonMouseEnter);
            this.picBtn_PS.MouseLeave += new EventHandler(OnButtonMouseLeave);
            // 
            // picBtn_CE
            // 
            this.picBtn_CE.BackColor = System.Drawing.Color.Transparent;
            this.picBtn_CE.BackgroundImage = global::ChemistryApp.Properties.Resources.CE_up;
            this.picBtn_CE.Location = new System.Drawing.Point(133, 131);
            this.picBtn_CE.Name = "picBtn_CE";
            this.picBtn_CE.Size = new System.Drawing.Size(141, 167);
            this.picBtn_CE.TabIndex = 0;
            this.picBtn_CE.TabStop = false;
            this.picBtn_CE.Cursor = Cursors.Hand;
            this.picBtn_CE.MouseEnter += new EventHandler(OnButtonMouseEnter);
            this.picBtn_CE.MouseLeave += new EventHandler(OnButtonMouseLeave);
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
                case "picBtn_PS":
                    pic.BackgroundImage = global::ChemistryApp.Properties.Resources.PS_down;
                    break;
                case "picBtn_RE":
                    pic.BackgroundImage = global::ChemistryApp.Properties.Resources.RE_down;
                    break;
                case "picBtn_CE":
                    pic.BackgroundImage = global::ChemistryApp.Properties.Resources.CE_down;
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
                case "picBtn_PS":
                    pic.BackgroundImage = global::ChemistryApp.Properties.Resources.PS_up;
                    break;
                case "picBtn_RE":
                    pic.BackgroundImage = global::ChemistryApp.Properties.Resources.RE_up;
                    break;
                case "picBtn_CE":
                    pic.BackgroundImage = global::ChemistryApp.Properties.Resources.CE_up;
                    break;
                default:
                    break;
            }

        }
        #endregion
    }
}
