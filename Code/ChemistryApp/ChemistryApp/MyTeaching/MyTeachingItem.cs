﻿using System;
using System.Drawing;
using System.Data;
using System.Windows.Forms;
using ChemistryApp.MyTeaching;
using ChemistryApp.SecondPage;

namespace ChemistryApp
{

    /// <summary>
    /// 我的课件内容
    /// </summary>
    class MyTeachingItem : Panel
    {
        private System.Windows.Forms.Label txt_myTeachingTitle;
        private System.Windows.Forms.PictureBox pic_typeIcon;
        private System.Windows.Forms.PictureBox pic_myteachingDelete;
        private System.Windows.Forms.PictureBox pic_myteachingDown;
        private System.Windows.Forms.PictureBox pic_myteachingUp;
        private System.Windows.Forms.PictureBox pic_select;
        public string itemName;
        public MyTeachingItem(int _posX, int _posY, string _itemTitle, string _type)
        {
            txt_myTeachingTitle = new Label();
            pic_myteachingDelete = new PictureBox();
            pic_myteachingDown = new PictureBox();
            pic_myteachingUp = new PictureBox();
            pic_typeIcon = new PictureBox();
            pic_select = new PictureBox();
            this.itemName = _itemTitle;
            MyTeachingItemPanel(_posX, _posY, _itemTitle, _type);
        }

        #region 创建item
        public void MyTeachingItemPanel(int _posX,int _posY,string _itemTitle,string _type)
        {
           
            // 
            // panel_myTeachingItem
            // 
            this.BackColor = System.Drawing.Color.Transparent;
            this.BackgroundImage = global::ChemistryApp.Properties.Resources.myteachingItemBG;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Controls.Add(this.txt_myTeachingTitle);
            this.Controls.Add(this.pic_typeIcon);
            this.Controls.Add(this.pic_myteachingDelete);
            this.Controls.Add(this.pic_myteachingDown);
            this.Controls.Add(this.pic_myteachingUp);
            this.Controls.Add(this.pic_select);
            this.Location = new System.Drawing.Point(_posX, _posY);
            this.Name = "panel_myTeachingItem";
            this.Size = new System.Drawing.Size(279, 70);
            this.TabIndex = 0;
            
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
            this.pic_myteachingUp.Click += new EventHandler(PicUp_Click);
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
            this.pic_myteachingDown.Click += new EventHandler(PicDown_Click);


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
            this.pic_myteachingDelete.Click += new EventHandler(OnDeleteCilck);
            // 
            // pic_typeIcon
            // 
            this.pic_typeIcon.BackgroundImage = TypeIconPicture(_type);
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
            this.txt_myTeachingTitle.Location = new System.Drawing.Point(65, 39);
            this.txt_myTeachingTitle.Name = "txt_myTeachingTitle";
            this.txt_myTeachingTitle.Size = new System.Drawing.Size(130, 21);
            this.txt_myTeachingTitle.TabIndex = 4;
            this.txt_myTeachingTitle.Text = _itemTitle ;

            //选择按钮
            this.pic_select.Image = global::ChemistryApp.Properties.Resources.删除键;
            this.pic_select.Name = "pic_select";
            this.pic_select.BackgroundImageLayout = ImageLayout.None;
            this.pic_select.Location = new System.Drawing.Point(-15, 30);
            this.pic_select.Size = new System.Drawing.Size(15, 15);
            this.pic_select.TabIndex = 3;
            this.pic_select.TabStop = false;
        }
        #endregion


        #region 按钮事件

        private void OnDeleteCilck(object sender, EventArgs e)
        {
            ConfirmDialogBox confirmBox = new ConfirmDialogBox(PicDeleteClickEvent);
            PictureBox pic = (PictureBox)sender;
            Control mainPanle = pic.Parent.Parent.Parent.Parent as Control;
            mainPanle.Controls.Add(confirmBox);
            confirmBox.BringToFront();
        }

