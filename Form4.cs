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
    public partial class Form4 : Form
    {
        string fName, mName, lName, ADDD, EM, NU, MO;
        int DA, YE;
        public Form4(string nameLast, string nameFirst, string nameMiddle, string ADDRESS, string EMAIL, string NUMBER, string MONTH, int DAY, int YEAR)
        {
            InitializeComponent();

            fName = nameFirst;
            mName = nameMiddle;
            lName = nameLast;
            ADDD = ADDRESS;
            EM = EMAIL;
            NU = NUMBER;
            MO = MONTH;
            DA = DAY;
            YE = YEAR;

           
            if (string.IsNullOrWhiteSpace(fName) && string.IsNullOrWhiteSpace(mName) && string.IsNullOrWhiteSpace(lName))
                nameF.Text = "No Name Provided";
            else
                nameF.Text = ($"{fName} {mName} {lName}").Replace("  ", " ").Trim();

           
            if (string.IsNullOrWhiteSpace(ADDD))
                addressF.Text = "No Address Provided";
            else
                addressF.Text = ADDD;

           
            if (string.IsNullOrWhiteSpace(EM))
                emailF.Text = "No Email Provided";      
            else
                emailF.Text = EM;

            
            if (string.IsNullOrWhiteSpace(NU))
                contactF.Text = "No Contact Number Provided";
            else
                contactF.Text = NU;

           
            if (string.IsNullOrWhiteSpace(MO) || DA <= 0 || YE <= 0)
                birthDateF.Text = "No Birth Date Provided";
            else
                birthDateF.Text = $"{MO} {DA}, {YE}";

        }

        private void Title_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
           
            if (string.IsNullOrWhiteSpace(MO) || DA <= 0 || YE <= 0)
            {
                if (birthDateF.Text != "No Birth Date Provided")
                    birthDateF.Text = "No Birth Date Provided";
            }
            else
            {
                var formatted = $"{MO} {DA}, {YE}";
                if (birthDateF.Text != formatted)
                    birthDateF.Text = formatted;
            }
        }

        private void nameF_TextChanged(object sender, EventArgs e)
        {
           
            string desired;
            if (String.IsNullOrWhiteSpace(fName) && String.IsNullOrWhiteSpace(mName) && String.IsNullOrWhiteSpace(lName))
                desired = "No Name Provided";
            else
                desired = ($"{fName} {mName} {lName}").Replace("  ", " ").Trim();

            if (nameF.Text != desired)
                nameF.Text = desired;
        }

        private void addressF_TextChanged(object sender, EventArgs e)
        {
            string desired = string.IsNullOrWhiteSpace(ADDD) ? "No Address Provided" : ADDD;
            if (addressF.Text != desired)
                addressF.Text = desired;
        }

        private void emailF_TextChanged(object sender, EventArgs e)
        {
            string desired = string.IsNullOrWhiteSpace(EM) ? "No Email Provided" : EM;
            if (emailF.Text != desired)
                emailF.Text = desired;
        }

        private void contactF_TextChanged(object sender, EventArgs e)
        {
            string desired = string.IsNullOrWhiteSpace(NU) ? "No Contact Number Provided" : NU;
            if (contactF.Text != desired)
                contactF.Text = desired;
        }

        private void formClosed(object sender, FormClosedEventArgs e) //behavior
        {
            Application.Exit();
        }

        private void buttonOkay_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void instruction_Click(object sender, EventArgs e)
        {

        }
    }
}
