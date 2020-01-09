////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//FileName: DFA_machine.cs
//FileType: Visual C# Source file
//Size : 26206
//Author : Nermin Kaya  
//github.com/nermiin
//Created On : 25/11/2019 01:38:39 PM
//Last Modified On : 28/11/2019 15:38:39 PM
//Description : Class for defining DFA (Deterministic Finite Automaton ) for specific regex 
//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
using System;
using System.Collections.Generic;
using System.Text;

namespace DFA
{
    class DFA_machine
    {
        private int DFA_Control(List<char> sentence, int state)
        {
            foreach (char k in sentence)
            {
                switch (state)
                {
                    case 1:
                        if (k.Equals('a'))
                        {
                            state = 2;
                        }
                        else if (k.Equals('b'))
                        {
                            state = 3;
                        }
                        break;

                    case 2:
                        if (k.Equals('a'))
                        {
                            state = 4;
                        }
                        else if (k.Equals('b'))
                        {
                            state = 1;
                        }
                        break;

                    case 3:
                        if (k.Equals('a'))
                        {
                            state = 3;
                        }
                        else if (k.Equals('b'))
                        {
                            state = 1;
                        }
                        break;

                    case 4:
                        if (k.Equals('a'))
                        {
                            state = 2;
                        }
                        else if (k.Equals('b'))
                        {
                            state = 4;
                        }
                        break;
                    default:
                        state = 1;
                        break;
                }
            }

            return state;
        }

        private bool Check_if_invalid_input(List<char> sentence)
        {
            bool t = false;
            if (!sentence.Contains('a'))
            {
                if (!sentence.Contains('b'))
                {
                    t = true;
                }
            }
            else if (!sentence.Contains('b'))
            {
                if (!sentence.Contains('a'))
                {
                    t = true;
                }
            }
            return t;
        }

        private bool Check_if_Accepted(List<char> sentence)
        {
            bool is_accepted = true;

            int Fstate = DFA_Control(sentence, 1);

            if ((Fstate.Equals(1) || Fstate.Equals(4)))
            {
                is_accepted = true;
            }
            else
            {
                is_accepted = false;
            }
            return is_accepted;
        }

        public void PrintResult(List<char> sentence)
        {
            bool is_accepted = Check_if_Accepted(sentence);
            bool is_invalid_input = Check_if_invalid_input(sentence);
            if (is_invalid_input.Equals(true))
            {
                Console.WriteLine(" invalid_input !!");
            }
            else
            {
                if (is_accepted.Equals(true))
                {
                    Console.WriteLine(" Accepted !!");
                }
                else
                {
                    Console.WriteLine(" Not accepted !");
                }
            }
        }
    }
}
