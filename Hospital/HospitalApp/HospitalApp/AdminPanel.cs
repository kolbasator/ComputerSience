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
    public partial class AdminPanel : Form
    {
        public AdminPanel()
        {
            InitializeComponent();
        }
        
        private void button3_Click(object sender, EventArgs e)
        {

            foreach (Employee employee in Program.FirstHospital.Employees)
                employee.Graphic = null;
                this.textBox1.Text = null;
            GraphicMaker.SetGraphicForAllEmployees(Program.FirstHospital.Employees);
            foreach (Employee employee in Program.FirstHospital.Employees)
                this.textBox1.AppendText($"\n {employee.GetData()},WorkDays-{employee.Graphic}");

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void AdminPanel_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            AddEmployee add = new AddEmployee();
            add.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void AnyButton_Click(object sender, EventArgs e)
        {
            EditEmployee form = new EditEmployee();
            form.Show();
        }
    }
}
