namespace Week3Fuentes
{
    public partial class LBOccupation : Form
    {
        string nameLast, nameFirst, nameMiddle, ADDRESS, EMAIL, NUMBER, MONTH;
        
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
            string firstName = firstNameTextBox.Text;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)//month
        {
            string month = monthTextBox.Text;
        }

        private void address_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click_1(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void lastNameTextBox_TextChanged(object sender, EventArgs e)
        {
            nameLast = lastNameTextBox.Text;
        }

        private void middleNameTextBox_TextChanged(object sender, EventArgs e)
        {
            nameMiddle = middleNameTextBox.Text;
        }

        private void addressTextBox_TextChanged(object sender, EventArgs e)
        {
           ADDRESS = addressTextBox.Text;

        }

        private void dayTextBox_TextChanged(object sender, EventArgs e)
        {
            DAY = int.Parse(dayTextBox.Text);
        }

        private void yearTextBox_TextChanged(object sender, EventArgs e)
        {
            YEAR = int.Parse(yearTextBox.Text);
        }

        private void emailAddTextBox_TextChanged(object sender, EventArgs e)
        {
            EMAIL = emailAddTextBox.Text;
        }

        private void contactNumberTextBox_TextChanged(object sender, EventArgs e)
        {
            NUMBER = contactNumberTextBox.Text;
        }

        private void genderTextBox_TextChanged(object sender, EventArgs e)
        {
            //string gender = genderTextBox.Text;
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
            Form4 fourthForm = new Form4(nameLast, nameFirst, nameMiddle, ADDRESS, EMAIL, NUMBER, MONTH, DAY, YEAR);
            Form2 secondForm = new Form2();

            secondForm.Show();

            this.Hide();
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
    }
}
