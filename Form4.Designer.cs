namespace Week3Fuentes
{
    partial class Form4
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            comboBox1 = new ComboBox();
            Title = new Label();
            instruction = new Label();
            piName = new Label();
            address = new Label();
            birthDate = new Label();
            emailAdd = new Label();
            contactNumber = new Label();
            nameF = new TextBox();
            addressF = new TextBox();
            birthDateF = new TextBox();
            contactF = new TextBox();
            emailF = new TextBox();
            buttonOkay = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(1151, 345);
            comboBox1.Margin = new Padding(4, 5, 4, 5);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(171, 33);
            comboBox1.TabIndex = 0;
            // 
            // Title
            // 
            Title.AutoSize = true;
            Title.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Title.Location = new Point(80, 40);
            Title.Margin = new Padding(4, 0, 4, 0);
            Title.Name = "Title";
            Title.Size = new Size(324, 74);
            Title.TabIndex = 4;
            Title.Text = "Thank You!";
            Title.Click += Title_Click;
            // 
            // instruction
            // 
            instruction.AutoSize = true;
            instruction.Font = new Font("Segoe UI Semibold", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            instruction.Location = new Point(112, 112);
            instruction.Margin = new Padding(4, 0, 4, 0);
            instruction.Name = "instruction";
            instruction.Size = new Size(260, 23);
            instruction.TabIndex = 5;
            instruction.Text = "Thank you for your cooperation!";
            instruction.Click += instruction_Click;
            // 
            // piName
            // 
            piName.AutoSize = true;
            piName.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            piName.Location = new Point(51, 190);
            piName.Margin = new Padding(4, 0, 4, 0);
            piName.Name = "piName";
            piName.Size = new Size(76, 31);
            piName.TabIndex = 6;
            piName.Text = "Name";
            // 
            // address
            // 
            address.AutoSize = true;
            address.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            address.Location = new Point(51, 238);
            address.Margin = new Padding(4, 0, 4, 0);
            address.Name = "address";
            address.Size = new Size(98, 31);
            address.TabIndex = 12;
            address.Text = "Address";
            // 
            // birthDate
            // 
            birthDate.AutoSize = true;
            birthDate.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            birthDate.Location = new Point(51, 290);
            birthDate.Margin = new Padding(4, 0, 4, 0);
            birthDate.Name = "birthDate";
            birthDate.Size = new Size(120, 31);
            birthDate.TabIndex = 15;
            birthDate.Text = "Birth Date";
            // 
            // emailAdd
            // 
            emailAdd.AutoSize = true;
            emailAdd.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            emailAdd.Location = new Point(51, 340);
            emailAdd.Margin = new Padding(4, 0, 4, 0);
            emailAdd.Name = "emailAdd";
            emailAdd.Size = new Size(125, 31);
            emailAdd.TabIndex = 23;
            emailAdd.Text = "Email Add.";
            // 
            // contactNumber
            // 
            contactNumber.AutoSize = true;
            contactNumber.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            contactNumber.Location = new Point(51, 390);
            contactNumber.Margin = new Padding(4, 0, 4, 0);
            contactNumber.Name = "contactNumber";
            contactNumber.Size = new Size(138, 31);
            contactNumber.TabIndex = 25;
            contactNumber.Text = "Contact No.";
            // 
            // nameF
            // 
            nameF.Location = new Point(192, 193);
            nameF.Margin = new Padding(4, 5, 4, 5);
            nameF.Name = "nameF";
            nameF.Size = new Size(229, 31);
            nameF.TabIndex = 26;
            nameF.TextChanged += nameF_TextChanged;
            // 
            // addressF
            // 
            addressF.Location = new Point(192, 243);
            addressF.Margin = new Padding(4, 5, 4, 5);
            addressF.Name = "addressF";
            addressF.Size = new Size(229, 31);
            addressF.TabIndex = 27;
            addressF.TextChanged += addressF_TextChanged;
            // 
            // birthDateF
            // 
            birthDateF.Location = new Point(192, 288);
            birthDateF.Margin = new Padding(4, 5, 4, 5);
            birthDateF.Name = "birthDateF";
            birthDateF.Size = new Size(229, 31);
            birthDateF.TabIndex = 28;
            birthDateF.TextChanged += textBox2_TextChanged;
            // 
            // contactF
            // 
            contactF.Location = new Point(192, 392);
            contactF.Margin = new Padding(4, 5, 4, 5);
            contactF.Name = "contactF";
            contactF.Size = new Size(229, 31);
            contactF.TabIndex = 28;
            contactF.TextChanged += contactF_TextChanged;
            // 
            // emailF
            // 
            emailF.Location = new Point(192, 336);
            emailF.Margin = new Padding(4, 5, 4, 5);
            emailF.Name = "emailF";
            emailF.Size = new Size(229, 31);
            emailF.TabIndex = 29;
            emailF.TextChanged += emailF_TextChanged;
            // 
            // buttonOkay
            // 
            buttonOkay.Location = new Point(176, 456);
            buttonOkay.Margin = new Padding(4, 5, 4, 5);
            buttonOkay.Name = "buttonOkay";
            buttonOkay.Size = new Size(107, 38);
            buttonOkay.TabIndex = 34;
            buttonOkay.Text = "OK";
            buttonOkay.UseVisualStyleBackColor = true;
            buttonOkay.Click += buttonOkay_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Emoji", 8F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(128, 136);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(212, 21);
            label1.TabIndex = 35;
            label1.Text = "Your responses are recorded.";
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(463, 529);
            Controls.Add(label1);
            Controls.Add(buttonOkay);
            Controls.Add(emailF);
            Controls.Add(contactF);
            Controls.Add(birthDateF);
            Controls.Add(addressF);
            Controls.Add(nameF);
            Controls.Add(contactNumber);
            Controls.Add(emailAdd);
            Controls.Add(birthDate);
            Controls.Add(address);
            Controls.Add(piName);
            Controls.Add(instruction);
            Controls.Add(Title);
            Controls.Add(comboBox1);
            Margin = new Padding(4, 5, 4, 5);
            Name = "Form4";
            Text = "Form4";
            FormClosed += formClosed;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBox1;
        private Label Title;
        private Label instruction;
        private Label piName;
        private Label address;
        private Label birthDate;
        private Label emailAdd;
        private Label contactNumber;
        private TextBox nameF;
        private TextBox addressF;
        private TextBox birthDateF;
        private TextBox contactF;
        private TextBox emailF;
        private Button buttonOkay;
        private Label label1;
    }
}