using System.Windows.Forms;

namespace BasicFacebookFeatures
{
    internal class LazyPictureBox : PictureBox
    {
        public string URL { get; set; }

        public void Load(string i_UrlToLoad)
        {
            URL = i_UrlToLoad;
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            if(ImageLocation == null)
            {
                ImageLocation = URL;
            }

            base.OnPaint(pe);
        }
    }
}
