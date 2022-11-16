namespace Parcheggio
{
    partial class EliminarPuesto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EliminarPuesto));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnCrearPuesto = new System.Windows.Forms.Button();
            this.txtCrearPuesto = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Parcheggio.Properties.Resources.eliminar;
            this.pictureBox1.Location = new System.Drawing.Point(286, 103);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(229, 44);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 32;
            this.pictureBox1.TabStop = false;
            // 
            // btnCrearPuesto
            // 
            this.btnCrearPuesto.Location = new System.Drawing.Point(360, 289);
            this.btnCrearPuesto.Name = "btnCrearPuesto";
            this.btnCrearPuesto.Size = new System.Drawing.Size(75, 23);
            this.btnCrearPuesto.TabIndex = 31;
            this.btnCrearPuesto.Text = "Eliminar";
            this.btnCrearPuesto.UseVisualStyleBackColor = true;
            // 
            // txtCrearPuesto
            // 
            this.txtCrearPuesto.Location = new System.Drawing.Point(277, 229);
            this.txtCrearPuesto.Name = "txtCrearPuesto";
            this.txtCrearPuesto.Size = new System.Drawing.Size(244, 20);
            this.txtCrearPuesto.TabIndex = 30;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(274, 203);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 13);
            this.label2.TabIndex = 29;
            this.label2.Text = "Ingrese el puesto a eliminar";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.ErrorImage = null;
            this.pictureBox2.InitialImage = null;
            this.pictureBox2.Location = new System.Drawing.Point(232, 167);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(337, 180);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 28;
            this.pictureBox2.TabStop = false;
            // 
            // EliminarPuesto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnCrearPuesto);
            this.Controls.Add(this.txtCrearPuesto);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox2);
            this.Name = "EliminarPuesto";
            this.Text = "EliminarPuesto";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnCrearPuesto;
        private System.Windows.Forms.TextBox txtCrearPuesto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}