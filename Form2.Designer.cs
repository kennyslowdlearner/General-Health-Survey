namespace Week3Fuentes
{
    partial class Form2
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
            Title = new Label();
            instruction = new Label();
            Q1 = new GroupBox();
            buttonDisagree = new RadioButton();
            buttonNeither = new RadioButton();
            buttonAgree = new RadioButton();
            label1 = new Label();
            agree = new Label();
            neither = new Label();
            disagree = new Label();
            next = new Button();
            groupBox1 = new GroupBox();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton3 = new RadioButton();
            label2 = new Label();
            groupBox2 = new GroupBox();
            radioButton4 = new RadioButton();
            radioButton5 = new RadioButton();
            radioButton6 = new RadioButton();
            label3 = new Label();
            groupBox3 = new GroupBox();
            radioButton7 = new RadioButton();
            radioButton8 = new RadioButton();
            radioButton9 = new RadioButton();
            label4 = new Label();
            groupBox4 = new GroupBox();
            radioButton10 = new RadioButton();
            radioButton11 = new RadioButton();
            radioButton12 = new RadioButton();
            label5 = new Label();
            Q1.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            SuspendLayout();
            // 
            // Title
            // 
            Title.AutoSize = true;
            Title.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Title.Location = new Point(264, 15);
            Title.Margin = new Padding(4, 0, 4, 0);
            Title.Name = "Title";
            Title.Size = new Size(617, 74);
            Title.TabIndex = 1;
            Title.Text = "General Health Survey";
            // 
            // instruction
            // 
            instruction.AutoSize = true;
            instruction.Font = new Font("Segoe UI Semibold", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            instruction.Location = new Point(103, 98);
            instruction.Margin = new Padding(4, 0, 4, 0);
            instruction.Name = "instruction";
            instruction.Size = new Size(980, 23);
            instruction.TabIndex = 2;
            instruction.Text = "Below are the survey questionnairs for community assessment and evaluation. Kindly tick the button of your desired response.";
            // 
            // Q1
            // 
            Q1.Controls.Add(buttonDisagree);
            Q1.Controls.Add(buttonNeither);
            Q1.Controls.Add(buttonAgree);
            Q1.Controls.Add(label1);
            Q1.Location = new Point(43, 188);
            Q1.Margin = new Padding(4, 5, 4, 5);
            Q1.Name = "Q1";
            Q1.Padding = new Padding(4, 5, 4, 5);
            Q1.Size = new Size(1037, 110);
            Q1.TabIndex = 3;
            Q1.TabStop = false;
            Q1.Text = "Question 1";
            // 
            // buttonDisagree
            // 
            buttonDisagree.AutoSize = true;
            buttonDisagree.Location = new Point(979, 53);
            buttonDisagree.Margin = new Padding(4, 5, 4, 5);
            buttonDisagree.Name = "buttonDisagree";
            buttonDisagree.Size = new Size(21, 20);
            buttonDisagree.TabIndex = 3;
            buttonDisagree.TabStop = true;
            buttonDisagree.UseVisualStyleBackColor = true;
            // 
            // buttonNeither
            // 
            buttonNeither.AutoSize = true;
            buttonNeither.Location = new Point(830, 53);
            buttonNeither.Margin = new Padding(4, 5, 4, 5);
            buttonNeither.Name = "buttonNeither";
            buttonNeither.Size = new Size(21, 20);
            buttonNeither.TabIndex = 2;
            buttonNeither.TabStop = true;
            buttonNeither.UseVisualStyleBackColor = true;
            // 
            // buttonAgree
            // 
            buttonAgree.AutoSize = true;
            buttonAgree.Location = new Point(687, 52);
            buttonAgree.Margin = new Padding(4, 5, 4, 5);
            buttonAgree.Name = "buttonAgree";
            buttonAgree.Size = new Size(21, 20);
            buttonAgree.TabIndex = 1;
            buttonAgree.TabStop = true;
            buttonAgree.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 50);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(650, 25);
            label1.TabIndex = 0;
            label1.Text = "I have easy access to affordable fresh fruits and vegetables in my neighborhood.";
            // 
            // agree
            // 
            agree.AutoSize = true;
            agree.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            agree.Location = new Point(707, 150);
            agree.Margin = new Padding(4, 0, 4, 0);
            agree.Name = "agree";
            agree.Size = new Size(76, 31);
            agree.TabIndex = 4;
            agree.Text = "Agree";
            // 
            // neither
            // 
            neither.AutoSize = true;
            neither.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            neither.Location = new Point(846, 150);
            neither.Margin = new Padding(4, 0, 4, 0);
            neither.Name = "neither";
            neither.Size = new Size(92, 31);
            neither.TabIndex = 5;
            neither.Text = "Neither";
            neither.Click += neither_Click;
            // 
            // disagree
            // 
            disagree.AutoSize = true;
            disagree.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            disagree.Location = new Point(981, 150);
            disagree.Margin = new Padding(4, 0, 4, 0);
            disagree.Name = "disagree";
            disagree.Size = new Size(106, 31);
            disagree.TabIndex = 6;
            disagree.Text = "Disagree";
            // 
            // next
            // 
            next.Location = new Point(973, 832);
            next.Margin = new Padding(4, 5, 4, 5);
            next.Name = "next";
            next.Size = new Size(107, 38);
            next.TabIndex = 32;
            next.Text = "Next";
            next.UseVisualStyleBackColor = true;
            next.Click += next_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(radioButton1);
            groupBox1.Controls.Add(radioButton2);
            groupBox1.Controls.Add(radioButton3);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(43, 308);
            groupBox1.Margin = new Padding(4, 5, 4, 5);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4, 5, 4, 5);
            groupBox1.Size = new Size(1037, 110);
            groupBox1.TabIndex = 33;
            groupBox1.TabStop = false;
            groupBox1.Text = "Question 2";
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(979, 53);
            radioButton1.Margin = new Padding(4, 5, 4, 5);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(21, 20);
            radioButton1.TabIndex = 3;
            radioButton1.TabStop = true;
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(830, 53);
            radioButton2.Margin = new Padding(4, 5, 4, 5);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(21, 20);
            radioButton2.TabIndex = 2;
            radioButton2.TabStop = true;
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Location = new Point(687, 52);
            radioButton3.Margin = new Padding(4, 5, 4, 5);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(21, 20);
            radioButton3.TabIndex = 1;
            radioButton3.TabStop = true;
            radioButton3.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(23, 50);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(632, 25);
            label2.TabIndex = 0;
            label2.Text = "Local healthcare facilities (clinics/hospitals) are easily accessible from my home.";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(radioButton4);
            groupBox2.Controls.Add(radioButton5);
            groupBox2.Controls.Add(radioButton6);
            groupBox2.Controls.Add(label3);
            groupBox2.Location = new Point(43, 428);
            groupBox2.Margin = new Padding(4, 5, 4, 5);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(4, 5, 4, 5);
            groupBox2.Size = new Size(1037, 110);
            groupBox2.TabIndex = 4;
            groupBox2.TabStop = false;
            groupBox2.Text = "Question 3";
            // 
            // radioButton4
            // 
            radioButton4.AutoSize = true;
            radioButton4.Location = new Point(979, 53);
            radioButton4.Margin = new Padding(4, 5, 4, 5);
            radioButton4.Name = "radioButton4";
            radioButton4.Size = new Size(21, 20);
            radioButton4.TabIndex = 3;
            radioButton4.TabStop = true;
            radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton5
            // 
            radioButton5.AutoSize = true;
            radioButton5.Location = new Point(830, 53);
            radioButton5.Margin = new Padding(4, 5, 4, 5);
            radioButton5.Name = "radioButton5";
            radioButton5.Size = new Size(21, 20);
            radioButton5.TabIndex = 2;
            radioButton5.TabStop = true;
            radioButton5.UseVisualStyleBackColor = true;
            // 
            // radioButton6
            // 
            radioButton6.AutoSize = true;
            radioButton6.Location = new Point(687, 52);
            radioButton6.Margin = new Padding(4, 5, 4, 5);
            radioButton6.Name = "radioButton6";
            radioButton6.Size = new Size(21, 20);
            radioButton6.TabIndex = 1;
            radioButton6.TabStop = true;
            radioButton6.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(23, 50);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(616, 25);
            label3.TabIndex = 0;
            label3.Text = "There are enough safe outdoor spaces (parks/sidewalks) for physical activity.";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(radioButton7);
            groupBox3.Controls.Add(radioButton8);
            groupBox3.Controls.Add(radioButton9);
            groupBox3.Controls.Add(label4);
            groupBox3.Location = new Point(43, 548);
            groupBox3.Margin = new Padding(4, 5, 4, 5);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(4, 5, 4, 5);
            groupBox3.Size = new Size(1037, 110);
            groupBox3.TabIndex = 4;
            groupBox3.TabStop = false;
            groupBox3.Text = "Question 4";
            // 
            // radioButton7
            // 
            radioButton7.AutoSize = true;
            radioButton7.Location = new Point(979, 53);
            radioButton7.Margin = new Padding(4, 5, 4, 5);
            radioButton7.Name = "radioButton7";
            radioButton7.Size = new Size(21, 20);
            radioButton7.TabIndex = 3;
            radioButton7.TabStop = true;
            radioButton7.UseVisualStyleBackColor = true;
            // 
            // radioButton8
            // 
            radioButton8.AutoSize = true;
            radioButton8.Location = new Point(830, 53);
            radioButton8.Margin = new Padding(4, 5, 4, 5);
            radioButton8.Name = "radioButton8";
            radioButton8.Size = new Size(21, 20);
            radioButton8.TabIndex = 2;
            radioButton8.TabStop = true;
            radioButton8.UseVisualStyleBackColor = true;
            // 
            // radioButton9
            // 
            radioButton9.AutoSize = true;
            radioButton9.Location = new Point(687, 52);
            radioButton9.Margin = new Padding(4, 5, 4, 5);
            radioButton9.Name = "radioButton9";
            radioButton9.Size = new Size(21, 20);
            radioButton9.TabIndex = 1;
            radioButton9.TabStop = true;
            radioButton9.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(23, 50);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(583, 25);
            label4.TabIndex = 0;
            label4.Text = "I feel that the air and water quality in my community are generally good.";
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(radioButton10);
            groupBox4.Controls.Add(radioButton11);
            groupBox4.Controls.Add(radioButton12);
            groupBox4.Controls.Add(label5);
            groupBox4.Location = new Point(43, 668);
            groupBox4.Margin = new Padding(4, 5, 4, 5);
            groupBox4.Name = "groupBox4";
            groupBox4.Padding = new Padding(4, 5, 4, 5);
            groupBox4.Size = new Size(1037, 110);
            groupBox4.TabIndex = 4;
            groupBox4.TabStop = false;
            groupBox4.Text = "Question 5";
            // 
            // radioButton10
            // 
            radioButton10.AutoSize = true;
            radioButton10.Location = new Point(979, 53);
            radioButton10.Margin = new Padding(4, 5, 4, 5);
            radioButton10.Name = "radioButton10";
            radioButton10.Size = new Size(21, 20);
            radioButton10.TabIndex = 3;
            radioButton10.TabStop = true;
            radioButton10.UseVisualStyleBackColor = true;
            // 
            // radioButton11
            // 
            radioButton11.AutoSize = true;
            radioButton11.Location = new Point(830, 53);
            radioButton11.Margin = new Padding(4, 5, 4, 5);
            radioButton11.Name = "radioButton11";
            radioButton11.Size = new Size(21, 20);
            radioButton11.TabIndex = 2;
            radioButton11.TabStop = true;
            radioButton11.UseVisualStyleBackColor = true;
            // 
            // radioButton12
            // 
            radioButton12.AutoSize = true;
            radioButton12.Location = new Point(687, 52);
            radioButton12.Margin = new Padding(4, 5, 4, 5);
            radioButton12.Name = "radioButton12";
            radioButton12.Size = new Size(21, 20);
            radioButton12.TabIndex = 1;
            radioButton12.TabStop = true;
            radioButton12.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(23, 50);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(528, 25);
            label5.TabIndex = 0;
            label5.Text = "I am aware of the emergency health services available in this area.";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1143, 890);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(next);
            Controls.Add(disagree);
            Controls.Add(neither);
            Controls.Add(agree);
            Controls.Add(Q1);
            Controls.Add(instruction);
            Controls.Add(Title);
            Margin = new Padding(4, 5, 4, 5);
            Name = "Form2";
            Text = "Form2";
            FormClosed += formClosed2;
            Load += Form2_Load;
            Q1.ResumeLayout(false);
            Q1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Title;
        private Label instruction;
        private GroupBox Q1;
        private Label agree;
        private Label neither;
        private Label disagree;
        private RadioButton buttonDisagree;
        private RadioButton buttonNeither;
        private RadioButton buttonAgree;
        private Label label1;
        private Button next;
        private GroupBox groupBox1;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private RadioButton radioButton3;
        private Label label2;
        private GroupBox groupBox2;
        private RadioButton radioButton4;
        private RadioButton radioButton5;
        private RadioButton radioButton6;
        private Label label3;
        private GroupBox groupBox3;
        private RadioButton radioButton7;
        private RadioButton radioButton8;
        private RadioButton radioButton9;
        private Label label4;
        private GroupBox groupBox4;
        private RadioButton radioButton10;
        private RadioButton radioButton11;
        private RadioButton radioButton12;
        private Label label5;
    }
}