using System;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using FacebookWrapper.ObjectModel;

namespace BasicFacebookFeatures
{
    public partial class FormPosts : Form
    {
        public FormPosts(FacebookObjectCollection<Post> i_Posts)
        {
            InitializeComponent();
            InitializePostsView(i_Posts);
        } 

        private void InitializePostsView(FacebookObjectCollection<Post> i_Posts)
        {
            foreach (Post post in i_Posts)
            {
                listBoxPosts.Items.Add(post);
            }

            listBoxPosts.Show();
        }

        private void buttonClearNewPostText_Click(object i_Sender, EventArgs i_E)
        {

        }

        private void listBoxPosts_SelectedIndexChanged(object i_Sender, EventArgs i_E)
        {
            Post selectedPost = listBoxPosts.SelectedItem as Post;
            StringBuilder postInformation = new StringBuilder();

            postInformation.Append(selectedPost.Name).Append(Environment.NewLine).Append(Environment.NewLine);
            postInformation.Append(selectedPost.Description).Append(Environment.NewLine).Append(Environment.NewLine);
            postInformation.Append(selectedPost.CreatedTime);

            richTextBoxSelectedPost.Text = postInformation.ToString();
        }
    }
}
