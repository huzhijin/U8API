using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helper.Time
{
    public class TimeHelper
    {
        public static TimeSpan GetDateTimeSpan(DateTime dtStart, DateTime dtEnd, TimeSpan time_start, TimeSpan time_end, TimeSpan time_start2, TimeSpan time_end2)
        {
            if (dtStart.Date == dtEnd.Date) //如果是同一天
            {
                if (IsWorkDay(dtStart))
                    return GetTimeSpan(dtStart.TimeOfDay, dtEnd.TimeOfDay, time_start, time_end, time_start2, time_end2);
                else
                    return new TimeSpan(0);
            }
            //如果不是同一天 计算天数减去1 乘以标准时长 加上分别计算开始开数和结束天数
            double days = dtEnd.Date.Subtract(dtStart.Date).TotalDays - 1;

            TimeSpan startTimeSpan;
            if (IsWorkDay(dtStart))
                startTimeSpan = GetTimeSpan(dtStart.TimeOfDay, new TimeSpan(23, 59, 60), time_start, time_end, time_start2, time_end2);//开始天
            else
                startTimeSpan = new TimeSpan(0);

            TimeSpan endTimeSpan;
            if (IsWorkDay(dtEnd))
                endTimeSpan = GetTimeSpan(new TimeSpan(0, 0, 0), dtEnd.TimeOfDay, time_start, time_end, time_start2, time_end2);//结束天
            else
                endTimeSpan = new TimeSpan(0);

            TimeSpan totalTimeSpan = startTimeSpan + endTimeSpan; //总值

            TimeSpan preTimeSpan = GetTimeSpan(new TimeSpan(0, 0, 0), new TimeSpan(23, 59, 60), time_start, time_end, time_start2, time_end2);//开始天
            for (int i = 1; i <= days; i++)
            {
                if (IsWorkDay(dtStart.AddDays(i)))
                    totalTimeSpan += preTimeSpan; //添加间隔天
            }

            return totalTimeSpan;
        }

        /// <summary>
        /// 判断是否为工作日
        /// </summary>
        /// <param name="dt"></param>
        /// <returns></returns>
        public static bool IsWorkDay(DateTime dt)
        {
            //先从日期表中，查找不是上班时间，如果不是直接返回 false ，如果是，直接返回 true。
            //如果在日期表中，找不到，则查找定义的日历，依据日历定义的周末时间来定义是否为工作日。
            //获取日历中不上班的标准周末时间,判断是不是上班时间
            if (dt.DayOfWeek == DayOfWeek.Sunday || dt.DayOfWeek == DayOfWeek.Saturday)
                return false;
            else
                return true;
        }

        //同一天获取
        public static TimeSpan GetTimeSpan(TimeSpan tsStart, TimeSpan tsEnd, TimeSpan time_start, TimeSpan time_end, TimeSpan time_start2, TimeSpan time_end2)
        {

            //判断 开始时间
            if (tsStart < time_start)
            {
                //标准开始时间不变
                //start1 不变
                //start2 不变
            }
            else if (tsStart >= time_start && tsStart <= time_end)
            {
                //标准开始= dtStart
                time_start = tsStart;
                //start1 变
                //start2 不变
            }
            else if (tsStart > time_end && tsStart < time_start2)
            {
                time_start = time_end;
                //start1 变
                //start2 不变
            }
            else if (tsStart >= time_start2 && tsStart <= time_end2)
            {
                time_start = time_end;
                time_start2 = tsStart;
                //start1 变
                //start2 变
            }
            else if (tsStart > time_end2)
            {
                time_start = time_end;
                time_start2 = time_end2;
                //start1 变
                //start2 变
            }

            //判断 结束时间
            if (tsEnd < time_start)
            {
                //标准开始时间不变
                time_end = time_start;
                time_end2 = time_start2;
                //time_end 变
                //time_end2变
            }
            else if (tsEnd >= time_start && tsEnd <= time_end)
            {
                time_end = tsEnd;
                time_end2 = time_start2;
                //time_end 变
                //time_end2变
            }
            else if (tsEnd > time_end && tsEnd < time_start2)
            {
                time_end2 = time_start2;
                //time_end2 不变
                //time_end1变
            }
            else if (tsEnd >= time_start2 && tsEnd <= time_end2)
            {
                time_end2 = tsEnd;
                //time_end 不变
                //time_end2变
            }
            else if (tsEnd > time_end2)
            {
                //time_end 不变
                //time_end2不变
            }

            return (time_end - time_start) + (time_end2 - time_start2);
        }
    }
}
