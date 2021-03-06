﻿using System;
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
    /// 二级页面四个单元的按钮panel
    /// </summary>
    class SecondPageButtonPanle : Panel
    {
        #region 字段
        public System.Windows.Forms.Button btn_four;
        public System.Windows.Forms.Button btn_three;
        public System.Windows.Forms.Button btn_two;
        private System.Windows.Forms.Label lab_title;
        private System.Windows.Forms.PictureBox secondRedLine;
        public System.Windows.Forms.Button btn_one;
        #endregion


        #region 方法
        public SecondPageButtonPanle()
        {

            SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            SetStyle(ControlStyles.UserPaint, true);
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);

            SecondPageManager.GetInstace.Init();
            btn_four = new Button();
            btn_one = new Button();
            btn_three = new Button();
            btn_two = new Button();
            secondRedLine = new PictureBox();
            lab_title = new Label();
            InitCompent();
        }


        private void InitCompent()
        {
            //加入到链表中点击某个按钮变色
            SecondPageManager.GetInstace.partBtnList.Add(btn_one);
            SecondPageManager.GetInstace.partBtnList.Add(btn_two);
            SecondPageManager.GetInstace.partBtnList.Add(btn_three);
            SecondPageManager.GetInstace.partBtnList.Add(btn_four);

            this.Controls.Add(this.secondRedLine);
            this.Controls.Add(this.lab_title);
            this.Controls.Add(this.btn_four);
            this.Controls.Add(this.btn_three);
            this.Controls.Add(this.btn_two);
            this.Controls.Add(this.btn_one);
            this.Location = new System.Drawing.Point(3, 0);
            this.Name = "panel_partBtn";
            this.Size = new System.Drawing.Size(800, 36);
            this.TabIndex = 22;
            // 
            // secondRedLine
            // 
            this.secondRedLine.BackgroundImage = global::ChemistryApp.Properties.Resources.redLine;
            this.secondRedLine.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.secondRedLine.Location = new System.Drawing.Point(-3, 33);
            this.secondRedLine.Name = "secondRedLine";
            this.secondRedLine.Size = new System.Drawing.Size(800, 3);
            this.secondRedLine.TabIndex = 23;
            this.secondRedLine.TabStop = false;
            // 
            // lab_title
            // 
            this.lab_title.AutoSize = true;
            this.lab_title.Font = new System.Drawing.Font("苹方 中等", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lab_title.ForeColor = System.Drawing.Color.DarkRed;
            this.lab_title.Location = new System.Drawing.Point(670, 3);
            this.lab_title.Name = "lab_title";
            this.lab_title.Size = new System.Drawing.Size(127, 33);
            this.lab_title.TabIndex = 25;
            this.lab_title.Text = "高一(上期)";
            // 
            // btn_four
            // 
            this.btn_four.BackgroundImage = global::ChemistryApp.Properties.Resources.btnWhiteBG_up;
            this.btn_four.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_four.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_four.FlatAppearance.BorderSize = 0;
            this.btn_four.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_four.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_four.ForeColor = System.Drawing.Color.DarkRed;
            this.btn_four.Location = new System.Drawing.Point(306, 0);
            this.btn_four.Name = "btn_four";
            this.btn_four.Size = new System.Drawing.Size(92, 36);
            this.btn_four.TabIndex = 24;
            this.btn_four.Text = "四单元";
            this.btn_four.UseVisualStyleBackColor = true;
            // 
            // btn_three
            // 
            this.btn_three.BackgroundImage = global::ChemistryApp.Properties.Resources.btnWhiteBG_up;
            this.btn_three.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_three.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_three.FlatAppearance.BorderSize = 0;
            this.btn_three.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_three.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_three.ForeColor = System.Drawing.Color.DarkRed;
            this.btn_three.Location = new System.Drawing.Point(204, 0);
            this.btn_three.Name = "btn_three";
            this.btn_three.Size = new System.Drawing.Size(92, 36);
            this.btn_three.TabIndex = 23;
            this.btn_three.Text = "三单元";
            this.btn_three.UseVisualStyleBackColor = true;
            // 
            // btn_two
            // 
            this.btn_two.BackgroundImage = global::ChemistryApp.Properties.Resources.btnWhiteBG_up;
            this.btn_two.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_two.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_two.FlatAppearance.BorderSize = 0;
            this.btn_two.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_two.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_two.ForeColor = System.Drawing.Color.DarkRed;
            this.btn_two.Location = new System.Drawing.Point(102, 0);
            this.btn_two.Name = "btn_two";
            this.btn_two.Size = new System.Drawing.Size(92, 36);
            this.btn_two.TabIndex = 22;
            this.btn_two.Text = "二单元";
            this.btn_two.UseVisualStyleBackColor = true;
            // 
            // btn_one
            // 
            this.btn_one.BackgroundImage = global::ChemistryApp.Properties.Resources.btnWhiteBG_up;
            this.btn_one.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_one.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_one.FlatAppearance.BorderSize = 0;
            this.btn_one.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_one.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_one.ForeColor = System.Drawing.Color.DarkRed;
            this.btn_one.Location = new System.Drawing.Point(0, 0);
            this.btn_one.Name = "btn_one";
            this.btn_one.Size = new System.Drawing.Size(92, 36);
            this.btn_one.TabIndex = 21;
            this.btn_one.Text = "一单元";
            this.btn_one.UseVisualStyleBackColor = true;
        }
    }
    #endregion

}
