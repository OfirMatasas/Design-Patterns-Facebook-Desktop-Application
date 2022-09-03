using System;
using System.Drawing;
using FacebookExceptions;
using FacebookWrapper;
using FacebookWrapper.ObjectModel;
using static FacebookWrapper.ObjectModel.User;

namespace FacebookWinFormsLogic
{
    public class FacebookAccountManager
    {
        //----------------------------------------------- Locks -----------------------------------------------//
        private static object s_InstanceCreationLock = new object();
        private object m_ConnectToFacebookAccountLock = new object();
        private object m_PostsLock = new object();
        private object m_AlbumsLock = new object();
        private object m_FavoriteTeamsLock = new object();
        private object m_LikedPagesLock = new object();
        private object m_FriendsLock = new object();
        private object m_GroupsLock = new object();
        private object m_EventsLock = new object();

        //----------------------------------------- Original Properties ---------------------------------------//
        private static FacebookAccountManager AccountManager { get; set; }
        public string AccessToken { get; private set; }
        private User LoggedInUser { get; set; }

        public Image ProfilePicture
        {
            get { return LoggedInUser.ImageLarge; }
        }

        public string Name
        {
            get { return LoggedInUser.Name; }
        }

        public string Birthday
        {
            get { return LoggedInUser.Birthday; }
        }

        public static bool LoggedIn
        {
            get { return AccountManager != null; }
        }

        public eGender? Gender
        {
            get { return LoggedInUser.Gender; }
        }

        public City Hometown
        {
            get { return LoggedInUser.Hometown; }
        }

        public City Location
        {
            get { return LoggedInUser.Location; }
        }

        public FacebookObjectCollection<Post> WallPosts
        {
            get { return LoggedInUser.WallPosts; }
        }

        public string About
        {
            get { return LoggedInUser.About; }
        }

        public Education[] Education
        {
            get { return LoggedInUser.Educations; }
        }

        public FacebookObjectCollection<Event> EventsCreated
        {
            get { return LoggedInUser.EventsCreated; }
        }

        public FacebookObjectCollection<Event> EventsDeclined
        {
            get { return LoggedInUser.EventsDeclined; }
        }

        public FacebookObjectCollection<Event> EventsMaybe
        {
            get { return LoggedInUser.EventsMaybe; }
        }

        public FacebookObjectCollection<Event> EventsNotYetReplied
        {
            get { return LoggedInUser.EventsNotYetReplied; }
        }

        public string Quotes
        {
            get { return LoggedInUser.Quotes; }
        }

        public FacebookObjectCollection<Checkin> Checkins
        {
            get { return LoggedInUser.Checkins; }
        }

        public Cover Cover
        {
            get { return LoggedInUser.Cover; }
        }

        public string Email
        {
            get { return LoggedInUser.Email; }
        }

        public Page[] Languages
        {
            get { return LoggedInUser.Languages; }
        }

        public string Locale
        {
            get { return LoggedInUser.Locale; }
        }

        public double? TimeZone
        {
            get { return LoggedInUser.TimeZone; }
        }

        public FacebookObjectCollection<FriendList> FriendLists
        {
            get { return LoggedInUser.FriendLists; }
        }

        public string Id
        {
            get { return LoggedInUser.Id; }
        }

        public eGender[] InterestedIn
        {
            get { return LoggedInUser.InterestedIn; }
        }

        public string Link
        {
            get { return LoggedInUser.Link; }
        }

        public string MiddleName
        {
            get { return LoggedInUser.MiddleName; }
        }

        public FacebookObjectCollection<Post> NewsFeed
        {
            get { return LoggedInUser.NewsFeed; }
        }

        public eOnlineStatus? OnlineStatus
        {
            get { return LoggedInUser.OnlineStatus; }
        }

        public eRelationshipStatus? RelationshipStatus
        {
            get { return LoggedInUser.RelationshipStatus; }
        }

        public FacebookObjectCollection<Status> Statuses
        {
            get { return LoggedInUser.Statuses; }
        }

        public FacebookObjectCollection<Photo> PhotosTaggedIn
        {
            get { return LoggedInUser.PhotosTaggedIn; }
        }

        public FacebookObjectCollection<Poke> Pokes
        {
            get { return LoggedInUser.Pokes; }
        }

        public FacebookObjectCollection<Link> PostedLinks
        {
            get { return LoggedInUser.PostedLinks; }
        }

        public FacebookObjectCollection<User> Subscribers
        {
            get { return LoggedInUser.Subscribers; }
        }

        public FacebookObjectCollection<User> SubscribedTo
        {
            get { return LoggedInUser.SubscribedTo; }
        }

        public PicturesColleciton Pictures
        {
            get { return LoggedInUser.Pictures; }
        }

        public FacebookObjectCollection<Message> MessageUpdates
        {
            get { return LoggedInUser.MessageUpdates; }
        }

        public string Religion
        {
            get { return LoggedInUser.Religion; }
        }

