using FacebookWrapper;
using FacebookWrapper.ObjectModel;

namespace FacebookWinFormsLogic
{
    public class FacebookAccountManager
    {
        public User LoggedInUser { get; private set; }

        public bool Login()
        {
            LoginResult loginResult = FacebookService.Login(
                "473768324575372",
                "email",
                "public_profile",
                "user_age_range",
                "user_birthday",
                "user_events",
                "user_friends",
                "user_gender",
                "user_hometown",
                "user_likes",
                "user_link",
                "user_location",
                "user_photos",
                "user_posts",
                "user_videos",
                "groups_access_member_info",
                "publish_to_groups",
                "pages_manage_posts");

            LoggedInUser = string.IsNullOrEmpty(loginResult.AccessToken) ? null : loginResult.LoggedInUser;

            return LoggedInUser != null;
        }

        public void Logout()
        {
            FacebookService.Logout();
        }

        public Status Post(string i_NewPost)
        {
            return LoggedInUser.PostStatus(i_NewPost);
        }
    }
}
