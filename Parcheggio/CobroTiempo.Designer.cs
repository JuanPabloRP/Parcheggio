namespace Parcheggio
{
    partial class CobroTiempo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CobroTiempo));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCobrar = new System.Windows.Forms.Button();
            this.cbVehiculos = new System.Windows.Forms.ComboBox();
            this.btnVerTodos = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Location = new System.Drawing.Point(16, 15);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(43, 37);
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(249, 48);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(331, 46);
            this.label1.TabIndex = 15;
            this.label1.Text = "Cobro de tiempo";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.ErrorImage = null;
            this.pictureBox2.InitialImage = null;
            this.pictureBox2.Location = new System.Drawing.Point(217, 117);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(413, 283);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 16;
            this.pictureBox2.TabStop = false;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(305, 177);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 22);
            this.label2.TabIndex = 0;
            this.label2.Text = "Ingrese placa";
            // 
            // btnCobrar
            // 
            this.btnCobrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCobrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCobrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCobrar.ForeColor = System.Drawing.Color.Black;
            this.btnCobrar.Location = new System.Drawing.Point(355, 322);
            this.btnCobrar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCobrar.Name = "btnCobrar";
            this.btnCobrar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnCobrar.Size = new System.Drawing.Size(125, 34);
            this.btnCobrar.TabIndex = 20;
            this.btnCobrar.Text = "Cobrar";
            this.btnCobrar.UseVisualStyleBackColor = true;
            this.btnCobrar.Click += new System.EventHandler(this.btnCobrar_Click);
            // 
            // cbVehiculos
            // 
            this.cbVehiculos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbVehiculos.FormattingEnabled = true;
            this.cbVehiculos.Location = new System.Drawing.Point(309, 203);
            this.cbVehiculos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbVehiculos.Name = "cbVehiculos";
            this.cbVehiculos.Size = new System.Drawing.Size(227, 24);
            this.cbVehiculos.TabIndex = 22;
            // 
            // btnVerTodos
            // 
            this.btnVerTodos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnVerTodos.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnVerTodos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerTodos.ForeColor = System.Drawing.Color.Black;
            this.btnVerTodos.Location = new System.Drawing.Point(355, 422);
            this.btnVerTodos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnVerTodos.Name = "btnVerTodos";
            this.btnVerTodos.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnVerTodos.Size = new System.Drawing.Size(125, 34);
            this.btnVerTodos.TabIndex = 23;
            this.btnVerTodos.Text = "Ver info";
            this.btnVerTodos.UseVisualStyleBackColor = true;
            // 
            // CobroTiempo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(803, 481);
            this.Controls.Add(this.btnVerTodos);
            this.Controls.Add(this.cbVehiculos);
            this.Controls.Add(this.btnCobrar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximumSize = new System.Drawing.Size(821, 528);
            this.MinimumSize = new System.Drawing.Size(821, 528);
            this.Name = "CobroTiempo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CobroTiempo";
            this.Load += new System.EventHandler(this.CobroTiempo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCobrar;
        private System.Windows.Forms.ComboBox cbVehiculos;
        private System.Windows.Forms.Button btnVerTodos;
    }
}