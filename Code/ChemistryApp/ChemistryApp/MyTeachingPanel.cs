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
        public Timer myTeachingTimer;

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
        /// 定时器，做左边收缩按钮动画
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MyTeachingPlaneTimer_Tick(object sender, EventArgs e)
        {
            int scrollWight = 20;
            long longWidth = this.Location.X;
            //如果panel目前是隐藏的
            if (Convert.ToInt16(this.Tag.ToString()) == 0)
            {
                if (longWidth >= 1040)
                {
                    myTeachingTimer.Enabled = false;
                    this.Tag = 1;//设置为显示标识
                    //this.btn_shrink.BackgroundImage = global::ChemistryApp.Properties.Resources.btn_left1;
                }
                else
                {
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
                    Point m_point = new Point();
                    m_point.X = this.Location.X - scrollWight;
                    m_point.Y = this.Location.Y;
                    this.Location = m_point;
                }
            }
        }


    }
}
