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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPuesto = new System.Windows.Forms.TextBox();
            this.btnCrearPuesto = new System.Windows.Forms.Button();
            this.pictureback = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureback)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(303, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Crear puesto";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(275, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Ingrese el puesto";
            // 
            // txtPuesto
            // 
            this.txtPuesto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtPuesto.Location = new System.Drawing.Point(278, 149);
            this.txtPuesto.Name = "txtPuesto";
            this.txtPuesto.Size = new System.Drawing.Size(144, 20);
            this.txtPuesto.TabIndex = 20;
            // 
            // btnCrearPuesto
            // 
            this.btnCrearPuesto.Location = new System.Drawing.Point(358, 242);
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
            this.pictureBox2.Location = new System.Drawing.Point(254, 87);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(274, 225);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 35;
            this.pictureBox2.TabStop = false;
            // 
            // CrearPuesto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureback);
            this.Controls.Add(this.btnCrearPuesto);
            this.Controls.Add(this.txtPuesto);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.Name = "CrearPuesto";
            this.Text = "CrearPuesto";
            ((System.ComponentModel.ISupportInitialize)(this.pictureback)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPuesto;
        private System.Windows.Forms.Button btnCrearPuesto;
        private System.Windows.Forms.PictureBox pictureback;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}