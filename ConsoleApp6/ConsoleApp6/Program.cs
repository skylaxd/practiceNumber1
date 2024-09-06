using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace skillboxcsharpnumer2
{
    class Program
    {
        static void Main(string[] args)
        {
           
            #region первое задание
            string fullName = "Cидоров Иван Андреевич";
            string Gmail = "vanek@yandex.ru ";

            byte Age = 17;
            double programmingPoints = 92.4;
            double mathPoints = 98.2;
            double phisycsPoint = 10.7;
            double arithmeticMean = 67.1;

            string pattern = "ФИО: {0}; Возраст: {1}; Почта: {2}; Информатика Балл: {3}; Математика Балл: {4}; Физика Балл: {5}; Средний Балл {6}";
            Console.Write(pattern,
                fullName,
                Gmail,
                Age,
                programmingPoints,
                mathPoints,
                phisycsPoint,
                arithmeticMean);

            Console.ReadKey();




            #endregion
            #region второе задание
           // double pPoints = 92.4; // информатика
           // double mPoints = 98.2; // математика
           // double pPoint = 10.7; // физика

           // double sum = 92.4 + 98.2 + 10.7;
          //  double a = 201.3; int b = 3;
          //  a /= b;
           // Console.Write(a); //средний балл
           // Console.ReadKey();

            #endregion

        }

        static void hz(string[] args)
        {


            string firstname = "александр";
            string lastname = "пушкин";
            string specialization = "писатель";

            byte age = 37;
            ulong yearOfBirth = 1799;

            string pattern = "Имя: {0} фамилия: {1} специализация: {2} возраст: {3} год рождения: {4}";
            Console.Write(pattern,
                firstname,
                lastname,
                specialization,
                age,
                yearOfBirth);

            Console.ReadKey();
        }
        static void threehundredbucks(string[] args)
        {
            int a = 100;
            int b = 11;
            int c = 111;
            Console.Write($"{a + b + c}");
        }
        static void convert(string[] args)
        {
            string inputString = "2029";
            int intValue = Convert.ToInt32(inputString);
            Console.Write(intValue);
        }
        static void MathOperation(string[] args)
        {
            // арифметические операции 

            #region Сумма +

            // int valueA = 2_140_000_003; int valueB = 2_140_000_003;
            //double valueC = (double)valueA + (double)valueB;

            //sbute valueF = 123; short valueG = 22;
            //var valueH = valueF + valueG

            // long valueK = 32; byte valueL = 11;
            //var valueM = valueK + valueL;

            #region ++

            Console.ReadKey(); Console.WriteLine("\n++");


            // int a = 10;
            // a += 20;
            //  Console.Write(a);

            //  int b = 25;
            // b -= 5;

            // Console.Write(b);


            #endregion
            #endregion

        }
        static void logicOperation(string[] args)
        {
            #region операции 
            bool flag1 = 4 > 5; Console.Write(flag1);
            bool flag2 = 1 < 3; Console.Write(flag2);

            char c = 'f';

            bool flag3 = 'f' == 'f'; Console.Write(flag3);
            bool flag4 = 28 == 28; Console.Write(flag4);
            bool flag5 = 28 >= 24; Console.Write(flag5);
            bool flag6 = 9 <= 9; Console.Write(flag6);
            bool flag7 = 28 != 90; Console.Write(flag7);

            string s = "C#";
            bool flag8 = 28 != 90 && s == "C#"; Console.Write(flag8);

            #endregion


        }
        static void workCordinat(string[] args)
        {
            int x1 = 30, x2 = 150, // кординаты вершин прямоугольника 
            y1 = 20, y2 = 90;

            int pA = 10, pB = 55; // кординаты точки

            //проверки условия принадлежности точки ограниченной области
            bool check = ((pA >= x1) && (pA <= x2)) & ((pB >= y1) && (pB <= y2));
            Console.Write(check);
            Console.Read();
        }
        static void practiceVariables(string[] args)
        {
            string fullName = "Cидоров Иван Андреевич";
            string Gmail = "vanek@yandex.ru ";

            byte Age = 17;
            double programmingPoints = 92.4;
            double mathPoints = 98.2;
            double phisycsPoint = 10.7;

            string pattern = "ФИО: {0} Возраст: {1}Почта: {2} Информатика Балл: {3} Математика Балл: {4} Физика Балл: {5}";
            Console.Write(pattern,
                fullName,
                Gmail,
                Age,
                programmingPoints,
                mathPoints,
                phisycsPoint);

            Console.ReadKey();


        }
    }
}


