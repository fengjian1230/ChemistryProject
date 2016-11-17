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
    class ChemicalElementSecondPage : OtherSecondPage
    {
        #region 字段构造函数
        private System.Windows.Forms.PictureBox picBtn_C;
        private System.Windows.Forms.PictureBox picBtn_N;
        private System.Windows.Forms.PictureBox picBtn_Na;
        private System.Windows.Forms.PictureBox picBtn_Cu;
        private System.Windows.Forms.PictureBox picBtn_Fe;
        private System.Windows.Forms.PictureBox picBtn_S;
        private System.Windows.Forms.PictureBox picBtn_Cl;
        private System.Windows.Forms.PictureBox picBtn_Si;
        private System.Windows.Forms.PictureBox picBtn_Al;
        private System.Windows.Forms.PictureBox picBtn_Mg;

        public ChemicalElementSecondPage()
        {
            this.picBtn_C = new PictureBox();
            this.picBtn_N = new System.Windows.Forms.PictureBox();
            this.picBtn_Na = new System.Windows.Forms.PictureBox();
            this.picBtn_Mg = new System.Windows.Forms.PictureBox();
            this.picBtn_Al = new System.Windows.Forms.PictureBox();
            this.picBtn_Cu = new System.Windows.Forms.PictureBox();
            this.picBtn_Fe = new System.Windows.Forms.PictureBox();
            this.picBtn_S = new System.Windows.Forms.PictureBox();
            this.picBtn_Cl = new System.Windows.Forms.PictureBox();
            this.picBtn_Si = new System.Windows.Forms.PictureBox();
            InitCompent();
        }
        #endregion

        #region 初始化
        /// <summary>
        /// 初始化
        /// </summary>
        private void InitCompent()
        {
            base.Controls.Add(this.picBtn_Cu);
            base.Controls.Add(this.picBtn_Fe);
            base.Controls.Add(this.picBtn_S);
            base.Controls.Add(this.picBtn_Cl);
            base.Controls.Add(this.picBtn_Si);
            base.Controls.Add(this.picBtn_Al);
            base.Controls.Add(this.picBtn_Mg);
            base.Controls.Add(this.picBtn_Na);
            base.Controls.Add(this.picBtn_N);
            base.Controls.Add(this.picBtn_C);

            // picBtn_C
            // 
            this.picBtn_C.BackColor = System.Drawing.Color.Transparent;
            this.picBtn_C.BackgroundImage = global::ChemistryApp.Properties.Resources.C_up;
            this.picBtn_C.Location = new System.Drawing.Point(120, 77);
            this.picBtn_C.Name = "picBtn_C";
            this.picBtn_C.Size = new System.Drawing.Size(93, 97);
            this.picBtn_C.TabIndex = 0;
            this.picBtn_C.TabStop = false;
            this.picBtn_C.Cursor = Cursors.Hand;
            this.picBtn_C.MouseEnter += new EventHandler(OnButtonMouseEnter);
            this.picBtn_C.MouseLeave += new EventHandler(OnButtonMouseLeave);

            // 
            // picBtn_N
            // 
            this.picBtn_N.BackColor = System.Drawing.Color.Transparent;
            this.picBtn_N.BackgroundImage = global::ChemistryApp.Properties.Resources.N_up;
            this.picBtn_N.Location = new System.Drawing.Point(243, 77);
            this.picBtn_N.Name = "picBtn_N";
            this.picBtn_N.Size = new System.Drawing.Size(93, 97);
            this.picBtn_N.TabIndex = 1;
            this.picBtn_N.TabStop = false;
            this.picBtn_N.Cursor = Cursors.Hand;
            this.picBtn_N.MouseEnter += new EventHandler(OnButtonMouseEnter);
            this.picBtn_N.MouseLeave += new EventHandler(OnButtonMouseLeave);
            // 
            // picBtn_Na
            // 
            this.picBtn_Na.BackColor = System.Drawing.Color.Transparent;
            this.picBtn_Na.BackgroundImage = global::ChemistryApp.Properties.Resources.Na_up;
            this.picBtn_Na.Location = new System.Drawing.Point(366, 77);
            this.picBtn_Na.Name = "picBtn_Na";
            this.picBtn_Na.Size = new System.Drawing.Size(93, 97);
            this.picBtn_Na.TabIndex = 2;
            this.picBtn_Na.TabStop = false;
            this.picBtn_Na.Cursor = Cursors.Hand;
            this.picBtn_Na.MouseEnter += new EventHandler(OnButtonMouseEnter);
            this.picBtn_Na.MouseLeave += new EventHandler(OnButtonMouseLeave);
            // 
            // picBtn_Mg
            // 
            this.picBtn_Mg.BackColor = System.Drawing.Color.Transparent;
            this.picBtn_Mg.BackgroundImage = global::ChemistryApp.Properties.Resources.Mg_up;
            this.picBtn_Mg.Location = new System.Drawing.Point(489, 77);
            this.picBtn_Mg.Name = "picBtn_Mg";
            this.picBtn_Mg.Size = new System.Drawing.Size(93, 97);
            this.picBtn_Mg.TabIndex = 3;
            this.picBtn_Mg.TabStop = false;
            this.picBtn_Mg.Cursor = Cursors.Hand;
            this.picBtn_Mg.MouseEnter += new EventHandler(OnButtonMouseEnter);
            this.picBtn_Mg.MouseLeave += new EventHandler(OnButtonMouseLeave);
            // 
            // picBtn_Al
            // 
            this.picBtn_Al.BackColor = System.Drawing.Color.Transparent;
            this.picBtn_Al.BackgroundImage = global::ChemistryApp.Properties.Resources.AI_up;
            this.picBtn_Al.Location = new System.Drawing.Point(612, 77);
            this.picBtn_Al.Name = "picBtn_Al";
            this.picBtn_Al.Size = new System.Drawing.Size(93, 97);
            this.picBtn_Al.TabIndex = 4;
            this.picBtn_Al.TabStop = false;
            this.picBtn_Al.Cursor = Cursors.Hand;
            this.picBtn_Al.MouseEnter += new EventHandler(OnButtonMouseEnter);
            this.picBtn_Al.MouseLeave += new EventHandler(OnButtonMouseLeave);
            // 
            // picBtn_Cu
            // 
            this.picBtn_Cu.BackColor = System.Drawing.Color.Transparent;
            this.picBtn_Cu.BackgroundImage = global::ChemistryApp.Properties.Resources.Cu_up;
            this.picBtn_Cu.Location = new System.Drawing.Point(612, 244);
            this.picBtn_Cu.Name = "picBtn_Cu";
            this.picBtn_Cu.Size = new System.Drawing.Size(93, 97);
            this.picBtn_Cu.TabIndex = 9;
            this.picBtn_Cu.TabStop = false;
            this.picBtn_Cu.Cursor = Cursors.Hand;
            this.picBtn_Cu.MouseEnter += new EventHandler(OnButtonMouseEnter);
            this.picBtn_Cu.MouseLeave += new EventHandler(OnButtonMouseLeave);
            // 
            // picBtn_Fe
            // 
            this.picBtn_Fe.BackColor = System.Drawing.Color.Transparent;
            this.picBtn_Fe.BackgroundImage = global::ChemistryApp.Properties.Resources.Fe_up;
            this.picBtn_Fe.Location = new System.Drawing.Point(489, 244);
            this.picBtn_Fe.Name = "picBtn_Fe";
            this.picBtn_Fe.Size = new System.Drawing.Size(93, 97);
            this.picBtn_Fe.TabIndex = 8;
            this.picBtn_Fe.TabStop = false;
            this.picBtn_Fe.Cursor = Cursors.Hand;
            this.picBtn_Fe.MouseEnter += new EventHandler(OnButtonMouseEnter);
            this.picBtn_Fe.MouseLeave += new EventHandler(OnButtonMouseLeave);
            // 
            // picBtn_S
            // 
            this.picBtn_S.BackColor = System.Drawing.Color.Transparent;
            this.picBtn_S.BackgroundImage = global::ChemistryApp.Properties.Resources.S_up;
            this.picBtn_S.Location = new System.Drawing.Point(366, 244);
            this.picBtn_S.Name = "picBtn_S";
            this.picBtn_S.Size = new System.Drawing.Size(93, 97);
            this.picBtn_S.TabIndex = 7;
            this.picBtn_S.TabStop = false;
            this.picBtn_S.Cursor = Cursors.Hand;
            this.picBtn_S.MouseEnter += new EventHandler(OnButtonMouseEnter);
            this.picBtn_S.MouseLeave += new EventHandler(OnButtonMouseLeave);
            // 
            // picBtn_Cl
            // 
            this.picBtn_Cl.BackColor = System.Drawing.Color.Transparent;
            this.picBtn_Cl.BackgroundImage = global::ChemistryApp.Properties.Resources.CI_up;
            this.picBtn_Cl.Location = new System.Drawing.Point(243, 244);
            this.picBtn_Cl.Name = "picBtn_Cl";
            this.picBtn_Cl.Size = new System.Drawing.Size(93, 97);
            this.picBtn_Cl.TabIndex = 6;
            this.picBtn_Cl.TabStop = false;
            this.picBtn_Cl.Cursor = Cursors.Hand;
            this.picBtn_Cl.MouseEnter += new EventHandler(OnButtonMouseEnter);
            this.picBtn_Cl.MouseLeave += new EventHandler(OnButtonMouseLeave);
            // 
            // picBtn_Si
            // 
            this.picBtn_Si.BackColor = System.Drawing.Color.Transparent;
            this.picBtn_Si.BackgroundImage = global::ChemistryApp.Properties.Resources.Si_up;
            this.picBtn_Si.Location = new System.Drawing.Point(120, 244);
            this.picBtn_Si.Name = "picBtn_Si";
            this.picBtn_Si.Size = new System.Drawing.Size(93, 97);
            this.picBtn_Si.TabIndex = 5;
            this.picBtn_Si.TabStop = false;
            this.picBtn_Si.Cursor = Cursors.Hand;
            this.picBtn_Si.MouseEnter += new EventHandler(OnButtonMouseEnter);
            this.picBtn_Si.MouseLeave += new EventHandler(OnButtonMouseLeave);
        }
        #endregion

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
                case "picBtn_C":
                    pic.BackgroundImage = global::ChemistryApp.Properties.Resources.C_down;
                    break;
                case "picBtn_N":
                    pic.BackgroundImage = global::ChemistryApp.Properties.Resources.N_down;
                    break;
                case "picBtn_Na":
                    pic.BackgroundImage = global::ChemistryApp.Properties.Resources.Na_down;
                    break;
                case "picBtn_Mg":
                    pic.BackgroundImage = global::ChemistryApp.Properties.Resources.Mg_down;
                    break;
                case "picBtn_Al":
                    pic.BackgroundImage = global::ChemistryApp.Properties.Resources.AI_down;
                    break;
                case "picBtn_Cu":
                    pic.BackgroundImage = global::ChemistryApp.Properties.Resources.Cu_down;
                    break;
                case "picBtn_Fe":
                    pic.BackgroundImage = global::ChemistryApp.Properties.Resources.Fe_down;
                    break;
                case "picBtn_S":
                    pic.BackgroundImage = global::ChemistryApp.Properties.Resources.S_down;
                    break;
                case "picBtn_Cl":
                    pic.BackgroundImage = global::ChemistryApp.Properties.Resources.CI_down;
                    break;
                case "picBtn_Si":
                    pic.BackgroundImage = global::ChemistryApp.Properties.Resources.Si_down;
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
                case "picBtn_C":
                    pic.BackgroundImage = global::ChemistryApp.Properties.Resources.C_up;
                    break;
                case "picBtn_N":
                    pic.BackgroundImage = global::ChemistryApp.Properties.Resources.N_up;
                    break;
                case "picBtn_Na":
                    pic.BackgroundImage = global::ChemistryApp.Properties.Resources.Na_up;
                    break;
                case "picBtn_Mg":
                    pic.BackgroundImage = global::ChemistryApp.Properties.Resources.Mg_up;
                    break;
                case "picBtn_Al":
                    pic.BackgroundImage = global::ChemistryApp.Properties.Resources.AI_up;
                    break;
                case "picBtn_Cu":
                    pic.BackgroundImage = global::ChemistryApp.Properties.Resources.Cu_up;
                    break;
                case "picBtn_Fe":
                    pic.BackgroundImage = global::ChemistryApp.Properties.Resources.Fe_up;
                    break;
                case "picBtn_S":
                    pic.BackgroundImage = global::ChemistryApp.Properties.Resources.S_up;
                    break;
                case "picBtn_Cl":
                    pic.BackgroundImage = global::ChemistryApp.Properties.Resources.CI_up;
                    break;
                case "picBtn_Si":
                    pic.BackgroundImage = global::ChemistryApp.Properties.Resources.Si_up;
                    break;
                default:
                    break;
            }

        }
        #endregion
    }
}
