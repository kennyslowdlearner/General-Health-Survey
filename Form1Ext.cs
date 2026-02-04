using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week3Fuentes
{
    public partial class Form1Ext : Form
    {
        string fName2, mName2, lName2, ADDD2, EM2, NU2, MO2;
        int DA2, YE2;
        public Form1Ext(string nameLast, string nameFirst, string nameMiddle, string ADDRESS, string EMAIL, string NUMBER, string MONTH, int DAY, int YEAR)
        {
            InitializeComponent();

            fName2 = nameFirst;
            mName2 = nameMiddle;
            lName2 = nameLast;
            ADDD2 = ADDRESS;
            EM2 = EMAIL;
            NU2 = NUMBER;
            MO2 = MONTH;
            DA2 = DAY;
            YE2 = YEAR;
        }

        private void Title_Click(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonPrevious_Click(object sender, EventArgs e)
        {
            this.Hide();
            LBOccupation backToForm1 = (LBOccupation)System.Windows.Forms.Application.OpenForms["LBOccupation "];
            backToForm1.Show();
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            if (!(checkBox1.Checked || checkBox2.Checked || checkBox3.Checked || checkBox4.Checked || checkBox5.Checked || checkBox6.Checked || checkBox7.Checked || checkBox8.Checked || checkBox9.Checked || checkBox10.Checked || checkBox11.Checked || checkBox12.Checked))
            {
                MessageBox.Show("Please select at least one condition in the checklist.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (checkBox6.Checked && string.IsNullOrWhiteSpace(textBox1.Text))
            {
                MessageBox.Show("Please specify the 'Others' value for the left checklist.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox1.Focus();
                return;
            }
            if (checkBox7.Checked && string.IsNullOrWhiteSpace(textBox2.Text))
            {
                MessageBox.Show("Please specify the 'Others' value for the right checklist.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox2.Focus();
                return;
            }

            if (!(radioButton1.Checked || radioButton2.Checked || radioButton3.Checked))
            {
                MessageBox.Show("Please answer whether you are pregnant.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!(radioButton4.Checked || radioButton5.Checked))
            {
                MessageBox.Show("Please indicate whether the medications are current.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(textBox3.Text) || string.IsNullOrWhiteSpace(textBox4.Text))
            {
                MessageBox.Show("Please enter both weight (kg) and height (cm) for BMI.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!double.TryParse(textBox3.Text, out var weight) || weight <= 0)
            {
                MessageBox.Show("Please enter a valid positive number for weight (kg).", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox3.Focus();
                return;
            }
            if (!double.TryParse(textBox4.Text, out var heightCm) || heightCm <= 0)
            {
                MessageBox.Show("Please enter a valid positive number for height (cm).", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox4.Focus();
                return;
            }

           
            Form2 secondfrom = new Form2(lName2, fName2, mName2, ADDD2, EM2, NU2, MO2, DA2, YE2);
            secondfrom.Show();
            this.Hide();
        }
    }
}
