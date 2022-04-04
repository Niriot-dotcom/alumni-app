using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Web;
using System.Net;
using Newtonsoft.Json;

namespace _2P_DP_PatyLopez
{
    public partial class ProfileForm : Form
    {
        public ProfileForm()
        {
            InitializeComponent();
        }

        private void ProfileForm_Load(object sender, EventArgs e)
        {

        }
        private void ProfileForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Console.WriteLine("profile form closing normal");
            // this.Hide();
        }

        class CourseWithGrade
        {
            public int courseId;
            public string name;
            public float grade;
        }

        class Grades
        {
            public int studentId;
            public string name;
            public List<CourseWithGrade> courses;
        }

        private void downloadGradesButton_Click(object sender, EventArgs e)
        {
            var gradesFormat = ConfigurationManager.AppSettings["GRADES_FORMAT"];
            Console.WriteLine("grades format: " + gradesFormat);
            downloadGrades(gradesFormat);
        }

        private void downloadGrades(string fileType)
        {
            if (fileType == "txt")
            {
                string path = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) + @"\grades.txt";
                //Check if the file exists
                if (!File.Exists(path))
                {
                    //using (StreamWriter writer = new StreamWriter(Response.OutputStream, Encoding.UTF8))
                    //{
                    //    writer.Write("This is the content");
                    //}
                    // Create the file and use streamWriter to write text to it.
                    //If the file existence is not check, this will overwrite said file.
                    //Use the using block so the file can close and vairable disposed correctly
                    using (StreamWriter writer = File.CreateText(path))
                    {
                        writer.WriteLine("\tGRADES");
                        writer.WriteLine("");
                        writer.WriteLine("---------------------------------------------");
                        writer.WriteLine("| Student: " + "Paty Lopez Mendez");
                        writer.WriteLine("---------------------------------------------");
                        writer.WriteLine("|          Course          |    Grade    |");
                        writer.WriteLine("| " + "math I           =>        7");
                        writer.WriteLine("| " + "math I           =>        8");
                        writer.WriteLine("| " + "math I           =>        9");
                        writer.WriteLine("| " + "math I           =>        10");
                        writer.WriteLine("---------------------------------------------");
                    }
                    Console.WriteLine("grades.txt created!");
                    Process.Start("explorer.exe", Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory));
                } else
                {
                    Console.WriteLine("grades.txt exists ...?");
                }
                // return Content("This is some text.", "text/plain");
                //return new File(new UTF8Encoding().GetBytes(csv.ToString()), "text/plain", "Export.csv"))
            }
            else if (fileType == "json")
            {
                string path = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) + @"\grades.json";
                if (!File.Exists(path))
                {
                    //using (StreamWriter writer = new StreamWriter(Response.OutputStream, Encoding.UTF8))
                    //{
                    //    writer.Write("This is the content");
                    //}
                    // Create the file and use streamWriter to write text to it.
                    //If the file existence is not check, this will overwrite said file.
                    //Use the using block so the file can close and vairable disposed correctly
                    using (StreamWriter writer = File.CreateText(path))
                    {
                        Grades studentGrades = new Grades()
                        {
                            studentId = 1,
                            name = "Paty Lopez Mendez",
                            courses = new List<CourseWithGrade>()
                            {
                                new CourseWithGrade()
                                {
                                    courseId = 1,
                                    name = "math I",
                                    grade = 7.8f
                                }
                            }
                        };
                        string stringjson = JsonConvert.SerializeObject(studentGrades, Formatting.Indented);
                        writer.Write(stringjson);
                    }
                    Console.WriteLine("grades.json created!");
                    Process.Start("explorer.exe", Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory));
                }
                else
                {
                    Console.WriteLine("grades.json exists ...?");
                }
            } else
            {
                Console.WriteLine("unknown file type to export grades");
                // please try with the following options: txt, docx
            }
        }
    }
}
