using BasicFacebookFeatures.Exceptions;
using FacebookWinFormsApp.Forms;
using FacebookWinFormsLogic;
using System;
using System.Windows.Forms;

namespace BasicFacebookFeatures
{
    public class FacebookFormFactoryMethod
    {
        private static FacebookAccountManager facebookAccountManager;
        private static object setFacebookAccountManagerLock = new object();

        public enum eFormTypes
        {
            Albums,
            Events,
            FavoriteTeams,
            Friends,
            Groups,
            LikedPages,
            MostPopularFeed,
            Posts,
            Profile,
            Statistics
        }

        public static void SetFacebookAccountManager(FacebookAccountManager i_FacebookAccountManager)
        {
            lock (setFacebookAccountManagerLock)
            {
                if (facebookAccountManager != null)
                {
                    throw new Exception("Facebook account manager can be set only once on FormFactoryMethod.");
                }

                facebookAccountManager = i_FacebookAccountManager;
            }
        }

        public static Form CreateForm(eFormTypes i_FormType)
        {
            Form requestedForm;

            makeSureTheUserIsLoggedIn();
            requestedForm = createTheFormRequested(i_FormType);

            return requestedForm;
        }

        private static void makeSureTheUserIsLoggedIn()
        {
            if (facebookAccountManager == null)
            {
                throw new InvalidOperationException("Forms can be created only after logging into a Facebook account.");
            }
        }

        private static Form createTheFormRequested(eFormTypes i_FormType)
        {
            Form requestedForm;

            switch (i_FormType)
            {
                case eFormTypes.Profile:
                    requestedForm = new FormProfile(facebookAccountManager.LoginResult.LoggedInUser);
                    break;
                case eFormTypes.Albums:
                    requestedForm = new FormAlbums(facebookAccountManager.LoginResult.LoggedInUser.Albums);
                    break;
                case eFormTypes.Events:
                    requestedForm = new FormEvents(facebookAccountManager.LoginResult.LoggedInUser.Events);
                    break;
                case eFormTypes.Posts:
                    requestedForm = new FormPosts(facebookAccountManager);
                    break;
                case eFormTypes.LikedPages:
                    requestedForm = new FormLikedPages(facebookAccountManager.LoginResult.LoggedInUser.LikedPages);
                    break;
                case eFormTypes.FavoriteTeams:
                    requestedForm = new FormFavoriteTeams(facebookAccountManager.LoginResult.LoggedInUser.FavofriteTeams);
                    break;
                case eFormTypes.Friends:
                    requestedForm = new FormFriends(facebookAccountManager.LoginResult.LoggedInUser.Friends);
                    break;
                case eFormTypes.Groups:
                    requestedForm = new FormGroups(facebookAccountManager.LoginResult.LoggedInUser.Groups);
                    break;
                case eFormTypes.Statistics:
                    requestedForm = new FormStatistics(facebookAccountManager.LoginResult.LoggedInUser);
                    break;
                case eFormTypes.MostPopularFeed:
                    requestedForm = new FormMostPopularFeed(facebookAccountManager.LoginResult.LoggedInUser);
                    break;
                default:
                    throw new NotSupportedFormTypeException("This form type is not manufactored in this factory.");
            }

            return requestedForm;
        }
    }
}
