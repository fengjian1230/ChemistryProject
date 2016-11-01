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
            this.btn_classSearch = new System.Windows.Forms.Button();
            this.panel_item = new System.Windows.Forms.Panel();
            this.LeftPlane = new System.Windows.Forms.Panel();
            this.panle_shrink = new System.Windows.Forms.Panel();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.txt_search = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pic_titleBG = new System.Windows.Forms.PictureBox();
            this.panel_classListBG = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.txt_classListSerch = new System.Windows.Forms.TextBox();
            this.pic_classListSearchBG = new System.Windows.Forms.PictureBox();
            this.tab_classList = new System.Windows.Forms.TabControl();
            this.tab_caogao = new System.Windows.Forms.TabPage();
            this.tab_wancheng = new System.Windows.Forms.TabPage();
            this.pic_close = new System.Windows.Forms.PictureBox();
            this.pic_max = new System.Windows.Forms.PictureBox();
            this.pic_min = new System.Windows.Forms.PictureBox();
            this.btn_search = new System.Windows.Forms.Button();
            this.pic_searchBG = new System.Windows.Forms.PictureBox();
            this.btn_ChemicalElement = new System.Windows.Forms.PictureBox();
            this.btn_VideoSource = new System.Windows.Forms.PictureBox();
            this.btn_ClassroomTeaching = new System.Windows.Forms.PictureBox();
            this.btn_KnowledgeReview = new System.Windows.Forms.PictureBox();
            this.btn_MindMap = new System.Windows.Forms.PictureBox();
            this.btn_ExperlmentalPlatform = new System.Windows.Forms.PictureBox();
            this.btn_shrink = new System.Windows.Forms.PictureBox();
            this.pic_title = new System.Windows.Forms.PictureBox();
            this.pic_classSearch = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel_Left = new System.Windows.Forms.Panel();
            this.LeftPlane.SuspendLayout();
            this.panle_shrink.SuspendLayout();
            this.MainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_titleBG)).BeginInit();
            this.panel_classListBG.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_classListSearchBG)).BeginInit();
            this.tab_classList.SuspendLayout();
            this.tab_caogao.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_close)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_max)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_min)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_searchBG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_ChemicalElement)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_VideoSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_ClassroomTeaching)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_KnowledgeReview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_MindMap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_ExperlmentalPlatform)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_shrink)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_title)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_classSearch)).BeginInit();
            this.SuspendLayout();
            // 
            // LeftPlaneTimer
            // 
            this.LeftPlaneTimer.Interval = 10;
            this.LeftPlaneTimer.Tick += new System.EventHandler(this.LeftPlaneTimer_Tick);
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
            this.MainPanel.BackColor = System.Drawing.Color.Transparent;
            this.MainPanel.Controls.Add(this.panel1);
            this.MainPanel.Controls.Add(this.pictureBox1);
            this.MainPanel.Controls.Add(this.pic_titleBG);
            this.MainPanel.Controls.Add(this.panel_classListBG);
            this.MainPanel.Controls.Add(this.pic_close);
            this.MainPanel.Controls.Add(this.pic_max);
            this.MainPanel.Controls.Add(this.pic_min);
            this.MainPanel.Controls.Add(this.btn_search);
            this.MainPanel.Controls.Add(this.txt_search);
            this.MainPanel.Controls.Add(this.pic_searchBG);
            this.MainPanel.Controls.Add(this.btn_ChemicalElement);
            this.MainPanel.Controls.Add(this.btn_VideoSource);
            this.MainPanel.Controls.Add(this.btn_ClassroomTeaching);
            this.MainPanel.Controls.Add(this.btn_KnowledgeReview);
            this.MainPanel.Controls.Add(this.btn_MindMap);
            this.MainPanel.Controls.Add(this.btn_ExperlmentalPlatform);
            this.MainPanel.Location = new System.Drawing.Point(3, 0);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(1027, 768);
            this.MainPanel.TabIndex = 18;
            // 
            // txt_search
            // 
            this.txt_search.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_search.Font = new System.Drawing.Font("苹方 常规", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt_search.ForeColor = System.Drawing.Color.Silver;
            this.txt_search.Location = new System.Drawing.Point(257, 88);
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(480, 42);
            this.txt_search.TabIndex = 7;
            this.txt_search.Text = "搜索/Serch";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::ChemistryApp.Properties.Resources.shrinkRight;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Location = new System.Drawing.Point(344, 357);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(23, 72);
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.BtnShrink_Click);
            // 
            // pic_titleBG
            // 
            this.pic_titleBG.BackColor = System.Drawing.Color.Transparent;
            this.pic_titleBG.BackgroundImage = global::ChemistryApp.Properties.Resources.mianban;
            this.pic_titleBG.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pic_titleBG.Location = new System.Drawing.Point(313, 40);
            this.pic_titleBG.Name = "pic_titleBG";
            this.pic_titleBG.Size = new System.Drawing.Size(31, 668);
            this.pic_titleBG.TabIndex = 12;
            this.pic_titleBG.TabStop = false;
            // 
            // panel_classListBG
            // 
            this.panel_classListBG.BackgroundImage = global::ChemistryApp.Properties.Resources.planeBG1;
            this.panel_classListBG.Controls.Add(this.button1);
            this.panel_classListBG.Controls.Add(this.txt_classListSerch);
            this.panel_classListBG.Controls.Add(this.pic_classListSearchBG);
            this.panel_classListBG.Controls.Add(this.tab_classList);
            this.panel_classListBG.Location = new System.Drawing.Point(0, 61);
            this.panel_classListBG.Name = "panel_classListBG";
            this.panel_classListBG.Size = new System.Drawing.Size(320, 626);
            this.panel_classListBG.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(264, 54);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(36, 15);
            this.button1.TabIndex = 13;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // txt_classListSerch
            // 
            this.txt_classListSerch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_classListSerch.Font = new System.Drawing.Font("苹方 中等", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt_classListSerch.ForeColor = System.Drawing.Color.Silver;
            this.txt_classListSerch.Location = new System.Drawing.Point(28, 20);
            this.txt_classListSerch.Name = "txt_classListSerch";
            this.txt_classListSerch.Size = new System.Drawing.Size(198, 26);
            this.txt_classListSerch.TabIndex = 14;
            this.txt_classListSerch.Text = "搜索课表";
            // 
            // pic_classListSearchBG
            // 
            this.pic_classListSearchBG.BackColor = System.Drawing.Color.Transparent;
            this.pic_classListSearchBG.BackgroundImage = global::ChemistryApp.Properties.Resources.classSearch;
            this.pic_classListSearchBG.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pic_classListSearchBG.Location = new System.Drawing.Point(10, 15);
            this.pic_classListSearchBG.Name = "pic_classListSearchBG";
            this.pic_classListSearchBG.Size = new System.Drawing.Size(279, 33);
            this.pic_classListSearchBG.TabIndex = 1;
            this.pic_classListSearchBG.TabStop = false;
            // 
            // tab_classList
            // 
            this.tab_classList.Controls.Add(this.tab_caogao);
            this.tab_classList.Controls.Add(this.tab_wancheng);
            this.tab_classList.ImeMode = System.Windows.Forms.ImeMode.On;
            this.tab_classList.Location = new System.Drawing.Point(11, 59);
            this.tab_classList.Name = "tab_classList";
            this.tab_classList.SelectedIndex = 0;
            this.tab_classList.Size = new System.Drawing.Size(290, 565);
            this.tab_classList.TabIndex = 0;
            // 
            // tab_caogao
            // 
            this.tab_caogao.BackColor = System.Drawing.Color.Transparent;
            this.tab_caogao.Controls.Add(this.panel_Left);
            this.tab_caogao.ForeColor = System.Drawing.SystemColors.Control;
            this.tab_caogao.Location = new System.Drawing.Point(4, 25);
            this.tab_caogao.Name = "tab_caogao";
            this.tab_caogao.Padding = new System.Windows.Forms.Padding(3);
            this.tab_caogao.Size = new System.Drawing.Size(282, 536);
            this.tab_caogao.TabIndex = 0;
            this.tab_caogao.Text = "草稿";
            // 
            // tab_wancheng
            // 
            this.tab_wancheng.CausesValidation = false;
            this.tab_wancheng.ForeColor = System.Drawing.Color.Transparent;
            this.tab_wancheng.Location = new System.Drawing.Point(4, 25);
            this.tab_wancheng.Name = "tab_wancheng";
            this.tab_wancheng.Padding = new System.Windows.Forms.Padding(3);
            this.tab_wancheng.Size = new System.Drawing.Size(282, 536);
            this.tab_wancheng.TabIndex = 1;
            this.tab_wancheng.Text = "已完成";
            this.tab_wancheng.UseVisualStyleBackColor = true;
            // 
            // pic_close
            // 
            this.pic_close.BackColor = System.Drawing.Color.Transparent;
            this.pic_close.BackgroundImage = global::ChemistryApp.Properties.Resources._0_05;
            this.pic_close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pic_close.Location = new System.Drawing.Point(950, 13);
            this.pic_close.Name = "pic_close";
            this.pic_close.Size = new System.Drawing.Size(38, 41);
            this.pic_close.TabIndex = 11;
            this.pic_close.TabStop = false;
            // 
            // pic_max
            // 
            this.pic_max.BackColor = System.Drawing.Color.Transparent;
            this.pic_max.BackgroundImage = global::ChemistryApp.Properties.Resources._0_04;
            this.pic_max.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pic_max.Location = new System.Drawing.Point(905, 13);
            this.pic_max.Name = "pic_max";
            this.pic_max.Size = new System.Drawing.Size(38, 41);
            this.pic_max.TabIndex = 10;
            this.pic_max.TabStop = false;
            // 
            // pic_min
            // 
            this.pic_min.BackColor = System.Drawing.Color.Transparent;
            this.pic_min.BackgroundImage = global::ChemistryApp.Properties.Resources._0_03;
            this.pic_min.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pic_min.Location = new System.Drawing.Point(863, 13);
            this.pic_min.Name = "pic_min";
            this.pic_min.Size = new System.Drawing.Size(38, 41);
            this.pic_min.TabIndex = 9;
            this.pic_min.TabStop = false;
            // 
            // btn_search
            // 
            this.btn_search.BackColor = System.Drawing.Color.Transparent;
            this.btn_search.BackgroundImage = global::ChemistryApp.Properties.Resources.btn_search;
            this.btn_search.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_search.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_search.FlatAppearance.BorderSize = 0;
            this.btn_search.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_search.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_search.Location = new System.Drawing.Point(740, 89);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(30, 41);
            this.btn_search.TabIndex = 8;
            this.btn_search.UseVisualStyleBackColor = false;
            // 
            // pic_searchBG
            // 
            this.pic_searchBG.BackColor = System.Drawing.Color.Transparent;
            this.pic_searchBG.BackgroundImage = global::ChemistryApp.Properties.Resources.搜索条;
            this.pic_searchBG.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pic_searchBG.Location = new System.Drawing.Point(230, 86);
            this.pic_searchBG.Name = "pic_searchBG";
            this.pic_searchBG.Size = new System.Drawing.Size(562, 47);
            this.pic_searchBG.TabIndex = 6;
            this.pic_searchBG.TabStop = false;
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
            this.btn_ChemicalElement.Click += new System.EventHandler(this.btn_ChemicalElement_Click);
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
            this.btn_VideoSource.Click += new System.EventHandler(this.btn_VideoSource_Click);
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
            this.btn_ClassroomTeaching.Click += new System.EventHandler(this.btn_ClassroomTeaching_Click);
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
            this.btn_KnowledgeReview.Click += new System.EventHandler(this.btn_KnowledgeReview_Click);
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
            this.btn_MindMap.Click += new System.EventHandler(this.btn_MindMap_Click);
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
            this.btn_ExperlmentalPlatform.Click += new System.EventHandler(this.btn_ExperlmentalPlatform_Click);
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
            // panel1
            // 
            this.panel1.BackgroundImage = global::ChemistryApp.Properties.Resources.planeBG1;
            this.panel1.Location = new System.Drawing.Point(704, 61);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(320, 626);
            this.panel1.TabIndex = 15;
            // 
            // panel_Left
            // 
            this.panel_Left.Location = new System.Drawing.Point(0, 0);
            this.panel_Left.Name = "panel_Left";
            this.panel_Left.Size = new System.Drawing.Size(282, 539);
            this.panel_Left.TabIndex = 0;
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
            this.panle_shrink.ResumeLayout(false);
            this.MainPanel.ResumeLayout(false);
            this.MainPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_titleBG)).EndInit();
            this.panel_classListBG.ResumeLayout(false);
            this.panel_classListBG.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_classListSearchBG)).EndInit();
            this.tab_classList.ResumeLayout(false);
            this.tab_caogao.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pic_close)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_max)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_min)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_searchBG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_ChemicalElement)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_VideoSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_ClassroomTeaching)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_KnowledgeReview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_MindMap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_ExperlmentalPlatform)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_shrink)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_title)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_classSearch)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer LeftPlaneTimer;
        private System.Windows.Forms.PictureBox pic_classSearch;
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
        private System.Windows.Forms.PictureBox pic_searchBG;
        private System.Windows.Forms.TextBox txt_search;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.PictureBox pic_min;
        private System.Windows.Forms.PictureBox pic_close;
        private System.Windows.Forms.PictureBox pic_max;
        private System.Windows.Forms.Panel panel_classListBG;
        private System.Windows.Forms.TabPage tab_caogao;
        private System.Windows.Forms.TabPage tab_wancheng;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pic_classListSearchBG;
        private System.Windows.Forms.TextBox txt_classListSerch;
        private System.Windows.Forms.PictureBox pic_titleBG;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabControl tab_classList;
        private System.Windows.Forms.Panel panel_Left;
    }
}

