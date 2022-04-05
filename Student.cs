using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2P_DP_PatyLopez
{
    class Student : User
    {
        public void VisualizeForm()
        {
            StudentForm form = new StudentForm();
            form.ShowDialog();
        }
    }
}
