using System;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using ChemistryApp.MyLesson;
using ChemistryApp.EnumType;
using ChemistryApp.SecondPage;

/// <summary>
/// 创建左边收缩panel中的课时item
/// </summary>
namespace ChemistryApp
{
    //生成item的背景
    class MyLessonItemBGPanel : Panel
    {
        public MyLessonItemBGPanel()
        {
            SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            SetStyle(ControlStyles.UserPaint, true);
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            InitControls();
        }

        private void InitControls()
        {
            // 
            // panel_item
            // 
            this.AutoScroll = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ForeColor = System.Drawing.Color.Black;
            this.ImeMode = System.Windows.Forms.ImeMode.On;
            this.Location = new System.Drawing.Point(20, 110);
            this.Name = "MyLessonItemBGPanel";
            this.Size = new System.Drawing.Size(315, 463);
            this.TabIndex = 17;
        }
    }

    class MyLessonItem : Panel
    {

        #region 字段
        public System.Windows.Forms.Panel panelItem;
        public System.Windows.Forms.Label lab_open;
        public System.Windows.Forms.Label lab_top;
        public System.Windows.Forms.PictureBox pic_top;
        public System.Windows.Forms.PictureBox pic_book;
        public System.Windows.Forms.Label lab_className;
        public System.Windows.Forms.Label lab_tips;
        public System.Windows.Forms.PictureBox pic_delete;
        public Button btn_againPrepareLesson;
        private bool isSearch;
        /// <summary>
        #endregion

        #region 构造函数
        /// <summary>
        /// 构造函数
        /// </summary>
        public MyLessonItem(int posX, int posY, string _strClassName, string _strTips,bool _isSearch )
        {

            //SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            //SetStyle(ControlStyles.UserPaint, true);
            //SetStyle(ControlStyles.OptimizedDoubleBuffer, true);

            //实例化控件
            panelItem = new Panel();
            lab_top = new Label();
            lab_className = new Label();
            lab_open = new Label();
            lab_tips = new Label();
            pic_top = new PictureBox();
            pic_book = new PictureBox();
            pic_delete = new PictureBox();
            this.btn_againPrepareLesson = new System.Windows.Forms.Button();
            this.isSearch = _isSearch;
            InitCompent(posX, posY, _strClassName, _strTips);

        }
        #endregion

