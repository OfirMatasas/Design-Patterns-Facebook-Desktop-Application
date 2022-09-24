using System;
using FacebookWinFormsLogic.DateComparatiorStrategies;

namespace FacebookWinFormsLogic.MostPopularLogic
{
    public abstract class MostPopularItem
    {
        public abstract object FindMostPopularItem(DateTime i_ChosenDate, ICompareDateStrategy i_CompareDateStrategy);
    }
}
