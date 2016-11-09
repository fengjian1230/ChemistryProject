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


namespace ChemistryApp.MyLesson
{
    public class CreateLessonDialogBox
    {
        public System.Windows.Forms.Panel panel_createDialog;
        public System.Windows.Forms.Button btn_cancel;
        public System.Windows.Forms.Button btn_ok;
        public System.Windows.Forms.TextBox txt_tips;
        public System.Windows.Forms.Label lab_tips;
        public System.Windows.Forms.TextBox txt_className;
        public System.Windows.Forms.Label lab_className;

        /// <summary>
        /// 构造函数
        /// </summary>
        public CreateLessonDialogBox()
        {
            panel_createDialog = new Panel();
            btn_cancel = new Button();
            btn_ok = new Button();
            txt_className = new TextBox();
            txt_tips = new TextBox();
            lab_tips = new Label();
            lab_className = new Label();
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
            this.panel_createDialog.Location = new System.Drawing.Point(319, 237);
            this.panel_createDialog.Name = "panel_createDialog";
            this.panel_createDialog.Size = new System.Drawing.Size(418, 201);
            this.panel_createDialog.TabIndex = 1;
            this.panel_createDialog.BringToFront();
            // 
            // lab_className
            // 
            this.lab_className.AutoSize = true;
            this.lab_className.Location = new System.Drawing.Point(14, 29);
            this.lab_className.Name = "lab_className";
            this.lab_className.Size = new System.Drawing.Size(52, 15);
            this.lab_className.TabIndex = 0;
            this.lab_className.Text = "课名：";
            // 
            // txt_className
            // 
            this.txt_className.Location = new System.Drawing.Point(72, 19);
            this.txt_className.Name = "txt_className";
            this.txt_className.Size = new System.Drawing.Size(316, 25);
            this.txt_className.TabIndex = 1;
            // 
            // lab_tips
            // 
            this.lab_tips.AutoSize = true;
            this.lab_tips.Location = new System.Drawing.Point(14, 64);
            this.lab_tips.Name = "lab_tips";
            this.lab_tips.Size = new System.Drawing.Size(52, 15);
            this.lab_tips.TabIndex = 2;
            this.lab_tips.Text = "备注：";
            // 
            // txt_tips
            // 
            this.txt_tips.Location = new System.Drawing.Point(72, 54);
            this.txt_tips.Name = "txt_tips";
            this.txt_tips.Size = new System.Drawing.Size(261, 25);
            this.txt_tips.TabIndex = 3;
            // 
            // btn_ok
            // 
            this.btn_ok.Location = new System.Drawing.Point(72, 123);
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.Size = new System.Drawing.Size(75, 23);
            this.btn_ok.TabIndex = 4;
            this.btn_ok.Text = "确定";
            this.btn_ok.UseVisualStyleBackColor = true;
            this.btn_ok.Click += new EventHandler(BtnOK_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(313, 123);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_cancel.TabIndex = 5;
            this.btn_cancel.Text = "取消";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new EventHandler(BtnCancel_Click);

            return panel_createDialog;
        }

        /// <summary>
        /// 点击取消
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnCancel_Click(object sender,EventArgs e)
        {
            Button btn = (Button)sender;
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
            string _strTitle = "";
            string _strType = "";
            string _strURL = "";
            //创建课件的数据表
            ADOX.Column[] columns = {
                                 new ADOX.Column(){Name="Title",DefinedSize=9},
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
                Button btn = (Button)sender;
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
    }

}
