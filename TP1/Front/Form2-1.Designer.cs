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
            this.groupBoxAp = new System.Windows.Forms.GroupBox();
            this.buttonCerrarAp = new System.Windows.Forms.Button();
            this.buttonAgregarAp = new System.Windows.Forms.Button();
            this.comboBoxSeleccionarMateriaAp = new System.Windows.Forms.ComboBox();
            this.groupBoxLinkAp = new System.Windows.Forms.GroupBox();
            this.linkLabelAp = new System.Windows.Forms.LinkLabel();
            this.comboBoxSeleccionarProfesorAp = new System.Windows.Forms.ComboBox();
            this.groupBoxAp.SuspendLayout();
            this.groupBoxLinkAp.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxAp
            // 
            this.groupBoxAp.Controls.Add(this.comboBoxSeleccionarProfesorAp);
            this.groupBoxAp.Controls.Add(this.buttonCerrarAp);
            this.groupBoxAp.Controls.Add(this.buttonAgregarAp);
            this.groupBoxAp.Controls.Add(this.comboBoxSeleccionarMateriaAp);
            this.groupBoxAp.Location = new System.Drawing.Point(467, 82);
            this.groupBoxAp.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.groupBoxAp.Name = "groupBoxAp";
            this.groupBoxAp.Size = new System.Drawing.Size(256, 300);
            this.groupBoxAp.TabIndex = 20;
            this.groupBoxAp.TabStop = false;
            this.groupBoxAp.Visible = false;
            // 
            // buttonCerrarAp
            // 
            this.buttonCerrarAp.Location = new System.Drawing.Point(175, 260);
            this.buttonCerrarAp.Name = "buttonCerrarAp";
            this.buttonCerrarAp.Size = new System.Drawing.Size(75, 23);
            this.buttonCerrarAp.TabIndex = 3;
            this.buttonCerrarAp.Text = "Cerrar";
            this.buttonCerrarAp.UseVisualStyleBackColor = true;
            // 
            // buttonAgregarAp
            // 
            this.buttonAgregarAp.Location = new System.Drawing.Point(19, 260);
            this.buttonAgregarAp.Name = "buttonAgregarAp";
            this.buttonAgregarAp.Size = new System.Drawing.Size(75, 23);
            this.buttonAgregarAp.TabIndex = 2;
            this.buttonAgregarAp.Text = "Agregar";
            this.buttonAgregarAp.UseVisualStyleBackColor = true;
            // 
            // comboBoxSeleccionarMateriaAp
            // 
            this.comboBoxSeleccionarMateriaAp.FormattingEnabled = true;
            this.comboBoxSeleccionarMateriaAp.Location = new System.Drawing.Point(74, 163);
            this.comboBoxSeleccionarMateriaAp.Name = "comboBoxSeleccionarMateriaAp";
            this.comboBoxSeleccionarMateriaAp.Size = new System.Drawing.Size(121, 23);
            this.comboBoxSeleccionarMateriaAp.TabIndex = 1;
            // 
            // groupBoxLinkAp
            // 
            this.groupBoxLinkAp.Controls.Add(this.linkLabelAp);
            this.groupBoxLinkAp.Location = new System.Drawing.Point(145, 143);
            this.groupBoxLinkAp.Name = "groupBoxLinkAp";
            this.groupBoxLinkAp.Size = new System.Drawing.Size(220, 91);
            this.groupBoxLinkAp.TabIndex = 22;
            this.groupBoxLinkAp.TabStop = false;
            this.groupBoxLinkAp.Visible = false;
            // 
            // linkLabelAp
            // 
            this.linkLabelAp.AutoSize = true;
            this.linkLabelAp.Location = new System.Drawing.Point(6, 22);
            this.linkLabelAp.Name = "linkLabelAp";
            this.linkLabelAp.Size = new System.Drawing.Size(113, 15);
            this.linkLabelAp.TabIndex = 21;
            this.linkLabelAp.TabStop = true;
            this.linkLabelAp.Text = "Asignacion profesor";
            this.linkLabelAp.Visible = false;
            // 
            // comboBoxSeleccionarProfesorAp
            // 
            this.comboBoxSeleccionarProfesorAp.FormattingEnabled = true;
            this.comboBoxSeleccionarProfesorAp.Location = new System.Drawing.Point(74, 83);
            this.comboBoxSeleccionarProfesorAp.Name = "comboBoxSeleccionarProfesorAp";
            this.comboBoxSeleccionarProfesorAp.Size = new System.Drawing.Size(121, 23);
            this.comboBoxSeleccionarProfesorAp.TabIndex = 4;
            // 
            // Form2_1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBoxLinkAp);
            this.Controls.Add(this.groupBoxAp);
            this.Name = "Form2_1";
            this.Text = "Form2_1";
            this.groupBoxAp.ResumeLayout(false);
            this.groupBoxLinkAp.ResumeLayout(false);
            this.groupBoxLinkAp.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.GroupBox groupBoxAp;
        public System.Windows.Forms.GroupBox groupBoxLinkAp;
        public System.Windows.Forms.LinkLabel linkLabelAp;
        private System.Windows.Forms.Button buttonCerrarAp;
        private System.Windows.Forms.Button buttonAgregarAp;
        public System.Windows.Forms.ComboBox comboBoxSeleccionarProfesorAp;
        public System.Windows.Forms.ComboBox comboBoxSeleccionarMateriaAp;
    }
}