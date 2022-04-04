namespace _2P_DP_PatyLopez
{
    partial class ProfileForm
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
            this.ProfileLabel = new System.Windows.Forms.Label();
            this.downloadGradesButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ProfileLabel
            // 
            this.ProfileLabel.AutoSize = true;
            this.ProfileLabel.Location = new System.Drawing.Point(60, 44);
            this.ProfileLabel.Name = "ProfileLabel";
            this.ProfileLabel.Size = new System.Drawing.Size(82, 32);
            this.ProfileLabel.TabIndex = 0;
            this.ProfileLabel.Text = "Profile";
            // 
            // downloadGradesButton
            // 
            this.downloadGradesButton.Location = new System.Drawing.Point(1162, 722);
            this.downloadGradesButton.Name = "downloadGradesButton";
            this.downloadGradesButton.Size = new System.Drawing.Size(240, 112);
            this.downloadGradesButton.TabIndex = 1;
            this.downloadGradesButton.Text = "Download grades";
            this.downloadGradesButton.UseVisualStyleBackColor = true;
            this.downloadGradesButton.Click += new System.EventHandler(this.downloadGradesButton_Click);
            // 
            // ProfileForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1448, 876);
            this.Controls.Add(this.downloadGradesButton);
            this.Controls.Add(this.ProfileLabel);
            this.Name = "ProfileForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ProfileForm";
            this.Load += new System.EventHandler(this.ProfileForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label ProfileLabel;
        private Button downloadGradesButton;
    }
}