namespace MVC
{
    partial class resolutionForm
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
            this.resolveIssueButton = new System.Windows.Forms.Button();
            this.resolutionCountLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // resolveIssueButton
            // 
            this.resolveIssueButton.Location = new System.Drawing.Point(98, 99);
            this.resolveIssueButton.Name = "resolveIssueButton";
            this.resolveIssueButton.Size = new System.Drawing.Size(108, 37);
            this.resolveIssueButton.TabIndex = 0;
            this.resolveIssueButton.Text = "Issue Resolved";
            this.resolveIssueButton.UseVisualStyleBackColor = true;
            this.resolveIssueButton.Click += new System.EventHandler(this.resolveIssueButton_Click);
            // 
            // resolutionCountLabel
            // 
            this.resolutionCountLabel.AutoSize = true;
            this.resolutionCountLabel.Location = new System.Drawing.Point(106, 60);
            this.resolutionCountLabel.Name = "resolutionCountLabel";
            this.resolutionCountLabel.Size = new System.Drawing.Size(75, 13);
            this.resolutionCountLabel.TabIndex = 1;
            this.resolutionCountLabel.Text = "Issue Count: 0";
            this.resolutionCountLabel.Click += new System.EventHandler(this.resolutionCountLabel_Click);
            // 
            // resolutionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 319);
            this.Controls.Add(this.resolutionCountLabel);
            this.Controls.Add(this.resolveIssueButton);
            this.Name = "resolutionForm";
            this.Text = "resolutionForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button resolveIssueButton;
        private System.Windows.Forms.Label resolutionCountLabel;
    }
}