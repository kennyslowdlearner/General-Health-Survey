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
    public partial class Form2 : Form
    {
        string fName2, mName2, lName2, ADDD2, EM2, NU2, MO2;
        int DA2, YE2;
        public Form2(string nameLast, string nameFirst, string nameMiddle, string ADDRESS, string EMAIL, string NUMBER, string MONTH, int DAY, int YEAR)
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

        private void neither_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {


            this.Hide();
        }

        private void next_Click(object sender, EventArgs e)
        {
            //error including passing the sequence even if not all questions are answered
            if (!buttonAgree.Checked && !buttonNeither.Checked && !buttonDisagree.Checked)
            {
                MessageBox.Show("Ensure to select your choice each of the questions.");
                return;
            }
            
            else if (!radioButton1.Checked && !radioButton2.Checked && !radioButton3.Checked && !radioButton4.Checked && !radioButton5.Checked && !radioButton6.Checked)
            {
                MessageBox.Show("Ensure to select your choice each of the questions.");
                return;
            }
            
            else if (!radioButton7.Checked && !radioButton8.Checked && !radioButton9.Checked && !radioButton10.Checked && !radioButton11.Checked && !radioButton12.Checked)
            {
                MessageBox.Show("Ensure to select your choice each of the questions.");
                return;
            }


            Form3 form3 = new Form3(fName2, mName2, lName2, ADDD2, EM2, NU2, MO2, DA2, YE2);


            form3.Show();
            this.Hide();
        }

        private void formClosed2(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
