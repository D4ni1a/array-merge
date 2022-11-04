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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close(); //Закрытие
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Program.Dict.ContainsKey(textBox1.Text)) //Если имя массива (из textBox1) существует (ключ существует в словаре массивов)
            {
                Program.Dict.Remove(textBox1.Text);  //Удаление массива
                textBox1.Clear(); //Очистка поля
                MessageBox.Show("Массив удален", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information); //Сообщение
            }
            else { MessageBox.Show("Такого массива не существует", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error); }//Если имени нет, то сообщение
        }
    }
}
