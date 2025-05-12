using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp_ImpUserInterface
{
    public partial class Form1 : Form
    {
        private bool _flag_access = true;
        private readonly int[] _paramValuesDefault = { 10, 9, 8 };
        private IEvaluate[] _evaluate_ref = { null, null, null };
        public Form1()
        {
            InitializeComponent();
            _evaluate_ref[0] = new Task1();
            _evaluate_ref[1] = new Task2();
            _evaluate_ref[2] = new Task3();
            comboBox_TaskNum.SelectedIndex = 0;
        }

        private void comboBox_TaskNum_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!_flag_access) return;

         int ind = comboBox_TaskNum.SelectedIndex;
         _evaluate_ref[ind].Invoke_Variant(ind, _paramValuesDefault[ind]);
         textBox_InputValue.Text = _paramValuesDefault[ind].ToString();
         pictureBox_Formula.Image = (Image)Properties.Resources.ResourceManager.GetObject("Task_" + (ind + 1).ToString());
        }

        private void button_EvaluateVariant_Click(object sender, EventArgs e)
        {
            if (!_flag_access) return;

         int ind = comboBox_TaskNum.SelectedIndex;
         string str_out = _evaluate_ref[ind].Execute_Variant();

         label_Output.Text = str_out;
        }

        private void textBox_InputValue_TextChanged(object sender, EventArgs e)
        {
            if (!_flag_access) return;

         int ind = comboBox_TaskNum.SelectedIndex;

         string str_num = textBox_InputValue.Text;
         _evaluate_ref[ind].ParamValue = Int32.Parse(str_num);
        }

        private void button_Close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
