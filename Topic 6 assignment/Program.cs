namespace Topic_6_assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            //Raine DeVries
            int number;
            int highNumber, lowNumber;
            int rightNumber;
            Random random = new Random();
            Console.WriteLine("What's the lowest number?");
            lowNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("What's the highest number?");
            highNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The number are "+lowNumber+ " "+ highNumber );    
            Console.WriteLine(random.Next(lowNumber, highNumber));

            rightNumber = random.Next(1, 11);
            Console.WriteLine("Guess a number between 1-10");
            int.TryParse(Console.ReadLine(), out number);
            if (number == rightNumber)
            {
                Console.WriteLine("Your right!");
            }
            else { Console.WriteLine("Nope That's not right"); }


            Console.WriteLine("I will roll 2 die, here's the output:");
            Console.WriteLine(random.Next(1, 7)+random.Next(1, 7));



        }
    }
}
