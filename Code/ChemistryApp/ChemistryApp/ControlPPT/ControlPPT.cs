using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using POWERPOINT = Microsoft.Office.Interop.PowerPoint;
using Microsoft.Office.Interop.Excel;
using Microsoft.Office.Interop.Word;
using OFFICECORE = Microsoft.Office.Core;
using System.Windows;
using System.Collections;
using System.Windows.Forms;

namespace ChemistryApp
{
    class ControlPPT
    {
        public POWERPOINT.Application objApp = null;
        public POWERPOINT.Presentation objPresSet = null;
        public POWERPOINT.SlideShowWindows objSSws;
        public POWERPOINT.SlideShowTransition objSST;
        public POWERPOINT.SlideShowSettings objSSS;
        public POWERPOINT.SlideRange objSldRng;
        bool bAssistanOn;


        public void PPTOpen(string filePath)
        {
            if (this.objApp != null)
            {
                return;
            }
            try
            {
                objApp = new POWERPOINT.Application();
                objPresSet = objApp.Presentations.Open(filePath, OFFICECORE.MsoTriState.msoFalse, OFFICECORE.MsoTriState.msoCTrue, OFFICECORE.MsoTriState.msoFalse);
                bAssistanOn = objApp.Assistant.On;
                objApp.Assistant.On = false;
                objSSS = this.objPresSet.SlideShowSettings;
                
                //objApp.PresentationOpen += OnPPTClose;
               
                objSSS.Run();
            }
            catch (Exception)
            {
                this.objApp.Quit();
            }
        }

        public void PPTAuto(string filePath,int playTime)
        {
            if (this.objApp != null)
            {
                return;
            }

            objApp = new POWERPOINT.Application();
            objPresSet = objApp.Presentations.Open(filePath, OFFICECORE.MsoTriState.msoCTrue, OFFICECORE.MsoTriState.msoFalse, OFFICECORE.MsoTriState.msoFalse);
            int Slides = objPresSet.Slides.Count;
            int[] SlideIdx = new int[Slides];
            for (int i = 0; i < Slides; i++)
            {
                SlideIdx[i] = i + 1;
            }
            objSldRng = objPresSet.Slides.Range(SlideIdx);
            objSST = objSldRng.SlideShowTransition;
            objSST.AdvanceOnTime = OFFICECORE.MsoTriState.msoCTrue;
            //设置翻页时间
            objSST.AdvanceOnTime = OFFICECORE.MsoTriState.msoCTrue;
            objSST.AdvanceTime = playTime;
            //翻页时的特效
            objSST.EntryEffect = POWERPOINT.PpEntryEffect.ppEffectNone;
            objSSS = objPresSet.SlideShowSettings;
            objSSS.StartingSlide = 1;
            objSSS.EndingSlide = Slides;
            objSSS.Run();
            //
            objSSws = objApp.SlideShowWindows;
            while (objSSws.Count >= 1)
            {
                System.Threading.Thread.Sleep(playTime * 100);
            }
            this.objPresSet.Close();
            this.objApp.Quit();
        }

        /// <summary>
        /// ppt下一页
        /// </summary>
        public void NextSlide()
        {
            if (this.objApp != null)
            {
                this.objPresSet.SlideShowWindow.View.Next();
            }
        }

        /// <summary>
        /// PPt上一页
        /// </summary>
        public void PreviousSlide()
        {
            if (this.objApp != null)
            {
                this.objPresSet.SlideShowWindow.View.Previous();
            }
        }

        /// <summary>
        /// 对当前的PPT页面进行图片插入操作。
        /// </summary>
        /// <param name="alImage">图片对象信息数组</param>
        /// <param name="offsetx">插入图片距离左边长度</param>
        /// <param name="pixperPoint">距离比例值</param>
        /// <returns>是否添加成功！</returns>
        //public bool InsertToSlide(List<>)


        private void SlideParams()
        {
            double slideWidth = this.objPresSet.PageSetup.SlideWidth;
            double slideHeight = this.objPresSet.PageSetup.SlideHeight;
            //double inkCanWidth = SystemParameters.PrimaryScreenWidth;

        }

        /// <summary>
        /// 关闭PPT文档
        /// </summary>
        public void PPTClose()
        {
            if (this.objPresSet != null)
            {
                DialogResult ok = MessageBox.Show("是否保存修改的笔迹!");
                if (ok == DialogResult.OK)
                {
                    this.objPresSet.Save();
                }
            }
            if (this.objApp != null)
            {
                this.objApp.Quit();
            }
            GC.Collect();
        }
    }
}
