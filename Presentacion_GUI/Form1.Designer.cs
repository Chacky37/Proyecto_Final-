namespace Presentacion_GUI
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
            this.buttoninicio = new System.Windows.Forms.Button();
            this.labelacceso = new System.Windows.Forms.Label();
            this.labelusuario = new System.Windows.Forms.Label();
            this.labelpassaword = new System.Windows.Forms.Label();
            this.buttonsalir = new System.Windows.Forms.Button();
            this.textBoxusuario = new System.Windows.Forms.TextBox();
            this.textBoxcontraseña = new System.Windows.Forms.TextBox();
            this.labelconfirmar = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttoninicio
            // 
            this.buttoninicio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.buttoninicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttoninicio.Location = new System.Drawing.Point(87, 255);
            this.buttoninicio.Name = "buttoninicio";
            this.buttoninicio.Size = new System.Drawing.Size(103, 23);
            this.buttoninicio.TabIndex = 0;
            this.buttoninicio.Text = "INICIAR SESIÓN";
            this.buttoninicio.UseVisualStyleBackColor = false;
            this.buttoninicio.Click += new System.EventHandler(this.buttoninicio_Click);
            // 
            // labelacceso
            // 
            this.labelacceso.AutoSize = true;
            this.labelacceso.BackColor = System.Drawing.Color.LavenderBlush;
            this.labelacceso.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelacceso.Location = new System.Drawing.Point(71, 36);
            this.labelacceso.Name = "labelacceso";
            this.labelacceso.Size = new System.Drawing.Size(122, 44);
            this.labelacceso.TabIndex = 1;
            this.labelacceso.Text = "INSERTE SU\r\n  USUARIO";
            // 
            // labelusuario
            // 
            this.labelusuario.AutoSize = true;
            this.labelusuario.BackColor = System.Drawing.Color.Yellow;
            this.labelusuario.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelusuario.Location = new System.Drawing.Point(29, 108);
            this.labelusuario.Name = "labelusuario";
            this.labelusuario.Size = new System.Drawing.Size(80, 21);
            this.labelusuario.TabIndex = 2;
            this.labelusuario.Text = "Usuario :";
            // 
            // labelpassaword
            // 
            this.labelpassaword.AutoSize = true;
            this.labelpassaword.BackColor = System.Drawing.Color.Yellow;
            this.labelpassaword.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelpassaword.Location = new System.Drawing.Point(21, 165);
            this.labelpassaword.Name = "labelpassaword";
            this.labelpassaword.Size = new System.Drawing.Size(108, 21);
            this.labelpassaword.TabIndex = 3;
            this.labelpassaword.Text = "Contraseña :";
            // 
            // buttonsalir
            // 
            this.buttonsalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.buttonsalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonsalir.Location = new System.Drawing.Point(87, 309);
            this.buttonsalir.Name = "buttonsalir";
            this.buttonsalir.Size = new System.Drawing.Size(103, 23);
            this.buttonsalir.TabIndex = 4;
            this.buttonsalir.Text = "EXIT";
            this.buttonsalir.UseVisualStyleBackColor = false;
            this.buttonsalir.Click += new System.EventHandler(this.buttonsalir_Click);
            // 
            // textBoxusuario
            // 
            this.textBoxusuario.Location = new System.Drawing.Point(141, 111);
            this.textBoxusuario.Name = "textBoxusuario";
            this.textBoxusuario.Size = new System.Drawing.Size(126, 20);
            this.textBoxusuario.TabIndex = 5;
            // 
            // textBoxcontraseña
            // 
            this.textBoxcontraseña.Location = new System.Drawing.Point(141, 166);
            this.textBoxcontraseña.Name = "textBoxcontraseña";
            this.textBoxcontraseña.Size = new System.Drawing.Size(126, 20);
            this.textBoxcontraseña.TabIndex = 6;
            // 
            // labelconfirmar
            // 
            this.labelconfirmar.AutoSize = true;
            this.labelconfirmar.Location = new System.Drawing.Point(113, 227);
            this.labelconfirmar.Name = "labelconfirmar";
            this.labelconfirmar.Size = new System.Drawing.Size(0, 13);
            this.labelconfirmar.TabIndex = 7;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Presentacion_GUI.Properties.Resources.vector_JUL_2021_73;
            this.pictureBox1.Location = new System.Drawing.Point(0, -2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(282, 347);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(279, 344);
            this.Controls.Add(this.labelconfirmar);
            this.Controls.Add(this.textBoxcontraseña);
            this.Controls.Add(this.textBoxusuario);
            this.Controls.Add(this.buttonsalir);
            this.Controls.Add(this.labelpassaword);
            this.Controls.Add(this.labelusuario);
            this.Controls.Add(this.labelacceso);
            this.Controls.Add(this.buttoninicio);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttoninicio;
        private System.Windows.Forms.Label labelacceso;
        private System.Windows.Forms.Label labelusuario;
        private System.Windows.Forms.Label labelpassaword;
        private System.Windows.Forms.Button buttonsalir;
        private System.Windows.Forms.TextBox textBoxusuario;
        private System.Windows.Forms.TextBox textBoxcontraseña;
        private System.Windows.Forms.Label labelconfirmar;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

