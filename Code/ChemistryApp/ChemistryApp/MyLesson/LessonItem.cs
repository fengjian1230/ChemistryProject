using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Office.Interop.Excel;

namespace ChemistryApp
{
    class LessonItem
    {
        #region 字段
        /// <summary> 
        /// 课程抬头
        /// </summary>
        private string _lessonTitle;
        /// <summary>
        /// 课程名字
        /// </summary>
        private string _lesson;
        /// <summary>
        /// 课程章节
        /// </summary>
        private string _lessonId;
        /// <summary>
        /// 课程内容
        /// </summary>
        private string _lessonContent;
        #endregion


        #region 属性
        /// <summary>
        /// 
        /// </summary>
        public string LessonTitle
        {
            get { return _lessonTitle; }
            set { _lessonTitle = value; }
        }

        /// <summary>
        /// 
        /// </summary>
        public string Lesson
        {
            get { return _lesson; }
            set { _lesson = value; }
        }

        /// <summary>
        /// 课程ID
        /// </summary>
        public string LessonID
        {
            get { return _lessonId; }
            set { _lessonId = value; }
        }

        /// <summary>
        /// 课程内容
        /// </summary>
        public string LessonContent
        {
            get { return _lessonContent; }
            set { _lessonContent = value; }
        }

        #endregion
    }
}
