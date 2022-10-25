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
            this.groupBoxAm2 = new System.Windows.Forms.GroupBox();
            this.groupBoxLinkAm2 = new System.Windows.Forms.GroupBox();
            this.linkLabelAm2 = new System.Windows.Forms.LinkLabel();
            this.groupBoxLinkAm2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxAm2
            // 
            this.groupBoxAm2.Location = new System.Drawing.Point(467, 82);
            this.groupBoxAm2.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.groupBoxAm2.Name = "groupBoxAm2";
            this.groupBoxAm2.Size = new System.Drawing.Size(256, 300);
            this.groupBoxAm2.TabIndex = 20;
            this.groupBoxAm2.TabStop = false;
            this.groupBoxAm2.Visible = false;
            // 
            // groupBoxLinkAm2
            // 
            this.groupBoxLinkAm2.Controls.Add(this.linkLabelAm2);
            this.groupBoxLinkAm2.Location = new System.Drawing.Point(145, 143);
            this.groupBoxLinkAm2.Name = "groupBoxLinkAm2";
            this.groupBoxLinkAm2.Size = new System.Drawing.Size(220, 91);
            this.groupBoxLinkAm2.TabIndex = 22;
            this.groupBoxLinkAm2.TabStop = false;
            this.groupBoxLinkAm2.Visible = false;
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
            this.Controls.Add(this.groupBoxLinkAm2);
            this.Controls.Add(this.groupBoxAm2);
            this.Name = "Form2_1";
            this.Text = "Form2_1";
            this.groupBoxLinkAm2.ResumeLayout(false);
            this.groupBoxLinkAm2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.GroupBox groupBoxAm2;
        public System.Windows.Forms.GroupBox groupBoxLinkAm2;
        private System.Windows.Forms.LinkLabel linkLabelAm2;
    }
}