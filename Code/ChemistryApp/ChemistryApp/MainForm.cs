using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace ChemistryApp
{
    public partial class MainForm : Form
    {
        /// <summary>
        /// 存储左边lessonitem
        /// </summary>
        List<Panel> panelItem;
        /// <summary>
        /// 我的备课panel
        /// </summary>
        MyTeachingPanel teachingPanel;
        public MainForm()
        {
            InitializeComponent();
            SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            SetStyle(ControlStyles.UserPaint, true);
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
        }

        /// <summary>
        /// mainform加载
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainForm_Load(object sender, EventArgs e)
        {
            
            int mainFormWidth = Screen.PrimaryScreen.Bounds.Width;
            int mainFormHeight = Screen.PrimaryScreen.Bounds.Height;


            panelItem = new List<Panel>();
            //初始位置
            this.MainPanel.Location = new Point((mainFormWidth - 1024) / 2, (mainFormHeight - 768) / 2);
            this.Size = new Size(mainFormWidth, mainFormWidth);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string sql = "update LessonList set LessonID = '222?', LessonContent = '堵起！' where ID = 1";
            DialogResult dr = MessageBox.Show("提示信息", "提示信息", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (dr == DialogResult.Yes)
            {
                int i = AccessDBConn.ExecuteNonQuery(sql);
                if (i != 0)
                {
                    MessageBox.Show("操作成功");
                }
                else
                {
                    MessageBox.Show("操作失败！");
                }
            }
            else
            {
                MessageBox.Show("已经取消");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ControlPPT controlPPT = new ControlPPT();
            controlPPT.PPTOpen(@System.Windows.Forms.Application.StartupPath + "\\111.pptx");
            //controlPPT.PPTAuto(@System.Windows.Forms.Application.StartupPath + "\\111.pptx", 2);
        }


        #region 我的课表列表动画
        /// <summary>
        /// 左边收缩按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnShrink_Click(object sender, EventArgs e)
        {
            panelItem.Clear();
            //创建panel
            for (int i = 0; i < 20; i++)
            {
                MyLessonItem item = new MyLessonItem();
                panelItem.Add(item.CreateControl(10, i * (140 + 10)));
                this.panel_item.Controls.Add(panelItem[i]);
            }


            if (Convert.ToInt16(panel_classListBG.Tag.ToString()) == 1)
            {
                LeftPlaneTimer.Start();
                //panel_classListBG.Tag = 0;
                //this.panel_classListBG.Size = new Size(0, 626);
                //this.btn_shrink.Location = new Point(28, 349);
                //this.pic_titleBG.Location = new Point(0, 48);
            }
            else
            {
                if (Convert.ToInt16(panel_classListBG.Tag.ToString()) == 0)
                {
                    LeftPlaneTimer.Start();
                    //panel_classListBG.Tag = 1;
                    //this.panel_classListBG.Size = new Size(330, 626);
                    //this.btn_shrink.Location = new Point(358, 349);
                    //this.pic_titleBG.Location = new Point(328, 48);     
                }
            }
        }

        /// <summary>
        /// 定时器，做左边收缩按钮动画
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LeftPlaneTimer_Tick(object sender, EventArgs e)
        {
            int scrollWight = 20;
            long longWidth = panel_classListBG.Size.Width;
            //如果panel目前是隐藏的
            if (Convert.ToInt16(panel_classListBG.Tag.ToString()) == 0)
            {
                if (longWidth >= 330)
                {
                    LeftPlaneTimer.Enabled = false;
                    panel_classListBG.Tag = 1;//设置为显示标识
                    this.btn_shrink.BackgroundImage = global::ChemistryApp.Properties.Resources.btn_left1;
                    //this.LeftPlane.Size = new Size(320, 728);
                }
                else
                {
                    Point m_point = new Point();
                    m_point.X = this.pic_titleBG.Location.X + scrollWight;
                    m_point.Y = this.pic_titleBG.Location.Y;

                    Point btnPoint = new Point();
                    btnPoint.X = btn_shrink.Location.X + scrollWight;
                    btnPoint.Y = btn_shrink.Location.Y;

                    this.pic_titleBG.Location = m_point;
                    this.btn_shrink.Location = btnPoint;

                    panel_classListBG.Width += scrollWight;
                }
            }
            //如果panel目前是显示的
            if (Convert.ToInt16(panel_classListBG.Tag.ToString()) == 1)
            {
                if (longWidth <= 0)
                {
                    LeftPlaneTimer.Enabled = false;
                    panel_classListBG.Tag = 0;//设置为隐藏标识
                    this.btn_shrink.BackgroundImage = global::ChemistryApp.Properties.Resources.btn_right;
                }
                else
                {
                    Point m_point = new Point();
                    m_point.X = this.pic_titleBG.Location.X - scrollWight;
                    m_point.Y = this.pic_titleBG.Location.Y;

                    Point btnPoint = new Point();
                    btnPoint.X = btn_shrink.Location.X - scrollWight;
                    btnPoint.Y = btn_shrink.Location.Y;

                    this.btn_shrink.Location = btnPoint;
                    this.pic_titleBG.Location = m_point;
                    panel_classListBG.Width -= scrollWight;
                }
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

        }

        /// <summary>
        /// 知识回顾
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_KnowledgeReview_Click(object sender, EventArgs e)
        {
            MyLessonItem item = new MyLessonItem();
            
        }

        /// <summary>
        /// 课堂教学
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_ClassroomTeaching_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// 实验平台
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_ExperlmentalPlatform_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// 思维导图
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_MindMap_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// 视频资源
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_VideoSource_Click(object sender, EventArgs e)
        {

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
            this.listBox_searchRuslut.Visible = true;
            string sql = "select * from LessonList where  LessonID like '%" + this.txt_search.Text + "%'";
            DataSet ds = AccessDBConn.ExecuteQuery(sql);
            try
            {
                this.listBox_searchRuslut.Items.Clear();
                DataRow[] dr = ds.Tables["LessonList"].Select();
                foreach (var item in dr)
                {
                    this.listBox_searchRuslut.Items.Add(item["LessonID"].ToString());
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

        /// <summary>
        /// 当输入框失去焦点时不显示搜索结果
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txt_search_Leave(object sender, EventArgs e)
        {
            //this.listBox_searchRuslut.Visible = false;
        }

        /// <summary>
        /// 失去焦点时
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txt_search_Enter(object sender, EventArgs e)
        {
            
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

        private void listBox_searchRuslut_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }


        #region 我的课表编辑按钮
        private void btn_bianji_MouseDown(object sender, MouseEventArgs e)
        {
            this.btn_bianji.BackgroundImage = global::ChemistryApp.Properties.Resources.btn_bianji_2;
        }

        private void btn_bianji_MouseUp(object sender, MouseEventArgs e)
        {
            this.btn_bianji.BackgroundImage = global::ChemistryApp.Properties.Resources.btn_bianji;
        }
        #endregion


        /// <summary>
        /// 我的备课动画效果
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
        }
    }
    #endregion
}
