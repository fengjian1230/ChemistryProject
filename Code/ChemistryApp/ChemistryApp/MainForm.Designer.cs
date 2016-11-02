﻿namespace ChemistryApp
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
            this.panle_shrink = new System.Windows.Forms.Panel();
            this.RightPanelTimer = new System.Windows.Forms.Timer(this.components);
            this.MainPanel = new ChemistryApp.BackGroundPanel();
            this.pic_typeIcon = new System.Windows.Forms.Panel();
            this.panel_myTeachingItem = new System.Windows.Forms.Panel();
            this.txt_title = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pic_myteachingDelete = new System.Windows.Forms.PictureBox();
            this.pic_myteachingDown = new System.Windows.Forms.PictureBox();
            this.pic_myteachingUp = new System.Windows.Forms.PictureBox();
            this.btn_shrink = new System.Windows.Forms.PictureBox();
            this.pic_titleBG = new System.Windows.Forms.PictureBox();
            this.panel_classListBG = new System.Windows.Forms.Panel();
            this.btn_bianji = new System.Windows.Forms.Button();
            this.panel_item = new System.Windows.Forms.Panel();
            this.txt_classListSerch = new System.Windows.Forms.TextBox();
            this.pic_classListSearchBG = new System.Windows.Forms.PictureBox();
            this.pic_close = new System.Windows.Forms.PictureBox();
            this.pic_max = new System.Windows.Forms.PictureBox();
            this.pic_min = new System.Windows.Forms.PictureBox();
            this.btn_search = new System.Windows.Forms.Button();
            this.txt_search = new System.Windows.Forms.TextBox();
            this.pic_searchBG = new System.Windows.Forms.PictureBox();
            this.btn_ChemicalElement = new System.Windows.Forms.PictureBox();
            this.btn_VideoSource = new System.Windows.Forms.PictureBox();
            this.btn_ClassroomTeaching = new System.Windows.Forms.PictureBox();
            this.btn_KnowledgeReview = new System.Windows.Forms.PictureBox();
            this.btn_MindMap = new System.Windows.Forms.PictureBox();
            this.btn_ExperlmentalPlatform = new System.Windows.Forms.PictureBox();
            this.MainPanel.SuspendLayout();
            this.pic_typeIcon.SuspendLayout();
            this.panel_myTeachingItem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_myteachingDelete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_myteachingDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_myteachingUp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_shrink)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_titleBG)).BeginInit();
            this.panel_classListBG.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_classListSearchBG)).BeginInit();
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
            this.SuspendLayout();
            // 
            // LeftPlaneTimer
            // 
            this.LeftPlaneTimer.Interval = 1;
            this.LeftPlaneTimer.Tick += new System.EventHandler(this.LeftPlaneTimer_Tick);
            // 
            // panle_shrink
            // 
            this.panle_shrink.BackColor = System.Drawing.Color.White;
            this.panle_shrink.Dock = System.Windows.Forms.DockStyle.Left;
            this.panle_shrink.Location = new System.Drawing.Point(0, 0);
            this.panle_shrink.Name = "panle_shrink";
            this.panle_shrink.Size = new System.Drawing.Size(0, 768);
            this.panle_shrink.TabIndex = 17;
            // 
            // RightPanelTimer
            // 
            this.RightPanelTimer.Interval = 1;
            // 
            // MainPanel
            // 
            this.MainPanel.BackColor = System.Drawing.Color.Transparent;
            this.MainPanel.BackgroundImage = global::ChemistryApp.Properties.Resources.背景;
            this.MainPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.MainPanel.Controls.Add(this.pic_typeIcon);
            this.MainPanel.Controls.Add(this.btn_shrink);
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
            this.MainPanel.Location = new System.Drawing.Point(12, 12);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(1027, 768);
            this.MainPanel.TabIndex = 18;
            this.MainPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.MainPanel_Paint);
            // 
            // pic_typeIcon
            // 
            this.pic_typeIcon.BackColor = System.Drawing.Color.White;
            this.pic_typeIcon.Controls.Add(this.panel_myTeachingItem);
            this.pic_typeIcon.Location = new System.Drawing.Point(704, 61);
            this.pic_typeIcon.Name = "pic_typeIcon";
            this.pic_typeIcon.Size = new System.Drawing.Size(320, 626);
            this.pic_typeIcon.TabIndex = 15;
            // 
            // panel_myTeachingItem
            // 
            this.panel_myTeachingItem.BackColor = System.Drawing.Color.Transparent;
            this.panel_myTeachingItem.BackgroundImage = global::ChemistryApp.Properties.Resources.myteachingItemBG;
            this.panel_myTeachingItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel_myTeachingItem.Controls.Add(this.txt_title);
            this.panel_myTeachingItem.Controls.Add(this.pictureBox1);
            this.panel_myTeachingItem.Controls.Add(this.pic_myteachingDelete);
            this.panel_myTeachingItem.Controls.Add(this.pic_myteachingDown);
            this.panel_myTeachingItem.Controls.Add(this.pic_myteachingUp);
            this.panel_myTeachingItem.Location = new System.Drawing.Point(17, 39);
            this.panel_myTeachingItem.Name = "panel_myTeachingItem";
            this.panel_myTeachingItem.Size = new System.Drawing.Size(279, 70);
            this.panel_myTeachingItem.TabIndex = 0;
            // 
            // txt_title
            // 
            this.txt_title.AutoSize = true;
            this.txt_title.Font = new System.Drawing.Font("苹方 中等", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt_title.Location = new System.Drawing.Point(100, 39);
            this.txt_title.Name = "txt_title";
            this.txt_title.Size = new System.Drawing.Size(130, 21);
            this.txt_title.TabIndex = 4;
            this.txt_title.Text = "《氯的化学反应》";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::ChemistryApp.Properties.Resources.icon_1_03;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Location = new System.Drawing.Point(10, 30);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(55, 37);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // pic_myteachingDelete
            // 
            this.pic_myteachingDelete.BackgroundImage = global::ChemistryApp.Properties.Resources.删除键;
            this.pic_myteachingDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pic_myteachingDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pic_myteachingDelete.Location = new System.Drawing.Point(257, 8);
            this.pic_myteachingDelete.Name = "pic_myteachingDelete";
            this.pic_myteachingDelete.Size = new System.Drawing.Size(15, 15);
            this.pic_myteachingDelete.TabIndex = 2;
            this.pic_myteachingDelete.TabStop = false;
            // 
            // pic_myteachingDown
            // 
            this.pic_myteachingDown.BackgroundImage = global::ChemistryApp.Properties.Resources.向下键;
            this.pic_myteachingDown.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pic_myteachingDown.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pic_myteachingDown.Location = new System.Drawing.Point(31, 8);
            this.pic_myteachingDown.Name = "pic_myteachingDown";
            this.pic_myteachingDown.Size = new System.Drawing.Size(15, 15);
            this.pic_myteachingDown.TabIndex = 1;
            this.pic_myteachingDown.TabStop = false;
            // 
            // pic_myteachingUp
            // 
            this.pic_myteachingUp.BackgroundImage = global::ChemistryApp.Properties.Resources.向上键;
            this.pic_myteachingUp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pic_myteachingUp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pic_myteachingUp.Location = new System.Drawing.Point(10, 8);
            this.pic_myteachingUp.Name = "pic_myteachingUp";
            this.pic_myteachingUp.Size = new System.Drawing.Size(15, 15);
            this.pic_myteachingUp.TabIndex = 0;
            this.pic_myteachingUp.TabStop = false;
            // 
            // btn_shrink
            // 
            this.btn_shrink.BackColor = System.Drawing.Color.Transparent;
            this.btn_shrink.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_shrink.Image = global::ChemistryApp.Properties.Resources.shrinkRight;
            this.btn_shrink.Location = new System.Drawing.Point(28, 349);
            this.btn_shrink.Name = "btn_shrink";
            this.btn_shrink.Size = new System.Drawing.Size(23, 72);
            this.btn_shrink.TabIndex = 13;
            this.btn_shrink.TabStop = false;
            this.btn_shrink.Tag = "0";
            this.btn_shrink.Click += new System.EventHandler(this.BtnShrink_Click);
            // 
            // pic_titleBG
            // 
            this.pic_titleBG.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.pic_titleBG.BackColor = System.Drawing.Color.Transparent;
            this.pic_titleBG.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pic_titleBG.Image = global::ChemistryApp.Properties.Resources.mianban;
            this.pic_titleBG.Location = new System.Drawing.Point(0, 48);
            this.pic_titleBG.Name = "pic_titleBG";
            this.pic_titleBG.Size = new System.Drawing.Size(31, 668);
            this.pic_titleBG.TabIndex = 12;
            this.pic_titleBG.TabStop = false;
            this.pic_titleBG.Tag = "0";
            // 
            // panel_classListBG
            // 
            this.panel_classListBG.BackColor = System.Drawing.Color.White;
            this.panel_classListBG.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel_classListBG.Controls.Add(this.btn_bianji);
            this.panel_classListBG.Controls.Add(this.panel_item);
            this.panel_classListBG.Controls.Add(this.txt_classListSerch);
            this.panel_classListBG.Controls.Add(this.pic_classListSearchBG);
            this.panel_classListBG.Location = new System.Drawing.Point(0, 61);
            this.panel_classListBG.Name = "panel_classListBG";
            this.panel_classListBG.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.panel_classListBG.Size = new System.Drawing.Size(0, 626);
            this.panel_classListBG.TabIndex = 0;
            this.panel_classListBG.Tag = "0";
            // 
            // btn_bianji
            // 
            this.btn_bianji.BackColor = System.Drawing.Color.Transparent;
            this.btn_bianji.BackgroundImage = global::ChemistryApp.Properties.Resources.btn_bianji;
            this.btn_bianji.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_bianji.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_bianji.FlatAppearance.BorderSize = 0;
            this.btn_bianji.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_bianji.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_bianji.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_bianji.Location = new System.Drawing.Point(187, 579);
            this.btn_bianji.Name = "btn_bianji";
            this.btn_bianji.Size = new System.Drawing.Size(131, 41);
            this.btn_bianji.TabIndex = 18;
            this.btn_bianji.UseVisualStyleBackColor = false;
            this.btn_bianji.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_bianji_MouseDown);
            this.btn_bianji.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_bianji_MouseUp);
            // 
            // panel_item
            // 
            this.panel_item.AutoScroll = true;
            this.panel_item.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel_item.BackColor = System.Drawing.Color.White;
            this.panel_item.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel_item.ForeColor = System.Drawing.Color.Black;
            this.panel_item.ImeMode = System.Windows.Forms.ImeMode.On;
            this.panel_item.Location = new System.Drawing.Point(3, 110);
            this.panel_item.Name = "panel_item";
            this.panel_item.Size = new System.Drawing.Size(315, 463);
            this.panel_item.TabIndex = 17;
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
            this.pic_classListSearchBG.BackColor = System.Drawing.Color.White;
            this.pic_classListSearchBG.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pic_classListSearchBG.Location = new System.Drawing.Point(10, 15);
            this.pic_classListSearchBG.Name = "pic_classListSearchBG";
            this.pic_classListSearchBG.Size = new System.Drawing.Size(279, 33);
            this.pic_classListSearchBG.TabIndex = 1;
            this.pic_classListSearchBG.TabStop = false;
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
            this.btn_ExperlmentalPlatform.BackgroundImage = global::ChemistryApp.Properties.Resources.课件播放icon;
            this.btn_ExperlmentalPlatform.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_ExperlmentalPlatform.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_ExperlmentalPlatform.Image = global::ChemistryApp.Properties.Resources.btn_011;
            this.btn_ExperlmentalPlatform.Location = new System.Drawing.Point(240, 176);
            this.btn_ExperlmentalPlatform.Name = "btn_ExperlmentalPlatform";
            this.btn_ExperlmentalPlatform.Size = new System.Drawing.Size(175, 226);
            this.btn_ExperlmentalPlatform.TabIndex = 0;
            this.btn_ExperlmentalPlatform.TabStop = false;
            this.btn_ExperlmentalPlatform.Click += new System.EventHandler(this.btn_ExperlmentalPlatform_Click);
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1024, 768);
            this.Controls.Add(this.MainPanel);
            this.Controls.Add(this.panle_shrink);
            this.Name = "MainForm";
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "App";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.MainPanel.ResumeLayout(false);
            this.MainPanel.PerformLayout();
            this.pic_typeIcon.ResumeLayout(false);
            this.panel_myTeachingItem.ResumeLayout(false);
            this.panel_myTeachingItem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_myteachingDelete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_myteachingDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_myteachingUp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_shrink)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_titleBG)).EndInit();
            this.panel_classListBG.ResumeLayout(false);
            this.panel_classListBG.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_classListSearchBG)).EndInit();
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
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel_item;
        private System.Windows.Forms.Panel panle_shrink;
        private BackGroundPanel MainPanel;
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
        private System.Windows.Forms.PictureBox pic_classListSearchBG;
        private System.Windows.Forms.TextBox txt_classListSerch;
        private System.Windows.Forms.PictureBox pic_titleBG;
        private System.Windows.Forms.PictureBox btn_shrink;
        private System.Windows.Forms.Panel pic_typeIcon;
        private System.Windows.Forms.Timer LeftPlaneTimer;
        private System.Windows.Forms.Timer RightPanelTimer;
        private System.Windows.Forms.Button btn_bianji;
        private System.Windows.Forms.Panel panel_myTeachingItem;
        private System.Windows.Forms.PictureBox pic_myteachingUp;
        private System.Windows.Forms.PictureBox pic_myteachingDown;
        private System.Windows.Forms.PictureBox pic_myteachingDelete;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label txt_title;
    }
}