        #region 创建控件
        /// <summary>
        /// 创建控件
        /// </summary>
        /// <returns></returns>
        public void InitCompent(int posX, int posY, string _strClassName, string _strTips)
        {
           
            // panel1
            // 
            this.BackColor = System.Drawing.Color.Transparent;
            this.BackgroundImage = global::ChemistryApp.Properties.Resources.myLessonItemBG;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Controls.Add(this.btn_againPrepareLesson);
            this.Controls.Add(this.lab_tips);
            this.Controls.Add(this.lab_className);
            this.Controls.Add(this.pic_book);
            this.Controls.Add(this.lab_open);
            this.Controls.Add(this.lab_top);
            this.Controls.Add(this.pic_top);
            this.Controls.Add(this.pic_delete);
           
            this.Font = new System.Drawing.Font("苹方 特粗", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Location = new System.Drawing.Point(posX, posY);
            this.Name = "panelItem";
            this.Size = new System.Drawing.Size(279, 140);
            this.TabIndex = 1;
            ///删除键
            this.pic_delete.Name = "pic_delete";
            this.pic_delete.Size = new Size(15, 15);
            this.pic_delete.BackgroundImage = global::ChemistryApp.Properties.Resources.删除键;
            this.pic_delete.Location = new System.Drawing.Point(315, 70);
            this.pic_delete.TabIndex = 0;
            this.pic_delete.Cursor = Cursors.Hand;
            this.pic_delete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pic_delete.BackColor = System.Drawing.Color.Transparent;
            this.pic_delete.Click += new EventHandler(this.BtnDelete_Click);
            // 
            // btn_againPrepareLesson
            // 
            this.btn_againPrepareLesson.BackgroundImage = global::ChemistryApp.Properties.Resources.btnAgain_norml;
            this.btn_againPrepareLesson.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_againPrepareLesson.FlatAppearance.BorderSize = 0;
            this.btn_againPrepareLesson.BackColor = Color.Transparent;
            this.btn_againPrepareLesson.Cursor = Cursors.Hand;
            this.btn_againPrepareLesson.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_againPrepareLesson.Location = new System.Drawing.Point(90, 110);
            this.btn_againPrepareLesson.Name = "btn_againPrepareLesson";
            this.btn_againPrepareLesson.Size = new System.Drawing.Size(90, 24);
            this.btn_againPrepareLesson.TabIndex = 20;
            this.btn_againPrepareLesson.UseVisualStyleBackColor = true;
            this.btn_againPrepareLesson.Anchor = AnchorStyles.Bottom;
            this.btn_againPrepareLesson.Visible = false;
            this.btn_againPrepareLesson.Click += new EventHandler(BtnAgainLesson_Click);
            // 
            // pictureBox2
            // 
            this.pic_top.Location = new System.Drawing.Point(4, 8);
            this.pic_top.BackgroundImage = global::ChemistryApp.Properties.Resources._1_03;
            this.pic_top.BackgroundImageLayout = ImageLayout.Center;
            this.pic_top.Name = "pictureBox2";
            this.pic_top.Size = new System.Drawing.Size(19, 21);
            this.pic_top.TabIndex = 0;
            this.pic_top.TabStop = false;
            this.pic_top.Cursor = Cursors.Hand;
            this.pic_top.Click += new EventHandler(TopLabelClick);
            // 
            // label1
            // 
            this.lab_top.AutoSize = true;
            this.lab_top.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lab_top.Font = new System.Drawing.Font("苹方 中等", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lab_top.Location = new System.Drawing.Point(22, 7);
            this.lab_top.Name = "lab_top";
            this.lab_top.Size = new System.Drawing.Size(40, 21);
            this.lab_top.TabIndex = 1;
            this.lab_top.Text = "置顶";
            this.lab_top.Click += new EventHandler(TopLabelClick);
            // 
            // label2
            // 
            this.lab_open.AutoSize = true;
            this.lab_open.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lab_open.Font = new System.Drawing.Font("苹方 中等", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lab_open.Location = new System.Drawing.Point(239, 7);
            this.lab_open.Name = "lab_open";
            this.lab_open.Size = new System.Drawing.Size(40, 21);
            this.lab_open.TabIndex = 2;
            this.lab_open.Text = "展开";
            this.lab_open.Click += new EventHandler(OpenLabelClick);
            // 
            // pictureBox3
            // 
            this.pic_book.Location = new System.Drawing.Point(19, 46);
            this.pic_book.BackgroundImage = global::ChemistryApp.Properties.Resources.课件播放icon;
            this.pic_book.Name = "pic_book";
            this.pic_book.BackgroundImageLayout = ImageLayout.Center;
            this.pic_book.Size = new System.Drawing.Size(57, 64);
            this.pic_book.TabIndex = 3;
            this.pic_book.TabStop = false;
            this.pic_book.Cursor = Cursors.Hand;
            this.pic_book.Click += new EventHandler(OnClickPlayPPT_Click);
            // 
            // label3
            // 
            this.lab_className.AutoSize = true;
            this.lab_className.Font = new System.Drawing.Font("苹方 中等", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lab_className.Location = new System.Drawing.Point(86, 41);
            this.lab_className.Name = "lab_classTime";
            this.lab_className.Size = new System.Drawing.Size(90, 34);
            this.lab_className.TabIndex = 4;
            this.lab_className.Text = _strClassName;
            // 
            // label4
            // 
            this.lab_tips.AutoSize = true;
            this.lab_tips.Font = new System.Drawing.Font("苹方 中等", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lab_tips.Location = new System.Drawing.Point(90, 88);
            this.lab_tips.Name = "lab_tips";
            this.lab_tips.Size = new System.Drawing.Size(164, 18);
            this.lab_tips.TabIndex = 5;
            this.lab_tips.DoubleClick += Lab_tips_DoubleClick;
            this.lab_tips.Text = _strTips;

            CreateChildItem();
        }

      
        #endregion



        #region 事件
        /// <summary>
        /// 置顶按钮点击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TopLabelClick(object sender, EventArgs e)
        {
            if (MyLessonItemManager.GetInstace.bianjiState == BianJiState.Bianji)
            {
                try
                {
                    //查询到所有结果
                    //string selectSqlStr = "select * from LessonList where  LessonTitle like '%" + this.lab_className.Text + "%'";
                    //DataSet selectDs = AccessDBConn.ExecuteQuery(selectSqlStr, "LessonList");
                    //更改全部列为flase
                    string updateSqlStrFlase = "update LessonList set IsTop = 'false'";
                    AccessDBConn.ExecuteNonQuery(updateSqlStrFlase);
                    //拿到ID可以从数据库中读取然后置顶
                    string updateSqlStrTrue = "update LessonList set IsTop = 'true' where LessonTitle = '" + this.lab_className.Text + "'";
                    AccessDBConn.ExecuteNonQuery(updateSqlStrTrue);
                    MyLessonItemManager.GetInstace.OnDeleteFinish?.Invoke();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

        }

        /// <summary>
        /// 展开按钮点击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OpenLabelClick(object sender,EventArgs e)
        {
            int itemLength = 0;
            Label pic = (Label)sender;
            pic.Parent.BackgroundImageLayout = ImageLayout.None;
            pic.Parent.BringToFront();
            for (int i = 0; i < MyLessonItemManager.GetInstace.ChildItemNum.Count; i++)
            {
                if (MyLessonItemManager.GetInstace.ChildItemNum.ContainsKey(this.lab_className.Text))
                {
                    itemLength = MyLessonItemManager.GetInstace.ChildItemNum[this.lab_className.Text];
                }
            }
            if (MyLessonItemManager.GetInstace.state == LessonItemState.Close)
            {
                pic.Text = "展开";
                this.btn_againPrepareLesson.Visible = false;
                MyLessonItemManager.GetInstace.state = LessonItemState.Open;
                pic.Parent.Size = new Size(pic.Parent.Size.Width, 140);
                
            }
            else if (MyLessonItemManager.GetInstace.state == LessonItemState.Open && MyLessonItemManager.GetInstace.bianjiState == BianJiState.Bianji)
            {
                pic.Text = "折叠";
                this.btn_againPrepareLesson.Visible = true;
                pic.Parent.Size = new Size(pic.Parent.Size.Width, 180 + itemLength * 30);
                MyLessonItemManager.GetInstace.state = LessonItemState.Close;
            }
           
        }

        /// <summary>
        /// 删除按钮点击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnDelete_Click(object sender,EventArgs e)
        {
            ConfirmDialogBox confirmBox = new ConfirmDialogBox(ButtonDeleteEvent);
            PictureBox pic = (PictureBox)sender;
            Control mainPanle = pic.Parent.Parent.Parent.Parent as Control;
            mainPanle.Controls.Add(confirmBox);
            confirmBox.BringToFront();
        }
        private void ButtonDeleteEvent(object sender, EventArgs e)
        {
            try
            {
                //查询到所有结果
                string selectSqlStr = "select * from LessonList where  LessonTitle = '" + this.lab_className.Text + "'";
                DataSet selectDs = AccessDBConn.ExecuteQuery(selectSqlStr, "LessonList");
                DataRow[] selectRow = selectDs.Tables["LessonList"].Select();
                if (selectRow[0]["IsTop"].ToString() == "true")
                {
                    MyLessonItemManager.GetInstace.isDeleteFirstItem = true;
                    MyLessonItemManager.GetInstace.filedName = this.lab_className.Text;

                }
                //拿到ID可以从数据库中读取然后置顶x
                string sqlStr = "delete from LessonList where LessonTitle = '" + this.lab_className.Text + "'";
                string deleteChildTabel = "drop table " + selectRow[0]["LessonContent"].ToString() + "";
                int i = AccessDBConn.ExecuteNonQuery(sqlStr);// && deleteErrorIndex != 0
                int deleteErrorIndex = AccessDBConn.ExecuteNonQuery(deleteChildTabel);
                if (i != 0)
                {
                    ((PictureBox)sender).Parent.Parent.Controls.Remove(((PictureBox)sender).Parent);
                    MessageBox.Show("删除完成!");
                    MyLessonItemManager.GetInstace.bianjiState = BianJiState.Bianji;
                    MyLessonItemManager.GetInstace.OnDeleteFinish?.Invoke();
                }
                else
                {
                    MessageBox.Show("删除未完成！");
                }
               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }   
        }

        /// <summary>
        /// 再次备课
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnAgainLesson_Click(object sender,EventArgs e)
        {
            //先要清空课件表中原来的数据
            string deleteSql = "delete * from MyTeaching";
            int errorIndex = AccessDBConn.ExecuteNonQuery(deleteSql);
            //先得到当前课表的子表的字段
            string selectSql = "select LessonContent from LessonList where LessonTitle = '" + this.lab_className.Text + "'";
            DataSet data = AccessDBConn.ExecuteQuery(selectSql, "LessonList");
            DataRow[] dataRow = data.Tables["LessonList"].Select();
            //从字段中读取表的内容
            string _childStr = "select * from " + dataRow[0]["LessonContent"].ToString() + "";
            DataSet childData = AccessDBConn.ExecuteQuery(_childStr, dataRow[0]["LessonContent"].ToString());
            DataRow[] childDataRow = childData.Tables[dataRow[0]["LessonContent"].ToString()].Select();
            //从读取的表中插入到我的课件表中
            for (int i = 0; i < childDataRow.Count(); i++)
            {
                string insertSql = "insert into MyTeaching(TeachingTitle,TeachingType,URL,TeachingSort)values('" + childDataRow[i]["Title"] + "','" + childDataRow[i]["Type"] + "','" + childDataRow[i]["URL"] + "','" + i.ToString() + "')";
                int insertErrorIndex = AccessDBConn.ExecuteNonQuery(insertSql);
                if (insertErrorIndex != 0)
                {
                   
                }
            }
            MessageBox.Show("在右边课件中继续备课！");
            MainForm mainForm = ((Control)sender).Parent.Parent.Parent.Parent.Parent as MainForm;
            MyTeaching.MyTeachingItemManager.GetInstace.ShowTeachingCount(mainForm);
            MyTeaching.MyTeachingItemManager.GetInstace.OnItemDelete?.Invoke();
            if (Convert.ToInt16(mainForm.teachingPanel.Tag.ToString()) == 1)
            {
                mainForm.teachingPanel.TimerStart(mainForm.pic_myteachingMianban, mainForm.btn_myteachingShrink);
            }

        }

        /// <summary>
        /// 点击播放ppt
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnClickPlayPPT_Click(object sender,EventArgs e)
        {
            if (MyLessonItemManager.GetInstace.bianjiState == BianJiState.Wancheng)
            {
                return;
            }
            MyLessonItemManager.GetInstace.lessonFiledName = this.lab_className.Text;
            Control mainPanel = ((Control)sender).Parent.Parent.Parent.Parent;
            mainPanel.Visible = false;
            ContentPlayPanel contentPanel = new SecondPage.ContentPlayPanel(false);
            mainPanel.Parent.Controls.Add(contentPanel);
            contentPanel.listContentItem[0].PlayButtonOnPPTPage_Click(sender, e);
        }

        /// <summary>
        /// 播放完成后根据index播放下个
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        private string OnIndexGetPath(int index,string _string)
        {
            string _str = null;
            string sql = "select * from LessonList where  LessonTitle = '" + this.lab_className.Text + "'";
            try
            {
                DataSet ds = AccessDBConn.ExecuteQuery(sql, "LessonList");
                DataRow[] dr = ds.Tables["LessonList"].Select();
                //根据字段查询到子表，然后找到路径预览课件
                string selectChildSql = "select top " + index.ToString() +" * from " + dr[0]["LessonContent"] + "";
                DataSet childDs = AccessDBConn.ExecuteQuery(selectChildSql, dr[0]["LessonContent"].ToString());
                DataRow[] childDr = childDs.Tables[dr[0]["LessonContent"].ToString()].Select();
                _str = childDr[0][_string].ToString();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return _str;
        }

        private void CreateChildItem()
        {
            //先拿到字段
            string sqlStr = "select * from LessonList where LessonTitle = '" + this.lab_className.Text + "'";//order by ListID asc"; //(select LessonContent from LessonList where ID = 1)";
            DataSet data = AccessDBConn.ExecuteQuery(sqlStr, "LessonList");
            DataRow[] dataRow = data.Tables["LessonList"].Select();
            //在从字段中读取到表名
            string _childStr = "select * from  " + dataRow[0]["LessonContent"].ToString() + "";
            DataSet childData = AccessDBConn.ExecuteQuery(_childStr, dataRow[0]["LessonContent"].ToString());
            DataRow[] childDataRow = childData.Tables[dataRow[0]["LessonContent"].ToString()].Select();
            //创建课表列表
            for (int j = 0; j < childDataRow.Count(); j++)
            {
                MyLessonChildItem childPanel = new MyLessonChildItem(0, 140 + j * 30, childDataRow[j]["Title"].ToString(), childDataRow[j]["Type"].ToString(), dataRow[0]["LessonTitle"].ToString());
                if (j % 2 == 0)
                {
                    childPanel.BackColor = Color.FromArgb(245, 245, 247);
                }
                else
                {
                    childPanel.BackColor = Color.White;
                }
                this.Controls.Add(childPanel);
                childPanel.BringToFront();
            }
            if (!isSearch)
            {
                MyLessonItemManager.GetInstace.ChildItemNum.Add(this.lab_className.Text, childDataRow.Count());
            }
        }

        /// <summary>
        /// 双击备注修改备注
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Lab_tips_DoubleClick(object sender, EventArgs e)
        {
            UpdateLessonItemTips updateTips = new UpdateLessonItemTips();
            updateTips.txt_className.Text = this.lab_className.Text;
            updateTips.txt_tips.Text = this.lab_tips.Text;
            updateTips.updateLessonItem = this;
            Control mainpanel = ((Control)sender).Parent.Parent.Parent.Parent as  Control;
            mainpanel.Controls.Add(updateTips);
            updateTips.BringToFront();
        }
        #endregion
    }
}
