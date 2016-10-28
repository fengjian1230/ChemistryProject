using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Office.Core;
using Microsoft.Office.Interop.Word;
using System.Windows;
using System.Windows.Forms;

namespace ChemistryApp
{
    class ControlWord
    {
        Microsoft.Office.Interop.Word.Application app = new Microsoft.Office.Interop.Word.Application(); //可以打开word程序 
        //Document doc = null;

        public void OpenFile()
        {
            try
            {
               
                



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
