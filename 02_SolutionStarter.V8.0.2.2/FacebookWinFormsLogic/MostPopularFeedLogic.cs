using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

            if(LoggedInUser.Posts.Count > 0)
            {
                foreach (Post post in LoggedInUser.Posts)
                {
                    if(mostPopularPost == null || (post.Comments.Count > mostPopularPost.Comments.Count))
                    {
                        mostPopularPost = post;
                    }
                }
            }

            return mostPopularPost;
        }
    }
}
