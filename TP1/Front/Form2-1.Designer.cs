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
            this.buttonCerrarAp = new System.Windows.Forms.Button();
            this.buttonAgregarAp = new System.Windows.Forms.Button();
            this.comboBoxMateriasAp = new System.Windows.Forms.ComboBox();
            this.groupBoxLinkAp = new System.Windows.Forms.GroupBox();
            this.linkLabelAp2 = new System.Windows.Forms.LinkLabel();
            this.comboBoxProfesorAp = new System.Windows.Forms.ComboBox();
            this.groupBoxAm.SuspendLayout();
            this.groupBoxLinkAp.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxAm
            // 
            this.groupBoxAm.Controls.Add(this.comboBoxProfesorAp);
            this.groupBoxAm.Controls.Add(this.buttonCerrarAp);
            this.groupBoxAm.Controls.Add(this.buttonAgregarAp);
            this.groupBoxAm.Controls.Add(this.comboBoxMateriasAp);
            this.groupBoxAm.Location = new System.Drawing.Point(467, 82);
            this.groupBoxAm.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.groupBoxAm.Name = "groupBoxAm";
            this.groupBoxAm.Size = new System.Drawing.Size(256, 300);
            this.groupBoxAm.TabIndex = 20;
            this.groupBoxAm.TabStop = false;
            this.groupBoxAm.Visible = false;
            // 
            // buttonCerrarAp
            // 
            this.buttonCerrarAp.Location = new System.Drawing.Point(168, 260);
            this.buttonCerrarAp.Name = "buttonCerrarAp";
            this.buttonCerrarAp.Size = new System.Drawing.Size(82, 23);
            this.buttonCerrarAp.TabIndex = 3;
            this.buttonCerrarAp.Text = "Cerrar";
            this.buttonCerrarAp.UseVisualStyleBackColor = true;
            this.buttonCerrarAp.Visible = false;
            // 
            // buttonAgregarAp
            // 
            this.buttonAgregarAp.Location = new System.Drawing.Point(19, 260);
            this.buttonAgregarAp.Name = "buttonAgregarAp";
            this.buttonAgregarAp.Size = new System.Drawing.Size(75, 23);
            this.buttonAgregarAp.TabIndex = 2;
            this.buttonAgregarAp.Text = "Agregar";
            this.buttonAgregarAp.UseVisualStyleBackColor = true;
            this.buttonAgregarAp.Visible = false;
            // 
            // comboBoxMateriasAp
            // 
            this.comboBoxMateriasAp.FormattingEnabled = true;
            this.comboBoxMateriasAp.Location = new System.Drawing.Point(74, 163);
            this.comboBoxMateriasAp.Name = "comboBoxMateriasAp";
            this.comboBoxMateriasAp.Size = new System.Drawing.Size(121, 23);
            this.comboBoxMateriasAp.TabIndex = 1;
            this.comboBoxMateriasAp.Visible = false;
            // 
            // groupBoxLinkAp
            // 
            this.groupBoxLinkAp.Controls.Add(this.linkLabelAp2);
            this.groupBoxLinkAp.Location = new System.Drawing.Point(145, 143);
            this.groupBoxLinkAp.Name = "groupBoxLinkAp";
            this.groupBoxLinkAp.Size = new System.Drawing.Size(220, 63);
            this.groupBoxLinkAp.TabIndex = 22;
            this.groupBoxLinkAp.TabStop = false;
            this.groupBoxLinkAp.Visible = false;
            // 
            // linkLabelAp2
            // 
            this.linkLabelAp2.AutoSize = true;
            this.linkLabelAp2.Location = new System.Drawing.Point(6, 22);
            this.linkLabelAp2.Name = "linkLabelAp2";
            this.linkLabelAp2.Size = new System.Drawing.Size(124, 15);
            this.linkLabelAp2.TabIndex = 21;
            this.linkLabelAp2.TabStop = true;
            this.linkLabelAp2.Text = "Asignacion profesores";
            this.linkLabelAp2.Visible = false;
            // 
            // comboBoxProfesorAp
            // 
            this.comboBoxProfesorAp.FormattingEnabled = true;
            this.comboBoxProfesorAp.Location = new System.Drawing.Point(74, 83);
            this.comboBoxProfesorAp.Name = "comboBoxProfesorAp";
            this.comboBoxProfesorAp.Size = new System.Drawing.Size(121, 23);
            this.comboBoxProfesorAp.TabIndex = 4;
            this.comboBoxProfesorAp.Visible = false;
            // 
            // Form2_1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBoxLinkAp);
            this.Controls.Add(this.groupBoxAm);
            this.Name = "Form2_1";
            this.Text = "Form2_1";
            this.groupBoxAm.ResumeLayout(false);
            this.groupBoxLinkAp.ResumeLayout(false);
            this.groupBoxLinkAp.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.GroupBox groupBoxAm;
        public System.Windows.Forms.GroupBox groupBoxLinkAp;
        public System.Windows.Forms.LinkLabel linkLabelAp2;
        private System.Windows.Forms.Button buttonAgregarAp;
        public System.Windows.Forms.ComboBox comboBoxMateriasAp;
        public System.Windows.Forms.ComboBox comboBoxProfesorAp;
        public System.Windows.Forms.Button buttonCerrarAp;
    }
}