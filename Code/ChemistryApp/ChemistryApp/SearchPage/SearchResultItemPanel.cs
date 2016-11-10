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


namespace ChemistryApp.SearchPage
{
    /// <summary>
    /// 搜索结果页面
    /// </summary>
    class SearchResultItemPanel : Panel
    {
        public System.Windows.Forms.PictureBox btn_playContent;
        public System.Windows.Forms.Label lab_typeContent;
        public System.Windows.Forms.Label lab_titleContent;
        public System.Windows.Forms.PictureBox pic_insert;

        public SearchResultItemPanel(int posX,int posY)
        {
            this.pic_insert = new System.Windows.Forms.PictureBox();
            this.lab_titleContent = new System.Windows.Forms.Label();
            this.lab_typeContent = new System.Windows.Forms.Label();
            this.btn_playContent = new System.Windows.Forms.PictureBox();
            InitCompent(posX,posY);
        }

        private void InitCompent(int posX, int posY)
        {
            // 
            // panel_searchItem
            // 
            this.Controls.Add(this.btn_playContent);
            this.Controls.Add(this.lab_typeContent);
            this.Controls.Add(this.lab_titleContent);
            this.Controls.Add(this.pic_insert);
            this.Location = new System.Drawing.Point(posX, posY);
            this.Name = "panel_searchItem";
            this.Size = new System.Drawing.Size(750, 36);
            this.TabIndex = 4;
            // 
            // pic_insert
            // 
            this.pic_insert.BackColor = System.Drawing.Color.Transparent;
            this.pic_insert.BackgroundImage = global::ChemistryApp.Properties.Resources.删除键;
            this.pic_insert.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pic_insert.Location = new System.Drawing.Point(28, 11);
            this.pic_insert.Name = "pic_insert";
            this.pic_insert.Size = new System.Drawing.Size(19, 20);
            this.pic_insert.TabIndex = 0;
            this.pic_insert.Cursor = Cursors.Hand;
            this.pic_insert.TabStop = false;
            // 
            // lab_titleContent
            // 
            this.lab_titleContent.AutoSize = true;
            this.lab_titleContent.Font = new System.Drawing.Font("苹方 中等", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lab_titleContent.Location = new System.Drawing.Point(111, 4);
            this.lab_titleContent.Name = "lab_titleContent";
            this.lab_titleContent.Size = new System.Drawing.Size(68, 28);
            this.lab_titleContent.TabIndex = 1;
            this.lab_titleContent.Text = "label2";
            // 
            // lab_typeContent
            // 
            this.lab_typeContent.AutoSize = true;
            this.lab_typeContent.Font = new System.Drawing.Font("苹方 中等", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lab_typeContent.Location = new System.Drawing.Point(422, 4);
            this.lab_typeContent.Name = "lab_typeContent";
            this.lab_typeContent.Size = new System.Drawing.Size(68, 28);
            this.lab_typeContent.TabIndex = 2;
            this.lab_typeContent.Text = "label2";
            // 
            // btn_playContent
            // 
            this.btn_playContent.BackgroundImage = global::ChemistryApp.Properties.Resources.删除键;
            this.btn_playContent.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_playContent.Location = new System.Drawing.Point(717, 10);
            this.btn_playContent.Name = "btn_playContent";
            this.btn_playContent.Size = new System.Drawing.Size(18, 21);
            this.btn_playContent.TabIndex = 3;
            this.btn_playContent.TabStop = false;
            this.btn_playContent.Cursor = Cursors.Hand;
        }
    }
}
