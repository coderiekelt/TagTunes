using System;
using System.IO;
using System.Windows.Forms;

namespace TagTunes
{
    public partial class FormMain : Form
    {
        private Properties.Settings Settings;

        private TagFile SelectedFile;

        public FormMain()
        {
            this.Settings = Properties.Settings.Default;
            Context.MainForm = this;

            InitializeComponent();
        }

        public void DoRefresh()
        {
            if (this.InvokeRequired)
            {
                this.Invoke(new Action(() => this.ButtonRefresh.PerformClick()));

                return;
            }

            this.ButtonRefresh.PerformClick();
        }

        private void ButtonRefresh_Click(object sender, EventArgs e)
        {
            this.ListLibrary.Items.Clear();

            if (Directory.Exists(Settings.LibraryLocation))
            {
                foreach (string file in Directory.GetFiles(Settings.LibraryLocation))
                {
                    try
                    {
                        TagLib.File tagLibFile = TagLib.File.Create(file);

                        TagFile tagFile = new TagFile();
                        tagFile.Location = file;

                        TagMeta tagMeta = new TagMeta();
                        tagMeta.Name = tagLibFile.Tag.Title;
                        tagMeta.Album = tagLibFile.Tag.Album;
                        tagMeta.Artist = tagLibFile.Tag.JoinedArtists;

                        tagFile.TagMeta = tagMeta;

                        this.ListLibrary.Items.Add(tagFile);
                    } catch (Exception exception)
                    {
                        MessageBox.Show("An error occured while loading " + file + ", details: " + exception.Message, "Something requires your attention.");
                    }
                }
            } else
            {
                MessageBox.Show("Please change the library location to a valid path in Settings.", "Something requires your attention.");
            }
        }

        private void ButtonSettings_Click(object sender, EventArgs e)
        {
            FormSettings settingsForm = new FormSettings();
            settingsForm.Show();
        }

        private void ListLibrary_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.ListLibrary.SelectedItem == null)
            {
                return;
            }

            TagFile selectedFile = (TagFile)this.ListLibrary.SelectedItem;

            this.TextName.Text = selectedFile.TagMeta.Name;
            this.TextAlbum.Text = selectedFile.TagMeta.Album;
            this.TextArtist.Text = selectedFile.TagMeta.Artist;

            this.SelectedFile = selectedFile;
        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            if (this.SelectedFile == null)
            {
                MessageBox.Show("You have not selected a valid file in your library.", "Something requires your attention.");

                return;
            }

            TagLib.File tagLibFile = TagLib.File.Create(this.SelectedFile.Location);

            tagLibFile.Tag.Title = this.TextName.Text;
            tagLibFile.Tag.Album = this.TextAlbum.Text;
            tagLibFile.Tag.Artists = new string[] { this.TextArtist.Text };

            tagLibFile.Save();

            this.ButtonRefresh.PerformClick();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            this.ButtonRefresh.PerformClick();
        }

        private void ButtonRemove_Click(object sender, EventArgs e)
        {
            if (this.SelectedFile == null)
            {
                MessageBox.Show("You have not selected a valid file in your library.", "Something requires your attention.");

                return;
            }

            if (MessageBox.Show("Are you sure you want to remove this file?", "Something requires your attention.", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                File.Delete(this.SelectedFile.Location);
                this.ButtonRefresh.PerformClick();
            }
        }

        private void ButtonDownload_Click(object sender, EventArgs e)
        {
            FormDownload downloadForm = new FormDownload();
            downloadForm.Show();
        }
    }
}
