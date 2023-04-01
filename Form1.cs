using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Lab2.Program;
namespace Lab2
{
    public partial class Form1 : Form
    {
        private readonly Complex _complex = new Complex();
        private readonly Vector _vector = new Vector();
        public Form1()
        {
            InitializeComponent();
        }
        int a;
        int bi;
        int x;
        int y;
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        
        private void TextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && number != 8 && (e.KeyChar <= 39 ||
                e.KeyChar >= 46) && number != 47 && number != 61) // цифры, клавиша BackSpace, запятая и математические знаки
            {
                e.Handled = true;
            }
        }

        private void TextBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && number != 8 && (e.KeyChar <= 39 ||
                e.KeyChar >= 46) && number != 47 && number != 61) // цифры, клавиша BackSpace, запятая и математические знаки
            {
                e.Handled = true;
            }
        }

        private void _normBtn_MouseClick(object sender, MouseEventArgs e)
        {
            a = Int32.Parse(textBox1.Text);
            bi = Int32.Parse(textBox2.Text);
            x = Int32.Parse(textBox1.Text); //ініціалізація змінних
            y = Int32.Parse(textBox2.Text);
            if (checkBox1.Checked) //викликання методів норми
            {
                _resLbl.Text = "Норма вектору дорівнює: " + Convert.ToString(_vector.NORM(x, y)); 
            }
            else
            {
                _resLbl.Text = "Норма комплексного числа дорівнює: " + Convert.ToString(_complex.NORM(a, bi));
            }
            
        }

        private void _AbsBtn_MouseClick(object sender, MouseEventArgs e)
        {
            a = Int32.Parse(textBox1.Text);
            bi = Int32.Parse(textBox2.Text); //ініціалізація змінних
            x = Int32.Parse(textBox1.Text);
            y = Int32.Parse(textBox2.Text);
            if (checkBox1.Checked) //викликання методів модуля
            {
                _resLbl.Text = "Модуль вектора дорівнює: " + Convert.ToString(_vector.ABS(x, y));
            }
            else
            {
                _resLbl.Text = "Модуль комплексного числа дорівнює: " + Convert.ToString(_complex.ABS(a, bi));
            }

        }
    }
    
}

