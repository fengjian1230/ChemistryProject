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
    class SearchContentPage : Panel
    {
        private System.Windows.Forms.Label lab_tips;
        private System.Windows.Forms.Label lab_play;
        private System.Windows.Forms.Label lab_type;
        private System.Windows.Forms.Label lab_title;
        public SearchContentPage(string _strContent)
        {
            this.lab_title = new System.Windows.Forms.Label();
            this.lab_type = new System.Windows.Forms.Label();
            this.lab_play = new System.Windows.Forms.Label();
            this.lab_tips = new System.Windows.Forms.Label();
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
            this.Controls.Add(this.lab_play);
            this.Controls.Add(this.lab_type);
            this.Controls.Add(this.lab_title);
            this.Controls.Add(this.lab_tips);
            this.AutoScroll = true;
            this.Location = new System.Drawing.Point(0, 36);
            this.Name = "panel_content";
            this.Size = new System.Drawing.Size(855, 431);
            this.TabIndex = 6;
            // 
            // lab_tips
            // 
            this.lab_tips.AutoSize = true;
            this.lab_tips.Font = new System.Drawing.Font("苹方 中等", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lab_tips.Location = new System.Drawing.Point(4, 24);
            this.lab_tips.Name = "lab_tips";
            this.lab_tips.Size = new System.Drawing.Size(165, 34);
            this.lab_tips.TabIndex = 0;
            this.lab_tips.Text = "从实验学化学";
            // 
            // lab_title
            // 
            this.lab_title.AutoSize = true;
            this.lab_title.Location = new System.Drawing.Point(178, 62);
            this.lab_title.Name = "lab_title";
            this.lab_title.Size = new System.Drawing.Size(37, 15);
            this.lab_title.TabIndex = 1;
            this.lab_title.Text = "标题";
            // 
            // lab_type
            // 
            this.lab_type.AutoSize = true;
            this.lab_type.Location = new System.Drawing.Point(460, 62);
            this.lab_type.Name = "lab_type";
            this.lab_type.Size = new System.Drawing.Size(37, 15);
            this.lab_type.TabIndex = 2;
            this.lab_type.Text = "类型";
            // 
            // lab_play
            // 
            this.lab_play.AutoSize = true;
            this.lab_play.Location = new System.Drawing.Point(716, 62);
            this.lab_play.Name = "lab_play";
            this.lab_play.Size = new System.Drawing.Size(37, 15);
            this.lab_play.TabIndex = 3;
            this.lab_play.Text = "预览";
        }

        /// <summary>
        /// 创建item
        /// </summary>
        private void CreateItem(string _strContent)
        {
            string selectSql = "select * from AllTeaching where Title like '%" + _strContent + "%'";
            try
            {
                DataSet ds = AccessDBConn.ExecuteQuery(selectSql, "AllTeaching");
                DataRow[] dr = ds.Tables["AllTeaching"].Select();
                for (int i = 0; i < dr.Count(); i++)
                {
                    SearchResultItemPanel item = new SearchResultItemPanel(10, 90 + (i * 36));
                    if (i % 2 == 0)
                    {
                        item.BackColor = Color.FromArgb(245, 245, 247);
                    }
                    else
                    {
                        item.BackColor = Color.White;
                    }
                    item.lab_titleContent.Text = dr[i]["Title"].ToString();
                    item.pic_typeContent.Image = SelectTypeIcon(dr[i]["Type"].ToString());
                    item.strType = dr[i]["Type"].ToString();
                    item.strURL = dr[i]["URL"].ToString();
                    this.Controls.Add(item);
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
        }

        /// <summary>
        /// 根据名字加载icon
        /// </summary>
        /// <param name="_typeName"></param>
        private Image SelectTypeIcon(string _typeName)
        {
            Image _typeIconIamge = null;
            switch (_typeName)
            {
                case "PPT":
                    _typeIconIamge = global::ChemistryApp.Properties.Resources.pptIcon;
                    break;
                case "反应方程":
                    _typeIconIamge = global::ChemistryApp.Properties.Resources.fanyingfangchengIcon;
                    break;
                case "视频":
                    _typeIconIamge = global::ChemistryApp.Properties.Resources.videoIcon;
                    break;
                case "思维导图":
                    _typeIconIamge = global::ChemistryApp.Properties.Resources.mandMapIcon;
                    break;
                case "实验":
                    _typeIconIamge = global::ChemistryApp.Properties.Resources.flashIcon;
                    break;
                case "习题":
                    _typeIconIamge = global::ChemistryApp.Properties.Resources.xitiIcon;
                    break;
                default:
                    break;
            }
            return _typeIconIamge;
        }
    }
}
