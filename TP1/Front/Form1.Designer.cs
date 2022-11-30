namespace Front
{
    partial class Ingreso
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtBoxPasswd = new System.Windows.Forms.TextBox();
            this.KindUser = new System.Windows.Forms.ComboBox();
            this.txtBoxDNI = new System.Windows.Forms.TextBox();
            this.TagUser = new System.Windows.Forms.Label();
            this.TagPasswd = new System.Windows.Forms.Label();
            this.TagType = new System.Windows.Forms.Label();
            this.Acceder = new System.Windows.Forms.Button();
            this.buttonAdminSession = new System.Windows.Forms.Button();
            this.buttonSessionAlumno = new System.Windows.Forms.Button();
            this.buttonSessionTeacher = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtBoxPasswd
            // 
            this.txtBoxPasswd.Location = new System.Drawing.Point(223, 242);
            this.txtBoxPasswd.Name = "txtBoxPasswd";
            this.txtBoxPasswd.PasswordChar = '*';
            this.txtBoxPasswd.Size = new System.Drawing.Size(146, 23);
            this.txtBoxPasswd.TabIndex = 3;
            // 
            // KindUser
            // 
            this.KindUser.FormattingEnabled = true;
            this.KindUser.Items.AddRange(new object[] {
            "Administrador",
            "Alumno",
            "Profesor"});
            this.KindUser.Location = new System.Drawing.Point(223, 95);
            this.KindUser.Name = "KindUser";
            this.KindUser.Size = new System.Drawing.Size(146, 23);
            this.KindUser.TabIndex = 1;
            // 
            // txtBoxDNI
            // 
            this.txtBoxDNI.Location = new System.Drawing.Point(223, 167);
            this.txtBoxDNI.Name = "txtBoxDNI";
            this.txtBoxDNI.Size = new System.Drawing.Size(146, 23);
            this.txtBoxDNI.TabIndex = 2;
            // 
            // TagUser
            // 
            this.TagUser.AutoSize = true;
            this.TagUser.Location = new System.Drawing.Point(223, 149);
            this.TagUser.Name = "TagUser";
            this.TagUser.Size = new System.Drawing.Size(27, 15);
            this.TagUser.TabIndex = 3;
            this.TagUser.Text = "DNI";
            // 
            // TagPasswd
            // 
            this.TagPasswd.AutoSize = true;
            this.TagPasswd.Location = new System.Drawing.Point(223, 224);
            this.TagPasswd.Name = "TagPasswd";
            this.TagPasswd.Size = new System.Drawing.Size(67, 15);
            this.TagPasswd.TabIndex = 4;
            this.TagPasswd.Text = "Contraseña";
            // 
            // TagType
            // 
            this.TagType.AutoSize = true;
            this.TagType.Location = new System.Drawing.Point(223, 77);
            this.TagType.Name = "TagType";
            this.TagType.Size = new System.Drawing.Size(47, 15);
            this.TagType.TabIndex = 5;
            this.TagType.Text = "Usuario";
            // 
            // Acceder
            // 
            this.Acceder.Location = new System.Drawing.Point(433, 287);
            this.Acceder.Name = "Acceder";
            this.Acceder.Size = new System.Drawing.Size(141, 28);
            this.Acceder.TabIndex = 4;
            this.Acceder.Text = "Iniciar sesion";
            this.Acceder.UseVisualStyleBackColor = true;
            this.Acceder.Click += new System.EventHandler(this.Acceder_Click);
            // 
            // buttonAdminSession
            // 
            this.buttonAdminSession.Location = new System.Drawing.Point(12, 316);
            this.buttonAdminSession.Name = "buttonAdminSession";
            this.buttonAdminSession.Size = new System.Drawing.Size(97, 23);
            this.buttonAdminSession.TabIndex = 6;
            this.buttonAdminSession.Text = "Administrador";
            this.buttonAdminSession.UseVisualStyleBackColor = true;
            this.buttonAdminSession.Click += new System.EventHandler(this.buttonAdminSession_Click);
            // 
            // buttonSessionAlumno
            // 
            this.buttonSessionAlumno.Location = new System.Drawing.Point(115, 316);
            this.buttonSessionAlumno.Name = "buttonSessionAlumno";
            this.buttonSessionAlumno.Size = new System.Drawing.Size(75, 23);
            this.buttonSessionAlumno.TabIndex = 7;
            this.buttonSessionAlumno.Text = "Alumno";
            this.buttonSessionAlumno.UseVisualStyleBackColor = true;
            this.buttonSessionAlumno.Click += new System.EventHandler(this.buttonSessionAlumno_Click);
            // 
            // buttonSessionTeacher
            // 
            this.buttonSessionTeacher.Location = new System.Drawing.Point(196, 316);
            this.buttonSessionTeacher.Name = "buttonSessionTeacher";
            this.buttonSessionTeacher.Size = new System.Drawing.Size(75, 23);
            this.buttonSessionTeacher.TabIndex = 8;
            this.buttonSessionTeacher.Text = "Profesor";
            this.buttonSessionTeacher.UseVisualStyleBackColor = true;
            this.buttonSessionTeacher.Click += new System.EventHandler(this.buttonSessionTeacher_Click);
            // 
            // Ingreso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.ClientSize = new System.Drawing.Size(615, 351);
            this.Controls.Add(this.buttonSessionTeacher);
            this.Controls.Add(this.buttonSessionAlumno);
            this.Controls.Add(this.buttonAdminSession);
            this.Controls.Add(this.Acceder);
            this.Controls.Add(this.TagType);
            this.Controls.Add(this.TagPasswd);
            this.Controls.Add(this.TagUser);
            this.Controls.Add(this.txtBoxDNI);
            this.Controls.Add(this.KindUser);
            this.Controls.Add(this.txtBoxPasswd);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Ingreso";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema de Gestion UTN";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBoxPasswd;
        private System.Windows.Forms.ComboBox KindUser;
        private System.Windows.Forms.TextBox txtBoxDNI;
        private System.Windows.Forms.Label TagUser;
        private System.Windows.Forms.Label TagPasswd;
        private System.Windows.Forms.Label TagType;
        private System.Windows.Forms.Button Acceder;
        public System.Windows.Forms.Button buttonAdminSession;
        public System.Windows.Forms.Button buttonSessionAlumno;
        public System.Windows.Forms.Button buttonSessionTeacher;
    }
}
