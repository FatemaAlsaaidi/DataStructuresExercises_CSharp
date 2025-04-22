namespace StakQueueFilesTasks
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter the number of task :");
            Console.WriteLine("1. Reverse a String Using Stack");

            int Choice = int.Parse(Console.ReadLine());
            switch (Choice)
            {
                case 1:
                    Console.WriteLine("Enter any word :");
                    string InputWord = Console.ReadLine();
                    ReverseAString(InputWord);
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
    }
}
