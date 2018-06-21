using System;
using MultiBracketValidation.Classes;

namespace MultiBracketValidation
{
    public class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine(MultiBracketValidation("()[]"));
            Console.WriteLine(MultiBracketValidation("(()){[]}[]"));
            Console.WriteLine(MultiBracketValidation("(){[Bob]}[letters]"));
            Console.WriteLine(MultiBracketValidation("()[]("));
            Console.WriteLine(MultiBracketValidation("([)]"));
            Console.WriteLine(MultiBracketValidation("({[})"));
            Console.WriteLine(MultiBracketValidation("]{[})"));

        }
        /// <summary>
        /// Method takes in a string, and will then create a stack 
        /// that accepts nodes of character value and for every open brack it will push into 
        /// the stack. If character is a closing bracket, it will check to make sure top is not empty
        /// to prevent a nullRef exception and if empty, it will return false. Else it will compare if
        /// the popped value opening brace matches the current closed brace. Return false if not. At the end of the
        /// loop it will see if the stack is empty, and if it is, returns true else returns false since that means
        /// the string is not balanced
        /// </summary>
        /// <param name="input">String of Brackets</param>
        /// <returns>True if the brackets are balanced</returns>
        public static bool MultiBracketValidation(string input)
        {
            Stack stack = new Stack(new Node(input[0]));
            for (int i = 1; i < input.Length; i++)
            {
                if (input[i] == '(' || input[i] == '[' || input[i] == '{') stack.Push(new Node(input[i]));
                if (input[i] == ')' || input[i] == ']' || input[i] == '}')
                {
                    if (stack.Peek() == null) return false;
                    Node temp = stack.Pop();
                    if (temp.Value != '(' && input[i] == ')') return false;
                    if (temp.Value != '[' && input[i] == ']') return false;
                    if (temp.Value != '[' && input[i] == ']') return false;
                }
            }
            return stack.Peek() == null ? true : false;
        }
    }
}
