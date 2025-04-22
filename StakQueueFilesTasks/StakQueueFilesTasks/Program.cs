using System.Diagnostics.Metrics;

namespace StakQueueFilesTasks
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Stak Queue Files Tasks");
            Console.WriteLine("1. Reverse a String Using Stack");
            Console.WriteLine("2. Evaluate Postfix Expression");
            Console.WriteLine("Enter the number of task :");

            int Choice = int.Parse(Console.ReadLine());
            switch (Choice)
            {
                case 1:
                    Console.WriteLine("Enter any word :");
                    string InputWord = Console.ReadLine();
                    ReverseAString(InputWord);
                    Console.ReadLine();
                    break;
                case 2:
                    Console.WriteLine("the formula");
                    string formula = Console.ReadLine();
                    EvaluatePostfixExpression(formula);
                    Console.ReadLine();
                    break;
            }

        }

        // ************************************* Stack *****************************************
        // =====================================  Easy =========================================
        //1. Reverse a String Using Stack 
        public static void ReverseAString(string word)
        {
            Stack<char> letter = new Stack<char>(); // Stack of letter 
            //char[] letter1 = new char[word.Length];
            foreach (char let in word)
            {
                letter.Push(let);
            }
            foreach (char let2 in letter)
            {
                Console.Write(let2);
            }
        }
        //2. Evaluate Postfix Expression 
        public static double EvaluatePostfixExpression(string formula)
        {
            bool isdigit = true;
            int num;
            double res;
            char op;
            Stack<char> bit = new Stack<char>(); // Stack of letter 
            foreach (char a in formula)
            {
                bit.Push(a);
            }

            foreach (char a in bit)
            {
                
                char Top_a = bit.Pop();

                if (Char.IsDigit(Top_a))
                {
                    isdigit = true;
                }
                else
                {
                    isdigit = false;
                }
                if (isdigit)
                {
                    num= (int)char.GetNumericValue(Top_a);
                }
                else
                {
                    op = Top_a;
                    switch (op)
                    {
                        case '*':
                            num = 1;
                            res = num * num;
                            break;
                        case '-':

                            res = res - num;
                            break;
                    }
                }
            }

            
        }
    }
}
