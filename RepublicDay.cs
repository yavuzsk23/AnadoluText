using System;

class Program
{
    static void Main()
    {
        DateTime republicDay = new DateTime(2026, 10, 29);
        TimeSpan difference = republicDay - DateTime.Now;

        Console.WriteLine("Days until October 29 " + difference.Days);
    }   Console.WriteLine("Ne Mutlu Türküm diyene!! 🇹🇷 🇹🇷 ");
}
