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
            InitCompent(_strContent);
        }

        private void InitCompent(string _strContent)
        {
            // 
            // panel_searchpage
            // 
            this.BackColor = System.Drawing.Color.Transparent;
            SearchContentPage contentPage = new SearchContentPage(_strContent);
            this.Controls.Add(contentPage);
            this.Controls.Add(this.btn_xiti);
            this.Controls.Add(this.btn_fangcheng);
            this.Controls.Add(this.btn_video);
            this.Controls.Add(this.btn_ppt);
            this.Controls.Add(this.btn_shiyan);
            this.Controls.Add(this.btn_mandMap);
            this.Location = new System.Drawing.Point(103, 171);
            this.Name = "panel_searchpage";
            this.Size = new System.Drawing.Size(798, 463);
            this.TabIndex = 20;
            // 
            // btn_xiti
            // 
            this.btn_xiti.Location = new System.Drawing.Point(654, 0);
            this.btn_xiti.Name = "btn_xiti";
            this.btn_xiti.Size = new System.Drawing.Size(99, 23);
            this.btn_xiti.TabIndex = 5;
            this.btn_xiti.Text = "习题";
            this.btn_xiti.UseVisualStyleBackColor = true;
            // 
            // btn_fangcheng
            // 
            this.btn_fangcheng.Location = new System.Drawing.Point(523, 0);
            this.btn_fangcheng.Name = "btn_fangcheng";
            this.btn_fangcheng.Size = new System.Drawing.Size(99, 23);
            this.btn_fangcheng.TabIndex = 4;
            this.btn_fangcheng.Text = "反应方程";
            this.btn_fangcheng.UseVisualStyleBackColor = true;
            // 
            // btn_video
            // 
            this.btn_video.Location = new System.Drawing.Point(401, 0);
            this.btn_video.Name = "btn_video";
            this.btn_video.Size = new System.Drawing.Size(99, 23);
            this.btn_video.TabIndex = 3;
            this.btn_video.Text = "视频";
            this.btn_video.UseVisualStyleBackColor = true;
            // 
            // btn_ppt
            // 
            this.btn_ppt.Location = new System.Drawing.Point(287, 0);
            this.btn_ppt.Name = "btn_ppt";
            this.btn_ppt.Size = new System.Drawing.Size(99, 23);
            this.btn_ppt.TabIndex = 2;
            this.btn_ppt.Text = "PPT";
            this.btn_ppt.UseVisualStyleBackColor = true;
            // 
            // btn_shiyan
            // 
            this.btn_shiyan.Location = new System.Drawing.Point(154, 0);
            this.btn_shiyan.Name = "btn_shiyan";
            this.btn_shiyan.Size = new System.Drawing.Size(99, 23);
            this.btn_shiyan.TabIndex = 1;
            this.btn_shiyan.Text = "实验FLASH";
            this.btn_shiyan.UseVisualStyleBackColor = true;
            // 
            // btn_mandMap
            // 
            this.btn_mandMap.Location = new System.Drawing.Point(56, 0);
            this.btn_mandMap.Name = "btn_mandMap";
            this.btn_mandMap.Size = new System.Drawing.Size(75, 23);
            this.btn_mandMap.TabIndex = 0;
            this.btn_mandMap.Text = "思维导图";
            this.btn_mandMap.UseVisualStyleBackColor = true;
        }
    }
}
