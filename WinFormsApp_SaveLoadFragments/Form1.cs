using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp_SaveLoadFragments
{
    public partial class Form1 : Form
    {
        private ArrayPictures _arr_pictures;
        public Form1()
        {
            InitializeComponent();
            int ind_image = 0;
            Image im_pic = (Image)Properties.Resources.ResourceManager.GetObject("Task_" + (ind_image + 1).ToString());
            Bitmap bmp_pic = new Bitmap(im_pic);
            //bmp_pic = ; 
            Size size_pic = new Size(pictureBox.Width, pictureBox.Height);
            _arr_pictures = new ArrayPictures(pictureBox, bmp_pic, size_pic, 3, 4);
            AssignPictures();
        }
        private void AssignPictures()
        {
            foreach (PictureBox pic in _arr_pictures.Get_Pictures())
            {
                int index = (int)pic.Tag;
                pic.Click += new EventHandler(fragment_Click);
                pic.Visible = true;
            }
        }
        void fragment_Click(object sender, EventArgs e)
        {
            PictureBox pic = (PictureBox)sender;
            int index = (int)pic.Tag;
            if (radioButton_Load.Checked)
            {
                Load_Fragment(index);
            }
            else
            {
                Save_Fragment(index);
            }
        }
        private void Load_Fragment(int index)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "файлы картинок (*.bmp;*.jpg;*.jpeg;)|*.bmp;*.jpg;.jpeg|All files(*.*) | *.* "; 
            openFileDialog.FilterIndex = 1;
            openFileDialog.RestoreDirectory = true;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                Bitmap pic_show = new Bitmap(openFileDialog.FileName);
                _arr_pictures.Change_Bmp(index, pic_show);
            }
        }
        private void Save_Fragment(int index)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "файлы картинок (*.bmp;*.jpg;*.jpeg;)|*.bmp;*.jpg;.jpeg|All files(*.*) | *.* "; 
            saveFileDialog.FilterIndex = 1;
            saveFileDialog.RestoreDirectory = true;

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string str_file = saveFileDialog.FileName;
                PictureBox pic = _arr_pictures[index];
                pic.Image.Save(str_file);
            }
        }
        private void Form1_SizeChanged(object sender, EventArgs e)
        {
            Size pic_size = new Size(this.Size.Width - 20, this.Size.Height - 100);
            pictureBox.Size = pic_size;

            _arr_pictures.Set_Sizes(pic_size);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
