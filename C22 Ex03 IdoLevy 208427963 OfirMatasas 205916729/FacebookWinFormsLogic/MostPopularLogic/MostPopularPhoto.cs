using System;
using FacebookWinFormsLogic.DateComparatiorStrategies;
using FacebookWrapper.ObjectModel;

namespace FacebookWinFormsLogic.MostPopularLogic
{
    public class MostPopularPhoto : MostPopularItem
    {
        private readonly FacebookObjectCollection<Album> r_Albums;

        public MostPopularPhoto()
        {
            r_Albums = FacebookAccountManager.Instance.Albums;
        }

        public override object FindMostPopularItem(DateTime i_ChosenDate, ICompareDateStrategy i_CompareDateStrategy)
        {
            Photo mostPopularPhoto = null;

            foreach (Album album in r_Albums)
            {
                foreach (Photo photo in album.Photos)
                {
                    if (i_CompareDateStrategy.Compare(photo.CreatedTime.Value, i_ChosenDate))
                    {
                        if (mostPopularPhoto == null || (photo.Comments.Count > mostPopularPhoto.Comments.Count))
                        {
                            mostPopularPhoto = photo;
                        }
                    }
                }
            }

            return mostPopularPhoto;
        }
    }
}
