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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
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
            Form3 form3 = new Form3();

            form3.Show();
            this.Hide();
        }
    }
}
