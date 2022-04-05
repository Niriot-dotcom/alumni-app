namespace _2P_DP_PatyLopez
{
    partial class StudentForm
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
            this.FullNameLabel = new System.Windows.Forms.Label();
            this.CareerLabel = new System.Windows.Forms.Label();
            this.BirthYearLabel = new System.Windows.Forms.Label();
            this.HometownLabel = new System.Windows.Forms.Label();
            this.DownloadGradesButton = new System.Windows.Forms.Button();
            this.GradesDgv = new System.Windows.Forms.DataGridView();
            this.CourseId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CourseName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Grade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.GradesDgv)).BeginInit();
            this.SuspendLayout();
            // 
            // FullNameLabel
            // 
            this.FullNameLabel.AutoSize = true;
            this.FullNameLabel.Location = new System.Drawing.Point(353, 42);
            this.FullNameLabel.Name = "FullNameLabel";
            this.FullNameLabel.Size = new System.Drawing.Size(131, 32);
            this.FullNameLabel.TabIndex = 0;
            this.FullNameLabel.Text = "Full name: ";
            // 
            // CareerLabel
            // 
            this.CareerLabel.AutoSize = true;
            this.CareerLabel.Location = new System.Drawing.Point(353, 104);
            this.CareerLabel.Name = "CareerLabel";
            this.CareerLabel.Size = new System.Drawing.Size(95, 32);
            this.CareerLabel.TabIndex = 1;
            this.CareerLabel.Text = "Career: ";
            // 
            // BirthYearLabel
            // 
            this.BirthYearLabel.AutoSize = true;
            this.BirthYearLabel.Location = new System.Drawing.Point(995, 42);
            this.BirthYearLabel.Name = "BirthYearLabel";
            this.BirthYearLabel.Size = new System.Drawing.Size(128, 32);
            this.BirthYearLabel.TabIndex = 2;
            this.BirthYearLabel.Text = "Birth year: ";
            // 
            // HometownLabel
            // 
            this.HometownLabel.AutoSize = true;
            this.HometownLabel.Location = new System.Drawing.Point(995, 104);
            this.HometownLabel.Name = "HometownLabel";
            this.HometownLabel.Size = new System.Drawing.Size(144, 32);
            this.HometownLabel.TabIndex = 3;
            this.HometownLabel.Text = "Hometown: ";
            // 
            // DownloadGradesButton
            // 
            this.DownloadGradesButton.Location = new System.Drawing.Point(767, 717);
            this.DownloadGradesButton.Name = "DownloadGradesButton";
            this.DownloadGradesButton.Size = new System.Drawing.Size(275, 100);
            this.DownloadGradesButton.TabIndex = 4;
            this.DownloadGradesButton.Text = "Download grades";
            this.DownloadGradesButton.UseVisualStyleBackColor = true;
            this.DownloadGradesButton.Click += new System.EventHandler(this.DownloadGradesButton_Click);
            // 
            // GradesDgv
            // 
            this.GradesDgv.AllowUserToAddRows = false;
            this.GradesDgv.AllowUserToDeleteRows = false;
            this.GradesDgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.GradesDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GradesDgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CourseId,
            this.CourseName,
            this.Grade});
            this.GradesDgv.Location = new System.Drawing.Point(353, 174);
            this.GradesDgv.Name = "GradesDgv";
            this.GradesDgv.ReadOnly = true;
            this.GradesDgv.RowHeadersWidth = 82;
            this.GradesDgv.RowTemplate.Height = 41;
            this.GradesDgv.Size = new System.Drawing.Size(1109, 524);
            this.GradesDgv.TabIndex = 5;
            // 
            // CourseId
            // 
            this.CourseId.HeaderText = "Course ID";
            this.CourseId.MinimumWidth = 10;
            this.CourseId.Name = "CourseId";
            this.CourseId.ReadOnly = true;
            // 
            // CourseName
            // 
            this.CourseName.HeaderText = "Course Name";
            this.CourseName.MinimumWidth = 10;
            this.CourseName.Name = "CourseName";
            this.CourseName.ReadOnly = true;
            // 
            // Grade
            // 
            this.Grade.HeaderText = "Grade";
            this.Grade.MinimumWidth = 10;
            this.Grade.Name = "Grade";
            this.Grade.ReadOnly = true;
            // 
            // StudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1474, 829);
            this.Controls.Add(this.GradesDgv);
            this.Controls.Add(this.DownloadGradesButton);
            this.Controls.Add(this.HometownLabel);
            this.Controls.Add(this.BirthYearLabel);
            this.Controls.Add(this.CareerLabel);
            this.Controls.Add(this.FullNameLabel);
            this.Name = "StudentForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StudentForm";
            this.Load += new System.EventHandler(this.StudentForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GradesDgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label FullNameLabel;
        private Label CareerLabel;
        private Label BirthYearLabel;
        private Label HometownLabel;
        private Button DownloadGradesButton;
        private DataGridView GradesDgv;
        private DataGridViewTextBoxColumn CourseId;
        private DataGridViewTextBoxColumn CourseName;
        private DataGridViewTextBoxColumn Grade;
    }
}