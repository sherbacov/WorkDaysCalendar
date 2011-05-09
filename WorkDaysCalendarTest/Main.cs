using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;

using System.Windows.Forms;
using WorkDaysCalendar;

namespace WorkDaysCalendarTest
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            dateTestPicker.Value = DateTime.Now;
        }

        private void TestSingleDay_Click(object sender, EventArgs e)
        {
            TestSingleDayResult.Text = WorkCalendar.GetDayType(dateTestPicker.Value).ToString();

        }
    }
}
