using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using ChemistryApp.MyLesson;

namespace ChemistryApp.SecondPage
{
    /// <summary>
    /// 点击课件的播放列表内容
    /// </summary>
    public class ContentPlayPanel : Panel
    {
        public AxDSOFramer.AxFramerControl ContentControlFramer;
        public AxWMPLib.AxWindowsMediaPlayer axAudioPlayer;
        public Panel panel_playContentPanelBtn;
        public PictureBox playBG;
        public PictureBox pic_top;
        public PictureBox pic_close;
        public Panel playBlackBG;
        public Panel playListBG;
        public PictureBox picBtn_back;
        public PictureBox picBtn_front;
        /// <summary>
        /// 当前点击课表的index 
        /// </summary>
        public int currListIndex = 0;
        /// <summary>
        /// 内容和index
        /// </summary>
        public Dictionary<string, int> dicListTitle;
        /// <summary>
        /// 存放item，用于上一个和下一个点击
        /// </summary>
        public List<ContentItem> listContentItem;
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));

        public ContentPlayPanel(bool isSearch)
        {

            SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            SetStyle(ControlStyles.UserPaint, true);
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);

            ContentControlFramer = new AxDSOFramer.AxFramerControl();
            axAudioPlayer = new AxWMPLib.AxWindowsMediaPlayer();
            panel_playContentPanelBtn = new Panel();
            playBG = new PictureBox();
            playBlackBG = new Panel();
            playListBG = new Panel();
            pic_top = new PictureBox();
            pic_close = new PictureBox();
            picBtn_back = new PictureBox();
            picBtn_front = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ContentControlFramer)).BeginInit();
            dicListTitle = new Dictionary<string, int>();
            listContentItem = new List<ContentItem>();
            InitCompent(isSearch);
        }


        /// <summary>
        /// 初始化控件
        /// </summary>
        /// <param name="isSearch"></param>
        private void InitCompent(bool isSearch)
        {
            CreateMyLessonItem();
            int width = Screen.PrimaryScreen.Bounds.Width;
            int height = Screen.PrimaryScreen.Bounds.Height;
            this.BackgroundImage = global::ChemistryApp.Properties.Resources._1600x900背景;
            this.Name = "ContentPlayPanel";
            this.Location = new Point(0, 0);
            this.Size = this.Size;
            //this.BackColor = Color.Black;
            this.Size = new Size(width, height);
            this.AutoScroll = true;
            this.Controls.Add(this.playBG);
            this.Controls.Add(panel_playContentPanelBtn);
            

            // 
            // playBG
            // 
            this.playBG.BackgroundImage = global::ChemistryApp.Properties.Resources.PlayBG;
            this.playBG.Controls.Add(this.pic_close);
            this.playBG.Controls.Add(this.axAudioPlayer);
            this.playBG.Controls.Add(ContentControlFramer);
            if (!isSearch)
            {
                this.playBG.Controls.Add(this.playListBG);
                this.playBG.Controls.Add(this.picBtn_back);
                this.playBG.Controls.Add(this.picBtn_front);
                this.playBG.Controls.Add(this.pic_top);
                this.playBG.Controls.Add(this.playBlackBG);
            }
            this.playBG.Location = new System.Drawing.Point((width - 1024) / 2, (height - 768) / 2 - 30);
            this.playBG.Name = "playBG";
            this.playBG.Size = new System.Drawing.Size(1024, 768);
            this.playBG.TabIndex = 22;
            // 
            // playListBG
            // 
            this.playListBG.BackgroundImage = global::ChemistryApp.Properties.Resources.playList;
            this.playListBG.AutoScroll = true;
            this.playListBG.Location = new System.Drawing.Point(750, 95);
            this.playListBG.Name = "playListBG";
            this.playListBG.Size = new System.Drawing.Size(266, 606);
            this.playListBG.TabIndex = 3;
            // 
            // pic_top
            // 
            this.pic_top.Image = global::ChemistryApp.Properties.Resources.playTop;
            this.pic_top.Location = new System.Drawing.Point(750, 47);
            this.pic_top.Name = "pic_top";
            this.pic_top.Size = new System.Drawing.Size(266, 50);
            this.pic_top.TabIndex = 1;
            this.pic_top.TabStop = false;
            // 
            // playBlackBG
            // 
            this.playBlackBG.BackColor = System.Drawing.Color.Black;
            this.playBlackBG.Location = new System.Drawing.Point(7, 48);
            this.playBlackBG.Name = "playBlackBG";
            this.playBlackBG.Size = new System.Drawing.Size(743, 653);
            this.playBlackBG.TabIndex = 0;
            // 
            // pic_close
            // 
            this.pic_close.BackColor = System.Drawing.Color.Transparent;
            this.pic_close.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pic_close.BackgroundImage")));
            this.pic_close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pic_close.Location = new System.Drawing.Point(950, 5);
            this.pic_close.Name = "pic_close";
            this.pic_close.Size = new System.Drawing.Size(38, 41);
            this.pic_close.Click += new System.EventHandler(OnClickClosePanel);

            // 
            // ppt播放
            // 
            this.ContentControlFramer.CausesValidation = false;
            this.ContentControlFramer.Enabled = true;
            this.ContentControlFramer.Location = new System.Drawing.Point(7, 48);
            this.ContentControlFramer.Name = "ContentControlFramer";
            this.ContentControlFramer.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axFramerControl1.OcxState")));
            this.ContentControlFramer.Size = new System.Drawing.Size(743, 653);
            // 
            // panel_playContentPanelBtn
            // 
            this.panel_playContentPanelBtn.Location = new System.Drawing.Point(0, (height - 550) / 2);
            this.panel_playContentPanelBtn.Name = "panel_playContentPanelBtn";
            this.panel_playContentPanelBtn.Size = new System.Drawing.Size(280, 550);
            this.panel_playContentPanelBtn.AutoScroll = true;
            this.panel_playContentPanelBtn.TabIndex = 21;
            this.panel_playContentPanelBtn.BackColor = Color.Transparent;
            // 
            // 视频播放
            // 
            this.axAudioPlayer.Enabled = true;
            this.axAudioPlayer.Location = new System.Drawing.Point(7, 48);
            this.axAudioPlayer.Name = "axAudioPlayer";
            this.axAudioPlayer.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axAudioPlayer.Size = new System.Drawing.Size(743, 653);
            this.axAudioPlayer.TabIndex = 21;
            this.axAudioPlayer.Visible = false;
            // 
            // picBtn_front
            // 
            this.picBtn_front.Image = global::ChemistryApp.Properties.Resources.front_up;
            this.picBtn_front.Location = new System.Drawing.Point(960,65);
            this.picBtn_front.Name = "picBtn_front";
            this.picBtn_front.Size = new System.Drawing.Size(18, 16);
            this.picBtn_front.TabIndex = 22;
            this.picBtn_front.TabStop = false;
            this.picBtn_front.Cursor = Cursors.Hand;
            this.picBtn_front.Click += new EventHandler(OnClickFrontOrBackButton);
            ControlPPTFonder.ControlTransparent.ControlTrans(this.picBtn_front, this.picBtn_front.Image);
            // 
            // picBtn_back
            // 
            this.picBtn_back.Image = global::ChemistryApp.Properties.Resources.back_up;
            this.picBtn_back.Location = new System.Drawing.Point(920, 65);
            this.picBtn_back.Name = "picBtn_back";
            this.picBtn_back.Size = new System.Drawing.Size(18, 16);
            this.picBtn_back.TabIndex = 22;
            this.picBtn_back.TabStop = false;
            this.picBtn_back.Cursor = Cursors.Hand;
            this.picBtn_back.Click += new EventHandler(OnClickFrontOrBackButton);
            ControlPPTFonder.ControlTransparent.ControlTrans(this.picBtn_back, this.picBtn_back.Image);
            // 

        }

        /// <summary>
        /// 创建我的课表的item
        /// </summary>
        public void CreateMyLessonItem()
        {
            //从数据库中读取数据
            string sqlStr = "select * from LessonList where LessonTitle = '" + MyLessonItemManager.GetInstace.lessonFiledName + "' order by ListID asc"; //(select LessonContent from LessonList where ID = 1)";
            DataSet data = AccessDBConn.ExecuteQuery(sqlStr, "LessonList");
            DataRow[] dataRow = data.Tables["LessonList"].Select();
            //创建itempanel
            for (int i = 0; i < dataRow.Count(); i++)
            {
                //从一个字段查询另外一个表
                string _childStr = "select * from " + dataRow[0]["LessonContent"].ToString() + "";
                DataSet childData = AccessDBConn.ExecuteQuery(_childStr, dataRow[0]["LessonContent"].ToString());
                DataRow[] childDataRow = childData.Tables[dataRow[0]["LessonContent"].ToString()].Select();
                //创建课表列表
                for (int j = 0; j < childDataRow.Count(); j++)
                {
                    ContentItem childPanel = new ContentItem(0, 10 + j * 50, childDataRow[j]["Title"].ToString(), childDataRow[j]["Type"].ToString(), childDataRow[j]["URL"].ToString(), this);
                    dicListTitle.Add(childDataRow[j]["Title"].ToString() , j);
                    childPanel.Name = "childPanel" + j.ToString();
                    listContentItem.Add(childPanel);
                    this.playListBG.Controls.Add(childPanel);
                }
            }
        }

        /// <summary>
        /// 关闭面板
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnClickClosePanel(object sender, EventArgs e)
        {
            PictureBox btn = (PictureBox)sender;
            MainForm mainForm = btn.Parent.Parent.Parent as MainForm;
            Panel parentPanel = btn.Parent.Parent as Panel;
            mainForm.Controls.Remove(parentPanel);
            mainForm.MainPanel.Visible = true;
            //btn.Dispose();
            //parentPanel.Dispose();
        }

        /// <summary>
        /// 点击前进或后退键
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnClickFrontOrBackButton(object sender,EventArgs e)
        {
            if (((PictureBox)sender).Name == "picBtn_back")
            {
                //当前索引不能为零，如果为0往前则越界
                if (currListIndex != 0)
                {
                    listContentItem[currListIndex - 1].PlayButtonOnPPTPage_Click(listContentItem[currListIndex - 1].kejianName, e);
                }
            }
            else if (((PictureBox)sender).Name == "picBtn_front")
            {
                //当前索引不能超过count，如果超过则越界了
                if (currListIndex < listContentItem.Count - 1)
                {
                    listContentItem[currListIndex + 1].PlayButtonOnPPTPage_Click(listContentItem[currListIndex + 1].kejianName, e);
                }
            }
        }
    }

    /// <summary>
    /// 创建播放列表内容
    /// </summary>
    public class ContentItem : Panel
    {
        //当第一次进入会模拟点击事件
        public Control onFirstEnter;
        public Label kejianName;
        public PictureBox pic_type;
        public int pos_x;
        public int pos_y;
        private string strTitleName;
        //类型名字
        private string strTypeName;
        //内容路径
        private string filePath;
        //内容 播放
        private ContentPlayPanel contentPlay;

        public ContentItem(int pos_x, int pos_y, string _titleName, string _typeName, string _filePath, ContentPlayPanel contentPlay)
        {
            kejianName = new Label();
            pic_type = new PictureBox();
            this.strTitleName = _titleName;
            this.strTypeName = _typeName;
            this.filePath = _filePath;
            this.contentPlay = contentPlay;
            InitCompent(pos_x, pos_y);
        }

        private void InitCompent(int pos_x, int pos_y)
        {
            // 
            // panel1
            // 
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.kejianName);
            this.Controls.Add(this.pic_type);
            this.Location = new System.Drawing.Point(pos_x, pos_y);
            this.Name = "panel1";
            this.Size = new System.Drawing.Size(265, 47);
            // 
            // pic_type
            // 
            this.pic_type.Image = TypeIconPicture(strTypeName);
            this.pic_type.Location = new System.Drawing.Point(3, 2);
            this.pic_type.Name = "pic_type";
            this.pic_type.Size = new System.Drawing.Size(53, 44);
            this.pic_type.Click += new EventHandler(PlayButtonOnPPTPage_Click);
            this.pic_type.TabStop = false;
            this.pic_type.Cursor = Cursors.Hand;
            // 
            // kejianName
            // 
            this.kejianName.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.kejianName.ForeColor = System.Drawing.Color.Gray;
            this.kejianName.Location = new System.Drawing.Point(59, 13);
            this.kejianName.Name = "kejianName";
            this.kejianName.Size = new System.Drawing.Size(300, 21);
            this.kejianName.Text = strTitleName;
            this.kejianName.Cursor = Cursors.Hand;
            this.kejianName.Click += new EventHandler(PlayButtonOnPPTPage_Click);
        }

        /// <summary>
        /// 点击预览按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void PlayButtonOnPPTPage_Click(object sender, EventArgs e)
        {
            //如果包含点击的item名字，则返回到当前点击item索引
            if (contentPlay.dicListTitle.ContainsKey(strTitleName))
            {
                contentPlay.currListIndex = contentPlay.dicListTitle[strTitleName];
            }
            try
            {
              

                ////获取到mianpanel
                Control currControl = (Control)sender;
                MainForm mainForm = currControl.Parent.Parent.Parent.Parent.Parent as MainForm;
                string strRight = filePath.Substring(filePath.Length - 3, 3);
                if (strRight == "swf")
                {
                    try
                    {
                        //播放 flash的控件
                        mainForm.MainFlashBox.Visible = true;
                        mainForm.MainFlashBox.Location = new System.Drawing.Point(7, 48);
                        mainForm.MainFlashBox.Size = new System.Drawing.Size(743, 653);
                        mainForm.MainFlashBox.Movie = System.Windows.Forms.Application.StartupPath + @filePath;
                        contentPlay.playBG.Controls.Add(mainForm.MainFlashBox);
                        mainForm.MainFlashBox.BringToFront();
                    }
                    catch (Exception exp)
                    {
                        MessageBox.Show(exp.Message);
                    }
                }
                else
                {
                    switch (this.strTypeName)
                    {

                        case "PPT":
                            contentPlay.axAudioPlayer.Visible = false;
                            contentPlay.ContentControlFramer.BorderStyle = DSOFramer.dsoBorderStyle.dsoBorderNone;
                            contentPlay.ContentControlFramer.Toolbars = true;
                            contentPlay.ContentControlFramer.Titlebar = false;
                            contentPlay.ContentControlFramer.Menubar = false;
                            contentPlay.ContentControlFramer.Visible = true;
                            contentPlay.ContentControlFramer.Close();
                            mainForm.MainFlashBox.Visible = false;
                            contentPlay.ContentControlFramer.Open(System.Windows.Forms.Application.StartupPath + @filePath);
                            break;
                        case "思维导图":
                            /* 思维导图*/
                            break;
                        case "视频":
                            contentPlay.axAudioPlayer.Visible = true;
                            contentPlay.ContentControlFramer.Visible = false;
                            mainForm.MainFlashBox.Visible = false;
                            contentPlay.axAudioPlayer.URL = System.Windows.Forms.Application.StartupPath + @filePath;
                            //contentPlay.axAudioPlayer.openPlayer(System.Windows.Forms.Application.StartupPath + @_filePath);
                            break;
                        case "实验":
                            /* 实验*/
                            break;
                        case "反应方程":
                            /* 反应方程*/
                            break;
                        case "习题":
                            /*习题*/
                            break;
                        default:
                            break;
                    }
                }
            }
            catch(Exception exs)
            {
                MessageBox.Show(exs.Message);
            }
        }

        /// <summary>
        /// ICon图标
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
        private Image TypeIconPicture(string _strType)
        {
            Image image = global::ChemistryApp.Properties.Resources.icon_1_03;
            switch (_strType)
            {
                case "PPT":
                    image = global::ChemistryApp.Properties.Resources.icon_1_06;
                    break;
                case "实验":
                    image = global::ChemistryApp.Properties.Resources.icon_1_03;
                    break;
                case "思维导图":
                    image = global::ChemistryApp.Properties.Resources.icon_1_09;
                    break;
                case "反应方程":
                    image = global::ChemistryApp.Properties.Resources.icon_1_16;
                    break;
                case "习题":
                    image = global::ChemistryApp.Properties.Resources.icon_1_14;
                    break;
                case "视频":
                    image = global::ChemistryApp.Properties.Resources.icon_1_12;
                    break;

            }
            return image;
        }
    }
}
