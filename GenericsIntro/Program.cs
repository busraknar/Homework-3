﻿namespace GenericsIntro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyList<string> isimler = new MyList<string>();
            isimler.Add("Engin");
            Console.WriteLine(isimler.Length);
            isimler.Add("Kerem");
            Console.WriteLine(isimler.Length);

            Console.WriteLine("Hello, World!");
        }
    }
}