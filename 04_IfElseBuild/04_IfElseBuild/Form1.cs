using System;
using System.Windows.Forms;

namespace _04_IfElseBuild
{
    public partial class Form1 : Form
    {
        int a, b, s;

        char tür=' ';

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void TextBox1_TextChanged_1(object sender, EventArgs e)
        {
            button1.Text = "Sonuç Göster";
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            a = int.Parse(textBox1.Text);
            b = int.Parse(textBox2.Text);

            tür = ' ';

            if (textBox3.TextLength > 1 || textBox3.TextLength == 0)
            {
                MessageBox.Show("Lütfen Size Gösterilen İşlem Türlerinden Birini Giriniz");
            }

            else
            {
                tür = char.Parse(textBox3.Text);
            }
            

            if (tür == '+')
            {
                s = a + b;
            }

            else if (tür == '-')
            {
                if (a>b)
                {
                    s = a - b;
                }

                else if (b>a)
                {
                    s = b - a;
                }

                else
                {
                    s = 0;
                }
            }

            else if (tür == '*')
            {
                s = a * b;
            }

            else if (tür == '/')
            {
                if (b == 0)
                {
                    MessageBox.Show("Bölen Değer 0 Olamaz");
                }

                else
                {
                    s = a / b;
                }
            }

            else if (tür == ' ')
            {

            }

            else
            {
                MessageBox.Show("Lütfen Size Gösterilen İşlem Türlerinden Birini Giriniz");
            }
           

            button1.Text = s.ToString();
        }
    }
}
