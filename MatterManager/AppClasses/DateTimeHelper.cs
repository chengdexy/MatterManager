using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTimeHelpers
{
    static class DateTimeHelper
    {
        /// <summary>
        /// 给定一个开始时间和检查间隔,返回今天是否需要提醒
        /// </summary>
        /// <param name="beginDate">开始日期</param>
        /// <param name="remind">检查间隔</param>
        /// <returns></returns>
        public static bool isNeedAlert(DateTime beginDate, int remind)
        {
            DateTime curDate = DateTime.Today;
            double pastDays = (curDate - beginDate).TotalDays;
            if (pastDays % remind <= 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
