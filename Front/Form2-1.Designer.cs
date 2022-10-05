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
            this.groupBoxAlta = new System.Windows.Forms.GroupBox();
            this.groupBoxAlta2 = new System.Windows.Forms.GroupBox();
            this.linkLabelRa = new System.Windows.Forms.LinkLabel();
            this.groupBoxAlta2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxAlta
            // 
            this.groupBoxAlta.Location = new System.Drawing.Point(467, 82);
            this.groupBoxAlta.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.groupBoxAlta.Name = "groupBoxAlta";
            this.groupBoxAlta.Size = new System.Drawing.Size(250, 299);
            this.groupBoxAlta.TabIndex = 20;
            this.groupBoxAlta.TabStop = false;
            this.groupBoxAlta.Visible = false;
            // 
            // groupBoxAlta2
            // 
            this.groupBoxAlta2.Controls.Add(this.linkLabelRa);
            this.groupBoxAlta2.Location = new System.Drawing.Point(145, 143);
            this.groupBoxAlta2.Name = "groupBoxAlta2";
            this.groupBoxAlta2.Size = new System.Drawing.Size(220, 100);
            this.groupBoxAlta2.TabIndex = 22;
            this.groupBoxAlta2.TabStop = false;
            this.groupBoxAlta2.Visible = false;
            // 
            // linkLabelRa
            // 
            this.linkLabelRa.AutoSize = true;
            this.linkLabelRa.Location = new System.Drawing.Point(6, 22);
            this.linkLabelRa.Name = "linkLabelRa";
            this.linkLabelRa.Size = new System.Drawing.Size(119, 15);
            this.linkLabelRa.TabIndex = 21;
            this.linkLabelRa.TabStop = true;
            this.linkLabelRa.Text = "Regularidad alumnos";
            // 
            // Form2_1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBoxAlta2);
            this.Controls.Add(this.groupBoxAlta);
            this.Name = "Form2_1";
            this.Text = "Form2_1";
            this.groupBoxAlta2.ResumeLayout(false);
            this.groupBoxAlta2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.GroupBox groupBoxAlta;
        public System.Windows.Forms.GroupBox groupBoxAlta2;
        private System.Windows.Forms.LinkLabel linkLabelRa;
    }
}