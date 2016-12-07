using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace ChemistryApp.SearchPage
{
    public class SearchContentPage : Panel
    {
        public List<SearchResultItemPanel> itemList;
        public SearchContentPage()
        {
            if (itemList == null)
            {
                itemList = new List<SearchResultItemPanel>();
            }

        }
        public SearchContentPage(string _strContent)
        {
            if (itemList == null)
            {
                itemList = new List<SearchResultItemPanel>();
            }
            SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            SetStyle(ControlStyles.UserPaint, true);
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            InitCompent(_strContent);
        }

        private void InitCompent(string _strContent)
        {
            // 
            // panel_content
            // 
            this.BackColor = System.Drawing.SystemColors.Control;
            //创建ITEM
            CreateItem(_strContent);
            this.AutoScroll = true;
            this.Location = new System.Drawing.Point(1, 120);
            this.Name = "panel_content";
            this.Size = new System.Drawing.Size(855, 431);
            this.TabIndex = 6;
        }

        /// <summary>
        /// 创建item
        /// </summary>
        public void CreateItem(string _strContent)
        {
            itemList.Clear();
            string selectSql = "select * from AllTeaching where Title like '%" + _strContent + "%'";
            try
            {
                DataSet ds = AccessDBConn.ExecuteQuery(selectSql, "AllTeaching");
                DataRow[] dr = ds.Tables["AllTeaching"].Select();
                for (int i = 0; i < dr.Count(); i++)
                {
                    SearchResultItemPanel item = new SearchResultItemPanel(10, 0 + (i * 36), dr[i]["Type"].ToString(), dr[i]["Title"].ToString(), dr[i]["URL"].ToString());
                    if (i % 2 == 0)
                    {
                        item.BackColor = Color.FromArgb(245, 245, 247);
                    }
                    else
                    {
                        item.BackColor = Color.White;
                    }
                    this.Controls.Add(item);
                    itemList.Add(item);
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
        }


        /// <summary>
        /// 创建item
        /// </summary>
        public void CreateItemOnSelect(object sender, EventArgs e)
        {
            int index = 0;
            this.Controls.Clear();
            for (int i = 0; i < itemList.Count(); i++)
            {
                if (itemList[i].strType == ((Control)sender).Name)
                {
                    if (i % 2 == 0)
                    {
                        itemList[i].BackColor = Color.FromArgb(245, 245, 247);
                    }
                    else
                    {
                        itemList[i].BackColor = Color.White;
                    }
                    itemList[i].Location = new Point(0, index * 36);
                    this.Controls.Add(itemList[i]);
                    index++;
                }
                
            }
        }

       
    }
}
