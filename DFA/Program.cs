////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//FileName: Program.cs
//FileType: Visual C# Source file
//Size : 26206
//Author : Nermin Kaya  G161210560
//github.com/nermiin
//Created On : 25/11/2019 01:38:39 PM
//Last Modified On : 28/11/2019 15:38:39 PM
//Description : Class for execute DFA_machine class and get input from user.
//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
using System;
using System.Collections.Generic;
using System.Linq;

namespace DFA
{
    class Program
    {
        static void Main(string[] args)
        {
            DFA_machine dFA_Machine = new DFA_machine();
            string a = "p";
            Console.WriteLine("Hi , This Deterministic Finite Automaton (DFA) is bulding depending on this regular expression : " +
                "\n ((a+b)*ab+(aa)*(bb)*)* " +
                "\n To check if your sentence accepted by this DFA machine please write  it down ");

            while (a != "e")
            {
                List<char> sentence = Console.ReadLine().ToCharArray().ToList();
               dFA_Machine.PrintResult(sentence);
                Console.WriteLine("To close press 'e' key" +
                    "\n To test another string press any key");
                a = Console.ReadLine();
            }
        }
    }
}
