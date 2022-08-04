using FacebookWrapper.ObjectModel;
using System.Windows.Forms;

namespace BasicFacebookFeatures.Forms
{
    public partial class FormStatistics : Form
    {
        public User LoggedInUser { get; }

        public FormStatistics(User i_LoggedInUser)
        {
            InitializeComponent();
            LoggedInUser = i_LoggedInUser;
        }

        private void analyzeDataOnAlbumsAndPhotosInChosenMonth()
        {
            int numberOfLikesOnPhotos = 0;
            int numberOfNewAlbums = 0;
            int numberOfNewPhotos = 0;

            foreach (Album album in LoggedInUser.Albums)
            {
                if (album.CreatedTime.Value.Month == dateTimePickerChoosedMonth.Value.Month
                    && album.CreatedTime.Value.Year == dateTimePickerChoosedMonth.Value.Year)
                {
                    numberOfNewAlbums += 1;
                }
                foreach (Photo photo in album.Photos)
                {
                    if (photo.CreatedTime.Value.Month == dateTimePickerChoosedMonth.Value.Month
                    && photo.CreatedTime.Value.Year == dateTimePickerChoosedMonth.Value.Year)
                    {
                        numberOfLikesOnPhotos += photo.LikedBy.Count;
                        numberOfNewPhotos += 1;
                    }
                }
            }

            labelNumberOfLikesOnPhotos.Text = numberOfLikesOnPhotos.ToString() + (numberOfLikesOnPhotos == 1 ? " Like" : " Likes" + "\nOn Photos");
            labelNumberOfNewAlbums.Text = numberOfNewAlbums.ToString() + " New\n" + (numberOfNewAlbums == 1 ? "Album" : "Albums");
            labelNumberOfNewPhotos.Text = numberOfNewPhotos.ToString() + " New\n" + (numberOfNewPhotos == 1 ? "Photo" : "Photos");
        }

        private void calculateNumberOfPostsInChosenMonth()
        {
            int numberOfPosts = 0;

            foreach (Post post in LoggedInUser.Posts)
            {
                if(post.CreatedTime.Value.Month == dateTimePickerChoosedMonth.Value.Month 
                    && post.CreatedTime.Value.Year == dateTimePickerChoosedMonth.Value.Year)
                {
                    numberOfPosts++;
                }
            }

            labelNumberOfPosts.Text = numberOfPosts.ToString() + (numberOfPosts == 1 ? " Post" : "Posts" + "\nPublished");
        }

        private void calculateNumberOfPostsInChosenMonth(FacebookObjectCollection<Post> i_Posts, string i_Message, Label i_Label)
        {
            int numberOfPosts = 0;

            foreach (Post post in i_Posts)
            {
                if (post.CreatedTime.Value.Month == dateTimePickerChoosedMonth.Value.Month
                    && post.CreatedTime.Value.Year == dateTimePickerChoosedMonth.Value.Year)
                {
                    numberOfPosts++;
                }
            }

            i_Label.Text = numberOfPosts.ToString() + (numberOfPosts == 1 ? " Post" : "Posts" + "\n" + i_Message);
        }


        //posts in groups
        //posts in favorite teams
        //posts tagged in




        private void dateTimePickerChoosedMonth_ValueChanged(object sender, System.EventArgs e)
        {
            //panelsvisible

            //calculateNumberOfPostsInChosenMonth();
            analyzeDataOnAlbumsAndPhotosInChosenMonth();

            calculateNumberOfPostsInChosenMonth(LoggedInUser.Posts, "Published", labelNumberOfPosts);
            //calculateNumberOfPostsInChosenMonth(LoggedInUser.PostsTaggedIn, "Tagged In", labelNumberOfPostsTaggedIn);

            //calculateNumberOfPostsInChosenMonth(LoggedInUser.Groups[0].WallPosts, "In Groups", labelNumberOfPostsInGroups);
            //calculateNumberOfPostsInChosenMonth(LoggedInUser.Posts, "In Teams", labelNumberOfPostsInFavoriteTeams);
            
        }
    }
}
