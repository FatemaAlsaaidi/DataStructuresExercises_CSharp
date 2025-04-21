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
        public static string ReverseAString(string word)
        {
            
            


        }
    }
}
