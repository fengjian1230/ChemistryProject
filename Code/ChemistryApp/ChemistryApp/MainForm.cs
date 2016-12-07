using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using ChemistryApp.MyLesson;
using ChemistryApp.EnumType;
using ChemistryApp.SearchPage;
using ChemistryApp.SecondPage;

namespace ChemistryApp
{
    public partial class MainForm : Form
    {
        /// <summary>
        /// 我的备课panel
        /// </summary>
        public MyTeachingPanel teachingPanel;
        /// <summary>
        /// 我的课件panel
        /// </summary>
        MyLessonPanel lessonPanel;

        /// <summary>
        /// 连接
        /// </summary>
        private List<string> listBoxItemListURL;
        /// <summary>
        /// 类型
        /// </summary>
        private List<string> listBoxItemListType;
        public MainForm()
        {
            InitializeComponent();
            SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            SetStyle(ControlStyles.UserPaint, true);
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
           
            this.BackgroundImage = global::ChemistryApp.Properties.Resources._1600x900背景; 
            //this.MainPanel.Visible = false;
        }

        /// <summary>
        /// mainform加载
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainForm_Load(object sender, EventArgs e)
        {

            //ChemistryApp.Register.RegisterPanle register = new Register.RegisterPanle(this);
            //register.IsRegister();

            MyTeaching.MyTeachingItemManager.GetInstace.ShowTeachingCount(this);


            int mainFormWidth = Screen.PrimaryScreen.Bounds.Width;
            int mainFormHeight = Screen.PrimaryScreen.Bounds.Height;
            this.listBoxItemListURL = new List<string>();
            this.listBoxItemListType = new List<string>();
            //初始位置
            this.MainPanel.Location = new Point((mainFormWidth - 1024) / 2, (mainFormHeight - 768) / 2 - 30);//((mainFormWidth - 1024) / 2, (mainFormHeight - 768) / 2 - 30);
            this.Size = new Size(mainFormWidth, mainFormWidth);

            //添加事件
            MyLessonItemManager.GetInstace.OnDeleteFinish += lessonPanel.OnDeleteMyLessonItem;
            MyLessonItemManager.GetInstace.CreateMyLessonItem();
            ////创建item
            for (int i = 0; i < MyLessonItemManager.GetInstace.listPanelItem.Count; i++)
            {
                this.lessonPanel.panel_item.Controls.Add(MyLessonItemManager.GetInstace.listPanelItem[i]);
            }
            teachingPanel.CreateTeachingItem();
        }
        #region 我的课表列表动画
        public MyLessonState lessonState = MyLessonState.OnClose;
        /// <summary>
        /// 左边收缩按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnShrink_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt16(teachingPanel.Tag.ToString()) == 1)
            {
                lessonPanel.TimerStart(this.pic_titleBG, this.btn_shrink);
            }
            else
            {
                if (Convert.ToInt16(teachingPanel.Tag.ToString()) == 0)
                {
                    lessonPanel.TimerStart(this.pic_titleBG, this.btn_shrink);
                }
            }
            //根据状态来加载内容
            if (lessonState == MyLessonState.OnClose)
            {
                lessonState = MyLessonState.OnOpen;
            }
            else if (lessonState == MyLessonState.OnOpen)
            {
                lessonState = MyLessonState.OnClose;
            }
        }
        #endregion

        #region 主页上六个按钮
        /// <summary>
        /// 化学元素按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_ChemicalElement_Click(object sender, EventArgs e)
        {
            SecondPage.ChemicalElementSecondPage cheiclElementPage = new SecondPage.ChemicalElementSecondPage();
            this.MainPanel.Controls.Add(cheiclElementPage);
            cheiclElementPage.BringToFront();
            ControlBringToFront();
        }

        /// <summary>
        /// 知识回顾
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_KnowledgeReview_Click(object sender, EventArgs e)
        {
            SecondPage.KnowledgeReviewSecondPage konwledegeReiewPage = new SecondPage.KnowledgeReviewSecondPage();
            this.MainPanel.Controls.Add(konwledegeReiewPage);
            konwledegeReiewPage.BringToFront();
            ControlBringToFront();
        }

