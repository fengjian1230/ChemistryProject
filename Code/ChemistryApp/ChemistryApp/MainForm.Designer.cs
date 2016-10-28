namespace ChemistryApp
{
    partial class MainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txt_search = new System.Windows.Forms.TextBox();
            this.btn_KnowledgeReview = new System.Windows.Forms.Button();
            this.btn_ChemicalElement = new System.Windows.Forms.Button();
            this.btn_ClassroomTeaching = new System.Windows.Forms.Button();
            this.btn_ExperlmentalPlatform = new System.Windows.Forms.Button();
            this.LeftPlaneTimer = new System.Windows.Forms.Timer(this.components);
            this.pic_title = new System.Windows.Forms.PictureBox();
            this.btn_shrink = new System.Windows.Forms.Button();
            this.pic_classSearch = new System.Windows.Forms.PictureBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.btn_classSearch = new System.Windows.Forms.Button();
            this.LeftPlane = new System.Windows.Forms.Panel();
            this.btn_search = new System.Windows.Forms.Button();
            this.listBox_searchRuslut = new System.Windows.Forms.ListBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel_item = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_title)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_classSearch)).BeginInit();
            this.LeftPlane.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::ChemistryApp.Properties.Resources.search;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Location = new System.Drawing.Point(236, 117);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(550, 43);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // txt_search
            // 
            this.txt_search.BackColor = System.Drawing.SystemColors.Window;
            this.txt_search.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_search.CausesValidation = false;
            this.txt_search.Font = new System.Drawing.Font("苹方 中等", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt_search.Location = new System.Drawing.Point(249, 121);
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(485, 35);
            this.txt_search.TabIndex = 2;
            this.txt_search.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_search.TextChanged += new System.EventHandler(this.TextSearch_TextChanged);
            this.txt_search.Enter += new System.EventHandler(this.txt_search_Enter);
            this.txt_search.Leave += new System.EventHandler(this.txt_search_Leave);
            // 
            // btn_KnowledgeReview
            // 
            this.btn_KnowledgeReview.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_KnowledgeReview.BackColor = System.Drawing.Color.Black;
            this.btn_KnowledgeReview.BackgroundImage = global::ChemistryApp.Properties.Resources.btn_01;
            this.btn_KnowledgeReview.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_KnowledgeReview.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_KnowledgeReview.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_KnowledgeReview.FlatAppearance.BorderSize = 0;
            this.btn_KnowledgeReview.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.WindowText;
            this.btn_KnowledgeReview.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.btn_KnowledgeReview.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_KnowledgeReview.ForeColor = System.Drawing.SystemColors.Window;
            this.btn_KnowledgeReview.Location = new System.Drawing.Point(36, 263);
            this.btn_KnowledgeReview.Name = "btn_KnowledgeReview";
            this.btn_KnowledgeReview.Size = new System.Drawing.Size(229, 295);
            this.btn_KnowledgeReview.TabIndex = 3;
            this.btn_KnowledgeReview.UseVisualStyleBackColor = false;
            this.btn_KnowledgeReview.Click += new System.EventHandler(this.btn_KnowledgeReview_Click);
            // 
            // btn_ChemicalElement
            // 
            this.btn_ChemicalElement.BackgroundImage = global::ChemistryApp.Properties.Resources.btn_02;
            this.btn_ChemicalElement.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_ChemicalElement.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_ChemicalElement.FlatAppearance.BorderSize = 0;
            this.btn_ChemicalElement.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btn_ChemicalElement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ChemicalElement.Location = new System.Drawing.Point(278, 263);
            this.btn_ChemicalElement.Name = "btn_ChemicalElement";
            this.btn_ChemicalElement.Size = new System.Drawing.Size(229, 295);
            this.btn_ChemicalElement.TabIndex = 4;
            this.btn_ChemicalElement.UseVisualStyleBackColor = true;
            this.btn_ChemicalElement.Click += new System.EventHandler(this.btn_ChemicalElement_Click);
            // 
            // btn_ClassroomTeaching
            // 
            this.btn_ClassroomTeaching.BackgroundImage = global::ChemistryApp.Properties.Resources.btn_03;
            this.btn_ClassroomTeaching.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_ClassroomTeaching.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_ClassroomTeaching.FlatAppearance.BorderSize = 0;
            this.btn_ClassroomTeaching.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btn_ClassroomTeaching.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ClassroomTeaching.Location = new System.Drawing.Point(518, 263);
            this.btn_ClassroomTeaching.Name = "btn_ClassroomTeaching";
            this.btn_ClassroomTeaching.Size = new System.Drawing.Size(229, 295);
            this.btn_ClassroomTeaching.TabIndex = 5;
            this.btn_ClassroomTeaching.UseVisualStyleBackColor = true;
            this.btn_ClassroomTeaching.Click += new System.EventHandler(this.btn_ClassroomTeaching_Click);
            // 
            // btn_ExperlmentalPlatform
            // 
            this.btn_ExperlmentalPlatform.BackgroundImage = global::ChemistryApp.Properties.Resources.btn_04;
            this.btn_ExperlmentalPlatform.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_ExperlmentalPlatform.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_ExperlmentalPlatform.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_ExperlmentalPlatform.FlatAppearance.BorderSize = 0;
            this.btn_ExperlmentalPlatform.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btn_ExperlmentalPlatform.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ExperlmentalPlatform.Location = new System.Drawing.Point(759, 264);
            this.btn_ExperlmentalPlatform.Name = "btn_ExperlmentalPlatform";
            this.btn_ExperlmentalPlatform.Size = new System.Drawing.Size(229, 295);
            this.btn_ExperlmentalPlatform.TabIndex = 6;
            this.btn_ExperlmentalPlatform.UseVisualStyleBackColor = true;
            this.btn_ExperlmentalPlatform.Click += new System.EventHandler(this.btn_ExperlmentalPlatform_Click);
            // 
            // LeftPlaneTimer
            // 
            this.LeftPlaneTimer.Interval = 10;
            this.LeftPlaneTimer.Tick += new System.EventHandler(this.LeftPlaneTimer_Tick);
            // 
            // pic_title
            // 
            this.pic_title.BackColor = System.Drawing.Color.Transparent;
            this.pic_title.Dock = System.Windows.Forms.DockStyle.Left;
            this.pic_title.Image = global::ChemistryApp.Properties.Resources.title;
            this.pic_title.Location = new System.Drawing.Point(0, 0);
            this.pic_title.Name = "pic_title";
            this.pic_title.Padding = new System.Windows.Forms.Padding(0, 50, 0, 0);
            this.pic_title.Size = new System.Drawing.Size(32, 728);
            this.pic_title.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pic_title.TabIndex = 10;
            this.pic_title.TabStop = false;
            // 
            // btn_shrink
            // 
            this.btn_shrink.BackColor = System.Drawing.Color.Transparent;
            this.btn_shrink.BackgroundImage = global::ChemistryApp.Properties.Resources.btn_right;
            this.btn_shrink.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_shrink.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_shrink.FlatAppearance.BorderSize = 0;
            this.btn_shrink.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_shrink.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_shrink.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_shrink.ForeColor = System.Drawing.Color.Transparent;
            this.btn_shrink.Location = new System.Drawing.Point(32, 0);
            this.btn_shrink.Name = "btn_shrink";
            this.btn_shrink.Padding = new System.Windows.Forms.Padding(0, 50, 0, 0);
            this.btn_shrink.Size = new System.Drawing.Size(22, 728);
            this.btn_shrink.TabIndex = 12;
            this.btn_shrink.UseVisualStyleBackColor = false;
            this.btn_shrink.Click += new System.EventHandler(this.BtnShrink_Click);
            // 
            // pic_classSearch
            // 
            this.pic_classSearch.BackgroundImage = global::ChemistryApp.Properties.Resources.classSearch;
            this.pic_classSearch.InitialImage = null;
            this.pic_classSearch.Location = new System.Drawing.Point(23, 70);
            this.pic_classSearch.Name = "pic_classSearch";
            this.pic_classSearch.Size = new System.Drawing.Size(270, 36);
            this.pic_classSearch.TabIndex = 0;
            this.pic_classSearch.TabStop = false;
            // 
            // textBox2
            // 
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Font = new System.Drawing.Font("苹方 中等", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox2.Location = new System.Drawing.Point(36, 75);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(203, 26);
            this.textBox2.TabIndex = 1;
            // 
            // btn_classSearch
            // 
            this.btn_classSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_classSearch.FlatAppearance.BorderSize = 0;
            this.btn_classSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_classSearch.Location = new System.Drawing.Point(257, 77);
            this.btn_classSearch.Name = "btn_classSearch";
            this.btn_classSearch.Size = new System.Drawing.Size(20, 20);
            this.btn_classSearch.TabIndex = 2;
            this.btn_classSearch.UseVisualStyleBackColor = true;
            // 
            // LeftPlane
            // 
            this.LeftPlane.AllowDrop = true;
            this.LeftPlane.BackColor = System.Drawing.Color.Transparent;
            this.LeftPlane.BackgroundImage = global::ChemistryApp.Properties.Resources.planeBG1;
            this.LeftPlane.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.LeftPlane.Controls.Add(this.panel_item);
            this.LeftPlane.Controls.Add(this.btn_classSearch);
            this.LeftPlane.Controls.Add(this.textBox2);
            this.LeftPlane.Controls.Add(this.pic_classSearch);
            this.LeftPlane.Dock = System.Windows.Forms.DockStyle.Left;
            this.LeftPlane.Location = new System.Drawing.Point(0, 0);
            this.LeftPlane.Margin = new System.Windows.Forms.Padding(0);
            this.LeftPlane.Name = "LeftPlane";
            this.LeftPlane.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.LeftPlane.Size = new System.Drawing.Size(0, 728);
            this.LeftPlane.TabIndex = 8;
            this.LeftPlane.Tag = "1";
            // 
            // btn_search
            // 
            this.btn_search.BackgroundImage = global::ChemistryApp.Properties.Resources.btn_search;
            this.btn_search.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_search.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_search.FlatAppearance.BorderSize = 0;
            this.btn_search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_search.ForeColor = System.Drawing.Color.Transparent;
            this.btn_search.Location = new System.Drawing.Point(738, 118);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(30, 41);
            this.btn_search.TabIndex = 13;
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // listBox_searchRuslut
            // 
            this.listBox_searchRuslut.FormattingEnabled = true;
            this.listBox_searchRuslut.ItemHeight = 15;
            this.listBox_searchRuslut.Location = new System.Drawing.Point(236, 162);
            this.listBox_searchRuslut.Name = "listBox_searchRuslut";
            this.listBox_searchRuslut.Size = new System.Drawing.Size(550, 4);
            this.listBox_searchRuslut.TabIndex = 14;
            this.listBox_searchRuslut.Visible = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::ChemistryApp.Properties.Resources._1_03;
            this.pictureBox5.Location = new System.Drawing.Point(4, 8);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(19, 21);
            this.pictureBox5.TabIndex = 0;
            this.pictureBox5.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label8.Font = new System.Drawing.Font("苹方 中等", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label8.Location = new System.Drawing.Point(22, 7);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 21);
            this.label8.TabIndex = 1;
            this.label8.Text = "置顶";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label7.Font = new System.Drawing.Font("苹方 中等", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.Location = new System.Drawing.Point(239, 7);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 21);
            this.label7.TabIndex = 2;
            this.label7.Text = "展开";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::ChemistryApp.Properties.Resources._1_07;
            this.pictureBox4.Location = new System.Drawing.Point(19, 46);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(57, 64);
            this.pictureBox4.TabIndex = 3;
            this.pictureBox4.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("苹方 中等", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(86, 41);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 34);
            this.label6.TabIndex = 4;
            this.label6.Text = "课时一";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("苹方 中等", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(83, 88);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(164, 18);
            this.label5.TabIndex = 5;
            this.label5.Text = "（备注：星期一要讲的课）";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.BackgroundImage = global::ChemistryApp.Properties.Resources.myLessonItemBG;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.pictureBox4);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.pictureBox5);
            this.panel2.Font = new System.Drawing.Font("苹方 特粗", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.panel2.Location = new System.Drawing.Point(403, 26);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(279, 140);
            this.panel2.TabIndex = 16;
            this.panel2.Visible = false;
            // 
            // panel_item
            // 
            this.panel_item.AutoScroll = true;
            this.panel_item.Location = new System.Drawing.Point(0, 112);
            this.panel_item.Name = "panel_item";
            this.panel_item.Size = new System.Drawing.Size(320, 516);
            this.panel_item.TabIndex = 17;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ChemistryApp.Properties.Resources.BG;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1006, 728);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.listBox_searchRuslut);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.btn_shrink);
            this.Controls.Add(this.pic_title);
            this.Controls.Add(this.LeftPlane);
            this.Controls.Add(this.btn_ExperlmentalPlatform);
            this.Controls.Add(this.btn_ClassroomTeaching);
            this.Controls.Add(this.btn_ChemicalElement);
            this.Controls.Add(this.btn_KnowledgeReview);
            this.Controls.Add(this.txt_search);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_title)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_classSearch)).EndInit();
            this.LeftPlane.ResumeLayout(false);
            this.LeftPlane.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txt_search;
        private System.Windows.Forms.Button btn_KnowledgeReview;
        private System.Windows.Forms.Button btn_ChemicalElement;
        private System.Windows.Forms.Button btn_ClassroomTeaching;
        private System.Windows.Forms.Button btn_ExperlmentalPlatform;
        private System.Windows.Forms.Timer LeftPlaneTimer;
        private System.Windows.Forms.PictureBox pic_title;
        private System.Windows.Forms.Button btn_shrink;
        private System.Windows.Forms.PictureBox pic_classSearch;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button btn_classSearch;
        private System.Windows.Forms.Panel LeftPlane;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.ListBox listBox_searchRuslut;
        private System.Windows.Forms.Panel panel_item;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox pictureBox5;
    }
}

