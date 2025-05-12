using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        private void PeopleList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (PeopleList.Text.Length != 0)
            {
                MemberList.Items.Add(PeopleList.Text);
            }
            else
            {
                MessageBox.Show("Select an item from the list or enter a new one");
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            while (MemberList.CheckedIndices.Count > 0)
            {
                MemberList.Items.Remove(MemberList.CheckedIndices[0]);
            }
        }

        private void buttonSort_Click(object sender, EventArgs e)
        {
            MemberList.Sorted = true;
        }
    }
}
