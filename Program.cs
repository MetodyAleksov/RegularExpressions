using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace RegularExpressions
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            string pattern = @"\b[A-Z][a-z]+ [A-Z][a-z]+";
            Regex regex = new Regex(pattern);
            var names = regex.Matches(text);

            Console.WriteLine(string.Join(" ", names));
        }
    }
}
