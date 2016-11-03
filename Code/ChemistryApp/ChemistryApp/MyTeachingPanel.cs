using System;
using System.Collections.Generic;
using System.Drawing;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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


        public MyTeachingPanel()
        {
            InitializeComponent();
            SetStyle(ControlStyles.UserPaint, true);
            SetStyle(ControlStyles.AllPaintingInWmPaint, true);   //   禁止擦除背景. 
            SetStyle(ControlStyles.DoubleBuffer, true);
        }

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
            MyTeachingItem teachingItem = new MyTeachingItem();
            this.Controls.Add(teachingItem.MyTeachingItemPanel(17, 300));
        }

        private void n(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 开启
        /// </summary>
        /// <param name="picMianban"></param>
        /// <param name="picBtn"></param>
        public void TimerStart(PictureBox picMianban,PictureBox picBtn)
        {
            this.myTeachingTimer.Start();
            this.picMyTeachingMianBan = picMianban;
            this.btnMyTeachingButton = picBtn;
        }

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


    }
}
