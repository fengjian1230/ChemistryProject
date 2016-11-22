using System;
using System.Windows.Forms;
using System.IO;


namespace ChemistryApp.MyTeaching
{
    class CreateTeachingItemDialogBox
    {
        public System.Windows.Forms.Panel panel_createDialog;
        public System.Windows.Forms.PictureBox btn_cancel;
        public System.Windows.Forms.PictureBox btn_ok;
        public System.Windows.Forms.TextBox txt_tips;
        public System.Windows.Forms.Label lab_tips;
        public System.Windows.Forms.TextBox txt_className;
        public System.Windows.Forms.Label lab_className;
        public System.Windows.Forms.Label lab_typeName;
        public System.Windows.Forms.ComboBox comboBox_type;
        public PictureBox pic_dialogBG;
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
            btn_cancel = new PictureBox();
            btn_ok = new PictureBox();
            txt_className = new TextBox();
            txt_tips = new TextBox();
            lab_tips = new Label();
            lab_className = new Label();
            comboBox_type = new ComboBox();
            lab_typeName = new Label();
            this.filePath = filePath;
            this.sourcePath = _source;
            this.loaclPath = _local;
            this.pic_dialogBG = new PictureBox();
        }

        /// <summary>
        /// 创建窗口
        /// </summary>
        public Panel CreateDialgBox()
        {
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
            // panel_createDialog
            // 
            this.panel_createDialog.Controls.Add(this.btn_cancel);
            this.panel_createDialog.Controls.Add(this.btn_ok);
            this.panel_createDialog.Controls.Add(this.txt_className);
            this.panel_createDialog.Controls.Add(this.lab_className);
            this.panel_createDialog.Controls.Add(this.comboBox_type);
            this.panel_createDialog.Controls.Add(this.lab_typeName);
            this.panel_createDialog.Controls.Add(this.pic_dialogBG);
            this.panel_createDialog.Location = new System.Drawing.Point(324, 277);
            this.panel_createDialog.Name = "panel_createTeachingItemDialog";
            this.panel_createDialog.Size = new System.Drawing.Size(363, 230);
            this.panel_createDialog.TabIndex = 1;
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
            //下拉框
            this.comboBox_type.FormattingEnabled = true;
            this.comboBox_type.Items.AddRange(new object[] {
            "PPT",
            "思维导图",
            "视频",
            "实验",
            "反应方程",
            "习题"});
            this.comboBox_type.Location = new System.Drawing.Point(235, 80);
            this.comboBox_type.Name = "comboBox_type";
            this.comboBox_type.Size = new System.Drawing.Size(100, 23);
            this.comboBox_type.TabIndex = 20;

            // 
            // 下拉框名字
            // 
            this.lab_typeName.AutoSize = true;
            this.lab_typeName.ForeColor = System.Drawing.Color.White;
            this.lab_typeName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(83)))), ((int)(((byte)(83)))));
            this.lab_typeName.Font = new System.Drawing.Font("微软雅黑", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lab_typeName.Location = new System.Drawing.Point(17, 80);
            this.lab_typeName.Name = "lab_className";
            this.lab_typeName.Size = new System.Drawing.Size(52, 15);
            this.lab_typeName.TabIndex = 0;
            this.lab_typeName.Text = "选择类型:";

            return panel_createDialog;
        }

        /// <summary>
        /// 点击取消
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnCancel_Click(object sender, EventArgs e)
        {
            PictureBox btn = (PictureBox)sender;
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
                    PictureBox btn = (PictureBox)sender;
                    Panel mainPanel = btn.Parent.Parent as Panel;
                    foreach (Control item in mainPanel.Controls)
                    {
                        if (item.Name == "panel_createTeachingItemDialog")
                        {
                            mainPanel.Controls.Remove(item);
                        }
                    }
                    File.Copy(sourcePath, loaclPath,true);
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
