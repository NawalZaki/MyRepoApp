using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApp
{
    class Program
    {
        static void Print()
        {
            Console.WriteLine("My Fun From Local");
        }
        static int sum(int x, int y)
        {
            return x+y;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome With GitHupb From Console APP");
            Console.WriteLine("Hi From Remote Repo");
            int x = 3;
            string UserInput= Console.ReadLine();
            Console.WriteLine(UserInput + x);
            //From Repo
            //From Local

            Console.ReadLine();
        }
    }
}
