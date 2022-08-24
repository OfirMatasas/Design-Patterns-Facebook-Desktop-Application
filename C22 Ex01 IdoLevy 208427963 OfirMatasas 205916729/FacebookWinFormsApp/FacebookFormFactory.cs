﻿using FacebookExceptions;
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
                    requestedForm = new FormProfile();
                    break;
                case eFormTypes.Albums:
                    requestedForm = new FormAlbums();
                    break;
                case eFormTypes.Events:
                    requestedForm = new FormEvents();
                    break;
                case eFormTypes.Posts:
                    requestedForm = new FormPosts();
                    break;
                case eFormTypes.LikedPages:
                    requestedForm = new FormLikedPages();
                    break;
                case eFormTypes.FavoriteTeams:
                    requestedForm = new FormFavoriteTeams();
                    break;
                case eFormTypes.Friends:
                    requestedForm = new FormFriends();
                    break;
                case eFormTypes.Groups:
                    requestedForm = new FormGroups();
                    break;
                case eFormTypes.Statistics:
                    requestedForm = new FormStatistics();
                    break;
                case eFormTypes.MostPopularFeed:
                    requestedForm = new FormMostPopularFeed();
                    break;
                default:
                    throw new NotSupportedFormTypeException();
            }

            return requestedForm;
        }
    }
}
