﻿namespace ChemistryApp.EnumType
{
    /// <summary>
    /// 我的课表的内容的状态
    /// </summary>
    public enum LessonItemState
    {
        Open = 0, //打开状态
        Close     //折叠状态
    }

    public enum MyLessonState
    {
        OnOpen = 0, //打开状态
        OnClose     //关闭状态
    }
    /// <summary>
    /// 我的课件的状态
    /// </summary>
    public enum TeachingSelectState
    {
        OnOpen = 0, //打开状态
        OnClose     //关闭状态
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
