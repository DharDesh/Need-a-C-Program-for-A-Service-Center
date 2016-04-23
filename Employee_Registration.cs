using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SevenStarServiceCenter
{
    public partial class Employee_Registration : Form
    {
        public Employee_Registration()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToLongTimeString() + "," + DateTime.Now.ToLongDateString();
        }

        private void Employee_Registration_Load(object sender, EventArgs e)
        {

        }
    }
}
