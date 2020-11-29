namespace PracticeForms.MainTask2
{
    partial class StartForm
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
            this.cmdOpenGreenPeaceForm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmdOpenGreenPeaceForm
            // 
            this.cmdOpenGreenPeaceForm.Location = new System.Drawing.Point(12, 12);
            this.cmdOpenGreenPeaceForm.Name = "cmdOpenGreenPeaceForm";
            this.cmdOpenGreenPeaceForm.Size = new System.Drawing.Size(180, 50);
            this.cmdOpenGreenPeaceForm.TabIndex = 0;
            this.cmdOpenGreenPeaceForm.Text = "Open GREEN_PEACE_FORM";
            this.cmdOpenGreenPeaceForm.UseVisualStyleBackColor = true;
            this.cmdOpenGreenPeaceForm.Click += new System.EventHandler(this.cmdOpenGreenPeaceForm_Click);
            // 
            // StartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cmdOpenGreenPeaceForm);
            this.Name = "StartForm";
            this.Text = "StartForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button cmdOpenGreenPeaceForm;
    }
}