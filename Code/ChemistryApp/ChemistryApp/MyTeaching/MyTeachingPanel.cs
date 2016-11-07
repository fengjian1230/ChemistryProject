using System;
using System.Collections.Generic;
using System.Drawing;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace ChemistryApp
{
    /// <summary>
    /// 我的备课panel
    /// </summary>
    class MyTeachingPanel : Panel
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

            this.Controls.Add(panelMyTeachingItemBG);
            this.Controls.Add(btn_bendiziyuan);
            this.Controls.Add(btn_yijianshengcheng);

            //在panel中显示出来
            MyTeachingItem teachingItem = new MyTeachingItem();
            this.panelMyTeachingItemBG.Controls.Add(teachingItem.MyTeachingItemPanel(17, 300));

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

        //点击事件
        private void btn_bendiziyuan_Click(object sender,EventArgs e)
        {
            
        }
        private void btn_yijianshengcheng_Click(object sender, EventArgs e)
        {
           
        }
        #endregion

        /// <summary>
        /// 开启动画
        /// </summary>
        /// <param name="picMianban"></param>
        /// <param name="picBtn"></param>
        public void TimerStart(PictureBox picMianban,PictureBox picBtn)
        {
            this.myTeachingTimer.Start();
            this.picMyTeachingMianBan = picMianban;
            this.btnMyTeachingButton = picBtn;
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
