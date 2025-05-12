using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace WinFormsApp_FormatOutputBox
{
    internal class FormatOutputBox_Handling
    {
        public class Operation_None : IFormatOutputBox
        {

            public bool Load_Invoking(ref RichTextBox consoleOut, ref PictureBox pic)
            {
                string str_class_name = this.GetType().Name;
                pic.Image = (Image)Properties.Resources.ResourceManager.GetObject(str_class_name);
                consoleOut.AppendText("Инициализировано действие \"0\".");
                return true;
            }
            public bool Run_Executing(int? a, int? b, ref RichTextBox consoleOut)
            {
                string str = String.Format("\nВыполнение действия \"0\"");
                return true;
            }
        }
        public class Operation_SimpleSum : IFormatOutputBox
        {
            public bool Load_Invoking(ref RichTextBox consoleOut, ref PictureBox pic)
            {
                string str_class_name = this.GetType().Name;
                pic.Image = (Image)Properties.Resources.ResourceManager.GetObject(str_class_name);
                consoleOut.AppendText("Инициализировано действие \"1\"!");
                return true;
            }
            public bool Run_Executing(int? a, int? b, ref RichTextBox consoleOut)
            {
                string str = String.Format("\nВыполнение действия \"1\":\n{0} + {1} = {2}", a, b, a + b);
                consoleOut.AppendText(str);
                return true;
            }           
        }
        public class Operation_SimpleMult : IFormatOutputBox
        {
            public bool Load_Invoking(ref RichTextBox consoleOut, ref PictureBox pic)
            {
                string str_class_name = this.GetType().Name;
                pic.Image = (Image)Properties.Resources.ResourceManager.GetObject(str_class_name);
                consoleOut.AppendText("Инициализировано действие \"2\"!");
                return true;
            }

            public bool Run_Executing(int? a, int? b, ref RichTextBox consoleOut)
            {
                string str = String.Format("\nВыполнение действия \"2\":\n{0} * {1} = {2}", a, b, a * b);
                consoleOut.AppendText(str);
                return true;
            }
        }
    }
}
