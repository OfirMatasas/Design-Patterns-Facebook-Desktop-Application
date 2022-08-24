using FacebookExceptions;
using FacebookWrapper;
using FacebookWrapper.ObjectModel;
using System;

namespace FacebookWinFormsLogic
{
    public class FacebookAccountManager
    {
        private static object InstanceCreationLock = new object();
        private object ConnectToFacebookAccountLock = new object();

        private static FacebookAccountManager facebookAccountManager;
        private static LoginResult LoginResult { get; set; }

        public User User
        {
            get { return LoginResult.LoggedInUser; }
        }

        public string AccessToken
        {
            get { return LoginResult.AccessToken; }
        }
          

        private FacebookAccountManager() {}

        public static FacebookAccountManager Instance
        {
            get
            {
                if (facebookAccountManager == null)
                {
                    lock (InstanceCreationLock)
                    {
                        if (facebookAccountManager == null)
                        {
                            facebookAccountManager = new FacebookAccountManager();
                        }
                    }
                }

                return facebookAccountManager;
            }
        }

        public static bool LoggedIn
        {
            get
            {
                return LoginResult != null;
            }
        }

        public void Connect(string i_AccessToken)
        {
            bool isExecuted = false;

            if (LoginResult == null)
            {
                lock (ConnectToFacebookAccountLock)
                {
                    if (LoginResult == null)
                    {
                        LoginResult = FacebookService.Connect(i_AccessToken);
                        isExecuted = true;
                    }
                }
            }

            if(!isExecuted)
            {
                throw new UserAlreadyLoggedInException();
            }
        }

        public void Login()
        {
            bool isExecuted = false;

            if (LoginResult == null)
            {
                lock (ConnectToFacebookAccountLock)
                {
                    if (LoginResult == null)
                    {
                        LoginResult = FacebookService.Login(
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
                        isExecuted = !string.IsNullOrEmpty(LoginResult.AccessToken);
                    }
                }
            }

            if(!isExecuted)
            {
                throw new UserAlreadyLoggedInException();
            }
        }

        public void Logout()
        {
            FacebookService.Logout();
            LoginResult = null;
        }

        public Status Post(string i_NewPost)
        {
            if(LoginResult == null)
            {
                throw new InvalidOperationException("User must be logged in to create a new post.");
            }

            return LoginResult.LoggedInUser.PostStatus(i_NewPost);
        }
    }
}
