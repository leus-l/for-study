using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void spWin_Click(object sender, EventArgs e)
        {
            spWin.Text = "Windowa is cascade";
        }

        private void spData_Click(object sender, EventArgs e)
        {

        }

        private void Form4_Load(object sender, EventArgs e)
        {
            //PublicKey ParenForm()
            //{
            //    InitializeComponent();
            //    spData.Text = Convert.ToString(System.DateTime.Today.ToLongDateString());
            //}
        }
    }
}
