namespace Front
{
    partial class Form2_1
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
            this.linkLabelInscripcion = new System.Windows.Forms.LinkLabel();
            this.linkLabelAsistencia = new System.Windows.Forms.LinkLabel();
            this.labelTitle = new System.Windows.Forms.Label();
            this.comboBoxInscripcion = new System.Windows.Forms.ComboBox();
            this.checkBoxPresenre = new System.Windows.Forms.CheckBox();
            this.checkBoxAusente = new System.Windows.Forms.CheckBox();
            this.monthCalendar = new System.Windows.Forms.MonthCalendar();
            this.groupBoxAsistencia = new System.Windows.Forms.GroupBox();
            this.groupBoxInscripcion = new System.Windows.Forms.GroupBox();
            this.buttonInscripcionI = new System.Windows.Forms.Button();
            this.buttonAsistenciaConfirmar = new System.Windows.Forms.Button();
            this.buttonAsistenciaC = new System.Windows.Forms.Button();
            this.buttonInscripcionC = new System.Windows.Forms.Button();
            this.groupBoxAsistencia.SuspendLayout();
            this.groupBoxInscripcion.SuspendLayout();
            this.SuspendLayout();
            // 
            // linkLabelInscripcion
            // 
            this.linkLabelInscripcion.AutoSize = true;
            this.linkLabelInscripcion.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.linkLabelInscripcion.Location = new System.Drawing.Point(12, 62);
            this.linkLabelInscripcion.Name = "linkLabelInscripcion";
            this.linkLabelInscripcion.Size = new System.Drawing.Size(74, 19);
            this.linkLabelInscripcion.TabIndex = 0;
            this.linkLabelInscripcion.TabStop = true;
            this.linkLabelInscripcion.Text = "Inscripcion";
            this.linkLabelInscripcion.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelInscripcion_LinkClicked);
            // 
            // linkLabelAsistencia
            // 
            this.linkLabelAsistencia.AutoSize = true;
            this.linkLabelAsistencia.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.linkLabelAsistencia.Location = new System.Drawing.Point(326, 61);
            this.linkLabelAsistencia.Name = "linkLabelAsistencia";
            this.linkLabelAsistencia.Size = new System.Drawing.Size(69, 19);
            this.linkLabelAsistencia.TabIndex = 1;
            this.linkLabelAsistencia.TabStop = true;
            this.linkLabelAsistencia.Text = "Asistencia";
            this.linkLabelAsistencia.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelAsistencia_LinkClicked);
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelTitle.Location = new System.Drawing.Point(120, 9);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(68, 21);
            this.labelTitle.TabIndex = 2;
            this.labelTitle.Text = "Alumno:";
            // 
            // comboBoxInscripcion
            // 
            this.comboBoxInscripcion.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.comboBoxInscripcion.FormattingEnabled = true;
            this.comboBoxInscripcion.Location = new System.Drawing.Point(22, 35);
            this.comboBoxInscripcion.Name = "comboBoxInscripcion";
            this.comboBoxInscripcion.Size = new System.Drawing.Size(230, 23);
            this.comboBoxInscripcion.TabIndex = 2;
            this.comboBoxInscripcion.Text = "Seleccione materia...";
            this.comboBoxInscripcion.Visible = false;
            // 
            // checkBoxPresenre
            // 
            this.checkBoxPresenre.AutoSize = true;
            this.checkBoxPresenre.Location = new System.Drawing.Point(21, 35);
            this.checkBoxPresenre.Name = "checkBoxPresenre";
            this.checkBoxPresenre.Size = new System.Drawing.Size(71, 19);
            this.checkBoxPresenre.TabIndex = 5;
            this.checkBoxPresenre.Text = "Presente";
            this.checkBoxPresenre.UseVisualStyleBackColor = true;
            this.checkBoxPresenre.Visible = false;
            // 
            // checkBoxAusente
            // 
            this.checkBoxAusente.AutoSize = true;
            this.checkBoxAusente.Location = new System.Drawing.Point(200, 35);
            this.checkBoxAusente.Name = "checkBoxAusente";
            this.checkBoxAusente.Size = new System.Drawing.Size(69, 19);
            this.checkBoxAusente.TabIndex = 6;
            this.checkBoxAusente.Text = "Ausente";
            this.checkBoxAusente.UseVisualStyleBackColor = true;
            this.checkBoxAusente.Visible = false;
            // 
            // monthCalendar
            // 
            this.monthCalendar.Location = new System.Drawing.Point(21, 61);
            this.monthCalendar.Name = "monthCalendar";
            this.monthCalendar.ShowToday = false;
            this.monthCalendar.ShowTodayCircle = false;
            this.monthCalendar.TabIndex = 6;
            this.monthCalendar.Visible = false;
            // 
            // groupBoxAsistencia
            // 
            this.groupBoxAsistencia.Controls.Add(this.monthCalendar);
            this.groupBoxAsistencia.Controls.Add(this.checkBoxAusente);
            this.groupBoxAsistencia.Controls.Add(this.checkBoxPresenre);
            this.groupBoxAsistencia.Location = new System.Drawing.Point(326, 83);
            this.groupBoxAsistencia.Name = "groupBoxAsistencia";
            this.groupBoxAsistencia.Size = new System.Drawing.Size(281, 237);
            this.groupBoxAsistencia.TabIndex = 7;
            this.groupBoxAsistencia.TabStop = false;
            this.groupBoxAsistencia.Visible = false;
            // 
            // groupBoxInscripcion
            // 
            this.groupBoxInscripcion.Controls.Add(this.comboBoxInscripcion);
            this.groupBoxInscripcion.Location = new System.Drawing.Point(12, 83);
            this.groupBoxInscripcion.Name = "groupBoxInscripcion";
            this.groupBoxInscripcion.Size = new System.Drawing.Size(281, 237);
            this.groupBoxInscripcion.TabIndex = 8;
            this.groupBoxInscripcion.TabStop = false;
            this.groupBoxInscripcion.Visible = false;
            // 
            // buttonInscripcionI
            // 
            this.buttonInscripcionI.Location = new System.Drawing.Point(218, 320);
            this.buttonInscripcionI.Name = "buttonInscripcionI";
            this.buttonInscripcionI.Size = new System.Drawing.Size(75, 23);
            this.buttonInscripcionI.TabIndex = 4;
            this.buttonInscripcionI.Text = "Inscribirse";
            this.buttonInscripcionI.UseVisualStyleBackColor = true;
            this.buttonInscripcionI.Visible = false;
            this.buttonInscripcionI.Click += new System.EventHandler(this.buttonInscripcionI_Click);
            // 
            // buttonAsistenciaConfirmar
            // 
            this.buttonAsistenciaConfirmar.Location = new System.Drawing.Point(532, 320);
            this.buttonAsistenciaConfirmar.Name = "buttonAsistenciaConfirmar";
            this.buttonAsistenciaConfirmar.Size = new System.Drawing.Size(75, 23);
            this.buttonAsistenciaConfirmar.TabIndex = 8;
            this.buttonAsistenciaConfirmar.Text = "Confirmar";
            this.buttonAsistenciaConfirmar.UseVisualStyleBackColor = true;
            this.buttonAsistenciaConfirmar.Visible = false;
            this.buttonAsistenciaConfirmar.Click += new System.EventHandler(this.buttonAsistenciaConfirmar_Click);
            // 
            // buttonAsistenciaC
            // 
            this.buttonAsistenciaC.Location = new System.Drawing.Point(326, 320);
            this.buttonAsistenciaC.Name = "buttonAsistenciaC";
            this.buttonAsistenciaC.Size = new System.Drawing.Size(75, 23);
            this.buttonAsistenciaC.TabIndex = 7;
            this.buttonAsistenciaC.Text = "Cerrar";
            this.buttonAsistenciaC.UseVisualStyleBackColor = true;
            this.buttonAsistenciaC.Visible = false;
            this.buttonAsistenciaC.Click += new System.EventHandler(this.buttonAsistenciaC_Click);
            // 
            // buttonInscripcionC
            // 
            this.buttonInscripcionC.Location = new System.Drawing.Point(14, 319);
            this.buttonInscripcionC.Name = "buttonInscripcionC";
            this.buttonInscripcionC.Size = new System.Drawing.Size(75, 23);
            this.buttonInscripcionC.TabIndex = 3;
            this.buttonInscripcionC.Text = "Cerrar";
            this.buttonInscripcionC.UseVisualStyleBackColor = true;
            this.buttonInscripcionC.Visible = false;
            this.buttonInscripcionC.Click += new System.EventHandler(this.buttonInscripcionC_Click);
            // 
            // Form2_1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(619, 355);
            this.Controls.Add(this.buttonInscripcionC);
            this.Controls.Add(this.buttonAsistenciaC);
            this.Controls.Add(this.buttonAsistenciaConfirmar);
            this.Controls.Add(this.buttonInscripcionI);
            this.Controls.Add(this.groupBoxInscripcion);
            this.Controls.Add(this.groupBoxAsistencia);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.linkLabelAsistencia);
            this.Controls.Add(this.linkLabelInscripcion);
            this.Name = "Form2_1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sesion: Alumno";
            this.groupBoxAsistencia.ResumeLayout(false);
            this.groupBoxAsistencia.PerformLayout();
            this.groupBoxInscripcion.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel linkLabelInscripcion;
        public System.Windows.Forms.Label labelTitle;
        public System.Windows.Forms.MonthCalendar monthCalendar;
        public System.Windows.Forms.GroupBox groupBoxInscripcion;
        public System.Windows.Forms.ComboBox comboBoxInscripcion;
        public System.Windows.Forms.Button buttonInscripcionI;
        public System.Windows.Forms.Button buttonInscripcionC;
        public System.Windows.Forms.LinkLabel linkLabelAsistencia;
        public System.Windows.Forms.CheckBox checkBoxPresenre;
        public System.Windows.Forms.CheckBox checkBoxAusente;
        public System.Windows.Forms.GroupBox groupBoxAsistencia;
        public System.Windows.Forms.Button buttonAsistenciaC;
        public System.Windows.Forms.Button buttonAsistenciaConfirmar;
    }
}