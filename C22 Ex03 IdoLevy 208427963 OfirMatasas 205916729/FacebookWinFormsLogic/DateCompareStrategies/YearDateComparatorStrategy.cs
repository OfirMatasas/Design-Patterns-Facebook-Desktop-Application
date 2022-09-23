using System;

namespace FacebookWinFormsLogic.DateComparatiorStrategies
{
    public class YearCompareStrategy : ICompareDateStrategy
    {
        public bool Compare(DateTime i_FirstDate, DateTime i_SecondDate)
        {
            return i_SecondDate.Year.Equals(i_FirstDate.Year);
        }
    }
}
