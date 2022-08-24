using FacebookExceptions;
using FacebookWinFormsApp.Forms;
using FacebookWinFormsLogic;
using System;
using System.Windows.Forms;

namespace BasicFacebookFeatures
{
    public class FacebookFormFactory
    {
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

        public static Form CreateForm(eFormTypes i_FormType)
        {
            Form requestedForm;

            makeSureTheUserIsLoggedIn();
            requestedForm = createTheFormRequested(i_FormType);

            return requestedForm;
        }

        private static void makeSureTheUserIsLoggedIn()
        {
            if (!FacebookAccountManager.LoggedIn)
            {
                throw new InvalidOperationException("Forms can be created only after logging into a Facebook account.");
            }
        }

        private static Form createTheFormRequested(eFormTypes i_FormType)
        {
            FacebookAccountManager accountManager = FacebookAccountManager.Instance;
            Form requestedForm;

            switch (i_FormType)
            {
                case eFormTypes.Profile:
                    requestedForm = new FormProfile(accountManager.User);
                    break;
                case eFormTypes.Albums:
                    requestedForm = new FormAlbums(accountManager.User.Albums);
                    break;
                case eFormTypes.Events:
                    requestedForm = new FormEvents(accountManager.User.Events);
                    break;
                case eFormTypes.Posts:
                    requestedForm = new FormPosts(accountManager);
                    break;
                case eFormTypes.LikedPages:
                    requestedForm = new FormLikedPages(accountManager.User.LikedPages);
                    break;
                case eFormTypes.FavoriteTeams:
                    requestedForm = new FormFavoriteTeams(accountManager.User.FavofriteTeams);
                    break;
                case eFormTypes.Friends:
                    requestedForm = new FormFriends(accountManager.User.Friends);
                    break;
                case eFormTypes.Groups:
                    requestedForm = new FormGroups(accountManager.User.Groups);
                    break;
                case eFormTypes.Statistics:
                    requestedForm = new FormStatistics(accountManager.User);
                    break;
                case eFormTypes.MostPopularFeed:
                    requestedForm = new FormMostPopularFeed(accountManager.User);
                    break;
                default:
                    throw new NotSupportedFormTypeException("This form type is not manufactored in this factory.");
            }

            return requestedForm;
        }
    }
}
