namespace TagTunes
{
    partial class FormSettings
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
            this.LabelCaptionLibraryLocation = new System.Windows.Forms.Label();
            this.ButtonSave = new System.Windows.Forms.Button();
            this.TextLibraryLocation = new System.Windows.Forms.TextBox();
            this.ButtonLibraryLocationBrowse = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LabelCaptionLibraryLocation
            // 
            this.LabelCaptionLibraryLocation.AutoSize = true;
            this.LabelCaptionLibraryLocation.Location = new System.Drawing.Point(12, 9);
            this.LabelCaptionLibraryLocation.Name = "LabelCaptionLibraryLocation";
            this.LabelCaptionLibraryLocation.Size = new System.Drawing.Size(81, 13);
            this.LabelCaptionLibraryLocation.TabIndex = 0;
            this.LabelCaptionLibraryLocation.Text = "Library location:";
            // 
            // ButtonSave
            // 
            this.ButtonSave.Location = new System.Drawing.Point(292, 139);
            this.ButtonSave.Name = "ButtonSave";
            this.ButtonSave.Size = new System.Drawing.Size(75, 23);
            this.ButtonSave.TabIndex = 1;
            this.ButtonSave.Text = "Save";
            this.ButtonSave.UseVisualStyleBackColor = true;
            this.ButtonSave.Click += new System.EventHandler(this.ButtonSave_Click);
            // 
            // TextLibraryLocation
            // 
            this.TextLibraryLocation.Location = new System.Drawing.Point(12, 25);
            this.TextLibraryLocation.Name = "TextLibraryLocation";
            this.TextLibraryLocation.Size = new System.Drawing.Size(295, 20);
            this.TextLibraryLocation.TabIndex = 2;
            // 
            // ButtonLibraryLocationBrowse
            // 
            this.ButtonLibraryLocationBrowse.Location = new System.Drawing.Point(313, 25);
            this.ButtonLibraryLocationBrowse.Name = "ButtonLibraryLocationBrowse";
            this.ButtonLibraryLocationBrowse.Size = new System.Drawing.Size(54, 21);
            this.ButtonLibraryLocationBrowse.TabIndex = 3;
            this.ButtonLibraryLocationBrowse.Text = "Browse";
            this.ButtonLibraryLocationBrowse.UseVisualStyleBackColor = true;
            this.ButtonLibraryLocationBrowse.Click += new System.EventHandler(this.ButtonLibraryLocationBrowse_Click);
            // 
            // FormSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 174);
            this.Controls.Add(this.ButtonLibraryLocationBrowse);
            this.Controls.Add(this.TextLibraryLocation);
            this.Controls.Add(this.ButtonSave);
            this.Controls.Add(this.LabelCaptionLibraryLocation);
            this.Name = "FormSettings";
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.FormSettings_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabelCaptionLibraryLocation;
        private System.Windows.Forms.Button ButtonSave;
        private System.Windows.Forms.TextBox TextLibraryLocation;
        private System.Windows.Forms.Button ButtonLibraryLocationBrowse;
    }
}