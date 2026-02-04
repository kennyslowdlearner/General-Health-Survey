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

            nameF.Text = fName + " " + mName + " " + lName;
            addressF.Text = ADDD;
            emailF.Text = EM;
            contactF.Text = NU;
            birthDateF.Text = MO + " " + DA + ", " + YE;

        }

        private void Title_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
        }

        private void nameF_TextChanged(object sender, EventArgs e)
        {

        }

        private void addressF_TextChanged(object sender, EventArgs e)
        {

        }

        private void emailF_TextChanged(object sender, EventArgs e)
        {
        }

        private void contactF_TextChanged(object sender, EventArgs e)
        {
        }

        private void formClosed(object sender, FormClosedEventArgs e) //behavior
        {
            Application.Exit();
        }

        private void buttonOkay_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
