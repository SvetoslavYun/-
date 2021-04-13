using System;
using System.Text;


namespace Progekt_1
{   
    class Program
    {
        public static int H;
        public static int n;
        public static double b;
        public static int d;
        public static int c;
        public static int j;
        public static int o;
        public static int result;
        public static string a;
        static void Main(string[] args)
        {
            static void F5()
            {

                    H = 2;
                    Console.WriteLine("введите имя питомца");
                    a = (Console.ReadLine());
            }

            static void F7()
            {

                try
                {
                    H = 2;                 
                    Console.WriteLine("введите возраст питомца");
                    n = int.Parse(Console.ReadLine());                  
                }
                catch
                {

                    Console.WriteLine("Введено недопустимое значение, попробуйте еще раз. ");
                    H = 3;
                }
                if (H != 2) F7();
            }

            static void F8()
            {        
                try
                {
                    H = 2;
                    Console.WriteLine("введите вес питомца");
                    b = double.Parse(Console.ReadLine());
                }
                catch
                {

                    Console.WriteLine("Введено недопустимое значение, попробуйте еще раз. ");
                    H = 4;
                }
                if (H != 2) F8();
            }

            static void F9()
            {
                try
                {
                    H = 2;
                    Console.WriteLine("введите первую отметку");
                    d = int.Parse(Console.ReadLine());
                }
                catch
                {

                    Console.WriteLine("Введено недопустимое значение, попробуйте еще раз. ");
                    H = 5;
                }
                if (H != 2) F9();
            }

            static void F10()
            {


                try
                {
                    H = 2;
                    Console.WriteLine("введите вторую отметку");
                    c = int.Parse(Console.ReadLine());
                }
                catch
                {

                    Console.WriteLine("Введено недопустимое значение, попробуйте еще раз. ");
                    H = 6;
                }
                if (H != 2) F10();
            }

            static void F11()
            {


                try
                {
                    H = 2;
                    Console.WriteLine("введите третью отметку");
                    j = int.Parse(Console.ReadLine());
                }
                catch
                {

                    Console.WriteLine("Введено недопустимое значение, попробуйте еще раз. ");
                    H = 7;
                }
                if (H != 2) F11();
            }

            static void F12()
            {


                try
                {
                    H = 2;
                    Console.WriteLine("введите четвертую отметку");
                    o = int.Parse(Console.ReadLine());
                }
                catch
                {

                    Console.WriteLine("Введено недопустимое значение, попробуйте еще раз. ");
                    H = 8;
                }
                if (H != 2) F12();
            }

            static void F13()
            {
                Pet pet1 = new Pet(a, n, b, new int[] { d, c, j, o });
                Console.WriteLine(pet1);
            }

            static void F14()
            {
                result = (d + c + j + o) / 4;
                Console.WriteLine("средний бал" );
                Console.WriteLine( result);
            }

            static void F6()
            {
                if (H == 1) F5();
                if (H == 3) F7();
                if (H == 4) F8();
                if (H == 5) F9();
                if (H == 6) F10();
                if (H == 7) F11();
                if (H == 8) F12();
            }

            static void Ma()
            {
               
                Console.WriteLine("***************Главное меню***************");
                Console.WriteLine("1 – ввод имени питомца");
                Console.WriteLine("2 – ввод возрпаста питомца");
                Console.WriteLine("3 – ввод веса питомца");
                Console.WriteLine("4 – ввод первой отметки");
                Console.WriteLine("5 – ввод второй отметки");
                Console.WriteLine("6 – ввод третей отметки");
                Console.WriteLine("7 – ввод четвертой отметки");
                Console.WriteLine("8 – ввывод данных о питомце");
                Console.WriteLine("9 – ввывод среднего балла");
                Console.WriteLine("0 – выход");
                while (true)
                {
                    Console.WriteLine("Выберите действие: ");
                    int choice = Convert.ToInt32(Console.ReadLine());
                    switch (choice)
                    {
                        case 1:
                            F5();
                            F6();
                            break;
                        case 2:
                            F7();
                            F6();
                            break;
                        case 3:
                            F8();
                            F6();
                            break;
                        case 4:
                            F9();
                            F6();
                            break;
                        case 5:
                            F10();
                            F6();
                            break;
                        case 6:
                            F11();
                            F6();
                            break;
                        case 7:
                            F12();
                            F6();
                            break;
                        case 8:
                            F13();
                            F6();
                            break;
                        case 9:
                            F14(); 
                            break;
                        case 0: return;
                    }
                }
            }

            Ma();

           
        }
    }
}
