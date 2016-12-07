using ChemistryApp.EnumType;
using ChemistryApp.SearchPage;
using ChemistryApp.SecondPage;
using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace ChemistryApp.MyLesson
{
    class MyLessonPanel : Panel
    {
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
        public Button btn_bianji;
        public PictureBox btn_myClassSearch;
        public TextBox txt_classListSerch;
        public PictureBox pic_classListSearchBG;
        private Timer LeftPlaneTimer;
        public PictureBox pic_titleBG;
        public PictureBox btn_shrink;
        public MyLessonItemBGPanel panel_item;

        public MyLessonPanel()
        {
            //SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            //SetStyle(ControlStyles.UserPaint, true);
            //SetStyle(ControlStyles.OptimizedDoubleBuffer, true);

            btn_bianji = new Button();
            btn_myClassSearch = new PictureBox();
            txt_classListSerch = new TextBox();
            pic_classListSearchBG = new PictureBox();
            LeftPlaneTimer = new Timer();
            pic_titleBG = new PictureBox();
            btn_shrink = new PictureBox();
            panel_item = new MyLessonItemBGPanel();
            LeftPlaneTimer.Tick += LeftPlaneTimer_Tick;
            LeftPlaneTimer.Interval = 10;
            InitControls();
        }


        private void InitControls()
        {
            // 
            // panel_classListBG
            // 
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Controls.Add(this.txt_classListSerch);
            this.Controls.Add(this.btn_myClassSearch);
            this.Controls.Add(this.pic_classListSearchBG);  
            this.Controls.Add(this.btn_bianji);
            this.Controls.Add(this.panel_item);
            this.Location = new System.Drawing.Point(0, 61);
            this.Name = "panel_classListBG";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Size = new System.Drawing.Size(320, 626);
            this.TabIndex = 0;
            this.Tag = "0";
            // 
            // btn_bianji
            // 
            this.btn_bianji.BackColor = System.Drawing.Color.Transparent;
            this.btn_bianji.BackgroundImage = global::ChemistryApp.Properties.Resources.delete_norml1;
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
            this.btn_bianji.Click += new System.EventHandler(this.btn_bianji_Click);
            this.btn_bianji.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_bianji_MouseDown);
            this.btn_bianji.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_bianji_MouseUp);

            // 
            // btn_myClassSearch
            // 
            this.btn_myClassSearch.BackgroundImage = global::ChemistryApp.Properties.Resources.myclassSearchBtn;
            this.pic_classListSearchBG.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_myClassSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_myClassSearch.Location = new System.Drawing.Point(265, 22);
            this.btn_myClassSearch.Name = "btn_myClassSearch";
            this.btn_myClassSearch.Size = new System.Drawing.Size(17, 17);
            this.btn_myClassSearch.TabIndex = 19;
            this.btn_myClassSearch.TabStop = false;
            this.btn_myClassSearch.Click += new System.EventHandler(this.btn_myClassSearch_Click);
            // 
            // txt_classListSerch
            // 
            this.txt_classListSerch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_classListSerch.Font = new System.Drawing.Font("苹方 中等", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt_classListSerch.ForeColor = System.Drawing.Color.Silver;
            this.txt_classListSerch.Location = new System.Drawing.Point(35, 20);
            this.txt_classListSerch.Name = "txt_classListSerch1";
            this.txt_classListSerch.Size = new System.Drawing.Size(198, 21);
            this.txt_classListSerch.TabIndex = 14;
            this.txt_classListSerch.Text = "搜索课表";
            this.txt_classListSerch.TabStop = false;
            // 
            // pic_classListSearchBG
            // 
            this.pic_classListSearchBG.BackColor = System.Drawing.Color.White;
            this.pic_classListSearchBG.BackgroundImage = global::ChemistryApp.Properties.Resources.myclassListSearchBG;
            this.pic_classListSearchBG.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pic_classListSearchBG.Location = new System.Drawing.Point(17, 15);
            this.pic_classListSearchBG.Name = "pic_classListSearchBG";
            this.pic_classListSearchBG.Size = new System.Drawing.Size(279, 33);
            this.pic_classListSearchBG.TabIndex = 1;
            this.pic_classListSearchBG.TabStop = true;
            // 

        }


        #region 我的课表编辑按钮
        private void btn_bianji_MouseDown(object sender, MouseEventArgs e)
        {
            this.btn_bianji.BackgroundImage = global::ChemistryApp.Properties.Resources.delete_down1;
        }

        private void btn_bianji_MouseUp(object sender, MouseEventArgs e)
        {
            this.btn_bianji.BackgroundImage = global::ChemistryApp.Properties.Resources.delete_norml1;
        }

        /// <summary>
        /// 点击编辑按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_bianji_Click(object sender, EventArgs e)
        {
            if (MyLessonItemManager.GetInstace.bianjiState == BianJiState.Bianji && MyLessonItemManager.GetInstace.state == LessonItemState.Open)
            {
                foreach (MyLessonItem item in panel_item.Controls)
                {
                    Point point = new Point();
                    point.X = item.Location.X - 50;
                    point.Y = item.Location.Y;
                    item.Location = point;
                    item.Size = new Size(329, 140);
                }
                MyLessonItemManager.GetInstace.bianjiState = BianJiState.Wancheng;

            }
            else if (MyLessonItemManager.GetInstace.bianjiState == BianJiState.Wancheng)
            {
                foreach (MyLessonItem item in panel_item.Controls)
                {
                    Point point = new Point();
                    point.X = 0;
                    point.Y = item.Location.Y;
                    item.Location = point;
                    item.Size = new Size(279, 140);
                }
                MyLessonItemManager.GetInstace.bianjiState = BianJiState.Bianji;
            }

        }
        #endregion

        public void OnDeleteMyLessonItem()
        {
            this.panel_item.Controls.Clear();
            //如果是删除第一个则下个置顶
            if (MyLessonItemManager.GetInstace.isDeleteFirstItem)
            {
                string selectSqlStr = "select top 1 * from LessonList";
                DataSet selectDs = AccessDBConn.ExecuteQuery(selectSqlStr, "LessonList");
                DataRow[] selectRow = selectDs.Tables["LessonList"].Select();
                if (selectRow.Length != 0)
                {
                    string updateSqlStr = "update LessonList set IsTop = 'true' where LessonTitle = '" + selectRow[0]["LessonTitle"].ToString() + "'";
                    AccessDBConn.ExecuteNonQuery(updateSqlStr);
                    MyLessonItemManager.GetInstace.isDeleteFirstItem = false;
                }
            }

            MyLessonItemManager.GetInstace.CreateMyLessonItem();
            for (int i = 0; i < MyLessonItemManager.GetInstace.listPanelItem.Count; i++)
            {
                this.panel_item.Controls.Add(MyLessonItemManager.GetInstace.listPanelItem[i]);
            }

        }

        /// <summary>
        /// 我的课表搜索
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_myClassSearch_Click(object sender, EventArgs e)
        {
            if (this.txt_classListSerch.Text != "")
            {
                this.panel_item.Controls.Clear();
                string selectSql = "select * from LessonList where  LessonTitle like '%" + this.txt_classListSerch.Text + "%'";
                try
                {
                    DataSet ds = AccessDBConn.ExecuteQuery(selectSql, "LessonList");
                    DataRow[] dr = ds.Tables["LessonList"].Select();
                    for (int i = 0; i < dr.Count(); i++)
                    {
                        string strTitle = dr[i]["LessonTitle"].ToString();
                        string strTips = dr[i]["Tips"].ToString();
                        MyLessonItem item = new MyLessonItem(10, i * (140 + 10), strTitle, strTips, true);
                        panel_item.Controls.Add(item);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                OnDeleteMyLessonItem();
            }
        }

        /// <summary>
        /// 开启动画
        /// </summary>
        /// <param name="picMianban"></param>
        /// <param name="picBtn"></param>
        public void TimerStart(PictureBox picMianban, PictureBox picBtn)
        {
            this.LeftPlaneTimer.Start();
            this.pic_titleBG = picMianban;
            this.btn_shrink = picBtn;
        }

        /// <summary>
        /// 定时器，做左边收缩按钮动画
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LeftPlaneTimer_Tick(object sender, EventArgs e)
        {
            int scrollWight = 10;
            long longWidth = this.Location.X;
            //如果panel目前是隐藏的
            if (Convert.ToInt16(this.Tag.ToString()) == 0)
            {
                if (longWidth >= 0)
                {
                    LeftPlaneTimer.Enabled = false;
                    this.Tag = 1;//设置为显示标识
                }
                else
                {
                    //面板动画
                    Point mianbanPoint = new Point();
                    mianbanPoint.X = this.pic_titleBG.Location.X + scrollWight;
                    mianbanPoint.Y = this.pic_titleBG.Location.Y;
                    this.pic_titleBG.Location = mianbanPoint;

                    //收缩按钮动画
                    Point btnShrinkPoint = new Point();
                    btnShrinkPoint.X = this.btn_shrink.Location.X + scrollWight;
                    btnShrinkPoint.Y = this.btn_shrink.Location.Y;
                    this.btn_shrink.Location = btnShrinkPoint;

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
                if (longWidth <= -330)
                {
                    LeftPlaneTimer.Enabled = false;
                    this.Tag = 0;//设置为隐藏标识\
                    //ControlPPTFonder.ControlTransparent.ControlTrans(btn_shrink,)
                    //this.btn_shrink.Image = global::ChemistryApp.Properties.Resources.btn_shousuo_left_open;
                }
                else
                {
                    //面板动画
                    Point mianbanPoint = new Point();
                    mianbanPoint.X = this.pic_titleBG.Location.X - scrollWight;
                    mianbanPoint.Y = this.pic_titleBG.Location.Y;
                    this.pic_titleBG.Location = mianbanPoint;

                    //收缩按钮动画
                    Point btnShrinkPoint = new Point();
                    btnShrinkPoint.X = this.btn_shrink.Location.X - scrollWight;
                    btnShrinkPoint.Y = this.btn_shrink.Location.Y;
                    this.btn_shrink.Location = btnShrinkPoint;

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
