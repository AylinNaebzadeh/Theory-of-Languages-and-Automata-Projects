using System;
using System.Collections.Generic;
using System.Linq;

namespace P1_Q2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
                The second part is to convert the NFA to DFA
            */
            var states = Console.ReadLine().Split(',', '{', '}').Where(x => !string.IsNullOrWhiteSpace(x)).ToList();
            var sigma = Console.ReadLine().Split(',', '{', '}').Where(x => !string.IsNullOrWhiteSpace(x)).Select(item =>  char.Parse(item)).ToList();
            var final = Console.ReadLine().Split(',', '{', '}').Where(x => !string.IsNullOrWhiteSpace(x)).ToList();
            long numberOfTransitions = Convert.ToInt64(Console.ReadLine());
            

        }
    }
}