namespace DriversHub
{
    partial class DriversHub
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DriversHub));
            this.DHEmbed = new System.Windows.Forms.WebBrowser();
            this.Loading_Bar = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // DHEmbed
            // 
            this.DHEmbed.AccessibleName = "VivaDriversHub";
            this.DHEmbed.Location = new System.Drawing.Point(17, 15);
            this.DHEmbed.Margin = new System.Windows.Forms.Padding(8, 6, 8, 6);
            this.DHEmbed.MaximumSize = new System.Drawing.Size(1550, 825);
            this.DHEmbed.MinimumSize = new System.Drawing.Size(1550, 825);
            this.DHEmbed.Name = "DHEmbed";
            this.DHEmbed.ScriptErrorsSuppressed = true;
            this.DHEmbed.Size = new System.Drawing.Size(1550, 825);
            this.DHEmbed.TabIndex = 0;
            this.DHEmbed.Url = new System.Uri("https://vivatrucks.com", System.UriKind.Absolute);
            this.DHEmbed.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.Driverhub_DocumentCompleted);
            // 
            // Loading_Bar
            // 
            this.Loading_Bar.Location = new System.Drawing.Point(12, 12);
            this.Loading_Bar.Name = "Loading_Bar";
            this.Loading_Bar.Size = new System.Drawing.Size(611, 32);
            this.Loading_Bar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.Loading_Bar.TabIndex = 1;
            this.Loading_Bar.Value = 10;
            // 
            // DriversHub
            // 
            this.AccessibleDescription = "Viva Drivers Hub";
            this.AccessibleName = "Viva Drivers Hub";
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1584, 861);
            this.Controls.Add(this.Loading_Bar);
            this.Controls.Add(this.DHEmbed);
            this.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.Font = new System.Drawing.Font("Helvetica Black", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(8, 6, 8, 6);
            this.Name = "DriversHub";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.UseWaitCursor = true;
            this.Load += new System.EventHandler(this.DriversHub_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.WebBrowser DHEmbed;
        private System.Windows.Forms.ProgressBar Loading_Bar;
    }
}

