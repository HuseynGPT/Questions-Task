using System;
using System.ComponentModel.Design;
using System.Net.Sockets;



namespace ConsoleApp1
{



    class Program
    {



        static public void ShowScore(byte Score)
        {
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine(@$"Congrulation! You finish test!!");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine($"          Your Score ---> {Score} ");
            Console.BackgroundColor = ConsoleColor.Black;
        }



        static void Main()
        {
            Console.Title = "Simple Quiz";
            int indexQuestion = 0;
            int indexVariants = 1;
            int indexAnswer = 4;



            byte SCORE = 0;



            string[,] questions =
            {
                {"Azerbaycanin paytaxti haradir?", "Baki", "Sumqayit", "Gence", "Baki" },
                {"INT ramda nece bayt yer tutur?", "4", "2", "8", "4" },
                {"\'Byte\' nin ala bileceyi maksimum deyer necedir?", "255", "21443543", "155", "255" },
                {"Ismin nece hail var?", "6", "4", "3", "6" },
                {"x + 10 = 54 durse, x = ?", "44", "32", "46", "44" },
                {"\'print(\'salam\' * 3)\' Ekrana ne cixacaq?", "salamsalamsalam", "ERROR", "salam * 3", "salamsalamsalam" },
                {"Azerbaycan Himninin musiqisi kime aiddir?", "Ehmed Cavad", "Uzeyir Hacibeyli", "Qara Qarayev", "Uzeyir Hacibeyli" },
                {"Azerbaycanin texmini ehalisi ne qederdir?", "10000000", "8000000", "15000000", "10000000" },
                {"Dunyanin en boyuk okeaninin adi nedir?", "Sakit", "Hind", "Atlantik", "Sakit" },
                {"Paris haranin paytaxtidir?", "Fransa", "Amerika", "Turkiye", "Fransa" }
            };





            string inputVariant;
            int i = 0;
            int previousRandom = 1;
            int index1 = 1;
            int index2 = 2;
            int index3 = 3;
            Random random = new Random();
            while (i != 10)
            {
                Console.WriteLine();
                Console.WriteLine($"{i + 1}){questions[i, 0]}");
                for (int j = 1; j <= 1; j++)
                {
                    index1 = random.Next(1, 4);
                    switch (index1)
                    {
                        case 1:
                            index2 = 2;
                            index3 = 3;
                            break;



                        case 2:
                            index2 = 1;
                            index3 = 3;
                            break;
                        case 3:
                            index2 = 1;
                            index3 = 2;
                            break;



                        default:
                            break;
                    }




                    string temp = questions[i, index2];
                    questions[i, index2] = questions[i, index1];
                    questions[i, index1] = temp;

                    Console.WriteLine($"A){questions[i,index1]}");
                    Console.WriteLine($"B){questions[i,index2]}");
                    Console.WriteLine($"C){questions[i,index3]}");

                    //if (j == 1) Console.Write("A)");
                    //else if (j == 2) Console.Write("B)");
                    //else if (j == 3) Console.Write("C)");



                    //Console.WriteLine(questions[i, j]);
                }



                Console.Write("Duzgun cavabin variantini daxil edin: ");
                inputVariant = Console.ReadLine();
                if (inputVariant.ToLower() == "a")
                {
                    if (questions[i, 1] == questions[i, 4])
                    {



                        SCORE += 10;
                    }
                    else
                        SCORE -= 10;
                }



                else if (inputVariant.ToLower() == "b")
                {
                    if (questions[i, 2] == questions[i, 4])
                        SCORE += 10;
                    else
                        SCORE -= 10;
                }



                else if (inputVariant.ToLower() == "c")
                {
                    if (questions[i, 3] == questions[i, 4])
                        SCORE += 10;
                    else
                        SCORE -= 10;
                }





                i++;
                Console.WriteLine();
            }



            if (SCORE < 0)
                SCORE = 0;
            Console.Clear();



            ShowScore(SCORE);



            Console.WriteLine("Press Any key to exit program");
            Console.ReadKey();
        }
    }
}