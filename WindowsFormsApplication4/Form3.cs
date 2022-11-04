using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication4
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try //Попытка вывода
            {
                string number = textBox3.Text; //Считывается номер элемента из textBox3
                if (number.Length == 0) //Если textBox3 пуст, т.е. номер элемента отсутсвует, выводится весь массив
                {
                    string n = textBox2.Text; //Строка для имени массива из textBox2
                    Massiv B = (Program.Dict[n]); //Считываение из словаря экземпляра класса Massiv с именем из textBox2
                    string text = " ";//Строка для элементов массива
                    for (int i = 0; i < B.len-1; i++)
                    {
                        text += (B[i] + ","); //Считываение элементов в строку, разделяя их запятыми
                    }
                    text += B[B.len - 1];
                    textBox1.Text = text; //Вывод строки с элементами в textBox1
                }
                else //Если textBox3 пуст, т.е. номер элемента отсутсвует, выводится весь массив
                {
                    string n = textBox2.Text; //Строка для имени массива из textBox2
                    Massiv B = (Program.Dict[n]); //Считываение из словаря экземпляра класса Massiv с именем из textBox2
                    textBox1.Text = B[System.Convert.ToInt32(number)]; //Вывод строки с элементом в textBox1
                }
            }
            catch { MessageBox.Show("Не существует", "Попробуй снова", MessageBoxButtons.OK, MessageBoxIcon.Error); } //Если массив с таким именем не существует, появится сообщение
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close(); //Закрывает
        }
    }
}
