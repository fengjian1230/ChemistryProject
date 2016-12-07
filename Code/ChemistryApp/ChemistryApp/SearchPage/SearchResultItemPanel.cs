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
    public class SearchResultItemPanel : Panel
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
        /// <summary>
        /// 标题
        /// </summary>
        public string strTitle;

        public SearchResultItemPanel(int posX, int posY ,string _strType,string _strTitle,string _strURL)
        {
            this.pic_insert = new System.Windows.Forms.PictureBox();
            this.lab_titleContent = new System.Windows.Forms.Label();
            this.pic_typeContent = new System.Windows.Forms.PictureBox();
            this.btn_playContent = new System.Windows.Forms.PictureBox();
            SetStyle(ControlStyles.UserPaint, true);
            SetStyle(ControlStyles.AllPaintingInWmPaint, true);   //   禁止擦除背景. 
            SetStyle(ControlStyles.DoubleBuffer, true);
            this.strType = _strType;
            this.strTitle = _strTitle;
            this.strURL = _strURL;
            InitCompent(posX, posY);
        }

        public SearchResultItemPanel(int posX, int posY)
        {
            this.pic_insert = new System.Windows.Forms.PictureBox();
            this.lab_titleContent = new System.Windows.Forms.Label();
            this.pic_typeContent = new System.Windows.Forms.PictureBox();
            this.btn_playContent = new System.Windows.Forms.PictureBox();
            SetStyle(ControlStyles.UserPaint, true);
            SetStyle(ControlStyles.AllPaintingInWmPaint, true);   //   禁止擦除背景. 
            SetStyle(ControlStyles.DoubleBuffer, true);
            InitCompent(posX, posY);
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
            this.DoubleClick += new EventHandler(ButtonPlayClick);
            // 
            // pic_insert
            // 
            this.pic_insert.BackColor = System.Drawing.Color.Transparent;
            this.pic_insert.BackgroundImage = global::ChemistryApp.Properties.Resources.inserticon;
            this.pic_insert.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pic_insert.Location = new System.Drawing.Point(670, 11);
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
            this.lab_titleContent.Text = this.strTitle;
            // 
            // lab_typeContent
            // 
            this.pic_typeContent.AutoSize = true;
            this.pic_typeContent.Location = new System.Drawing.Point(430, 10);
            this.pic_typeContent.Name = "pic_typeContent";
            this.pic_typeContent.Size = new System.Drawing.Size(68, 28);
            this.pic_typeContent.TabIndex = 2;
            this.pic_typeContent.Image = SelectTypeIcon(strType);
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
        /// 添加按键点击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void InsertButton_Click(object sender, EventArgs e)
        {
            try
            {
                string selectSql = "select * from MyTeaching where TeachingTitle= '" + strTitle + "'";
                DataSet ds = AccessDBConn.ExecuteQuery(selectSql, "MyTeaching");
                DataRow[] dr = ds.Tables["MyTeaching"].Select();
                if (dr.Length == 0)
                {
                    string countSql = "select count(*) from MyTeaching";
                    int count = AccessDBConn.ExecuteScalar(countSql);
                    if (lab_titleContent.Text != "")
                    {
                        string insertSql = "insert into MyTeaching(TeachingTitle,TeachingType,URL,TeachingSort)values('" + strTitle + "','" + "" + this.strType + "','" + this.strURL + "'," + count.ToString() + ")";
                        int _insertErrorIndex = AccessDBConn.ExecuteNonQuery(insertSql);
                        if (_insertErrorIndex != 0)
                        {
                            MainForm mainForm = ((Control)sender).Parent.Parent.Parent.Parent.Parent.Parent as MainForm;
                            MyTeachingItemManager.GetInstace.ShowTeachingCount(mainForm);
                            MessageBox.Show("加入成功！");
                            MyTeachingItemManager.GetInstace.OnItemDelete?.Invoke();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("不能重复添加课件!");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }

        }
        /// <summary>
        /// 点击预览按键
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonPlayClick(object sender, EventArgs e)
        {
            //获取到mianpanel

            Control currControl = (Control)sender;
            MainForm mainForm = null;
            if (SecondPageManager.GetInstace.TableName == "AllTeaching")
            {
                if (((Control)sender).Name == this.Name)
                {
                    mainForm = currControl.Parent.Parent.Parent.Parent as MainForm;
                }
                else
                {
                    mainForm = currControl.Parent.Parent.Parent.Parent.Parent as MainForm;
                }
            }
            else
            {
                if (((Control)sender).Name == this.Name)
                {
                    mainForm = currControl.Parent.Parent.Parent.Parent.Parent as MainForm;
                }
                else
                {
                    mainForm = currControl.Parent.Parent.Parent.Parent.Parent.Parent as MainForm;
                }
            }
            string selectSql = "select * from " + SecondPageManager.GetInstace.TableName + " where Title = '" + this.lab_titleContent.Text + "'";
            DataSet ds = AccessDBConn.ExecuteQuery(selectSql, SecondPageManager.GetInstace.TableName);
            DataRow[] dr = ds.Tables[SecondPageManager.GetInstace.TableName].Select();
            
            PlaySwfPanel swfPanel = new PlaySwfPanel();
            mainForm.Controls.Add(swfPanel);
            int width = Screen.PrimaryScreen.Bounds.Width;
            int height = Screen.PrimaryScreen.Bounds.Height;
            if (dr.Length != 0)
            {
                if (dr[0]["URL"].ToString().Substring(dr[0]["URL"].ToString().Length - 3, 3) == "swf")
                {
                    mainForm.Controls.Add(swfPanel);
                    //播放 flash的控件
                    mainForm.MainFlashBox.Visible = true;
                    mainForm.MainFlashBox.Location = new System.Drawing.Point((width - 1024) / 2, (height - 768) / 2 - 30);
                    mainForm.MainFlashBox.Size = new System.Drawing.Size(1024, 768);
                    mainForm.MainFlashBox.Movie = System.Windows.Forms.Application.StartupPath + dr[0]["URL"].ToString();
                    swfPanel.Controls.Add(mainForm.MainFlashBox);
                    swfPanel.BringToFront();
                }
                else
                {
                    switch (dr[0]["Type"].ToString())
                    {
                        case "PPT":
                            mainForm.Controls.Remove(swfPanel);
                            swfPanel = null;
                            ControlPPTFonder.ControlPPT controlPPT = new ControlPPTFonder.ControlPPT();
                            controlPPT.PPTOpen(System.Windows.Forms.Application.StartupPath + dr[0]["URL"].ToString());
                            break;
                        case "思维导图":
                            /* 思维导图*/
                            break;
                        case "视频":
                            mainForm.Controls.Add(swfPanel);
                            //播放 flash的控件
                            mainForm.previewAudioWindow.Visible = true;
                            mainForm.previewAudioWindow.Location = new System.Drawing.Point((width - 1024) / 2, (height - 768) / 2 - 30);
                            mainForm.previewAudioWindow.Size = new System.Drawing.Size(1024, 768);
                            mainForm.previewAudioWindow.URL = System.Windows.Forms.Application.StartupPath + dr[0]["URL"].ToString();
                            swfPanel.Controls.Add(mainForm.previewAudioWindow);
                            swfPanel.BringToFront();
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
           
        }
        /// <summary>
        /// 根据名字加载icon
        /// </summary>
        /// <param name="_typeName"></param>
        private Image SelectTypeIcon(string _typeName)
        {
            Image _typeIconIamge = null;
            switch (_typeName)
            {
                case "PPT":
                    _typeIconIamge = global::ChemistryApp.Properties.Resources.pptIcon;
                    break;
                case "反应方程":
                    _typeIconIamge = global::ChemistryApp.Properties.Resources.fanyingfangchengIcon;
                    break;
                case "视频":
                    _typeIconIamge = global::ChemistryApp.Properties.Resources.videoIcon;
                    break;
                case "思维导图":
                    _typeIconIamge = global::ChemistryApp.Properties.Resources.mandMapIcon;
                    break;
                case "实验":
                    _typeIconIamge = global::ChemistryApp.Properties.Resources.flashIcon;
                    break;
                case "习题":
                    _typeIconIamge = global::ChemistryApp.Properties.Resources.xitiIcon;
                    break;
                default:
                    break;
            }
            return _typeIconIamge;
        }
    }
}