        public User SignificantOther
        {
            get { return LoggedInUser.SignificantOther; }
        }

        public string UserName
        {
            get { return LoggedInUser.UserName; }
        }

        public bool? Verfied
        {
            get { return LoggedInUser.Verfied; }
        }

        public FacebookObjectCollection<Video> Videos
        {
            get { return LoggedInUser.Videos; }
        }

        public WorkExperience[] WorkExperiences
        {
            get { return LoggedInUser.WorkExperiences; }
        }

        //------------------------------------------ Cached Properties ----------------------------------------//
        private FacebookObjectCollection<Event> m_Events;
        private FacebookObjectCollection<Group> m_Groups;
        private Page[] m_FavoriteTeams;
        private FacebookObjectCollection<Album> m_Albums;
        private FacebookObjectCollection<Post> m_Posts;
        private FacebookObjectCollection<Page> m_LikedPages;
        private FacebookObjectCollection<User> m_Friends;

        public FacebookObjectCollection<Event> Events
        {
            get { return getObjectFromCacheOrGetFromWebServiceForTheFirstTime(ref m_Events, ref m_EventsLock, () => m_Events = LoggedInUser.Events); }
        }

        public FacebookObjectCollection<Group> Groups
        {
            get { return getObjectFromCacheOrGetFromWebServiceForTheFirstTime(ref m_Groups, ref m_GroupsLock, () => m_Groups = LoggedInUser.Groups); }
        }

        public Page[] FavoriteTeams
        {
            get { return getObjectFromCacheOrGetFromWebServiceForTheFirstTime(ref m_FavoriteTeams, ref m_FavoriteTeamsLock, () => m_FavoriteTeams = LoggedInUser.FavofriteTeams); }
        }

        public FacebookObjectCollection<Album> Albums
        {
            get { return getObjectFromCacheOrGetFromWebServiceForTheFirstTime(ref m_Albums, ref m_AlbumsLock, () => m_Albums = LoggedInUser.Albums); }
        }

        public FacebookObjectCollection<Page> LikedPages
        {
            get { return getObjectFromCacheOrGetFromWebServiceForTheFirstTime(ref m_LikedPages, ref m_LikedPagesLock, () => m_LikedPages = LoggedInUser.LikedPages); }
        }

        public FacebookObjectCollection<Post> Posts
        {
            get { return getObjectFromCacheOrGetFromWebServiceForTheFirstTime(ref m_Posts, ref m_PostsLock, () => m_Posts = LoggedInUser.Posts); }
        }

        public FacebookObjectCollection<User> Friends
        {
            get { return getObjectFromCacheOrGetFromWebServiceForTheFirstTime(ref m_Friends, ref m_FriendsLock, () => m_Friends = LoggedInUser.Friends); }
        }

        private T getObjectFromCacheOrGetFromWebServiceForTheFirstTime<T>(ref T io_DesiredObject, ref object i_DesiredObjectLock, Func<T> i_GetTheDesiredObjectFromWebService)
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

        //-------------------------------------------- Constructor --------------------------------------------//
        private FacebookAccountManager()
        {
        }

        //---------------------------------------------- Instance ---------------------------------------------//
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

        //----------------------------------------------- Login -----------------------------------------------//
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

            if (!isExecuted)
            {
                throw new UserAlreadyLoggedInException();
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

            if (!isExecuted)
            {
                throw new UserAlreadyLoggedInException();
            }
        }

        //---------------------------------------------- Methods ----------------------------------------------//
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

        public void Checkin(Checkin i_Checkin)
        {
            LoggedInUser.Checkin(i_Checkin);
        }

        public FriendList CreateFriendList(string i_FriendList)
        {
            return LoggedInUser.CreateFriendList(i_FriendList);
        }

        public void PostPhoto(string i_PictureFilePath, string i_Title = null, string i_Caption = null, string i_PrivacyParameterValue = null)
        {
            LoggedInUser.PostPhoto(i_PictureFilePath, i_Title, i_Caption, i_PrivacyParameterValue);
        }

        public void PostLink(string i_Url, string i_Message = null, string i_PrivacyParameterValue = null)
        {
            LoggedInUser.PostLink(i_Url, i_Message, i_PrivacyParameterValue);
        }

        public void CreateEvent_DeprecatedSinceV2(string i_Name, DateTime i_StartTime, DateTime? i_EndTime = null, string i_Description = null, string i_Location = null, Event.ePrivacy? i_PrivacyType = null, string i_PlaceID = null)
        {
            LoggedInUser.CreateEvent_DeprecatedSinceV2(i_Name, i_StartTime, i_EndTime, i_Description, i_Location, i_PrivacyType, i_PlaceID);
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

        //---------------------------------------------- Logout -----------------------------------------------//
        public void Logout()
        {
            FacebookService.Logout();
            AccessToken = null;
            LoggedInUser = null;
        }
    }
}
