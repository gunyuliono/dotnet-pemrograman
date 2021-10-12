using System;

namespace Tugas
{
    class Program
    {
        static void Main(string[] args)
        {
            StringsinC.StringC();
            searchString.cariString();
            NumberinC.NumberC1();
            NumberinC.NumberC2();
            Precision.Precision1();
            DoubleType.DoubleType1();
            DoubleType.DoubleType2();

        }
    }

    class NumberinC
    {
        public static void NumberC1()
        {
            int a = 18;
            int b = 6;
            int c = a + b;
            Console.WriteLine("\nIni Bagian Number C #1");
            Console.WriteLine(c);
        }
        public static void NumberC2()
        {
            Console.WriteLine("\nIni Bagian Number C #2");
            int a = 5;
            int b = 4;
            int c = 2;
            int d = (a + b) - 6 * c + (12 * 4) / 3 + 12;
            Console.WriteLine(d);
        }
    }

    class StringsinC
    {
        public static void StringC()
        {
            Console.WriteLine("\nIni Bagian String C");
            string firstFriend = "Maria";
            string secondFriend = "Sage";
            string aFriend = "GUN";
            Console.WriteLine(aFriend);
            Console.WriteLine("Hello " + firstFriend);
            Console.WriteLine($"My Friends are {firstFriend} and {secondFriend}");
            Console.WriteLine($"Hello {aFriend}");
            Console.WriteLine($"The name {firstFriend} has {firstFriend.Length} letters");
            Console.WriteLine($"The name {secondFriend} has {secondFriend.Length} letters"
            );
        }
    }

    class searchString
    {
        public static void cariString()
        {
            Console.WriteLine("\nIni Bagian Search String");
            string songLyrics = "You say goodbye, and I say hello";
            Console.WriteLine(songLyrics.Contains("goodbye"));
            Console.WriteLine(songLyrics.Contains("greetings"));
            Console.WriteLine(songLyrics.EndsWith("hello"));
        }
    }

    class Precision
    {
        public static void Precision1()
        {
            Console.WriteLine("\nIni Bagian Search Precision1");
            int a = 7;
            int b = 4;
            int c = 3;
            int d = (a + b) / c;
            int e = (a + b) % c;
            Console.WriteLine($"quotient: {d}");
            Console.WriteLine($"remainder: {e}");

        }
    }

    class DoubleType
    {
        public static void DoubleType1()
        {
            Console.WriteLine("\nIni Bagian Search DoubleType1");
            double a = 5;
            double b = 4;
            double c = 2;
            double d = (a + b) / c;
            Console.WriteLine(d);
        }
        public static void DoubleType2()
        {
            Console.WriteLine("\nIni Bagian Search DoubleType2");
            double a = 19;
            double b = 23;
            double c = 8;
            double d = (a + b) / c;
            Console.WriteLine(d);
        }
    }



}
