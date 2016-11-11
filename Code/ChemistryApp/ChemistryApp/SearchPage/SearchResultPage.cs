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
    class SearchResultPage : Panel
    {
        private System.Windows.Forms.Panel panel_searchpage;
        private System.Windows.Forms.Button btn_shiyan;
        private System.Windows.Forms.Button btn_mandMap;
        private System.Windows.Forms.Button btn_video;
        private System.Windows.Forms.Button btn_ppt;
        private System.Windows.Forms.Button btn_fangcheng;
        private System.Windows.Forms.Button btn_xiti;
        private System.Windows.Forms.Panel panel_content;
        private System.Windows.Forms.Label lab_tips;
        PictureBox pic_redLine;
        public SearchResultPage(string _strContent)
        {
            this.panel_searchpage = new System.Windows.Forms.Panel();
            this.panel_content = new System.Windows.Forms.Panel();
            this.lab_tips = new System.Windows.Forms.Label();
            this.btn_xiti = new System.Windows.Forms.Button();
            this.btn_fangcheng = new System.Windows.Forms.Button();
            this.btn_video = new System.Windows.Forms.Button();
            this.btn_ppt = new System.Windows.Forms.Button();
            this.btn_shiyan = new System.Windows.Forms.Button();
            this.btn_mandMap = new System.Windows.Forms.Button();
            this.pic_redLine = new PictureBox();
            InitCompent(_strContent);
        }

        private void InitCompent(string _strContent)
        {
            // 
            // panel_searchpage
            // 
            this.BackColor = System.Drawing.Color.Transparent;
            SearchContentPage contentPage = new SearchContentPage(_strContent);
            this.Controls.Add(this.pic_redLine);
            this.Controls.Add(contentPage);
            this.Controls.Add(this.btn_xiti);
            this.Controls.Add(this.btn_fangcheng);
            this.Controls.Add(this.btn_video);
            this.Controls.Add(this.btn_ppt);
            this.Controls.Add(this.btn_shiyan);
            this.Controls.Add(this.btn_mandMap);
            this.Location = new System.Drawing.Point(85, 175);
            this.Name = "panel_searchpage";
            this.Size = new System.Drawing.Size(860, 460);
            this.TabIndex = 20;
            // 
            // btn_xiti
            // 
            this.btn_xiti.Location = new System.Drawing.Point(723, 0);
            this.btn_xiti.Name = "btn_xiti";
            this.btn_xiti.Size = new System.Drawing.Size(132, 36);
            this.btn_xiti.TabIndex = 5;
            this.btn_xiti.Cursor = Cursors.Hand;
            this.btn_xiti.UseVisualStyleBackColor = true;
            this.btn_xiti.BackgroundImage = global::ChemistryApp.Properties.Resources.xitibtn_up_png;
            this.btn_xiti.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_xiti.FlatAppearance.BorderSize = 0;
            this.btn_xiti.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_xiti.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_xiti.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_xiti.UseVisualStyleBackColor = true;
            // 
            // btn_fangcheng
            // 
            this.btn_fangcheng.Location = new System.Drawing.Point(576, 0);
            this.btn_fangcheng.Name = "btn_fangcheng";
            this.btn_fangcheng.Size = new System.Drawing.Size(132, 36);
            this.btn_fangcheng.Cursor = Cursors.Hand;
            this.btn_fangcheng.UseVisualStyleBackColor = true;
            this.btn_fangcheng.UseVisualStyleBackColor = true;
            this.btn_fangcheng.BackgroundImage = global::ChemistryApp.Properties.Resources.fanyingfangcheng_up;
            this.btn_fangcheng.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_fangcheng.FlatAppearance.BorderSize = 0;
            this.btn_fangcheng.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_fangcheng.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_fangcheng.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            // 
            // btn_video
            // 
            this.btn_video.Location = new System.Drawing.Point(434, 0);
            this.btn_video.Size = new System.Drawing.Size(132, 36);
            this.btn_video.TabIndex = 3;
            this.btn_video.Cursor = Cursors.Hand;
            this.btn_video.UseVisualStyleBackColor = true;
            this.btn_video.BackgroundImage = global::ChemistryApp.Properties.Resources.vidoebtn_up;
            this.btn_video.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_video.FlatAppearance.BorderSize = 0;
            this.btn_video.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_video.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_video.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            // 
            // btn_ppt
            // 
            this.btn_ppt.Location = new System.Drawing.Point(292, 0);
            this.btn_ppt.Name = "btn_ppt";
            this.btn_ppt.Size = new System.Drawing.Size(132, 36);
            this.btn_ppt.TabIndex = 2;
            this.btn_ppt.Cursor = Cursors.Hand;
            this.btn_ppt.UseVisualStyleBackColor = true;
            this.btn_ppt.BackgroundImage = global::ChemistryApp.Properties.Resources.PPTbtn_up;
            this.btn_ppt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_ppt.FlatAppearance.BorderSize = 0;
            this.btn_ppt.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_ppt.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_ppt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            // 
            // btn_shiyan
            // 
            this.btn_shiyan.Location = new System.Drawing.Point(150, 0);
            this.btn_shiyan.Name = "btn_shiyan";
            this.btn_shiyan.Size = new System.Drawing.Size(132, 36);
            this.btn_shiyan.TabIndex = 1;
            this.btn_shiyan.Cursor = Cursors.Hand;
            this.btn_shiyan.UseVisualStyleBackColor = true;
            this.btn_shiyan.BackgroundImage = global::ChemistryApp.Properties.Resources.flash_btn_up;
            this.btn_shiyan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_shiyan.FlatAppearance.BorderSize = 0;
            this.btn_shiyan.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_shiyan.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_shiyan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            // 
            // btn_mandMap
            // 
            this.btn_mandMap.Location = new System.Drawing.Point(0, 0);
            this.btn_mandMap.Name = "btn_mandMap";
            this.btn_mandMap.Size = new System.Drawing.Size(132, 36);
            this.btn_mandMap.TabIndex = 0;
            this.btn_mandMap.Cursor = Cursors.Hand;
            this.btn_mandMap.UseVisualStyleBackColor = true;
            this.btn_mandMap.BackgroundImage = global::ChemistryApp.Properties.Resources.maidmapbtn_up;
            this.btn_mandMap.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_mandMap.FlatAppearance.BorderSize = 0;
            this.btn_mandMap.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_mandMap.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_mandMap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            // 
            // dccc
            // 
            this.pic_redLine.BackgroundImage = global::ChemistryApp.Properties.Resources.redLine;
            this.pic_redLine.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pic_redLine.Location = new System.Drawing.Point(0, 37);
            this.pic_redLine.Name = "pic_redLine";
            this.pic_redLine.Size = new System.Drawing.Size(855, 3);
            this.pic_redLine.TabIndex = 21;
            this.pic_redLine.TabStop = false;
        }
    }
}
