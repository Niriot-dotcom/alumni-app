using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace _2P_DP_PatyLopez
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            List<User> users = LoadUsers();

            if (users.Exists(u => u.username == usernameTextBox.Text))
            {
                User user = users.Find(u => u.username == usernameTextBox.Text);
                if (passwordTextBox.Text == user.password)
                {
                    Console.WriteLine("login success!");
                    this.Hide();
                    ProfileForm profileForm = new ProfileForm();
                    profileForm.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Password is wrong");
                }
            } else
            {
                MessageBox.Show("User does not exists");
            }
        }

        public static List<User> LoadUsers()
        {
            try
            {
                using (StreamReader r = new StreamReader("../../../dbUsers.json"))
                {
                    string json = r.ReadToEnd();
                    List<User> users = JsonConvert.DeserializeObject<List<User>>(json);
                    return users;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("\nexception:\n" + e.ToString());
                return new List<User>();
            }
        }
    }
}
