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
using ChemistryApp.SearchPage;

namespace ChemistryApp.SecondPage
{
    class SecondPageContent : Panel
    {
        /// <summary>
        /// 表名
        /// </summary>
        private string tableName;
        public string TableName
        {
            get { return tableName; }
            set { tableName = value; }
        }

        public SecondPageContent()
        {
            InitCompent();
        }

        private void InitCompent()
        {
            // 
            // panel_secondPageContent
            // 
            CreateItem();
            this.Location = new System.Drawing.Point(2, 102);
            this.Name = "panel_secondPageContent";
            this.Size = new System.Drawing.Size(806, 318);
            this.TabIndex = 7;
        }

        /// <summary>
        /// 创建item
        /// </summary>
        private void CreateItem()
        {
            string selectSql = "select * from " + tableName + "";
            //string selectSql = "select * from AllTeaching where Title like '%" + _strContent + "%'";
            try
            {
                DataSet ds = AccessDBConn.ExecuteQuery(selectSql, tableName);
                DataRow[] dr = ds.Tables[tableName].Select();
                for (int i = 0; i < dr.Count(); i++)
                {
                    SearchResultItemPanel item = new SearchResultItemPanel(10, i * 36);
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
