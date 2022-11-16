namespace Parcheggio
{
    partial class Primera
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnRegistrarse = new System.Windows.Forms.PictureBox();
            this.btnIniciarSesion = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.btnRegistrarse)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnIniciarSesion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRegistrarse
            // 
            this.btnRegistrarse.BackgroundImage = global::Parcheggio.Properties.Resources.btnRegistrarse;
            this.btnRegistrarse.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnRegistrarse.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegistrarse.Location = new System.Drawing.Point(316, 272);
            this.btnRegistrarse.Name = "btnRegistrarse";
            this.btnRegistrarse.Size = new System.Drawing.Size(157, 44);
            this.btnRegistrarse.TabIndex = 9;
            this.btnRegistrarse.TabStop = false;
            this.btnRegistrarse.Click += new System.EventHandler(this.btnRegistrarse_Click_1);
            // 
            // btnIniciarSesion
            // 
            this.btnIniciarSesion.BackgroundImage = global::Parcheggio.Properties.Resources.btnInicioSesion;
            this.btnIniciarSesion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnIniciarSesion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnIniciarSesion.Location = new System.Drawing.Point(316, 200);
            this.btnIniciarSesion.Name = "btnIniciarSesion";
            this.btnIniciarSesion.Size = new System.Drawing.Size(157, 48);
            this.btnIniciarSesion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnIniciarSesion.TabIndex = 8;
            this.btnIniciarSesion.TabStop = false;
            this.btnIniciarSesion.Click += new System.EventHandler(this.btnIniciarSesion_Click_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Parcheggio.Properties.Resources.parPar;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(171, 91);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(447, 67);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // Primera
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(806, 491);
            this.Controls.Add(this.btnRegistrarse);
            this.Controls.Add(this.btnIniciarSesion);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximumSize = new System.Drawing.Size(822, 530);
            this.MinimumSize = new System.Drawing.Size(822, 530);
            this.Name = "Primera";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Primera_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btnRegistrarse)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnIniciarSesion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox btnRegistrarse;
        private System.Windows.Forms.PictureBox btnIniciarSesion;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

