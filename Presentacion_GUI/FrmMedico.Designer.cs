namespace Presentacion_GUI
{
    partial class FrmMedico
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.cmbEspecialidad = new System.Windows.Forms.ComboBox();
            this.cmbCiudad = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.dtpNacimiento = new System.Windows.Forms.DateTimePicker();
            this.label12 = new System.Windows.Forms.Label();
            this.dtpGraduacion = new System.Windows.Forms.DateTimePicker();
            this.buttonActualizar = new System.Windows.Forms.Button();
            this.buttonNuevo = new System.Windows.Forms.Button();
            this.buttonAgregar = new System.Windows.Forms.Button();
            this.buttonEliminar = new System.Windows.Forms.Button();
            this.textBoxTelefono = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxCorreo = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.labelid = new System.Windows.Forms.Label();
            this.labelnombre = new System.Windows.Forms.Label();
            this.textBoxSegundoNombre = new System.Windows.Forms.TextBox();
            this.textBoxPrimerApellido = new System.Windows.Forms.TextBox();
            this.textBoxSegundoApellido = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxId = new System.Windows.Forms.TextBox();
            this.textBoxPrimerNombre = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.TxtFiltrar = new System.Windows.Forms.TextBox();
            this.buttonFiltar = new System.Windows.Forms.Button();
            this.GrillaMed = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PNomber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PApellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SApellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Edad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Corr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Especialidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Años = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ciu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonSalir = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxFacultad = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GrillaMed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(33, 69);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(576, 457);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Controls.Add(this.textBoxFacultad);
            this.tabPage1.Controls.Add(this.cmbEspecialidad);
            this.tabPage1.Controls.Add(this.cmbCiudad);
            this.tabPage1.Controls.Add(this.label14);
            this.tabPage1.Controls.Add(this.dtpNacimiento);
            this.tabPage1.Controls.Add(this.label12);
            this.tabPage1.Controls.Add(this.dtpGraduacion);
            this.tabPage1.Controls.Add(this.buttonActualizar);
            this.tabPage1.Controls.Add(this.buttonNuevo);
            this.tabPage1.Controls.Add(this.buttonAgregar);
            this.tabPage1.Controls.Add(this.buttonEliminar);
            this.tabPage1.Controls.Add(this.textBoxTelefono);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.textBoxCorreo);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.labelid);
            this.tabPage1.Controls.Add(this.labelnombre);
            this.tabPage1.Controls.Add(this.textBoxSegundoNombre);
            this.tabPage1.Controls.Add(this.textBoxPrimerApellido);
            this.tabPage1.Controls.Add(this.textBoxSegundoApellido);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.textBoxId);
            this.tabPage1.Controls.Add(this.textBoxPrimerNombre);
            this.tabPage1.Controls.Add(this.pictureBox2);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(568, 431);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Gestion";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // cmbEspecialidad
            // 
            this.cmbEspecialidad.FormattingEnabled = true;
            this.cmbEspecialidad.Location = new System.Drawing.Point(441, 143);
            this.cmbEspecialidad.Name = "cmbEspecialidad";
            this.cmbEspecialidad.Size = new System.Drawing.Size(105, 21);
            this.cmbEspecialidad.TabIndex = 118;
            // 
            // cmbCiudad
            // 
            this.cmbCiudad.FormattingEnabled = true;
            this.cmbCiudad.Location = new System.Drawing.Point(441, 82);
            this.cmbCiudad.Name = "cmbCiudad";
            this.cmbCiudad.Size = new System.Drawing.Size(105, 21);
            this.cmbCiudad.TabIndex = 117;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.LightPink;
            this.label14.Font = new System.Drawing.Font("Maiandra GD", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(357, 84);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(64, 16);
            this.label14.TabIndex = 116;
            this.label14.Text = "Ciudad :";
            // 
            // dtpNacimiento
            // 
            this.dtpNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNacimiento.Location = new System.Drawing.Point(441, 22);
            this.dtpNacimiento.Name = "dtpNacimiento";
            this.dtpNacimiento.Size = new System.Drawing.Size(105, 20);
            this.dtpNacimiento.TabIndex = 113;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.LightPink;
            this.label12.Font = new System.Drawing.Font("Maiandra GD", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(326, 17);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(91, 32);
            this.label12.TabIndex = 112;
            this.label12.Text = "  Fecha De\r\nNacimiento :";
            // 
            // dtpGraduacion
            // 
            this.dtpGraduacion.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpGraduacion.Location = new System.Drawing.Point(441, 264);
            this.dtpGraduacion.Name = "dtpGraduacion";
            this.dtpGraduacion.Size = new System.Drawing.Size(105, 20);
            this.dtpGraduacion.TabIndex = 111;
            // 
            // buttonActualizar
            // 
            this.buttonActualizar.Font = new System.Drawing.Font("Segoe UI Symbol", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonActualizar.ForeColor = System.Drawing.Color.Black;
            this.buttonActualizar.Location = new System.Drawing.Point(450, 320);
            this.buttonActualizar.Name = "buttonActualizar";
            this.buttonActualizar.Size = new System.Drawing.Size(96, 29);
            this.buttonActualizar.TabIndex = 109;
            this.buttonActualizar.Text = "Actualizar";
            this.buttonActualizar.UseVisualStyleBackColor = true;
            this.buttonActualizar.Click += new System.EventHandler(this.buttonActualizar_Click);
            // 
            // buttonNuevo
            // 
            this.buttonNuevo.Font = new System.Drawing.Font("Segoe UI Symbol", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNuevo.ForeColor = System.Drawing.Color.Black;
            this.buttonNuevo.Location = new System.Drawing.Point(329, 320);
            this.buttonNuevo.Name = "buttonNuevo";
            this.buttonNuevo.Size = new System.Drawing.Size(73, 29);
            this.buttonNuevo.TabIndex = 108;
            this.buttonNuevo.Text = "Nuevo";
            this.buttonNuevo.UseVisualStyleBackColor = true;
            this.buttonNuevo.Click += new System.EventHandler(this.buttonNuevo_Click);
            // 
            // buttonAgregar
            // 
            this.buttonAgregar.Font = new System.Drawing.Font("Segoe UI Symbol", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAgregar.ForeColor = System.Drawing.Color.Black;
            this.buttonAgregar.Location = new System.Drawing.Point(329, 389);
            this.buttonAgregar.Name = "buttonAgregar";
            this.buttonAgregar.Size = new System.Drawing.Size(78, 29);
            this.buttonAgregar.TabIndex = 107;
            this.buttonAgregar.Text = "Agregar";
            this.buttonAgregar.UseVisualStyleBackColor = true;
            this.buttonAgregar.Click += new System.EventHandler(this.buttonAgregar_Click);
            // 
            // buttonEliminar
            // 
            this.buttonEliminar.Font = new System.Drawing.Font("Segoe UI Symbol", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEliminar.ForeColor = System.Drawing.Color.Black;
            this.buttonEliminar.Location = new System.Drawing.Point(463, 389);
            this.buttonEliminar.Name = "buttonEliminar";
            this.buttonEliminar.Size = new System.Drawing.Size(83, 29);
            this.buttonEliminar.TabIndex = 106;
            this.buttonEliminar.Text = "Eliminar";
            this.buttonEliminar.UseVisualStyleBackColor = true;
            this.buttonEliminar.Click += new System.EventHandler(this.buttonEliminar_Click);
            // 
            // textBoxTelefono
            // 
            this.textBoxTelefono.Location = new System.Drawing.Point(156, 329);
            this.textBoxTelefono.Name = "textBoxTelefono";
            this.textBoxTelefono.Size = new System.Drawing.Size(105, 20);
            this.textBoxTelefono.TabIndex = 103;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.LightPink;
            this.label8.Font = new System.Drawing.Font("Maiandra GD", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(60, 331);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 16);
            this.label8.TabIndex = 102;
            this.label8.Text = "Telefono :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.LightPink;
            this.label6.Font = new System.Drawing.Font("Maiandra GD", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(318, 145);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 16);
            this.label6.TabIndex = 94;
            this.label6.Text = "Especialidad :";
            // 
            // textBoxCorreo
            // 
            this.textBoxCorreo.Location = new System.Drawing.Point(156, 387);
            this.textBoxCorreo.Name = "textBoxCorreo";
            this.textBoxCorreo.Size = new System.Drawing.Size(105, 20);
            this.textBoxCorreo.TabIndex = 100;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.LightPink;
            this.label7.Font = new System.Drawing.Font("Maiandra GD", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(306, 194);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(109, 32);
            this.label7.TabIndex = 98;
            this.label7.Text = "Facultad donde\r\n   Se Graduo: ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.LightPink;
            this.label9.Font = new System.Drawing.Font("Maiandra GD", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(72, 389);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(64, 16);
            this.label9.TabIndex = 97;
            this.label9.Text = "Correo :";
            // 
            // labelid
            // 
            this.labelid.AutoSize = true;
            this.labelid.BackColor = System.Drawing.Color.LightPink;
            this.labelid.Font = new System.Drawing.Font("Maiandra GD", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelid.Location = new System.Drawing.Point(73, 24);
            this.labelid.Name = "labelid";
            this.labelid.Size = new System.Drawing.Size(62, 16);
            this.labelid.TabIndex = 83;
            this.labelid.Text = "Cedula :";
            // 
            // labelnombre
            // 
            this.labelnombre.AutoSize = true;
            this.labelnombre.BackColor = System.Drawing.Color.LightPink;
            this.labelnombre.Font = new System.Drawing.Font("Maiandra GD", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelnombre.Location = new System.Drawing.Point(18, 84);
            this.labelnombre.Name = "labelnombre";
            this.labelnombre.Size = new System.Drawing.Size(118, 16);
            this.labelnombre.TabIndex = 84;
            this.labelnombre.Text = "Primer Nombre :";
            // 
            // textBoxSegundoNombre
            // 
            this.textBoxSegundoNombre.Location = new System.Drawing.Point(156, 143);
            this.textBoxSegundoNombre.Name = "textBoxSegundoNombre";
            this.textBoxSegundoNombre.Size = new System.Drawing.Size(105, 20);
            this.textBoxSegundoNombre.TabIndex = 92;
            // 
            // textBoxPrimerApellido
            // 
            this.textBoxPrimerApellido.Location = new System.Drawing.Point(156, 204);
            this.textBoxPrimerApellido.Name = "textBoxPrimerApellido";
            this.textBoxPrimerApellido.Size = new System.Drawing.Size(105, 20);
            this.textBoxPrimerApellido.TabIndex = 91;
            // 
            // textBoxSegundoApellido
            // 
            this.textBoxSegundoApellido.Location = new System.Drawing.Point(156, 267);
            this.textBoxSegundoApellido.Name = "textBoxSegundoApellido";
            this.textBoxSegundoApellido.Size = new System.Drawing.Size(105, 20);
            this.textBoxSegundoApellido.TabIndex = 90;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.LightPink;
            this.label3.Font = new System.Drawing.Font("Maiandra GD", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(16, 206);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 16);
            this.label3.TabIndex = 89;
            this.label3.Text = "Primer Apellido :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.LightPink;
            this.label2.Font = new System.Drawing.Font("Maiandra GD", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(4, 272);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 16);
            this.label2.TabIndex = 88;
            this.label2.Text = "Segundo Apellido:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.LightPink;
            this.label1.Font = new System.Drawing.Font("Maiandra GD", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 145);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 16);
            this.label1.TabIndex = 87;
            this.label1.Text = "Segundo Nombre:";
            // 
            // textBoxId
            // 
            this.textBoxId.Location = new System.Drawing.Point(156, 22);
            this.textBoxId.Name = "textBoxId";
            this.textBoxId.Size = new System.Drawing.Size(105, 20);
            this.textBoxId.TabIndex = 85;
            // 
            // textBoxPrimerNombre
            // 
            this.textBoxPrimerNombre.Location = new System.Drawing.Point(156, 82);
            this.textBoxPrimerNombre.Name = "textBoxPrimerNombre";
            this.textBoxPrimerNombre.Size = new System.Drawing.Size(105, 20);
            this.textBoxPrimerNombre.TabIndex = 86;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.TxtFiltrar);
            this.tabPage2.Controls.Add(this.buttonFiltar);
            this.tabPage2.Controls.Add(this.GrillaMed);
            this.tabPage2.Controls.Add(this.pictureBox3);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(568, 431);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Listado De Medicos";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // TxtFiltrar
            // 
            this.TxtFiltrar.Location = new System.Drawing.Point(573, 18);
            this.TxtFiltrar.Name = "TxtFiltrar";
            this.TxtFiltrar.Size = new System.Drawing.Size(131, 20);
            this.TxtFiltrar.TabIndex = 28;
            this.TxtFiltrar.TextChanged += new System.EventHandler(this.TxtFiltrar_TextChanged);
            // 
            // buttonFiltar
            // 
            this.buttonFiltar.Location = new System.Drawing.Point(728, 16);
            this.buttonFiltar.Name = "buttonFiltar";
            this.buttonFiltar.Size = new System.Drawing.Size(75, 23);
            this.buttonFiltar.TabIndex = 27;
            this.buttonFiltar.Text = "Filtrar";
            this.buttonFiltar.UseVisualStyleBackColor = true;
            this.buttonFiltar.Click += new System.EventHandler(this.buttonFiltar_Click);
            // 
            // GrillaMed
            // 
            this.GrillaMed.AllowUserToOrderColumns = true;
            this.GrillaMed.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GrillaMed.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.PNomber,
            this.SNombre,
            this.PApellido,
            this.SApellido,
            this.Edad,
            this.Tel,
            this.Corr,
            this.Especialidad,
            this.Años,
            this.Ciu});
            this.GrillaMed.Location = new System.Drawing.Point(19, 56);
            this.GrillaMed.Name = "GrillaMed";
            this.GrillaMed.Size = new System.Drawing.Size(785, 255);
            this.GrillaMed.TabIndex = 0;
            // 
            // Id
            // 
            this.Id.HeaderText = "Identificación";
            this.Id.Name = "Id";
            // 
            // PNomber
            // 
            this.PNomber.HeaderText = "Primer Nombre";
            this.PNomber.Name = "PNomber";
            // 
            // SNombre
            // 
            this.SNombre.HeaderText = "Segundo Nombre";
            this.SNombre.Name = "SNombre";
            // 
            // PApellido
            // 
            this.PApellido.HeaderText = "Primer Apellido";
            this.PApellido.Name = "PApellido";
            // 
            // SApellido
            // 
            this.SApellido.HeaderText = "Segundo Apellido";
            this.SApellido.Name = "SApellido";
            // 
            // Edad
            // 
            this.Edad.HeaderText = "Edad";
            this.Edad.Name = "Edad";
            // 
            // Tel
            // 
            this.Tel.HeaderText = "Telefono";
            this.Tel.Name = "Tel";
            // 
            // Corr
            // 
            this.Corr.HeaderText = "Correo";
            this.Corr.Name = "Corr";
            // 
            // Especialidad
            // 
            this.Especialidad.HeaderText = "Especialidad";
            this.Especialidad.Name = "Especialidad";
            // 
            // Años
            // 
            this.Años.HeaderText = "Años De Experiencia";
            this.Años.Name = "Años";
            // 
            // Ciu
            // 
            this.Ciu.HeaderText = "Ciudad De Nacimiento";
            this.Ciu.Name = "Ciu";
            this.Ciu.ReadOnly = true;
            // 
            // buttonSalir
            // 
            this.buttonSalir.Font = new System.Drawing.Font("Segoe UI Symbol", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSalir.Location = new System.Drawing.Point(522, 543);
            this.buttonSalir.Name = "buttonSalir";
            this.buttonSalir.Size = new System.Drawing.Size(83, 29);
            this.buttonSalir.TabIndex = 107;
            this.buttonSalir.Text = "Exit";
            this.buttonSalir.UseVisualStyleBackColor = true;
            this.buttonSalir.Click += new System.EventHandler(this.buttonSalir_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label4.Font = new System.Drawing.Font("Lucida Handwriting", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Blue;
            this.label4.Location = new System.Drawing.Point(140, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(392, 38);
            this.label4.TabIndex = 108;
            this.label4.Text = "Hospital San Fernando";
            // 
            // textBoxFacultad
            // 
            this.textBoxFacultad.Location = new System.Drawing.Point(441, 201);
            this.textBoxFacultad.Name = "textBoxFacultad";
            this.textBoxFacultad.Size = new System.Drawing.Size(105, 20);
            this.textBoxFacultad.TabIndex = 119;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.LightPink;
            this.label10.Font = new System.Drawing.Font("Maiandra GD", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(326, 262);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(93, 32);
            this.label10.TabIndex = 121;
            this.label10.Text = " Fecha de\r\nGraduacion :";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Presentacion_GUI.Properties.Resources.R6TUEN5PBZBNLOK3C5UZ4C6AAQ;
            this.pictureBox1.Location = new System.Drawing.Point(1, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(637, 583);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 109;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Presentacion_GUI.Properties.Resources.vector_JUL_2021_73;
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(568, 440);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 122;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Presentacion_GUI.Properties.Resources.vector_JUL_2021_73;
            this.pictureBox3.Location = new System.Drawing.Point(0, 0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(567, 434);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 29;
            this.pictureBox3.TabStop = false;
            // 
            // FrmMedico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(639, 584);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.buttonSalir);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "FrmMedico";
            this.Text = "Gestión Medicos";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmMedico_FormClosing);
            this.Load += new System.EventHandler(this.FrmMedico_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GrillaMed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox textBoxTelefono;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxCorreo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label labelid;
        private System.Windows.Forms.Label labelnombre;
        private System.Windows.Forms.TextBox textBoxSegundoNombre;
        private System.Windows.Forms.TextBox textBoxPrimerApellido;
        private System.Windows.Forms.TextBox textBoxSegundoApellido;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxId;
        private System.Windows.Forms.TextBox textBoxPrimerNombre;
        private System.Windows.Forms.Button buttonActualizar;
        private System.Windows.Forms.Button buttonNuevo;
        private System.Windows.Forms.Button buttonAgregar;
        private System.Windows.Forms.Button buttonEliminar;
        private System.Windows.Forms.DataGridView GrillaMed;
        private System.Windows.Forms.Button buttonSalir;
        private System.Windows.Forms.TextBox TxtFiltrar;
        private System.Windows.Forms.Button buttonFiltar;
        private System.Windows.Forms.DateTimePicker dtpGraduacion;
        private System.Windows.Forms.ComboBox cmbEspecialidad;
        private System.Windows.Forms.ComboBox cmbCiudad;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DateTimePicker dtpNacimiento;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn PNomber;
        private System.Windows.Forms.DataGridViewTextBoxColumn SNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn PApellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn SApellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn Edad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tel;
        private System.Windows.Forms.DataGridViewTextBoxColumn Corr;
        private System.Windows.Forms.DataGridViewTextBoxColumn Especialidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Años;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ciu;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBoxFacultad;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}