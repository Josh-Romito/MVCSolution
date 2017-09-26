namespace MVC
{
    partial class newIssueForm
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
            this.submitButton = new System.Windows.Forms.Button();
            this.resolutionCountLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // submitButton
            // 
            this.submitButton.Location = new System.Drawing.Point(121, 161);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(136, 47);
            this.submitButton.TabIndex = 0;
            this.submitButton.Text = "Submit Issue";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // resolutionCountLabel
            // 
            this.resolutionCountLabel.AutoSize = true;
            this.resolutionCountLabel.Location = new System.Drawing.Point(135, 236);
            this.resolutionCountLabel.Name = "resolutionCountLabel";
            this.resolutionCountLabel.Size = new System.Drawing.Size(75, 13);
            this.resolutionCountLabel.TabIndex = 2;
            this.resolutionCountLabel.Text = "Issue Count: 0";
            // 
            // newIssueForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 324);
            this.Controls.Add(this.resolutionCountLabel);
            this.Controls.Add(this.submitButton);
            this.Name = "newIssueForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.Label resolutionCountLabel;
    }
}

