using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using Newtonsoft.Json;

namespace _2P_DP_PatyLopez
{
    class CourseWithGrade
    {
        public int courseId;
        public string name;
        public float grade;
    }

    interface Format
    {
        void CreateFile(string studentName, List<CourseWithGrade> grades);
    }

    class TxtFormat : Format
    {
        public void CreateFile(string studentName, List<CourseWithGrade> grades)
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) + $"\\{studentName}_Grades.txt";
            if (File.Exists(path))
                File.Delete(path);

            using (StreamWriter writer = File.CreateText(path))
            {
                writer.WriteLine("\t\t\tGRADES");
                writer.WriteLine("");
                writer.WriteLine("---------------------------------------------");
                writer.WriteLine("| Student: " + studentName);
                writer.WriteLine("---------------------------------------------");
                writer.WriteLine("|          Course          |    Grade    |");
                writer.WriteLine("---------------------------------------------");
                foreach (CourseWithGrade c in grades)
                {
                    writer.WriteLine("|  " + c.name + "\t\t\t\t   " + c.grade);
                }
                writer.WriteLine("---------------------------------------------");
            }
            Process.Start("explorer.exe", Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory));
            // return Content("This is some text.", "text/plain");
            //return new File(new UTF8Encoding().GetBytes(csv.ToString()), "text/plain", "Export.csv"))
        }
    }

    class JsonFormat : Format
    {
        public void CreateFile(string studentName, List<CourseWithGrade> grades)
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) + $"\\{studentName}_Grades.json";
            if (File.Exists(path))
                File.Delete(path);

            using (StreamWriter writer = File.CreateText(path))
            {
                string stringjson = JsonConvert.SerializeObject(grades, Formatting.Indented);
                writer.Write(stringjson);
            }
            Console.WriteLine("grades.json created!");
            Process.Start("explorer.exe", Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory));
        }
    }
}
