using LINQ;
using System.Diagnostics.Contracts;
using System.Security.Cryptography.X509Certificates;

namespace ConsoleApp12
{
    public class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("Vali number");
            Console.WriteLine("1. FIRST");
            Console.WriteLine("2. WHERE");
            Console.WriteLine("3. pyramid");
            Console.WriteLine("4. if ja else");



            string choice = Console.ReadLine();


            switch (choice)
            {
                case "1":
                    FirstOrDefaultLINQ();

                    break;

                case "2":
                    WhereLINQ();

                    break;

                case "3":
                    Pyramid();

                    break;

                case "4":
                    IfjElse();

                    break;





                default:
                    Console.WriteLine("Tegid vale valiku");

                    break;
            }



        }

        public static void WhereLINQ()
        {
            var peopleAge = PeopleList.peoples
                .Where(x => x.Age > 11 && x.Age < 30);

            foreach (var item in peopleAge)
            {
                Console.WriteLine(item.Name);
            }
        }

        public static void FirstOrDefaultLINQ()
        {
            Console.WriteLine("First or Default");

            var firstOrDefault = NumberList.numberList.LastOrDefault();

            Console.WriteLine(firstOrDefault);
        }

        public static void Pyramid()
        {
            int i, j, rows;

            Console.WriteLine("Numbri püramiid");

            Console.WriteLine("Sisesta ridade arv");

            rows = Convert.ToInt32(Console.ReadLine());


            for (i = 0; i <= rows; i++)
            {
                for (j = 1; j <= rows - i; j++)
                {
                    Console.Write(" ");
                }
                for (j = 1; j <= 2 * i - 1; j++)
                {
                    //Console.Write("{0} ", t++);
                    Console.Write("*"); //kui paned selle, siis saad püramiidi
                }
                Console.Write("\n");

                
            }
        }

        public static void IfjElse()
        {
            Console.WriteLine("Kui url on vale, siis annab" +
             "veateate. Kui on õige, siis ütleb, " +
             "et kõik on korras");
            Console.WriteLine("Kui on õige, siis loob faili " +
                "koos sinu sisestatud tekstiga");
            //kasutada if ja else

            string wrongPath = "V:/Users/Enriko/Desktop/FileToDesktop.txt";
            string wrightPath = "C:/Users/Enriko/Desktop/FileToDesktop.txt";

            Console.WriteLine("Tee valik numbriga:");
            Console.WriteLine("1 on vale url");
            Console.WriteLine("2 on õige url");
            string choose = Console.ReadLine();

            if (choose == "1")
            {
                try
                {
                    string inputText = Console.ReadLine();
                    File.WriteAllText(wrongPath, inputText);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Ei salevstanud desktopile file kuna " +
                        "seda urli ei ole");
                    Console.WriteLine(ex.Message);
                }
            }
            if (choose == "2")
            {
                string inputText = Console.ReadLine();
                File.WriteAllText(wrightPath, inputText);

                Console.WriteLine("Salvestas edukalt desktopile");
            }
        }
    }
}