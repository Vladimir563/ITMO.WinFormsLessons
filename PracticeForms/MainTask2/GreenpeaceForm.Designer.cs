namespace PracticeForms
{
    partial class GreenpeaceForm
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
            this.cmdCloseGreenPeaceForm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmdCloseGreenPeaceForm
            // 
            this.cmdCloseGreenPeaceForm.Location = new System.Drawing.Point(140, 100);
            this.cmdCloseGreenPeaceForm.Name = "cmdCloseGreenPeaceForm";
            this.cmdCloseGreenPeaceForm.Size = new System.Drawing.Size(100, 50);
            this.cmdCloseGreenPeaceForm.TabIndex = 0;
            this.cmdCloseGreenPeaceForm.Text = "GREENPEACE";
            this.cmdCloseGreenPeaceForm.UseVisualStyleBackColor = true;
            this.cmdCloseGreenPeaceForm.Click += new System.EventHandler(this.cmdCloseGreenPeaceForm_Click);
            // 
            // GreenpeaceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Green;
            this.ClientSize = new System.Drawing.Size(384, 261);
            this.Controls.Add(this.cmdCloseGreenPeaceForm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GreenpeaceForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GreenpeaceForm";
            this.Load += new System.EventHandler(this.GreenpeaceForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button cmdCloseGreenPeaceForm;
    }
}