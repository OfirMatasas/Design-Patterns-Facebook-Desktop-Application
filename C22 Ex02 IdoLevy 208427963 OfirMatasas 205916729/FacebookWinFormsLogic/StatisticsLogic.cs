using System;
using FacebookWrapper.ObjectModel;

namespace FacebookWinFormsLogic
{
    public class StatisticsLogic
    {
        private readonly FacebookObjectCollection<Album> r_Albums;
        private readonly FacebookObjectCollection<Post> r_Posts;

        public StatisticsLogic()
        {
            r_Albums = FacebookAccountManager.Instance.Albums;
            r_Posts = FacebookAccountManager.Instance.Posts;
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

            foreach (Album album in r_Albums)
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

            foreach (Post post in r_Posts)
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
