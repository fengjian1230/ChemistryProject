﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using ADOX;
using System.Data.OleDb;
using ChemistryApp.MyLesson;
using ChemistryApp.EnumType;
using ChemistryApp.MyTeaching;

namespace ChemistryApp.SecondPage
{
    class ContentPlayPanel : Panel
    {
        public AxDSOFramer.AxFramerControl ContentControlFramer;
        public AxWMPLib.AxWindowsMediaPlayer axAudioPlayer;
        private Panel panel_playContentPanelBtn;
        private Button btn_close;
        PictureBox dasdas;
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));

        public ContentPlayPanel()
        {
            ContentControlFramer = new AxDSOFramer.AxFramerControl();
            axAudioPlayer = new AxWMPLib.AxWindowsMediaPlayer();
            panel_playContentPanelBtn = new Panel();
            btn_close = new Button();
            dasdas = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ContentControlFramer)).BeginInit();
            InitCompent();
        }



        private void InitCompent()
        {
            CreateMyLessonItem();
            int width = Screen.PrimaryScreen.Bounds.Width;
            int height = Screen.PrimaryScreen.Bounds.Height;
            this.Name = "PPTPlayPanel";
            this.Location = new Point(0, 0);
            this.Size = this.Size;
            this.BackColor = Color.Black;
            this.Size = new Size(width, height);
            this.Controls.Add(this.axAudioPlayer);
            this.Controls.Add(dasdas);
            this.Controls.Add(btn_close);
            this.Controls.Add(ContentControlFramer);
            this.Controls.Add(panel_playContentPanelBtn);

            this.dasdas.Name = "dddd";
            this.dasdas.BackColor = Color.Black;
            this.dasdas.Size = new Size(1600, 45);
            this.dasdas.Location = new Point(150, 0);
            // 
            // axFramerControl1
            // 
            this.ContentControlFramer.CausesValidation = false;
            this.ContentControlFramer.Enabled = true;
            this.ContentControlFramer.Location = new System.Drawing.Point((width - (height / 3) * 4) / 2 + 100, 0);
            this.ContentControlFramer.Name = "ContentControlFramer";
            this.ContentControlFramer.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axFramerControl1.OcxState")));
            this.ContentControlFramer.Size = new System.Drawing.Size((height / 3) * 4, height);
            // 
            // panel_playContentPanelBtn
            // 
            this.panel_playContentPanelBtn.Location = new System.Drawing.Point(0, (height - 550) / 2);
            this.panel_playContentPanelBtn.Name = "panel_playContentPanelBtn";
            this.panel_playContentPanelBtn.Size = new System.Drawing.Size(280, 550);
            this.panel_playContentPanelBtn.AutoScroll = true;
            this.panel_playContentPanelBtn.TabIndex = 21;
            this.panel_playContentPanelBtn.BackColor = Color.White;

            // 
            // button
            // 
            this.btn_close.Location = new System.Drawing.Point(0, 0);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(120, 29);
            this.btn_close.TabIndex = 21;
            this.btn_close.Text = "关闭";
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new EventHandler(OnClickClosePanel);
            // 
            // axWindowsMediaPlayer1
            // 
            this.axAudioPlayer.Enabled = true;
            this.axAudioPlayer.Location = new System.Drawing.Point((width - (height / 3) * 4) / 2 + 100, 0);
            this.axAudioPlayer.Name = "axAudioPlayer";
            this.axAudioPlayer.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axAudioPlayer.Size = new System.Drawing.Size((height / 3) * 4, height);
            this.axAudioPlayer.TabIndex = 21;
            this.axAudioPlayer.Visible = false;

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
                    PlayContentPanelList childPanel = new PlayContentPanelList(0, 50 + j * 50, childDataRow[j]["Title"].ToString(), childDataRow[j]["Type"].ToString());
                    childPanel.fieldName = dataRow[0]["LessonTitle"].ToString();
                    childPanel.Name = "childPanel" + j.ToString();
                    this.panel_playContentPanelBtn.Controls.Add(childPanel);

                }
            }
        }

        /// <summary>
        /// 关闭面板
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnClickClosePanel(object sender,EventArgs e)
        {
            Button btn = (Button)sender;
            MainForm mainForm = btn.Parent.Parent as MainForm;
            Panel parentPanel = btn.Parent as Panel;
            mainForm.Controls.Remove(parentPanel);
            mainForm.MainPanel.Visible = true;
            btn.Dispose();
            parentPanel.Dispose();
        }
    }
}