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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox4.Text.Length != 0)//Если имя нового массива есть
                {
                    string n1 = textBox1.Text; //Имя 1-ого из textBox1
                    string n2 = textBox2.Text;//Имя 2-ого из textBox2
                    Massiv B = (Program.Dict[n1]);//Считываение из словаря экземпляра класса Massiv с именем из textBox1
                    Massiv C = B.Plus(Program.Dict[n2]);//Создание экземпляра класса для метода Plus для В
                    string text = " ";//Строка для элементов массива
                    for (int i = 0; i < C.len - 1; i++)
                    {
                        text += (C[i] + ","); //Считываение элементов в строку, разделяя их запятыми
                    }
                    text += C[C.len - 1];
                    textBox3.Text = text; //Вывод строки с элементами в textBox3
                    Program.Dict.Add(textBox4.Text, C); //Добавление в словарь нового элемента (массива)
                }
                else { MessageBox.Show("Введите имя нового массива", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error); } //Если имя нового массива отсутсвует
            }
            catch (KeyNotFoundException) { MessageBox.Show("Не существует такого массива", "Попробуй снова", MessageBoxButtons.OK, MessageBoxIcon.Error); } //При отсутсвии массива с именем в словаре массивов
            catch (ArgumentException) { MessageBox.Show("Массив с таким именем уже существует", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error); } //Ошибка при создании нового массива
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close(); //Закрытие
        }
    }
}
