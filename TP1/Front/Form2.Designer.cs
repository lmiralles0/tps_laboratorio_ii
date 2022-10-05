namespace Front
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.linkLabelRa = new System.Windows.Forms.LinkLabel();
            this.linkLabelAm = new System.Windows.Forms.LinkLabel();
            this.linkLabelAp = new System.Windows.Forms.LinkLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBoxLinkbRa = new System.Windows.Forms.GroupBox();
            this.linkLabelRa2 = new System.Windows.Forms.LinkLabel();
            this.groupBoxAlta2 = new System.Windows.Forms.GroupBox();
            this.linkLabelAu2 = new System.Windows.Forms.LinkLabel();
            this.linkLabelAu = new System.Windows.Forms.LinkLabel();
            this.groupBoxAlta = new System.Windows.Forms.GroupBox();
            this.groupBoxRa = new System.Windows.Forms.GroupBox();
            this.buttonAgregarAlta = new System.Windows.Forms.Button();
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
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBoxLinkbRa.SuspendLayout();
            this.groupBoxAlta2.SuspendLayout();
            this.groupBoxAlta.SuspendLayout();
            this.SuspendLayout();
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
            this.linkLabelRa.Visible = false;
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
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBoxAlta2);
            this.groupBox1.Controls.Add(this.linkLabelAu);
            this.groupBox1.Controls.Add(this.groupBoxAlta);
            this.groupBox1.Controls.Add(this.linkLabelAp);
            this.groupBox1.Controls.Add(this.linkLabelRa);
            this.groupBox1.Controls.Add(this.linkLabelAm);
            this.groupBox1.Location = new System.Drawing.Point(76, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(470, 299);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            // 
            // groupBoxLinkbRa
            // 
            this.groupBoxLinkbRa.Controls.Add(this.linkLabelRa2);
            this.groupBoxLinkbRa.Location = new System.Drawing.Point(0, 100);
            this.groupBoxLinkbRa.Name = "groupBoxLinkbRa";
            this.groupBoxLinkbRa.Size = new System.Drawing.Size(220, 100);
            this.groupBoxLinkbRa.TabIndex = 23;
            this.groupBoxLinkbRa.TabStop = false;
            this.groupBoxLinkbRa.Visible = false;
            // 
            // linkLabelRa2
            // 
            this.linkLabelRa2.AutoSize = true;
            this.linkLabelRa2.Location = new System.Drawing.Point(6, 22);
            this.linkLabelRa2.Name = "linkLabelRa2";
            this.linkLabelRa2.Size = new System.Drawing.Size(119, 15);
            this.linkLabelRa2.TabIndex = 21;
            this.linkLabelRa2.TabStop = true;
            this.linkLabelRa2.Text = "Regularidad alumnos";
            // 
            // groupBoxAlta2
            // 
            this.groupBoxAlta2.Controls.Add(this.groupBoxLinkbRa);
            this.groupBoxAlta2.Controls.Add(this.linkLabelAu2);
            this.groupBoxAlta2.Location = new System.Drawing.Point(0, 0);
            this.groupBoxAlta2.Name = "groupBoxAlta2";
            this.groupBoxAlta2.Size = new System.Drawing.Size(220, 100);
            this.groupBoxAlta2.TabIndex = 20;
            this.groupBoxAlta2.TabStop = false;
            this.groupBoxAlta2.Visible = false;
            // 
            // linkLabelAu2
            // 
            this.linkLabelAu2.AutoSize = true;
            this.linkLabelAu2.Location = new System.Drawing.Point(6, 34);
            this.linkLabelAu2.Name = "linkLabelAu2";
            this.linkLabelAu2.Size = new System.Drawing.Size(75, 15);
            this.linkLabelAu2.TabIndex = 6;
            this.linkLabelAu2.TabStop = true;
            this.linkLabelAu2.Text = "Alta usuarios";
            this.linkLabelAu2.Visible = false;
            // 
            // linkLabelAu
            // 
            this.linkLabelAu.AutoSize = true;
            this.linkLabelAu.Location = new System.Drawing.Point(6, 34);
            this.linkLabelAu.Name = "linkLabelAu";
            this.linkLabelAu.Size = new System.Drawing.Size(75, 15);
            this.linkLabelAu.TabIndex = 1;
            this.linkLabelAu.TabStop = true;
            this.linkLabelAu.Text = "Alta usuarios";
            this.linkLabelAu.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelAu2_LinkClicked_1);
            // 
            // groupBoxAlta
            // 
            this.groupBoxAlta.Controls.Add(this.groupBoxRa);
            this.groupBoxAlta.Controls.Add(this.buttonAgregarAlta);
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
            this.groupBoxAlta.Location = new System.Drawing.Point(220, 0);
            this.groupBoxAlta.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.groupBoxAlta.Name = "groupBoxAlta";
            this.groupBoxAlta.Size = new System.Drawing.Size(250, 299);
            this.groupBoxAlta.TabIndex = 19;
            this.groupBoxAlta.TabStop = false;
            this.groupBoxAlta.Visible = false;
            // 
            // groupBoxRa
            // 
            this.groupBoxRa.Location = new System.Drawing.Point(0, 0);
            this.groupBoxRa.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.groupBoxRa.Name = "groupBoxRa";
            this.groupBoxRa.Size = new System.Drawing.Size(250, 299);
            this.groupBoxRa.TabIndex = 21;
            this.groupBoxRa.TabStop = false;
            this.groupBoxRa.Visible = false;
            // 
            // buttonAgregarAlta
            // 
            this.buttonAgregarAlta.Location = new System.Drawing.Point(10, 270);
            this.buttonAgregarAlta.Name = "buttonAgregarAlta";
            this.buttonAgregarAlta.Size = new System.Drawing.Size(91, 23);
            this.buttonAgregarAlta.TabIndex = 20;
            this.buttonAgregarAlta.Text = "Agregar ";
            this.buttonAgregarAlta.UseVisualStyleBackColor = true;
            this.buttonAgregarAlta.Visible = false;
            // 
            // buttonCerrarAlta
            // 
            this.buttonCerrarAlta.Location = new System.Drawing.Point(158, 270);
            this.buttonCerrarAlta.Name = "buttonCerrarAlta";
            this.buttonCerrarAlta.Size = new System.Drawing.Size(86, 23);
            this.buttonCerrarAlta.TabIndex = 19;
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
            "Adminitrativo ",
            "Alumno ",
            "Profesor"});
            this.AltaUserComboBox.FormattingEnabled = true;
            this.AltaUserComboBox.Items.AddRange(new object[] {
            "Adminitrativo ",
            "Alumno ",
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
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(619, 355);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form2";
            this.Text = "Sesion: Admin";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBoxLinkbRa.ResumeLayout(false);
            this.groupBoxLinkbRa.PerformLayout();
            this.groupBoxAlta2.ResumeLayout(false);
            this.groupBoxAlta2.PerformLayout();
            this.groupBoxAlta.ResumeLayout(false);
            this.groupBoxAlta.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        public System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        public System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.LinkLabel linkLabelRa;
        private System.Windows.Forms.LinkLabel linkLabelAm;
        private System.Windows.Forms.LinkLabel linkLabelAp;
        private System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.ComboBox AltaUserComboBox;
        public System.Windows.Forms.TextBox AltaTextBoxUserPasswd;
        public System.Windows.Forms.TextBox AltaTextBoxUserDni;
        public System.Windows.Forms.TextBox AltaTextBoxUserName;
        public System.Windows.Forms.TextBox AltaTextBoxUserSureName;
        public System.Windows.Forms.GroupBox groupBoxAlta;
        private System.Windows.Forms.Label labelUser;
        private System.Windows.Forms.Label labelPasswd;
        private System.Windows.Forms.Label labelLastName;
        private System.Windows.Forms.Label labelDni;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.LinkLabel linkLabelAu;
        public System.Windows.Forms.GroupBox groupBoxAlta2;
        public System.Windows.Forms.LinkLabel linkLabelAu2;
        public System.Windows.Forms.Button buttonAgregarAlta;
        public System.Windows.Forms.Button buttonCerrarAlta;
        public System.Windows.Forms.GroupBox groupBoxLinkbRa;
        private System.Windows.Forms.LinkLabel linkLabelRa2;
        public System.Windows.Forms.GroupBox groupBoxRa;
    }
}