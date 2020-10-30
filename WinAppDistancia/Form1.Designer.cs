namespace WinAppDistancia
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.labelTitulo = new System.Windows.Forms.Label();
            this.labelX1 = new System.Windows.Forms.Label();
            this.labelX2 = new System.Windows.Forms.Label();
            this.labelY1 = new System.Windows.Forms.Label();
            this.labelY2 = new System.Windows.Forms.Label();
            this.textBoxX1 = new System.Windows.Forms.TextBox();
            this.textBoxY1 = new System.Windows.Forms.TextBox();
            this.textBoxX2 = new System.Windows.Forms.TextBox();
            this.textBoxY2 = new System.Windows.Forms.TextBox();
            this.buttonCalcular = new System.Windows.Forms.Button();
            this.labelResultado = new System.Windows.Forms.Label();
            this.groupBoxPunto1 = new System.Windows.Forms.GroupBox();
            this.groupBoxPunto2 = new System.Windows.Forms.GroupBox();
            this.groupBoxDistancia = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBoxPunto1.SuspendLayout();
            this.groupBoxPunto2.SuspendLayout();
            this.groupBoxDistancia.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelTitulo
            // 
            this.labelTitulo.AutoSize = true;
            this.labelTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitulo.Location = new System.Drawing.Point(130, 33);
            this.labelTitulo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTitulo.Name = "labelTitulo";
            this.labelTitulo.Size = new System.Drawing.Size(322, 29);
            this.labelTitulo.TabIndex = 0;
            this.labelTitulo.Text = "Distancia entre dos puntos";
            this.labelTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelTitulo.Click += new System.EventHandler(this.label1_Click);
            // 
            // labelX1
            // 
            this.labelX1.AutoSize = true;
            this.labelX1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX1.Location = new System.Drawing.Point(23, 41);
            this.labelX1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(50, 24);
            this.labelX1.TabIndex = 3;
            this.labelX1.Text = "X1= ";
            this.labelX1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // labelX2
            // 
            this.labelX2.AutoSize = true;
            this.labelX2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX2.Location = new System.Drawing.Point(23, 47);
            this.labelX2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(50, 24);
            this.labelX2.TabIndex = 4;
            this.labelX2.Text = "X2= ";
            this.labelX2.Click += new System.EventHandler(this.label1_Click_2);
            // 
            // labelY1
            // 
            this.labelY1.AutoSize = true;
            this.labelY1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelY1.Location = new System.Drawing.Point(201, 40);
            this.labelY1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelY1.Name = "labelY1";
            this.labelY1.Size = new System.Drawing.Size(48, 24);
            this.labelY1.TabIndex = 5;
            this.labelY1.Text = "Y1= ";
            // 
            // labelY2
            // 
            this.labelY2.AutoSize = true;
            this.labelY2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelY2.Location = new System.Drawing.Point(201, 48);
            this.labelY2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelY2.Name = "labelY2";
            this.labelY2.Size = new System.Drawing.Size(48, 24);
            this.labelY2.TabIndex = 6;
            this.labelY2.Text = "Y2= ";
            // 
            // textBoxX1
            // 
            this.textBoxX1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxX1.Location = new System.Drawing.Point(81, 40);
            this.textBoxX1.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxX1.Name = "textBoxX1";
            this.textBoxX1.Size = new System.Drawing.Size(76, 26);
            this.textBoxX1.TabIndex = 0;
            this.textBoxX1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxX1_KeyPress);
            // 
            // textBoxY1
            // 
            this.textBoxY1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxY1.Location = new System.Drawing.Point(257, 41);
            this.textBoxY1.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxY1.Name = "textBoxY1";
            this.textBoxY1.Size = new System.Drawing.Size(76, 26);
            this.textBoxY1.TabIndex = 8;
            this.textBoxY1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxY1_KeyPress);
            // 
            // textBoxX2
            // 
            this.textBoxX2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxX2.Location = new System.Drawing.Point(81, 47);
            this.textBoxX2.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxX2.Name = "textBoxX2";
            this.textBoxX2.Size = new System.Drawing.Size(76, 26);
            this.textBoxX2.TabIndex = 9;
            this.textBoxX2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxX2_KeyPress);
            // 
            // textBoxY2
            // 
            this.textBoxY2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxY2.Location = new System.Drawing.Point(257, 47);
            this.textBoxY2.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxY2.Name = "textBoxY2";
            this.textBoxY2.Size = new System.Drawing.Size(76, 26);
            this.textBoxY2.TabIndex = 10;
            this.textBoxY2.TextChanged += new System.EventHandler(this.textBoxY2_TextChanged);
            this.textBoxY2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxY2_KeyPress);
            // 
            // buttonCalcular
            // 
            this.buttonCalcular.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(221)))), ((int)(((byte)(230)))));
            this.buttonCalcular.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCalcular.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(131)))), ((int)(((byte)(129)))));
            this.buttonCalcular.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(131)))), ((int)(((byte)(129)))));
            this.buttonCalcular.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(131)))), ((int)(((byte)(129)))));
            this.buttonCalcular.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCalcular.Location = new System.Drawing.Point(151, 338);
            this.buttonCalcular.Margin = new System.Windows.Forms.Padding(2);
            this.buttonCalcular.Name = "buttonCalcular";
            this.buttonCalcular.Size = new System.Drawing.Size(152, 51);
            this.buttonCalcular.TabIndex = 11;
            this.buttonCalcular.Text = "Calcular";
            this.buttonCalcular.UseVisualStyleBackColor = false;
            this.buttonCalcular.Click += new System.EventHandler(this.buttonCalcular_Click);
            // 
            // labelResultado
            // 
            this.labelResultado.AutoSize = true;
            this.labelResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelResultado.Location = new System.Drawing.Point(31, 44);
            this.labelResultado.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelResultado.Name = "labelResultado";
            this.labelResultado.Size = new System.Drawing.Size(82, 31);
            this.labelResultado.TabIndex = 13;
            this.labelResultado.Text = "0,000";
            // 
            // groupBoxPunto1
            // 
            this.groupBoxPunto1.Controls.Add(this.textBoxX1);
            this.groupBoxPunto1.Controls.Add(this.labelX1);
            this.groupBoxPunto1.Controls.Add(this.labelY1);
            this.groupBoxPunto1.Controls.Add(this.textBoxY1);
            this.groupBoxPunto1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxPunto1.Location = new System.Drawing.Point(29, 84);
            this.groupBoxPunto1.Name = "groupBoxPunto1";
            this.groupBoxPunto1.Size = new System.Drawing.Size(379, 100);
            this.groupBoxPunto1.TabIndex = 14;
            this.groupBoxPunto1.TabStop = false;
            this.groupBoxPunto1.Text = "Punto 1";
            this.groupBoxPunto1.Enter += new System.EventHandler(this.groupBoxPunto1_Enter);
            // 
            // groupBoxPunto2
            // 
            this.groupBoxPunto2.Controls.Add(this.textBoxX2);
            this.groupBoxPunto2.Controls.Add(this.labelX2);
            this.groupBoxPunto2.Controls.Add(this.labelY2);
            this.groupBoxPunto2.Controls.Add(this.textBoxY2);
            this.groupBoxPunto2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxPunto2.Location = new System.Drawing.Point(29, 210);
            this.groupBoxPunto2.Name = "groupBoxPunto2";
            this.groupBoxPunto2.Size = new System.Drawing.Size(379, 100);
            this.groupBoxPunto2.TabIndex = 15;
            this.groupBoxPunto2.TabStop = false;
            this.groupBoxPunto2.Text = "Punto 2";
            // 
            // groupBoxDistancia
            // 
            this.groupBoxDistancia.Controls.Add(this.labelResultado);
            this.groupBoxDistancia.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxDistancia.Location = new System.Drawing.Point(424, 275);
            this.groupBoxDistancia.Name = "groupBoxDistancia";
            this.groupBoxDistancia.Size = new System.Drawing.Size(146, 100);
            this.groupBoxDistancia.TabIndex = 16;
            this.groupBoxDistancia.TabStop = false;
            this.groupBoxDistancia.Text = "Distancia";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WinAppDistancia.Properties.Resources.puntos;
            this.pictureBox1.Location = new System.Drawing.Point(396, 125);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(194, 132);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(221)))), ((int)(((byte)(230)))));
            this.ClientSize = new System.Drawing.Size(602, 407);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBoxDistancia);
            this.Controls.Add(this.groupBoxPunto2);
            this.Controls.Add(this.groupBoxPunto1);
            this.Controls.Add(this.buttonCalcular);
            this.Controls.Add(this.labelTitulo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Distancia entre dos puntos";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBoxPunto1.ResumeLayout(false);
            this.groupBoxPunto1.PerformLayout();
            this.groupBoxPunto2.ResumeLayout(false);
            this.groupBoxPunto2.PerformLayout();
            this.groupBoxDistancia.ResumeLayout(false);
            this.groupBoxDistancia.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitulo;
        private System.Windows.Forms.Label labelX1;
        private System.Windows.Forms.Label labelX2;
        private System.Windows.Forms.Label labelY1;
        private System.Windows.Forms.Label labelY2;
        private System.Windows.Forms.TextBox textBoxX1;
        private System.Windows.Forms.TextBox textBoxY1;
        private System.Windows.Forms.TextBox textBoxX2;
        private System.Windows.Forms.TextBox textBoxY2;
        private System.Windows.Forms.Button buttonCalcular;
        private System.Windows.Forms.Label labelResultado;
        private System.Windows.Forms.GroupBox groupBoxPunto1;
        private System.Windows.Forms.GroupBox groupBoxPunto2;
        private System.Windows.Forms.GroupBox groupBoxDistancia;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

