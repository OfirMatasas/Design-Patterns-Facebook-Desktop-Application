using System;
using FacebookWrapper.ObjectModel;

namespace FacebookWinFormsLogic
{
    public class MostPopularFeedLogic
    {
        public User LoggedInUser { get; }

        public MostPopularFeedLogic(User i_LoggedInUser)
        {
            LoggedInUser = i_LoggedInUser;
        }

        public Post FindMostPopularPost(DateTime i_ChosenDate)
        {
            Post mostPopularPost = null;

            foreach (Post currentPost in LoggedInUser.Posts)
            {
                if (currentPost.CreatedTime.Value.Year == i_ChosenDate.Year)
                {
                    if (mostPopularPost == null || (currentPost.Comments.Count > mostPopularPost.Comments.Count))
                    {
                        mostPopularPost = currentPost;
                    }
                }
            }

            return mostPopularPost;
        }

        public Photo FindMostPopularPhoto(DateTime i_ChosenDate)
        {
            Photo mostPopularPhoto = null;

            foreach (Album currentAlbum in LoggedInUser.Albums)
            {
                foreach(Photo currentPhoto in currentAlbum.Photos)
                {
                    if (currentPhoto.CreatedTime.Value.Year == i_ChosenDate.Year)
                    {
                        if (mostPopularPhoto == null || (currentPhoto.Comments.Count > mostPopularPhoto.Comments.Count))
                        {
                            mostPopularPhoto = currentPhoto;
                        }
                    }
                }
            }

            return mostPopularPhoto;
        }
    }
}
