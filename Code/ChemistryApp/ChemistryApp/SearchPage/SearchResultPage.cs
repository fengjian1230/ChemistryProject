using System.Data;
using System.Drawing;
using System.Windows.Forms;


namespace ChemistryApp.SearchPage
{
    class SearchResultPage : Panel
    {
        private System.Windows.Forms.Button btn_shiyan;
        private System.Windows.Forms.Button btn_mindMap;
        private System.Windows.Forms.Button btn_video;
        private System.Windows.Forms.Button btn_ppt;
        private System.Windows.Forms.Button btn_fangcheng;
        private System.Windows.Forms.Button btn_xiti;
        private System.Windows.Forms.Panel panel_content;
        private System.Windows.Forms.Label lab_partName;

        private System.Windows.Forms.Label lab_play;
        private System.Windows.Forms.Label lab_type;
        private System.Windows.Forms.Label lab_title;
        private System.Windows.Forms.Label lab_insert;



        public SearchContentPage contentPage;
        PictureBox pic_redLine;
        public SearchResultPage(string _strContent)
        {

            SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            SetStyle(ControlStyles.UserPaint, true);
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);

            this.panel_content = new System.Windows.Forms.Panel();
            this.lab_partName = new System.Windows.Forms.Label();
            this.btn_xiti = new System.Windows.Forms.Button();
            this.btn_fangcheng = new System.Windows.Forms.Button();
            this.btn_video = new System.Windows.Forms.Button();
            this.btn_ppt = new System.Windows.Forms.Button();
            this.btn_shiyan = new System.Windows.Forms.Button();
            this.btn_mindMap = new System.Windows.Forms.Button();

            this.lab_partName = new Label();
            this.lab_title = new System.Windows.Forms.Label();
            this.lab_type = new System.Windows.Forms.Label();
            this.lab_play = new System.Windows.Forms.Label();
            this.lab_insert = new Label();
            this.pic_redLine = new PictureBox();
            InitCompent(_strContent);
        }

