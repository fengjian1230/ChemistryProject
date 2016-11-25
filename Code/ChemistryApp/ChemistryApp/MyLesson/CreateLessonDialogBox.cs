using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using ChemistryApp.MyTeaching;


namespace ChemistryApp.MyLesson
{
    public class CreateLessonDialogBox
    {
        public System.Windows.Forms.Panel panel_createDialog;
        public System.Windows.Forms.PictureBox btn_cancel;
        public System.Windows.Forms.PictureBox btn_ok;
        public System.Windows.Forms.TextBox txt_tips;
        public System.Windows.Forms.Label lab_tips;
        public System.Windows.Forms.TextBox txt_className;
        public System.Windows.Forms.Label lab_className;
        public PictureBox pic_dialogBG;

        /// <summary>
        /// 构造函数
        /// </summary>
        public CreateLessonDialogBox()
        {
            panel_createDialog = new Panel();
            btn_cancel = new PictureBox();
            btn_ok = new PictureBox();
            txt_className = new TextBox();
            txt_tips = new TextBox();
            lab_tips = new Label();
            lab_className = new Label();
            pic_dialogBG = new PictureBox();
        }

        /// <summary>
        /// 创建窗口
        /// </summary>
        public Panel CreateDialgBox()
        {


           
            // 
            // panel_createDialog
            // 
            this.panel_createDialog.Controls.Add(this.btn_cancel);
            this.panel_createDialog.Controls.Add(this.btn_ok);
            this.panel_createDialog.Controls.Add(this.txt_tips);
            this.panel_createDialog.Controls.Add(this.lab_tips);
            this.panel_createDialog.Controls.Add(this.txt_className);
            this.panel_createDialog.Controls.Add(this.lab_className);
            this.panel_createDialog.Controls.Add(this.pic_dialogBG);
            this.panel_createDialog.Location = new System.Drawing.Point(324, 277);
            this.panel_createDialog.Name = "panel_createDialog";
            this.panel_createDialog.Size = new System.Drawing.Size(363, 230);
            this.panel_createDialog.TabIndex = 1;
            this.panel_createDialog.BringToFront();
            
            // 
            // pic_dialogBG
            // 
            this.pic_dialogBG.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pic_dialogBG.Image = global::ChemistryApp.Properties.Resources.d_bg;
            this.pic_dialogBG.Location = new System.Drawing.Point(0, 0);
            this.pic_dialogBG.Name = "pic_dialogBG";
            this.pic_dialogBG.Size = new System.Drawing.Size(363, 158);
            this.pic_dialogBG.TabIndex = 0;
            this.pic_dialogBG.TabStop = false;

            // 
            // btn_cancel
            // 
            this.btn_cancel.BackColor = System.Drawing.Color.Transparent;
            this.btn_cancel.Image = global::ChemistryApp.Properties.Resources.cancel_up;
            this.btn_cancel.Location = new System.Drawing.Point(0, 157);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(182, 76);
            this.btn_cancel.TabIndex = 6;
            this.btn_cancel.TabStop = false;
            this.btn_cancel.Click += new EventHandler(BtnCancel_Click);
            this.btn_cancel.Cursor = Cursors.Hand;
            // 
            // btn_ok
            // 
            this.btn_ok.BackColor = System.Drawing.Color.Transparent;
            this.btn_ok.Image = global::ChemistryApp.Properties.Resources.comfire_up;
            this.btn_ok.Location = new System.Drawing.Point(182, 157);
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.Size = new System.Drawing.Size(182, 76);
            this.btn_ok.TabIndex = 5;
            this.btn_ok.TabStop = false;
            this.btn_ok.Click += new EventHandler(BtnOK_Click);
            this.btn_ok.Cursor = Cursors.Hand;
            // 
            // txt_tips
            // 
            this.txt_tips.ForeColor = System.Drawing.Color.Black;
            this.txt_tips.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txt_tips.Location = new System.Drawing.Point(102, 84);
            this.txt_tips.Name = "txt_tips";
            this.txt_tips.Size = new System.Drawing.Size(235, 27);
            this.txt_tips.TabIndex = 4;
            // 
            // txt_className
            // 
            this.txt_className.ForeColor = System.Drawing.Color.Black;
            this.txt_className.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txt_className.Location = new System.Drawing.Point(102, 19);
            this.txt_className.Name = "txt_className";
            this.txt_className.Size = new System.Drawing.Size(235, 27);
            this.txt_className.TabIndex = 3;

            // 
            // lab_className
            // 
            this.lab_className.AutoSize = true;
            this.lab_className.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(83)))), ((int)(((byte)(83)))));
            this.lab_className.Font = new System.Drawing.Font("微软雅黑", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lab_className.ForeColor = System.Drawing.Color.White;
            this.lab_className.Location = new System.Drawing.Point(17, 14);
            this.lab_className.Name = "lab_className";
            this.lab_className.Size = new System.Drawing.Size(62, 31);
            this.lab_className.TabIndex = 1;
            this.lab_className.Text = "命名";
            // 
            // label2
            // 
            this.lab_tips.AutoSize = true;
            this.lab_tips.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(83)))), ((int)(((byte)(83)))));
            this.lab_tips.Font = new System.Drawing.Font("微软雅黑", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lab_tips.ForeColor = System.Drawing.Color.White;
            this.lab_tips.Location = new System.Drawing.Point(17, 80);
            this.lab_tips.Name = "lab_tips";
            this.lab_tips.Size = new System.Drawing.Size(62, 31);
            this.lab_tips.TabIndex = 2;
            this.lab_tips.Text = "备注";


            return panel_createDialog;
        }

        /// <summary>
        /// 点击取消
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnCancel_Click(object sender,EventArgs e)
        {
            PictureBox btn = (PictureBox)sender;
            Panel mainPanel = btn.Parent.Parent as Panel;
            foreach (Control item in mainPanel.Controls)
            {
                if (item.Name == "panel_createDialog")
                {
                    mainPanel.Controls.Remove(item);
                }
            }
        }

        /// <summary>
        /// 确定按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnOK_Click(object sender,EventArgs e)
        {
            try
            {
                string _strTitle = "";
                string _strType = "";
                string _strURL = "";
                //创建课件的数据表
                ADOX.Column[] columns = {
                                 new ADOX.Column(){Name="Title",DefinedSize=50},
                                 new ADOX.Column(){Name="URL",DefinedSize=50},
                                 new ADOX.Column(){Name="Type",DefinedSize=50}
                             };
                int _creatErrorIndex = AccessDBConn.CreateAccessTable("课件" + txt_className.Text, columns);
                if (_creatErrorIndex == 0)
                {
                    MessageBox.Show("创建不成功！");
                }
                //从课件表中读取数据，然后放入到课表中去
                if (MyTeachingItemManager.GetInstace.listPanelItem.Count != 0)
                {
                    for (int i = 0; i < MyTeachingItemManager.GetInstace.listPanelItem.Count; i++)
                    {

                        Label item = MyTeachingItemManager.GetInstace.listPanelItem[i].GetChildAtPoint(new Point(100, 39)) as Label;
                        string _selectSql = "select * from MyTeaching where TeachingTitle = '" + item.Text + "'";
                        DataSet ds = AccessDBConn.ExecuteQuery(_selectSql, "MyTeaching");
                        DataRow[] dr = ds.Tables["MyTeaching"].Select();
                        _strTitle = item.Text;
                        _strType = dr[0]["TeachingType"].ToString();
                        _strURL = dr[0]["URL"].ToString();
                        //在空表中插入数据
                        string insertSql = "insert into 课件" + txt_className.Text + "(Title,URL,Type)values('" + _strTitle + "','" + _strURL + "','" + _strType + "')";
                        int inserErrorIndex = AccessDBConn.ExecuteNonQuery(insertSql);
                        if (inserErrorIndex == 0)
                        {
                            MessageBox.Show("失败！");
                        }
                    }
                }

                //插入到lessonlist表中
                string sql = "insert into LessonList(LessonTitle,LessonContent,Tips,IsTop,State,ListID)values('" + txt_className.Text + "','" + "课件" + txt_className.Text + "','" + txt_tips.Text + "','false','Finish',3)";
                //MessageBox.Show(sql);
                int _insertErrorIndex = AccessDBConn.ExecuteNonQuery(sql);
                if (_insertErrorIndex != 0)
                {
                    PictureBox btn = (PictureBox)sender;
                    Panel mainPanel = btn.Parent.Parent as Panel;
                    foreach (Control item in mainPanel.Controls)
                    {
                        if (item.Name == "panel_createDialog")
                        {
                            mainPanel.Controls.Remove(item);
                        }
                    }
                    MessageBox.Show("创建成功！");
                    MyLessonItemManager.GetInstace.OnDeleteFinish?.Invoke();
                }
                else
                {
                    MessageBox.Show("创建失败！");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           
        }
    }

}
