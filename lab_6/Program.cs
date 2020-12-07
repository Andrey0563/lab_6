using System;

namespace Task_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = System.Text.Encoding.Unicode;
            Console.OutputEncoding = System.Text.Encoding.Unicode;

            Massives a = new Massives();

            a.InputMassiveSize_M(); //вызов функций для ввода размера
            a.InputMassiveSize_N();

            a.CreateMassive(); //создаем масив
            a.OutputMassive();//виводим
            a.TaskFunction();//индив завд

            a.GetMassiveValue();

        }
    }

    class Massives
    {

        //веластивості для даних
        private int m;
        public int M
        {
            get { return m; }
            set { m = value; }
        }

        private int n;
        public int N
        {
            get { return n; }
            set { n = value; }
        }

        private int[,] mass;
        public int[,] Mass
        {
            get { return mass; }
            set { mass = value; }
        }

        public int InputMassiveSize_M()
        {

            bool flag = false; //атрибут для типу перерахування обітових полів
            do
            {
                Console.Write("Введіть к-сть стрічок масиву: ");
                string a = Console.ReadLine();
                flag = int.TryParse(a, out m);
                if (flag)
                    break;
                else
                {
                    Console.WriteLine("Невірно введені данні!");
                    flag = true;
                }

            } while (flag);

            Console.WriteLine();
            return m;
        }

        public int InputMassiveSize_N()
        {
            //Введення і перевірка на правильність кількості стовпчиків масиву
            bool flag = false;
            do
            {
                Console.Write("Введіть к-сть стовпчиків масиву: ");
                string a = Console.ReadLine();
                flag = int.TryParse(a, out n);
                if (flag)
                    break;
                else
                {
                    Console.WriteLine("Невірно введені данні!!!!");
                    flag = true;
                }

            } while (flag);

            Console.WriteLine();
            return n;
        }

        public int[,] CreateMassive()
        {
            //Створення і заповнення масиву
            Console.WriteLine("Створений масив: ");
            Random rnd = new Random();
            mass = new int[m, n];
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    mass[i, j] = rnd.Next(1, 40);
                }
            }

            Console.WriteLine();
            return mass;
        }

        public void OutputMassive()
        {
            //Вивід масиву у консоль
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write($"{mass[i, j]} \t");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        public void GetMassiveValue()
        {
            //Функція отримання індексу масиву за його значенням
            int count = 0;

            Console.Write("Введіть елемент масиву ");
            int a = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (a == mass[i, j])
                    {
                        Console.WriteLine($"Елемент масиву у {a} знаходиться на позиції - {i}, {j}");
                        count++;
                    }
                }
            }
            if (count == 0)
                Console.WriteLine($"Елементу {a} у масиві немає");
            Console.WriteLine();
        }

        
        public void TaskFunction()//Функція знаходження минимального значення елементів у стрічкі масиву
        {
            {
                for (int st = 0; st < n; st++)
                {
                    int t = int.MaxValue;
                    for (int i = 0; i < m; i++)
                    {
                        if (mass[st, i] < t)
                        {
                            t = mass[st, i];

                        }

                    }
                    Console.WriteLine($"в стрічкі {st + 1} мінамальне число:{t}");

                }
                Console.ReadKey();
            }

        }

    }
}