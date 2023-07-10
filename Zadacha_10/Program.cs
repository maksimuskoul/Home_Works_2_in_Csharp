namespace Zadacha_10;
class Program
{
    static void Main(string[] args)
    {
        int Input(string text)
        {
            Console.Write(text);
            return Convert.ToInt32(Console.ReadLine());
        }

        void Task10()
        {
            /* напишите программу которая принимает на вход 3-х значное 
               число и на выходе показывает вторую цифру этого числа */

            Random rnd = new Random();
            int nam = rnd.Next(100, 1000);
            Console.WriteLine($"рандомное число {nam}");

            int s_nam = nam % 100 / 10;

            Console.WriteLine($"вторая цифра числа : {s_nam}");
        }

        void Task13()
        {
            /* напишите программу которая с помощью деления выводит 3-ю цифру 
                заданного числа или сообщает что третьей цифры нет 
                567 -> 7
                67 -> третей цифры нет 
                45673234 -> 6      
                
                ПРАВИЛЬНОЕ РЕШЕНИЕ
                  */

            int nam = Input("введите любое Целое число  ");

            while (nam > 1000)
            {
                nam = nam / 10;
            }
            if (nam <= 1000 & nam >= 100)
            {
                nam = nam % 10;
                Console.WriteLine($"3 цифра числа : {nam}");
            }
            else if (nam < 100)
                Console.WriteLine($"не целое число : {nam}");

        }
        Console.Clear();
        Task13();
        
        void Task13_2()
        {
            /* напишите программу которая с помощью деления выводит 3-ю цифру 
                заданного числа или сообщает что третьей цифры нет 
                567 -> 7
                67 -> третей цифры нет 
                45673234 -> 6       
                
                ОДИН ИЗ ВАРИАНТОВ
                оставлю тут на всякий случай для себя 
                 */


            
            int nam = Input("введите любое Целое число  ");

            if (nam <= 9999999 & nam >= 999999)
            {
                int f_nam = nam / 10000;
                Console.WriteLine($"1 цифра числа : {f_nam}");
                int t_nam = f_nam % 10;
                Console.WriteLine($" 1 if 3 цифра числа : {t_nam}");
            }
            else if (nam <= 999999 & nam >= 99999)
            {
                int f_nam = nam / 1000;
                Console.WriteLine($"1 цифра числа : {f_nam}");
                int t_nam = f_nam % 10;
                Console.WriteLine($" 2 if 3 цифра числа : {t_nam}");
            }

            else if (nam <= 99999 & nam >= 9999)
            {
                int f_nam = nam / 100;
                Console.WriteLine($"1 цифра числа : {f_nam}");
                int t_nam = f_nam % 10;
                Console.WriteLine($" 3 if 3 цифра числа : {t_nam}");
            }
            else if (nam <= 9999 & nam >= 999)
            {
                int f_nam = nam / 10;
                Console.WriteLine($"1 цифра числа : {f_nam}");
                int t_nam = f_nam % 10;
                Console.WriteLine($" 4 if 3 цифра числа : {t_nam}");
            }
            else if (nam <= 999 & nam >= 99)
            {
                int t_nam = nam % 10;
                Console.WriteLine($" 5 if 3 цифра числа : {t_nam}");

            }
            else if (nam <= 99 & nam >= 1)
            {
                Console.WriteLine(" 6 if 3 (число двузначное) - 3 цифры NET ");
            }
        }
    }
}