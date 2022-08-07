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

        private bool IsSameDate(DateTime i_CurrentDate, DateTime i_PostedDate)
        {
            return i_PostedDate.Month == i_CurrentDate.Month && i_PostedDate.Year == i_CurrentDate.Year;
        }

        public void AnalyzeDataOnAlbumsAndPhotosInChosenDate(
            DateTime i_Date,
            out int o_NumberOfLikesOnPhotos,
            out int o_NumberOfNewAlbums,
            out int o_NumberOfNewPhotos)
        {
            o_NumberOfLikesOnPhotos = 0;
            o_NumberOfNewAlbums = 0;
            o_NumberOfNewPhotos = 0;

            foreach (Album album in LoggedInUser.Albums)
            {
                if (IsSameDate(i_Date, album.CreatedTime.Value))
                {
                    o_NumberOfNewAlbums += 1;
                }

                foreach (Photo photo in album.Photos)
                {
                    if (IsSameDate(i_Date, photo.CreatedTime.Value))
                    {
                        o_NumberOfLikesOnPhotos += photo.LikedBy.Count;
                        o_NumberOfNewPhotos += 1;
                    }
                }
            }
        }

        public int CalculateNumberOfPostsInChosenDate(DateTime i_Date)
        {
            int numberOfPosts = 0;

            foreach (Post post in LoggedInUser.Posts)
            {
                if (IsSameDate(i_Date, post.CreatedTime.Value))
                {
                    numberOfPosts++;
                }
            }

            return numberOfPosts;
        }
    }
}
