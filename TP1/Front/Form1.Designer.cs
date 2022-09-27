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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.KindUser = new System.Windows.Forms.ComboBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.TagUser = new System.Windows.Forms.Label();
            this.TagPasswd = new System.Windows.Forms.Label();
            this.TagType = new System.Windows.Forms.Label();
            this.Acceder = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(223, 242);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(146, 23);
            this.textBox1.TabIndex = 0;
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
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(223, 167);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(146, 23);
            this.textBox2.TabIndex = 2;
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
            this.Acceder.TabIndex = 6;
            this.Acceder.Text = "Iniciar sesion";
            this.Acceder.UseVisualStyleBackColor = true;
            // 
            // Ingreso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(615, 351);
            this.Controls.Add(this.Acceder);
            this.Controls.Add(this.TagType);
            this.Controls.Add(this.TagPasswd);
            this.Controls.Add(this.TagUser);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.KindUser);
            this.Controls.Add(this.textBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Ingreso";
            this.Text = "Sistema de Gestion UTN";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox KindUser;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label TagUser;
        private System.Windows.Forms.Label TagPasswd;
        private System.Windows.Forms.Label TagType;
        private System.Windows.Forms.Button Acceder;
    }
}
