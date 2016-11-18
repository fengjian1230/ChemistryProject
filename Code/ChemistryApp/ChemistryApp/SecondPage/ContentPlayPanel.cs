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
        private Panel panel_playContentPanelBtn;
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));

        public ContentPlayPanel()
        {
            ContentControlFramer = new AxDSOFramer.AxFramerControl();
            panel_playContentPanelBtn = new Panel();
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
            this.Controls.Add(ContentControlFramer);
            this.Controls.Add(panel_playContentPanelBtn);
            // 
            // axFramerControl1
            // 
            this.ContentControlFramer.CausesValidation = false;
            //this.ContentControlFramer.BorderStyle = DSOFramer.dsoBorderStyle.dsoBorderNone;
            //this.ContentControlFramer.Toolbars = true;
            //this.ContentControlFramer.Titlebar = false;
            //this.ContentControlFramer.Menubar = false;
            this.ContentControlFramer.Enabled = true;
            this.ContentControlFramer.Location = new System.Drawing.Point((width - (height / 3) * 4) / 2 + 100, 0);
            this.ContentControlFramer.Name = "ContentControlFramer";
            this.ContentControlFramer.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axFramerControl1.OcxState")));
            this.ContentControlFramer.Size = new System.Drawing.Size((height / 3) * 4, height);
            this.ContentControlFramer.TabIndex = 21;
            // 
            // panel_playContentPanelBtn
            // 
            this.panel_playContentPanelBtn.Location = new System.Drawing.Point(0, (height - 550) / 2);
            this.panel_playContentPanelBtn.Name = "panel_playContentPanelBtn";
            this.panel_playContentPanelBtn.Size = new System.Drawing.Size(280, 550);
            this.panel_playContentPanelBtn.TabIndex = 21;
            this.panel_playContentPanelBtn.BackColor = Color.White;
        }

        /// <summary>
        /// 创建我的课表的item
        /// </summary>
        public void CreateMyLessonItem()
        {
            //从数据库中读取数据
            string sqlStr = "select * from LessonList order by ListID asc"; //(select LessonContent from LessonList where ID = 1)";
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
    }
}
