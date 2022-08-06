using FacebookWrapper.ObjectModel;
using System;

namespace FacebookWinFormsLogic
{
    public class MostPopularFeedLogic
    {
        public User LoggedInUser { get; }
        public MostPopularFeedLogic(User i_LoggedInUser)
        {
            LoggedInUser = i_LoggedInUser;
        }

        public Post FindMostPopularPost(DateTime i_Date)
        {
            Post mostPopularPost = null;

            foreach (Post post in LoggedInUser.Posts)
            {
                if (post.CreatedTime.Value.Year == i_Date.Year)
                {
                    if ((mostPopularPost != null && post.Comments.Count > mostPopularPost.Comments.Count)
                        || mostPopularPost == null)
                    {
                        mostPopularPost = post;
                    }
                }
            }

            return mostPopularPost;
        }

        public Photo FindMostPopularPhoto(DateTime i_Date)
        {
            Photo mostPopularPhoto = null;

            foreach (Album album in LoggedInUser.Albums)
            {
                foreach(Photo photo in album.Photos)
                {
                    if (photo.CreatedTime.Value.Year == i_Date.Year)
                    {
                        if ((mostPopularPhoto != null && photo.Comments.Count > mostPopularPhoto.Comments.Count)
                            || mostPopularPhoto == null)
                        {
                            mostPopularPhoto = photo;
                        }
                    }
                }
            }

            return mostPopularPhoto;
        }
    }
}
