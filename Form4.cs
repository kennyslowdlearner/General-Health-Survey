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
        string fName, mName, lName, ADDD, EM, NU, MO, DA, YE;
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
            DA = DAY.ToString();
            YE = YEAR.ToString();
        }

        private void Title_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            birthDateF.Text = MO + " " + DA + ", " + YE;
        }

        private void nameF_TextChanged(object sender, EventArgs e)
        {
            nameF.Text = fName + mName + lName;
        }

        private void addressF_TextChanged(object sender, EventArgs e)
        {
            addressF.Text = ADDD;
        }

        private void emailF_TextChanged(object sender, EventArgs e)
        {
            emailF.Text = EM;
        }

        private void contactF_TextChanged(object sender, EventArgs e)
        {
            contactF.Text = NU;
        }
    }
}
