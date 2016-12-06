using System.Drawing;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System;

namespace ChemistryApp.ControlPPTFonder
{
    public class ControlTransparent
    {
        /// <summary>
        /// 根据图片计算GraphicsPath路径
        /// </summary>
        /// <param name="img">gif或者png图片</param>
        /// <returns>图片不透明区域路径</returns>
        /// 用这个代码的时候需要选择项目属性->生成->勾选"允许不安全代码"
        /// 因为这里用到了指针，C#用指针式不安全的，具体可查看msdn
        private unsafe static GraphicsPath subGraphicsPath(Image img)
        {
            if (img == null) return null;

            // 建立GraphicsPath, 给我们的位图路径计算使用   
            GraphicsPath g = new GraphicsPath(FillMode.Alternate);

            Bitmap bitmap = new Bitmap(img);

            int width = bitmap.Width;
            int height = bitmap.Height;
            BitmapData bmData = bitmap.LockBits(new Rectangle(0, 0, width, height), ImageLockMode.ReadWrite, PixelFormat.Format32bppArgb);
            IntPtr ptr = bmData.Scan0;
            int bytes = Math.Abs(bmData.Stride) * bitmap.Height;
            byte[] argbValues = new byte[bytes];
            System.Runtime.InteropServices.Marshal.Copy(ptr, argbValues, 0, bytes);
            bitmap.UnlockBits(bmData);
            bitmap.Dispose();
            int X;
            int Y;
            int counter = 3;
            for (X = 0; X < height; X++)
            {
                for (Y = 0; Y < width; Y++)
                {
                    if (argbValues[counter] != 0)
                    {
                        g.AddRectangle(new Rectangle(Y, X, 1, 1));
                    }
                    counter += 4;
                }
            }
            return g;
        }

        /// <summary>
        /// 调用此函数后使图片透明
        /// </summary>
        /// <param name="control">需要处理的控件</param>
        /// <param name="img">控件的背景或图片，如PictureBox.Image
        ///   或PictureBox.BackgroundImage</param>
        public static void ControlTrans(Control control, Image image)
        {
            GraphicsPath graphic = null;
            graphic = subGraphicsPath(image);

            if (graphic == null)
                return;

            control.Region = new Region(graphic);
        }
    }
}
