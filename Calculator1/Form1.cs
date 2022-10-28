using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator1
{
    public partial class Form1 : Form

    {
        string HistoryMaintain = null;
        List<string> HistoryList = new List<string>();

        Calculator Mycal = new Calculator();
        int ValueOne;
        int ValueTwo;
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
                try
                {
                    HistoryMaintain = txt_Answer.Text = Mycal.Add(Convert.ToInt32(txt_firstvalue.Text), Convert.ToInt32(txt_2ndValue.Text)).ToString();
                    txt_firstvalue.Clear();
                    txt_2ndValue.Clear();
                }
                catch (Exception)
                {
                    MessageBox.Show("Input is not in valid format", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            if (cmb_choice.Text == "Subtract")
                try
                {
                    HistoryMaintain = txt_Answer.Text = Mycal.Subtract(Convert.ToInt32(txt_firstvalue.Text), Convert.ToInt32(txt_2ndValue.Text)).ToString();
                    txt_firstvalue.Clear();
                    txt_2ndValue.Clear();

                }
                catch (Exception)
                {
                    MessageBox.Show("Input is not in valid format", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            if (cmb_choice.Text == "Multiply")
                try
                {
                    HistoryMaintain = txt_Answer.Text = Mycal.Mul(Convert.ToInt32(txt_firstvalue.Text), Convert.ToInt32(txt_2ndValue.Text)).ToString();

                    txt_firstvalue.Clear();
                    txt_2ndValue.Clear();
                }

                catch (Exception)
                {
                    MessageBox.Show("Input is not in valid format", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

           

        }
        public void clear()
        {
            txt_firstvalue.Clear();
            txt_2ndValue.Clear();
            txt_firstvalue.Focus();
            txt_Answer.Clear();
            lbl_last_operator.Text = "Last Operator:" + HistoryMaintain;
            HistoryList.Add(HistoryMaintain);
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void btn_History_Click(object sender, EventArgs e)
        {
            History myHistory = new History();
            myHistory.LoadList(HistoryList);
        }
    }
}
