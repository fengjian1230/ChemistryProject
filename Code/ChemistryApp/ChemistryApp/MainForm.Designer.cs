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
            this.LeftPlaneTimer = new System.Windows.Forms.Timer(this.components);
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.btn_classSearch = new System.Windows.Forms.Button();
            this.panel_item = new System.Windows.Forms.Panel();
            this.LeftPlane = new System.Windows.Forms.Panel();
            this.panle_shrink = new System.Windows.Forms.Panel();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.btn_ExperlmentalPlatform = new System.Windows.Forms.PictureBox();
            this.btn_shrink = new System.Windows.Forms.PictureBox();
            this.pic_title = new System.Windows.Forms.PictureBox();
            this.pic_classSearch = new System.Windows.Forms.PictureBox();
            this.btn_MindMap = new System.Windows.Forms.PictureBox();
            this.btn_KnowledgeReview = new System.Windows.Forms.PictureBox();
            this.btn_ClassroomTeaching = new System.Windows.Forms.PictureBox();
            this.btn_ChemicalElement = new System.Windows.Forms.PictureBox();
            this.btn_VideoSource = new System.Windows.Forms.PictureBox();
            this.LeftPlane.SuspendLayout();
            this.panle_shrink.SuspendLayout();
            this.MainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_ExperlmentalPlatform)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_shrink)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_title)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_classSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_MindMap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_KnowledgeReview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_ClassroomTeaching)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_ChemicalElement)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_VideoSource)).BeginInit();
            this.SuspendLayout();
            // 
            // LeftPlaneTimer
            // 
            this.LeftPlaneTimer.Interval = 10;
            this.LeftPlaneTimer.Tick += new System.EventHandler(this.LeftPlaneTimer_Tick);
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
            // panel_item
            // 
            this.panel_item.AutoScroll = true;
            this.panel_item.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel_item.BackColor = System.Drawing.Color.White;
            this.panel_item.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel_item.ForeColor = System.Drawing.Color.Black;
            this.panel_item.ImeMode = System.Windows.Forms.ImeMode.On;
            this.panel_item.Location = new System.Drawing.Point(0, 112);
            this.panel_item.Name = "panel_item";
            this.panel_item.Size = new System.Drawing.Size(320, 516);
            this.panel_item.TabIndex = 17;
            // 
            // LeftPlane
            // 
            this.LeftPlane.AllowDrop = true;
            this.LeftPlane.BackColor = System.Drawing.Color.Transparent;
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
            this.LeftPlane.Size = new System.Drawing.Size(0, 768);
            this.LeftPlane.TabIndex = 8;
            this.LeftPlane.Tag = "1";
            // 
            // panle_shrink
            // 
            this.panle_shrink.BackColor = System.Drawing.Color.White;
            this.panle_shrink.Controls.Add(this.btn_shrink);
            this.panle_shrink.Controls.Add(this.pic_title);
            this.panle_shrink.Dock = System.Windows.Forms.DockStyle.Left;
            this.panle_shrink.Location = new System.Drawing.Point(0, 0);
            this.panle_shrink.Name = "panle_shrink";
            this.panle_shrink.Size = new System.Drawing.Size(0, 768);
            this.panle_shrink.TabIndex = 17;
            // 
            // MainPanel
            // 
            this.MainPanel.BackgroundImage = global::ChemistryApp.Properties.Resources._1;
            this.MainPanel.Controls.Add(this.btn_ChemicalElement);
            this.MainPanel.Controls.Add(this.btn_VideoSource);
            this.MainPanel.Controls.Add(this.btn_ClassroomTeaching);
            this.MainPanel.Controls.Add(this.btn_KnowledgeReview);
            this.MainPanel.Controls.Add(this.btn_MindMap);
            this.MainPanel.Controls.Add(this.btn_ExperlmentalPlatform);
            this.MainPanel.Location = new System.Drawing.Point(0, 0);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(1027, 768);
            this.MainPanel.TabIndex = 18;
            // 
            // btn_ExperlmentalPlatform
            // 
            this.btn_ExperlmentalPlatform.BackColor = System.Drawing.Color.Transparent;
            this.btn_ExperlmentalPlatform.BackgroundImage = global::ChemistryApp.Properties.Resources.btn_011;
            this.btn_ExperlmentalPlatform.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_ExperlmentalPlatform.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_ExperlmentalPlatform.Location = new System.Drawing.Point(240, 176);
            this.btn_ExperlmentalPlatform.Name = "btn_ExperlmentalPlatform";
            this.btn_ExperlmentalPlatform.Size = new System.Drawing.Size(175, 226);
            this.btn_ExperlmentalPlatform.TabIndex = 0;
            this.btn_ExperlmentalPlatform.TabStop = false;
            // 
            // btn_shrink
            // 
            this.btn_shrink.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_shrink.Location = new System.Drawing.Point(31, 330);
            this.btn_shrink.Name = "btn_shrink";
            this.btn_shrink.Size = new System.Drawing.Size(23, 70);
            this.btn_shrink.TabIndex = 1;
            this.btn_shrink.TabStop = false;
            this.btn_shrink.Click += new System.EventHandler(this.BtnShrink_Click);
            // 
            // pic_title
            // 
            this.pic_title.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pic_title.Location = new System.Drawing.Point(0, 47);
            this.pic_title.Name = "pic_title";
            this.pic_title.Size = new System.Drawing.Size(35, 626);
            this.pic_title.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_title.TabIndex = 0;
            this.pic_title.TabStop = false;
            // 
            // pic_classSearch
            // 
            this.pic_classSearch.InitialImage = null;
            this.pic_classSearch.Location = new System.Drawing.Point(23, 70);
            this.pic_classSearch.Name = "pic_classSearch";
            this.pic_classSearch.Size = new System.Drawing.Size(270, 36);
            this.pic_classSearch.TabIndex = 0;
            this.pic_classSearch.TabStop = false;
            // 
            // btn_MindMap
            // 
            this.btn_MindMap.BackColor = System.Drawing.Color.Transparent;
            this.btn_MindMap.BackgroundImage = global::ChemistryApp.Properties.Resources.btn_021;
            this.btn_MindMap.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_MindMap.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_MindMap.Location = new System.Drawing.Point(425, 176);
            this.btn_MindMap.Name = "btn_MindMap";
            this.btn_MindMap.Size = new System.Drawing.Size(175, 226);
            this.btn_MindMap.TabIndex = 1;
            this.btn_MindMap.TabStop = false;
            // 
            // btn_KnowledgeReview
            // 
            this.btn_KnowledgeReview.BackColor = System.Drawing.Color.Transparent;
            this.btn_KnowledgeReview.BackgroundImage = global::ChemistryApp.Properties.Resources.btn_031;
            this.btn_KnowledgeReview.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_KnowledgeReview.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_KnowledgeReview.Location = new System.Drawing.Point(609, 176);
            this.btn_KnowledgeReview.Name = "btn_KnowledgeReview";
            this.btn_KnowledgeReview.Size = new System.Drawing.Size(175, 226);
            this.btn_KnowledgeReview.TabIndex = 2;
            this.btn_KnowledgeReview.TabStop = false;
            // 
            // btn_ClassroomTeaching
            // 
            this.btn_ClassroomTeaching.BackColor = System.Drawing.Color.Transparent;
            this.btn_ClassroomTeaching.BackgroundImage = global::ChemistryApp.Properties.Resources.btn_041;
            this.btn_ClassroomTeaching.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_ClassroomTeaching.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_ClassroomTeaching.Location = new System.Drawing.Point(240, 408);
            this.btn_ClassroomTeaching.Name = "btn_ClassroomTeaching";
            this.btn_ClassroomTeaching.Size = new System.Drawing.Size(175, 226);
            this.btn_ClassroomTeaching.TabIndex = 3;
            this.btn_ClassroomTeaching.TabStop = false;
            // 
            // btn_ChemicalElement
            // 
            this.btn_ChemicalElement.BackColor = System.Drawing.Color.Transparent;
            this.btn_ChemicalElement.BackgroundImage = global::ChemistryApp.Properties.Resources.btn_061;
            this.btn_ChemicalElement.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_ChemicalElement.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_ChemicalElement.Location = new System.Drawing.Point(609, 408);
            this.btn_ChemicalElement.Name = "btn_ChemicalElement";
            this.btn_ChemicalElement.Size = new System.Drawing.Size(175, 226);
            this.btn_ChemicalElement.TabIndex = 5;
            this.btn_ChemicalElement.TabStop = false;
            // 
            // btn_VideoSource
            // 
            this.btn_VideoSource.BackColor = System.Drawing.Color.Transparent;
            this.btn_VideoSource.BackgroundImage = global::ChemistryApp.Properties.Resources.btn_051;
            this.btn_VideoSource.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_VideoSource.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_VideoSource.Location = new System.Drawing.Point(425, 408);
            this.btn_VideoSource.Name = "btn_VideoSource";
            this.btn_VideoSource.Size = new System.Drawing.Size(175, 226);
            this.btn_VideoSource.TabIndex = 4;
            this.btn_VideoSource.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1024, 768);
            this.Controls.Add(this.MainPanel);
            this.Controls.Add(this.panle_shrink);
            this.Controls.Add(this.LeftPlane);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "App";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.LeftPlane.ResumeLayout(false);
            this.LeftPlane.PerformLayout();
            this.panle_shrink.ResumeLayout(false);
            this.MainPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btn_ExperlmentalPlatform)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_shrink)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_title)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_classSearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_MindMap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_KnowledgeReview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_ClassroomTeaching)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_ChemicalElement)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_VideoSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer LeftPlaneTimer;
        private System.Windows.Forms.PictureBox pic_classSearch;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button btn_classSearch;
        private System.Windows.Forms.Panel panel_item;
        private System.Windows.Forms.Panel LeftPlane;
        private System.Windows.Forms.PictureBox pic_title;
        private System.Windows.Forms.PictureBox btn_shrink;
        private System.Windows.Forms.Panel panle_shrink;
        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.PictureBox btn_ExperlmentalPlatform;
        private System.Windows.Forms.PictureBox btn_ChemicalElement;
        private System.Windows.Forms.PictureBox btn_ClassroomTeaching;
        private System.Windows.Forms.PictureBox btn_KnowledgeReview;
        private System.Windows.Forms.PictureBox btn_MindMap;
        private System.Windows.Forms.PictureBox btn_VideoSource;
    }
}

