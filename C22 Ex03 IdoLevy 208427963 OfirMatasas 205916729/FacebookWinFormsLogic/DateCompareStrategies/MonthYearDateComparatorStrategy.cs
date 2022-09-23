using System;

namespace FacebookWinFormsLogic.DateComparatiorStrategies
{
    public class MonthYearCompareStrategy : ICompareDateStrategy
    {
        public bool Compare(DateTime i_FirstDate, DateTime i_SecondDate)
        {
            return i_FirstDate.Year.Equals(i_SecondDate.Year) && i_FirstDate.Month.Equals(i_SecondDate.Month);
        }
    }
}
