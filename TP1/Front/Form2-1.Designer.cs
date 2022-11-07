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
            this.linkLabelAp2 = new System.Windows.Forms.LinkLabel();
            this.linkLabelAp = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
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
            // Form2_1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Name = "Form2_1";
            this.Text = "Form2_1";
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.GroupBox groupBoxLinkAp;
        public System.Windows.Forms.LinkLabel linkLabelAp2;
        private System.Windows.Forms.Button buttonAgregarAp;
        public System.Windows.Forms.Button buttonCerrarAp;
       
        public System.Windows.Forms.LinkLabel linkLabelAp;
    }
}