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
            this.Cbtipo = new System.Windows.Forms.ComboBox();
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
            this.label1.Location = new System.Drawing.Point(288, 154);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
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
            this.label2.Location = new System.Drawing.Point(696, 154);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
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
            this.label3.Location = new System.Drawing.Point(290, 304);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
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
            this.label4.Location = new System.Drawing.Point(696, 304);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Asignar puesto";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(360, 29);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(357, 46);
            this.label5.TabIndex = 4;
            this.label5.Text = "Registrar vehiculo";
            // 
            // txtcolor
            // 
            this.txtcolor.Location = new System.Drawing.Point(699, 186);
            this.txtcolor.Margin = new System.Windows.Forms.Padding(5, 2, 5, 2);
            this.txtcolor.Name = "txtcolor";
            this.txtcolor.Size = new System.Drawing.Size(123, 22);
            this.txtcolor.TabIndex = 6;
            // 
            // txtplaca
            // 
            this.txtplaca.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtplaca.Location = new System.Drawing.Point(282, 186);
            this.txtplaca.Margin = new System.Windows.Forms.Padding(5, 2, 5, 2);
            this.txtplaca.MaxLength = 6;
            this.txtplaca.Name = "txtplaca";
            this.txtplaca.Size = new System.Drawing.Size(131, 22);
            this.txtplaca.TabIndex = 7;
            // 
            // cbPuestoVehi
            // 
            this.cbPuestoVehi.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.cbPuestoVehi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPuestoVehi.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbPuestoVehi.FormattingEnabled = true;
            this.cbPuestoVehi.Location = new System.Drawing.Point(699, 342);
            this.cbPuestoVehi.Margin = new System.Windows.Forms.Padding(5, 2, 5, 2);
            this.cbPuestoVehi.Name = "cbPuestoVehi";
            this.cbPuestoVehi.Size = new System.Drawing.Size(137, 24);
            this.cbPuestoVehi.TabIndex = 8;
            this.cbPuestoVehi.SelectedIndexChanged += new System.EventHandler(this.cbPuestoVehi_SelectedIndexChanged);
            // 
            // Cbtipo
            // 
            this.Cbtipo.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.Cbtipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cbtipo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Cbtipo.FormattingEnabled = true;
            this.Cbtipo.Items.AddRange(new object[] {
            "Motocicleta",
            "Automovil"});
            this.Cbtipo.Location = new System.Drawing.Point(282, 342);
            this.Cbtipo.Margin = new System.Windows.Forms.Padding(5, 2, 5, 2);
            this.Cbtipo.Name = "Cbtipo";
            this.Cbtipo.Size = new System.Drawing.Size(142, 24);
            this.Cbtipo.TabIndex = 9;
            this.Cbtipo.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.ErrorImage = null;
            this.pictureBox2.InitialImage = null;
            this.pictureBox2.Location = new System.Drawing.Point(172, 99);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(734, 413);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 19;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // btnRogVeih
            // 
            this.btnRogVeih.Location = new System.Drawing.Point(462, 425);
            this.btnRogVeih.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.btnRogVeih.Name = "btnRogVeih";
            this.btnRogVeih.Size = new System.Drawing.Size(157, 43);
            this.btnRogVeih.TabIndex = 20;
            this.btnRogVeih.Text = "Registrar vehiculo";
            this.btnRogVeih.UseVisualStyleBackColor = true;
            this.btnRogVeih.Click += new System.EventHandler(this.btnRogVeih_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Location = new System.Drawing.Point(21, 18);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
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
            this.ClientSize = new System.Drawing.Size(1072, 594);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnRogVeih);
            this.Controls.Add(this.Cbtipo);
            this.Controls.Add(this.cbPuestoVehi);
            this.Controls.Add(this.txtplaca);
            this.Controls.Add(this.txtcolor);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.Margin = new System.Windows.Forms.Padding(5, 2, 5, 2);
            this.MaximumSize = new System.Drawing.Size(1090, 641);
            this.MinimumSize = new System.Drawing.Size(1090, 641);
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
        private System.Windows.Forms.ComboBox Cbtipo;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnRogVeih;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}