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

        /// <summary>
        #endregion

        #region 构造函数
        /// <summary>
        /// 构造函数
        /// </summary>
        public MyLessonItem(int posX, int posY, string _strClassName, string _strTips)
        {
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
            this.lab_tips.Location = new System.Drawing.Point(83, 88);
            this.lab_tips.Name = "lab_tips";
            this.lab_tips.Size = new System.Drawing.Size(164, 18);
            this.lab_tips.TabIndex = 5;
            this.lab_tips.Text = "（" + _strTips + "）";
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
                int topIndex = 0;
                //拿到ID可以从数据库中读取然后置顶
                Label pic = (Label)sender;
                Control control = pic.Parent.GetChildAtPoint(new Point(86, 41));
                Label label = (Label)control;
                string sqlStr = "select * from LessonList where  LessonTitle like '%" + label.Text + "%'";
                DataSet ds = AccessDBConn.ExecuteQuery(sqlStr, "LessonList");
                try
                {
                    DataRow[] dr = ds.Tables["LessonList"].Select();

                    int index = int.Parse(dr[0]["ListID"].ToString());
                    MyLessonItemManager.GetInstace.listPanelItem[index].Location = MyLessonItemManager.GetInstace.listPanelItemPoint[topIndex];

                    for (int i = 0; i < MyLessonItemManager.GetInstace.listPanelItem.Count; i++)
                    {
                        if (i != index)
                        {
                            topIndex++;
                            MyLessonItemManager.GetInstace.listPanelItem[i].Location = MyLessonItemManager.GetInstace.listPanelItemPoint[topIndex];

                        }
                    }
                    foreach (var item in dr)
                    {


                    }

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
            Control control = pic.Parent.GetChildAtPoint(new Point(86, 41));
            Label label = (Label)control;
            pic.Parent.BackgroundImageLayout = ImageLayout.None;
            for (int i = 0; i < MyLessonItemManager.GetInstace.ChildItemNum.Count; i++)
            {
                if (MyLessonItemManager.GetInstace.ChildItemNum.ContainsKey(label.Text))
                {
                    itemLength = MyLessonItemManager.GetInstace.ChildItemNum[label.Text];
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
            MessageBox.Show("删除完成!");
            //MessageBoxButtons messButton = MessageBoxButtons.OKCancel;
            //PictureBox pic = (PictureBox)sender;
            //Control control = pic.Parent.GetChildAtPoint(new Point(86, 41));
            //Label label = (Label)control;
            //string sqlStr = "delete from LessonList where LessonTitle = '" + label.Text + "'";
            //DialogResult dr = MessageBox.Show("确定要删除吗?", "删除", messButton);
            //int i = AccessDBConn.ExecuteNonQuery(sqlStr);
            //if (i != 0)
            //{
            //    MessageBox.Show("删除完成!");
            //    MyLessonItemManager.GetInstace.OnDeleteFinish?.Invoke();
            //}
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
            if (errorIndex != 0)
            {
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
                MyTeaching.MyTeachingItemManager.GetInstace.OnItemDelete?.Invoke();
            }
        }

        /// <summary>
        /// 点击播放ppt
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnClickPlayPPT_Click(object sender,EventArgs e)
        {
            MyLessonItemManager.GetInstace.lessonFiledName = this.lab_className.Text;
            Control mainPanel = ((PictureBox)sender).Parent.Parent.Parent.Parent;
            mainPanel.Visible = false;
            ChemistryApp.SecondPage.ContentPlayPanel contentPanel = new SecondPage.ContentPlayPanel();
            mainPanel.Parent.Controls.Add(contentPanel);
            contentPanel.ContentControlFramer.Open(@System.Windows.Forms.Application.StartupPath + @OnIndexGetPath(1));
        }

        /// <summary>
        /// 播放完成后根据index播放下个
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        private string OnIndexGetPath(int index)
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
                _str = childDr[0]["URL"].ToString();
            }
            catch
            {

            }
            return _str;
        }
        #endregion
    }
}
