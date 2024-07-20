using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LNCode.StackDemo
{
    internal class MyStack
    {
        public static bool IsValid(string s)
        {
            Stack<char> stack = new Stack<char>();

            foreach (char c in s)
            {
                if (c == '[')
                {
                    stack.Push(']');

                }
                else if (c == '{')
                {
                    stack.Push('}');

                }
                else if (c == '(')
                {
                    stack.Push(')');

                }

                else if (stack.Count ==0 || c != stack.Pop()) {
                    return false;
                }

            }
            if (s.Length == 1) return false;
            return stack.Count==0;

        }
    }
}