        /// <summary>
        /// 课堂教学
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_ClassRoomTeaching_Click(object sender, EventArgs e)
        {
            SecondPage.SecondPageManager.GetInstace.TableName = "ClassRoomTeaching";
            SecondPage.SecondPageBackGroundPanel secondPagePanel = new SecondPage.SecondPageBackGroundPanel();
            this.MainPanel.Controls.Add(secondPagePanel);
            secondPagePanel.BringToFront();
            ControlBringToFront();
        }

        /// <summary>
        /// 实验平台
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_ExperlmentalPlatform_Click(object sender, EventArgs e)
        {
            SecondPage.ExperlmentalPlatformSecondPage experlMentalPlathformPage = new SecondPage.ExperlmentalPlatformSecondPage();
            this.MainPanel.Controls.Add(experlMentalPlathformPage);
            experlMentalPlathformPage.BringToFront();
            ControlBringToFront();
        }

        /// <summary>
        /// 思维导图
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_MindMap_Click(object sender, EventArgs e)
        {
            SecondPage.SecondPageManager.GetInstace.TableName = "MindMap";
            SecondPage.SecondPageBackGroundPanel secondPagePanel = new SecondPage.SecondPageBackGroundPanel();
            this.MainPanel.Controls.Add(secondPagePanel);
            secondPagePanel.BringToFront();
            ControlBringToFront();
        }

        /// <summary>
        /// 视频资源
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_VideoSource_Click(object sender, EventArgs e)
        {
            SecondPage.SecondPageManager.GetInstace.TableName = "VideoSource";
            SecondPage.SecondPageBackGroundPanel secondPagePanel = new SecondPage.SecondPageBackGroundPanel();
            this.MainPanel.Controls.Add(secondPagePanel);
            secondPagePanel.BringToFront();
            ControlBringToFront();
        }
        /// <summary>
        /// 所有的面板置顶
        /// </summary>
        public void ControlBringToFront()
        {
            this.pic_titleBG.BringToFront();
            this.btn_shrink.BringToFront();
            this.btn_myteachingShrink.BringToFront();
            this.pic_myteachingMianban.BringToFront();
            this.teachingPanel.BringToFront();
            this.lessonPanel.BringToFront();
        }
        #endregion

