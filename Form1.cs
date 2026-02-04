namespace Week3Fuentes
{
    public partial class LBOccupation : Form
    {
        string nameLast, nameFirst, nameMiddle, GENDER, ADDRESS, EMAIL, NUMBER, MONTH;

        int DAY, YEAR;


        public LBOccupation()
        {
            InitializeComponent();
        }

        private void instruction_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e) //firstName
        {


        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)//month
        {
        }

        private void address_Click(object sender, EventArgs e)
        {
        }

        private void label4_Click_1(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)//exit
        {
            Application.Exit();
        }

        private void lastNameTextBox_TextChanged(object sender, EventArgs e)
        {
        }

        private void middleNameTextBox_TextChanged(object sender, EventArgs e)
        {
        }

        private void addressTextBox_TextChanged(object sender, EventArgs e)
        {
        }

        private void dayTextBox_TextChanged(object sender, EventArgs e)
        {
        }

        private void yearTextBox_TextChanged(object sender, EventArgs e)
        {
        }

        private void emailAddTextBox_TextChanged(object sender, EventArgs e)
        {
        }

        private void contactNumberTextBox_TextChanged(object sender, EventArgs e)
        {
        }

        private void genderTextBox_TextChanged(object sender, EventArgs e)
        {
        }

        private void occupationTextBox_TextChanged(object sender, EventArgs e)
        {
        }

        private void listBoxOcc_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxOcc.SelectedItem != null)
            {
                occupationTextBox.Text = listBoxOcc.SelectedItem.ToString();
            }
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            try
            {
                nameFirst = firstNameTextBox.Text;
                nameMiddle = middleNameTextBox.Text;
                nameLast = lastNameTextBox.Text;
                ADDRESS = addressTextBox.Text;
                EMAIL = emailAddTextBox.Text;
                NUMBER = contactNumberTextBox.Text;
                MONTH = monthTextBox.Text;

                DAY = int.Parse(dayTextBox.Text);
                YEAR = int.Parse(yearTextBox.Text);

                if (string.IsNullOrWhiteSpace(nameFirst) || string.IsNullOrWhiteSpace(nameLast) || string.IsNullOrWhiteSpace(ADDRESS) || string.IsNullOrWhiteSpace(EMAIL) || string.IsNullOrWhiteSpace(NUMBER) || string.IsNullOrWhiteSpace(MONTH) || string.IsNullOrWhiteSpace(dayTextBox.Text) || string.IsNullOrWhiteSpace(yearTextBox.Text))
                { 
                   MessageBox.Show("Please fill in all the required fields.");
                   return;
                }

                if (male.Checked)
                    GENDER = "Male";
                else if (female.Checked)
                    GENDER = "Female";
                else if (etc.Checked)
                    GENDER = genderTextBox.Text;

                if (!int.TryParse(dayTextBox.Text, out DAY) || !int.TryParse(yearTextBox.Text, out YEAR))
                {
                    MessageBox.Show("Please enter valid numeric values for Day and Year.");
                    return;
                }


                Form1Ext extension = new Form1Ext(nameLast, nameFirst, nameMiddle, ADDRESS, EMAIL, NUMBER, MONTH, DAY, YEAR);
                Form4 fourthForm = new Form4(nameLast, nameFirst, nameMiddle, ADDRESS, EMAIL, NUMBER, MONTH, DAY, YEAR);
                Form3 thirdForm = new Form3(nameLast, nameFirst, nameMiddle, ADDRESS, EMAIL, NUMBER, MONTH, DAY, YEAR);
                Form2 secondForm = new Form2(nameLast, nameFirst, nameMiddle, ADDRESS, EMAIL, NUMBER, MONTH, DAY, YEAR);

                extension.Show();

                this.Hide();
            }

            catch (FormatException)
            {
                MessageBox.Show("Make sure to fill up the necessary details provided and leave no blank.");
            }


        }


        private void male_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void female_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void etc_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void formClosed1(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
