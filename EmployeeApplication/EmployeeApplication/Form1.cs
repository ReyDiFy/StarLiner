using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace EmployeeApplication
{
    public partial class Form1 : Form
    {
        string Fname = "";
        string Lname = "";
        string dept = "";
        string jobtitle = "";
        double RPH = 0;
        int THW = 0;
        public Form1()
        {
            InitializeComponent();
            
        }

        private void Fbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Lbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void DEPTbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Jbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void RPHbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void THWbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void ComputeSalaryLabel_Click(object sender, EventArgs e)
        {
            Fname = Fbox.Text;
            Lname = Lbox.Text;
            dept = DEPTbox.Text;
            jobtitle = Jbox.Text;
            RPH = Convert.ToDouble(RPHbox.Text);
            THW = Convert.ToInt32(THWbox.Text);
            PartTimeEmployee PE1 = new PartTimeEmployee(Fname, Lname, dept, jobtitle);
            FirstNameLabel.Text = "First Name: " + PE1.FirstName;
            LastNameLabel.Text = "Last Name: " + PE1.LastName;
            PE1.computeSalary(THW, RPH);

            SalaryLabel.Text = "Basic Salary: " + PE1.GetSalary().ToString("F2");

        }

        private void FirstNameLabel_Click(object sender, EventArgs e)
        {

        }

        private void LastNameLabel_Click(object sender, EventArgs e)
        {

        }

        private void SalaryLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
