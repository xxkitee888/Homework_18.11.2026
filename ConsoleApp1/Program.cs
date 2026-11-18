using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1
            SayHello();
            SayHello();
            SayHello();
            
            void SayHello()
            {
                Console.WriteLine($"Привет, мир");
            }

            //2
            Greet("Саша");
            Greet("Ваня");
            Greet("Павел");
            
            void Greet(string name)
            {
                Console.WriteLine($"Привет, {name}");
            }

            //3
            PrintPerson("Егор", 15, "Москва");
            PrintPerson("Паша", 16, "Питер");
            
            void PrintPerson(string name, int age, string city)
            {
                Console.WriteLine($"Имя: {name}, Возраст: {age}, город: {city}");
            }


            //4
            PrintPersonWithHobby("Ivan", "Programmirovanie", 25);
            PrintPersonWithHobby("Masha");
            
            void PrintPersonWithHobby(string name, string hobby = "Не указано", int age = 18)
            {
                Console.WriteLine($"Имя: {name}, Возраст: {age}, хобби: {hobby}");
            }


            //5
            int num = 16;
            int res = Square(num);
            Console.WriteLine($"Квадрат числа {num} = {res}");
            
            int Square(int x)
            {
                return x * x;
            }

            //6
            Console.WriteLine("Введите 1e число: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите 2e число: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();

            add(num1, num2);
            subtract(num1, num2);
            multiply(num1, num2);
            divide(num1, num2);
            
            void add(int a1, int b1)
            {
                Console.WriteLine(a1 + b1);
            }

            void subtract(int a1, int b1)
            {
                Console.WriteLine(a1 - b1);
            }

            void multiply(int a1, int b1)
            {
                Console.WriteLine(a1 * b1);
            }

            void divide(int a1, int b1)
            {
                Console.WriteLine(a1 / b1);
            }

            //7
            int counter = 0;
            Increment();
            Console.WriteLine($"1й вызов: {counter}");
            Increment();
            Console.WriteLine($"2й вызов: {counter}");
            Increment();
            Console.WriteLine($"3й вызов: {counter}");
            
            void Increment()
            {
                counter++;
            }

            //8
            Console.WriteLine(Multiply(2, 3));
            Console.WriteLine(Multiply(2, 3, 4));
            Console.WriteLine(Multiply(2.5, 3.5));

            int Multiply(int a, int b)
            {
                return a * b;
            }

            int Multiply(int a, int b, int c)
            {
                return a * b * c;
            }

            double Multiply(double a, double b)
            {
                return a * b;
            }


            
            


        }
    }
}