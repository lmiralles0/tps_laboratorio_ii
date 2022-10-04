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
            this.linkLabelAltaUsers = new System.Windows.Forms.LinkLabel();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.linkLabel3 = new System.Windows.Forms.LinkLabel();
            this.linkLabel4 = new System.Windows.Forms.LinkLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.groupBoxAlta = new System.Windows.Forms.GroupBox();
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
            this.groupBoxAlta2 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBoxAlta.SuspendLayout();
            this.groupBoxAlta2.SuspendLayout();
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
            // linkLabelAltaUsers
            // 
            this.linkLabelAltaUsers.AutoSize = true;
            this.linkLabelAltaUsers.Location = new System.Drawing.Point(6, 34);
            this.linkLabelAltaUsers.Name = "linkLabelAltaUsers";
            this.linkLabelAltaUsers.Size = new System.Drawing.Size(75, 15);
            this.linkLabelAltaUsers.TabIndex = 1;
            this.linkLabelAltaUsers.TabStop = true;
            this.linkLabelAltaUsers.Text = "Alta usuarios";
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Location = new System.Drawing.Point(6, 109);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(119, 15);
            this.linkLabel2.TabIndex = 2;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "Regularidad alumnos";
            // 
            // linkLabel3
            // 
            this.linkLabel3.AutoSize = true;
            this.linkLabel3.Location = new System.Drawing.Point(6, 185);
            this.linkLabel3.Name = "linkLabel3";
            this.linkLabel3.Size = new System.Drawing.Size(76, 15);
            this.linkLabel3.TabIndex = 3;
            this.linkLabel3.TabStop = true;
            this.linkLabel3.Text = "Alta materias";
            // 
            // linkLabel4
            // 
            this.linkLabel4.AutoSize = true;
            this.linkLabel4.Location = new System.Drawing.Point(6, 247);
            this.linkLabel4.Name = "linkLabel4";
            this.linkLabel4.Size = new System.Drawing.Size(124, 15);
            this.linkLabel4.TabIndex = 4;
            this.linkLabel4.TabStop = true;
            this.linkLabel4.Text = "Asignacion profesores";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.linkLabel1);
            this.groupBox1.Controls.Add(this.groupBoxAlta);
            this.groupBox1.Controls.Add(this.linkLabel4);
            this.groupBox1.Controls.Add(this.linkLabel2);
            this.groupBox1.Controls.Add(this.linkLabel3);
            this.groupBox1.Location = new System.Drawing.Point(82, 44);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(470, 299);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(6, 34);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(75, 15);
            this.linkLabel1.TabIndex = 1;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Alta usuarios";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked_1);
            // 
            // groupBoxAlta
            // 
            this.groupBoxAlta.Controls.Add(this.button2);
            this.groupBoxAlta.Controls.Add(this.button1);
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
            // groupBoxAlta2
            // 
            this.groupBoxAlta2.Controls.Add(this.linkLabelAltaUsers);
            this.groupBoxAlta2.Location = new System.Drawing.Point(82, 44);
            this.groupBoxAlta2.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.groupBoxAlta2.Name = "groupBoxAlta2";
            this.groupBoxAlta2.Padding = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.groupBoxAlta2.Size = new System.Drawing.Size(220, 106);
            this.groupBoxAlta2.TabIndex = 20;
            this.groupBoxAlta2.TabStop = false;
            this.groupBoxAlta2.Visible = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(169, 270);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 19;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(10, 270);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 20;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(619, 355);
            this.Controls.Add(this.groupBoxAlta2);
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
            this.groupBoxAlta.ResumeLayout(false);
            this.groupBoxAlta.PerformLayout();
            this.groupBoxAlta2.ResumeLayout(false);
            this.groupBoxAlta2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        public System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        public System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.LinkLabel linkLabelAltaUsers;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.LinkLabel linkLabel3;
        private System.Windows.Forms.LinkLabel linkLabel4;
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
        public System.Windows.Forms.GroupBox groupBoxAlta2;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}