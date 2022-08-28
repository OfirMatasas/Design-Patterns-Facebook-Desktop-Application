using FacebookExceptions;
using FacebookWrapper;
using FacebookWrapper.ObjectModel;
using System;
using System.Drawing;
using static FacebookWrapper.ObjectModel.User;

namespace FacebookWinFormsLogic
{
    public class FacebookAccountManager
    {
        private static object s_InstanceCreationLock = new object();
        private object m_ConnectToFacebookAccountLock = new object();
        private object m_PostsLock = new object();
        private object m_AlbumsLock = new object();
        private object m_FavoriteTeamsLock = new object();
        private object m_LikedPagesLock = new object();
        private object m_FriendsLock = new object();
        private object m_GroupsLock = new object();
        private object m_EventsLock = new object();

        private static FacebookAccountManager AccountManager { get; set; }
        public string AccessToken { get; private set; }
        private User LoggedInUser { get; set; }

        private FacebookObjectCollection<Event> m_Events;
        private FacebookObjectCollection<Group> m_Groups;
        private Page[] m_FavoriteTeams;
        private FacebookObjectCollection<Album> m_Albums;
        private FacebookObjectCollection<Post> m_Posts;
        private FacebookObjectCollection<Page> m_LikedPages;
        private FacebookObjectCollection<User> m_Friends;

        public FacebookObjectCollection<Event> Events
        {
            get
            {
                return GetObjectFromCacheOrGetFromWebServiceForTheFirstTime(ref m_Events, ref m_EventsLock, () => m_Events = LoggedInUser.Events);
            }
        }

        public FacebookObjectCollection<Group> Groups
        {
            get
            {
                return GetObjectFromCacheOrGetFromWebServiceForTheFirstTime(ref m_Groups, ref m_GroupsLock, () => m_Groups = LoggedInUser.Groups);
            }
        }

        public Page[] FavoriteTeams
        {
            get
            {
                return GetObjectFromCacheOrGetFromWebServiceForTheFirstTime(ref m_FavoriteTeams, ref m_FavoriteTeamsLock, () => m_FavoriteTeams = LoggedInUser.FavofriteTeams);
            }
        }

        public FacebookObjectCollection<Album> Albums
        {
            get
            {
                return GetObjectFromCacheOrGetFromWebServiceForTheFirstTime(ref m_Albums, ref m_AlbumsLock, () => m_Albums = LoggedInUser.Albums);
            }
        }

        public FacebookObjectCollection<Page> LikedPages
        {
            get
            {
                return GetObjectFromCacheOrGetFromWebServiceForTheFirstTime(ref m_LikedPages, ref m_LikedPagesLock, () => m_LikedPages = LoggedInUser.LikedPages);
            }
        }

        public FacebookObjectCollection<Post> Posts
        {
            get
            {
                return GetObjectFromCacheOrGetFromWebServiceForTheFirstTime(ref m_Posts, ref m_PostsLock, () => m_Posts = LoggedInUser.Posts);
            }
        }

        public FacebookObjectCollection<User> Friends
        {
            get
            {
                return GetObjectFromCacheOrGetFromWebServiceForTheFirstTime(ref m_Friends, ref m_FriendsLock, () => m_Friends = LoggedInUser.Friends);
            }
        }

        private T GetObjectFromCacheOrGetFromWebServiceForTheFirstTime<T>(ref T io_DesiredObject, ref object i_DesiredObjectLock, Func<T> i_GetTheDesiredObjectFromWebService)
        {
            if (io_DesiredObject == null)
            {
                lock (i_DesiredObjectLock)
                {
                    if (io_DesiredObject == null)
                    {
                        io_DesiredObject = i_GetTheDesiredObjectFromWebService.Invoke();
                    }
                }
            }

            return io_DesiredObject;
        }

        public Image ProfilePicture
        {
            get
            {
                return LoggedInUser.ImageNormal;
            }
        }

        public string Name
        {
            get
            {
                return LoggedInUser.Name;
            }
        }

        public string Birthday
        {
            get
            {
                return LoggedInUser.Birthday;
            }
        }

        private FacebookAccountManager() {}

        public static FacebookAccountManager Instance
        {
            get
            {
                if (AccountManager == null)
                {
                    lock (s_InstanceCreationLock)
                    {
                        if (AccountManager == null)
                        {
                            AccountManager = new FacebookAccountManager();
                        }
                    }
                }

                return AccountManager;
            }
        }

        public static bool LoggedIn
        {
            get
            {
                return AccountManager != null;
            }
        }

        public eGender? Gender
        {
            get
            {
                return LoggedInUser.Gender;
            }
        }

        public City Hometown
        {
            get
            {
                return LoggedInUser.Hometown;
            }
        }

        public City Location 
        { 
            get
            {
                return LoggedInUser.Location;
            }

        }

        public FacebookObjectCollection<Post> WallPosts 
        {
            get
            {
                return LoggedInUser.WallPosts;
            }
        }

        public void Connect(string i_AccessToken)
        {
            LoginResult loginResult;
            bool isExecuted = false;

            if (LoggedInUser == null)
            {
                lock (m_ConnectToFacebookAccountLock)
                {
                    if (LoggedInUser == null)
                    {
                        loginResult = FacebookService.Connect(i_AccessToken);
                        isExecuted = true;
                        checkIfLoginWasSuccessful(loginResult);
                    }
                }
            }

            if(!isExecuted)
            {
                throw new UserAlreadyLoggedInException();
            }
        }

        private void checkIfLoginWasSuccessful(LoginResult loginResult)
        {
            if (loginResult.AccessToken != null)
            {
                LoggedInUser = loginResult.LoggedInUser;
                AccessToken = loginResult.AccessToken;
            }
            else
            {
                throw new LoginFailureException();
            }
        }

        public void Login()
        {
            LoginResult loginResult;
            bool isExecuted = false;

            if (LoggedInUser == null)
            {
                lock (m_ConnectToFacebookAccountLock)
                {
                    if (LoggedInUser == null)
                    {
                        loginResult = FacebookService.Login(
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
                        checkIfLoginWasSuccessful(loginResult);
                        isExecuted = !string.IsNullOrEmpty(loginResult.AccessToken);
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
            AccessToken = null;
            LoggedInUser = null;
        }

        public Status Post(string i_NewPost)
        {
            Status postedStatus;

            if (LoggedInUser == null)
            {
                throw new InvalidOperationException("User must be logged in to create a new post.");
            }

            try
            {
                postedStatus = LoggedInUser.PostStatus(i_NewPost);
            }
            catch
            {
                postedStatus = null;
            }

            return postedStatus;
        }
    }
}
