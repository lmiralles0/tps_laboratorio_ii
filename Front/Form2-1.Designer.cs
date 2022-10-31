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
            this.groupBoxAm = new System.Windows.Forms.GroupBox();
            this.groupBoxLinkAm = new System.Windows.Forms.GroupBox();
            this.linkLabelAm = new System.Windows.Forms.LinkLabel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.buttonAgregarAm = new System.Windows.Forms.Button();
            this.buttonCerrarAm = new System.Windows.Forms.Button();
            this.groupBoxAm.SuspendLayout();
            this.groupBoxLinkAm.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxAm
            // 
            this.groupBoxAm.Controls.Add(this.buttonCerrarAm);
            this.groupBoxAm.Controls.Add(this.buttonAgregarAm);
            this.groupBoxAm.Controls.Add(this.comboBox1);
            this.groupBoxAm.Controls.Add(this.textBox1);
            this.groupBoxAm.Location = new System.Drawing.Point(467, 82);
            this.groupBoxAm.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.groupBoxAm.Name = "groupBoxAm";
            this.groupBoxAm.Size = new System.Drawing.Size(256, 300);
            this.groupBoxAm.TabIndex = 20;
            this.groupBoxAm.TabStop = false;
            this.groupBoxAm.Visible = false;
            // 
            // groupBoxLinkAm
            // 
            this.groupBoxLinkAm.Controls.Add(this.linkLabelAm);
            this.groupBoxLinkAm.Location = new System.Drawing.Point(145, 143);
            this.groupBoxLinkAm.Name = "groupBoxLinkAm";
            this.groupBoxLinkAm.Size = new System.Drawing.Size(220, 91);
            this.groupBoxLinkAm.TabIndex = 22;
            this.groupBoxLinkAm.TabStop = false;
            this.groupBoxLinkAm.Visible = false;
            // 
            // linkLabelAm
            // 
            this.linkLabelAm.AutoSize = true;
            this.linkLabelAm.Location = new System.Drawing.Point(6, 22);
            this.linkLabelAm.Name = "linkLabelAm";
            this.linkLabelAm.Size = new System.Drawing.Size(76, 15);
            this.linkLabelAm.TabIndex = 21;
            this.linkLabelAm.TabStop = true;
            this.linkLabelAm.Text = "Alta materias";
            this.linkLabelAm.Visible = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(74, 83);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(121, 23);
            this.textBox1.TabIndex = 0;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(74, 163);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 23);
            this.comboBox1.TabIndex = 1;
            // 
            // buttonAgregarAm
            // 
            this.buttonAgregarAm.Location = new System.Drawing.Point(19, 260);
            this.buttonAgregarAm.Name = "buttonAgregarAm";
            this.buttonAgregarAm.Size = new System.Drawing.Size(75, 23);
            this.buttonAgregarAm.TabIndex = 2;
            this.buttonAgregarAm.Text = "Agregar";
            this.buttonAgregarAm.UseVisualStyleBackColor = true;
            // 
            // buttonCerrarAm
            // 
            this.buttonCerrarAm.Location = new System.Drawing.Point(175, 260);
            this.buttonCerrarAm.Name = "buttonCerrarAm";
            this.buttonCerrarAm.Size = new System.Drawing.Size(75, 23);
            this.buttonCerrarAm.TabIndex = 3;
            this.buttonCerrarAm.Text = "Cerrar";
            this.buttonCerrarAm.UseVisualStyleBackColor = true;
            // 
            // Form2_1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBoxLinkAm);
            this.Controls.Add(this.groupBoxAm);
            this.Name = "Form2_1";
            this.Text = "Form2_1";
            this.groupBoxAm.ResumeLayout(false);
            this.groupBoxAm.PerformLayout();
            this.groupBoxLinkAm.ResumeLayout(false);
            this.groupBoxLinkAm.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.GroupBox groupBoxAm;
        public System.Windows.Forms.GroupBox groupBoxLinkAm;
        public System.Windows.Forms.LinkLabel linkLabelAm;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button buttonCerrarAm;
        private System.Windows.Forms.Button buttonAgregarAm;
    }
}