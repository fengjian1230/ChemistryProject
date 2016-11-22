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
using ChemistryApp.EnumType;
using ChemistryApp.MyLesson;

namespace ChemistryApp.SecondPage
{
    class PlayContentPanelList : MyLessonChildItem
    {
        public PlayContentPanelList(int posX, int posY, string _strTitle, string _strType) : base(posX, posY, _strTitle, _strType)
        {
            base.pic_play.Click -= base.PlayButton_Click;
            base.pic_play.Click += new EventHandler(PlayButtonOnPPTPage_Click);
        }


        /// <summary>
        /// 点击预览按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PlayButtonOnPPTPage_Click(object sender, EventArgs e)
        {
            Control parentPanel = ((PictureBox)sender).Parent.Parent.Parent;
            ContentPlayPanel contentPanel = (ContentPlayPanel)parentPanel;
            //根据题目来查询到路径
            string selectParentSql = "select * from LessonList where  LessonTitle = '" + base.fieldName + "'";
            try
            {
                DataSet ds = AccessDBConn.ExecuteQuery(selectParentSql, "LessonList");
                DataRow[] dr = ds.Tables["LessonList"].Select();
                //根据字段查询到子表，然后找到路径预览课件
                string selectChildSql = "select * from " + dr[0]["LessonContent"] + " where Title = '" + base.lab_title.Text + "'";
                DataSet childDs = AccessDBConn.ExecuteQuery(selectChildSql, dr[0]["LessonContent"].ToString());
                DataRow[] childDr = childDs.Tables[dr[0]["LessonContent"].ToString()].Select();
                
                string _fileType = childDr[0]["Type"].ToString();
                string _filePath = childDr[0]["URL"].ToString();
                switch (_fileType)
                {
                  
                    case "PPT":
                        contentPanel.ContentControlFramer.Close();
                        contentPanel.ContentControlFramer.Open(System.Windows.Forms.Application.StartupPath + @_filePath);
                        break;
                    case "思维导图":
                        /* 思维导图*/
                        break;
                    case "视频":
                        /* 视频文件*/
                        break;
                    case "实验":
                        /* 实验*/
                        break;
                    case "反应方程":
                        /* 反应方程*/
                        break;
                    case "习题":
                        /*习题*/
                        break;
                    default:
                        break;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }
    }
}
