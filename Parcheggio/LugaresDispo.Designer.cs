namespace Parcheggio
{
    partial class LugaresDispo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LugaresDispo));
            this.pictureback = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureback)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureback
            // 
            this.pictureback.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureback.BackgroundImage")));
            this.pictureback.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureback.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureback.Location = new System.Drawing.Point(17, 16);
            this.pictureback.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.pictureback.Name = "pictureback";
            this.pictureback.Size = new System.Drawing.Size(45, 33);
            this.pictureback.TabIndex = 23;
            this.pictureback.TabStop = false;
            this.pictureback.Click += new System.EventHandler(this.pictureback_Click);
            // 
            // LugaresDispo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.pictureback);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "LugaresDispo";
            this.Text = "LugaresDispo";
            ((System.ComponentModel.ISupportInitialize)(this.pictureback)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureback;
    }
}