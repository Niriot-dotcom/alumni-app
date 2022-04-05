using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace _2P_DP_PatyLopez
{
    public partial class StudentForm : Form
    {
        public StudentForm()
        {
            InitializeComponent();
            // List<CourseWithGrade> studentGrades = new GetGradesByStudentId(Program.LoggedUser);
        }

        private void DownloadGradesButton_Click(object sender, EventArgs e)
        {
            List<CourseWithGrade> grades = new List<CourseWithGrade>()
            {
                new CourseWithGrade()
                {
                    courseId = 1,
                    name = "math 1",
                    grade = 7.8f
                },
                new CourseWithGrade()
                {
                    courseId = 2,
                    name = "physics",
                    grade = 8f
                },
                new CourseWithGrade()
                {
                    courseId = 3,
                    name = "history",
                    grade = 5.0f
                },
            };

            // App.config
            var gradesFormat = ConfigurationManager.AppSettings["GRADES_FORMAT"];

            if (gradesFormat == "json")
                new JsonFormat().CreateFile("Paty Lopez", grades);
            else if (gradesFormat == "txt")
                new TxtFormat().CreateFile("Paty Lopez", grades);
            else
                Console.WriteLine("unknown file type to export grades");
        }

        private void StudentForm_Load(object sender, EventArgs e)
        {
            FullNameLabel.Text += Program.LoggedUser.fullName;
            CareerLabel.Text += Program.LoggedUser.career;
            BirthYearLabel.Text += Program.LoggedUser.birthYear;
            HometownLabel.Text += Program.LoggedUser.hometown;

            List<CourseWithGrade> grades = new List<CourseWithGrade>()
            {
                new CourseWithGrade()
                {
                    courseId = 1,
                    name = "math 1",
                    grade = 7.8f
                },
                new CourseWithGrade()
                {
                    courseId = 2,
                    name = "physics",
                    grade = 8f
                },
                new CourseWithGrade()
                {
                    courseId = 3,
                    name = "history",
                    grade = 5.0f
                },
            };
            foreach (CourseWithGrade g in grades)
            {
                GradesDgv.Rows.Add(g.courseId, g.name, g.grade);
            }
        }
    }
}
