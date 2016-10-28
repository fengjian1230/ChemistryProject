using System;
using System.Collections.Generic;
using System.Drawing;
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
    class MyLessonItem
    {
       
        public Control AddBtn()
        {
            Button mBtn = new Button();
            mBtn.Location = new System.Drawing.Point(10, 0);
            mBtn.Name = "button1";
            mBtn.Size = new System.Drawing.Size(120, 40);
            mBtn.TabIndex = 9;
            mBtn.Text = "m_btn";
            mBtn.UseVisualStyleBackColor = true;
            return mBtn;
        }
    }
}
