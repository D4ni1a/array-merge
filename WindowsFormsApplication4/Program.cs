using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication4
{
    static class Program
    {
        public static Dictionary<string, Massiv> Dict = new Dictionary<string, Massiv>(100); //Создание словаря массивов на 100 элементов
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());

        }
    }
}
class Massiv //Класс Massiv
{
    string[] a; //Строковый массив
    public int len; //Переменная для размера массива
    string name; //Имя массива
    public Massiv(int N, string M) //Конструктор для его размера, имени и элементов
    {
        len = N;
        name = M;
        a = new string[N];
    }
    public string this[int index] //Индексатор для добавления и извлечения элементов
    {
        get
        {
            return a[index]; //Извлечение
        }
        set
        {
            a[index] = value; //Добавление
        }
    }
    public Massiv Concat(Massiv A) //Метод принимает другой экземпляр этого класса
    {
        Massiv c = new Massiv(len, name); //Создается новый экземпляр данного класса
        if (len == A.len) //Работает только если количество элементов одинаково
        {
            for (int i = 0; i < len; i++) 
            {
                c[i] = a[i] +" "+ A[i]; //Элементы объединяются через пробел
            }
            return c;
        }
        else //Если различно, выводится сообщение
        {
            MessageBox.Show("Попробуй снова", "Объединение невозможно", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return c;
        }
    }
    public Massiv Plus(Massiv A) //Метод принимает другой экземпляр этого класса
    {
        int count3 = 0; //Счетчик
        int b = A.len;
        for (int i = 0; i < len; i++)
        {
            for (int j = 0; j < b; j++)
            {
                if (A[j] == a[i]) count3 += 1; //Считает количество равных элементов
            }
        }
        Massiv c = new Massiv(b + len - count3, name); //Новый экземпляр с количеством элементов равным количеству элементов двух массивов взятых 1 раз
        for (int i = 0; i < len; i++)
        {
            c[i] = a[i]; //Добавляем все элементы первого
        }
        int count2 = len;
        for (int i = 0; i < b; i++)
        {
            int count = 0;
            for (int j = 0; j < len; j++)
            {
                if (c[j] == A[i]) count += 1;
            }
            if (count == 0)
            {
                c[count2] = A[i]; //Добавляем только новые элементы из второго (т.е. тех, что нет в первом)
                count2 += 1;
            }
        }

        return c;
    }
}