﻿using System;
using System.Drawing;
using System.Windows.Forms;
using ChemistryApp.EnumType;
using ChemistryApp.MyTeaching;
using ChemistryApp.MyLesson;

namespace ChemistryApp
{
    /// <summary>
    /// 我的备课panel
    /// </summary>
    public class MyTeachingPanel : Panel
    {
        //做动画的计时器
        private Timer myTeachingTimer;
        /// <summary>
        /// 我的备课的面板
        /// </summary>
        private PictureBox picMyTeachingMianBan;
        /// <summary>
        /// 我的备课动画按钮
        /// </summary>
        private PictureBox btnMyTeachingButton;
        /// <summary>
        /// 用于放item的背景
        /// </summary>
        private Panel panelMyTeachingItemBG;
        /// <summary>
        /// 本地资源按钮
        /// </summary>
        private Button btn_bendiziyuan;
        /// <summary>
        /// 一键生成
        /// </summary>
        private Button btn_yijianshengcheng;
        /// <summary>
        /// 一键清空
        /// </summary>
        private Button btn_yijianqingkong;
        /// <summary>
        /// item的类型
        /// </summary>
        public TeachingItemType itemType = TeachingItemType.PPT;
        public MyTeachingPanel()
        {
            InitializeComponent();
            SetStyle(ControlStyles.UserPaint, true);
            SetStyle(ControlStyles.AllPaintingInWmPaint, true);   //   禁止擦除背景. 
            SetStyle(ControlStyles.DoubleBuffer, true);
        }

        #region 初始化
        private void InitializeComponent()
        {
            MyTeachingItemManager.GetInstace.OnItemDelete += RefreshItem;
            //timer
            myTeachingTimer = new Timer();
            myTeachingTimer.Interval = 10;
            myTeachingTimer.Enabled = false;
            myTeachingTimer.Tick += new System.EventHandler(this.MyTeachingPlaneTimer_Tick);

            this.SuspendLayout();
            this.ResumeLayout(false);
            //创建panel
            this.TabIndex = 18;
            this.BackColor = System.Drawing.Color.White;
            this.Location = new System.Drawing.Point(1030, 61);
            this.Name = "panel_myteachingBG";
            this.Size = new System.Drawing.Size(330, 628);
            //this.RightToLeft = RightToLeft.Yes;
            this.AutoScroll = true;
            this.Tag = 1;

            // 
            // panelMyTeachingItemBG
            // 
            panelMyTeachingItemBG = new Panel();
            this.panelMyTeachingItemBG.AutoScroll = true;
            this.panelMyTeachingItemBG.BackColor = System.Drawing.Color.White;
            this.panelMyTeachingItemBG.Location = new System.Drawing.Point(2, 30);
            this.panelMyTeachingItemBG.Name = "panelMyTeachingItemBG";
            this.panelMyTeachingItemBG.Size = new System.Drawing.Size(320, 543);
            this.panelMyTeachingItemBG.TabIndex = 0;
            // 
            // btn_yijianqingkong
            // 
            btn_yijianqingkong = new Button();
            this.btn_yijianqingkong.BackColor = System.Drawing.Color.Transparent;
            this.btn_yijianqingkong.BackgroundImage = global::ChemistryApp.Properties.Resources.yijianqingk;
            this.btn_yijianqingkong.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_yijianqingkong.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_yijianqingkong.FlatAppearance.BorderSize = 0;
            this.btn_yijianqingkong.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_yijianqingkong.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_yijianqingkong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_yijianqingkong.Location = new System.Drawing.Point(161, 20);
            this.btn_yijianqingkong.Name = "btn_yijianqingkong";
            this.btn_yijianqingkong.Size = new System.Drawing.Size(131, 41);
            this.btn_yijianqingkong.TabIndex = 20;
            this.btn_yijianqingkong.UseVisualStyleBackColor = false;
            this.btn_yijianqingkong.Click += new EventHandler(btn_OnClickClaer);
            // 
            // btn_bendiziyuan
            //
            btn_bendiziyuan = new Button();
            this.btn_bendiziyuan.BackColor = System.Drawing.Color.Transparent;
            this.btn_bendiziyuan.BackgroundImage = global::ChemistryApp.Properties.Resources.bendiziyuan_norml_;
            this.btn_bendiziyuan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_bendiziyuan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_bendiziyuan.FlatAppearance.BorderSize = 0;
            this.btn_bendiziyuan.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_bendiziyuan.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_bendiziyuan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_bendiziyuan.Location = new System.Drawing.Point(161, 579);
            this.btn_bendiziyuan.Name = "btn_bendiziyuan";
            this.btn_bendiziyuan.Size = new System.Drawing.Size(131, 41);
            this.btn_bendiziyuan.TabIndex = 21;
            this.btn_bendiziyuan.UseVisualStyleBackColor = false;
            // 
            // btn_yijianshengcheng
            // 
            btn_yijianshengcheng = new Button();
            this.btn_yijianshengcheng.BackColor = System.Drawing.Color.Transparent;
            this.btn_yijianshengcheng.BackgroundImage = global::ChemistryApp.Properties.Resources.yijianshengcheng_norml_;
            this.btn_yijianshengcheng.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_yijianshengcheng.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_yijianshengcheng.FlatAppearance.BorderSize = 0;
            this.btn_yijianshengcheng.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_yijianshengcheng.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_yijianshengcheng.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_yijianshengcheng.Location = new System.Drawing.Point(13, 579);
            this.btn_yijianshengcheng.Name = "btn_yijianshengcheng";
            this.btn_yijianshengcheng.Size = new System.Drawing.Size(131, 41);
            this.btn_yijianshengcheng.TabIndex = 20;
            this.btn_yijianshengcheng.UseVisualStyleBackColor = false;

            this.Controls.Add(btn_yijianqingkong);
            this.Controls.Add(panelMyTeachingItemBG);
            this.Controls.Add(btn_bendiziyuan);
            this.Controls.Add(btn_yijianshengcheng);
           
            //本地资源按钮悬停
            this.btn_bendiziyuan.MouseDown += new MouseEventHandler(btn_bendiziyuan_MouseDown);
            this.btn_bendiziyuan.MouseUp += new MouseEventHandler(btn_bendiziyuan_MouseUp);

            //本地资源按钮悬停
            this.btn_yijianshengcheng.MouseDown += new MouseEventHandler(btn_yijianshengcheng_MouseDown);
            this.btn_yijianshengcheng.MouseUp += new MouseEventHandler(btn_yijianshengcheng_MouseUp);

            //按钮点击事件
            this.btn_bendiziyuan.Click += new EventHandler(btn_bendiziyuan_Click);
            this.btn_yijianshengcheng.Click += new EventHandler(btn_yijianshengcheng_Click);
           

        }
        #endregion

