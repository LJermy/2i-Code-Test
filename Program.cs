using System;

namespace _2i_Code_Test
{
    class Program
    {
        static int multiplier;
        static int upperLimit;
        static int loopCount = 3;
        static void Main(string[] args)
        {
            getInputs();

            for (int i = 0; i <= loopCount-1; i++)                               //Loops 3 times calling the iterate method. Could be edited to get user input to iterate any number of times requested
            {
                iterate(i, i + 1);
            }
                
        }

        public static void getInputs()
        {
            Console.WriteLine("Enter the multiplier");                  //Gets user input for multiplier and converts it to an int
            multiplier = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the Upper Limit");
            upperLimit = Convert.ToInt32(Console.ReadLine());           //Gets user input for upperLimit and converts it to an int
        }

        public static void iterate(int offset, int modifier)
        {
            int increment = multiplier + offset;                    //Sets the number that the total will increase by each loop
            int currentValue;

            for (currentValue = increment; currentValue < upperLimit * modifier; currentValue = currentValue + increment)  //iterates starting from the calculated number and iterates through and stops before going over the upper limit
            {
                Console.WriteLine(currentValue);
            }
            Console.WriteLine(currentValue + "\n");                                       //Prints the last value of i calculated, will be equal to or over the upper limit and wont itterate again
        }
    }
}
