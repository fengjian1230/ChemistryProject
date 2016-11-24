using System;
using System.Windows.Forms;
using System.Drawing;

namespace ChemistryApp.SecondPage
{
    /// <summary>
    /// flash播放器，用来调用原来的flash
    /// </summary>
    class PlaySwfPanel : Panel
    {
        /// <summary>
        /// flash路径
        /// </summary>
        private string _swfFilePath = null;
        public string swfFilePath
        {
            get { return _swfFilePath; }
            set { _swfFilePath = value; }
        }
        private Button btn_close;
        private AxShockwaveFlashObjects.AxShockwaveFlash FlashBox;
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
        public PlaySwfPanel()
        {
            this.FlashBox = new AxShockwaveFlashObjects.AxShockwaveFlash();
            btn_close = new Button();
            CreatePanel();
        }

        /// <summary>
        /// 创建panel和flash播放器
        /// </summary>
        private void CreatePanel()
        {
            int width = Screen.PrimaryScreen.Bounds.Width;
            int height = Screen.PrimaryScreen.Bounds.Height;
            this.Name = "PPTPlayPanel";
            this.Location = new Point(0, 0);
            this.BackColor = Color.Black;
            this.Size = new Size(width, height);
            this.Controls.Add(this.btn_close);
            //this.Controls.Add(this.FlashBox);

            //关闭按钮
            this.btn_close.Location = new System.Drawing.Point(0, 0);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(120, 29);
            this.btn_close.TabIndex = 21;
            this.btn_close.Text = "关闭";
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new EventHandler(OnClickClosePanel);
        }

        /// <summary>
        /// 关闭面板
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnClickClosePanel(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            MainForm mainForm = btn.Parent.Parent as MainForm;
            Panel parentPanel = btn.Parent as Panel;
            mainForm.Controls.Remove(parentPanel);
            mainForm.Controls.Add(mainForm.MainFlashBox);
            mainForm.MainFlashBox.Visible = false;
            mainForm.MainPanel.Visible = true;
            btn.Dispose();
            parentPanel.Dispose();
        }
    }
}
