using ChemistryApp.SecondPage;
using System;
using System.Data;
using System.Windows.Forms;


namespace ChemistryApp.MyLesson
{
    /// <summary>
    /// 创建课件列表
    /// </summary>
    class MyLessonChildItem : Panel
    {
        #region 字段
        protected Panel childItemPanel;
        protected Label lab_title;
        protected Label lab_type;
        protected PictureBox pic_play;
        protected string fieldName = null;
        #endregion

        public MyLessonChildItem(int posX, int posY, string _strTitle, string _strType,string _fildName)
        {

            SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            SetStyle(ControlStyles.UserPaint, true);
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);

            this.fieldName = _fildName;
            childItemPanel = new Panel();
            lab_title = new Label();
            lab_type = new Label();
            pic_play = new PictureBox();
            InitCompent(posX, posY, _strTitle, _strType);
        }


        protected void InitCompent(int posX,int posY,string _strTitle, string _strType)
        {
            // 
            // CHILD
            // 
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.lab_title);
            this.Controls.Add(this.lab_type);
            this.Controls.Add(this.pic_play);
            this.Location = new System.Drawing.Point(posX, posY);
            this.Name = "childItemPanel";
            this.Size = new System.Drawing.Size(279, 30);
            this.TabIndex = 0;
            // 
            // label1
            // 
            this.lab_title.AutoSize = true;
            this.lab_title.Font = new System.Drawing.Font("苹方 中等", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lab_title.Location = new System.Drawing.Point(3, 3);
            this.lab_title.Name = "lab_title";
            this.lab_title.Size = new System.Drawing.Size(109, 21);
            this.lab_title.TabIndex = 0;
            this.lab_title.Text = _strTitle;
            // 
            // label2
            // 
            this.lab_type.AutoSize = true;
            this.lab_type.Font = new System.Drawing.Font("苹方 中等", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lab_type.Location = new System.Drawing.Point(200, 5);
            this.lab_type.Name = "lab_type";
            this.lab_type.Size = new System.Drawing.Size(39, 21);
            this.lab_type.TabIndex = 1;
            this.lab_type.Text = _strType;
            // 
            // pictureBox1
            // 
            this.pic_play.BackgroundImage = global::ChemistryApp.Properties.Resources.playicon ;
            this.pic_play.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pic_play.BackgroundImageLayout = ImageLayout.None;
            this.pic_play.Location = new System.Drawing.Point(245, 7);
            this.pic_play.Name = "pic_play";
            this.pic_play.Size = new System.Drawing.Size(31, 20);
            this.pic_play.TabIndex = 2;
            this.pic_play.TabStop = false;
            this.pic_play.Click += new EventHandler(PlayButton_Click);
        }

        /// <summary>
        /// 点击预览按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void PlayButton_Click(object sender,EventArgs e)
        {

            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            //根据题目来查询到路径
            string selectParentSql = "select * from LessonList where  LessonTitle = '" + this.fieldName + "'";
            try
            {
                DataSet ds = AccessDBConn.ExecuteQuery(selectParentSql, "LessonList");
                DataRow[] dr = ds.Tables["LessonList"].Select();
                //根据字段查询到子表，然后找到路径预览课件
                string selectChildSql = "select * from " + dr[0]["LessonContent"] + " where Title = '" + this.lab_title.Text + "'";
                DataSet childDs = AccessDBConn.ExecuteQuery(selectChildSql, dr[0]["LessonContent"].ToString());
                DataRow[] childDr = childDs.Tables[dr[0]["LessonContent"].ToString()].Select();
                string _fileType = childDr[0]["Type"].ToString();
                string _filePath = childDr[0]["URL"].ToString();
                MainForm mainForm = ((Control)sender).Parent.Parent.Parent.Parent.Parent.Parent as MainForm;
                int width = Screen.PrimaryScreen.Bounds.Width;
                int height = Screen.PrimaryScreen.Bounds.Height;
                PlaySwfPanel swfPanel = new PlaySwfPanel();
                if (_filePath.Substring(_filePath.Length - 3, 3) == "swf")
                {
                    mainForm.Controls.Add(swfPanel);
                    //播放 flash的控件
                    mainForm.MainFlashBox.Visible = true;
                    mainForm.MainFlashBox.Location = new System.Drawing.Point((width - 1024) / 2, (height - 768) / 2 - 30);
                    mainForm.MainFlashBox.Size = new System.Drawing.Size(1024, 768);
                    mainForm.MainFlashBox.Movie = System.Windows.Forms.Application.StartupPath + @_filePath;
                    swfPanel.Controls.Add(mainForm.MainFlashBox);
                    swfPanel.BringToFront();
                }
                else
                {
                    switch (_fileType)
                    {
                        case "PPT":
                            ControlPPTFonder.ControlPPT controlPPT = new ControlPPTFonder.ControlPPT();
                            controlPPT.PPTOpen(System.Windows.Forms.Application.StartupPath + @_filePath);
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
                            mainForm.previewAudioWindow.URL = System.Windows.Forms.Application.StartupPath + @_filePath;
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
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }
    }
}
