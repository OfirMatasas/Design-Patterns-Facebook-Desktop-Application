using System;
using FacebookWrapper.ObjectModel;

namespace FacebookWinFormsLogic
{
    public class StatisticsLogic
    {
        public User LoggedInUser { get; }

        public StatisticsLogic(User i_LoggedInUser)
        {
            LoggedInUser = i_LoggedInUser;
        }

        private bool CheckIfDatesHasTheSameYearAndMonth(DateTime i_ChosenDate, DateTime i_PostedDate)
        {
            return i_PostedDate.Month == i_ChosenDate.Month && i_PostedDate.Year == i_ChosenDate.Year;
        }

        public void AnalyzeDataOnAlbumsAndPhotosInChosenDate(
            DateTime i_ChosenDate,
            out int o_NumberOfLikesOnPhotosCreatedOnChosenDate,
            out int o_NumberOfAlbumsCreatedOnChosenDate,
            out int o_NumberOfPhotosCreatedOnChosenDate)
        {
            o_NumberOfLikesOnPhotosCreatedOnChosenDate = 0;
            o_NumberOfAlbumsCreatedOnChosenDate = 0;
            o_NumberOfPhotosCreatedOnChosenDate = 0;

            foreach (Album album in LoggedInUser.Albums)
            {
                if (CheckIfDatesHasTheSameYearAndMonth(i_ChosenDate, album.CreatedTime.Value))
                {
                    o_NumberOfAlbumsCreatedOnChosenDate += 1;
                }

                foreach (Photo photo in album.Photos)
                {
                    if (CheckIfDatesHasTheSameYearAndMonth(i_ChosenDate, photo.CreatedTime.Value))
                    {
                        o_NumberOfLikesOnPhotosCreatedOnChosenDate += photo.LikedBy.Count;
                        o_NumberOfPhotosCreatedOnChosenDate += 1;
                    }
                }
            }
        }

        public int GetTheNumberOfPostsCreatedOnChosenDate(DateTime i_ChosenDate)
        {
            int numberOfPostsCreatedOnChosenDate = 0;

            foreach (Post post in LoggedInUser.Posts)
            {
                if (CheckIfDatesHasTheSameYearAndMonth(i_ChosenDate, post.CreatedTime.Value))
                {
                    numberOfPostsCreatedOnChosenDate++;
                }
            }

            return numberOfPostsCreatedOnChosenDate;
        }
    }
}
