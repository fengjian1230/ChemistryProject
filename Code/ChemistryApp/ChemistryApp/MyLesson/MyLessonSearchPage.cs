using System.Windows.Forms;


namespace ChemistryApp.MyLesson
{
    /// <summary>
    /// 我的课表的搜索结果
    /// </summary>
    class MyLessonSearchPage : Panel
    {
        PictureBox pic_top;
        public MyLessonSearchPage()
        {
            pic_top = new PictureBox();
            InitCompent();
        }

        private void InitCompent()
        {
            // 
            // panel_item
            // 
            this.AutoScroll = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ForeColor = System.Drawing.Color.Black;
            this.ImeMode = System.Windows.Forms.ImeMode.On;
            this.Location = new System.Drawing.Point(3, 110);
            this.Name = "panel_SearchItem";
            this.Size = new System.Drawing.Size(315, 463);
            this.TabIndex = 17;

        }
    }
}
