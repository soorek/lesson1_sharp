


internal class Program
{
    private static void Main(string[] args)
    {
        void DataType()
        {
            // Типы данных в C#

            string variable_string = "Это строка";
            int variable_int = 12;
            double variable_double = 24.5;
            bool variable_bool = true;
            char variable_char = 'a';


            // Консольный вывод

            Console.WriteLine("Тип данных - строчка " + variable_string);
            Console.WriteLine("Тип данных - целочисленный " + variable_int);
            Console.WriteLine("Тип данных - дробный " + variable_double);
            Console.WriteLine("Тип данных - логический " + variable_bool);
            Console.WriteLine("Тип данных - символьный " + variable_char);

            // Сложение двух переменных в консоли для вывода

            Console.WriteLine(variable_int + variable_double);

            // Консольный ввод и конвертация для него типов данных

            Console.WriteLine("Введите переменную типа int: ");
            int xInt;
            xInt = int.Parse(Console.ReadLine());
            Console.WriteLine(xInt + " - ваше значение.");

            Console.WriteLine("Введите переменную типа char: ");
            char xChar;
            xChar = char.Parse(Console.ReadLine());
            Console.WriteLine(xChar + " - ваше значение.");

            Console.WriteLine("Введите переменную типа double: ");
            double xDouble;
            xDouble = double.Parse(Console.ReadLine());
            Console.WriteLine(xDouble + " - ваше значение.");

            Console.WriteLine("Введите переменную типа bool: ");
            bool xBool;
            xBool = bool.Parse(Console.ReadLine());
            Console.WriteLine(xBool + " - ваше значение.");

            Console.WriteLine("Введите переменную типа string: ");
            string xString;
            xString = Console.ReadLine();
            Console.WriteLine(xDouble + " - ваше значение.");


            // Бла бла бла, раз два три, 4 5, это очень важный комментарий для нашей работы
        }
        void Condition()
        {

            while (true)
            {
                Console.WriteLine("Введите свой баланс: ");

                int amountOfMoney = int.Parse(Console.ReadLine());

                if (amountOfMoney >= 2000)
                {
                    Console.WriteLine("Я богат, куплю два доширака вместо одного");
                }
                else if (amountOfMoney > 0)
                {
                    Console.WriteLine("Деньги есть, но не хватает, пройду мимо магазина");
                }
                else
                {
                    Console.WriteLine("Денег нет, продам Сережу за доширак");
                }
            }

        }
        void Cycle()
        {
            int i = 0;


            // Цикл с предусловием
            while (i < 5)
            {
                Console.WriteLine(i);
                i++;
            }

            // Цикл с постусловием
            i = 0;
            do
            {
                i++;
                Console.WriteLine(i);
            } while (i < 0);

            // Цикл for

            for (i = 0; i <= 52; i++)
            {
                Console.WriteLine(i);
            }


            int mnojitel = 5;
            for (i = 0; i < 11; i++)
            {
                Console.WriteLine(mnojitel + " * " + i +
                    " = " + i * mnojitel);
            }

            // определение массива

            int[] numbers;
            int[] numbers_1 = new int[10];
            int[] numbers_2 = new int[5] { 1, 5, 23, -4, 10 };
            int[] numbers_3 = { 1, 24, 3, -8 };

            // определенние n-мерных массивов

            int[,] matrix = new int[3, 3] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };


            foreach (int a in numbers_2)
            {
                Console.WriteLine(a);
            }

            for (int b = 0; b < numbers_2.Length; b++)
            {
                Console.WriteLine(b);
                Console.WriteLine(numbers_2[b]);

                Console.WriteLine("В ячейке под номером" + b
                    + "хранится значение" + numbers_2[b]);
            }

        }

        


        int getSquare(int x, int y)
        {
            int z = x + y;

            return x * y;

        }

        double getKVADRAT(double x)
        {
            var result = x * x;
            return result;
        }

        
        Console.WriteLine(getKVADRAT(100346));

        var max = Int32.MaxValue;
        var min = Int32.MinValue;

        Console.WriteLine(max + " " + min);

        int getFactorial(int number)
        {
            var result = 1;

            for (int i = 0; i <=number; i++)
            {
                result *= i;
            }
                return result;
        }

        Console.WriteLine(getFactorial(4));
    }
}
    
