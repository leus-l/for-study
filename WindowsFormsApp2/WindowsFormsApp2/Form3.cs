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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            //switch (e.ClickedItem.Tag.ToString())
            //{
            //    case "NewDoc":
            //        ChildForm newChild = new ChildForm();
            //        newChild.MidParents = this;
            //        newChild.Show();
            //        newChild.Text = newChild.Text + " " + ++OpenDocument;
            //        break;
            //    case "Cascade":
            //        this.LoyoutMdi(System.Windows.Forms.MdiLayout.Cascade);
            //        break;
            //    case "Title":
            //        this.LayoutMdi(System.Windows.Forms.MdiLayout.TileHorizontal);
            //        break;
            //}
        }
    }
}
