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

        private bool CheckIfDatesHasTheSameYearAndMonth(DateTime i_CurrentDate, DateTime i_PostedDate)
        {
            return i_PostedDate.Month == i_CurrentDate.Month && i_PostedDate.Year == i_CurrentDate.Year;
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

            foreach (Album currentAlbum in LoggedInUser.Albums)
            {
                if (CheckIfDatesHasTheSameYearAndMonth(i_ChosenDate, currentAlbum.CreatedTime.Value))
                {
                    o_NumberOfAlbumsCreatedOnChosenDate += 1;
                }

                foreach (Photo currentPhoto in currentAlbum.Photos)
                {
                    if (CheckIfDatesHasTheSameYearAndMonth(i_ChosenDate, currentPhoto.CreatedTime.Value))
                    {
                        o_NumberOfLikesOnPhotosCreatedOnChosenDate += currentPhoto.LikedBy.Count;
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
