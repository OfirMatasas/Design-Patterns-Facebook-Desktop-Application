using System;
using System.Collections;
using System.Collections.Generic;
using FacebookWrapper.ObjectModel;

namespace FacebookWinFormsLogic
{
    public class MostPopularFeedLogic : IEnumerable<Post>
    {
        //---------------------------------------------- Members ----------------------------------------------//
        private readonly FacebookObjectCollection<Post> r_Posts;
        private readonly FacebookObjectCollection<Album> r_Albums;
        public DateTime ChosenDate { get; set; }

        //-------------------------------------------- Constructor --------------------------------------------//
        public MostPopularFeedLogic()
        {
            r_Albums = FacebookAccountManager.Instance.Albums;
            r_Posts = FacebookAccountManager.Instance.Posts;
        }

        //---------------------------------------------- Methods ----------------------------------------------//
        public Photo FindMostPopularPhoto()
        {
            Photo mostPopularPhoto = null;

            foreach (Album album in r_Albums)
            {
                foreach (Photo photo in album.Photos)
                {
                    if (photo.CreatedTime.Value.Year == ChosenDate.Year)
                    {
                        if (mostPopularPhoto == null || (photo.Comments.Count > mostPopularPhoto.Comments.Count))
                        {
                            mostPopularPhoto = photo;
                        }
                    }
                }
            }

            return mostPopularPhoto;
        }

        public IEnumerator GetEnumerator()
        {
            return r_Posts.GetEnumerator();
        }

        IEnumerator<Post> IEnumerable<Post>.GetEnumerator()
        {
            foreach (Post post in r_Posts)
            {
                if (post.CreatedTime.Value.Year == ChosenDate.Year)
                {
                    yield return post;
                }
            }
        }
    }
}
