using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.Design;
using System.Windows.Forms;

namespace Attendance_Register_App
{
    [DefaultEvent(nameof(TextChanged))]
    public partial class UserControl1 : UserControl
    {   
        public UserControl1()
        {
            InitializeComponent();
        }
        [Browsable(true)]
        public new event EventHandler TextChanged
        {
             add { textValue.TextChanged += value; }
            remove { textValue.TextChanged -= value; }

        }
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public string TextValue
        {
            get { return textValue.Text; }
            set { textValue.Text = value; }
        }
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public string LabelText
        {
            get { return label1title.Text; }
            set { label1title.Text = value; }
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            Text= string.Empty;
        }
    }
}
