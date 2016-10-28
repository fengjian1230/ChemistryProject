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
            this.textBox1 = new System.Windows.Forms.TextBox();
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_title)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_classSearch)).BeginInit();
            this.LeftPlane.SuspendLayout();
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
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Window;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("苹方 中等", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox1.Location = new System.Drawing.Point(249, 121);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(485, 35);
            this.textBox1.TabIndex = 2;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            this.pic_title.Location = new System.Drawing.Point(320, 0);
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
            this.btn_shrink.Location = new System.Drawing.Point(352, 0);
            this.btn_shrink.Name = "btn_shrink";
            this.btn_shrink.Padding = new System.Windows.Forms.Padding(0, 50, 0, 0);
            this.btn_shrink.Size = new System.Drawing.Size(22, 728);
            this.btn_shrink.TabIndex = 12;
            this.btn_shrink.UseVisualStyleBackColor = false;
            this.btn_shrink.Click += new System.EventHandler(this.button1_Click_3);
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
            this.LeftPlane.Controls.Add(this.btn_classSearch);
            this.LeftPlane.Controls.Add(this.textBox2);
            this.LeftPlane.Controls.Add(this.pic_classSearch);
            this.LeftPlane.Dock = System.Windows.Forms.DockStyle.Left;
            this.LeftPlane.Location = new System.Drawing.Point(0, 0);
            this.LeftPlane.Margin = new System.Windows.Forms.Padding(0);
            this.LeftPlane.Name = "LeftPlane";
            this.LeftPlane.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.LeftPlane.Size = new System.Drawing.Size(320, 728);
            this.LeftPlane.TabIndex = 8;
            this.LeftPlane.Tag = "1";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ChemistryApp.Properties.Resources.BG;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1006, 728);
            this.Controls.Add(this.btn_shrink);
            this.Controls.Add(this.pic_title);
            this.Controls.Add(this.LeftPlane);
            this.Controls.Add(this.btn_ExperlmentalPlatform);
            this.Controls.Add(this.btn_ClassroomTeaching);
            this.Controls.Add(this.btn_ChemicalElement);
            this.Controls.Add(this.btn_KnowledgeReview);
            this.Controls.Add(this.textBox1);
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
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBox1;
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
    }
}

