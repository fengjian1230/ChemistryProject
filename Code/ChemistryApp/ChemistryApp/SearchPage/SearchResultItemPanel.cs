using System;
using System.Windows.Forms;
using ChemistryApp.MyTeaching;
using ChemistryApp.SecondPage;
using System.Data;
using System.Linq;
using System.Drawing;

namespace ChemistryApp.SearchPage
{
    /// <summary>
    /// 搜索结果页面
    /// </summary>
    class SearchResultItemPanel : Panel
    {
        
        public System.Windows.Forms.PictureBox btn_playContent;
        public System.Windows.Forms.PictureBox pic_typeContent;
        public System.Windows.Forms.Label lab_titleContent;
        public System.Windows.Forms.PictureBox pic_insert;
        /// <summary>
        /// 类型
        /// </summary>
        public string strType;
        /// <summary>
        /// 路径
        /// </summary>
        public string strURL;

        public SearchResultItemPanel(int posX,int posY)
        {
            this.pic_insert = new System.Windows.Forms.PictureBox();
            this.lab_titleContent = new System.Windows.Forms.Label();
            this.pic_typeContent = new System.Windows.Forms.PictureBox();
            this.btn_playContent = new System.Windows.Forms.PictureBox();
            InitCompent(posX,posY);
            SetStyle(ControlStyles.UserPaint, true);
            SetStyle(ControlStyles.AllPaintingInWmPaint, true);   //   禁止擦除背景. 
            SetStyle(ControlStyles.DoubleBuffer, true);
        }

        private void InitCompent(int posX, int posY)
        {
            // 
            // panel_searchItem
            // 
            this.Controls.Add(this.btn_playContent);
            this.Controls.Add(this.pic_typeContent);
            this.Controls.Add(this.lab_titleContent);
            this.Controls.Add(this.pic_insert);
            this.Location = new System.Drawing.Point(0, posY);
            this.Name = "panel_searchItem";
            this.Size = new System.Drawing.Size(778, 36);
            this.TabIndex = 4;
            // 
            // pic_insert
            // 
            this.pic_insert.BackColor = System.Drawing.Color.Transparent;
            this.pic_insert.BackgroundImage = global::ChemistryApp.Properties.Resources.inserticon;
            this.pic_insert.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pic_insert.Location = new System.Drawing.Point(28, 11);
            this.pic_insert.Name = "pic_insert";
            this.pic_insert.Size = new System.Drawing.Size(19, 20);
            this.pic_insert.TabIndex = 0;
            this.pic_insert.Cursor = Cursors.Hand;
            this.pic_insert.TabStop = false;
            this.pic_insert.Click += new EventHandler(InsertButton_Click);
            // 
            // lab_titleContent
            // 
            this.lab_titleContent.AutoSize = true;
            this.lab_titleContent.Font = new System.Drawing.Font("苹方 常规", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(130)));
            this.lab_titleContent.Location = new System.Drawing.Point(80, 8);
            this.lab_titleContent.Name = "lab_titleContent";
            this.lab_titleContent.Size = new System.Drawing.Size(68, 28);
            this.lab_titleContent.TabIndex = 1;
            this.lab_titleContent.Text = "label2";
            // 
            // lab_typeContent
            // 
            this.pic_typeContent.AutoSize = true;
            this.pic_typeContent.Location = new System.Drawing.Point(430, 10);
            this.pic_typeContent.Name = "pic_typeContent";
            this.pic_typeContent.Size = new System.Drawing.Size(68, 28);
            this.pic_typeContent.TabIndex = 2;
            this.pic_typeContent.Image = global::ChemistryApp.Properties.Resources.inserticon;
            // 
            // btn_playContent
            // 
            this.btn_playContent.BackgroundImage = global::ChemistryApp.Properties.Resources.playicon;
            this.btn_playContent.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_playContent.Location = new System.Drawing.Point(717, 10);
            this.btn_playContent.Name = "btn_playContent";
            this.btn_playContent.Size = new System.Drawing.Size(18, 21);
            this.btn_playContent.TabIndex = 3;
            this.btn_playContent.TabStop = false;
            this.btn_playContent.Click += new EventHandler(ButtonPlayClick);
            this.btn_playContent.Cursor = Cursors.Hand;
        }


        /// <summary>
        /// 预览按键点击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void InsertButton_Click(object sender,EventArgs e)
        {
            string countSql = "select count(*) from MyTeaching";
            int count = AccessDBConn.ExecuteScalar(countSql);
            if (lab_titleContent.Text != "")
            {
                string insertSql = "insert into MyTeaching(TeachingTitle,TeachingType,URL,TeachingSort)values('" + lab_titleContent.Text + "','" + "" + this.strType + "','" + this.strURL + "',"+ (count-1).ToString()+")";
                int _insertErrorIndex = AccessDBConn.ExecuteNonQuery(insertSql);
                if (_insertErrorIndex != 0)
                {
                    MessageBox.Show("加入成功！");
                    MyTeachingItemManager.GetInstace.OnItemDelete?.Invoke();
                }
            }
        }
        /// <summary>
        /// 点击预览按键
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonPlayClick(object sender, EventArgs e)
        {
            try
            {
                //获取到mianpanel
                PictureBox currControl = (PictureBox)sender;
                MainForm mainForm = currControl.Parent.Parent.Parent.Parent.Parent.Parent as MainForm;
                string selectSql = "select * from " + SecondPageManager.GetInstace.TableName + " where Title = '" + this.lab_titleContent.Text + "'";
                DataSet ds = AccessDBConn.ExecuteQuery(selectSql, SecondPageManager.GetInstace.TableName);
                DataRow[] dr = ds.Tables[SecondPageManager.GetInstace.TableName].Select();
                PlaySwfPanel swfPanel = new PlaySwfPanel();
                mainForm.Controls.Add(swfPanel);
                //播放 flash的控件
                int width = Screen.PrimaryScreen.Bounds.Width;
                int height = Screen.PrimaryScreen.Bounds.Height;
                mainForm.MainFlashBox.Visible = true;
                mainForm.MainFlashBox.Location = new System.Drawing.Point((width - 1024) / 2, (height - 768) / 2 - 30);
                mainForm.MainFlashBox.Size = new System.Drawing.Size(1024, 768);
                mainForm.MainFlashBox.Movie = System.Windows.Forms.Application.StartupPath + @dr[0]["URL"].ToString();
                swfPanel.Controls.Add(mainForm.MainFlashBox);
                swfPanel.BringToFront();
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }


        }
    }
}
