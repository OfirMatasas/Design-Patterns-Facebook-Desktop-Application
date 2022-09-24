using System;
using FacebookWinFormsLogic.DateComparatiorStrategies;
using FacebookWinFormsLogic.MostPopularLogic;
using FacebookWrapper.ObjectModel;

namespace FacebookWinFormsLogic
{
    public class MostPopularFeedLogic
    {
        //---------------------------------------------- Members ----------------------------------------------//
        public DateTime ChosenDate { get; set; }

        public ICompareDateStrategy CompareDateStrategy { get; set; }

        private readonly MostPopularPost r_MostPopularPost;
        private readonly MostPopularPhoto r_MostPopularPhoto;

        //-------------------------------------------- Constructor --------------------------------------------//
        public MostPopularFeedLogic()
        {
            r_MostPopularPost = new MostPopularPost();
            r_MostPopularPhoto = new MostPopularPhoto();
        }

        //---------------------------------------------- Methods ----------------------------------------------//
        public Post MostPopularPost
        {
            get { return r_MostPopularPost.FindMostPopularItem(ChosenDate, CompareDateStrategy) as Post; }
        }

        public Photo MostPopularPhoto
        {
            get { return r_MostPopularPhoto.FindMostPopularItem(ChosenDate, CompareDateStrategy) as Photo; }
        }
    }
}
