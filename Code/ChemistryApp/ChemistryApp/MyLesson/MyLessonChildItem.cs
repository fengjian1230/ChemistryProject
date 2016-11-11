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


namespace ChemistryApp.MyLesson
{
    /// <summary>
    /// 创建课件列表
    /// </summary>
    class MyLessonChildItem : Panel
    {
        #region 字段
        Panel childItemPanel;
        Label lab_title;
        Label lab_type;
        PictureBox pic_play;
        #endregion

        public MyLessonChildItem(int posX, int posY, string _strTitle, string _strType)
        {
            childItemPanel = new Panel();
            lab_title = new Label();
            lab_type = new Label();
            pic_play = new PictureBox();
            InitCompent(posX, posY, _strTitle, _strType);
        }


        public void InitCompent(int posX,int posY,string _strTitle, string _strType)
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
            this.lab_type.Location = new System.Drawing.Point(171, 3);
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
            this.pic_play.Location = new System.Drawing.Point(240, 7);
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
        private void PlayButton_Click(object sender,EventArgs e)
        {
            PictureBox pic = (PictureBox)sender;

            MessageBox.Show(pic.Parent.Parent.Name);
        }
    }
}
