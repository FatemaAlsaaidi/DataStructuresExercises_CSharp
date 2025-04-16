namespace List
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Console.WriteLine("Select Exercises: ");
            Console.WriteLine("1.Top N Frequent Numbers");

            int Choice = int.Parse(Console.ReadLine());


            while (true)
            {
                switch (Choice)
                {
                    case 1:
                        TopNFrequentNumbers();
                        break;
                }
            }
        }

        public static void TopNFrequentNumbers()
        {
            int value = 0;
            int N = 0;
            List<int> numbers = new List<int>();
            List<int> UniquNum = new List<int>();
            List<int> NumCount = new List<int>();
            bool AddMore = true;
            char choice = 'y';

            // ask user to enter the number
            do
            {
                Console.Write("Enter the number: ");
                int num = int.Parse(Console.ReadLine());
                numbers.Add(num);

                Console.Write("Do you want to add more number (y/n): ");
                choice = Console.ReadKey().KeyChar;
                Console.WriteLine();

                AddMore = (choice == 'y' || choice == 'Y');

            } while (AddMore);

            Console.Write("Enter the N which decides the Top N Frequent Numbers: ");
            N = int.Parse(Console.ReadLine());

            // create list copy for origenal list
            List<int> tempNumbers = new List<int>(numbers);
            // count the frequency number
            while (tempNumbers.Count > 0)
            {
                value = tempNumbers[0];
                int count = 0;

                // count how many time the number is apear
                for (int i = 0; i < tempNumbers.Count; i++)
                {
                    if (tempNumbers[i] == value)
                    {
                        count++;
                    }
                }

                // save the unique number with the count of that 
                UniquNum.Add(value);
                NumCount.Add(count);

                // delete the frequence number
                for (int i = tempNumbers.Count - 1; i >= 0; i--)
                {
                    if (tempNumbers[i] == value)
                    {
                        tempNumbers.RemoveAt(i);
                    }
                }
            }

            // order base on the number of count
            for (int i = 0; i < NumCount.Count - 1; i++)
            {
                for (int j = 0; j < NumCount.Count - i - 1; j++)
                {
                    if (NumCount[j] < NumCount[j + 1])
                    {
                        //swap
                        int tempCount = NumCount[j];
                        NumCount[j] = NumCount[j + 1];
                        NumCount[j + 1] = tempCount;

                        // swap
                        int tempNum = UniquNum[j];
                        UniquNum[j] = UniquNum[j + 1];
                        UniquNum[j + 1] = tempNum;
                    }
                }
            }

            Console.WriteLine($"\nTop {N} Frequent Numbers:");
            for (int i = 0; i < N && i < UniquNum.Count; i++)
            {
                Console.WriteLine($"{UniquNum[i]} => {NumCount[i]} times");
            }
        }


    }
}
