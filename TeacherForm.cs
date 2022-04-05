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
    public partial class TeacherForm : Form
    {
        public TeacherForm()
        {
            InitializeComponent();
            // List<CourseWithGrade> studentGrades = new GetGradesByStudentId(Program.LoggedUser);
        }

        private void TeacherForm_Load(object sender, EventArgs e)
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
                Button btn = new Button();
                btn.Text = "Show grades";
                GradesDgv.Rows.Add(g.courseId, g.name, "Show grades");
            }
        }

        private void GradesDgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0)
            {
                string cellValue = senderGrid.Rows[e.RowIndex].Cells[0].Value.ToString();
                Console.WriteLine("hola click from column!" + cellValue);
            }
        }
    }
}
