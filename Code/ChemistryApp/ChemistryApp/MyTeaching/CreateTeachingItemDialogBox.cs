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
using System.IO;


namespace ChemistryApp.MyTeaching
{
    class CreateTeachingItemDialogBox
    {
        public System.Windows.Forms.Panel panel_createDialog;
        public System.Windows.Forms.Button btn_cancel;
        public System.Windows.Forms.Button btn_ok;
        public System.Windows.Forms.TextBox txt_tips;
        public System.Windows.Forms.Label lab_tips;
        public System.Windows.Forms.TextBox txt_className;
        public System.Windows.Forms.Label lab_className;
        public System.Windows.Forms.Label lab_typeName;
        public System.Windows.Forms.ComboBox comboBox_type;
        /// <summary>
        /// 文件路径
        /// </summary>
        private string filePath;
        /// <summary>
        /// 目标路径
        /// </summary>
        private string sourcePath;
        /// <summary>
        /// 本地路径
        /// </summary>
        private string loaclPath;
        /// <summary>
        /// 构造函数
        /// </summary>
        public CreateTeachingItemDialogBox(string filePath,string _source,string _local)
        {
            panel_createDialog = new Panel();
            btn_cancel = new Button();
            btn_ok = new Button();
            txt_className = new TextBox();
            txt_tips = new TextBox();
            lab_tips = new Label();
            lab_className = new Label();
            comboBox_type = new ComboBox();
            lab_typeName = new Label();
            this.filePath = filePath;
            this.sourcePath = _source;
            this.loaclPath = _local;
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
            this.panel_createDialog.Controls.Add(this.txt_className);
            this.panel_createDialog.Controls.Add(this.lab_className);
            this.panel_createDialog.Controls.Add(this.comboBox_type);
            this.panel_createDialog.Controls.Add(this.lab_typeName);
            this.panel_createDialog.Location = new System.Drawing.Point(319, 237);
            this.panel_createDialog.Name = "panel_createTeachingItemDialog";
            this.panel_createDialog.Size = new System.Drawing.Size(418, 201);
            this.panel_createDialog.TabIndex = 1;
            this.panel_createDialog.BringToFront();

            //下拉框
            this.comboBox_type.FormattingEnabled = true;
            this.comboBox_type.Items.AddRange(new object[] {
            "PPT",
            "思维导图",
            "视频",
            "实验",
            "反应方程",
            "习题"});
            this.comboBox_type.Location = new System.Drawing.Point(257, 54);
            this.comboBox_type.Name = "comboBox_type";
            this.comboBox_type.Size = new System.Drawing.Size(72, 23);
            this.comboBox_type.TabIndex = 20;

            // 
            // 下拉框名字
            // 
            this.lab_typeName.AutoSize = true;
            this.lab_typeName.Location = new System.Drawing.Point(14, 54);
            this.lab_typeName.Name = "lab_className";
            this.lab_typeName.Size = new System.Drawing.Size(52, 15);
            this.lab_typeName.TabIndex = 0;
            this.lab_typeName.Text = "选择类型:";

            // 
            // lab_className
            // 
            this.lab_className.AutoSize = true;
            this.lab_className.Location = new System.Drawing.Point(14, 29);
            this.lab_className.Name = "lab_className";
            this.lab_className.Size = new System.Drawing.Size(52, 15);
            this.lab_className.TabIndex = 0;
            this.lab_className.Text = "课件名：";
            // 
            // txt_className
            // 
            this.txt_className.Location = new System.Drawing.Point(72, 19);
            this.txt_className.Name = "txt_className";
            this.txt_className.Size = new System.Drawing.Size(316, 25);
            this.txt_className.TabIndex = 1;
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
        private void BtnCancel_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            Panel mainPanel = btn.Parent.Parent as Panel;
            foreach (Control item in mainPanel.Controls)
            {
                if (item.Name == "panel_createTeachingItemDialog")
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
        private void BtnOK_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(this.comboBox_type.Text);
            if (txt_className.Text != "" && this.comboBox_type.Text != "")
            {
                string insertSql = "insert into MyTeaching(TeachingTitle,TeachingType,URL)values('" + txt_className.Text + "','" + "" + this.comboBox_type.Text + "','" + this.filePath + "')";
                int _insertErrorIndex = AccessDBConn.ExecuteNonQuery(insertSql);
                if (_insertErrorIndex != 0)
                {
                    Button btn = (Button)sender;
                    Panel mainPanel = btn.Parent.Parent as Panel;
                    foreach (Control item in mainPanel.Controls)
                    {
                        if (item.Name == "panel_createTeachingItemDialog")
                        {
                            mainPanel.Controls.Remove(item);
                        }
                    }
                    File.Copy(sourcePath, loaclPath);
                    MessageBox.Show("上传成功！");
                    MyTeachingItemManager.GetInstace.OnItemDelete?.Invoke();
                }
            }
            else
            {
                MessageBox.Show("输入课件名字或者选择课件类型！");
            }

        }
    }
}
