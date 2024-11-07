using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_Tasks_from_file
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1.Вывести на экран число e(основание натурального логарифма) с точностью до десятых.
            Console.WriteLine("Задание 1");
            double digit = Math.E;
            Console.WriteLine(Math.Round(digit, 1));
            Console.WriteLine(" ");
            //2. Вывести на экран числа 50 и 10 одно под другим.
            Console.WriteLine("Задание 2");
            int fifty = 50;
            Console.WriteLine(fifty);
            int ten = 10;
            Console.WriteLine(ten);
            Console.WriteLine(" ");
            //3.Составить программу вывода на экран «столбиком» четырех любых чисел.
            Console.WriteLine("Задание 3");
            int three = 3;
            Console.WriteLine(three);
            int seven = 7;
            Console.WriteLine(seven);
            int five = 5;
            Console.WriteLine(five);
            int thirty = 30;
            Console.WriteLine(thirty);
            Console.WriteLine(" ");
            //4. Пользователь вводит число. Выведите на экран число, которое больше введенного на 10.
            Console.WriteLine("Задание 4");
            string number;
            Console.Write("Введите любое число: ");
            number = Console.ReadLine();
            int f = int.Parse(number); // временно обозначим число, введенное пользователем,буквой f.
            int answer = f + 10;
            Console.WriteLine(answer);
            Console.WriteLine(" ");
            //5. Дана сторона квадрата. Найти его периметр.
            Console.WriteLine("Задание 5");
            string sideLength;
            Console.Write("Введите значение длины стороны квадрата: ");
            sideLength = Console.ReadLine();
            int side = int.Parse(sideLength);
            int perimeter = side * 4;
            Console.WriteLine($"Периметр квадрата с заданной стороной равен : {perimeter}");
            Console.WriteLine(" ");
            //6. Дан радиус окружности. Найти длину окружности и площадь круга.
            Console.WriteLine("Задание 6");
            string radius;
            Console.Write("Задайте радиус окружности: ");
            radius = Console.ReadLine();
            double p = double.Parse(radius); // временно обозначим число, введенное пользователем, буквой p.
            double resultC = p * 2 * 3.14;
            Console.WriteLine($"Длина окружности с заданным радиусом равна: {resultC}");
            double resultS = p * p * 3.14;
            Console.WriteLine($"Площадь круга с заданным радиусом равна:{resultS}");
            Console.WriteLine(" ");
            //7. Найти значение y=cos(x).
            Console.WriteLine("Задание 7");
            string x;
            Console.Write("Введите значение угла в градусах: ");
            x = Console.ReadLine();
            double X = double.Parse(x);
            double cos = Math.Cos(X * 3.14 / 180);
            Console.WriteLine($"Значение косинуса заданного угла:{cos}");
            Console.WriteLine(" ");
            //8. Даны основания и высота равнобедренной трапеции. Найти ее периметр.
            Console.WriteLine("Задание 8");
            string firstBase;
            Console.Write("Введите значение длины основания 1 трапеции: ");
            firstBase = Console.ReadLine();
            string secondBase;
            Console.Write("Введите значение длины основания 2 трапеции: ");
            secondBase = Console.ReadLine();
            string height;
            Console.Write("Введите значение высоты трапеции: ");
            height = Console.ReadLine();
            int v = int.Parse(height);// пусть v- обозначение высоты трапеции.
            int t = int.Parse(firstBase);// пусть t- обозначение 1 основания трапеции.
            int r = int.Parse(secondBase);// пусть r- обозначение 2 основания трапеции.
            int result = (t + r) / 2 * v;
            Console.WriteLine($"Периметр трапеции равен: {result}");
            Console.WriteLine("");
            /*9. Известна стоимость 1 кг конфет, печенья и яблок. Найти стоимость всей покупки,
            если купили x кг конфет, у кг печенья и z кг яблок.*/
            Console.WriteLine("Задание 9");
            string sweets;
            Console.Write("Задайте стоимость 1 кг конфет: ");
            sweets = Console.ReadLine();
            string cookies;
            Console.Write("Задайте стоимость 1 кг печенья: ");
            cookies = Console.ReadLine();
            string apples;
            Console.Write("Задайте стоимость 1 кг яблок: ");
            apples = Console.ReadLine();
            string sumSweets;
            Console.Write("Задайте количество кг конфет: ");
            sumSweets = Console.ReadLine();
            string sumCookies;
            Console.Write("Задайте количество кг печенья: ");
            sumCookies = Console.ReadLine();
            string sumApples;
            Console.Write("Задайте количество кг яблок:");
            sumApples = Console.ReadLine();
            int candies = int.Parse(sweets);
            int cookie = int.Parse(cookies);
            int apple = int.Parse(apples);
            int numberOfApples = int.Parse(sumApples);
            int numberOfsweets = int.Parse(sumSweets);
            int numberOfcookies = int.Parse(sumCookies);
            int purchasePrice = candies * numberOfsweets + apple * numberOfApples + cookie * numberOfsweets;
            Console.WriteLine($"Стоимость покупки составила: {purchasePrice}");
            Console.WriteLine(" ");
            /*10. Напишите программу, выводит на экран три строки "Мир", "Труд" и "Май"
            (кавычки не нужны). Причём сделайте, чтобы выводилось сначала так: Мир Труд Май 
            Затем так:
                      Мир
                          Труд
                               Май*/
            Console.WriteLine("Задание 10");
            Console.WriteLine("Мир Труд Май");
            Console.WriteLine("Мир");
            Console.WriteLine("\tТруд");
            Console.WriteLine("\t\t Май");
            Console.WriteLine(" ");
            /*11.Программа просит пользователя ввести 2 числовые переменные. А после она
            меняет их местами и выводит результат на экран.Но, так как пользователь может
            ошибиться, необходимо предусмотреть тот факт, что пользователь может ввести,
            например, букву или строку, а так же учесть, что число может быть дробным, и для
            выделения её дробной части одни используют точку, другие – запятую.*/
            Console.WriteLine("Задание 11");
            string firstVariable;
            Console.Write("Задайте числовое значение для первой переменной: ");
            firstVariable = Console.ReadLine();
            firstVariable = firstVariable.Replace('.', ',');
            double z; // Обозначим первую переменную за z.
            bool isValidFirstNumber = double.TryParse(firstVariable, out z);
            if (!isValidFirstNumber)
            {
                Console.WriteLine("Ошибка.Убедитесь в корректности введённых данных");
            }
            string secondVariable;
            Console.Write("Задайте числовое значение для второй переменной: ");
            secondVariable = Console.ReadLine();
            secondVariable = secondVariable.Replace('.', ',');
            double y; // Обозначим вторую переменную за y.
            bool isValidSecondNumber = double.TryParse(secondVariable, out y);
            if (!isValidSecondNumber)
            {
                Console.WriteLine("Ошибка.Убедитесь в корректности введённых данных");
            }
            double change;
            change = z;
            z = y;
            y = change;
            Console.WriteLine($"{z},{y}");
            Console.WriteLine(" ");
            /* 13. Составить программу вывода на экран числа, вводимого с клавиатуры.Вводимому
            числу должно предшествовать сообщение «Вы ввели число».*/
            Console.WriteLine("Задание 13");
            string yourNumber;
            Console.Write("Вы ввели число: ");
            yourNumber = Console.ReadLine();
            int yourResult = int.Parse( yourNumber );
            Console.WriteLine($"{yourNumber}");
            Console.WriteLine(" ");
            /*14. Составить программу вывода на экран следующей информации:
            2 кг
            13 17*/
            Console.WriteLine("Задание 14");
            Console.WriteLine("2 кг");
            Console.WriteLine("13 17");
            Console.WriteLine(" ");
            //15. Составить программу вывода на экран «столбиком» четырех случайных чисел.
            Console.WriteLine("Задание 15");
            int firstDigit;
            Random random = new Random();
            firstDigit = random.Next(1,157);
            Console.WriteLine($"{firstDigit}");
            int secondDigit;
            Random secondRandom = new Random();
            secondDigit = secondRandom.Next(157,396);
            Console.WriteLine($"{secondDigit}");
            int thirdDigit;
            Random thirdRandom = new Random();
            thirdDigit = thirdRandom.Next(396, 780);
            Console.WriteLine($"{thirdDigit}");
            int fourthDigit;
            Random fourthRandom = new Random();
            fourthDigit = fourthRandom.Next(780, 1064);
            Console.WriteLine($"{fourthDigit}");
            Console.WriteLine(" ");
            /* 16. Найти корни квадратного уравнения(коэффициенты задаются пользователем с
            клавиатуры)*/
            Console.WriteLine("Задание 16");
            Console.WriteLine("Задайте значения переменным a,b,c для нахождения корней следующего уравнения: ax^2 + bx + c = 0");
            Console.WriteLine("Значение для переменной a : ");
            string firstNumb = Console.ReadLine();
            Console.WriteLine("Значение для переменной b : ");
            string secondNumb = Console.ReadLine();
            Console.WriteLine("Значение для переменной c : ");
            string thirdNumb = Console.ReadLine();
            double a = double.Parse(firstNumb);
            double b = double.Parse(secondNumb);
            double c = double.Parse(thirdNumb);
            double firstAnswer = (-b + Math.Sqrt(b * b - 4 * a * c)) / 2 * a;
            double secondAnswer = (-b - Math.Sqrt(b * b - 4 * a * c)) / 2 * a;
            Console.WriteLine($" Ответ : x1 = {firstAnswer} , x2 = {secondAnswer}");
            Console.WriteLine(" ");
            /*17.Даны два целых числа. Найти: а) их среднее арифметическое; б) их среднее
            геометрическое.*/
            Console.WriteLine("Задание 17");
            string firstInteger;
            Console.WriteLine("Введите первое число: ");
            firstInteger = Console.ReadLine();
            string secondInteger;
            Console.WriteLine("Введите второе число: ");
            secondInteger = Console.ReadLine();
            double integerFirst = double.Parse(firstInteger);
            double integerSecond = double.Parse(secondInteger);
            double mean = (integerFirst + integerSecond) / 2;
            Console.WriteLine($"Среднее арифметическое введённых чисел: {mean} ");
            double meanGeometric = Math.Sqrt(integerFirst*integerSecond);
            Console.WriteLine($"Среднее геометрическое введённых чисел {meanGeometric}");
            Console.WriteLine(" ");
            /*18. Известны координаты на плоскости двух точек. Составить программу вычисления
           расстояния между ними.*/
            Console.WriteLine("Задание 18");
            double firstX;
            Console.Write("Введите координату первой точки на оси абсцисс: ");
            firstX = Convert.ToDouble(Console.ReadLine());
            double firstY;
            Console.Write("Введите координату первой точки на оси ординат: ");
            firstY = Convert.ToDouble(Console.ReadLine());
            double secondX;
            Console.Write("Введите координату второй точки на оси абсцисс: ");
            secondX = Convert.ToDouble(Console.ReadLine());
            double secondY;
            Console.Write("Введите координату второй точки на оси ординат: ");
            secondY = Convert.ToDouble(Console.ReadLine());
            double distance = Math.Sqrt((secondX-firstX)*(secondX-firstX) + (secondY-firstY)*(secondY-firstY));
            Console.WriteLine($"Расстояние между двумя точками равняется:{distance}");
            Console.WriteLine(" ");
            /*19.Составить программу обмена значениями трех переменных величин а, b, c по
            следующим двум схемам:
            а) b присвоить значение c, а присвоить значение b, с присвоить значение а;
            б) b присвоить значение а, с присвоить значение b, а присвоить значение с.*/
            Console.WriteLine ("Задание номер 19, пункт а");
            int numberA;
            Console.WriteLine("Введите значение переменной a: ");
            numberA = Convert.ToInt32(Console.ReadLine());
            int numberB;
            Console.WriteLine("Введите значение переменной b: ");
            numberB = Convert.ToInt32(Console.ReadLine());
            int numberC;
            Console.WriteLine("Введите значение переменной c: ");
            numberC = Convert.ToInt32(Console.ReadLine());
            int numberD = numberB;
            numberB = numberC;
            numberC = numberA;
            numberA= numberD;  
            Console.WriteLine($"Итог: a = {numberA}, b = {numberB}, c = {numberC}");
            Console.WriteLine(" ");
            Console.WriteLine("Задание номер 19, пункт б");
            int numberAB;
            Console.WriteLine("Введите значение переменной a: ");
            numberAB = Convert.ToInt32(Console.ReadLine());
            int numberBB;
            Console.WriteLine("Введите значение переменной b: ");
            numberBB = Convert.ToInt32(Console.ReadLine());
            int numberCB;
            Console.WriteLine("Введите значение переменной c: ");
            numberCB = Convert.ToInt32(Console.ReadLine());
            int numberDB = numberAB; // B-пункт б, numberDB-временная переменная
            numberAB = numberBB;
            numberBB = numberCB;
            numberCB = numberDB;
            Console.WriteLine($"Итог: a = {numberAB}, b = {numberBB}, c = {numberCB}");
            Console.WriteLine(" ");
            /*20. С начала суток прошло n секунд. Определить:
         а) сколько полных часов прошло с начала суток;
         б) сколько полных минут прошло с начала очередного часа;
         в) сколько полных секунд прошло с начала очередной минуты.*/
            Console.WriteLine("Задание 20");
            int seconds;
            Console.WriteLine("Введите количество прошедших секунд: ");
            seconds = Convert.ToInt32(Console.ReadLine());
            int hours = seconds / 3600;//Пункт а;
            Console.WriteLine($"Полных часов с начала суток прошло:{hours} ");
            int secondsNow = seconds % 3600;
            int minute = secondsNow / 60;
            Console.WriteLine($"Полных минут с начала очередного часа прошло: {minute} ");//Пункт б;
            int minutesNow = minute % 60;
            Console.WriteLine($"Полных секунд прошло с начала очередной минуты: {minutesNow}");
            Console.WriteLine(" ");
           /*21. Дан прямоугольник с размерами 543 х 130 мм. Сколько квадратов со стороной 130
          мм можно отрезать от него?*/
            Console.WriteLine("Задание 21");
            int sideA = 543;
            int sideB = 130;
            int sideOfTheSquare = 130;
            int SOfRecr = sideA * sideB;
            int SOfSquare = sideB * sideB;
            int quantity = SOfRecr / SOfSquare;
            Console.WriteLine($"Количество квадратов равняется:{quantity}");
            Console.WriteLine(" "); 
            /*34. Составить программу, которая:
         а) запрашивает имя человека и повторяет его на экране;
         б) запрашивает имя человека и повторяет его на экране с приветствием.*/
            Console.WriteLine("Задание 34, пункт а");
            string name;
            Console.Write("Введите Ваше имя: ");
            name = Console.ReadLine();
            Console.WriteLine($"{name}");
            Console.WriteLine(" ");
            Console.WriteLine("Задание 34, пункт б");
            string nameSecond;
            Console.Write("Введите Ваше имя: ");
            nameSecond = Console.ReadLine();
            Console.WriteLine($"Здравствуйте, {nameSecond}!");
            Console.WriteLine(" ");












        }
    }
}