        /// <summary>
        /// 删除按钮事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PicDeleteClickEvent(object sender, EventArgs e)
        {
            string sqlStr = "delete from MyTeaching where TeachingTitle = '" + this.txt_myTeachingTitle.Text + "'";
            int i = AccessDBConn.ExecuteNonQuery(sqlStr);
            if (i != 0)
            {
                MainForm mainForm = ((Control)sender).Parent.Parent.Parent as MainForm;
                MyTeachingItemManager.GetInstace.ShowTeachingCount(mainForm);
                MyTeachingItemManager.GetInstace.OnItemDelete?.Invoke();
                ((PictureBox)sender).Parent.Parent.Controls.Remove(((PictureBox)sender).Parent);
                MessageBox.Show("删除完成!");     
            }

        }
        /// <summary>
        /// 向上按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PicDown_Click(object sender, EventArgs e)
        {
            string sqlStr = "select * from MyTeaching where TeachingTitle = '" + itemName + "'";
            try
            {
                DataSet ds = AccessDBConn.ExecuteQuery(sqlStr, "MyTeaching");
                DataRow[] dr = ds.Tables["MyTeaching"].Select();
                int index = int.Parse(dr[0]["TeachingSort"].ToString());
                if (index + 1 != MyTeachingItemManager.GetInstace.listPanelItem.Count)
                {
                    string _sqlStr = "update MyTeaching set TeachingSort = " + index.ToString() + " where TeachingTitle = '" + MyTeachingItemManager.GetInstace.listPanelItem[index + 1].itemName + "'";
                    int nextInt = AccessDBConn.ExecuteNonQuery(_sqlStr);
                    string strUpdate = "update MyTeaching set TeachingSort = " + (index + 1).ToString() + " where TeachingTitle = '" + itemName + "'";
                    int curr = AccessDBConn.ExecuteNonQuery(strUpdate);
                    MyTeachingItemManager.GetInstace.OnItemDelete?.Invoke();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
          
            
        }
        /// <summary>
        /// 向上按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PicUp_Click(object sender, EventArgs e)
        {
            string sqlStr = "select * from MyTeaching where TeachingTitle = '" + itemName + "'";
            try
            {
                DataSet ds = AccessDBConn.ExecuteQuery(sqlStr, "MyTeaching");
                DataRow[] dr = ds.Tables["MyTeaching"].Select();
                int index = int.Parse(dr[0]["TeachingSort"].ToString());
                if (index != 0)
                {
                    string _sqlStr = "update MyTeaching set TeachingSort = " + index.ToString() + " where TeachingTitle = '" + MyTeachingItemManager.GetInstace.listPanelItem[index - 1].itemName + "'";
                    int nextInt = AccessDBConn.ExecuteNonQuery(_sqlStr);
                    string strUpdate = "update MyTeaching set TeachingSort = " + (index - 1).ToString() + " where TeachingTitle = '" + itemName + "'";
                    int curr = AccessDBConn.ExecuteNonQuery(strUpdate);
                    MyTeachingItemManager.GetInstace.OnItemDelete?.Invoke();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        #endregion


        /// <summary>
        /// ICon图标
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
        private Image TypeIconPicture(string _strType)
        {
            Image image = global::ChemistryApp.Properties.Resources.icon_1_03;
            switch (_strType)
            {
                case "PPT":
                    image = global::ChemistryApp.Properties.Resources.icon_1_06;
                    break;
                case "实验":
                    image = global::ChemistryApp.Properties.Resources.icon_1_03;
                    break;
                case "思维导图":
                    image = global::ChemistryApp.Properties.Resources.icon_1_09;
                    break;
                case "反应方程":
                    image = global::ChemistryApp.Properties.Resources.icon_1_16;
                    break;
                case "习题":
                    image = global::ChemistryApp.Properties.Resources.icon_1_14;
                    break;
                case "视频":
                    image = global::ChemistryApp.Properties.Resources.icon_1_12;
                    break;
            }
            return image;
        }
    }



}
