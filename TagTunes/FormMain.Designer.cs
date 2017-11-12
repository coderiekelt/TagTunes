namespace TagTunes
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.LabelCaptionLibrary = new System.Windows.Forms.Label();
            this.ListLibrary = new System.Windows.Forms.ListBox();
            this.ButtonSettings = new System.Windows.Forms.Button();
            this.ButtonDownload = new System.Windows.Forms.Button();
            this.ButtonRefresh = new System.Windows.Forms.Button();
            this.ButtonSave = new System.Windows.Forms.Button();
            this.ButtonRemove = new System.Windows.Forms.Button();
            this.LabelCaptionInformation = new System.Windows.Forms.Label();
            this.LabelCaptionName = new System.Windows.Forms.Label();
            this.TextName = new System.Windows.Forms.TextBox();
            this.TextArtist = new System.Windows.Forms.TextBox();
            this.LabelCaptionArtist = new System.Windows.Forms.Label();
            this.TextAlbum = new System.Windows.Forms.TextBox();
            this.LabelCaptionAlbum = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LabelCaptionLibrary
            // 
            this.LabelCaptionLibrary.AutoSize = true;
            this.LabelCaptionLibrary.Location = new System.Drawing.Point(12, 9);
            this.LabelCaptionLibrary.Name = "LabelCaptionLibrary";
            this.LabelCaptionLibrary.Size = new System.Drawing.Size(38, 13);
            this.LabelCaptionLibrary.TabIndex = 0;
            this.LabelCaptionLibrary.Text = "Library";
            // 
            // ListLibrary
            // 
            this.ListLibrary.FormattingEnabled = true;
            this.ListLibrary.Location = new System.Drawing.Point(12, 25);
            this.ListLibrary.Name = "ListLibrary";
            this.ListLibrary.Size = new System.Drawing.Size(365, 420);
            this.ListLibrary.TabIndex = 1;
            this.ListLibrary.SelectedIndexChanged += new System.EventHandler(this.ListLibrary_SelectedIndexChanged);
            // 
            // ButtonSettings
            // 
            this.ButtonSettings.Location = new System.Drawing.Point(12, 451);
            this.ButtonSettings.Name = "ButtonSettings";
            this.ButtonSettings.Size = new System.Drawing.Size(75, 23);
            this.ButtonSettings.TabIndex = 2;
            this.ButtonSettings.Text = "Settings";
            this.ButtonSettings.UseVisualStyleBackColor = true;
            this.ButtonSettings.Click += new System.EventHandler(this.ButtonSettings_Click);
            // 
            // ButtonDownload
            // 
            this.ButtonDownload.Location = new System.Drawing.Point(788, 451);
            this.ButtonDownload.Name = "ButtonDownload";
            this.ButtonDownload.Size = new System.Drawing.Size(75, 23);
            this.ButtonDownload.TabIndex = 3;
            this.ButtonDownload.Text = "Download";
            this.ButtonDownload.UseVisualStyleBackColor = true;
            this.ButtonDownload.Click += new System.EventHandler(this.ButtonDownload_Click);
            // 
            // ButtonRefresh
            // 
            this.ButtonRefresh.Location = new System.Drawing.Point(302, 451);
            this.ButtonRefresh.Name = "ButtonRefresh";
            this.ButtonRefresh.Size = new System.Drawing.Size(75, 23);
            this.ButtonRefresh.TabIndex = 4;
            this.ButtonRefresh.Text = "Refresh";
            this.ButtonRefresh.UseVisualStyleBackColor = true;
            this.ButtonRefresh.Click += new System.EventHandler(this.ButtonRefresh_Click);
            // 
            // ButtonSave
            // 
            this.ButtonSave.Location = new System.Drawing.Point(386, 451);
            this.ButtonSave.Name = "ButtonSave";
            this.ButtonSave.Size = new System.Drawing.Size(75, 23);
            this.ButtonSave.TabIndex = 5;
            this.ButtonSave.Text = "Save";
            this.ButtonSave.UseVisualStyleBackColor = true;
            this.ButtonSave.Click += new System.EventHandler(this.ButtonSave_Click);
            // 
            // ButtonRemove
            // 
            this.ButtonRemove.Location = new System.Drawing.Point(467, 451);
            this.ButtonRemove.Name = "ButtonRemove";
            this.ButtonRemove.Size = new System.Drawing.Size(75, 23);
            this.ButtonRemove.TabIndex = 6;
            this.ButtonRemove.Text = "Remove";
            this.ButtonRemove.UseVisualStyleBackColor = true;
            this.ButtonRemove.Click += new System.EventHandler(this.ButtonRemove_Click);
            // 
            // LabelCaptionInformation
            // 
            this.LabelCaptionInformation.AutoSize = true;
            this.LabelCaptionInformation.Location = new System.Drawing.Point(383, 9);
            this.LabelCaptionInformation.Name = "LabelCaptionInformation";
            this.LabelCaptionInformation.Size = new System.Drawing.Size(59, 13);
            this.LabelCaptionInformation.TabIndex = 7;
            this.LabelCaptionInformation.Text = "Information";
            // 
            // LabelCaptionName
            // 
            this.LabelCaptionName.AutoSize = true;
            this.LabelCaptionName.Location = new System.Drawing.Point(383, 25);
            this.LabelCaptionName.Name = "LabelCaptionName";
            this.LabelCaptionName.Size = new System.Drawing.Size(38, 13);
            this.LabelCaptionName.TabIndex = 8;
            this.LabelCaptionName.Text = "Name:";
            // 
            // TextName
            // 
            this.TextName.Location = new System.Drawing.Point(383, 41);
            this.TextName.Name = "TextName";
            this.TextName.Size = new System.Drawing.Size(477, 20);
            this.TextName.TabIndex = 9;
            // 
            // TextArtist
            // 
            this.TextArtist.Location = new System.Drawing.Point(383, 79);
            this.TextArtist.Name = "TextArtist";
            this.TextArtist.Size = new System.Drawing.Size(477, 20);
            this.TextArtist.TabIndex = 11;
            // 
            // LabelCaptionArtist
            // 
            this.LabelCaptionArtist.AutoSize = true;
            this.LabelCaptionArtist.Location = new System.Drawing.Point(383, 63);
            this.LabelCaptionArtist.Name = "LabelCaptionArtist";
            this.LabelCaptionArtist.Size = new System.Drawing.Size(33, 13);
            this.LabelCaptionArtist.TabIndex = 10;
            this.LabelCaptionArtist.Text = "Artist:";
            // 
            // TextAlbum
            // 
            this.TextAlbum.Location = new System.Drawing.Point(383, 118);
            this.TextAlbum.Name = "TextAlbum";
            this.TextAlbum.Size = new System.Drawing.Size(477, 20);
            this.TextAlbum.TabIndex = 13;
            // 
            // LabelCaptionAlbum
            // 
            this.LabelCaptionAlbum.AutoSize = true;
            this.LabelCaptionAlbum.Location = new System.Drawing.Point(383, 102);
            this.LabelCaptionAlbum.Name = "LabelCaptionAlbum";
            this.LabelCaptionAlbum.Size = new System.Drawing.Size(39, 13);
            this.LabelCaptionAlbum.TabIndex = 12;
            this.LabelCaptionAlbum.Text = "Album:";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(875, 482);
            this.Controls.Add(this.TextAlbum);
            this.Controls.Add(this.LabelCaptionAlbum);
            this.Controls.Add(this.TextArtist);
            this.Controls.Add(this.LabelCaptionArtist);
            this.Controls.Add(this.TextName);
            this.Controls.Add(this.LabelCaptionName);
            this.Controls.Add(this.LabelCaptionInformation);
            this.Controls.Add(this.ButtonRemove);
            this.Controls.Add(this.ButtonSave);
            this.Controls.Add(this.ButtonRefresh);
            this.Controls.Add(this.ButtonDownload);
            this.Controls.Add(this.ButtonSettings);
            this.Controls.Add(this.ListLibrary);
            this.Controls.Add(this.LabelCaptionLibrary);
            this.Name = "FormMain";
            this.Text = "TagTunes";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabelCaptionLibrary;
        private System.Windows.Forms.ListBox ListLibrary;
        private System.Windows.Forms.Button ButtonSettings;
        private System.Windows.Forms.Button ButtonDownload;
        private System.Windows.Forms.Button ButtonRefresh;
        private System.Windows.Forms.Button ButtonSave;
        private System.Windows.Forms.Button ButtonRemove;
        private System.Windows.Forms.Label LabelCaptionInformation;
        private System.Windows.Forms.Label LabelCaptionName;
        private System.Windows.Forms.TextBox TextName;
        private System.Windows.Forms.TextBox TextArtist;
        private System.Windows.Forms.Label LabelCaptionArtist;
        private System.Windows.Forms.TextBox TextAlbum;
        private System.Windows.Forms.Label LabelCaptionAlbum;
    }
}

