using System;
using FacebookWinFormsLogic.DateComparatiorStrategies;
using FacebookWrapper.ObjectModel;

namespace FacebookWinFormsLogic.MostPopularLogic
{
    public class MostPopularPost : MostPopularItem
    {
        private readonly FacebookObjectCollection<Post> r_Posts;

        public MostPopularPost()
        {
            r_Posts = FacebookAccountManager.Instance.Posts;
        }

        public override object FindMostPopularItem(DateTime i_ChosenDate, ICompareDateStrategy i_CompareDateStrategy)
        {
            Post mostPopularPost = null;

            foreach (Post post in r_Posts)
            {
                if (i_CompareDateStrategy.Compare(post.CreatedTime.Value, i_ChosenDate))
                {
                    if (mostPopularPost == null || (post.Comments.Count > mostPopularPost.Comments.Count))
                    {
                        mostPopularPost = post;
                    }
                }
            }

            return mostPopularPost;
        }
    }
}
