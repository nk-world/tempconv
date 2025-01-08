using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            CalcResult();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void CalcResult()
        {
            if (!double.TryParse(textBox1.Text, out double temp))
            {
                ResultC.Text = "-";
                ResultF.Text = "-";
                ResultK.Text = "-";
                return;
            }

            int a = OptionC.Checked ? 0 : (OptionF.Checked ? 1 : 2);
            var result = Program.TempConv(temp, a);

            ResultC.Text = $"{result.Item1}";
            ResultF.Text = $"{result.Item2}";
            ResultK.Text = $"{result.Item3}";
        }

        private void OptionC_CheckedChanged(object sender, EventArgs e)
        {
            CalcResult();
        }

        private void OptionF_CheckedChanged(object sender, EventArgs e)
        {
            CalcResult();
        }

        private void OptionK_CheckedChanged(object sender, EventArgs e)
        {
            CalcResult();
        }

        private void ResultC_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(ResultC.Text);
        }

        private void ResultF_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(ResultF.Text);
        }

        private void ResultK_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(ResultK.Text);
        }
    }
}
