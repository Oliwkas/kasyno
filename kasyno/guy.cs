using System;
using System.Collections.Generic;
using System.Text;

namespace kasyno
{
    internal class guy
    {
        public string Name;
        public int Cash;

        /// <summary>
        /// metoda opisuje ile hajsu ma jaki ziomek
        /// </summary>
        public void WriteMyInfo()
        {
            Console.WriteLine(Name +" ma " + Cash + " zł.");
        }
        /// <summary>
        /// przekazuje hajs i usuwa go z portfela V pokazuje info o braku środków
        /// </summary>
        /// <param name="amount"> Przekazywana kwota do typka</param>
        /// <returns>Ilość pieniędzy wyjmowanych z portfela lub 0, jeśli dostępnę środki są za małe lub parametr amount jest nieprawidłowy</returns>
        public int GiveCash(int amount)
        {
            if (amount <= 0)
            {
                Console.WriteLine(Name + " mówi: " + amount + " nie jest poprawną kwotą.");
                return 0;
            }
            if (amount > Cash)
            {
                Console.WriteLine(Name + " mówi: " + " nie mam wystarczających środków, aby dać ci " + amount + " zł.");
                return 0;
            }
            
            Cash -= amount;
            return amount;
        }
        public void ReceiveCash(int amount)
        {
            if(amount <= 0)
            {
                Console.WriteLine(Name +" mówi: "+  "nie przyjmę " + amount + " zł.");
            }
            else
            {
                Cash += amount;
            }
        }
    }
}
