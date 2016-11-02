using System;
using System.Collections.Generic;
using System.Drawing;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChemistryApp
{
    class MyTeachingItem
    {
        private System.Windows.Forms.Panel panel_myTeachingItem;
        private System.Windows.Forms.Label txt_myTeachingTitle;
        private System.Windows.Forms.PictureBox pic_typeIcon;
        private System.Windows.Forms.PictureBox pic_myteachingDelete;
        private System.Windows.Forms.PictureBox pic_myteachingDown;
        private System.Windows.Forms.PictureBox pic_myteachingUp;
        public MyTeachingItem()
        {
            panel_myTeachingItem = new Panel();
            txt_myTeachingTitle = new Label();
            pic_myteachingDelete = new PictureBox();
            pic_myteachingDown = new PictureBox();
            pic_myteachingUp = new PictureBox();
            pic_typeIcon = new PictureBox();
        }

        public Panel MyTeachingItemPanel(int posX,int posY)
        {
            // 
            // panel_myTeachingItem
            // 
            this.panel_myTeachingItem.BackColor = System.Drawing.Color.Transparent;
            this.panel_myTeachingItem.BackgroundImage = global::ChemistryApp.Properties.Resources.myteachingItemBG;
            this.panel_myTeachingItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel_myTeachingItem.Controls.Add(this.txt_myTeachingTitle);
            this.panel_myTeachingItem.Controls.Add(this.pic_typeIcon);
            this.panel_myTeachingItem.Controls.Add(this.pic_myteachingDelete);
            this.panel_myTeachingItem.Controls.Add(this.pic_myteachingDown);
            this.panel_myTeachingItem.Controls.Add(this.pic_myteachingUp);
            this.panel_myTeachingItem.Location = new System.Drawing.Point(posX, posY);
            this.panel_myTeachingItem.Name = "panel_myTeachingItem";
            this.panel_myTeachingItem.Size = new System.Drawing.Size(279, 70);
            this.panel_myTeachingItem.TabIndex = 0;
            // 
            // pic_myteachingUp
            // 
            this.pic_myteachingUp.BackgroundImage = global::ChemistryApp.Properties.Resources.向上键;
            this.pic_myteachingUp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pic_myteachingUp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pic_myteachingUp.Location = new System.Drawing.Point(10, 8);
            this.pic_myteachingUp.Name = "pic_myteachingUp";
            this.pic_myteachingUp.Size = new System.Drawing.Size(15, 15);
            this.pic_myteachingUp.TabIndex = 0;
            this.pic_myteachingUp.TabStop = false;
            // 
            // pic_myteachingDown
            // 
            this.pic_myteachingDown.BackgroundImage = global::ChemistryApp.Properties.Resources.向下键;
            this.pic_myteachingDown.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pic_myteachingDown.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pic_myteachingDown.Location = new System.Drawing.Point(31, 8);
            this.pic_myteachingDown.Name = "pic_myteachingDown";
            this.pic_myteachingDown.Size = new System.Drawing.Size(15, 15);
            this.pic_myteachingDown.TabIndex = 1;
            this.pic_myteachingDown.TabStop = false;
            // 
            // pic_myteachingDelete
            // 
            this.pic_myteachingDelete.BackgroundImage = global::ChemistryApp.Properties.Resources.删除键;
            this.pic_myteachingDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pic_myteachingDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pic_myteachingDelete.Location = new System.Drawing.Point(257, 8);
            this.pic_myteachingDelete.Name = "pic_myteachingDelete";
            this.pic_myteachingDelete.Size = new System.Drawing.Size(15, 15);
            this.pic_myteachingDelete.TabIndex = 2;
            this.pic_myteachingDelete.TabStop = false;
            // 
            // pic_typeIcon
            // 
            this.pic_typeIcon.BackgroundImage = global::ChemistryApp.Properties.Resources.icon_1_03;
            this.pic_typeIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pic_typeIcon.Location = new System.Drawing.Point(10, 30);
            this.pic_typeIcon.Name = "pic_typeIcon";
            this.pic_typeIcon.Size = new System.Drawing.Size(55, 37);
            this.pic_typeIcon.TabIndex = 3;
            this.pic_typeIcon.TabStop = false;
            // 
            // txt_myTeachingTitle
            // 
            this.txt_myTeachingTitle.AutoSize = true;
            this.txt_myTeachingTitle.Font = new System.Drawing.Font("苹方 中等", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt_myTeachingTitle.Location = new System.Drawing.Point(100, 39);
            this.txt_myTeachingTitle.Name = "txt_myTeachingTitle";
            this.txt_myTeachingTitle.Size = new System.Drawing.Size(130, 21);
            this.txt_myTeachingTitle.TabIndex = 4;
            this.txt_myTeachingTitle.Text = "《氯的化学反应》";

            return panel_myTeachingItem;
        }
    }

   

}
