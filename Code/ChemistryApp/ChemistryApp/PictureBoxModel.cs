using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
/// <summary>
/// 实现绘制图像
/// </summary>
public class PictureBoxModel : PanelExtend
{
    public PictureBoxModel()
    {
        //this.SetStyle(System.Windows.Forms.ControlStyles.SupportsTransparentBackColor, true);
    }
    protected override void OnDraw()
    {
        // 获取图像
        Image imageModel = global::ChemistryApp.Properties.Resources.bendiziyuan_norml_;
        Image imageHair = global::ChemistryApp.Properties.Resources.btnAgain_norml;
        //int width = imageModel.Size.Width;
        //int height = imageModel.Size.Height;
        int width = this.Width;
        int height = this.Height;
        Rectangle recModel = new Rectangle(0, 0, width, height);
        Rectangle recHair = new Rectangle(0, 0, imageHair.Width, imageHair.Height);

        this.graphics.DrawImage(imageModel, recModel);
        this.graphics.DrawImage(imageHair, recHair);
    }
}