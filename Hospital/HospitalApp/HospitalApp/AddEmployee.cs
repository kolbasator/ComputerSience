using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using HospitalLibrary;

namespace HospitalApp
{
    public partial class AddEmployee : Form
    {
        public AddEmployee()
        {
            InitializeComponent();
        }
        public List<Button> greenButtons = new List<Button>();
        private void button13_Click(object sender, EventArgs e)
        {
            button13.BackColor = Color.GreenYellow;
            greenButtons.Add(button13);
        }

        private void button11_Click(object sender, EventArgs e)
        {

            button11.BackColor = Color.GreenYellow;
            greenButtons.Add(button11);

        }

        private void button29_Click(object sender, EventArgs e)
        {
            button29.BackColor = Color.GreenYellow;
            greenButtons.Add(button29);

        }

        private void button28_Click(object sender, EventArgs e)
        {
            button28.BackColor = Color.GreenYellow;
            greenButtons.Add(button28);
        }

        private void button27_Click(object sender, EventArgs e)
        {
            button27.BackColor = Color.GreenYellow;
            greenButtons.Add(button27);
        }

        private void button26_Click(object sender, EventArgs e)
        {
            button26.BackColor = Color.GreenYellow;
            greenButtons.Add(button26);
        }

        private void button25_Click(object sender, EventArgs e)
        {
            button25.BackColor = Color.GreenYellow;
            greenButtons.Add(button25);
        }

        private void button24_Click(object sender, EventArgs e)
        {
            button24.BackColor = Color.GreenYellow;
            greenButtons.Add(button24);
        }

        private void button23_Click(object sender, EventArgs e)
        {
            button23.BackColor = Color.GreenYellow;
            greenButtons.Add(button23);
        }

        private void button22_Click(object sender, EventArgs e)
        {
            button22.BackColor = Color.GreenYellow;
            greenButtons.Add(button22);
        }

        private void button21_Click(object sender, EventArgs e)
        {
            button21.BackColor = Color.GreenYellow;
            greenButtons.Add(button21);
        }

        private void button20_Click(object sender, EventArgs e)
        {
            button20.BackColor = Color.GreenYellow;
            greenButtons.Add(button20);
        }

        private void button19_Click(object sender, EventArgs e)
        {
            button19.BackColor = Color.GreenYellow;
            greenButtons.Add(button19);
        }

        private void button18_Click(object sender, EventArgs e)
        {
            button18.BackColor = Color.GreenYellow;
            greenButtons.Add(button18);
        }

        private void button17_Click(object sender, EventArgs e)
        {
            button17.BackColor = Color.GreenYellow;
            greenButtons.Add(button17);
        }

        private void button16_Click(object sender, EventArgs e)
        {
            button16.BackColor = Color.GreenYellow;
            greenButtons.Add(button16);
        }

        private void button15_Click(object sender, EventArgs e)
        {
            button15.BackColor = Color.GreenYellow;
            greenButtons.Add(button15);
        }

        private void button14_Click(object sender, EventArgs e)
        {
            button14.BackColor = Color.GreenYellow;
            greenButtons.Add(button14);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            button12.BackColor = Color.GreenYellow;
            greenButtons.Add(button12);
        }

        private void button30_Click(object sender, EventArgs e)
        {
            button30.BackColor = Color.GreenYellow;
            greenButtons.Add(button30);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            button10.BackColor = Color.GreenYellow;
            greenButtons.Add(button10);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            button9.BackColor = Color.GreenYellow;
            greenButtons.Add(button9);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            button8.BackColor = Color.GreenYellow;
            greenButtons.Add(button8);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            button7.BackColor = Color.GreenYellow;
            greenButtons.Add(button7);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            button6.BackColor = Color.GreenYellow;
            greenButtons.Add(button6);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            button5.BackColor = Color.GreenYellow;
            greenButtons.Add(button5);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            button4.BackColor = Color.GreenYellow;
            greenButtons.Add(button4);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button3.BackColor = Color.GreenYellow;
            greenButtons.Add(button3);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button2.BackColor = Color.GreenYellow;
            greenButtons.Add(button13);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.BackColor = Color.GreenYellow;
            greenButtons.Add(button1);
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
                if (Convert.ToString(this.textBox7.Text).Length != 7)
                {
                    throw new WrongLengthGms();
                }
                try
                {
                    Convert.ToInt32(textBox7.Text);
                }
                catch (Exception exception)
                {
                    MessageBox.Show(
                        exception.Message);
                }
            }
            try
            {
                Convert.ToInt32(this.textBox3.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message);
                this.Close();

            }



            switch (this.textBox6.Text)
            {
                case "Admin":
                    Program.FirstHospital.Employees.Add(new Admin(this.textBox1.Text, this.textBox2.Text, Convert.ToInt32(this.textBox3.Text), this.textBox5.Text, this.textBox4.Text));

                    break;
                case "Cardiologitst":
                    Program.FirstHospital.Employees.Add(new Cardiologist(this.textBox1.Text, this.textBox2.Text, Convert.ToInt32(this.textBox3.Text), this.textBox5.Text, this.textBox4.Text, Convert.ToInt32(this.textBox7.Text)));

                    break;
                case "Neurologist":
                    Program.FirstHospital.Employees.Add(new Neurologist(this.textBox1.Text, this.textBox2.Text, Convert.ToInt32(this.textBox3.Text), this.textBox5.Text, this.textBox4.Text, Convert.ToInt32(this.textBox7.Text)));

                    break;
                case "Urologist":
                    Program.FirstHospital.Employees.Add(new Urologist(this.textBox1.Text, this.textBox2.Text, Convert.ToInt32(this.textBox3.Text), this.textBox5.Text, this.textBox4.Text, Convert.ToInt32(this.textBox7.Text)));

                    break;
                case "Laryngologist":
                    Program.FirstHospital.Employees.Add(new Laryngologist(this.textBox1.Text, this.textBox2.Text, Convert.ToInt32(this.textBox3.Text), this.textBox5.Text, this.textBox4.Text, Convert.ToInt32(this.textBox7.Text)));

                    break;
                case "Nurse":
                    Program.FirstHospital.Employees.Add(new Nurse(this.textBox1.Text, this.textBox2.Text, Convert.ToInt32(this.textBox3.Text), this.textBox5.Text, this.textBox4.Text));

                    break;
                default:

                    break;
            }
            if (this.textBox6.Text != "Admin")
            {
                string type = this.textBox6.Text;
                foreach (Button n in greenButtons)
                    if (Calendar.arrayOfLists[Convert.ToInt32(n.Text)].Contains(Calendar.arrayOfLists[Convert.ToInt32(n.Text)].FirstOrDefault(e => Convert.ToString(e.GetType()) == type)) == false)
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
            }

        }
    }
}
