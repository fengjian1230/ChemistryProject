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
        private PictureBox btn_close;
        private AxShockwaveFlashObjects.AxShockwaveFlash FlashBox;
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
        public PlaySwfPanel()
        {

            SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            SetStyle(ControlStyles.UserPaint, true);
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);

            this.FlashBox = new AxShockwaveFlashObjects.AxShockwaveFlash();
            btn_close = new PictureBox();
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
            //this.BackColor = Color.Transparent;
            this.Size = new Size(width, height);
            this.Controls.Add(this.btn_close);
            this.BackgroundImage = global::ChemistryApp.Properties.Resources._1600x900背景;
            //this.Controls.Add(this.FlashBox);

            //关闭按钮
            this.btn_close.BackColor = Color.Transparent;
            this.btn_close.Location = new System.Drawing.Point(0, 0);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(42, 43);
            this.btn_close.TabIndex = 21;
            this.btn_close.Image = global::ChemistryApp.Properties.Resources._0_05;
            this.btn_close.Cursor = Cursors.Hand;
            this.btn_close.Click += new EventHandler(OnClickClosePanel);
        }

        /// <summary>
        /// 关闭面板
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnClickClosePanel(object sender, EventArgs e)
        {
            Control btn = (Control)sender;
            MainForm mainForm = btn.Parent.Parent as MainForm;
            Panel parentPanel = btn.Parent as Panel;
            mainForm.Controls.Remove(parentPanel);
            mainForm.Controls.Add(mainForm.MainFlashBox);
            mainForm.Controls.Add(mainForm.previewAudioWindow);
            mainForm.previewAudioWindow.Ctlcontrols.stop();
            mainForm.previewAudioWindow.Visible = false;
            mainForm.previewAudioWindow.URL = null;
            mainForm.MainFlashBox.Visible = false;
            mainForm.MainPanel.Visible = true;

        }
    }
}
