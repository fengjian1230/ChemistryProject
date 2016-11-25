using System.Windows.Forms;

namespace ChemistryApp.SecondPage
{
    /// <summary>
    /// 二级界面的内容背景
    /// </summary>
    class SecondPageContentBackGroundPanel : Panel
    {
        #region 字段
        private System.Windows.Forms.Label lab_title_second;
        private System.Windows.Forms.Label lab_secondPlay;
        private System.Windows.Forms.PictureBox pic_play_border;
        private System.Windows.Forms.Label lab_secondType;
        private System.Windows.Forms.PictureBox pic_type_border;
        private System.Windows.Forms.Label lab_secondTitle;
        private System.Windows.Forms.PictureBox pic_titleborder;
        public SecondPageContent pageContent;
        #endregion


        #region 方法
        public SecondPageContentBackGroundPanel()
        {
            this.lab_secondPlay = new System.Windows.Forms.Label();
            this.pic_play_border = new System.Windows.Forms.PictureBox();
            this.lab_secondType = new System.Windows.Forms.Label();
            this.pic_type_border = new System.Windows.Forms.PictureBox();
            this.lab_secondTitle = new System.Windows.Forms.Label();
            this.pic_titleborder = new System.Windows.Forms.PictureBox();
            this.lab_title_second = new System.Windows.Forms.Label();
            this.pageContent = new SecondPageContent();
            InitCompent();
        }

        private void InitCompent()
        {
            // 
            // panel_secondContentBG
            // 
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.pageContent);
            this.Controls.Add(this.lab_secondPlay);
            this.Controls.Add(this.pic_play_border);
            this.Controls.Add(this.lab_secondType);
            this.Controls.Add(this.pic_type_border);
            this.Controls.Add(this.lab_secondTitle);
            this.Controls.Add(this.pic_titleborder);
            this.Controls.Add(this.lab_title_second);
            this.AutoScroll = true;
            this.Location = new System.Drawing.Point(3, 36);
            this.Name = "panel_secondContentBG";
            this.Size = new System.Drawing.Size(810, 424);
          
            this.TabIndex = 23;
            // 
            // lab_secondPlay
            // 
            this.lab_secondPlay.AutoSize = true;
            this.lab_secondPlay.Location = new System.Drawing.Point(710, 77);
            this.lab_secondPlay.Name = "lab_secondPlay";
            this.lab_secondPlay.Size = new System.Drawing.Size(39, 20);
            this.lab_secondPlay.TabIndex = 6;
            this.lab_secondPlay.Text = "预览";
            // 
            // pic_play_border
            // 
            this.pic_play_border.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pic_play_border.Location = new System.Drawing.Point(510, 73);
            this.pic_play_border.Name = "pic_play_border";
            this.pic_play_border.Size = new System.Drawing.Size(290, 28);
            this.pic_play_border.TabIndex = 5;
            this.pic_play_border.TabStop = false;
            // 
            // lab_secondType
            // 
            this.lab_secondType.AutoSize = true;
            this.lab_secondType.Location = new System.Drawing.Point(430, 77);
            this.lab_secondType.Name = "lab_secondType";
            this.lab_secondType.Size = new System.Drawing.Size(39, 20);
            this.lab_secondType.TabIndex = 4;
            this.lab_secondType.Text = "类型";
            // 
            // pic_type_border
            // 
            this.pic_type_border.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pic_type_border.Location = new System.Drawing.Point(399, 73);
            this.pic_type_border.Name = "pic_type_border";
            this.pic_type_border.Size = new System.Drawing.Size(111, 28);
            this.pic_type_border.TabIndex = 3;
            this.pic_type_border.TabStop = false;
            // 
            // lab_secondTitle
            // 
            this.lab_secondTitle.AutoSize = true;
            this.lab_secondTitle.Location = new System.Drawing.Point(172, 77);
            this.lab_secondTitle.Name = "lab_secondTitle";
            this.lab_secondTitle.Size = new System.Drawing.Size(39, 20);
            this.lab_secondTitle.TabIndex = 2;
            this.lab_secondTitle.Text = "标题";
            // 
            // pic_titleborder
            // 
            this.pic_titleborder.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pic_titleborder.Location = new System.Drawing.Point(0, 73);
            this.pic_titleborder.Name = "pic_titleborder";
            this.pic_titleborder.Size = new System.Drawing.Size(413, 28);
            this.pic_titleborder.TabIndex = 1;
            this.pic_titleborder.TabStop = false;
            // 
            // lab_title_second
            // 
            this.lab_title_second.AutoSize = true;
            this.lab_title_second.BackColor = System.Drawing.Color.White;
            this.lab_title_second.Font = new System.Drawing.Font("苹方 中等", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lab_title_second.ForeColor = System.Drawing.Color.DarkRed;
            this.lab_title_second.Location = new System.Drawing.Point(1, 29);
            this.lab_title_second.Name = "lab_title_second";
            this.lab_title_second.Size = new System.Drawing.Size(185, 40);
            this.lab_title_second.TabIndex = 0;
            this.lab_title_second.Text = "从实验学化学";
        }
        #endregion
    }
}
