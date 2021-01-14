using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using HospitalLibrary;

namespace HospitalApp
{
    public partial class EditEmployee : Form
    {
        public EditEmployee()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            foreach (Employee j in Program.FirstHospital.Employees)
                if( Convert.ToString(j.GetType().Name) == "Admin" || Convert.ToString(j.GetType().Name) == "Cardiologist" || Convert.ToString(j.GetType().Name) == "Urologist" || Convert.ToString(j.GetType().Name) == "Laryngologist" || Convert.ToString(j.GetType().Name) == "Neurologist" || Convert.ToString(j.GetType().Name) == "Nurse")
                {
                    if (Convert.ToString(j.GetType().Name) != "Cardiologist" && Convert.ToString(j.GetType().Name) == "Urologist" && Convert.ToString(j.GetType().Name) == "Laryngologist" && Convert.ToString(j.GetType().Name) == "Neurologist")
                    {

                        if (j.GetData() == $"{this.textBox1.Text},{this.textBox2.Text},id-{this.textBox3.Text},username-{this.textBox5.Text},password-{this.textBox6.Text}" && Convert.ToString(j.GetType().Name) != this.textBox4.Text)
                        {
                            ChangeEmployee form = new ChangeEmployee();
                            Program.FirstHospital.EmployeeForChange = j;
                            form.Show();
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show(
                                "User not found");
                            this.Close();
                        }
                    }
                    else
                    {

                        if (j.GetData() == $"{this.textBox1.Text},{this.textBox2.Text},id-{this.textBox3.Text},username-{this.textBox5.Text},password-{this.textBox6.Text},gmc -{this.textBox7.Text},type-{Convert.ToString(j.GetType())}" && Convert.ToString(j.GetType().Name) != this.textBox4.Text)
                        {
                            ChangeEmployee form = new ChangeEmployee();
                            Program.FirstHospital.EmployeeForChange = j;
                            form.Show();
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show(
                                "User not found");
                            this.Close();
                        }
                    }
                }
                else
                {
                    MessageBox.Show(
                        "Incorrect Type");
                    this.Close();
                }
                

        }
    }
}