        #region 按钮变换动画 和点击事件
        //本地资源按钮变换事件
        private void btn_bendiziyuan_MouseDown(object sender, MouseEventArgs e)
        {
            this.btn_bendiziyuan.BackgroundImage = global::ChemistryApp.Properties.Resources.bendiziyuan_xuanting_;
        }

        private void btn_bendiziyuan_MouseUp(object sender, MouseEventArgs e)
        {
            this.btn_bendiziyuan.BackgroundImage = global::ChemistryApp.Properties.Resources.bendiziyuan_norml_;
        }
        //一键生成按钮变换事件
        private void btn_yijianshengcheng_MouseDown(object sender, MouseEventArgs e)
        {
            this.btn_yijianshengcheng.BackgroundImage = global::ChemistryApp.Properties.Resources.yijianshengcheng_xuanting_;
        }

        private void btn_yijianshengcheng_MouseUp(object sender, MouseEventArgs e)
        {
            this.btn_yijianshengcheng.BackgroundImage = global::ChemistryApp.Properties.Resources.yijianshengcheng_norml_;
        }

        //点击事件 本地资源上传
        private void btn_bendiziyuan_Click(object sender, EventArgs e)
        {
            try
            {
                //获取到父物体
                Button btn_bendi = (Button)sender;
                Panel mainPanel = btn_bendi.Parent.Parent as Panel;
                string _loaclPath = @System.Windows.Forms.Application.StartupPath + "\\ResourcesFolder\\MyTeaching";
                OpenFileDialog openFile = new OpenFileDialog();
                openFile.Filter = "ppt(*.pptx)|*.pptx|mp4(*.mp4)|*.mp4|docx(*.docx)|*.docx|all file(*.*)|*.*";//"(*.pptx)|*.pptx, (*.mp4)|*.mp4";
                if (openFile.ShowDialog() == DialogResult.OK)
                {
                    CreateTeachingItemDialogBox item = new CreateTeachingItemDialogBox("\\ResourcesFolder\\MyTeaching\\" + openFile.SafeFileName + "", openFile.FileName, _loaclPath + "\\" + openFile.SafeFileName, System.IO.Path.GetFileNameWithoutExtension(openFile.FileName));
                    mainPanel.Controls.Add(item);
                    item.BringToFront();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message); 
            }
           
        }
        /// <summary>
        /// 一键生成
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_yijianshengcheng_Click(object sender, EventArgs e)
        {
            CreateLessonDialogBox dialogBox = null;
            Button btn_yijian = (Button)sender;
            Panel mainPanel = btn_yijian.Parent.Parent as Panel;
            if (MyTeachingItemManager.GetInstace.listPanelItem.Count != 0)
            {
                foreach (Control item in mainPanel.Controls)
                {
                    if (item.Name == "panel_createDialog")
                    {
                        return;
                    }
                }
                dialogBox = new CreateLessonDialogBox();
                Panel panelDialogBox = dialogBox.CreateDialgBox();
                //dialogBox.OnCreateDeleteAllTeachingAction = btn_OnClickClaer;
                mainPanel.Controls.Add(panelDialogBox);
                panelDialogBox.BringToFront();
            }
        }

