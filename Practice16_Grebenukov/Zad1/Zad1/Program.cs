using System;
using System.IO;
using System.Linq;

namespace Zad1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader("text.txt");
            string text  = sr.ReadToEnd();
            text = text.ToLower();
            Console.WriteLine("Введите слово которое хотите ввести");
            while (true)
            {
                string word = Console.ReadLine();
                if (word.All(c => char.IsLetter(c)))
                {
                    text = new string(text.Where(c => !char.IsPunctuation(c)).ToArray());
                    int count = text.Split(' ').Where(w => w.ToLower() == word).Count();
                    Console.WriteLine($"Были найдены {count} вхождения(ий) поискового запроса '{word}'");
                    break;
                }
                else
                {
                    Console.WriteLine("Ошибка!Введите слово!");
                }
            }


        }
    }
}
