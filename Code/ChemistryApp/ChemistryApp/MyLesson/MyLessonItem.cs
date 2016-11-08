﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ChemistryApp.MyLesson;
using ChemistryApp.EnumType;

/// <summary>
/// 创建左边收缩panel中的课时item
/// </summary>
namespace ChemistryApp
{
    class MyLessonItem
    {

        #region 字段
        private System.Windows.Forms.Panel panelItem;
        private System.Windows.Forms.Label lab_open;
        private System.Windows.Forms.Label lab_top;
        private System.Windows.Forms.PictureBox pic_top;
        private System.Windows.Forms.PictureBox pic_book;
        private System.Windows.Forms.Label lab_className;
        private System.Windows.Forms.Label lab_tips;
        private System.Windows.Forms.PictureBox pic_delete;
        
        /// <summary>
        #endregion

        #region 构造函数
        /// <summary>
        /// 构造函数
        /// </summary>
        public MyLessonItem()
        {
            //实例化控件
            panelItem = new Panel();
            lab_top = new Label();
            lab_className = new Label();
            lab_open = new Label();
            lab_tips = new Label();
            pic_top = new PictureBox();
            pic_book = new PictureBox();
            pic_delete = new PictureBox();
        }
        #endregion

        #region 创建控件
        /// <summary>
        /// 创建控件
        /// </summary>
        /// <returns></returns>
        public Panel CreateControl(int posX, int posY, string _strClassName, string _strTips)
        {
            // panel1
            // 
            this.panelItem.BackColor = System.Drawing.Color.Transparent;
            this.panelItem.BackgroundImage = global::ChemistryApp.Properties.Resources.myLessonItemBG;
            this.panelItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panelItem.Controls.Add(this.lab_tips);
            this.panelItem.Controls.Add(this.lab_className);
            this.panelItem.Controls.Add(this.pic_book);
            this.panelItem.Controls.Add(this.lab_open);
            this.panelItem.Controls.Add(this.lab_top);
            this.panelItem.Controls.Add(this.pic_top);
            this.panelItem.Controls.Add(this.pic_delete);
            this.panelItem.Font = new System.Drawing.Font("苹方 特粗", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.panelItem.Location = new System.Drawing.Point(posX, posY);
            this.panelItem.Name = "panelItem";
            this.panelItem.Size = new System.Drawing.Size(279, 140);
            this.panelItem.TabIndex = 1;
            ///删除键
            this.pic_delete.Name = "pic_delete";
            this.pic_delete.Size = new Size(15, 15);
            this.pic_delete.BackgroundImage = global::ChemistryApp.Properties.Resources.删除键;
            this.pic_delete.Location = new System.Drawing.Point(315, 70);
            this.pic_delete.TabIndex = 0;
            this.pic_delete.Cursor = Cursors.Hand;
            this.pic_delete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pic_delete.BackColor = System.Drawing.Color.Transparent;
            this.pic_delete.Click += new EventHandler(this.BtnDelete_Click);
            // 
            // pictureBox2
            // 
            this.pic_top.Location = new System.Drawing.Point(4, 8);
            this.pic_top.BackgroundImage = global::ChemistryApp.Properties.Resources._1_03;
            this.pic_top.BackgroundImageLayout = ImageLayout.Center;
            this.pic_top.Name = "pictureBox2";
            this.pic_top.Size = new System.Drawing.Size(19, 21);
            this.pic_top.TabIndex = 0;
            this.pic_top.TabStop = false;
            // 
            // label1
            // 
            this.lab_top.AutoSize = true;
            this.lab_top.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lab_top.Font = new System.Drawing.Font("苹方 中等", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lab_top.Location = new System.Drawing.Point(22, 7);
            this.lab_top.Name = "lab_top";
            this.lab_top.Size = new System.Drawing.Size(40, 21);
            this.lab_top.TabIndex = 1;
            this.lab_top.Text = "置顶";
            this.lab_top.Click += new EventHandler(TopLabelClick);
            // 
            // label2
            // 
            this.lab_open.AutoSize = true;
            this.lab_open.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lab_open.Font = new System.Drawing.Font("苹方 中等", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lab_open.Location = new System.Drawing.Point(239, 7);
            this.lab_open.Name = "lab_open";
            this.lab_open.Size = new System.Drawing.Size(40, 21);
            this.lab_open.TabIndex = 2;
            this.lab_open.Text = "展开";
            this.lab_open.Click += new EventHandler(OpenLabelClick);
            // 
            // pictureBox3
            // 
            this.pic_book.Location = new System.Drawing.Point(19, 46);
            this.pic_book.BackgroundImage = global::ChemistryApp.Properties.Resources.课件播放icon;
            this.pic_book.Name = "pic_book";
            this.pic_book.BackgroundImageLayout = ImageLayout.Center;
            this.pic_book.Size = new System.Drawing.Size(57, 64);
            this.pic_book.TabIndex = 3;
            this.pic_book.TabStop = false;
            // 
            // label3
            // 
            this.lab_className.AutoSize = true;
            this.lab_className.Font = new System.Drawing.Font("苹方 中等", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lab_className.Location = new System.Drawing.Point(86, 41);
            this.lab_className.Name = "lab_classTime";
            this.lab_className.Size = new System.Drawing.Size(90, 34);
            this.lab_className.TabIndex = 4;
            this.lab_className.Text = _strClassName;
            // 
            // label4
            // 
            this.lab_tips.AutoSize = true;
            this.lab_tips.Font = new System.Drawing.Font("苹方 中等", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lab_tips.Location = new System.Drawing.Point(83, 88);
            this.lab_tips.Name = "lab_tips";
            this.lab_tips.Size = new System.Drawing.Size(164, 18);
            this.lab_tips.TabIndex = 5;
            this.lab_tips.Text = "（" + _strTips + "）";

            return panelItem;
        }
        #endregion



        #region 事件
        /// <summary>
        /// 置顶按钮点击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TopLabelClick(object sender, EventArgs e)
        {
            int topIndex = 0;
            //拿到ID可以从数据库中读取然后置顶
            Label pic = (Label)sender;
            Control control = pic.Parent.GetChildAtPoint(new Point(86, 41));
            Label label = (Label)control;
            string sqlStr = "select * from LessonList where  LessonTitle like '%" + label.Text + "%'";
            DataSet ds = AccessDBConn.ExecuteQuery(sqlStr, "LessonList");
            try
            {
                DataRow[] dr = ds.Tables["LessonList"].Select();

                int index = int.Parse(dr[0]["ListID"].ToString());
                MyLessonItemManager.GetInstace.listPanelItem[index].Location = MyLessonItemManager.GetInstace.listPanelItemPoint[topIndex];
               
                for (int i = 0; i < MyLessonItemManager.GetInstace.listPanelItem.Count; i++)
                {
                    if (i != index)
                    {
                        topIndex++;
                        MyLessonItemManager.GetInstace.listPanelItem[i].Location = MyLessonItemManager.GetInstace.listPanelItemPoint[topIndex];

                    }
                }
                foreach (var item in dr)
                {
                    
                    
                }
               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// 展开按钮点击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OpenLabelClick(object sender,EventArgs e)
        {
            int itemLength = 0;
            Label pic = (Label)sender;
            Control control = pic.Parent.GetChildAtPoint(new Point(86, 41));
            Label label = (Label)control;
            pic.Parent.BackgroundImageLayout = ImageLayout.None;
            for (int i = 0; i < MyLessonItemManager.GetInstace.ChildItemNum.Count; i++)
            {
                if (MyLessonItemManager.GetInstace.ChildItemNum.ContainsKey(label.Text))
                {
                    itemLength = MyLessonItemManager.GetInstace.ChildItemNum[label.Text];
                }
            }
            if (MyLessonItemManager.GetInstace.state == LessonState.Close)
            {
                pic.Text = "展开";
                MyLessonItemManager.GetInstace.state = LessonState.Open;
                pic.Parent.Size = new Size(pic.Parent.Size.Width, 140);
            }
            else if (MyLessonItemManager.GetInstace.state == LessonState.Open && MyLessonItemManager.GetInstace.bianjiState == BianJiState.Bianji)
            {
                pic.Text = "折叠";
                pic.Parent.Size = new Size(pic.Parent.Size.Width, 140 + itemLength * 30);
                MyLessonItemManager.GetInstace.state = LessonState.Close;
            }
           
        }

        /// <summary>
        /// 删除按钮点击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnDelete_Click(object sender,EventArgs e)
        {
            PictureBox pic = (PictureBox)sender;
            Control control = pic.Parent.GetChildAtPoint(new Point(86, 41));
            Label label = (Label)control;
            string sqlStr = "delete from LessonList where LessonTitle = '" + label.Text + "'";
            int i = AccessDBConn.ExecuteNonQuery(sqlStr);
            if (i != 0)
            {
                MessageBox.Show("删除完成");
            }
        }

        #endregion
    }
}
