using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Collections;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Создание формы с добавлением массива
            Form2 A = new Form2();
            A.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //Создание формы с выводом массива
            Form3 B = new Form3();
            B.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Создание формы с сцеплением
            Form4 A = new Form4();
            A.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Создание формы с слиянием
            Form5 A = new Form5();
            A.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //Закрытие
            this.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //Удаление массива
            Form6 A = new Form6();
            A.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            //Удаление всех массивов
            Program.Dict.Clear();
            MessageBox.Show("Все массивы удалены", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
