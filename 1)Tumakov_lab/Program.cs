using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace _1_Tumakov_lab
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Лабораторная 1.Написать программу, которая спрашивает имя
            пользователя, и затем приветствует пользователя по имени. (Создать
            консольное приложение.)*/
            Console.WriteLine("Лабораторная 1");
            string name;
            Console.Write("Введите Ваше имя: ");
            name = Console.ReadLine();
            Console.WriteLine($"Здравствуйте, {name}!");
            Console.WriteLine(" ");
            /*Лабораторная 2.Написать программу, которой на вход подается два
           числа, на выходе – результат деления одного числа на другое.
           Предусмотреть обработку исключительной ситуации, возникающей при
           делении числа на ноль.*/
            Console.WriteLine("Лабораторная 2");
            Console.Write("Введите числовое значение первой переменной : ");
            string firstNumber = Console.ReadLine();
            Console.Write("Введите числовое значение второй переменной : ");
            string secondNumber = Console.ReadLine();
            int f = int.Parse(firstNumber); // Назовем первую перемменную буквой f.
            int g = int.Parse(secondNumber);// Назовем вторую переменную буквой g.
            if (g == 0)
            {
                Console.WriteLine("Ошибка, убедитесь, что не производилось деление на нуль.");
            }
            else
            {
                int answer = f / g;
                Console.WriteLine($"Ответ: {answer}");
            }
            Console.WriteLine(" ");
            //Домашнее задание 2.1.Прочитать букву с экрана и вывести на печать следующую за ней букву в алфавитном порядке.
            Console.WriteLine(" Домашнее задание 2.1. ");
            char letter;
            Console.Write("Введите любую букву алфавита: ");
            letter = Console.ReadKey().KeyChar;
            Console.WriteLine(" ");
            char secondLeter;
            secondLeter= (char)(letter + 1);
            Console.WriteLine(secondLeter);
            Console.WriteLine(" ");
            /* Домашнее задание 2.2 Написать программу, которая решает квадратное
            уравнение.Входные данные – коэффициенты уравнения, выходные – найденные корни.*/
            Console.WriteLine(" Домашнее задание 2.2 ");
            Console.WriteLine(" Задайте значения переменным a,b,c для нахождения корней следующего уравнения: ax^2 + bx + c = 0");
            Console.WriteLine(" Значение для переменной a : ");
            string firstDigit = Console.ReadLine();
            Console.WriteLine("Значение для переменной b : ");
            string secondDigit = Console.ReadLine();
            Console.WriteLine("Значение для переменной c : ");
            string thirdDigit = Console.ReadLine();
            double a = double.Parse(firstDigit);
            double b = double.Parse(secondDigit);
            double c = double.Parse(thirdDigit);
            double firstAnswer = (-b + Math.Sqrt(b*b - 4*a*c))/ 2*a;
            double secondAnswer = (-b - Math.Sqrt(b * b - 4 * a * c)) / 2 * a;
            Console.WriteLine($" Ответ : x1 = {firstAnswer} , x2 = {secondAnswer}");

















        }
    }
}
