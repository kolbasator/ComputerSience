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
    public partial class ChangeEmployee : Form
    {
        public ChangeEmployee()
        {
            InitializeComponent();
        }
        public List<Button> greenButtons = new List<Button>();
        private void AnyButton_Click(object sender, EventArgs e)
        {
            var button = sender as Button;
            if (button.BackColor == Color.Gray)
            {
                button.BackColor = Color.GreenYellow;
                greenButtons.Add(button);
            }
            else if (button.BackColor == Color.GreenYellow)
            {

                button.BackColor = Color.Gray;
                greenButtons.Remove(button);
            }
        }

        private void button31_Click(object sender, EventArgs e)
        {
            for (int y = greenButtons.Count; y > 0; y--)
                if (Calendar.arrayOfLists[y].Contains(Calendar.arrayOfLists[y].FirstOrDefault(e => e.GetType().Name == this.textBox6.Text)) == true)
                {
                    MessageBox.Show(
                                        "It is busy day.", "Error");
                    this.Close();
                }



            if (greenButtons.Count > 10)
            {
                MessageBox.Show(
                    "To many days exception", "Error");
                this.Close();
            }
            if (this.textBox6.Text != "Nurse" && this.textBox6.Text != "Admin")
            {
                if (Convert.ToString(this.textBox1.Text).Length != 7)
                {
                    throw new WrongLengthGms();
                }
                try
                {
                    Convert.ToInt32(textBox1.Text);
                }
                catch (Exception exception)
                {
                    MessageBox.Show(
                        exception.Message);
                }
            }
            try
            {
                Convert.ToInt32(this.textBox5.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message);
                this.Close();

            }

            foreach (Employee employee in Program.FirstHospital.Employees)
                employee.Graphic = null;

            foreach (var l in Program.FirstHospital.Employees)
                if (l.GetData() == Program.FirstHospital.EmployeeForChange.GetData())
                {
                    if(Convert.ToString(l.GetType().Name) != "Cardiologist" && Convert.ToString(l.GetType().Name) == "Urologist" && Convert.ToString(l.GetType().Name) == "Laryngologist" && Convert.ToString(l.GetType().Name) == "Neurologist")
                    {
                        l.Name = this.textBox7.Text;
                        l.Surname = this.textBox6.Text;
                        l.IdNumber = Convert.ToInt32(this.textBox5.Text);
                        l.Password = this.textBox2.Text;
                        l.Username = this.textBox3.Text;

                    }
                    else
                    {
                        l.Name = this.textBox7.Text;
                        l.Surname = this.textBox6.Text;
                        l.IdNumber = Convert.ToInt32(this.textBox5.Text);
                        l.Password = this.textBox2.Text;
                        l.Username = this.textBox3.Text;

                    }
                }
            foreach (Button n in greenButtons)
                if (Calendar.arrayOfLists[Convert.ToInt32(n.Text)].Contains(Calendar.arrayOfLists[Convert.ToInt32(n.Text)].FirstOrDefault(e => Convert.ToString(e.GetType()) == Convert.ToString(Program.FirstHospital.EmployeeForChange.GetType().Name) == false)))
                {
                    Calendar.arrayOfLists[Convert.ToInt32(n.Text)].Add(Program.FirstHospital.Employees[Program.FirstHospital.Employees.Count - 1]);
                    Program.FirstHospital.Employees[Program.FirstHospital.Employees.Count - 1].WorkDayesList[Convert.ToInt32(n.Text)] = true;
                }
                else
                {

                    MessageBox.Show(
        $"Someone is already working these days! ",
        "Error");

                    this.Close();
                    break;
                }

            this.Close();
            GraphicMaker.SetGraphicForAllEmployees(Program.FirstHospital.Employees);


        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
