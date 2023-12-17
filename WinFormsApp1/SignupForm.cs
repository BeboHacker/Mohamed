using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class SignupForm : Form
    {
        public SignupForm()
        {
            InitializeComponent();
        }
        private void signup_Click(object sender, EventArgs e)
        {
            if ((conf_password.Text == password.Text)
                && 
                (admin_password.Text == Environment.GetEnvironmentVariable("admin_password")))
            {
                Employee employee = new Employee()
                {
                    name = name.Text,
                    username = username.Text,
                    password = password.Text,
                };
                var db = new Db();
                db.Database.EnsureCreated();
                db.employees.Add(employee);
                db.SaveChanges();
                MessageBox.Show("employee add", "OK");
                this.Close();
            }
            else
            {
                MessageBox.Show("the password is wrong", "ERROR");
            }
        }
    }
}
