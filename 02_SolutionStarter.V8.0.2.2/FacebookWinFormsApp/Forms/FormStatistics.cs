using FacebookWrapper.ObjectModel;
using System.Windows.Forms;

namespace BasicFacebookFeatures.Forms
{
    public partial class FormStatistics : Form
    {
        public User LoggedInUser { get; }

        public FormStatistics(User loggedInUser)
        {
            InitializeComponent();
            LoggedInUser = loggedInUser;
        }

        private void calculateNumberOfPostsAndLikesInChosenMonth()
        {
            int numberOfPosts = 0;
            //int numberOfLikesOnPosts = 0;

            foreach (Post post in LoggedInUser.Posts)
            {
                if(post.CreatedTime.Value.Month == dateTimePickerChoosedMonth.Value.Month 
                    && post.CreatedTime.Value.Year == dateTimePickerChoosedMonth.Value.Year)
                {
                    numberOfPosts++;
                    //numberOfLikesOnPosts += post.LikedBy.Count;
                }
            }
            label1.Text = numberOfPosts.ToString();
            //labelNumberOfPosts.Text += numberOfPosts;
        }

        private void calculateNumberOfLikesOnPhotosInChosenMonth()
        {
            int numberOfLikesOnPhotos = 0;

            foreach (Album album in LoggedInUser.Albums)
            {
                foreach (Photo photo in album.Photos)
                {
                    if (photo.CreatedTime.Value.Month == dateTimePickerChoosedMonth.Value.Month
                    && photo.CreatedTime.Value.Year == dateTimePickerChoosedMonth.Value.Year)
                    {
                        numberOfLikesOnPhotos += photo.LikedBy.Count;
                    }

                }
            }

            label4.Text = numberOfLikesOnPhotos.ToString();
        }

        private void calculateNumberOfNewGroupsInChosenMonth()
        {
            int numberOfNewGroups = 0;

            foreach (Group group in LoggedInUser.Groups)
            {
                if (group.UpdateTime.Value.Month == dateTimePickerChoosedMonth.Value.Month
                    && group.UpdateTime.Value.Year == dateTimePickerChoosedMonth.Value.Year)
                {
                    numberOfNewGroups += 1;
                }
            }

            label5.Text = numberOfNewGroups.ToString();

        }


        private void dateTimePickerChoosedMonth_ValueChanged(object sender, System.EventArgs e)
        {
            calculateNumberOfPostsAndLikesInChosenMonth();
            calculateNumberOfLikesOnPhotosInChosenMonth();
            //calculateNumberOfNewGroupsInChosenMonth();
        }
    }
}
