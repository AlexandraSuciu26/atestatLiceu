using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace atestat
{
    public partial class start : Form
    {
        public start()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            test1 f = new test1();
            f.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            test2 f = new test2();
            f.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            test3 f = new test3();
            f.ShowDialog();
        }
    }
}
