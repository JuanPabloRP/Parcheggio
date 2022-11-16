namespace Parcheggio
{
    partial class RegisVehiculo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegisVehiculo));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtcolor = new System.Windows.Forms.TextBox();
            this.txtplaca = new System.Windows.Forms.TextBox();
            this.cbPuestoVehi = new System.Windows.Forms.ComboBox();
            this.cbTipoVehi = new System.Windows.Forms.ComboBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnRogVeih = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(205, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Placa";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(538, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Color";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(205, 257);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tipo";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(538, 257);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Asignar puesto";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(225, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(357, 46);
            this.label5.TabIndex = 4;
            this.label5.Text = "Registrar vehiculo";
            // 
            // txtcolor
            // 
            this.txtcolor.Location = new System.Drawing.Point(541, 151);
            this.txtcolor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtcolor.Name = "txtcolor";
            this.txtcolor.Size = new System.Drawing.Size(108, 22);
            this.txtcolor.TabIndex = 6;
            this.txtcolor.TextChanged += new System.EventHandler(this.txtcolor_TextChanged);
            // 
            // txtplaca
            // 
            this.txtplaca.Location = new System.Drawing.Point(208, 151);
            this.txtplaca.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtplaca.Name = "txtplaca";
            this.txtplaca.Size = new System.Drawing.Size(108, 22);
            this.txtplaca.TabIndex = 7;
            this.txtplaca.TextChanged += new System.EventHandler(this.txtplaca_TextChanged);
            // 
            // cbPuestoVehi
            // 
            this.cbPuestoVehi.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.cbPuestoVehi.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbPuestoVehi.FormattingEnabled = true;
            this.cbPuestoVehi.Location = new System.Drawing.Point(541, 288);
            this.cbPuestoVehi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbPuestoVehi.Name = "cbPuestoVehi";
            this.cbPuestoVehi.Size = new System.Drawing.Size(119, 24);
            this.cbPuestoVehi.TabIndex = 8;
            // 
            // cbTipoVehi
            // 
            this.cbTipoVehi.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.cbTipoVehi.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbTipoVehi.FormattingEnabled = true;
            this.cbTipoVehi.Items.AddRange(new object[] {
            "Automovil\t",
            "Motocicleta"});
            this.cbTipoVehi.Location = new System.Drawing.Point(208, 288);
            this.cbTipoVehi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbTipoVehi.Name = "cbTipoVehi";
            this.cbTipoVehi.Size = new System.Drawing.Size(119, 24);
            this.cbTipoVehi.TabIndex = 9;
            this.cbTipoVehi.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.ErrorImage = null;
            this.pictureBox2.InitialImage = null;
            this.pictureBox2.Location = new System.Drawing.Point(110, 83);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(586, 366);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 19;
            this.pictureBox2.TabStop = false;
            // 
            // btnRogVeih
            // 
            this.btnRogVeih.Location = new System.Drawing.Point(358, 367);
            this.btnRogVeih.Margin = new System.Windows.Forms.Padding(4);
            this.btnRogVeih.Name = "btnRogVeih";
            this.btnRogVeih.Size = new System.Drawing.Size(147, 34);
            this.btnRogVeih.TabIndex = 20;
            this.btnRogVeih.Text = "Registrar vehiculo";
            this.btnRogVeih.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Location = new System.Drawing.Point(16, 15);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(43, 37);
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // RegisVehiculo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(804, 483);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnRogVeih);
            this.Controls.Add(this.cbTipoVehi);
            this.Controls.Add(this.cbPuestoVehi);
            this.Controls.Add(this.txtplaca);
            this.Controls.Add(this.txtcolor);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximumSize = new System.Drawing.Size(822, 530);
            this.MinimumSize = new System.Drawing.Size(822, 530);
            this.Name = "RegisVehiculo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.RegisVehiculo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtcolor;
        private System.Windows.Forms.TextBox txtplaca;
        private System.Windows.Forms.ComboBox cbPuestoVehi;
        private System.Windows.Forms.ComboBox cbTipoVehi;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnRogVeih;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}