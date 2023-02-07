using System;

namespace kasyno
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            double odds = 0.75;
            guy player = new guy() { Cash = 100, Name = "Gracz" };
            

            Console.WriteLine("Witaj w kasynie. Prawdopodobieństwo przegranej : 0,75");
            player.WriteMyInfo();
            while (player.Cash > 0)
            {

                double value = random.NextDouble();
                Console.WriteLine("Proszę podać stawianą kwotę : ");
                string howMuch = Console.ReadLine();
                if (int.TryParse(howMuch, out int amount))
                {
                    int pot = amount * 2;
                    //Console.WriteLine(pot);
                    if (value > odds)
                    {
                        Console.WriteLine("Gratuluję, wygrałeś !");
                        player.ReceiveCash(pot);
                        player.WriteMyInfo();
                    }
                    else if (value < odds)
                    {
                        Console.WriteLine("Niestety przegrałeś, spróbuj jeszcze raz !");
                        player.Cash -= amount;
                        player.WriteMyInfo();


                    }
                }
            


            }

        }
    }
}
