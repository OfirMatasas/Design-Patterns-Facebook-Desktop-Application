using BasicFacebookFeatures;
using FacebookWinFormsLogic;
using FacebookWrapper.ObjectModel;
using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace FacebookWinFormsApp.Forms
{
    internal partial class FormAlbums : Form
    {
        private readonly FacebookObjectCollection<Album> r_Albums;

        public FormAlbums()
        {
            InitializeComponent();
            r_Albums = FacebookAccountManager.Instance.Albums;            
        }

        private void fetchAlbums()
        {
            listBoxAlbums.Invoke(new Action(() => albumBindingSource.DataSource = r_Albums));
        }

        protected override void OnShown(EventArgs i_E)
        {
            base.OnShown(i_E);
            new Thread(fetchAlbums).Start();
            if (r_Albums == null)
            {
                MessageDisplayer.NoItemsAppearOnForm("albums");
            }
        }

        private void listBoxAlbums_SelectedIndexChanged(object i_Sender, EventArgs i_E)
        {
            Album album = listBoxAlbums.SelectedItem as Album;
            if (album != null)
            {
                showSelectedAlbumsPhotos(album);
                showSelectedAlbumsName(album);
            }
        }

        private void showSelectedAlbumsPhotos(Album i_Album)
        {
            LazyPictureBox pictureBox;
            Size pictureBoxSize = new Size(200, 200);
            Padding pictureBoxPadding = new Padding(10);

            flowLayoutPanelSelectedAlbumPhotos.Controls.Clear();
            if(i_Album.Count == 0)
            {
                MessageDisplayer.NoItemsAppearOnForm("photos");
            }
            else
            {
                foreach (Photo photo in i_Album.Photos)
                {
                    pictureBox = new LazyPictureBox()
                    {
                        Padding = pictureBoxPadding,
                        Size = pictureBoxSize,
                        SizeMode = PictureBoxSizeMode.StretchImage
                    };
                    pictureBox.Load(photo.PictureNormalURL);
                    flowLayoutPanelSelectedAlbumPhotos.Controls.Add(pictureBox);
                }

                flowLayoutPanelSelectedAlbumPhotos.Show();
            }
        }

        private void showSelectedAlbumsName(Album i_Album)
        {
            labelSelectedAlbumName.Text = i_Album.Name;
            labelSelectedAlbumName.Visible = true;
        }
    }
}
