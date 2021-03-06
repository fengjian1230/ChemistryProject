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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.LeftPlaneTimer = new System.Windows.Forms.Timer(this.components);
            this.panle_shrink = new System.Windows.Forms.Panel();
            this.RightPanelTimer = new System.Windows.Forms.Timer(this.components);
            this.MainPanel = new ChemistryApp.BackGroundPanel();
            this.countBG = new System.Windows.Forms.PictureBox();
            this.pic_done = new System.Windows.Forms.PictureBox();
            this.previewAudioWindow = new AxWMPLib.AxWindowsMediaPlayer();
            this.myTeachingCount = new System.Windows.Forms.Label();
            this.MainFlashBox = new AxShockwaveFlashObjects.AxShockwaveFlash();
            this.pic_titleBG = new System.Windows.Forms.PictureBox();
            this.btn_shrink = new System.Windows.Forms.PictureBox();
            this.btn_myteachingShrink = new System.Windows.Forms.PictureBox();
            this.pic_myteachingMianban = new System.Windows.Forms.PictureBox();
            this.teachingPanel = new ChemistryApp.MyTeachingPanel();
            this.lessonPanel = new ChemistryApp.MyLesson.MyLessonPanel();
            this.btn_back = new System.Windows.Forms.Button();
            this.pic_close = new System.Windows.Forms.PictureBox();
            this.pic_max = new System.Windows.Forms.PictureBox();
            this.pic_min = new System.Windows.Forms.PictureBox();
            this.btn_search = new System.Windows.Forms.Button();
            this.listBox_searchRuslut = new System.Windows.Forms.ListBox();
            this.txt_search = new System.Windows.Forms.TextBox();
            this.pic_searchBG = new System.Windows.Forms.PictureBox();
            this.btn_ChemicalElement = new System.Windows.Forms.PictureBox();
            this.btn_VideoSource = new System.Windows.Forms.PictureBox();
            this.btn_ClassroomTeaching = new System.Windows.Forms.PictureBox();
            this.btn_KnowledgeReview = new System.Windows.Forms.PictureBox();
            this.btn_MindMap = new System.Windows.Forms.PictureBox();
            this.btn_ExperlmentalPlatform = new System.Windows.Forms.PictureBox();
            this.MainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.countBG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_done)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.previewAudioWindow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MainFlashBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_titleBG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_shrink)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_myteachingShrink)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_myteachingMianban)).BeginInit();
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
            this.MainPanel.BackgroundImage = global::ChemistryApp.Properties.Resources.背景shen;
            this.MainPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.MainPanel.Controls.Add(this.countBG);
            this.MainPanel.Controls.Add(this.pic_done);
            this.MainPanel.Controls.Add(this.previewAudioWindow);
            this.MainPanel.Controls.Add(this.myTeachingCount);
            this.MainPanel.Controls.Add(this.MainFlashBox);
            this.MainPanel.Controls.Add(this.pic_titleBG);
            this.MainPanel.Controls.Add(this.btn_shrink);
            this.MainPanel.Controls.Add(this.btn_myteachingShrink);
            this.MainPanel.Controls.Add(this.pic_myteachingMianban);
            this.MainPanel.Controls.Add(this.teachingPanel);
            this.MainPanel.Controls.Add(this.lessonPanel);
            this.MainPanel.Controls.Add(this.btn_back);
            this.MainPanel.Controls.Add(this.pic_close);
            this.MainPanel.Controls.Add(this.pic_max);
            this.MainPanel.Controls.Add(this.pic_min);
            this.MainPanel.Controls.Add(this.btn_search);
            this.MainPanel.Controls.Add(this.listBox_searchRuslut);
            this.MainPanel.Controls.Add(this.txt_search);
            this.MainPanel.Controls.Add(this.pic_searchBG);
            this.MainPanel.Controls.Add(this.btn_ChemicalElement);
            this.MainPanel.Controls.Add(this.btn_VideoSource);
            this.MainPanel.Controls.Add(this.btn_ClassroomTeaching);
            this.MainPanel.Controls.Add(this.btn_KnowledgeReview);
            this.MainPanel.Controls.Add(this.btn_MindMap);
            this.MainPanel.Controls.Add(this.btn_ExperlmentalPlatform);
            this.MainPanel.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.MainPanel.Location = new System.Drawing.Point(29, 12);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(1024, 768);
            this.MainPanel.TabIndex = 18;
            // 
            // countBG
            // 
            this.countBG.Image = global::ChemistryApp.Properties.Resources.countBG;
            this.countBG.Location = new System.Drawing.Point(6, 281);
            this.countBG.Name = "countBG";
            this.countBG.Size = new System.Drawing.Size(15, 15);
            this.countBG.TabIndex = 25;
            this.countBG.TabStop = false;
            // 
            // pic_done
            // 
            this.pic_done.Image = global::ChemistryApp.Properties.Resources.done;
            this.pic_done.Location = new System.Drawing.Point(410, 350);
            this.pic_done.Name = "pic_done";
            this.pic_done.Size = new System.Drawing.Size(210, 100);
            this.pic_done.TabIndex = 22;
            this.pic_done.TabStop = false;
            this.pic_done.Visible = false;
            // 
            // previewAudioWindow
            // 
            this.previewAudioWindow.Enabled = true;
            this.previewAudioWindow.Location = new System.Drawing.Point(200, 176);
            this.previewAudioWindow.Name = "previewAudioWindow";
            this.previewAudioWindow.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("previewAudioWindow.OcxState")));
            this.previewAudioWindow.Size = new System.Drawing.Size(0, 0);
            this.previewAudioWindow.TabIndex = 24;
            // 
            // myTeachingCount
            // 
            this.myTeachingCount.AutoSize = true;
            this.myTeachingCount.BackColor = System.Drawing.Color.Transparent;
            this.myTeachingCount.Font = new System.Drawing.Font("苹方 中等", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.myTeachingCount.ForeColor = System.Drawing.Color.White;
            this.myTeachingCount.Location = new System.Drawing.Point(3, 299);
            this.myTeachingCount.Name = "myTeachingCount";
            this.myTeachingCount.Size = new System.Drawing.Size(17, 20);
            this.myTeachingCount.TabIndex = 23;
            this.myTeachingCount.Text = "0";
            // 
            // MainFlashBox
            // 
            this.MainFlashBox.Enabled = true;
            this.MainFlashBox.Location = new System.Drawing.Point(-240, 120);
            this.MainFlashBox.Name = "MainFlashBox";
            this.MainFlashBox.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("MainFlashBox.OcxState")));
            this.MainFlashBox.Size = new System.Drawing.Size(240, 240);
            this.MainFlashBox.TabIndex = 21;
            this.MainFlashBox.Visible = false;
            // 
            // pic_titleBG
            // 
            this.pic_titleBG.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.pic_titleBG.BackColor = System.Drawing.Color.Transparent;
            this.pic_titleBG.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pic_titleBG.Image = ((System.Drawing.Image)(resources.GetObject("pic_titleBG.Image")));
            this.pic_titleBG.Location = new System.Drawing.Point(0, 60);
            this.pic_titleBG.Name = "pic_titleBG";
            this.pic_titleBG.Size = new System.Drawing.Size(31, 626);
            this.pic_titleBG.TabIndex = 12;
            this.pic_titleBG.TabStop = false;
            this.pic_titleBG.Tag = "0";
            // 
            // btn_shrink
            // 
            this.btn_shrink.BackColor = System.Drawing.Color.Transparent;
            this.btn_shrink.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_shrink.Image = ((System.Drawing.Image)(resources.GetObject("btn_shrink.Image")));
            this.btn_shrink.Location = new System.Drawing.Point(28, 350);
            this.btn_shrink.Name = "btn_shrink";
            this.btn_shrink.Size = new System.Drawing.Size(21, 69);
            this.btn_shrink.TabIndex = 13;
            this.btn_shrink.TabStop = false;
            this.btn_shrink.Tag = "0";
            this.btn_shrink.Click += new System.EventHandler(this.BtnShrink_Click);
            // 
            // btn_myteachingShrink
            // 
            this.btn_myteachingShrink.BackColor = System.Drawing.Color.Transparent;
            this.btn_myteachingShrink.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_myteachingShrink.Image = ((System.Drawing.Image)(resources.GetObject("btn_myteachingShrink.Image")));
            this.btn_myteachingShrink.Location = new System.Drawing.Point(972, 350);
            this.btn_myteachingShrink.Name = "btn_myteachingShrink";
            this.btn_myteachingShrink.Size = new System.Drawing.Size(21, 69);
            this.btn_myteachingShrink.TabIndex = 17;
            this.btn_myteachingShrink.TabStop = false;
            this.btn_myteachingShrink.Tag = "0";
            this.btn_myteachingShrink.Click += new System.EventHandler(this.btn_myteachingShrink_Click);
            // 
            // pic_myteachingMianban
            // 
            this.pic_myteachingMianban.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.pic_myteachingMianban.BackColor = System.Drawing.Color.Transparent;
            this.pic_myteachingMianban.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pic_myteachingMianban.Image = ((System.Drawing.Image)(resources.GetObject("pic_myteachingMianban.Image")));
            this.pic_myteachingMianban.Location = new System.Drawing.Point(993, 62);
            this.pic_myteachingMianban.Name = "pic_myteachingMianban";
            this.pic_myteachingMianban.Size = new System.Drawing.Size(31, 668);
            this.pic_myteachingMianban.TabIndex = 16;
            this.pic_myteachingMianban.TabStop = false;
            this.pic_myteachingMianban.Tag = "0";
            // 
            // teachingPanel
            // 
            this.teachingPanel.AutoScroll = true;
            this.teachingPanel.BackColor = System.Drawing.Color.White;
            this.teachingPanel.Location = new System.Drawing.Point(1023, 61);
            this.teachingPanel.Name = "teachingPanel";
            this.teachingPanel.Size = new System.Drawing.Size(330, 628);
            this.teachingPanel.TabIndex = 18;
            this.teachingPanel.Tag = 1;
            // 
            // lessonPanel
            // 
            this.lessonPanel.BackColor = System.Drawing.Color.White;
            this.lessonPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.lessonPanel.Location = new System.Drawing.Point(-330, 61);
            this.lessonPanel.Name = "lessonPanel";
            this.lessonPanel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lessonPanel.Size = new System.Drawing.Size(330, 626);
            this.lessonPanel.TabIndex = 0;
            this.lessonPanel.Tag = "0";
            // 
            // btn_back
            // 
            this.btn_back.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_back.BackgroundImage")));
            this.btn_back.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_back.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_back.FlatAppearance.BorderSize = 0;
            this.btn_back.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_back.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_back.ForeColor = System.Drawing.Color.Transparent;
            this.btn_back.Location = new System.Drawing.Point(81, 698);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(107, 32);
            this.btn_back.TabIndex = 20;
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // pic_close
            // 
            this.pic_close.BackColor = System.Drawing.Color.Transparent;
            this.pic_close.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pic_close.BackgroundImage")));
            this.pic_close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pic_close.Location = new System.Drawing.Point(950, 13);
            this.pic_close.Name = "pic_close";
            this.pic_close.Size = new System.Drawing.Size(38, 41);
            this.pic_close.TabIndex = 11;
            this.pic_close.TabStop = false;
            this.pic_close.Click += new System.EventHandler(this.pic_close_Click);
            // 
            // pic_max
            // 
            this.pic_max.BackColor = System.Drawing.Color.Transparent;
            this.pic_max.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pic_max.BackgroundImage")));
            this.pic_max.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pic_max.Location = new System.Drawing.Point(905, 13);
            this.pic_max.Name = "pic_max";
            this.pic_max.Size = new System.Drawing.Size(38, 41);
            this.pic_max.TabIndex = 10;
            this.pic_max.TabStop = false;
            this.pic_max.Click += new System.EventHandler(this.pic_max_Click);
            // 
            // pic_min
            // 
            this.pic_min.BackColor = System.Drawing.Color.Transparent;
            this.pic_min.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pic_min.BackgroundImage")));
            this.pic_min.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pic_min.Location = new System.Drawing.Point(863, 13);
            this.pic_min.Name = "pic_min";
            this.pic_min.Size = new System.Drawing.Size(38, 41);
            this.pic_min.TabIndex = 9;
            this.pic_min.TabStop = false;
            this.pic_min.Click += new System.EventHandler(this.pic_min_Click);
            // 
            // btn_search
            // 
            this.btn_search.BackColor = System.Drawing.Color.Transparent;
            this.btn_search.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_search.BackgroundImage")));
            this.btn_search.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_search.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_search.FlatAppearance.BorderSize = 0;
            this.btn_search.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_search.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_search.Location = new System.Drawing.Point(740, 77);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(30, 41);
            this.btn_search.TabIndex = 8;
            this.btn_search.UseVisualStyleBackColor = false;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click_1);
            // 
            // listBox_searchRuslut
            // 
            this.listBox_searchRuslut.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBox_searchRuslut.Font = new System.Drawing.Font("苹方 常规", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.listBox_searchRuslut.ForeColor = System.Drawing.Color.Silver;
            this.listBox_searchRuslut.FormattingEnabled = true;
            this.listBox_searchRuslut.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.listBox_searchRuslut.ItemHeight = 33;
            this.listBox_searchRuslut.Location = new System.Drawing.Point(239, 120);
            this.listBox_searchRuslut.Name = "listBox_searchRuslut";
            this.listBox_searchRuslut.Size = new System.Drawing.Size(547, 297);
            this.listBox_searchRuslut.TabIndex = 19;
            this.listBox_searchRuslut.Visible = false;
            this.listBox_searchRuslut.SelectedIndexChanged += new System.EventHandler(this.listBox_searchRuslut_SelectedIndexChanged);
            // 
            // txt_search
            // 
            this.txt_search.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_search.Font = new System.Drawing.Font("苹方 常规", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt_search.ForeColor = System.Drawing.Color.Silver;
            this.txt_search.Location = new System.Drawing.Point(265, 83);
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(468, 31);
            this.txt_search.TabIndex = 7;
            this.txt_search.Text = "搜索/Search";
            this.txt_search.Click += new System.EventHandler(this.txt_search_Click);
            this.txt_search.TextChanged += new System.EventHandler(this.TextSearch_TextChanged);
            // 
            // pic_searchBG
            // 
            this.pic_searchBG.BackColor = System.Drawing.Color.Transparent;
            this.pic_searchBG.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pic_searchBG.BackgroundImage")));
            this.pic_searchBG.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pic_searchBG.Location = new System.Drawing.Point(229, 76);
            this.pic_searchBG.Name = "pic_searchBG";
            this.pic_searchBG.Size = new System.Drawing.Size(558, 47);
            this.pic_searchBG.TabIndex = 6;
            this.pic_searchBG.TabStop = false;
            // 
            // btn_ChemicalElement
            // 
            this.btn_ChemicalElement.BackColor = System.Drawing.Color.Transparent;
            this.btn_ChemicalElement.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_ChemicalElement.BackgroundImage")));
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
            this.btn_VideoSource.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_VideoSource.BackgroundImage")));
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
            this.btn_ClassroomTeaching.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_ClassroomTeaching.BackgroundImage")));
            this.btn_ClassroomTeaching.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_ClassroomTeaching.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_ClassroomTeaching.Location = new System.Drawing.Point(240, 408);
            this.btn_ClassroomTeaching.Name = "btn_ClassroomTeaching";
            this.btn_ClassroomTeaching.Size = new System.Drawing.Size(175, 226);
            this.btn_ClassroomTeaching.TabIndex = 3;
            this.btn_ClassroomTeaching.TabStop = false;
            this.btn_ClassroomTeaching.Click += new System.EventHandler(this.btn_ClassRoomTeaching_Click);
            // 
            // btn_KnowledgeReview
            // 
            this.btn_KnowledgeReview.BackColor = System.Drawing.Color.Transparent;
            this.btn_KnowledgeReview.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_KnowledgeReview.BackgroundImage")));
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
            this.btn_MindMap.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_MindMap.BackgroundImage")));
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
            this.btn_ExperlmentalPlatform.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_ExperlmentalPlatform.BackgroundImage")));
            this.btn_ExperlmentalPlatform.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_ExperlmentalPlatform.Cursor = System.Windows.Forms.Cursors.Hand;
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
            this.BackgroundImage = global::ChemistryApp.Properties.Resources._1600x900背景;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1103, 768);
            this.Controls.Add(this.MainPanel);
            this.Controls.Add(this.panle_shrink);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "App";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyDown);
            this.MainPanel.ResumeLayout(false);
            this.MainPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.countBG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_done)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.previewAudioWindow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MainFlashBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_titleBG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_shrink)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_myteachingShrink)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_myteachingMianban)).EndInit();
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
        private System.Windows.Forms.Panel panle_shrink;
        public BackGroundPanel MainPanel;
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
        private System.Windows.Forms.PictureBox pic_titleBG;
        private System.Windows.Forms.Timer LeftPlaneTimer;
        private System.Windows.Forms.Timer RightPanelTimer;
        public System.Windows.Forms.PictureBox pic_myteachingMianban;
        public System.Windows.Forms.PictureBox btn_myteachingShrink;
        private System.Windows.Forms.ListBox listBox_searchRuslut;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.PictureBox btn_shrink;
        public AxShockwaveFlashObjects.AxShockwaveFlash MainFlashBox;
        public System.Windows.Forms.PictureBox pic_done;
        public System.Windows.Forms.Label myTeachingCount;
        public AxWMPLib.AxWindowsMediaPlayer previewAudioWindow;
        public System.Windows.Forms.PictureBox countBG;
    }
}

