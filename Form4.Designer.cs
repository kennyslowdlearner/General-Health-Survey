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
            SuspendLayout();
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(806, 207);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 0;
            // 
            // Title
            // 
            Title.AutoSize = true;
            Title.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Title.Location = new Point(67, 32);
            Title.Name = "Title";
            Title.Size = new Size(215, 50);
            Title.TabIndex = 4;
            Title.Text = "Thank You!";
            Title.Click += Title_Click;
            // 
            // instruction
            // 
            instruction.AutoSize = true;
            instruction.Font = new Font("Segoe UI Semibold", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            instruction.Location = new Point(90, 82);
            instruction.Name = "instruction";
            instruction.Size = new Size(171, 13);
            instruction.TabIndex = 5;
            instruction.Text = "Thank you for your cooperation!";
            // 
            // piName
            // 
            piName.AutoSize = true;
            piName.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            piName.Location = new Point(36, 114);
            piName.Name = "piName";
            piName.Size = new Size(50, 20);
            piName.TabIndex = 6;
            piName.Text = "Name";
            // 
            // address
            // 
            address.AutoSize = true;
            address.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            address.Location = new Point(36, 143);
            address.Name = "address";
            address.Size = new Size(63, 20);
            address.TabIndex = 12;
            address.Text = "Address";
            // 
            // birthDate
            // 
            birthDate.AutoSize = true;
            birthDate.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            birthDate.Location = new Point(36, 174);
            birthDate.Name = "birthDate";
            birthDate.Size = new Size(78, 20);
            birthDate.TabIndex = 15;
            birthDate.Text = "Birth Date";
            // 
            // emailAdd
            // 
            emailAdd.AutoSize = true;
            emailAdd.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            emailAdd.Location = new Point(36, 204);
            emailAdd.Name = "emailAdd";
            emailAdd.Size = new Size(104, 20);
            emailAdd.TabIndex = 23;
            emailAdd.Text = "Email Address";
            // 
            // contactNumber
            // 
            contactNumber.AutoSize = true;
            contactNumber.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            contactNumber.Location = new Point(36, 234);
            contactNumber.Name = "contactNumber";
            contactNumber.Size = new Size(122, 20);
            contactNumber.TabIndex = 25;
            contactNumber.Text = "Contact Number";
            // 
            // nameF
            // 
            nameF.Location = new Point(176, 114);
            nameF.Name = "nameF";
            nameF.Size = new Size(120, 23);
            nameF.TabIndex = 26;
            nameF.TextChanged += nameF_TextChanged;
            // 
            // addressF
            // 
            addressF.Location = new Point(176, 144);
            addressF.Name = "addressF";
            addressF.Size = new Size(120, 23);
            addressF.TabIndex = 27;
            addressF.TextChanged += addressF_TextChanged;
            // 
            // birthDateF
            // 
            birthDateF.Location = new Point(176, 171);
            birthDateF.Name = "birthDateF";
            birthDateF.Size = new Size(120, 23);
            birthDateF.TabIndex = 28;
            birthDateF.TextChanged += textBox2_TextChanged;
            // 
            // contactF
            // 
            contactF.Location = new Point(176, 229);
            contactF.Name = "contactF";
            contactF.Size = new Size(120, 23);
            contactF.TabIndex = 28;
            contactF.TextChanged += contactF_TextChanged;
            // 
            // emailF
            // 
            emailF.Location = new Point(176, 200);
            emailF.Name = "emailF";
            emailF.Size = new Size(120, 23);
            emailF.TabIndex = 29;
            emailF.TextChanged += emailF_TextChanged;
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(324, 380);
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
            Name = "Form4";
            Text = "Form4";
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
    }
}