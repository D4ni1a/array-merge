using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Collections;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication4
{
    public partial class Form2 : Form
    {
       
        string[] mass;
        string name;
        public Form2()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            try //Попытка добавить в словарь массивов новый массив с именем из textBox1 и элементами из textBox2
            {
                
                if ((textBox1.Text.Length != 0) || (textBox2.Text.Length != 0)) //Если имя или элементы отсутствуют, выдается ошибка в элсе
                {
                    mass = textBox2.Text.Split(','); //Строка с элементами разбывается на отдельные элементы по запятым и записывает их в mass
                    name = textBox1.Text; //Имя
                    Massiv A = new Massiv(mass.Length, name); //Создается экземпляр класса Massiv
                    for (int i = 0; i < mass.Length; i++)
                    {
                        A[i] = mass[i]; //Все элементы из mass сохраняются как элементы экземпляра класса
                    }
                    Program.Dict.Add(name, A); //В словарь с массивами добавляется экземпляр класса и ключ являющийся именем 
                    //Очистка полей
                    textBox1.Clear();
                    textBox2.Clear();
                }
                else
                {
                    //Выскакивает сообщение и очищаются поля
                    MessageBox.Show("Попробуй снова", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBox1.Clear();
                    textBox2.Clear();
                }
            }
            catch //Если такой массив уже существует
            {
                MessageBox.Show("Массив с таким именем уже существует", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Закрывает окно
            this.Close();
        }
    }
}