        /// <summary>
        /// 一键清空
        /// </summary>
        /// <param name="sender"></param>
        /// <param name=""></param>
        private void btn_OnClickClaer(object sender, EventArgs e)
        {
            string clearTabelSql = "delete * from MyTeaching";
            int errorIndex = AccessDBConn.ExecuteNonQuery(clearTabelSql);
            if (errorIndex != 0)
            {
                this.panelMyTeachingItemBG.Controls.Clear();
            }
            MainForm mainForm = ((Control)sender).Parent.Parent.Parent as MainForm;
            MyTeachingItemManager.GetInstace.ShowTeachingCount(mainForm);
            RefreshItem();
        }
        #endregion

        /// <summary>
        /// 开启动画
        /// </summary>
        /// <param name="picMianban"></param>
        /// <param name="picBtn"></param>
        public void TimerStart(PictureBox picMianban, PictureBox picBtn)
        {
            this.myTeachingTimer.Start();
            this.picMyTeachingMianBan = picMianban;
            this.btnMyTeachingButton = picBtn;
        }


        /// <summary>
        /// 创建item
        /// </summary>
        public void CreateTeachingItem()
        {
            MyTeachingItemManager.GetInstace.CreateTeachingItem();
            for (int i = 0; i < MyTeachingItemManager.GetInstace.listPanelItem.Count; i++)
            {
                this.panelMyTeachingItemBG.Controls.Add(MyTeachingItemManager.GetInstace.listPanelItem[i]);
            }
        }

        /// <summary>
        /// 删除后刷新界面
        /// </summary>
        public void RefreshItem()
        {
            this.panelMyTeachingItemBG.Controls.Clear();
            CreateTeachingItem();
        }

        #region 定时器
        /// <summary>
        /// 定时器，做我的备课收缩按钮动画
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MyTeachingPlaneTimer_Tick(object sender, EventArgs e)
        {
            int scrollWight = 15;
            long longWidth = this.Location.X;
            //如果panel目前是隐藏的
            if (Convert.ToInt16(this.Tag.ToString()) == 0)
            {
                if (longWidth >= 1035)
                {
                    myTeachingTimer.Enabled = false;
                    this.Tag = 1;//设置为显示标识
                    //this.btn_shrink.BackgroundImage = global::ChemistryApp.Properties.Resources.btn_left1;
                }
                else
                {
                    //面板动画
                    Point mianbanPoint = new Point();
                    mianbanPoint.X = this.picMyTeachingMianBan.Location.X + scrollWight;
                    mianbanPoint.Y = this.picMyTeachingMianBan.Location.Y;
                    this.picMyTeachingMianBan.Location = mianbanPoint;

                    //收缩按钮动画
                    Point btnShrinkPoint = new Point();
                    btnShrinkPoint.X = this.btnMyTeachingButton.Location.X + scrollWight;
                    btnShrinkPoint.Y = this.btnMyTeachingButton.Location.Y;
                    this.btnMyTeachingButton.Location = btnShrinkPoint;

                    //我的备课panele动画
                    Point m_point = new Point();
                    m_point.X = this.Location.X + scrollWight;
                    m_point.Y = this.Location.Y;
                    this.Location = m_point;
                }
            }
            //如果panel目前是显示的
            if (Convert.ToInt16(this.Tag.ToString()) == 1)
            {
                if (longWidth <= 710)
                {
                    myTeachingTimer.Enabled = false;
                    this.Tag = 0;//设置为隐藏标识
                    //this.btn_shrink.BackgroundImage = global::ChemistryApp.Properties.Resources.btn_right;
                }
                else
                {
                    //面板动画
                    Point mianbanPoint = new Point();
                    mianbanPoint.X = this.picMyTeachingMianBan.Location.X - scrollWight;
                    mianbanPoint.Y = this.picMyTeachingMianBan.Location.Y;
                    this.picMyTeachingMianBan.Location = mianbanPoint;

                    //收缩按钮动画
                    Point btnShrinkPoint = new Point();
                    btnShrinkPoint.X = this.btnMyTeachingButton.Location.X - scrollWight;
                    btnShrinkPoint.Y = this.btnMyTeachingButton.Location.Y;
                    this.btnMyTeachingButton.Location = btnShrinkPoint;

                    //我的备课panele动画
                    Point m_point = new Point();
                    m_point.X = this.Location.X - scrollWight;
                    m_point.Y = this.Location.Y;
                    this.Location = m_point;
                }
            }
        }
        #endregion

    }
}