        private void InitCompent(string _strContent)
        {
            // 
            // panel_searchpage
            // 
            this.BackColor = System.Drawing.SystemColors.Control;
            contentPage = new SearchContentPage(_strContent);
            this.Controls.Add(this.lab_play);
            this.Controls.Add(this.lab_type);
            this.Controls.Add(this.lab_title);
            this.Controls.Add(this.lab_insert);
            this.Controls.Add(this.lab_partName);
            this.Controls.Add(this.pic_redLine);
            this.Controls.Add(contentPage);
            this.Controls.Add(this.btn_xiti);
            this.Controls.Add(this.btn_fangcheng);
            this.Controls.Add(this.btn_video);
            this.Controls.Add(this.btn_ppt);
            this.Controls.Add(this.btn_shiyan);
            this.Controls.Add(this.btn_mindMap);
            
            this.Location = new System.Drawing.Point(85, 175);
            this.Name = "panel_searchpage";
            this.Size = new System.Drawing.Size(860, 460);
            this.TabIndex = 20;
            // 
            // btn_xiti
            // 
            this.btn_xiti.Location = new System.Drawing.Point(723, 0);
            this.btn_xiti.Name = "习题";
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
            this.btn_xiti.Click += new System.EventHandler(this.contentPage.CreateItemOnSelect);
            // 
            // btn_fangcheng
            // 
            this.btn_fangcheng.Location = new System.Drawing.Point(576, 0);
            this.btn_fangcheng.Name = "反应方程";
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
            this.btn_fangcheng.Click += new System.EventHandler(this.contentPage.CreateItemOnSelect);
            // 
            // btn_video
            // 
            this.btn_video.Location = new System.Drawing.Point(434, 0);
            this.btn_video.Size = new System.Drawing.Size(132, 36);
            this.btn_video.TabIndex = 3;
            this.btn_video.Name = "视频";
            this.btn_video.Cursor = Cursors.Hand;
            this.btn_video.UseVisualStyleBackColor = true;
            this.btn_video.BackgroundImage = global::ChemistryApp.Properties.Resources.vidoebtn_up;
            this.btn_video.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_video.FlatAppearance.BorderSize = 0;
            this.btn_video.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_video.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_video.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_video.Click += new System.EventHandler(this.contentPage.CreateItemOnSelect);
            // 
            // btn_ppt
            // 
            this.btn_ppt.Location = new System.Drawing.Point(292, 0);
            this.btn_ppt.Name = "PPT";
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
            this.btn_ppt.Click += new System.EventHandler(this.contentPage.CreateItemOnSelect);
            // 
            // btn_shiyan
            // 
            this.btn_shiyan.Location = new System.Drawing.Point(150, 0);
            this.btn_shiyan.Name = "实验";
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
            this.btn_shiyan.Click += new System.EventHandler(this.contentPage.CreateItemOnSelect);
            // 
            // btn_mandMap
            // 
            this.btn_mindMap.Location = new System.Drawing.Point(0, 0);
            this.btn_mindMap.Name = "思维导图";
            this.btn_mindMap.Size = new System.Drawing.Size(132, 36);
            this.btn_mindMap.TabIndex = 0;
            this.btn_mindMap.Cursor = Cursors.Hand;
            this.btn_mindMap.UseVisualStyleBackColor = true;
            this.btn_mindMap.BackgroundImage = global::ChemistryApp.Properties.Resources.maidmapbtn_up;
            this.btn_mindMap.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_mindMap.FlatAppearance.BorderSize = 0;
            this.btn_mindMap.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_mindMap.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_mindMap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_mindMap.Click += new System.EventHandler(this.contentPage.CreateItemOnSelect);
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
            // 
            // lab_tips
            // 
            this.lab_partName.AutoSize = true;
            this.lab_partName.BackColor = Color.FromArgb(240, 240, 240);
            this.lab_partName.Font = new System.Drawing.Font("苹方 中等", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lab_partName.Location = new System.Drawing.Point(4, 60);
            this.lab_partName.Name = "lab_tips";
            this.lab_partName.Size = new System.Drawing.Size(165, 44);
            this.lab_partName.TabIndex = 0;
            this.lab_partName.Text = "从实验学化学";
            // 
            // lab_title
            // 
            this.lab_title.AutoSize = true;
            this.lab_title.BackColor = Color.FromArgb(240,240,240);
            this.lab_title.Location = new System.Drawing.Point(178, 100);
            this.lab_title.Name = "lab_title";
            this.lab_title.Size = new System.Drawing.Size(37, 15);
            this.lab_title.TabIndex = 1;
            this.lab_title.Text = "标题";
            // 
            // lab_type
            // 
            this.lab_type.AutoSize = true;
            this.lab_type.BackColor = Color.FromArgb(240, 240, 240);
            this.lab_type.Location = new System.Drawing.Point(440, 100);
            this.lab_type.Name = "lab_type";
            this.lab_type.Size = new System.Drawing.Size(37, 15);
            this.lab_type.TabIndex = 2;
            this.lab_type.Text = "类型";
            // 
            // lab_play
            // 
            this.lab_insert.AutoSize = true;
            this.lab_insert.BackColor = Color.FromArgb(240, 240, 240);
            this.lab_insert.Location = new System.Drawing.Point(665, 100);
            this.lab_insert.Name = "lab_insert";
            this.lab_insert.Size = new System.Drawing.Size(37, 15);
            this.lab_insert.TabIndex = 3;
            this.lab_insert.Text = "添加";

            // 
            // lab_play
            // 
            this.lab_play.AutoSize = true;
            this.lab_play.BackColor = Color.FromArgb(240, 240, 240);
            this.lab_play.Location = new System.Drawing.Point(716,100);
            this.lab_play.Name = "lab_play";
            this.lab_play.Size = new System.Drawing.Size(37, 15);
            this.lab_play.TabIndex = 3;
            this.lab_play.Text = "预览";
        }
    }
}
