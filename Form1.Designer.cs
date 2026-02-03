namespace Week3Fuentes
{
    partial class LBOccupation
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Title = new Label();
            instruction = new Label();
            piName = new Label();
            personalInformation = new Label();
            lastName = new Label();
            lastNameTextBox = new TextBox();
            firstNameTextBox = new TextBox();
            label1 = new Label();
            middleNameTextBox = new TextBox();
            middleName = new Label();
            firstName = new Label();
            address = new Label();
            addressTextBox = new TextBox();
            label3 = new Label();
            birthDate = new Label();
            monthTextBox = new TextBox();
            month = new Label();
            dayTextBox = new TextBox();
            yearTextBox = new TextBox();
            label2 = new Label();
            day = new Label();
            year = new Label();
            emailAddTextBox = new TextBox();
            emailAdd = new Label();
            contactNumberTextBox = new TextBox();
            contactNumber = new Label();
            gender = new Label();
            male = new RadioButton();
            female = new RadioButton();
            etc = new RadioButton();
            genderTextBox = new TextBox();
            nextButton = new Button();
            exitButton = new Button();
            label4 = new Label();
            label5 = new Label();
            occupationTextBox = new TextBox();
            listBoxOcc = new ListBox();
            SuspendLayout();
            // 
            // Title
            // 
            Title.AutoSize = true;
            Title.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Title.Location = new Point(156, 9);
            Title.Name = "Title";
            Title.Size = new Size(410, 50);
            Title.TabIndex = 0;
            Title.Text = "General Health Survey";
            // 
            // instruction
            // 
            instruction.AutoSize = true;
            instruction.Font = new Font("Segoe UI Semibold", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            instruction.Location = new Point(21, 59);
            instruction.Name = "instruction";
            instruction.Size = new Size(637, 13);
            instruction.TabIndex = 1;
            instruction.Text = "Kindly fill the necessary information below. Make sure to fill all the boxes and leave no empty boxes after you have settled. ";
            instruction.Click += instruction_Click;
            // 
            // piName
            // 
            piName.AutoSize = true;
            piName.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            piName.Location = new Point(30, 125);
            piName.Name = "piName";
            piName.Size = new Size(50, 20);
            piName.TabIndex = 2;
            piName.Text = "Name";
            piName.Click += label1_Click;
            // 
            // personalInformation
            // 
            personalInformation.AutoSize = true;
            personalInformation.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            personalInformation.Location = new Point(21, 84);
            personalInformation.Name = "personalInformation";
            personalInformation.Size = new Size(257, 32);
            personalInformation.TabIndex = 3;
            personalInformation.Text = "Personal Information";
            // 
            // lastName
            // 
            lastName.AutoSize = true;
            lastName.Location = new Point(57, 174);
            lastName.Name = "lastName";
            lastName.Size = new Size(63, 15);
            lastName.TabIndex = 4;
            lastName.Text = "Last Name";
            // 
            // lastNameTextBox
            // 
            lastNameTextBox.Location = new Point(32, 148);
            lastNameTextBox.Name = "lastNameTextBox";
            lastNameTextBox.Size = new Size(120, 23);
            lastNameTextBox.TabIndex = 5;
            lastNameTextBox.TextChanged += lastNameTextBox_TextChanged;
            // 
            // firstNameTextBox
            // 
            firstNameTextBox.Location = new Point(172, 148);
            firstNameTextBox.Name = "firstNameTextBox";
            firstNameTextBox.Size = new Size(120, 23);
            firstNameTextBox.TabIndex = 6;
            firstNameTextBox.TextChanged += textBox2_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(156, 156);
            label1.Name = "label1";
            label1.Size = new Size(10, 15);
            label1.TabIndex = 7;
            label1.Text = ",";
            label1.Click += label1_Click_1;
            // 
            // middleNameTextBox
            // 
            middleNameTextBox.Location = new Point(298, 148);
            middleNameTextBox.Name = "middleNameTextBox";
            middleNameTextBox.Size = new Size(120, 23);
            middleNameTextBox.TabIndex = 8;
            middleNameTextBox.TextChanged += middleNameTextBox_TextChanged;
            // 
            // middleName
            // 
            middleName.AutoSize = true;
            middleName.Location = new Point(326, 174);
            middleName.Name = "middleName";
            middleName.Size = new Size(79, 15);
            middleName.TabIndex = 9;
            middleName.Text = "Middle Name";
            // 
            // firstName
            // 
            firstName.AutoSize = true;
            firstName.Location = new Point(202, 175);
            firstName.Name = "firstName";
            firstName.Size = new Size(64, 15);
            firstName.TabIndex = 10;
            firstName.Text = "First Name";
            // 
            // address
            // 
            address.AutoSize = true;
            address.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            address.Location = new Point(32, 201);
            address.Name = "address";
            address.Size = new Size(63, 20);
            address.TabIndex = 11;
            address.Text = "Address";
            address.Click += address_Click;
            // 
            // addressTextBox
            // 
            addressTextBox.Location = new Point(30, 224);
            addressTextBox.Name = "addressTextBox";
            addressTextBox.Size = new Size(388, 23);
            addressTextBox.TabIndex = 12;
            addressTextBox.TextChanged += addressTextBox_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(57, 250);
            label3.Name = "label3";
            label3.Size = new Size(0, 15);
            label3.TabIndex = 13;
            // 
            // birthDate
            // 
            birthDate.AutoSize = true;
            birthDate.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            birthDate.Location = new Point(32, 265);
            birthDate.Name = "birthDate";
            birthDate.Size = new Size(78, 20);
            birthDate.TabIndex = 14;
            birthDate.Text = "Birth Date";
            birthDate.Click += label4_Click;
            // 
            // monthTextBox
            // 
            monthTextBox.Location = new Point(30, 288);
            monthTextBox.Name = "monthTextBox";
            monthTextBox.Size = new Size(120, 23);
            monthTextBox.TabIndex = 15;
            monthTextBox.TextChanged += textBox5_TextChanged;
            // 
            // month
            // 
            month.AutoSize = true;
            month.Location = new Point(67, 314);
            month.Name = "month";
            month.Size = new Size(43, 15);
            month.TabIndex = 16;
            month.Text = "Month";
            // 
            // dayTextBox
            // 
            dayTextBox.Location = new Point(156, 288);
            dayTextBox.Name = "dayTextBox";
            dayTextBox.Size = new Size(44, 23);
            dayTextBox.TabIndex = 17;
            dayTextBox.TextChanged += dayTextBox_TextChanged;
            // 
            // yearTextBox
            // 
            yearTextBox.Location = new Point(222, 288);
            yearTextBox.Name = "yearTextBox";
            yearTextBox.Size = new Size(120, 23);
            yearTextBox.TabIndex = 18;
            yearTextBox.TextChanged += yearTextBox_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(206, 296);
            label2.Name = "label2";
            label2.Size = new Size(10, 15);
            label2.TabIndex = 19;
            label2.Text = ",";
            // 
            // day
            // 
            day.AutoSize = true;
            day.Location = new Point(156, 314);
            day.Name = "day";
            day.Size = new Size(27, 15);
            day.TabIndex = 20;
            day.Text = "Day";
            day.Click += label4_Click_1;
            // 
            // year
            // 
            year.AutoSize = true;
            year.Location = new Point(263, 314);
            year.Name = "year";
            year.Size = new Size(29, 15);
            year.TabIndex = 21;
            year.Text = "Year";
            // 
            // emailAddTextBox
            // 
            emailAddTextBox.Location = new Point(30, 364);
            emailAddTextBox.Name = "emailAddTextBox";
            emailAddTextBox.Size = new Size(388, 23);
            emailAddTextBox.TabIndex = 23;
            emailAddTextBox.TextChanged += emailAddTextBox_TextChanged;
            // 
            // emailAdd
            // 
            emailAdd.AutoSize = true;
            emailAdd.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            emailAdd.Location = new Point(32, 341);
            emailAdd.Name = "emailAdd";
            emailAdd.Size = new Size(104, 20);
            emailAdd.TabIndex = 22;
            emailAdd.Text = "Email Address";
            // 
            // contactNumberTextBox
            // 
            contactNumberTextBox.Location = new Point(28, 425);
            contactNumberTextBox.Name = "contactNumberTextBox";
            contactNumberTextBox.Size = new Size(388, 23);
            contactNumberTextBox.TabIndex = 25;
            contactNumberTextBox.TextChanged += contactNumberTextBox_TextChanged;
            // 
            // contactNumber
            // 
            contactNumber.AutoSize = true;
            contactNumber.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            contactNumber.Location = new Point(30, 402);
            contactNumber.Name = "contactNumber";
            contactNumber.Size = new Size(122, 20);
            contactNumber.TabIndex = 24;
            contactNumber.Text = "Contact Number";
            // 
            // gender
            // 
            gender.AutoSize = true;
            gender.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            gender.Location = new Point(453, 125);
            gender.Name = "gender";
            gender.Size = new Size(59, 20);
            gender.TabIndex = 26;
            gender.Text = "Gender";
            // 
            // male
            // 
            male.AutoSize = true;
            male.Location = new Point(459, 152);
            male.Name = "male";
            male.Size = new Size(51, 19);
            male.TabIndex = 27;
            male.TabStop = true;
            male.Text = "Male";
            male.UseVisualStyleBackColor = true;
            male.CheckedChanged += male_CheckedChanged;
            // 
            // female
            // 
            female.AutoSize = true;
            female.Location = new Point(459, 174);
            female.Name = "female";
            female.Size = new Size(63, 19);
            female.TabIndex = 28;
            female.TabStop = true;
            female.Text = "Female";
            female.UseVisualStyleBackColor = true;
            female.CheckedChanged += female_CheckedChanged;
            // 
            // etc
            // 
            etc.AutoSize = true;
            etc.Location = new Point(459, 199);
            etc.Name = "etc";
            etc.Size = new Size(61, 19);
            etc.TabIndex = 29;
            etc.TabStop = true;
            etc.Text = "others:";
            etc.UseVisualStyleBackColor = true;
            // 
            // genderTextBox
            // 
            genderTextBox.Location = new Point(517, 198);
            genderTextBox.Name = "genderTextBox";
            genderTextBox.Size = new Size(90, 23);
            genderTextBox.TabIndex = 30;
            genderTextBox.TextChanged += genderTextBox_TextChanged;
            // 
            // nextButton
            // 
            nextButton.Location = new Point(451, 374);
            nextButton.Name = "nextButton";
            nextButton.Size = new Size(75, 23);
            nextButton.TabIndex = 31;
            nextButton.Text = "Next";
            nextButton.UseVisualStyleBackColor = true;
            nextButton.Click += nextButton_Click;
            // 
            // exitButton
            // 
            exitButton.Location = new Point(544, 374);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(75, 23);
            exitButton.TabIndex = 32;
            exitButton.Text = "Exit";
            exitButton.UseVisualStyleBackColor = true;
            exitButton.Click += button2_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(453, 245);
            label4.Name = "label4";
            label4.Size = new Size(87, 20);
            label4.TabIndex = 33;
            label4.Text = "Occupation";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(462, 269);
            label5.Name = "label5";
            label5.Size = new Size(50, 15);
            label5.TabIndex = 34;
            label5.Text = "Choose:";
            // 
            // occupationTextBox
            // 
            occupationTextBox.Location = new Point(518, 266);
            occupationTextBox.Name = "occupationTextBox";
            occupationTextBox.Size = new Size(90, 23);
            occupationTextBox.TabIndex = 35;
            occupationTextBox.TextChanged += occupationTextBox_TextChanged;
            // 
            // listBoxOcc
            // 
            listBoxOcc.FormattingEnabled = true;
            listBoxOcc.Items.AddRange(new object[] { "Student", "Employed", "Unemployed", "Senior Citizen", "OFW" });
            listBoxOcc.Location = new Point(517, 306);
            listBoxOcc.Name = "listBoxOcc";
            listBoxOcc.Size = new Size(107, 34);
            listBoxOcc.TabIndex = 36;
            listBoxOcc.SelectedIndexChanged += listBoxOcc_SelectedIndexChanged;
            // 
            // LBOccupation
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(689, 475);
            Controls.Add(listBoxOcc);
            Controls.Add(occupationTextBox);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(exitButton);
            Controls.Add(nextButton);
            Controls.Add(genderTextBox);
            Controls.Add(etc);
            Controls.Add(female);
            Controls.Add(male);
            Controls.Add(gender);
            Controls.Add(contactNumberTextBox);
            Controls.Add(contactNumber);
            Controls.Add(emailAddTextBox);
            Controls.Add(emailAdd);
            Controls.Add(year);
            Controls.Add(day);
            Controls.Add(label2);
            Controls.Add(yearTextBox);
            Controls.Add(dayTextBox);
            Controls.Add(month);
            Controls.Add(monthTextBox);
            Controls.Add(birthDate);
            Controls.Add(label3);
            Controls.Add(addressTextBox);
            Controls.Add(address);
            Controls.Add(firstName);
            Controls.Add(middleName);
            Controls.Add(middleNameTextBox);
            Controls.Add(label1);
            Controls.Add(firstNameTextBox);
            Controls.Add(lastNameTextBox);
            Controls.Add(lastName);
            Controls.Add(personalInformation);
            Controls.Add(piName);
            Controls.Add(instruction);
            Controls.Add(Title);
            Name = "LBOccupation";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Title;
        private Label instruction;
        private Label piName;
        private Label personalInformation;
        private Label lastName;
        private TextBox lastNameTextBox;
        private TextBox firstNameTextBox;
        private Label label1;
        private TextBox middleNameTextBox;
        private Label middleName;
        private Label firstName;
        private Label address;
        private TextBox addressTextBox;
        private Label label3;
        private Label birthDate;
        private TextBox monthTextBox;
        private Label month;
        private TextBox dayTextBox;
        private TextBox yearTextBox;
        private Label label2;
        private Label day;
        private Label year;
        private TextBox emailAddTextBox;
        private Label emailAdd;
        private TextBox contactNumberTextBox;
        private Label contactNumber;
        private Label gender;
        private RadioButton male;
        private RadioButton female;
        private RadioButton etc;
        private TextBox genderTextBox;
        private Button nextButton;
        private Button exitButton;
        private Label label4;
        private Label label5;
        private TextBox occupationTextBox;
        private ListBox listBoxOcc;
    }
}
