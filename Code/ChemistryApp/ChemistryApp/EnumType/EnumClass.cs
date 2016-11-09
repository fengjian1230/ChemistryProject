using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChemistryApp.EnumType
{
    /// <summary>
    /// 我的课表的状态
    /// </summary>
    public enum LessonState
    {
        Open = 0, //打开状态
        Close     //折叠状态
    }

    /// <summary>
    /// 我的课件的状态
    /// </summary>
    public enum TeachingSelectState
    {
        OnSelect = 0, //打开状态
        Close     //折叠状态
    }

    /// <summary>
    /// 我的课件类型
    /// </summary>
    public enum TeachingItemType
    {
        PPT = 0,  //PPT
        Video,    //视频
        MandMap,  //思维导图
        Example,  //习题
        Test,     //实验
        RreactionEquation //反应方程
    }

    /// <summary>
    /// 我的课表编辑按钮
    /// </summary>
    public enum BianJiState
    {
        Bianji = 0, //编辑状态
        Wancheng    //完成状态
    }
}
