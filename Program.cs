using System;

namespace DZ_modul_1
{
    internal class Program
    {
        static void NumLog(int n)
        {
            if(n > 100 || n <= 0)
            {
                Console.WriteLine("ERROR: invalid range number");
                return;
            }
            else if(n % 3 == 0)
            {
                Console.WriteLine("Fizz");
                return;
            }

            else if(n % 5 == 0)
            {
                Console.WriteLine("Buzz");
                return;
            }

            else if(n % 3 == 0 && n % 5 == 0)
            {
                Console.WriteLine("Fizz Buzz");
                return;
            }
            else if (!(n % 3 == 0 && n % 5 == 0))
            {
                Console.WriteLine($"The number itself: {n}");
                return;
            }
                
        }

        static void PrNum(int num, int pr)
        {
            double res = ((double)num / (double)pr);

            Console.WriteLine($"The result is a percentage {pr} of number {num} = {res}");
        }

        static void FormNum(int n1,int n2, int n3, int n4)
        {

            string res = n1.ToString() + n2.ToString() + n3.ToString() + n4.ToString();

            Console.WriteLine($"The result form from numbers {res}");
        }

        static void SwapNum(int n, int p1, int p2)
        {
            string res = n.ToString();

            if ((p1 >= 16 || p1 < 0) && (p2 >= 16 || p2 < 0))
            {
                Console.WriteLine("ERROR: invalid index range");
                return;
            }

            char[] res_ch = res.ToCharArray();

            char tmp = res_ch[p1];
            res_ch[p1] = res_ch[p2];
            res_ch[p2] = tmp;

            res = new string(res_ch);

            Console.WriteLine($"The result from swap numbers {res}");
        }

        static void ConvTemp(int t)
        {
            
            Console.WriteLine("Enter your choice: 1 Fahrenheit to Celsius.\t2 Celsius to Fahrenheit");
            int choice = int.Parse(Console.ReadLine());

            double res;

            switch (choice)
            {
                case 1:
                   res = (t - 32) * 5 / 9;
                    Console.WriteLine($"The result from convert Fahrenheit to Celsius {res}");
                    break;

                case 2:
                   res = t * 9 / 5 + 32;
                   Console.WriteLine($"The result from convert Celsius to Fahrenheit {res}");
                    break;


            }

        }
        static void SwapNum_p(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }
        static void ShowEvenNumbers(int min, int max)
        {
            if(min > max)
            {
                SwapNum_p(ref min,ref max);
            }
            for(int n = min; n <= max; n++)
            {
                if (n % 2 == 0)
                    Console.WriteLine($"{n} — чётное");
            }
        }
        static void Main(string[] args)
        {


            //Задание 1
            //Пользователь вводит с клавиатуры число в диапазоне от 1 до 100.Если число кратно 3(делится на 3 без
            //остатка) нужно вывести слово Fizz. Если число кратно 5
            //нужно вывести слово Buzz. Если число кратно 3 и 5 нужно
            //вывести Fizz Buzz. Если число не кратно не 3 и 5 нужно
            //вывести само число.
            //Если пользователь ввел значение не в диапазоне от 1
            //до 100 требуется вывести сообщение об ошибке.

            //Console.Write("Enter number from 1 to 100: ");

            //int num =int.Parse(Console.ReadLine());

            //NumLog(num);


            //Задание 2
            //Пользователь вводит с клавиатуры два числа. Первое
            //число — это значение, второе число процент, который
            //необходимо посчитать. Например, мы ввели с клавиатуры
            //90 и 10.Требуется вывести на экран 10 процентов от 90.
            //Результат: 9.

            //Console.Write("Enter number: ");
            //int num1 = int.Parse(Console.ReadLine());

            //Console.Write("Enter percent: ");
            //int num2 = int.Parse(Console.ReadLine());

            //PrNum(num1, num2);

            //Задание 3
            //Пользователь вводит с клавиатуры четыре цифры.
            //Необходимо создать число, содержащее эти цифры.Например, если с клавиатуры введено 1, 5, 7, 8 тогда нужно
            //сформировать число 1578.

            //Console.Write("Enter number: ");
            //int numb1 = int.Parse(Console.ReadLine());

            //Console.Write("Enter number: ");
            //int numb2 = int.Parse(Console.ReadLine());

            //Console.Write("Enter number: ");
            //int numb3 = int.Parse(Console.ReadLine());

            //Console.Write("Enter number: ");
            //int numb4 = int.Parse(Console.ReadLine());

            //FormNum(numb1, numb2, numb3, numb4);

            //Задание 4
            //Пользователь вводит шестизначное число. После чего
            //пользователь вводит номера разрядов для обмена цифр.
            //Например, если пользователь ввёл один и шесть — это
            //значит, что надо обменять местами первую и шестую
            //цифры.
            //Число 723895 должно превратиться в 523897.
            //Если пользователь ввел не шестизначное число требуется вывести сообщение об ошибке.

            //Console.Write("Enter number: ");
            //int numb_16r = int.Parse(Console.ReadLine());

            //Console.Write("Enter digit number 1 for digit exchange: ");
            //int p1 = int.Parse(Console.ReadLine());

            //Console.Write("Enter digit number 2 for digit exchange: ");
            //int p2 = int.Parse(Console.ReadLine());

            //SwapNum(numb_16r, p1, p2);

            //Задание 5
            //Пользователь вводит с клавиатуры дату.Приложение должно отобразить название сезона и дня недели.
            //Например, если введено 22.12.2021, приложение должно
            //отобразить Winter Wednesday.

            //Задание 6
            //Пользователь вводит с клавиатуры показания температуры. В зависимости от выбора пользователя программа переводит температуру из Фаренгейта в Цельсий
            //или наоборот.

            Console.Write("Enter temperature: ");
            int t = int.Parse(Console.ReadLine());

            ConvTemp(t);

            //Задание 7
            //Пользователь вводит с клавиатуры два числа. Нужно
            //показать все четные числа в указанном диапазоне. Если
            //границы диапазона указаны неправильно требуется произвести нормализацию границ.Например, пользователь
            //ввел 20 и 11, требуется нормализация, после которой
            //начало диапазона станет равно 11, а конец 20.

            Console.WriteLine("Введите диапазон четных чисел ");
            int min = int.Parse(Console.ReadLine());
            int max = int.Parse(Console.ReadLine());
            ShowEvenNumbers(min,max);
        }
    }
}
