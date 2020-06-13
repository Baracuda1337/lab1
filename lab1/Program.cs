using System;

namespace lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = 3680;
            var hours = n / 3600;
            var minutes = (n - (hours * 3600)) / 60;
            var seconds = n % 60;

            Console.WriteLine( "З початку доби пройшло " +
            $"{hours} годин {minutes} хвилин {seconds} секунд")
               ;
        }
    }
}   