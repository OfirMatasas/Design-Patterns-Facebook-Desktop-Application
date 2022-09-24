using System;
using System.Collections;
using System.Collections.Generic;
using FacebookWinFormsLogic.DateComparatiorStrategies;
using FacebookWrapper.ObjectModel;

namespace FacebookWinFormsLogic
{
    public class MostPopularFeedLogic : IEnumerable<Post>
    {
        //---------------------------------------------- Members ----------------------------------------------//
        private readonly FacebookObjectCollection<Post> r_Posts;
        private readonly FacebookObjectCollection<Album> r_Albums;

        public DateTime ChosenDate { get; set; }

        public ICompareDateStrategy CompareDateStrategy { get; set; }

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
                    if (CompareDateStrategy.Compare(photo.CreatedTime.Value, ChosenDate))
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
                if (CompareDateStrategy.Compare(post.CreatedTime.Value, ChosenDate))
                {
                    yield return post;
                }
            }
        }
    }
}
