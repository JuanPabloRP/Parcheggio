namespace Parcheggio
{
    partial class CrearPuesto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CrearPuesto));
            this.label2 = new System.Windows.Forms.Label();
            this.txtPuesto = new System.Windows.Forms.TextBox();
            this.btnCrearPuesto = new System.Windows.Forms.Button();
            this.pictureback = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureback)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(281, 185);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Ingrese el puesto";
            // 
            // txtPuesto
            // 
            this.txtPuesto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtPuesto.Location = new System.Drawing.Point(284, 201);
            this.txtPuesto.Name = "txtPuesto";
            this.txtPuesto.Size = new System.Drawing.Size(144, 20);
            this.txtPuesto.TabIndex = 20;
            // 
            // btnCrearPuesto
            // 
            this.btnCrearPuesto.Location = new System.Drawing.Point(364, 294);
            this.btnCrearPuesto.Name = "btnCrearPuesto";
            this.btnCrearPuesto.Size = new System.Drawing.Size(75, 23);
            this.btnCrearPuesto.TabIndex = 21;
            this.btnCrearPuesto.Text = "Crear";
            this.btnCrearPuesto.UseVisualStyleBackColor = true;
            this.btnCrearPuesto.Click += new System.EventHandler(this.btnCrearPuesto_Click);
            // 
            // pictureback
            // 
            this.pictureback.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureback.BackgroundImage")));
            this.pictureback.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureback.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureback.Location = new System.Drawing.Point(12, 12);
            this.pictureback.Name = "pictureback";
            this.pictureback.Size = new System.Drawing.Size(32, 28);
            this.pictureback.TabIndex = 34;
            this.pictureback.TabStop = false;
            this.pictureback.Click += new System.EventHandler(this.pictureback_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.ErrorImage = null;
            this.pictureBox2.InitialImage = null;
            this.pictureBox2.Location = new System.Drawing.Point(260, 139);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(274, 225);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 35;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Parcheggio.Properties.Resources.crearPuesto;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(284, 72);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(226, 50);
            this.pictureBox1.TabIndex = 36;
            this.pictureBox1.TabStop = false;
            // 
            // CrearPuesto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(806, 489);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureback);
            this.Controls.Add(this.btnCrearPuesto);
            this.Controls.Add(this.txtPuesto);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox2);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(822, 528);
            this.MinimumSize = new System.Drawing.Size(822, 528);
            this.Name = "CrearPuesto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CrearPuesto";
            ((System.ComponentModel.ISupportInitialize)(this.pictureback)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPuesto;
        private System.Windows.Forms.Button btnCrearPuesto;
        private System.Windows.Forms.PictureBox pictureback;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}