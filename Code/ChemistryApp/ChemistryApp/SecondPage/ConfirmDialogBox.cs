using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using ChemistryApp.EnumType;

namespace ChemistryApp.SecondPage
{

    class ConfirmDialogBox : Panel
    {
        private System.Windows.Forms.Panel panel_confirmBox;
        private System.Windows.Forms.PictureBox comfire_pic_title;
        private System.Windows.Forms.PictureBox confirm_OK;
        private System.Windows.Forms.PictureBox confire_NO;
        /// <summary>
        /// 确定按钮
        /// </summary>
        private EventHandler ButtonOkEvent;

        public ConfirmDialogBox(EventHandler btnOkEvent)
        {
            this.ButtonOkEvent = btnOkEvent;
            this.confire_NO = new System.Windows.Forms.PictureBox();
            this.confirm_OK = new System.Windows.Forms.PictureBox();
            this.comfire_pic_title = new PictureBox();
            InitComponent();
        }

        private void InitComponent()
        {
            // 
            // panel_confirmBox
            // 
            this.Controls.Add(this.confirm_OK);
            this.Controls.Add(this.confire_NO);
            this.Controls.Add(this.comfire_pic_title);
            this.Location = new System.Drawing.Point(412, 362);
            this.Name = "panel_confirmBox";
            this.Size = new System.Drawing.Size(210, 100);
            this.TabIndex = 21;
            // 
            // confire_NO
            // 
            this.confire_NO.Image = global::ChemistryApp.Properties.Resources.no_up;
            this.confire_NO.Location = new System.Drawing.Point(0, 56);
            this.confire_NO.Name = "confire_NO";
            this.confire_NO.Size = new System.Drawing.Size(105, 44);
            this.confire_NO.TabIndex = 1;
            this.confire_NO.TabStop = false;
            this.confire_NO.Click += new EventHandler(ButtonCancelEvent);
            // 
            // confirm_OK
            // 
            this.confirm_OK.Image = global::ChemistryApp.Properties.Resources.ok_up;
            this.confirm_OK.Location = new System.Drawing.Point(105, 56);
            this.confirm_OK.Name = "confirm_OK";
            this.confirm_OK.Size = new System.Drawing.Size(105, 44);
            this.confirm_OK.TabIndex = 2;
            this.confirm_OK.TabStop = false;
            // 
            // comfire_pic_title
            // 
            this.comfire_pic_title.Image = global::ChemistryApp.Properties.Resources.deletetitle;
            this.comfire_pic_title.Location = new System.Drawing.Point(0, 0);
            this.comfire_pic_title.Name = "comfire_pic_title";
            this.comfire_pic_title.Size = new System.Drawing.Size(210, 57);
            this.comfire_pic_title.TabIndex = 0;
            this.comfire_pic_title.TabStop = false;
        }

        /// <summary>
        /// 点击取消按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonCancelEvent(object sender,EventArgs e)
        {
            this.Parent.Controls.Remove(this);
        }
    }
}
