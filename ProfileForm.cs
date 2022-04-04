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

        private Panel buttonPanel = new Panel();
        private DataGridView songsDataGridView = new DataGridView();
        private Button addNewRowButton = new Button();
        private Button deleteRowButton = new Button();
        public ProfileForm()
        {
            InitializeComponent();
        }

        private void ProfileForm_Load(object sender, EventArgs e)
        {
            //SetupLayout();
            //SetupDataGridView();
            //PopulateDataGridView();
        }

        private void songsDataGridView_CellFormatting(object sender,
        System.Windows.Forms.DataGridViewCellFormattingEventArgs e)
        {
            if (e != null)
            {
                if (this.songsDataGridView.Columns[e.ColumnIndex].Name == "Release Date")
                {
                    if (e.Value != null)
                    {
                        try
                        {
                            e.Value = DateTime.Parse(e.Value.ToString())
                                .ToLongDateString();
                            e.FormattingApplied = true;
                        }
                        catch (FormatException)
                        {
                            Console.WriteLine("{0} is not a valid date.", e.Value.ToString());
                        }
                    }
                }
            }
        }

        private void addNewRowButton_Click(object sender, EventArgs e)
        {
            this.songsDataGridView.Rows.Add();
        }

        private void deleteRowButton_Click(object sender, EventArgs e)
        {
            if (this.songsDataGridView.SelectedRows.Count > 0 &&
                this.songsDataGridView.SelectedRows[0].Index !=
                this.songsDataGridView.Rows.Count - 1)
            {
                this.songsDataGridView.Rows.RemoveAt(
                    this.songsDataGridView.SelectedRows[0].Index);
            }
        }

        private void SetupLayout()
        {
            //this.Size = new Size(600, 500);

            addNewRowButton.Text = "Add Row";
            addNewRowButton.Location = new Point(10, 10);
            addNewRowButton.Click += new EventHandler(addNewRowButton_Click);

            deleteRowButton.Text = "Delete Row";
            deleteRowButton.Location = new Point(100, 10);
            deleteRowButton.Click += new EventHandler(deleteRowButton_Click);

            buttonPanel.Controls.Add(addNewRowButton);
            buttonPanel.Controls.Add(deleteRowButton);
            buttonPanel.Height = 50;
            buttonPanel.Dock = DockStyle.Bottom;

            this.Controls.Add(this.buttonPanel);
        }

        private void SetupDataGridView()
        {
            this.Controls.Add(songsDataGridView);

            songsDataGridView.ColumnCount = 5;

            songsDataGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.Navy;
            songsDataGridView.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            songsDataGridView.ColumnHeadersDefaultCellStyle.Font =
                new Font(songsDataGridView.Font, FontStyle.Bold);

            songsDataGridView.Name = "songsDataGridView";
            songsDataGridView.Location = new Point(8, 8);
            songsDataGridView.Size = new Size(500, 250);
            songsDataGridView.AutoSizeRowsMode =
                DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            songsDataGridView.ColumnHeadersBorderStyle =
                DataGridViewHeaderBorderStyle.Single;
            songsDataGridView.CellBorderStyle = DataGridViewCellBorderStyle.Single;
            songsDataGridView.GridColor = Color.Black;
            songsDataGridView.RowHeadersVisible = false;

            songsDataGridView.Columns[0].Name = "Release Date";
            songsDataGridView.Columns[1].Name = "Track";
            songsDataGridView.Columns[2].Name = "Title";
            songsDataGridView.Columns[3].Name = "Artist";
            songsDataGridView.Columns[4].Name = "Album";
            songsDataGridView.Columns[4].DefaultCellStyle.Font =
                new Font(songsDataGridView.DefaultCellStyle.Font, FontStyle.Italic);

            songsDataGridView.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;
            songsDataGridView.MultiSelect = false;
            songsDataGridView.Dock = DockStyle.Fill;

            songsDataGridView.CellFormatting += new
                DataGridViewCellFormattingEventHandler(
                songsDataGridView_CellFormatting);
        }


        private void PopulateDataGridView()
        {

            string[] row0 = { "11/22/1968", "29", "Revolution 9",
            "Beatles", "The Beatles [White Album]" };
            string[] row1 = { "1960", "6", "Fools Rush In",
            "Frank Sinatra", "Nice 'N' Easy" };
            string[] row2 = { "11/11/1971", "1", "One of These Days",
            "Pink Floyd", "Meddle" };
            string[] row3 = { "1988", "7", "Where Is My Mind?",
            "Pixies", "Surfer Rosa" };
            string[] row4 = { "5/1981", "9", "Can't Find My Mind",
            "Cramps", "Psychedelic Jungle" };
            string[] row5 = { "6/10/2003", "13",
            "Scatterbrain. (As Dead As Leaves.)",
            "Radiohead", "Hail to the Thief" };
            string[] row6 = { "6/30/1992", "3", "Dress", "P J Harvey", "Dry" };

            songsDataGridView.Rows.Add(row0);
            songsDataGridView.Rows.Add(row1);
            songsDataGridView.Rows.Add(row2);
            songsDataGridView.Rows.Add(row3);
            songsDataGridView.Rows.Add(row4);
            songsDataGridView.Rows.Add(row5);
            songsDataGridView.Rows.Add(row6);

            songsDataGridView.Columns[0].DisplayIndex = 3;
            songsDataGridView.Columns[1].DisplayIndex = 4;
            songsDataGridView.Columns[2].DisplayIndex = 0;
            songsDataGridView.Columns[3].DisplayIndex = 1;
            songsDataGridView.Columns[4].DisplayIndex = 2;
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
