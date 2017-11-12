using System;
using System.Windows.Forms;

namespace TagTunes
{
    public partial class FormSettings : Form
    {
        private Properties.Settings Settings;

        public FormSettings()
        {
            this.Settings = Properties.Settings.Default;

            InitializeComponent();
        }

        private void FormSettings_Load(object sender, EventArgs e)
        {
            this.TextLibraryLocation.Text = this.Settings.LibraryLocation;
        }

        private void ButtonLibraryLocationBrowse_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();

            DialogResult folderDialogResult = folderBrowserDialog.ShowDialog();

            if (folderDialogResult == DialogResult.OK && !string.IsNullOrWhiteSpace(folderBrowserDialog.SelectedPath))
            {
                this.TextLibraryLocation.Text = folderBrowserDialog.SelectedPath;
            }
        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            this.Settings.LibraryLocation = this.TextLibraryLocation.Text;
            this.Settings.Save();
        }
    }
}
