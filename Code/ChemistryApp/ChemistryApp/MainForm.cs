using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChemistryApp
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
           // string str = null;


            //foreach (RadioButton item in groupBox1.Controls)
            //{
            //    if (item.Checked)
            //    {
            //        MessageBox.Show(item.Text);
            //        str = item.Text;
            //    }
            //}
            //this.label1.Text = null;
            //string sql = "select * from LessonList where "+ str + " like '%"+ textBox1.Text+"%'" ;
            //if (str != null && this.textBox1.Text != "")
            //{
            
            //    DataSet ds = AccessDBConn.ExecuteQuery(sql);
            //    try
            //    {
            //        DataRow[] dr = ds.Tables["LessonList"].Select();
            //        foreach (var item in dr)
            //        {
            //            this.label1.Text += item[str].ToString();
            //        }


            //    }
            //    catch (Exception exp)
            //    {

            //        MessageBox.Show(exp.Message);
            //    }
            //}
            //else
            //{
            //    MessageBox.Show("不能为空");
            //}
           
           
          

            

            //string str = null;
            //for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            //{
            //    for (int j = 0; j < ds.Tables[0].Columns.Count; j++)
            //    {
            //        str += ds.Tables[0].Rows[i][j].ToString();
            //    }
            //}
            //this.textBox1.Text = str;
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string sql = "update LessonList set LessonID = '222?', LessonContent = '堵起！' where ID = 1";
            DialogResult dr = MessageBox.Show("提示信息", "提示信息", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (dr == DialogResult.Yes)
            {
                int i = AccessDBConn.ExecuteNonQuery(sql);
                if (i != 0)
                {
                    MessageBox.Show("操作成功");
                }
                else
                {
                    MessageBox.Show("操作失败！");
                }
            }
            else
            {
                MessageBox.Show("已经取消");
            }

            
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ControlPPT controlPPT = new ControlPPT();
            controlPPT.PPTOpen(@System.Windows.Forms.Application.StartupPath + "\\111.pptx");
            //controlPPT.PPTAuto(@System.Windows.Forms.Application.StartupPath + "\\111.pptx", 2);
        }

        private void button4_Click(object sender, EventArgs e)
        {

            //ControlWord controlWord = new ControlWord();
            //controlWord.OpenFile();
            //OpenFileDialog P_GetFile = new OpenFileDialog();       //创建打开文件对话框对象
            //DialogResult P_dr = P_GetFile.ShowDialog();        //显示打开文件对话框
            //if (P_dr == DialogResult.OK)           //是否单击确定
            //{
            //    webBrowser1.Navigate(P_GetFile.FileName);       //打开Word文档并显示
            //}



        }

        private void axFramerControl1_OnFileCommand(object sender, AxDSOFramer._DFramerCtlEvents_OnFileCommandEvent e)
        {

        }

        private void LeftPlaneTimer_Tick(object sender, EventArgs e)
        {
            long longWidth = LeftPlane.Width;
            //如果panel目前是隐藏的
            if (Convert.ToInt16(LeftPlane.Tag.ToString()) == 0)
            {
                if (longWidth >= 320)
                {
                    LeftPlaneTimer.Enabled = false;
                    LeftPlane.Tag = 1;//设置为显示标识
                    this.btn_shrink.BackgroundImage = global::ChemistryApp.Properties.Resources.btn_left;
                }
                else
                {
                    LeftPlane.Width += 20;
                }
            }
            //如果panel目前是显示的
            if (Convert.ToInt16(LeftPlane.Tag.ToString()) == 1)
            {
                if (longWidth == 0)
                {
                    LeftPlaneTimer.Enabled = false;
                    LeftPlane.Tag = 0;//设置为隐藏标识
                    this.btn_shrink.BackgroundImage = global::ChemistryApp.Properties.Resources.btn_right;
                }
                else
                {
                    LeftPlane.Width -= 20;
                }
            }
        }
        private void button1_Click_3(object sender, EventArgs e)
        {

            if (Convert.ToInt16(LeftPlane.Tag.ToString()) == 1)
            {
                LeftPlaneTimer.Start();

            }
            else
            {
                if (Convert.ToInt16(LeftPlane.Tag.ToString()) == 0)
                {
                    LeftPlaneTimer.Start();
                }
            }
        }

        private void btn_ChemicalElement_Click(object sender, EventArgs e)
        {

        }
    }
}
