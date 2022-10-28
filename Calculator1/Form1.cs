using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator1
{
    public partial class Form1 : Form

    {
        Calculator mycal = new Calculator();
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_2ndValue_TextChanged(object sender, EventArgs e)
        {

        }
       

        private void btn_cal_Click(object sender, EventArgs e)
        {
            if (cmb_choice.Text == "Add")
            {
               
            }
        }
    }
}