        #region 搜索对话框事件
        /// <summary>
        /// 搜索按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_search_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// 当textbox发生变化时,显示收收缩结果
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TextSearch_TextChanged(object sender, EventArgs e)
        {
            this.listBoxItemListURL.Clear();
            this.listBoxItemListType.Clear();
            this.listBox_searchRuslut.Visible = true;
            string sql = "select * from AllTeaching where Title like '%" + this.txt_search.Text + "%'";
            DataSet ds = AccessDBConn.ExecuteQuery(sql, "AllTeaching");
            try
            {
                this.listBox_searchRuslut.Items.Clear();
                DataRow[] dr = ds.Tables["AllTeaching"].Select();
                foreach (var item in dr)
                {
                    this.listBox_searchRuslut.Items.Add(item["Title"].ToString());
                    this.listBoxItemListURL.Add(item["URL"].ToString());
                    this.listBoxItemListType.Add(item["Type"].ToString());
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }

            ///当为空的时候清空list
            if (this.txt_search.Text == "")
            {
                this.listBox_searchRuslut.Items.Clear();
            }
        }



        private void txt_search_Click(object sender, EventArgs e)
        {
            TextBox txtSearch = (TextBox)sender;
            txtSearch.Parent.Click += new EventHandler(HideSearchRulust);
        }

        private void HideSearchRulust(object sender, EventArgs e)
        {
            this.listBox_searchRuslut.Visible = false;
        }

        private void pic_title_Click(object sender, EventArgs e)
        {

        }
        
        /// <summary>
        /// 选择下拉框
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listBox_searchRuslut_SelectedIndexChanged(object sender, EventArgs e)
        {
            //string selectStr = this.listBox_searchRuslut.SelectedItem as string;
            int index = this.listBox_searchRuslut.SelectedIndex;
            string strURL = this.listBoxItemListURL[index];
            string strType = this.listBoxItemListType[index];
            if (strURL.Substring(strURL.Length - 3,3) == "swf")
            {
                PlaySwfPanel swfPanel = new PlaySwfPanel();
                this.Controls.Add(swfPanel);
                //播放 flash的控件
                int width = Screen.PrimaryScreen.Bounds.Width;
                int height = Screen.PrimaryScreen.Bounds.Height;
                this.MainFlashBox.Visible = true;
                this.MainFlashBox.Location = new System.Drawing.Point((width - 1024) / 2, (height - 768) / 2 - 30);
                this.MainFlashBox.Size = new System.Drawing.Size(1024, 768);
                this.MainFlashBox.Movie = System.Windows.Forms.Application.StartupPath + @strURL;
                swfPanel.Controls.Add(this.MainFlashBox);
                swfPanel.BringToFront();
            }
            else
            {
                switch (strType)
                {
                    case "PPT":
                        ControlPPTFonder.ControlPPT controlPPT = new ControlPPTFonder.ControlPPT();
                        controlPPT.PPTOpen(System.Windows.Forms.Application.StartupPath + @strURL);
                        break;
                    case "思维导图":
                        /* 思维导图*/
                        break;
                    case "视频":
                        /* 视频文件*/
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
        #endregion

        public TeachingSelectState teachingState = TeachingSelectState.OnClose;
        /// <summary>
        /// 我的课表动画效果
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_myteachingShrink_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt16(teachingPanel.Tag.ToString()) == 1)
            {
                teachingPanel.TimerStart(this.pic_myteachingMianban, this.btn_myteachingShrink);
            }
            else
            {
                if (Convert.ToInt16(teachingPanel.Tag.ToString()) == 0)
                {
                    teachingPanel.TimerStart(this.pic_myteachingMianban, this.btn_myteachingShrink);
                }
            }
            if (teachingState == TeachingSelectState.OnClose)
            {
                teachingState = TeachingSelectState.OnOpen;
            }
            else if (teachingState == TeachingSelectState.OnOpen)
            {
                teachingState = TeachingSelectState.OnClose;
            }
        }

        private void btn_search_Click_1(object sender, EventArgs e)
        {
            if (this.txt_search.Text == "搜索/Search" || this.txt_search.Text == "")
            {
                return;
            }
            SearchResultPage resultPage = new SearchResultPage(this.txt_search.Text);
            SecondPageManager.GetInstace.TableName = "AllTeaching";
            this.MainPanel.Controls.Add(resultPage);
            resultPage.BringToFront();
            this.listBox_searchRuslut.Visible = false;
            this.ControlBringToFront();
            this.listBox_searchRuslut.BringToFront();

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            foreach (Control item in MainPanel.Controls)
            {
                if (item.Name == "panel_searchpage" || item.Name == "panel_secondPage" || item.Name == "panel_OtherSecond")
                {
                    this.MainPanel.Controls.Remove(item);
                }
            }
        }
       

        private void button2_Click(object sender, EventArgs e)
        {
            ControlPPTFonder.ControlPPT controlPPT = new ControlPPTFonder.ControlPPT();
            controlPPT.PPTAuto(@System.Windows.Forms.Application.StartupPath + "\\ResourcesFolder\\MyTeaching\\asdasdsa.pptx",2);
        }

        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            //MessageBox.Show(e.KeyCode.ToString());
        }

        /// <summary>
        /// 关闭界面
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pic_close_Click(object sender, EventArgs e)
        {

            this.Close();

        }

        private void btn_myClassSearch_Click(object sender, EventArgs e)
        {

        }

        private void pic_min_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pic_max_Click(object sender, EventArgs e)
        {
            
        }
    }
}
