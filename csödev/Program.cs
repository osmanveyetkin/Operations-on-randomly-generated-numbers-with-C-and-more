using System;

class Program
{
    static void Main()
    {
        Random randomMaker = new Random();
        int number = randomMaker.Next(1, 10001);
        Console.WriteLine("Rastgele oluşturulan sayı:" + number);
        int sum = 0;
        while (number > 0)
        {
            int digit = number % 10;
            sum += digit;
            number = number / 10;
        }
        if (sum % 2 == 0)
        {
            Console.WriteLine("Rakamları toplamı çifttir.");
        }
        else
        {
            Console.WriteLine("Rakamları toplamı tektir.");
        }
    }
}
