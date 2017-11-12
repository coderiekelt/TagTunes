namespace TagTunes
{
    partial class FormDownload
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
            this.TextAlbum = new System.Windows.Forms.TextBox();
            this.LabelCaptionAlbum = new System.Windows.Forms.Label();
            this.TextArtist = new System.Windows.Forms.TextBox();
            this.LabelCaptionArtist = new System.Windows.Forms.Label();
            this.TextName = new System.Windows.Forms.TextBox();
            this.LabelCaptionName = new System.Windows.Forms.Label();
            this.LabelCaptionInformation = new System.Windows.Forms.Label();
            this.LabelCaptionYoutubeUri = new System.Windows.Forms.Label();
            this.TextYoutubeUri = new System.Windows.Forms.TextBox();
            this.ButtonDownload = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TextAlbum
            // 
            this.TextAlbum.Location = new System.Drawing.Point(12, 163);
            this.TextAlbum.Name = "TextAlbum";
            this.TextAlbum.Size = new System.Drawing.Size(477, 20);
            this.TextAlbum.TabIndex = 20;
            // 
            // LabelCaptionAlbum
            // 
            this.LabelCaptionAlbum.AutoSize = true;
            this.LabelCaptionAlbum.Location = new System.Drawing.Point(12, 147);
            this.LabelCaptionAlbum.Name = "LabelCaptionAlbum";
            this.LabelCaptionAlbum.Size = new System.Drawing.Size(39, 13);
            this.LabelCaptionAlbum.TabIndex = 19;
            this.LabelCaptionAlbum.Text = "Album:";
            // 
            // TextArtist
            // 
            this.TextArtist.Location = new System.Drawing.Point(12, 124);
            this.TextArtist.Name = "TextArtist";
            this.TextArtist.Size = new System.Drawing.Size(477, 20);
            this.TextArtist.TabIndex = 18;
            // 
            // LabelCaptionArtist
            // 
            this.LabelCaptionArtist.AutoSize = true;
            this.LabelCaptionArtist.Location = new System.Drawing.Point(12, 108);
            this.LabelCaptionArtist.Name = "LabelCaptionArtist";
            this.LabelCaptionArtist.Size = new System.Drawing.Size(33, 13);
            this.LabelCaptionArtist.TabIndex = 17;
            this.LabelCaptionArtist.Text = "Artist:";
            // 
            // TextName
            // 
            this.TextName.Location = new System.Drawing.Point(12, 86);
            this.TextName.Name = "TextName";
            this.TextName.Size = new System.Drawing.Size(477, 20);
            this.TextName.TabIndex = 16;
            // 
            // LabelCaptionName
            // 
            this.LabelCaptionName.AutoSize = true;
            this.LabelCaptionName.Location = new System.Drawing.Point(12, 70);
            this.LabelCaptionName.Name = "LabelCaptionName";
            this.LabelCaptionName.Size = new System.Drawing.Size(38, 13);
            this.LabelCaptionName.TabIndex = 15;
            this.LabelCaptionName.Text = "Name:";
            // 
            // LabelCaptionInformation
            // 
            this.LabelCaptionInformation.AutoSize = true;
            this.LabelCaptionInformation.Location = new System.Drawing.Point(12, 54);
            this.LabelCaptionInformation.Name = "LabelCaptionInformation";
            this.LabelCaptionInformation.Size = new System.Drawing.Size(59, 13);
            this.LabelCaptionInformation.TabIndex = 14;
            this.LabelCaptionInformation.Text = "Information";
            // 
            // LabelCaptionYoutubeUri
            // 
            this.LabelCaptionYoutubeUri.AutoSize = true;
            this.LabelCaptionYoutubeUri.Location = new System.Drawing.Point(12, 9);
            this.LabelCaptionYoutubeUri.Name = "LabelCaptionYoutubeUri";
            this.LabelCaptionYoutubeUri.Size = new System.Drawing.Size(75, 13);
            this.LabelCaptionYoutubeUri.TabIndex = 21;
            this.LabelCaptionYoutubeUri.Text = "Youtube URL:";
            // 
            // TextYoutubeUri
            // 
            this.TextYoutubeUri.Location = new System.Drawing.Point(12, 25);
            this.TextYoutubeUri.Name = "TextYoutubeUri";
            this.TextYoutubeUri.Size = new System.Drawing.Size(477, 20);
            this.TextYoutubeUri.TabIndex = 22;
            // 
            // ButtonDownload
            // 
            this.ButtonDownload.Location = new System.Drawing.Point(414, 189);
            this.ButtonDownload.Name = "ButtonDownload";
            this.ButtonDownload.Size = new System.Drawing.Size(75, 23);
            this.ButtonDownload.TabIndex = 23;
            this.ButtonDownload.Text = "Download";
            this.ButtonDownload.UseVisualStyleBackColor = true;
            this.ButtonDownload.Click += new System.EventHandler(this.ButtonDownload_Click);
            // 
            // FormDownload
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 227);
            this.Controls.Add(this.ButtonDownload);
            this.Controls.Add(this.TextYoutubeUri);
            this.Controls.Add(this.LabelCaptionYoutubeUri);
            this.Controls.Add(this.TextAlbum);
            this.Controls.Add(this.LabelCaptionAlbum);
            this.Controls.Add(this.TextArtist);
            this.Controls.Add(this.LabelCaptionArtist);
            this.Controls.Add(this.TextName);
            this.Controls.Add(this.LabelCaptionName);
            this.Controls.Add(this.LabelCaptionInformation);
            this.Name = "FormDownload";
            this.Text = "Download";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TextAlbum;
        private System.Windows.Forms.Label LabelCaptionAlbum;
        private System.Windows.Forms.TextBox TextArtist;
        private System.Windows.Forms.Label LabelCaptionArtist;
        private System.Windows.Forms.TextBox TextName;
        private System.Windows.Forms.Label LabelCaptionName;
        private System.Windows.Forms.Label LabelCaptionInformation;
        private System.Windows.Forms.Label LabelCaptionYoutubeUri;
        private System.Windows.Forms.TextBox TextYoutubeUri;
        private System.Windows.Forms.Button ButtonDownload;
    }
}