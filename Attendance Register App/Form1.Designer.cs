namespace Attendance_Register_App
{
    partial class AttendanceRegister
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
            this.dateLabel = new System.Windows.Forms.Label();
            this.submitButton = new System.Windows.Forms.Button();
            this.showDetailsButton = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panel6 = new System.Windows.Forms.Panel();
            this.backButton = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.period6Absent = new System.Windows.Forms.CheckBox();
            this.period6Present = new System.Windows.Forms.CheckBox();
            this.period5Absent = new System.Windows.Forms.CheckBox();
            this.period5Present = new System.Windows.Forms.CheckBox();
            this.period4Absent = new System.Windows.Forms.CheckBox();
            this.period4Present = new System.Windows.Forms.CheckBox();
            this.period3Absent = new System.Windows.Forms.CheckBox();
            this.period3Present = new System.Windows.Forms.CheckBox();
            this.period2Absent = new System.Windows.Forms.CheckBox();
            this.period2Present = new System.Windows.Forms.CheckBox();
            this.period1Absent = new System.Windows.Forms.CheckBox();
            this.period1Present = new System.Windows.Forms.CheckBox();
            this.period6 = new System.Windows.Forms.Label();
            this.period5 = new System.Windows.Forms.Label();
            this.period4 = new System.Windows.Forms.Label();
            this.period3 = new System.Windows.Forms.Label();
            this.period2 = new System.Windows.Forms.Label();
            this.period1 = new System.Windows.Forms.Label();
            this.dayLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.percentage6 = new System.Windows.Forms.Label();
            this.percentage5 = new System.Windows.Forms.Label();
            this.percentage4 = new System.Windows.Forms.Label();
            this.percentage3 = new System.Windows.Forms.Label();
            this.percentage2 = new System.Windows.Forms.Label();
            this.subject5Attendance = new System.Windows.Forms.Label();
            this.subject6Attendance = new System.Windows.Forms.Label();
            this.subject4Attendance = new System.Windows.Forms.Label();
            this.subject3Attendance = new System.Windows.Forms.Label();
            this.subject2Attendance = new System.Windows.Forms.Label();
            this.percentage1 = new System.Windows.Forms.Label();
            this.subject1Attendance = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.subject6 = new System.Windows.Forms.Label();
            this.subject5 = new System.Windows.Forms.Label();
            this.subject4 = new System.Windows.Forms.Label();
            this.subject3 = new System.Windows.Forms.Label();
            this.subject2 = new System.Windows.Forms.Label();
            this.subject1 = new System.Windows.Forms.Label();
            this.idDisplay = new System.Windows.Forms.Label();
            this.nameDisplay = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.teacherName = new Attendance_Register_App.UserControl1();
            this.Label10 = new System.Windows.Forms.Label();
            this.teacherLabel = new System.Windows.Forms.Label();
            this.panel6.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateLabel.Location = new System.Drawing.Point(49, 340);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(0, 26);
            this.dateLabel.TabIndex = 9;
            // 
            // submitButton
            // 
            this.submitButton.Location = new System.Drawing.Point(0, 0);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(158, 42);
            this.submitButton.TabIndex = 16;
            this.submitButton.Text = "SUBMIT";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // showDetailsButton
            // 
            this.showDetailsButton.Enabled = false;
            this.showDetailsButton.Location = new System.Drawing.Point(207, -1);
            this.showDetailsButton.Name = "showDetailsButton";
            this.showDetailsButton.Size = new System.Drawing.Size(149, 42);
            this.showDetailsButton.TabIndex = 17;
            this.showDetailsButton.Text = "DETAILS";
            this.showDetailsButton.UseVisualStyleBackColor = true;
            this.showDetailsButton.Click += new System.EventHandler(this.showDetailsButton_Click);
            // 
            // panel6
            // 
            this.panel6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.panel6.Controls.Add(this.backButton);
            this.panel6.Controls.Add(this.submitButton);
            this.panel6.Controls.Add(this.showDetailsButton);
            this.panel6.Location = new System.Drawing.Point(70, 720);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(613, 41);
            this.panel6.TabIndex = 36;
            this.panel6.Paint += new System.Windows.Forms.PaintEventHandler(this.panel6_Paint);
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(433, 0);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(135, 41);
            this.backButton.TabIndex = 18;
            this.backButton.Text = "BACK";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel3.Controls.Add(this.dateTimePicker1);
            this.panel3.Controls.Add(this.textBox2);
            this.panel3.Controls.Add(this.textBox1);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Location = new System.Drawing.Point(70, 85);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(553, 253);
            this.panel3.TabIndex = 35;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint_1);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(287, 171);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(218, 32);
            this.dateTimePicker1.TabIndex = 3;
            this.dateTimePicker1.Value = new System.DateTime(2025, 5, 11, 0, 0, 0, 0);
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged_1);
            // 
            // textBox2
            // 
            this.textBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(214, 131);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(164, 26);
            this.textBox2.TabIndex = 2;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged_1);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(128, 90);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(164, 26);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(28, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(334, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "ENTER STUDENT DETAILS";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(21, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 26);
            this.label3.TabIndex = 3;
            this.label3.Text = "NAME :";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(21, 177);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(230, 26);
            this.label5.TabIndex = 6;
            this.label5.Text = "ATTENDANCE DATE:";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(21, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(187, 26);
            this.label4.TabIndex = 4;
            this.label4.Text = "ADMISSION NO :";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel2.Controls.Add(this.period6Absent);
            this.panel2.Controls.Add(this.period6Present);
            this.panel2.Controls.Add(this.period5Absent);
            this.panel2.Controls.Add(this.period5Present);
            this.panel2.Controls.Add(this.period4Absent);
            this.panel2.Controls.Add(this.period4Present);
            this.panel2.Controls.Add(this.period3Absent);
            this.panel2.Controls.Add(this.period3Present);
            this.panel2.Controls.Add(this.period2Absent);
            this.panel2.Controls.Add(this.period2Present);
            this.panel2.Controls.Add(this.period1Absent);
            this.panel2.Controls.Add(this.period1Present);
            this.panel2.Controls.Add(this.period6);
            this.panel2.Controls.Add(this.period5);
            this.panel2.Controls.Add(this.period4);
            this.panel2.Controls.Add(this.period3);
            this.panel2.Controls.Add(this.period2);
            this.panel2.Controls.Add(this.period1);
            this.panel2.Controls.Add(this.dayLabel);
            this.panel2.Location = new System.Drawing.Point(96, 340);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(354, 336);
            this.panel2.TabIndex = 36;
            this.panel2.Visible = false;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint_1);
            // 
            // period6Absent
            // 
            this.period6Absent.AutoSize = true;
            this.period6Absent.Location = new System.Drawing.Point(259, 275);
            this.period6Absent.Name = "period6Absent";
            this.period6Absent.Size = new System.Drawing.Size(71, 20);
            this.period6Absent.TabIndex = 15;
            this.period6Absent.Text = "Absent";
            this.period6Absent.UseVisualStyleBackColor = true;
            this.period6Absent.CheckedChanged += new System.EventHandler(this.period6Absent_CheckedChanged_1);
            this.period6Absent.KeyDown += new System.Windows.Forms.KeyEventHandler(this.period6Absent_KeyDown);
            // 
            // period6Present
            // 
            this.period6Present.AutoSize = true;
            this.period6Present.Location = new System.Drawing.Point(119, 275);
            this.period6Present.Name = "period6Present";
            this.period6Present.Size = new System.Drawing.Size(75, 20);
            this.period6Present.TabIndex = 14;
            this.period6Present.Text = "Present";
            this.period6Present.UseVisualStyleBackColor = true;
            this.period6Present.CheckedChanged += new System.EventHandler(this.period6Present_CheckedChanged_1);
            this.period6Present.KeyDown += new System.Windows.Forms.KeyEventHandler(this.period6Present_KeyDown);
            // 
            // period5Absent
            // 
            this.period5Absent.AutoSize = true;
            this.period5Absent.Location = new System.Drawing.Point(259, 230);
            this.period5Absent.Name = "period5Absent";
            this.period5Absent.Size = new System.Drawing.Size(71, 20);
            this.period5Absent.TabIndex = 13;
            this.period5Absent.Text = "Absent";
            this.period5Absent.UseVisualStyleBackColor = true;
            this.period5Absent.CheckedChanged += new System.EventHandler(this.period5Absent_CheckedChanged_1);
            this.period5Absent.KeyDown += new System.Windows.Forms.KeyEventHandler(this.period5Absent_KeyDown);
            // 
            // period5Present
            // 
            this.period5Present.AutoSize = true;
            this.period5Present.Location = new System.Drawing.Point(119, 230);
            this.period5Present.Name = "period5Present";
            this.period5Present.Size = new System.Drawing.Size(75, 20);
            this.period5Present.TabIndex = 12;
            this.period5Present.Text = "Present";
            this.period5Present.UseVisualStyleBackColor = true;
            this.period5Present.CheckedChanged += new System.EventHandler(this.period5Present_CheckedChanged_1);
            this.period5Present.KeyDown += new System.Windows.Forms.KeyEventHandler(this.period5Present_KeyDown);
            // 
            // period4Absent
            // 
            this.period4Absent.AutoSize = true;
            this.period4Absent.Location = new System.Drawing.Point(259, 185);
            this.period4Absent.Name = "period4Absent";
            this.period4Absent.Size = new System.Drawing.Size(71, 20);
            this.period4Absent.TabIndex = 11;
            this.period4Absent.Text = "Absent";
            this.period4Absent.UseVisualStyleBackColor = true;
            this.period4Absent.CheckedChanged += new System.EventHandler(this.period4Absent_CheckedChanged_1);
            this.period4Absent.KeyDown += new System.Windows.Forms.KeyEventHandler(this.period4Absent_KeyDown);
            // 
            // period4Present
            // 
            this.period4Present.AutoSize = true;
            this.period4Present.Location = new System.Drawing.Point(119, 185);
            this.period4Present.Name = "period4Present";
            this.period4Present.Size = new System.Drawing.Size(75, 20);
            this.period4Present.TabIndex = 10;
            this.period4Present.Text = "Present";
            this.period4Present.UseVisualStyleBackColor = true;
            this.period4Present.CheckedChanged += new System.EventHandler(this.period4Present_CheckedChanged_1);
            this.period4Present.KeyDown += new System.Windows.Forms.KeyEventHandler(this.period4Present_KeyDown);
            // 
            // period3Absent
            // 
            this.period3Absent.AutoSize = true;
            this.period3Absent.Location = new System.Drawing.Point(259, 143);
            this.period3Absent.Name = "period3Absent";
            this.period3Absent.Size = new System.Drawing.Size(71, 20);
            this.period3Absent.TabIndex = 9;
            this.period3Absent.Text = "Absent";
            this.period3Absent.UseVisualStyleBackColor = true;
            this.period3Absent.CheckedChanged += new System.EventHandler(this.period3Absent_CheckedChanged_1);
            this.period3Absent.KeyDown += new System.Windows.Forms.KeyEventHandler(this.period3Absent_KeyDown);
            // 
            // period3Present
            // 
            this.period3Present.AutoSize = true;
            this.period3Present.Location = new System.Drawing.Point(119, 142);
            this.period3Present.Name = "period3Present";
            this.period3Present.Size = new System.Drawing.Size(75, 20);
            this.period3Present.TabIndex = 8;
            this.period3Present.Text = "Present";
            this.period3Present.UseVisualStyleBackColor = true;
            this.period3Present.CheckedChanged += new System.EventHandler(this.period3Present_CheckedChanged_1);
            this.period3Present.KeyDown += new System.Windows.Forms.KeyEventHandler(this.period3Present_KeyDown);
            // 
            // period2Absent
            // 
            this.period2Absent.AutoSize = true;
            this.period2Absent.Location = new System.Drawing.Point(259, 100);
            this.period2Absent.Name = "period2Absent";
            this.period2Absent.Size = new System.Drawing.Size(71, 20);
            this.period2Absent.TabIndex = 7;
            this.period2Absent.Text = "Absent";
            this.period2Absent.UseVisualStyleBackColor = true;
            this.period2Absent.CheckedChanged += new System.EventHandler(this.period2Absent_CheckedChanged_1);
            this.period2Absent.KeyDown += new System.Windows.Forms.KeyEventHandler(this.period2Absent_KeyDown);
            // 
            // period2Present
            // 
            this.period2Present.AutoSize = true;
            this.period2Present.Location = new System.Drawing.Point(119, 100);
            this.period2Present.Name = "period2Present";
            this.period2Present.Size = new System.Drawing.Size(75, 20);
            this.period2Present.TabIndex = 6;
            this.period2Present.Text = "Present";
            this.period2Present.UseVisualStyleBackColor = true;
            this.period2Present.CheckedChanged += new System.EventHandler(this.period2Present_CheckedChanged);
            this.period2Present.KeyDown += new System.Windows.Forms.KeyEventHandler(this.period2Present_KeyDown);
            // 
            // period1Absent
            // 
            this.period1Absent.AutoSize = true;
            this.period1Absent.Location = new System.Drawing.Point(259, 50);
            this.period1Absent.Name = "period1Absent";
            this.period1Absent.Size = new System.Drawing.Size(71, 20);
            this.period1Absent.TabIndex = 5;
            this.period1Absent.Text = "Absent";
            this.period1Absent.UseVisualStyleBackColor = true;
            this.period1Absent.CheckedChanged += new System.EventHandler(this.period1Absent_CheckedChanged);
            this.period1Absent.KeyDown += new System.Windows.Forms.KeyEventHandler(this.period1Absent_KeyDown);
            // 
            // period1Present
            // 
            this.period1Present.AutoSize = true;
            this.period1Present.Location = new System.Drawing.Point(119, 50);
            this.period1Present.Name = "period1Present";
            this.period1Present.Size = new System.Drawing.Size(75, 20);
            this.period1Present.TabIndex = 4;
            this.period1Present.Text = "Present";
            this.period1Present.UseVisualStyleBackColor = true;
            this.period1Present.CheckedChanged += new System.EventHandler(this.period1Present_CheckedChanged);
            this.period1Present.KeyDown += new System.Windows.Forms.KeyEventHandler(this.period1Present_KeyDown);
            // 
            // period6
            // 
            this.period6.AutoSize = true;
            this.period6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.period6.Location = new System.Drawing.Point(3, 275);
            this.period6.Name = "period6";
            this.period6.Size = new System.Drawing.Size(71, 20);
            this.period6.TabIndex = 27;
            this.period6.Text = "Period 6";
            // 
            // period5
            // 
            this.period5.AutoSize = true;
            this.period5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.period5.Location = new System.Drawing.Point(3, 230);
            this.period5.Name = "period5";
            this.period5.Size = new System.Drawing.Size(71, 20);
            this.period5.TabIndex = 24;
            this.period5.Text = "Period 5";
            // 
            // period4
            // 
            this.period4.AutoSize = true;
            this.period4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.period4.Location = new System.Drawing.Point(3, 185);
            this.period4.Name = "period4";
            this.period4.Size = new System.Drawing.Size(71, 20);
            this.period4.TabIndex = 21;
            this.period4.Text = "Period 4";
            // 
            // period3
            // 
            this.period3.AutoSize = true;
            this.period3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.period3.Location = new System.Drawing.Point(3, 141);
            this.period3.Name = "period3";
            this.period3.Size = new System.Drawing.Size(71, 20);
            this.period3.TabIndex = 18;
            this.period3.Text = "Period 3";
            // 
            // period2
            // 
            this.period2.AutoSize = true;
            this.period2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.period2.Location = new System.Drawing.Point(3, 98);
            this.period2.Name = "period2";
            this.period2.Size = new System.Drawing.Size(71, 20);
            this.period2.TabIndex = 15;
            this.period2.Text = "Period 2";
            // 
            // period1
            // 
            this.period1.AutoSize = true;
            this.period1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.period1.Location = new System.Drawing.Point(3, 50);
            this.period1.Name = "period1";
            this.period1.Size = new System.Drawing.Size(71, 20);
            this.period1.TabIndex = 12;
            this.period1.Text = "Period 1";
            // 
            // dayLabel
            // 
            this.dayLabel.AutoSize = true;
            this.dayLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dayLabel.Location = new System.Drawing.Point(2, 4);
            this.dayLabel.Name = "dayLabel";
            this.dayLabel.Size = new System.Drawing.Size(183, 26);
            this.dayLabel.TabIndex = 28;
            this.dayLabel.Text = "CURRENT DATE";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.teacherLabel);
            this.panel1.Controls.Add(this.Label10);
            this.panel1.Controls.Add(this.percentage6);
            this.panel1.Controls.Add(this.percentage5);
            this.panel1.Controls.Add(this.percentage4);
            this.panel1.Controls.Add(this.percentage3);
            this.panel1.Controls.Add(this.percentage2);
            this.panel1.Controls.Add(this.subject5Attendance);
            this.panel1.Controls.Add(this.subject6Attendance);
            this.panel1.Controls.Add(this.subject4Attendance);
            this.panel1.Controls.Add(this.subject3Attendance);
            this.panel1.Controls.Add(this.subject2Attendance);
            this.panel1.Controls.Add(this.percentage1);
            this.panel1.Controls.Add(this.subject1Attendance);
            this.panel1.Controls.Add(this.label20);
            this.panel1.Controls.Add(this.label19);
            this.panel1.Controls.Add(this.label18);
            this.panel1.Controls.Add(this.subject6);
            this.panel1.Controls.Add(this.subject5);
            this.panel1.Controls.Add(this.subject4);
            this.panel1.Controls.Add(this.subject3);
            this.panel1.Controls.Add(this.subject2);
            this.panel1.Controls.Add(this.subject1);
            this.panel1.Controls.Add(this.idDisplay);
            this.panel1.Controls.Add(this.nameDisplay);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Location = new System.Drawing.Point(666, 85);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(482, 604);
            this.panel1.TabIndex = 37;
            this.panel1.Visible = false;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // percentage6
            // 
            this.percentage6.AutoSize = true;
            this.percentage6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.percentage6.Location = new System.Drawing.Point(355, 542);
            this.percentage6.Name = "percentage6";
            this.percentage6.Size = new System.Drawing.Size(108, 20);
            this.percentage6.TabIndex = 48;
            this.percentage6.Text = "Percentage 6";
            // 
            // percentage5
            // 
            this.percentage5.AutoSize = true;
            this.percentage5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.percentage5.Location = new System.Drawing.Point(355, 495);
            this.percentage5.Name = "percentage5";
            this.percentage5.Size = new System.Drawing.Size(108, 20);
            this.percentage5.TabIndex = 47;
            this.percentage5.Text = "Percentage 5";
            // 
            // percentage4
            // 
            this.percentage4.AutoSize = true;
            this.percentage4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.percentage4.Location = new System.Drawing.Point(355, 449);
            this.percentage4.Name = "percentage4";
            this.percentage4.Size = new System.Drawing.Size(108, 20);
            this.percentage4.TabIndex = 46;
            this.percentage4.Text = "Percentage 4";
            // 
            // percentage3
            // 
            this.percentage3.AutoSize = true;
            this.percentage3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.percentage3.Location = new System.Drawing.Point(355, 405);
            this.percentage3.Name = "percentage3";
            this.percentage3.Size = new System.Drawing.Size(108, 20);
            this.percentage3.TabIndex = 45;
            this.percentage3.Text = "Percentage 3";
            // 
            // percentage2
            // 
            this.percentage2.AutoSize = true;
            this.percentage2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.percentage2.Location = new System.Drawing.Point(355, 362);
            this.percentage2.Name = "percentage2";
            this.percentage2.Size = new System.Drawing.Size(108, 20);
            this.percentage2.TabIndex = 44;
            this.percentage2.Text = "Percentage 2";
            // 
            // subject5Attendance
            // 
            this.subject5Attendance.AutoSize = true;
            this.subject5Attendance.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subject5Attendance.Location = new System.Drawing.Point(200, 495);
            this.subject5Attendance.Name = "subject5Attendance";
            this.subject5Attendance.Size = new System.Drawing.Size(111, 20);
            this.subject5Attendance.TabIndex = 43;
            this.subject5Attendance.Text = "Ateendance 5";
            // 
            // subject6Attendance
            // 
            this.subject6Attendance.AutoSize = true;
            this.subject6Attendance.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subject6Attendance.Location = new System.Drawing.Point(200, 542);
            this.subject6Attendance.Name = "subject6Attendance";
            this.subject6Attendance.Size = new System.Drawing.Size(102, 20);
            this.subject6Attendance.TabIndex = 42;
            this.subject6Attendance.Text = "Attendance6";
            // 
            // subject4Attendance
            // 
            this.subject4Attendance.AutoSize = true;
            this.subject4Attendance.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subject4Attendance.Location = new System.Drawing.Point(200, 449);
            this.subject4Attendance.Name = "subject4Attendance";
            this.subject4Attendance.Size = new System.Drawing.Size(107, 20);
            this.subject4Attendance.TabIndex = 41;
            this.subject4Attendance.Text = "Attendance 4";
            // 
            // subject3Attendance
            // 
            this.subject3Attendance.AutoSize = true;
            this.subject3Attendance.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subject3Attendance.Location = new System.Drawing.Point(201, 405);
            this.subject3Attendance.Name = "subject3Attendance";
            this.subject3Attendance.Size = new System.Drawing.Size(107, 20);
            this.subject3Attendance.TabIndex = 31;
            this.subject3Attendance.Text = "Attendance 3";
            // 
            // subject2Attendance
            // 
            this.subject2Attendance.AutoSize = true;
            this.subject2Attendance.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subject2Attendance.Location = new System.Drawing.Point(200, 362);
            this.subject2Attendance.Name = "subject2Attendance";
            this.subject2Attendance.Size = new System.Drawing.Size(107, 20);
            this.subject2Attendance.TabIndex = 32;
            this.subject2Attendance.Text = "Attendence 2";
            // 
            // percentage1
            // 
            this.percentage1.AutoSize = true;
            this.percentage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.percentage1.Location = new System.Drawing.Point(355, 315);
            this.percentage1.Name = "percentage1";
            this.percentage1.Size = new System.Drawing.Size(108, 20);
            this.percentage1.TabIndex = 40;
            this.percentage1.Text = "Percentage 1";
            // 
            // subject1Attendance
            // 
            this.subject1Attendance.AutoSize = true;
            this.subject1Attendance.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subject1Attendance.Location = new System.Drawing.Point(201, 315);
            this.subject1Attendance.Name = "subject1Attendance";
            this.subject1Attendance.Size = new System.Drawing.Size(102, 20);
            this.subject1Attendance.TabIndex = 39;
            this.subject1Attendance.Text = "Attendance1";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(325, 275);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(148, 25);
            this.label20.TabIndex = 38;
            this.label20.Text = "PERCENTAGE";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(165, 275);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(154, 25);
            this.label19.TabIndex = 37;
            this.label19.Text = "ATTENDANCE ";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(24, 275);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(105, 25);
            this.label18.TabIndex = 36;
            this.label18.Text = "SUBJECT";
            // 
            // subject6
            // 
            this.subject6.AutoSize = true;
            this.subject6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subject6.Location = new System.Drawing.Point(24, 542);
            this.subject6.Name = "subject6";
            this.subject6.Size = new System.Drawing.Size(79, 20);
            this.subject6.TabIndex = 35;
            this.subject6.Text = "Subject 6";
            // 
            // subject5
            // 
            this.subject5.AutoSize = true;
            this.subject5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subject5.Location = new System.Drawing.Point(24, 495);
            this.subject5.Name = "subject5";
            this.subject5.Size = new System.Drawing.Size(79, 20);
            this.subject5.TabIndex = 34;
            this.subject5.Text = "Subject 5";
            // 
            // subject4
            // 
            this.subject4.AutoSize = true;
            this.subject4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subject4.Location = new System.Drawing.Point(24, 449);
            this.subject4.Name = "subject4";
            this.subject4.Size = new System.Drawing.Size(79, 20);
            this.subject4.TabIndex = 33;
            this.subject4.Text = "Subject 4";
            // 
            // subject3
            // 
            this.subject3.AutoSize = true;
            this.subject3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subject3.Location = new System.Drawing.Point(24, 405);
            this.subject3.Name = "subject3";
            this.subject3.Size = new System.Drawing.Size(79, 20);
            this.subject3.TabIndex = 32;
            this.subject3.Text = "Subject 3";
            // 
            // subject2
            // 
            this.subject2.AutoSize = true;
            this.subject2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subject2.Location = new System.Drawing.Point(24, 362);
            this.subject2.Name = "subject2";
            this.subject2.Size = new System.Drawing.Size(79, 20);
            this.subject2.TabIndex = 31;
            this.subject2.Text = "Subject 2";
            // 
            // subject1
            // 
            this.subject1.AutoSize = true;
            this.subject1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subject1.Location = new System.Drawing.Point(24, 315);
            this.subject1.Name = "subject1";
            this.subject1.Size = new System.Drawing.Size(79, 20);
            this.subject1.TabIndex = 30;
            this.subject1.Text = "Subject 1";
            this.subject1.Click += new System.EventHandler(this.subject1_Click);
            // 
            // idDisplay
            // 
            this.idDisplay.AutoSize = true;
            this.idDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idDisplay.Location = new System.Drawing.Point(225, 171);
            this.idDisplay.Name = "idDisplay";
            this.idDisplay.Size = new System.Drawing.Size(129, 26);
            this.idDisplay.TabIndex = 9;
            this.idDisplay.Text = "Enter Name";
            // 
            // nameDisplay
            // 
            this.nameDisplay.AutoSize = true;
            this.nameDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameDisplay.Location = new System.Drawing.Point(127, 129);
            this.nameDisplay.Name = "nameDisplay";
            this.nameDisplay.Size = new System.Drawing.Size(129, 26);
            this.nameDisplay.TabIndex = 8;
            this.nameDisplay.Text = "Enter Name";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(24, 217);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(318, 26);
            this.label9.TabIndex = 7;
            this.label9.Text = "ATTENDANCE PERCENTAGE";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(23, 171);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(187, 26);
            this.label8.TabIndex = 5;
            this.label8.Text = "ADMISSION NO :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(24, 131);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 26);
            this.label7.TabIndex = 4;
            this.label7.Text = "NAME :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(13, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(294, 29);
            this.label6.TabIndex = 2;
            this.label6.Text = "ATTENDANCE DETAILS";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(86, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(436, 39);
            this.label1.TabIndex = 1;
            this.label1.Text = "ATTENDANCE REGISTER";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.Controls.Add(this.label1);
            this.panel4.Location = new System.Drawing.Point(338, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(584, 57);
            this.panel4.TabIndex = 0;
            // 
            // teacherName
            // 
            this.teacherName.LabelText = "Teacher Name";
            this.teacherName.Location = new System.Drawing.Point(714, 682);
            this.teacherName.MinimumSize = new System.Drawing.Size(84, 53);
            this.teacherName.Name = "teacherName";
            this.teacherName.Size = new System.Drawing.Size(236, 80);
            this.teacherName.TabIndex = 0;
            this.teacherName.TextValue = "";
            // 
            // Label10
            // 
            this.Label10.AutoSize = true;
            this.Label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.Label10.Location = new System.Drawing.Point(23, 88);
            this.Label10.Name = "Label10";
            this.Label10.Size = new System.Drawing.Size(205, 26);
            this.Label10.TabIndex = 49;
            this.Label10.Text = "TEACHER NAME : ";
            // 
            // teacherLabel
            // 
            this.teacherLabel.AutoSize = true;
            this.teacherLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teacherLabel.Location = new System.Drawing.Point(225, 88);
            this.teacherLabel.Name = "teacherLabel";
            this.teacherLabel.Size = new System.Drawing.Size(129, 26);
            this.teacherLabel.TabIndex = 38;
            this.teacherLabel.Text = "Enter Name";
            this.teacherLabel.Click += new System.EventHandler(this.teacherLabel_Click);
            // 
            // AttendanceRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1310, 793);
            this.Controls.Add(this.teacherName);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dateLabel);
            this.Controls.Add(this.panel6);
            this.Name = "AttendanceRegister";
            this.Text = "ATTENDANCE REGISTER";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel6.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.Button showDetailsButton;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label percentage6;
        private System.Windows.Forms.Label percentage5;
        private System.Windows.Forms.Label percentage4;
        private System.Windows.Forms.Label percentage3;
        private System.Windows.Forms.Label percentage2;
        private System.Windows.Forms.Label subject5Attendance;
        private System.Windows.Forms.Label subject6Attendance;
        private System.Windows.Forms.Label subject4Attendance;
        private System.Windows.Forms.Label subject3Attendance;
        private System.Windows.Forms.Label subject2Attendance;
        private System.Windows.Forms.Label percentage1;
        private System.Windows.Forms.Label subject1Attendance;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label subject6;
        private System.Windows.Forms.Label subject5;
        private System.Windows.Forms.Label subject4;
        private System.Windows.Forms.Label subject3;
        private System.Windows.Forms.Label subject2;
        private System.Windows.Forms.Label subject1;
        private System.Windows.Forms.Label idDisplay;
        private System.Windows.Forms.Label nameDisplay;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.CheckBox period6Absent;
        private System.Windows.Forms.CheckBox period6Present;
        private System.Windows.Forms.CheckBox period5Absent;
        private System.Windows.Forms.CheckBox period5Present;
        private System.Windows.Forms.CheckBox period4Absent;
        private System.Windows.Forms.CheckBox period4Present;
        private System.Windows.Forms.CheckBox period3Absent;
        private System.Windows.Forms.CheckBox period3Present;
        private System.Windows.Forms.CheckBox period2Absent;
        private System.Windows.Forms.CheckBox period2Present;
        private System.Windows.Forms.CheckBox period1Absent;
        private System.Windows.Forms.CheckBox period1Present;
        private System.Windows.Forms.Label dayLabel;
        private System.Windows.Forms.Label period6;
        private System.Windows.Forms.Label period5;
        private System.Windows.Forms.Label period4;
        private System.Windows.Forms.Label period3;
        private System.Windows.Forms.Label period2;
        private System.Windows.Forms.Label period1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel4;
        private UserControl1 teacherName;
        private System.Windows.Forms.Label Label10;
        private System.Windows.Forms.Label teacherLabel;
    }
}

