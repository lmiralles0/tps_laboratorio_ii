﻿namespace Front
{
    partial class Form2
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
            this.components = new System.ComponentModel.Container();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.linkLabelRa = new System.Windows.Forms.LinkLabel();
            this.linkLabelAm = new System.Windows.Forms.LinkLabel();
            this.linkLabelAp = new System.Windows.Forms.LinkLabel();
            this.linkLabelAu = new System.Windows.Forms.LinkLabel();
            this.groupBoxRa = new System.Windows.Forms.GroupBox();
            this.labelRa = new System.Windows.Forms.Label();
            this.comboBoxMateriasRa = new System.Windows.Forms.ComboBox();
            this.materiaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comboBoxRegularRa = new System.Windows.Forms.ComboBox();
            this.comboBoxAlumnosRa = new System.Windows.Forms.ComboBox();
            this.alumnoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.buttonAgregarRa = new System.Windows.Forms.Button();
            this.buttonCerrarRa = new System.Windows.Forms.Button();
            this.groupBoxAlta = new System.Windows.Forms.GroupBox();
            this.buttonCerrarAlta = new System.Windows.Forms.Button();
            this.labelUser = new System.Windows.Forms.Label();
            this.labelPasswd = new System.Windows.Forms.Label();
            this.AltaTextBoxUserPasswd = new System.Windows.Forms.TextBox();
            this.labelLastName = new System.Windows.Forms.Label();
            this.AltaTextBoxUserDni = new System.Windows.Forms.TextBox();
            this.AltaTextBoxUserSureName = new System.Windows.Forms.TextBox();
            this.AltaTextBoxUserName = new System.Windows.Forms.TextBox();
            this.AltaUserComboBox = new System.Windows.Forms.ComboBox();
            this.labelDni = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.buttonAgregarAlta = new System.Windows.Forms.Button();
            this.groupBoxAm = new System.Windows.Forms.GroupBox();
            this.labelCorrelativaAm = new System.Windows.Forms.Label();
            this.checkBoxCorrelativa1 = new System.Windows.Forms.CheckBox();
            this.textBoxCodigoAm = new System.Windows.Forms.TextBox();
            this.comboBoxSeleccionarMateriaAm = new System.Windows.Forms.ComboBox();
            this.labelNombreMateriaAm = new System.Windows.Forms.Label();
            this.buttonCerrarAm = new System.Windows.Forms.Button();
            this.buttonAgregarAm = new System.Windows.Forms.Button();
            this.textBoxNombreAm = new System.Windows.Forms.TextBox();
            this.groupBoxAp = new System.Windows.Forms.GroupBox();
            this.labelMateriaSeleccionar = new System.Windows.Forms.Label();
            this.labelProfesorSeleccionar = new System.Windows.Forms.Label();
            this.comboBoxProfesorAp = new System.Windows.Forms.ComboBox();
            this.profesorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.buttonCerrarAp = new System.Windows.Forms.Button();
            this.buttonAgregarAp = new System.Windows.Forms.Button();
            this.comboBoxMateriasAp = new System.Windows.Forms.ComboBox();
            this.groupBoxLinkLabelAltaU = new System.Windows.Forms.GroupBox();
            this.linkLabelAu2 = new System.Windows.Forms.LinkLabel();
            this.groupBoxLinkLabelRa = new System.Windows.Forms.GroupBox();
            this.linkLabelRa2 = new System.Windows.Forms.LinkLabel();
            this.groupBoxLinkAm = new System.Windows.Forms.GroupBox();
            this.linkLabelAm2 = new System.Windows.Forms.LinkLabel();
            this.groupBoxGeneral = new System.Windows.Forms.GroupBox();
            this.groupBoxLinkAp = new System.Windows.Forms.GroupBox();
            this.linkLabelAp2 = new System.Windows.Forms.LinkLabel();
            this.menuStrip1.SuspendLayout();
            this.groupBoxRa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.materiaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alumnoBindingSource)).BeginInit();
            this.groupBoxAlta.SuspendLayout();
            this.groupBoxAm.SuspendLayout();
            this.groupBoxAp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.profesorBindingSource)).BeginInit();
            this.groupBoxLinkLabelAltaU.SuspendLayout();
            this.groupBoxLinkLabelRa.SuspendLayout();
            this.groupBoxLinkAm.SuspendLayout();
            this.groupBoxGeneral.SuspendLayout();
            this.groupBoxLinkAp.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripMenuItem1.Checked = true;
            this.toolStripMenuItem1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2,
            this.toolStripMenuItem3});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(34, 20);
            this.toolStripMenuItem1.Text = "***";
            this.toolStripMenuItem1.MouseHover += new System.EventHandler(this.toolStripMenuItem1_MouseHover);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(167, 22);
            this.toolStripMenuItem2.Text = "Modificar usuario";
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(167, 22);
            this.toolStripMenuItem3.Text = "Cerrar sesion";
            this.toolStripMenuItem3.Click += new System.EventHandler(this.toolStripMenuItem3_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip1.Size = new System.Drawing.Size(619, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // linkLabelRa
            // 
            this.linkLabelRa.AutoSize = true;
            this.linkLabelRa.Location = new System.Drawing.Point(6, 109);
            this.linkLabelRa.Name = "linkLabelRa";
            this.linkLabelRa.Size = new System.Drawing.Size(119, 15);
            this.linkLabelRa.TabIndex = 2;
            this.linkLabelRa.TabStop = true;
            this.linkLabelRa.Text = "Regularidad alumnos";
            this.linkLabelRa.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelRa_LinkClicked);
            // 
            // linkLabelAm
            // 
            this.linkLabelAm.AutoSize = true;
            this.linkLabelAm.Location = new System.Drawing.Point(6, 185);
            this.linkLabelAm.Name = "linkLabelAm";
            this.linkLabelAm.Size = new System.Drawing.Size(76, 15);
            this.linkLabelAm.TabIndex = 3;
            this.linkLabelAm.TabStop = true;
            this.linkLabelAm.Text = "Alta materias";
            this.linkLabelAm.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelAm_LinkClicked);
            // 
            // linkLabelAp
            // 
            this.linkLabelAp.AutoSize = true;
            this.linkLabelAp.Location = new System.Drawing.Point(6, 247);
            this.linkLabelAp.Name = "linkLabelAp";
            this.linkLabelAp.Size = new System.Drawing.Size(124, 15);
            this.linkLabelAp.TabIndex = 4;
            this.linkLabelAp.TabStop = true;
            this.linkLabelAp.Text = "Asignacion profesores";
            this.linkLabelAp.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelAp_LinkClicked);
            // 
            // linkLabelAu
            // 
            this.linkLabelAu.AutoSize = true;
            this.linkLabelAu.Location = new System.Drawing.Point(6, 28);
            this.linkLabelAu.Name = "linkLabelAu";
            this.linkLabelAu.Size = new System.Drawing.Size(75, 15);
            this.linkLabelAu.TabIndex = 1;
            this.linkLabelAu.TabStop = true;
            this.linkLabelAu.Text = "Alta usuarios";
            this.linkLabelAu.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelAu_LinkClicked_1);
            // 
            // groupBoxRa
            // 
            this.groupBoxRa.Controls.Add(this.labelRa);
            this.groupBoxRa.Controls.Add(this.comboBoxMateriasRa);
            this.groupBoxRa.Controls.Add(this.comboBoxRegularRa);
            this.groupBoxRa.Controls.Add(this.comboBoxAlumnosRa);
            this.groupBoxRa.Controls.Add(this.buttonAgregarRa);
            this.groupBoxRa.Controls.Add(this.buttonCerrarRa);
            this.groupBoxRa.Location = new System.Drawing.Point(220, 0);
            this.groupBoxRa.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.groupBoxRa.Name = "groupBoxRa";
            this.groupBoxRa.Size = new System.Drawing.Size(256, 300);
            this.groupBoxRa.TabIndex = 21;
            this.groupBoxRa.TabStop = false;
            this.groupBoxRa.Visible = false;
            // 
            // labelRa
            // 
            this.labelRa.AutoSize = true;
            this.labelRa.Font = new System.Drawing.Font("Segoe UI", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.labelRa.Location = new System.Drawing.Point(33, 19);
            this.labelRa.Name = "labelRa";
            this.labelRa.Size = new System.Drawing.Size(209, 17);
            this.labelRa.TabIndex = 22;
            this.labelRa.Text = "Regularidad alumno por materia";
            this.labelRa.Visible = false;
            // 
            // comboBoxMateriasRa
            // 
            this.comboBoxMateriasRa.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.materiaBindingSource, "SelectedMateria", true));
            this.comboBoxMateriasRa.DataSource = this.materiaBindingSource;
            this.comboBoxMateriasRa.DisplayMember = "SelectedMateria";
            this.comboBoxMateriasRa.Enabled = false;
            this.comboBoxMateriasRa.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.comboBoxMateriasRa.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.comboBoxMateriasRa.FormattingEnabled = true;
            this.comboBoxMateriasRa.Location = new System.Drawing.Point(33, 118);
            this.comboBoxMateriasRa.Name = "comboBoxMateriasRa";
            this.comboBoxMateriasRa.Size = new System.Drawing.Size(200, 23);
            this.comboBoxMateriasRa.TabIndex = 4;
            this.comboBoxMateriasRa.ValueMember = "SelectedMateria";
            this.comboBoxMateriasRa.Visible = false;
            this.comboBoxMateriasRa.Enter += new System.EventHandler(this.comboBoxMateriasRa_Enter);
            // 
            // materiaBindingSource
            // 
            this.materiaBindingSource.DataSource = typeof(Materias.Materia);
            // 
            // comboBoxRegularRa
            // 
            this.comboBoxRegularRa.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.comboBoxRegularRa.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.comboBoxRegularRa.FormattingEnabled = true;
            this.comboBoxRegularRa.Items.AddRange(new object[] {
            "Libre",
            "Regular"});
            this.comboBoxRegularRa.Location = new System.Drawing.Point(33, 185);
            this.comboBoxRegularRa.Name = "comboBoxRegularRa";
            this.comboBoxRegularRa.Size = new System.Drawing.Size(200, 23);
            this.comboBoxRegularRa.TabIndex = 5;
            this.comboBoxRegularRa.Text = "Condicion...";
            this.comboBoxRegularRa.Visible = false;
            this.comboBoxRegularRa.Enter += new System.EventHandler(this.comboBoxRegularRa_Enter);
            // 
            // comboBoxAlumnosRa
            // 
            this.comboBoxAlumnosRa.BackColor = System.Drawing.SystemColors.Window;
            this.comboBoxAlumnosRa.DataSource = this.alumnoBindingSource;
            this.comboBoxAlumnosRa.DisplayMember = "SelectedAlumno";
            this.comboBoxAlumnosRa.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.comboBoxAlumnosRa.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.comboBoxAlumnosRa.Location = new System.Drawing.Point(33, 54);
            this.comboBoxAlumnosRa.Name = "comboBoxAlumnosRa";
            this.comboBoxAlumnosRa.Size = new System.Drawing.Size(200, 23);
            this.comboBoxAlumnosRa.TabIndex = 3;
            this.comboBoxAlumnosRa.Visible = false;
            this.comboBoxAlumnosRa.SelectedIndexChanged += new System.EventHandler(this.comboBoxAlumnosRa_SelectedIndexChanged);
            this.comboBoxAlumnosRa.SelectionChangeCommitted += new System.EventHandler(this.comboBoxAlumnosRa_SelectionChangeCommitted);
            this.comboBoxAlumnosRa.Enter += new System.EventHandler(this.comboBoxAlumnosRa_Enter);
            // 
            // alumnoBindingSource
            // 
            this.alumnoBindingSource.AllowNew = false;
            this.alumnoBindingSource.DataSource = typeof(Persona.Alumno);
            // 
            // buttonAgregarRa
            // 
            this.buttonAgregarRa.Location = new System.Drawing.Point(19, 270);
            this.buttonAgregarRa.Name = "buttonAgregarRa";
            this.buttonAgregarRa.Size = new System.Drawing.Size(89, 23);
            this.buttonAgregarRa.TabIndex = 2;
            this.buttonAgregarRa.Text = "Modificar";
            this.buttonAgregarRa.UseVisualStyleBackColor = true;
            this.buttonAgregarRa.Visible = false;
            this.buttonAgregarRa.Click += new System.EventHandler(this.buttonAgregarRa_Click);
            // 
            // buttonCerrarRa
            // 
            this.buttonCerrarRa.Location = new System.Drawing.Point(152, 270);
            this.buttonCerrarRa.Name = "buttonCerrarRa";
            this.buttonCerrarRa.Size = new System.Drawing.Size(89, 23);
            this.buttonCerrarRa.TabIndex = 1;
            this.buttonCerrarRa.Text = "Cerrar";
            this.buttonCerrarRa.UseVisualStyleBackColor = true;
            this.buttonCerrarRa.Visible = false;
            this.buttonCerrarRa.Click += new System.EventHandler(this.buttonCerrarRa_Click);
            // 
            // groupBoxAlta
            // 
            this.groupBoxAlta.Controls.Add(this.buttonCerrarAlta);
            this.groupBoxAlta.Controls.Add(this.labelUser);
            this.groupBoxAlta.Controls.Add(this.labelPasswd);
            this.groupBoxAlta.Controls.Add(this.AltaTextBoxUserPasswd);
            this.groupBoxAlta.Controls.Add(this.labelLastName);
            this.groupBoxAlta.Controls.Add(this.AltaTextBoxUserDni);
            this.groupBoxAlta.Controls.Add(this.AltaTextBoxUserSureName);
            this.groupBoxAlta.Controls.Add(this.AltaTextBoxUserName);
            this.groupBoxAlta.Controls.Add(this.AltaUserComboBox);
            this.groupBoxAlta.Controls.Add(this.labelDni);
            this.groupBoxAlta.Controls.Add(this.labelName);
            this.groupBoxAlta.Controls.Add(this.buttonAgregarAlta);
            this.groupBoxAlta.Location = new System.Drawing.Point(220, 0);
            this.groupBoxAlta.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.groupBoxAlta.Name = "groupBoxAlta";
            this.groupBoxAlta.Size = new System.Drawing.Size(256, 300);
            this.groupBoxAlta.TabIndex = 19;
            this.groupBoxAlta.TabStop = false;
            this.groupBoxAlta.Visible = false;
            // 
            // buttonCerrarAlta
            // 
            this.buttonCerrarAlta.Location = new System.Drawing.Point(158, 270);
            this.buttonCerrarAlta.Name = "buttonCerrarAlta";
            this.buttonCerrarAlta.Size = new System.Drawing.Size(86, 23);
            this.buttonCerrarAlta.TabIndex = 8;
            this.buttonCerrarAlta.Text = "Cerrar";
            this.buttonCerrarAlta.UseVisualStyleBackColor = true;
            this.buttonCerrarAlta.Visible = false;
            this.buttonCerrarAlta.Click += new System.EventHandler(this.buttonCerrarAlta_Click);
            // 
            // labelUser
            // 
            this.labelUser.AutoSize = true;
            this.labelUser.Location = new System.Drawing.Point(10, 31);
            this.labelUser.Name = "labelUser";
            this.labelUser.Size = new System.Drawing.Size(53, 15);
            this.labelUser.TabIndex = 10;
            this.labelUser.Text = "Usuario :";
            this.labelUser.Visible = false;
            // 
            // labelPasswd
            // 
            this.labelPasswd.AutoSize = true;
            this.labelPasswd.Location = new System.Drawing.Point(9, 231);
            this.labelPasswd.Name = "labelPasswd";
            this.labelPasswd.Size = new System.Drawing.Size(53, 15);
            this.labelPasswd.TabIndex = 18;
            this.labelPasswd.Text = "Paaswd :";
            this.labelPasswd.Visible = false;
            // 
            // AltaTextBoxUserPasswd
            // 
            this.AltaTextBoxUserPasswd.Location = new System.Drawing.Point(102, 228);
            this.AltaTextBoxUserPasswd.Name = "AltaTextBoxUserPasswd";
            this.AltaTextBoxUserPasswd.PasswordChar = '*';
            this.AltaTextBoxUserPasswd.Size = new System.Drawing.Size(136, 23);
            this.AltaTextBoxUserPasswd.TabIndex = 6;
            this.AltaTextBoxUserPasswd.Visible = false;
            // 
            // labelLastName
            // 
            this.labelLastName.AutoSize = true;
            this.labelLastName.Location = new System.Drawing.Point(9, 81);
            this.labelLastName.Name = "labelLastName";
            this.labelLastName.Size = new System.Drawing.Size(57, 15);
            this.labelLastName.TabIndex = 12;
            this.labelLastName.Text = "Apellido :";
            this.labelLastName.Visible = false;
            // 
            // AltaTextBoxUserDni
            // 
            this.AltaTextBoxUserDni.Location = new System.Drawing.Point(102, 185);
            this.AltaTextBoxUserDni.Name = "AltaTextBoxUserDni";
            this.AltaTextBoxUserDni.Size = new System.Drawing.Size(136, 23);
            this.AltaTextBoxUserDni.TabIndex = 5;
            this.AltaTextBoxUserDni.Visible = false;
            // 
            // AltaTextBoxUserSureName
            // 
            this.AltaTextBoxUserSureName.Location = new System.Drawing.Point(102, 81);
            this.AltaTextBoxUserSureName.Name = "AltaTextBoxUserSureName";
            this.AltaTextBoxUserSureName.Size = new System.Drawing.Size(136, 23);
            this.AltaTextBoxUserSureName.TabIndex = 3;
            this.AltaTextBoxUserSureName.Visible = false;
            // 
            // AltaTextBoxUserName
            // 
            this.AltaTextBoxUserName.Location = new System.Drawing.Point(102, 130);
            this.AltaTextBoxUserName.Name = "AltaTextBoxUserName";
            this.AltaTextBoxUserName.Size = new System.Drawing.Size(136, 23);
            this.AltaTextBoxUserName.TabIndex = 4;
            this.AltaTextBoxUserName.Visible = false;
            // 
            // AltaUserComboBox
            // 
            this.AltaUserComboBox.AutoCompleteCustomSource.AddRange(new string[] {
            "Administrativo",
            "Alumno",
            "Profesor"});
            this.AltaUserComboBox.FormattingEnabled = true;
            this.AltaUserComboBox.Items.AddRange(new object[] {
            "Administrativo",
            "Alumno",
            "Profesor"});
            this.AltaUserComboBox.Location = new System.Drawing.Point(102, 31);
            this.AltaUserComboBox.Name = "AltaUserComboBox";
            this.AltaUserComboBox.Size = new System.Drawing.Size(136, 23);
            this.AltaUserComboBox.TabIndex = 2;
            this.AltaUserComboBox.Visible = false;
            // 
            // labelDni
            // 
            this.labelDni.AutoSize = true;
            this.labelDni.Location = new System.Drawing.Point(10, 193);
            this.labelDni.Name = "labelDni";
            this.labelDni.Size = new System.Drawing.Size(33, 15);
            this.labelDni.TabIndex = 16;
            this.labelDni.Text = "DNI :";
            this.labelDni.Visible = false;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(9, 138);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(60, 15);
            this.labelName.TabIndex = 14;
            this.labelName.Text = "Nombre : ";
            this.labelName.Visible = false;
            // 
            // buttonAgregarAlta
            // 
            this.buttonAgregarAlta.Location = new System.Drawing.Point(6, 270);
            this.buttonAgregarAlta.Name = "buttonAgregarAlta";
            this.buttonAgregarAlta.Size = new System.Drawing.Size(91, 23);
            this.buttonAgregarAlta.TabIndex = 7;
            this.buttonAgregarAlta.Text = "Agregar ";
            this.buttonAgregarAlta.UseVisualStyleBackColor = true;
            this.buttonAgregarAlta.Visible = false;
            this.buttonAgregarAlta.Click += new System.EventHandler(this.buttonAgregarAlta_Click);
            // 
            // groupBoxAm
            // 
            this.groupBoxAm.Controls.Add(this.labelCorrelativaAm);
            this.groupBoxAm.Controls.Add(this.checkBoxCorrelativa1);
            this.groupBoxAm.Controls.Add(this.textBoxCodigoAm);
            this.groupBoxAm.Controls.Add(this.comboBoxSeleccionarMateriaAm);
            this.groupBoxAm.Controls.Add(this.labelNombreMateriaAm);
            this.groupBoxAm.Controls.Add(this.buttonCerrarAm);
            this.groupBoxAm.Controls.Add(this.buttonAgregarAm);
            this.groupBoxAm.Controls.Add(this.textBoxNombreAm);
            this.groupBoxAm.Location = new System.Drawing.Point(220, 0);
            this.groupBoxAm.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.groupBoxAm.Name = "groupBoxAm";
            this.groupBoxAm.Size = new System.Drawing.Size(256, 300);
            this.groupBoxAm.TabIndex = 21;
            this.groupBoxAm.TabStop = false;
            this.groupBoxAm.Visible = false;
            // 
            // labelCorrelativaAm
            // 
            this.labelCorrelativaAm.AutoSize = true;
            this.labelCorrelativaAm.Location = new System.Drawing.Point(47, 152);
            this.labelCorrelativaAm.Name = "labelCorrelativaAm";
            this.labelCorrelativaAm.Size = new System.Drawing.Size(70, 15);
            this.labelCorrelativaAm.TabIndex = 23;
            this.labelCorrelativaAm.Text = "Correlativa: ";
            this.labelCorrelativaAm.Visible = false;
            // 
            // checkBoxCorrelativa1
            // 
            this.checkBoxCorrelativa1.AutoSize = true;
            this.checkBoxCorrelativa1.Location = new System.Drawing.Point(180, 152);
            this.checkBoxCorrelativa1.Name = "checkBoxCorrelativa1";
            this.checkBoxCorrelativa1.Size = new System.Drawing.Size(35, 19);
            this.checkBoxCorrelativa1.TabIndex = 3;
            this.checkBoxCorrelativa1.Text = "Si";
            this.checkBoxCorrelativa1.UseVisualStyleBackColor = true;
            this.checkBoxCorrelativa1.Visible = false;
            this.checkBoxCorrelativa1.CheckedChanged += new System.EventHandler(this.checkBoxCorrelativa1_CheckedChanged);
            // 
            // textBoxCodigoAm
            // 
            this.textBoxCodigoAm.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxCodigoAm.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.textBoxCodigoAm.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBoxCodigoAm.Location = new System.Drawing.Point(50, 106);
            this.textBoxCodigoAm.Name = "textBoxCodigoAm";
            this.textBoxCodigoAm.PlaceholderText = "Codigo...";
            this.textBoxCodigoAm.Size = new System.Drawing.Size(165, 23);
            this.textBoxCodigoAm.TabIndex = 1;
            // 
            // comboBoxSeleccionarMateriaAm
            // 
            this.comboBoxSeleccionarMateriaAm.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.materiaBindingSource, "SelectedMateria", true));
            this.comboBoxSeleccionarMateriaAm.DataSource = this.materiaBindingSource;
            this.comboBoxSeleccionarMateriaAm.DisplayMember = "SelectedMateria";
            this.comboBoxSeleccionarMateriaAm.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.comboBoxSeleccionarMateriaAm.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.comboBoxSeleccionarMateriaAm.Location = new System.Drawing.Point(50, 185);
            this.comboBoxSeleccionarMateriaAm.Name = "comboBoxSeleccionarMateriaAm";
            this.comboBoxSeleccionarMateriaAm.Size = new System.Drawing.Size(165, 23);
            this.comboBoxSeleccionarMateriaAm.TabIndex = 4;
            this.comboBoxSeleccionarMateriaAm.Visible = false;
            this.comboBoxSeleccionarMateriaAm.Enter += new System.EventHandler(this.comboBoxSeleccionarMateriaAm_Enter);
            // 
            // labelNombreMateriaAm
            // 
            this.labelNombreMateriaAm.AutoSize = true;
            this.labelNombreMateriaAm.Font = new System.Drawing.Font("Segoe UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.labelNombreMateriaAm.Location = new System.Drawing.Point(50, 28);
            this.labelNombreMateriaAm.Name = "labelNombreMateriaAm";
            this.labelNombreMateriaAm.Size = new System.Drawing.Size(89, 15);
            this.labelNombreMateriaAm.TabIndex = 4;
            this.labelNombreMateriaAm.Text = "Nueva materia:";
            this.labelNombreMateriaAm.Visible = false;
            // 
            // buttonCerrarAm
            // 
            this.buttonCerrarAm.Location = new System.Drawing.Point(170, 260);
            this.buttonCerrarAm.Name = "buttonCerrarAm";
            this.buttonCerrarAm.Size = new System.Drawing.Size(75, 23);
            this.buttonCerrarAm.TabIndex = 6;
            this.buttonCerrarAm.Text = "Cerrar";
            this.buttonCerrarAm.UseVisualStyleBackColor = true;
            this.buttonCerrarAm.Visible = false;
            this.buttonCerrarAm.Click += new System.EventHandler(this.buttonCerrarAm_Click);
            // 
            // buttonAgregarAm
            // 
            this.buttonAgregarAm.Location = new System.Drawing.Point(19, 260);
            this.buttonAgregarAm.Name = "buttonAgregarAm";
            this.buttonAgregarAm.Size = new System.Drawing.Size(75, 23);
            this.buttonAgregarAm.TabIndex = 5;
            this.buttonAgregarAm.Text = "Agregar";
            this.buttonAgregarAm.UseVisualStyleBackColor = true;
            this.buttonAgregarAm.Visible = false;
            this.buttonAgregarAm.Click += new System.EventHandler(this.buttonAgregarAm_Click);
            // 
            // textBoxNombreAm
            // 
            this.textBoxNombreAm.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.textBoxNombreAm.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBoxNombreAm.Location = new System.Drawing.Point(50, 57);
            this.textBoxNombreAm.Name = "textBoxNombreAm";
            this.textBoxNombreAm.PlaceholderText = "Nombre...";
            this.textBoxNombreAm.Size = new System.Drawing.Size(165, 23);
            this.textBoxNombreAm.TabIndex = 0;
            this.textBoxNombreAm.Visible = false;
            // 
            // groupBoxAp
            // 
            this.groupBoxAp.Controls.Add(this.labelMateriaSeleccionar);
            this.groupBoxAp.Controls.Add(this.labelProfesorSeleccionar);
            this.groupBoxAp.Controls.Add(this.comboBoxProfesorAp);
            this.groupBoxAp.Controls.Add(this.buttonCerrarAp);
            this.groupBoxAp.Controls.Add(this.buttonAgregarAp);
            this.groupBoxAp.Controls.Add(this.comboBoxMateriasAp);
            this.groupBoxAp.Location = new System.Drawing.Point(220, 0);
            this.groupBoxAp.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.groupBoxAp.Name = "groupBoxAp";
            this.groupBoxAp.Size = new System.Drawing.Size(256, 300);
            this.groupBoxAp.TabIndex = 22;
            this.groupBoxAp.TabStop = false;
            this.groupBoxAp.Visible = false;
            // 
            // labelMateriaSeleccionar
            // 
            this.labelMateriaSeleccionar.AutoSize = true;
            this.labelMateriaSeleccionar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.labelMateriaSeleccionar.Location = new System.Drawing.Point(53, 145);
            this.labelMateriaSeleccionar.Name = "labelMateriaSeleccionar";
            this.labelMateriaSeleccionar.Size = new System.Drawing.Size(109, 15);
            this.labelMateriaSeleccionar.TabIndex = 6;
            this.labelMateriaSeleccionar.Text = "Seleccionar materia";
            this.labelMateriaSeleccionar.Visible = false;
            // 
            // labelProfesorSeleccionar
            // 
            this.labelProfesorSeleccionar.AutoSize = true;
            this.labelProfesorSeleccionar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.labelProfesorSeleccionar.Location = new System.Drawing.Point(53, 65);
            this.labelProfesorSeleccionar.Name = "labelProfesorSeleccionar";
            this.labelProfesorSeleccionar.Size = new System.Drawing.Size(105, 15);
            this.labelProfesorSeleccionar.TabIndex = 5;
            this.labelProfesorSeleccionar.Text = "Seleccione profesor";
            this.labelProfesorSeleccionar.Visible = false;
            // 
            // comboBoxProfesorAp
            // 
            this.comboBoxProfesorAp.DataSource = this.profesorBindingSource;
            this.comboBoxProfesorAp.DisplayMember = "SelectedProfesor";
            this.comboBoxProfesorAp.FormattingEnabled = true;
            this.comboBoxProfesorAp.Location = new System.Drawing.Point(53, 83);
            this.comboBoxProfesorAp.Name = "comboBoxProfesorAp";
            this.comboBoxProfesorAp.Size = new System.Drawing.Size(161, 23);
            this.comboBoxProfesorAp.TabIndex = 4;
            this.comboBoxProfesorAp.Visible = false;
            this.comboBoxProfesorAp.SelectedIndexChanged += new System.EventHandler(this.comboBoxProfesorAp_SelectedIndexChanged);
            this.comboBoxProfesorAp.Enter += new System.EventHandler(this.comboBoxProfesorAp_Enter);
            // 
            // profesorBindingSource
            // 
            this.profesorBindingSource.DataSource = typeof(Persona.Profesor);
            // 
            // buttonCerrarAp
            // 
            this.buttonCerrarAp.Location = new System.Drawing.Point(164, 260);
            this.buttonCerrarAp.Name = "buttonCerrarAp";
            this.buttonCerrarAp.Size = new System.Drawing.Size(86, 23);
            this.buttonCerrarAp.TabIndex = 3;
            this.buttonCerrarAp.Text = "Cerrar";
            this.buttonCerrarAp.UseVisualStyleBackColor = true;
            this.buttonCerrarAp.Visible = false;
            this.buttonCerrarAp.Click += new System.EventHandler(this.buttonCerrarAp_Click);
            // 
            // buttonAgregarAp
            // 
            this.buttonAgregarAp.Location = new System.Drawing.Point(19, 260);
            this.buttonAgregarAp.Name = "buttonAgregarAp";
            this.buttonAgregarAp.Size = new System.Drawing.Size(89, 23);
            this.buttonAgregarAp.TabIndex = 2;
            this.buttonAgregarAp.Text = "Agregar";
            this.buttonAgregarAp.UseVisualStyleBackColor = true;
            this.buttonAgregarAp.Visible = false;
            this.buttonAgregarAp.Click += new System.EventHandler(this.buttonAgregarAp_Click);
            // 
            // comboBoxMateriasAp
            // 
            this.comboBoxMateriasAp.DataSource = this.materiaBindingSource;
            this.comboBoxMateriasAp.DisplayMember = "SelectedMateria";
            this.comboBoxMateriasAp.Enabled = false;
            this.comboBoxMateriasAp.FormattingEnabled = true;
            this.comboBoxMateriasAp.Location = new System.Drawing.Point(53, 163);
            this.comboBoxMateriasAp.Name = "comboBoxMateriasAp";
            this.comboBoxMateriasAp.Size = new System.Drawing.Size(161, 23);
            this.comboBoxMateriasAp.TabIndex = 1;
            this.comboBoxMateriasAp.Visible = false;
            this.comboBoxMateriasAp.Enter += new System.EventHandler(this.comboBoxMateriasAp_Enter);
            // 
            // groupBoxLinkLabelAltaU
            // 
            this.groupBoxLinkLabelAltaU.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxLinkLabelAltaU.Controls.Add(this.linkLabelAu2);
            this.groupBoxLinkLabelAltaU.Location = new System.Drawing.Point(0, 0);
            this.groupBoxLinkLabelAltaU.Name = "groupBoxLinkLabelAltaU";
            this.groupBoxLinkLabelAltaU.Size = new System.Drawing.Size(220, 85);
            this.groupBoxLinkLabelAltaU.TabIndex = 20;
            this.groupBoxLinkLabelAltaU.TabStop = false;
            this.groupBoxLinkLabelAltaU.Visible = false;
            // 
            // linkLabelAu2
            // 
            this.linkLabelAu2.AutoSize = true;
            this.linkLabelAu2.Location = new System.Drawing.Point(6, 28);
            this.linkLabelAu2.Name = "linkLabelAu2";
            this.linkLabelAu2.Size = new System.Drawing.Size(75, 15);
            this.linkLabelAu2.TabIndex = 1;
            this.linkLabelAu2.TabStop = true;
            this.linkLabelAu2.Text = "Alta usuarios";
            this.linkLabelAu2.Visible = false;
            // 
            // groupBoxLinkLabelRa
            // 
            this.groupBoxLinkLabelRa.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxLinkLabelRa.Controls.Add(this.linkLabelRa2);
            this.groupBoxLinkLabelRa.Location = new System.Drawing.Point(0, 70);
            this.groupBoxLinkLabelRa.Name = "groupBoxLinkLabelRa";
            this.groupBoxLinkLabelRa.Size = new System.Drawing.Size(220, 100);
            this.groupBoxLinkLabelRa.TabIndex = 23;
            this.groupBoxLinkLabelRa.TabStop = false;
            this.groupBoxLinkLabelRa.Text = " ";
            this.groupBoxLinkLabelRa.Visible = false;
            // 
            // linkLabelRa2
            // 
            this.linkLabelRa2.AutoSize = true;
            this.linkLabelRa2.Location = new System.Drawing.Point(6, 38);
            this.linkLabelRa2.Name = "linkLabelRa2";
            this.linkLabelRa2.Size = new System.Drawing.Size(119, 15);
            this.linkLabelRa2.TabIndex = 2;
            this.linkLabelRa2.TabStop = true;
            this.linkLabelRa2.Text = "Regularidad alumnos";
            this.linkLabelRa2.Visible = false;
            // 
            // groupBoxLinkAm
            // 
            this.groupBoxLinkAm.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxLinkAm.Controls.Add(this.linkLabelAm2);
            this.groupBoxLinkAm.Location = new System.Drawing.Point(0, 156);
            this.groupBoxLinkAm.Name = "groupBoxLinkAm";
            this.groupBoxLinkAm.Size = new System.Drawing.Size(220, 78);
            this.groupBoxLinkAm.TabIndex = 23;
            this.groupBoxLinkAm.TabStop = false;
            this.groupBoxLinkAm.Visible = false;
            // 
            // linkLabelAm2
            // 
            this.linkLabelAm2.AutoSize = true;
            this.linkLabelAm2.Location = new System.Drawing.Point(6, 29);
            this.linkLabelAm2.Name = "linkLabelAm2";
            this.linkLabelAm2.Size = new System.Drawing.Size(76, 15);
            this.linkLabelAm2.TabIndex = 4;
            this.linkLabelAm2.TabStop = true;
            this.linkLabelAm2.Text = "Alta materias";
            this.linkLabelAm2.Visible = false;
            // 
            // groupBoxGeneral
            // 
            this.groupBoxGeneral.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxGeneral.Controls.Add(this.groupBoxAp);
            this.groupBoxGeneral.Controls.Add(this.groupBoxRa);
            this.groupBoxGeneral.Controls.Add(this.groupBoxAlta);
            this.groupBoxGeneral.Controls.Add(this.groupBoxAm);
            this.groupBoxGeneral.Controls.Add(this.groupBoxLinkLabelRa);
            this.groupBoxGeneral.Controls.Add(this.groupBoxLinkLabelAltaU);
            this.groupBoxGeneral.Controls.Add(this.groupBoxLinkAm);
            this.groupBoxGeneral.Controls.Add(this.groupBoxLinkAp);
            this.groupBoxGeneral.Controls.Add(this.linkLabelAu);
            this.groupBoxGeneral.Controls.Add(this.linkLabelAp);
            this.groupBoxGeneral.Controls.Add(this.linkLabelAm);
            this.groupBoxGeneral.Controls.Add(this.linkLabelRa);
            this.groupBoxGeneral.Location = new System.Drawing.Point(68, 27);
            this.groupBoxGeneral.Name = "groupBoxGeneral";
            this.groupBoxGeneral.Size = new System.Drawing.Size(476, 299);
            this.groupBoxGeneral.TabIndex = 5;
            this.groupBoxGeneral.TabStop = false;
            // 
            // groupBoxLinkAp
            // 
            this.groupBoxLinkAp.Controls.Add(this.linkLabelAp2);
            this.groupBoxLinkAp.Location = new System.Drawing.Point(0, 220);
            this.groupBoxLinkAp.Name = "groupBoxLinkAp";
            this.groupBoxLinkAp.Size = new System.Drawing.Size(220, 79);
            this.groupBoxLinkAp.TabIndex = 23;
            this.groupBoxLinkAp.TabStop = false;
            this.groupBoxLinkAp.Visible = false;
            // 
            // linkLabelAp2
            // 
            this.linkLabelAp2.AutoSize = true;
            this.linkLabelAp2.Location = new System.Drawing.Point(6, 27);
            this.linkLabelAp2.Name = "linkLabelAp2";
            this.linkLabelAp2.Size = new System.Drawing.Size(124, 15);
            this.linkLabelAp2.TabIndex = 5;
            this.linkLabelAp2.TabStop = true;
            this.linkLabelAp2.Text = "Asignacion profesores";
            this.linkLabelAp2.Visible = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.ClientSize = new System.Drawing.Size(619, 355);
            this.Controls.Add(this.groupBoxGeneral);
            this.Controls.Add(this.menuStrip1);
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sesion: Admin";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBoxRa.ResumeLayout(false);
            this.groupBoxRa.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.materiaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alumnoBindingSource)).EndInit();
            this.groupBoxAlta.ResumeLayout(false);
            this.groupBoxAlta.PerformLayout();
            this.groupBoxAm.ResumeLayout(false);
            this.groupBoxAm.PerformLayout();
            this.groupBoxAp.ResumeLayout(false);
            this.groupBoxAp.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.profesorBindingSource)).EndInit();
            this.groupBoxLinkLabelAltaU.ResumeLayout(false);
            this.groupBoxLinkLabelAltaU.PerformLayout();
            this.groupBoxLinkLabelRa.ResumeLayout(false);
            this.groupBoxLinkLabelRa.PerformLayout();
            this.groupBoxLinkAm.ResumeLayout(false);
            this.groupBoxLinkAm.PerformLayout();
            this.groupBoxGeneral.ResumeLayout(false);
            this.groupBoxGeneral.PerformLayout();
            this.groupBoxLinkAp.ResumeLayout(false);
            this.groupBoxLinkAp.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        public System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.MenuStrip menuStrip1;
        public System.Windows.Forms.LinkLabel linkLabelRa;
        private System.Windows.Forms.LinkLabel linkLabelAm;
        private System.Windows.Forms.LinkLabel linkLabelAp;
        public System.Windows.Forms.LinkLabel linkLabelAu;
        public System.Windows.Forms.GroupBox groupBoxRa;
        public System.Windows.Forms.Button buttonCerrarRa;
        public System.Windows.Forms.GroupBox groupBoxLinkLabelAltaU;
        public System.Windows.Forms.GroupBox groupBoxLinkLabelRa;
        public System.Windows.Forms.LinkLabel linkLabelRa2;
        public System.Windows.Forms.LinkLabel linkLabelAu2;
        public System.Windows.Forms.GroupBox groupBoxAlta;
        public System.Windows.Forms.Button buttonAgregarAlta;
        public System.Windows.Forms.Button buttonCerrarAlta;
        public System.Windows.Forms.Label labelUser;
        public System.Windows.Forms.Label labelPasswd;
        public System.Windows.Forms.TextBox AltaTextBoxUserPasswd;
        public System.Windows.Forms.Label labelLastName;
        public System.Windows.Forms.TextBox AltaTextBoxUserDni;
        public System.Windows.Forms.TextBox AltaTextBoxUserSureName;
        public System.Windows.Forms.TextBox AltaTextBoxUserName;
        public System.Windows.Forms.ComboBox AltaUserComboBox;
        public System.Windows.Forms.Label labelDni;
        public System.Windows.Forms.Label labelName;
        public System.Windows.Forms.GroupBox groupBoxGeneral;
        public System.Windows.Forms.Button buttonAgregarRa;
        public System.Windows.Forms.ComboBox comboBoxRegularRa;
        public System.Windows.Forms.ComboBox comboBoxMateriasRa;
        public System.Windows.Forms.ComboBox comboBoxAlumnosRa;
        public System.Windows.Forms.GroupBox groupBoxAm;
        public System.Windows.Forms.Button buttonCerrarAm;
        public System.Windows.Forms.Button buttonAgregarAm;
        public System.Windows.Forms.TextBox textBoxNombreAm;
        public System.Windows.Forms.GroupBox groupBoxLinkAm;
        public System.Windows.Forms.LinkLabel linkLabelAm2;
        public System.Windows.Forms.Label labelNombreMateriaAm;
        public System.Windows.Forms.ComboBox comboBoxSeleccionarMateriaAm;
        public System.Windows.Forms.GroupBox groupBoxLinkAp;
        public System.Windows.Forms.LinkLabel linkLabelAp2;
        public System.Windows.Forms.GroupBox groupBoxAp;
        public System.Windows.Forms.ComboBox comboBoxProfesorAp;
        public System.Windows.Forms.Button buttonCerrarAp;
        private System.Windows.Forms.Button buttonAgregarAp;
        public System.Windows.Forms.ComboBox comboBoxMateriasAp;
        public System.Windows.Forms.Label labelRa;
        public System.Windows.Forms.BindingSource alumnoBindingSource;
        public System.Windows.Forms.BindingSource materiaBindingSource;
        public System.Windows.Forms.TextBox textBoxCodigoAm;
        public System.Windows.Forms.Label labelCorrelativaAm;
        public System.Windows.Forms.CheckBox checkBoxCorrelativa1;
        private System.Windows.Forms.BindingSource profesorBindingSource;
        public System.Windows.Forms.Label labelProfesorSeleccionar;
        public System.Windows.Forms.Label labelMateriaSeleccionar;
    }
}