namespace Week3__
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Twitter();
            //Admission();
            //CheckMonth();
            CheckDigit();
        }


        // Tutorial Question 1
        /*
        static void Twitter()
        {
            Console.WriteLine("Enter a message less than 140 char: ");
            string message = Console.ReadLine();
            if (message.Length > 140)
            {
                Console.WriteLine("Message is Too Long > 140 character");
            }
            else
            {
                {
                    Console.WriteLine("Message Accepted");
                }
            }
        }
        */
        // Tutorial Queestion 2
        /*
        static void Admission()
        {
            Console.WriteLine("Enter your high school grade point average: ");
            double grade = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter your admission test score: ");
            double testScore = Convert.ToDouble(Console.ReadLine());

            bool condition1 = grade >= 3.0 && testScore >= 60;
            bool condition2 = grade < 3.0 && testScore >= 80;
            if (condition1 || condition2)
            {
                Console.WriteLine("Accept");
            }

            else
            {
                Console.WriteLine("Reject");  

            }

        }
        */

        // Tutorial Question 3
        /*
        static void CheckMonth()
        {
            Console.WriteLine("Enter your birth month");
            int birthMonth= Convert.ToInt32(Console.ReadLine());

            if (birthMonth > 12 || birthMonth < 1)
            {
                Console.WriteLine("ERROR");
            }
            else
            {
                Console.WriteLine(birthMonth + " is a valid month");
            }
        }
        */

        static void CheckDigit()
        {
            Console.WriteLine("Enter four digit");
            int digit = Convert.ToInt32(Console.ReadLine());

            if (digit % 7 == 0)
            {
                Console.WriteLine("digit is a volid number");
            }
            else
            {
                Console.WriteLine("digit is not valid number");
            }
        }
    }
}
