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
            this.linkLabelAm2 = new System.Windows.Forms.LinkLabel();
            this.groupBoxLinkAm.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxAm
            // 
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
            this.groupBoxLinkAm.Controls.Add(this.linkLabelAm2);
            this.groupBoxLinkAm.Location = new System.Drawing.Point(145, 143);
            this.groupBoxLinkAm.Name = "groupBoxLinkAm";
            this.groupBoxLinkAm.Size = new System.Drawing.Size(220, 91);
            this.groupBoxLinkAm.TabIndex = 22;
            this.groupBoxLinkAm.TabStop = false;
            this.groupBoxLinkAm.Visible = false;
            // 
            // linkLabelAm2
            // 
            this.linkLabelAm2.AutoSize = true;
            this.linkLabelAm2.Location = new System.Drawing.Point(6, 22);
            this.linkLabelAm2.Name = "linkLabelAm2";
            this.linkLabelAm2.Size = new System.Drawing.Size(76, 15);
            this.linkLabelAm2.TabIndex = 21;
            this.linkLabelAm2.TabStop = true;
            this.linkLabelAm2.Text = "Alta materias";
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
            this.groupBoxLinkAm.ResumeLayout(false);
            this.groupBoxLinkAm.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.GroupBox groupBoxAm;
        public System.Windows.Forms.GroupBox groupBoxLinkAm;
        private System.Windows.Forms.LinkLabel linkLabelAm2;
    }
}