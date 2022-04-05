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
    public partial class SupervisorForm : Form
    {
        public SupervisorForm()
        {
            InitializeComponent();
        }

        private void SupervisorForm_Load(object sender, EventArgs e)
        {
            FullNameLabel.Text += Program.LoggedUser.fullName;
        }
    }
}

