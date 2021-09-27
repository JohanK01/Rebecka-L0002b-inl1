using System;
//Ange pris
//Ange betalt
//Vilka sedlar: 500 100 50 20. mynt: 10 5 1.
//Hur många av vad också
namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            {
                //Rebecka Klausen, rebkla-1, L0002B
                // Här frågar jag efter input: pris på vara/varor (price) och hur mycket kunden har betalat (payment//
                Console.Write("Ange pris: ");
                int price = int.Parse(Console.ReadLine());
                Console.Write("Hur mycket kunden har betalat: ");
                int payment = int.Parse(Console.ReadLine());

                // Här räknar jag ut vad differensen blir när kunden har betalat
                int diff = (payment - price);

                //Här avänder jag mig av if-statement för att ta reda på om kunden har betalat in för mycket, för lite eller betalat jämt ut.
                if (diff > 0)
                {
                    Console.WriteLine("Kunden får tillbaka " + diff + " kronor");
                    Console.WriteLine("Växel tillbaka sedlar: ");
                    Console.WriteLine("500-lappar: " + ((diff - diff % 500) / 500));
                    diff = diff % 500;
                    Console.WriteLine("100-lappar: " + ((diff - diff % 100) / 100));
                    diff = diff % 100;
                    Console.WriteLine("50-lappar: " + ((diff - diff % 50) / 50));
                    diff = diff % 50;
                    Console.WriteLine("20-lappar: " + ((diff - diff % 20) / 20));
                    diff = diff % 20;
                    Console.WriteLine("Växel tillbaka mynt: ");
                    Console.WriteLine("10-kronor: " + ((diff - diff % 10) / 10));
                    diff = diff % 10;
                    Console.WriteLine("5-kronor: " + ((diff - diff % 5) / 5));
                    diff = diff % 5;
                    Console.WriteLine("2-kronor: " + ((diff - diff % 2) / 2));
                    diff = diff % 2;
                    Console.WriteLine("1-kronor: " + ((diff - diff % 1) / 1));
                    diff = diff % 1;
                    _ = Console.ReadLine();
                }
                else if (diff == 0)
                {
                    Console.WriteLine("Toppen, du har betalat med jämna pengar");
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine($"Tyvärr räcker pengarna inte till, du saknar {diff} kronor");
                    Console.ReadLine();
                }
            }
        }
    }
}
