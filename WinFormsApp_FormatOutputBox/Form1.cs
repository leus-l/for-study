using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp_FormatOutputBox
{
    public partial class Form1 : Form
    {
        private FormatOutputBox_GUI _outputBox = new FormatOutputBox_GUI();
        private int? _A = null;
        private int? _B = null;
        private int _index = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void listBox_Input_SelectedIndexChanged(object sender, EventArgs e)
        {
            _index = listBox_Input.SelectedIndex;
            _outputBox.Invoke_Data(_index, ref pictureBox_Preview, ref richTextBox_Output);
        }

        private void button_Evaluate_Click(object sender, EventArgs e)
        {
            if (_A != null && _B != null)
                _outputBox.Execute_Data(_A, _B);
            double tbA = Convert.ToDouble(textBox_A.Text);
            double tbB = Convert.ToInt32(textBox_B.Text);
            double res = Math.Pow(-tbA, 4) - Math.Pow(tbB, 3);
            richTextBox_Output.Text = res.ToString();
        }

        private void textBox_A_TextChanged(object sender, EventArgs e)
        {
            int value;
            if (Int32.TryParse(textBox_A.Text, out value))
                _A = value;
            else
                _A = null;
        }

        private void textBox_B_TextChanged(object sender, EventArgs e)
        {
            int value;
            if (Int32.TryParse(textBox_A.Text, out value))
                _A = value;
            else
                _A = null;
        }

        private void button_Clear_Click(object sender, EventArgs e)
        {
            _outputBox.Clear_Data();
        }
    }
}
