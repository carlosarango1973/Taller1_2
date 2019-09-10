using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Taller1_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lbltotal.Text = "IVA: " + Convert.ToInt32(txtvalor.Text) * 0.19 + " Total: " + (Convert.ToInt32(txtvalor.Text) + Convert.ToInt32(txtvalor.Text) * 0.19);
        }
    }
}
