using System;
using System.Collections.Generic;
using System.Linq;

namespace CowProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> initial = new List<int>() { 1, 0, 0 };
            for (int i = 0; i < 50; i++)
            {
                var s = 0;
                for (int j = 0; j < initial.Count; j++)
                    if (j <= initial.Count - 3)
                        s += initial[j];
                initial.Add(s);
            }
            var sum = 0;
            for (int i = 0; i < initial.Count; i++)
            {
                Console.WriteLine($"第{i + 1}年有{sum = sum + initial[i]}头");
            }
            Console.ReadLine();
        }
    }
}
