using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChemistryApp
{
    class ShowTipsPanel : Panel
    {
        private Label lab_tips;
        //使用单例
        private static ShowTipsPanel instance;
        public static ShowTipsPanel GetInstance
        {
            get
            {
                if (instance == null)
                {
                    instance = new ShowTipsPanel();
                }
                return instance;
            }
        }

        /// <summary>
        /// 初始化控件
        /// </summary>
        public void InitControls(string _strTips)
        {
            //初始化
            this.lab_tips = new Label();

            this.Name = "showTipsPanel";
            this.Location = new System.Drawing.Point(410, 350);
            this.Size = new System.Drawing.Size(210, 100);
            this.Controls.Add(this.lab_tips);
            this.BackgroundImage = global::ChemistryApp.Properties.Resources._1600x900背景;

            this.lab_tips.Name = "lab_tips";
            this.lab_tips.Location = new System.Drawing.Point(0, 0);
            this.lab_tips.Size = new System.Drawing.Size(100, 50);
            this.lab_tips.Font = new System.Drawing.Font("苹方 中等", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lab_tips.Text = _strTips;
        }


    }
}
