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
using ChemistryApp.MyLesson;
using ChemistryApp.EnumType;
using ChemistryApp.MyTeaching;


namespace ChemistryApp.SecondPage 
{
    class OtherSecondPage : Panel
    {
        public OtherSecondPage()
        {
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Location = new System.Drawing.Point(100, 174);
            this.Name = "panel_OtherSecond";
            this.Size = new System.Drawing.Size(810, 460);
            this.TabIndex = 21;
        }


    }
}
