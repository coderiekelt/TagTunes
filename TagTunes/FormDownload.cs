using System;
using System.Windows.Forms;

namespace TagTunes
{
    public partial class FormDownload : Form
    {
        public FormDownload()
        {
            InitializeComponent();
        }

        private void ButtonDownload_Click(object sender, EventArgs e)
        {
            TagMeta tagMeta = new TagMeta();
            tagMeta.Name = this.TextName.Text;
            tagMeta.Album = this.TextAlbum.Text;
            tagMeta.Artist = this.TextArtist.Text;

            TagDownload tagDownload = new TagDownload();
            tagDownload.TagMeta = tagMeta;
            tagDownload.YoutubeUri = this.TextYoutubeUri.Text;

            TagFile tagFile = new TagFile();
            tagFile.TagMeta = tagMeta;

            tagDownload.TagFile = tagFile;

            Context.QueueDownload(tagDownload);

            this.Close();
        }
    }
}
