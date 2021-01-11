using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using HospitalLibrary;
using System.Linq;

namespace HospitalApp
{
    public partial class SignIn : Form
    {

        public SignIn()
        {
            InitializeComponent();
        }

        private void SignIn_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button2(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Program.FirstHospital.Employees.Add(new Cardiologist("Pavel", "Pechorin", 1, "12345", "Vrach", 1234567));
            Program.FirstHospital.Employees.Add(new Cardiologist("Petya", "Pechorin", 2, "54321", "Chelovek", 5687891));
            Program.FirstHospital.Employees.Add(new Cardiologist("Petro", "Kolosov", 3, "R", "Razumovsky", 5678084));
            Program.FirstHospital.Employees.Add(new Urologist("Kirill", "Chebotarev", 4, "Kolbasyaka", "Musyaka", 7683412));
            Program.FirstHospital.Employees.Add(new Urologist("Veronika", "Maksimova", 5, "12395", "Vrachiha", 4555544));
            Program.FirstHospital.Employees.Add(new Nurse("Pavel", "Pechorin", 6, "12345", "Vrach"));
            Program.FirstHospital.Employees.Add(new Neurologist("Pavel", "Gagarin", 1, "12345", "Vrach", 1234567));
            Calendar.SetData();
            foreach (Employee n in Program.FirstHospital.Employees)
                if (textBox1.Text == n.Username && textBox3.Text == n.Password)
                {
                    string myString = Convert.ToString(n.GetType());
                    if (myString != "Admin")
                    {
                        NursesAndDoctors form2 = new NursesAndDoctors();
                        foreach (Employee y in Program.FirstHospital.Employees)
                            if (Convert.ToString(y.GetType()) != "Admin")
                            {
                                y.MakeGraphic(8, Convert.ToString(y.GetType()), Calendar.arrayOfLists);
                                y.SetWorkDayes();
                                y.SetGraphic();
                                form2.textBox1.Text += y.GetInfo();

                            }


                        form2.Show();
                        break;
                    }
                }
        }
    }
}
