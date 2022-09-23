using System;

namespace FacebookWinFormsLogic.DateComparatiorStrategies
{
    public interface ICompareDateStrategy
    {
        bool Compare(DateTime i_FirstDate, DateTime i_SecondDate);
    }
}
