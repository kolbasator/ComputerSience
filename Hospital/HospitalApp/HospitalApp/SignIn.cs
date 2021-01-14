using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using HospitalLibrary;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

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
        private void SignIn_Closing(object sender, EventArgs e)
        {
            BinaryFormatter formatter = new BinaryFormatter();

            using (FileStream fs = new FileStream("data.dat", FileMode.OpenOrCreate))
            {
                foreach(Employee n in Program.FirstHospital.Employees)
                    formatter.Serialize(fs, n);
                
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {

            BinaryFormatter formatter = new BinaryFormatter();
            NursesAndDoctors form2 = new NursesAndDoctors();
            if (File.Exists("data.dat") == true)
            {
                string[] strok = File.ReadAllLines("data.dat");
                if (strok.Length != 0)
                {
                    using (FileStream fs = new FileStream("data.dat", FileMode.OpenOrCreate))
                    {
                            Program.FirstHospital.Employees.Add((Employee)formatter.Deserialize(fs));
                    }
                }
                else
                {
                    Program.FirstHospital = new Hospital();
                }
            }
            else
            {
                Program.FirstHospital = new Hospital();
            }
            Calendar.SetData();
            GraphicMaker.SetGraphicForAllEmployees(Program.FirstHospital.Employees);
            Program.FirstHospital.Employees.Add(new Admin("Musyaka","Kolbasyaka",1,"Chebotarev","Kirill"));
            foreach (Employee n in Program.FirstHospital.Employees)
                if (textBox1.Text == n.Username && textBox3.Text == n.Password)
                {

                    string myString = Convert.ToString(n.GetType().Name);
                    if (myString != "Admin")
                    {
                        form2.textBox1.Text = null;
                        Program.FirstHospital.DataList = null;
                        foreach (Employee y in Program.FirstHospital.Employees)
                            if (Convert.ToString(y.GetType()) != "HospitalLibrary.Admin")
                            {
                                form2.textBox1.Text = null;
                                foreach (Employee employee in Program.FirstHospital.Employees)
                                    form2.textBox1.AppendText($"\n {employee.GetData()},WorkDays-{employee.Graphic}");
                                form2.textBox1.Text += Program.FirstHospital.DataList;
                                form2.Show();
                                break;
                            }
                        
                        break;
                    }
                    else
                    {

                        AdminPanel adminPanel = new AdminPanel();
                        foreach (Employee m in Program.FirstHospital.Employees)
                                Program.FirstHospital.DataList += $"{m.GetData()} ,Work days-{m.Graphic}";
                        adminPanel.textBox1.Text += Program.FirstHospital.DataList;
                        adminPanel.Show();
                    }

                }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
