using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace Attendance_Register_App
{
    public partial class AttendanceRegister : Form
    {
        // This is a Windows Forms application for managing attendance registers.
        public string name { get; set; }
        public string id { get; set; }
        public DateTime date { get; set; } 
        public string CurrentDay { get; set; }

        public string[] Days = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday" };
        
        public string[] subjects = { "DS", "DBMS", "JAVA", "AI", "ML", "PE" };
        public Dictionary<String,bool> periodAttendance = new Dictionary<string, bool>();
        public Dictionary<DateTime, Dictionary<string,bool>> attendanceData = new Dictionary<DateTime, Dictionary<string,bool>>();
        public Dictionary<string, double> attendancePercentages = new Dictionary<string, double>();
        public Dictionary<string, List<string>> Subjects { get; set; } = new Dictionary<string, List<string>>()
         {
           { "Monday", new List<string> { "DS", "DBMS", "JAVA", "AI", "ML", "PE" } },
           { "Tuesday", new List<string> { "AI", "DS", "PE", "ML", "DBMS", "JAVA" } },
           { "Wednesday", new List<string> { "ML", "AI", "DS", "PE", "JAVA", "DBMS" } },
           { "Thursday", new List<string> { "DS", "ML", "JAVA", "DBMS", "AI", "PE" } },
           { "Friday", new List<string> { "JAVA", "DS", "AI", "ML", "PE", "DBMS" } }
        };

        

        private void ChceckAttendance()
        {
            // This method checks the attendance for the current day and updates the UI accordingly.
            if (date == null || string.IsNullOrEmpty(CurrentDay))
            {
                MessageBox.Show("Please select a date first.");
                return;
            }
            if (!Subjects.ContainsKey(CurrentDay))
            {
                MessageBox.Show("No subjects found for the selected day.");
                return;
            }

            List<string> timeTable = Subjects[CurrentDay];
            foreach (string period in timeTable)
                {
                    Console.WriteLine(period);
            }
            period1.Text = timeTable[0];
            period2.Text = timeTable[1];
            period3.Text = timeTable[2];
            period4.Text = timeTable[3];
            period5.Text = timeTable[4];
            period6.Text = timeTable[5];

            
        }
        private void EnterAttendance() 
        {
            List<string> timeTable = Subjects[CurrentDay];
            if (period1Present.Checked)
            {
                periodAttendance[timeTable[0]] = true;
            }
            else if (period1Absent.Checked)
            {
                periodAttendance[timeTable[0]] = false;
            }
            else 
            {
                periodAttendance[timeTable[0]] = false;
            }

            if (period2Present.Checked)
            {
                periodAttendance[timeTable[1]] = true;
            }
            else if (period2Absent.Checked)
            {
                periodAttendance[timeTable[1]] = false;
            }
            else
            {  
                periodAttendance[timeTable[1]]= false;
            }

            if (period3Present.Checked)
            {
                periodAttendance[timeTable[2]] = true;
            }
            else if (period3Absent.Checked)
            {
                periodAttendance[timeTable[2]] = false;
            }
            else 
            {
                periodAttendance[timeTable[2]] = false;
            }


            if (period4Present.Checked)
            {
                periodAttendance[timeTable[3]] = true;
            }
            else if (period4Absent.Checked)
            {
                periodAttendance[timeTable[3]] = false;
            }
            else
            {
                periodAttendance[timeTable[3]] = false;
            }

            if (period5Present.Checked)
            {
                periodAttendance[timeTable[4]] = true;
            }
            else if (period5Absent.Checked)
            {
                periodAttendance[timeTable[4]] = false;
            }
            else 
            {
                periodAttendance[timeTable[4]] = false;
            }

            if (period6Present.Checked)
            {
                periodAttendance[timeTable[5]] = true;
            }
            else if (period6Absent.Checked)
            {
                periodAttendance[timeTable[5]] = false;
            }
            else
            {
                periodAttendance[timeTable[5]] = false;
            }

        }
        public void MarkAttendance(DateTime date, Dictionary<string, bool> periodattendance)
        {
            if (periodattendance == null)
            {
                throw new ArgumentNullException(nameof(periodattendance));
            }

            foreach (KeyValuePair<string, bool> period in periodattendance)
            {
                if (!attendanceData.ContainsKey(date))
                {
                    attendanceData[date] = new Dictionary<string, bool>();
                }
                attendanceData[date][period.Key] = period.Value;
            }
        }

        public Dictionary<string, double> GetAttendancePercentage(out Dictionary<string, List<int[]>> totalAttendance)
        {
            totalAttendance = new Dictionary<string, List<int[]>>(); // Ensure this is initialized at the start of the method.

            if (attendanceData.Count == 0)
            {
                return new Dictionary<string, double>();
            }

            List<string> allPeriods = Subjects.Values.SelectMany(p => p).Distinct().ToList();
            Dictionary<string, double> allPeriodAttendance = new Dictionary<string, double>();

            foreach (var period in allPeriods)
            {
                var totalPresent = 0;
                var totalPeriods = 0;

                foreach (var dateRecord in attendanceData.Values)
                {
                    foreach (var attendance in dateRecord)
                    {
                        if (attendance.Key == period)
                        {
                            totalPeriods++;
                            if (attendance.Value)
                            {
                                totalPresent++;
                            }
                        }
                    }

                }
                List<int[]> attendanceList = new List<int[]>() { new int[] { totalPresent, totalPeriods } };

                // Store the count of present and total periods for this subject

                totalAttendance[period] = attendanceList;
                // Initialize the list for each period

                allPeriodAttendance[period] = totalPeriods > 0 ? (double)totalPresent / totalPeriods * 100 : 0.0;
            }

            return allPeriodAttendance;
        }
        
        void DisplayInfo(Dictionary<String, Double> allPeriodAttendance, Dictionary<String, List<int[]>>totalAttendance)
        {
            teacherLabel.Text = teacherName.TextValue;
            nameDisplay.Text = name;
            idDisplay.Text = id;
            subject1.Text = subjects[0];
            subject2.Text = subjects[1];
            subject3.Text = subjects[2];
            subject4.Text = subjects[3];
            subject5.Text = subjects[4];
            subject6.Text = subjects[5];
            subject1Attendance.Text = $"{totalAttendance[subjects[0]][0][0]} / {totalAttendance[subjects[0]][0][1]}";
            subject2Attendance.Text = $"{totalAttendance[subjects[1]][0][0]} / {totalAttendance[subjects[1]][0][1]}";
            subject3Attendance.Text = $"{totalAttendance[subjects[2]][0][0]} / {totalAttendance[subjects[2]][0][1]}";
            subject4Attendance.Text = $"{totalAttendance[subjects[3]][0][0]} / {totalAttendance[subjects[3]][0][1]}";
            subject5Attendance.Text = $"{totalAttendance[subjects[4]][0][0]} / {totalAttendance[subjects[4]][0][1]}";
            subject6Attendance.Text = $"{totalAttendance[subjects[5]][0][0]} / {totalAttendance[subjects[5]][0][1]}";
            percentage1.Text = $"{allPeriodAttendance[subjects[0]]}%";
            percentage2.Text = $"{allPeriodAttendance[subjects[1]]}%";
            percentage3.Text = $"{allPeriodAttendance[subjects[2]]}%";
            percentage4.Text = $"{allPeriodAttendance[subjects[3]]}%";
            percentage5.Text = $"{allPeriodAttendance[subjects[4]]}%";
            percentage6.Text = $"{allPeriodAttendance[subjects[5]]}%";
        }
        public AttendanceRegister()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }


        

 
        private bool TwoOptionSet()
        {
            
            
            
            
            
            
            if (period1Present.Checked && period1Absent.Checked)
            {
                MessageBox.Show("Please select either Present or Absent for each period.");
                period1Present.Checked = false;
                period1Absent.Checked = false;
                period1.BackColor = Color.White;
                return false;
            }
            if (period2Present.Checked && period2Absent.Checked)
            {
                MessageBox.Show("Please select either Present or Absent for each period.");
                period2Present.Checked = false;
                period2Absent.Checked = false;
                period2.BackColor = Color.White;
                return false;
            }
            if (period3Present.Checked && period3Absent.Checked)
            {
                MessageBox.Show("Please select either Present or Absent for each period.");
                period3Present.Checked = false;
                period3Absent.Checked = false;
                period3.BackColor = Color.White;
                return false;
            }
            if (period4Present.Checked && period4Absent.Checked)
            {
                MessageBox.Show("Please select either Present or Absent for each period.");
                period4Present.Checked = false;
                period4Absent.Checked = false;
                period4.BackColor = Color.White;
                return false;
            }
            if (period5Present.Checked && period5Absent.Checked)
            {
                MessageBox.Show("Please select either Present or Absent for each period.");
                period5Present.Checked = false;
                period5Absent.Checked = false;
                period5.BackColor = Color.White;
                return false;
            }
            if (period6Present.Checked && period6Absent.Checked)
            {
                MessageBox.Show("Please select either Present or Absent for each period.");
                period6Present.Checked = false;
                period6Absent.Checked = false;
                period6.BackColor = Color.White;
                return false;
            }
            return true;

        }

        

        private void showDetailsButton_Click(object sender, EventArgs e)
        {   
            attendancePercentages = GetAttendancePercentage(out Dictionary<string, List<int[]>> totalAttendance);
            DisplayInfo(attendancePercentages, totalAttendance);
            teacherName.Visible = false;
            panel2.Visible = false;
            panel3.Visible = false;
            panel1.Visible = true;
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(id))
            {
                MessageBox.Show("Please enter both Name and ID.");
                return;
            }
            if (string.IsNullOrEmpty(CurrentDay))
            {
                MessageBox.Show("Please select a date.");
                return;
            }
            
           
            
                EnterAttendance();
                MarkAttendance(date, periodAttendance);
                MessageBox.Show("Attendance submitted successfully!");
                panel2.Visible = false;
                ResetAttendance();
                dateTimePicker1.Enabled = true;
                showDetailsButton.Enabled = true;
            
           

        }
        private void ResetAttendance()
        {
            period1Present.Checked = false;
            period1Absent.Checked = false;
            period2Present.Checked = false;
            period2Absent.Checked = false;
            period3Present.Checked = false;
            period3Absent.Checked = false;
            period4Present.Checked = false;
            period4Absent.Checked = false;
            period5Present.Checked = false;
            period5Absent.Checked = false;
            period6Present.Checked = false;
            period6Absent.Checked = false;
            period1.BackColor = Color.White;
            period2.BackColor = Color.White;
            period3.BackColor = Color.White;
            period4.BackColor = Color.White;
            period5.BackColor = Color.White;
            period6.BackColor = Color.White;
        }
       


        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }
        private void ClearText()
        {
            textBox1.Text = string.Empty;
            textBox2.Text = string.Empty;
            dateTimePicker1.Value = DateTime.Now;
        }
        private void backButton_Click(object sender, EventArgs e)
        {
            ClearText();
            teacherName.Visible = true;
            panel3.Visible = true;
            panel2.Visible = false;
            panel1.Visible = false;
        }



        private void label1_Click(object sender, EventArgs e)
        {

        }


        private void panel3_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged_1(object sender, EventArgs e)
        {
            date = dateTimePicker1.Value;


            CurrentDay = date.ToString("dddd");
            dayLabel.Text = $"Enter Attendance for {date.ToShortDateString()}  ";
            if (Days.Contains(CurrentDay))
            {
                ChceckAttendance();
                panel2.Visible = true;
            }
            else
            {
                MessageBox.Show("Please select a valid school day (Monday to Friday).");

                return;
            }
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            name = textBox1.Text;
        }

        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {
            id = textBox2.Text;
        }

        private void period1Present_CheckedChanged(object sender, EventArgs e)
        {
            if (!TwoOptionSet())
            {
                return;
            }
            else
                period1.BackColor = Color.LightGreen;
        }

        private void period2Present_CheckedChanged(object sender, EventArgs e)
        {
            if (!TwoOptionSet())
            {   
                return;
            }
            else
                period2.BackColor = Color.LightGreen;
        }

        private void period3Present_CheckedChanged_1(object sender, EventArgs e)
        {
            if (!TwoOptionSet())
            {
                return;
            }
            else
                period3.BackColor = Color.LightGreen;
        }

        private void panel2_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void period1Absent_CheckedChanged(object sender, EventArgs e)
        {
            if (!TwoOptionSet())
            {
                return;
            }
            else
                period1.BackColor = Color.LightCoral;
        }

        private void period2Absent_CheckedChanged_1(object sender, EventArgs e)
        {

            if (!TwoOptionSet())
            {
                return;
            }
            else
                period2.BackColor = Color.LightCoral;
        }

        private void period3Absent_CheckedChanged_1(object sender, EventArgs e)
        {

            if (!TwoOptionSet())
            {
                return;
            }
            else
                period3.BackColor = Color.LightCoral;
        }

        private void period4Absent_CheckedChanged_1(object sender, EventArgs e)
        {

            if (!TwoOptionSet())
            {
                return;
            }
            else
                period4.BackColor = Color.LightCoral;
        }

        private void period5Absent_CheckedChanged_1(object sender, EventArgs e)
        {

            if (!TwoOptionSet())
            {
                return;
            }
            else
                period5.BackColor = Color.LightCoral;
        }

        private void period4Present_CheckedChanged_1(object sender, EventArgs e)
        {
            if (!TwoOptionSet())
            {
                return;
            }
            else
                period4.BackColor = Color.LightGreen;
        }

        private void period5Present_CheckedChanged_1(object sender, EventArgs e)
        {
            if (!TwoOptionSet())
            {
                return;
            }
            else
                period5.BackColor = Color.LightGreen;
        }

        private void period6Present_CheckedChanged_1(object sender, EventArgs e)
        {
            if (!TwoOptionSet())
            {
                return;
            }
            else
                period6.BackColor = Color.LightGreen;
        }

        private void period6Absent_CheckedChanged_1(object sender, EventArgs e)
        {

            if (!TwoOptionSet())
            {
                return;
            }
            else
                period6.BackColor = Color.LightCoral;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void subject1_Click(object sender, EventArgs e)
        {

        }

        private void userControl11_TextChanged(object sender, EventArgs e)
        {

        }

        private void period1Present_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                period1Present.Checked = !period1Present.Checked; 
                e.Handled = true;
            }
        }

        private void period1Absent_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                period1Absent.Checked = !period1Absent.Checked; 
                e.Handled = true;
            }
        }

        private void period2Present_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                period2Present.Checked = !period2Present.Checked;
                e.Handled = true;
            }
        }

        private void period2Absent_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                period2Absent.Checked = !period2Absent.Checked;
                e.Handled = true;
            }
        }

        private void period3Present_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                period3Present.Checked = !period3Present.Checked;
                e.Handled = true;
            }
        }

        private void period4Present_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                period4Present.Checked = !period4Present.Checked;
                e.Handled = true;
            }
        }

        private void period5Present_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                period5Present.Checked = !period5Present.Checked;
                e.Handled = true;
            }
        }

        private void period6Present_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                period6Present.Checked = !period6Present.Checked;
                e.Handled = true;
            }
        }

        private void period6Absent_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                period6Absent.Checked = !period6Absent.Checked;
                e.Handled = true;
            }
        }

        private void period5Absent_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                period5Absent.Checked = !period5Absent.Checked;
                e.Handled = true;
            }
        }

        private void period4Absent_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                period4Absent.Checked = !period4Absent.Checked;
                e.Handled = true;
            }
        }

        private void period3Absent_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                period3Absent.Checked = !period3Absent.Checked;
                e.Handled = true;
            }
        }

        private void teacherLabel_Click(object sender, EventArgs e)
        {
            
        }
    }
}

