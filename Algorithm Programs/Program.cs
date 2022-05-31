using System;

namespace Algorithm_Programs
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Algorithm Programs");
            Console.WriteLine("Enter String to find Permutation ");
            string obj = Console.ReadLine();
            int n = obj.Length;
            Permutation.Permute(obj, 0, n - 1);
        }
    }
}

