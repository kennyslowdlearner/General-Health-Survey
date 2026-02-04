using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using static System.Net.Mime.MediaTypeNames;
using static System.Runtime.InteropServices.JavaScript.JSType;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Week3Fuentes
{
    public partial class Form3 : Form
    {
        string fName3, mName3, lName3, ADDD3, EM3, NU3, MO3;
        int DA3, YE3;
        public Form3(string nameLast, string nameFirst, string nameMiddle, string ADDRESS, string EMAIL, string NUMBER, string MONTH, int DAY, int YEAR)
        {
            InitializeComponent();

            fName3 = nameFirst;
            mName3 = nameMiddle;
            lName3 = nameLast;
            ADDD3 = ADDRESS;
            EM3 = EMAIL;
            NU3 = NUMBER;
            MO3 = MONTH;
            DA3 = DAY;
            YE3 = YEAR;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
          
            if (!button1.Checked && !button2.Checked && !button3.Checked && !button4.Checked && !button5.Checked)
            {
                MessageBox.Show("Ensure to select your choice for Question 6.");
                return;
            }

           
            if (!radioButton1.Checked && !radioButton2.Checked && !radioButton3.Checked && !radioButton4.Checked && !radioButton5.Checked)
            {
                MessageBox.Show("Ensure to select your choice for Question 7.");
                return;
            }

           
            if (!radioButton6.Checked && !radioButton7.Checked && !radioButton8.Checked && !radioButton9.Checked && !radioButton10.Checked)
            {
                MessageBox.Show("Ensure to select your choice for Question 8.");
                return;
            }

           
            if (!radioButton11.Checked && !radioButton12.Checked && !radioButton13.Checked && !radioButton14.Checked && !radioButton15.Checked)
            {
                MessageBox.Show("Ensure to select your choice for Question 9.");
                return;
            }

            
            if (!radioButton16.Checked && !radioButton17.Checked && !radioButton18.Checked && !radioButton19.Checked && !radioButton20.Checked)
            {
                MessageBox.Show("Ensure to select your choice for Question 10.");
                return;
            }

            Form4 fourthform = new Form4(fName3, mName3, lName3, ADDD3, EM3, NU3, MO3, DA3, YE3);

            fourthform.Show();
            this.Hide();
        }

        private void buttonPrevious_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 backToForm2 = (Form2)System.Windows.Forms.Application.OpenForms["Form2"];
            backToForm2.Show();
        }

        private void button5_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void formClosed3(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
