using System;
using System.Collections.Generic;
using System.Linq;

namespace Zadanie_kollekcii
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите строку, затем нажмите Enter");
            string str = Console.ReadLine();
            str.ToCharArray();
            Stack<char> stack = new Stack<char>();
            foreach (char i in str)
            {
                if (i == '(')
                {
                    stack.Push(')');
                }
                if (i == '{')
                {
                    stack.Push('}');
                }
                if (i == '[')
                {
                    stack.Push(']');
                }
                if (i == ')'|| i == '}' || i == ']')
                {
                    if (stack.Count != 0)
                    {
                        if (stack.Peek() == i)
                        {
                            stack.Pop();
                        }
                    }
                    else
                    {
                        stack.Push(i);
                    }
                }
            }
            if (stack.Count == 0)
            {
                Console.WriteLine("В строке скобки расставлены корректно");
            }
            else
            {
                Console.WriteLine("В строке скобки расставлены некорректно");
            }

        }
    }
}