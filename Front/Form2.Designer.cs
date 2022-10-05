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
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.linkLabelRa = new System.Windows.Forms.LinkLabel();
            this.linkLabelAm = new System.Windows.Forms.LinkLabel();
            this.linkLabelAp = new System.Windows.Forms.LinkLabel();
            this.linkLabelAu = new System.Windows.Forms.LinkLabel();
            this.groupBoxRa = new System.Windows.Forms.GroupBox();
            this.buttonCerrarRa = new System.Windows.Forms.Button();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.groupBoxAlta2 = new System.Windows.Forms.GroupBox();
            this.linkLabelAu2 = new System.Windows.Forms.LinkLabel();
            this.groupBoxLinkLabelRa = new System.Windows.Forms.GroupBox();
            this.linkLabelRa2 = new System.Windows.Forms.LinkLabel();
            this.groupBoxAlta = new System.Windows.Forms.GroupBox();
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
            this.groupBoxGeneral = new System.Windows.Forms.GroupBox();
            this.menuStrip1.SuspendLayout();
            this.groupBoxRa.SuspendLayout();
            this.groupBoxAlta2.SuspendLayout();
            this.groupBoxLinkLabelRa.SuspendLayout();
            this.groupBoxAlta.SuspendLayout();
            this.groupBoxGeneral.SuspendLayout();
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
            this.groupBoxRa.Controls.Add(this.buttonCerrarRa);
            this.groupBoxRa.Controls.Add(this.checkedListBox1);
            this.groupBoxRa.Location = new System.Drawing.Point(220, 0);
            this.groupBoxRa.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.groupBoxRa.Name = "groupBoxRa";
            this.groupBoxRa.Size = new System.Drawing.Size(256, 300);
            this.groupBoxRa.TabIndex = 21;
            this.groupBoxRa.TabStop = false;
            this.groupBoxRa.Visible = false;
            // 
            // buttonCerrarRa
            // 
            this.buttonCerrarRa.Location = new System.Drawing.Point(154, 255);
            this.buttonCerrarRa.Name = "buttonCerrarRa";
            this.buttonCerrarRa.Size = new System.Drawing.Size(75, 23);
            this.buttonCerrarRa.TabIndex = 1;
            this.buttonCerrarRa.Text = "Cerrar";
            this.buttonCerrarRa.UseVisualStyleBackColor = true;
            this.buttonCerrarRa.Visible = false;
            this.buttonCerrarRa.Click += new System.EventHandler(this.buttonCerrarRa_Click);
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(62, 81);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(120, 94);
            this.checkedListBox1.TabIndex = 0;
            this.checkedListBox1.Visible = false;
            // 
            // groupBoxAlta2
            // 
            this.groupBoxAlta2.Controls.Add(this.groupBoxLinkLabelRa);
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
            this.linkLabelAu2.Location = new System.Drawing.Point(6, 28);
            this.linkLabelAu2.Name = "linkLabelAu2";
            this.linkLabelAu2.Size = new System.Drawing.Size(75, 15);
            this.linkLabelAu2.TabIndex = 6;
            this.linkLabelAu2.TabStop = true;
            this.linkLabelAu2.Text = "Alta usuarios";
            this.linkLabelAu2.Visible = false;
            // 
            // groupBoxLinkLabelRa
            // 
            this.groupBoxLinkLabelRa.Controls.Add(this.linkLabelRa2);
            this.groupBoxLinkLabelRa.Location = new System.Drawing.Point(0, 91);
            this.groupBoxLinkLabelRa.Name = "groupBoxLinkLabelRa";
            this.groupBoxLinkLabelRa.Size = new System.Drawing.Size(223, 91);
            this.groupBoxLinkLabelRa.TabIndex = 23;
            this.groupBoxLinkLabelRa.TabStop = false;
            this.groupBoxLinkLabelRa.Visible = false;
            // 
            // linkLabelRa2
            // 
            this.linkLabelRa2.AutoSize = true;
            this.linkLabelRa2.Location = new System.Drawing.Point(6, 15);
            this.linkLabelRa2.Name = "linkLabelRa2";
            this.linkLabelRa2.Size = new System.Drawing.Size(119, 15);
            this.linkLabelRa2.TabIndex = 21;
            this.linkLabelRa2.TabStop = true;
            this.linkLabelRa2.Text = "Regularidad alumnos";
            this.linkLabelRa2.Visible = false;
            // 
            // groupBoxAlta
            // 
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
            this.groupBoxAlta.Size = new System.Drawing.Size(256, 300);
            this.groupBoxAlta.TabIndex = 19;
            this.groupBoxAlta.TabStop = false;
            this.groupBoxAlta.Visible = false;
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
            // groupBoxGeneral
            // 
            this.groupBoxGeneral.Controls.Add(this.groupBoxAlta);
            this.groupBoxGeneral.Controls.Add(this.groupBoxAlta2);
            this.groupBoxGeneral.Controls.Add(this.groupBoxRa);
            this.groupBoxGeneral.Controls.Add(this.groupBoxLinkLabelRa);
            this.groupBoxGeneral.Controls.Add(this.linkLabelAu);
            this.groupBoxGeneral.Controls.Add(this.linkLabelAp);
            this.groupBoxGeneral.Controls.Add(this.linkLabelAm);
            this.groupBoxGeneral.Controls.Add(this.linkLabelRa);
            this.groupBoxGeneral.Location = new System.Drawing.Point(77, 27);
            this.groupBoxGeneral.Name = "groupBoxGeneral";
            this.groupBoxGeneral.Size = new System.Drawing.Size(476, 299);
            this.groupBoxGeneral.TabIndex = 5;
            this.groupBoxGeneral.TabStop = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(619, 355);
            this.Controls.Add(this.groupBoxGeneral);
            this.Controls.Add(this.menuStrip1);
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form2";
            this.Text = "Sesion: Admin";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBoxRa.ResumeLayout(false);
            this.groupBoxAlta2.ResumeLayout(false);
            this.groupBoxAlta2.PerformLayout();
            this.groupBoxLinkLabelRa.ResumeLayout(false);
            this.groupBoxLinkLabelRa.PerformLayout();
            this.groupBoxAlta.ResumeLayout(false);
            this.groupBoxAlta.PerformLayout();
            this.groupBoxGeneral.ResumeLayout(false);
            this.groupBoxGeneral.PerformLayout();
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
        public System.Windows.Forms.CheckedListBox checkedListBox1;
        public System.Windows.Forms.GroupBox groupBoxAlta2;
        public System.Windows.Forms.GroupBox groupBoxLinkLabelRa;
        public System.Windows.Forms.LinkLabel linkLabelRa2;
        public System.Windows.Forms.LinkLabel linkLabelAu2;
        public System.Windows.Forms.GroupBox groupBoxAlta;
        public System.Windows.Forms.Button buttonAgregarAlta;
        public System.Windows.Forms.Button buttonCerrarAlta;
        private System.Windows.Forms.Label labelUser;
        private System.Windows.Forms.Label labelPasswd;
        public System.Windows.Forms.TextBox AltaTextBoxUserPasswd;
        private System.Windows.Forms.Label labelLastName;
        public System.Windows.Forms.TextBox AltaTextBoxUserDni;
        public System.Windows.Forms.TextBox AltaTextBoxUserSureName;
        public System.Windows.Forms.TextBox AltaTextBoxUserName;
        public System.Windows.Forms.ComboBox AltaUserComboBox;
        private System.Windows.Forms.Label labelDni;
        private System.Windows.Forms.Label labelName;
        public System.Windows.Forms.GroupBox groupBoxGeneral;
    }
}