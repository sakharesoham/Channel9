using System;

namespace IfElseBob
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello !! Enter your choice");
            Console.WriteLine("1,2 or 3");

            string uservalue = Console.ReadLine();
            string message = "";

            if(uservalue=="1")
            {
                message = "You won a car!";
                Console.WriteLine(message);
            }
            else if(uservalue=="2")
            {
                message = "You won a bike!!";
                Console.WriteLine(message);
            }
            else if(uservalue=="3")
            {
                message = "You won a bicycle";
                Console.WriteLine(message);
            }
            else 
            {
                message = "Sorry,Please enter from the given choices";
                message += "\n You lose";
                Console.WriteLine(message);
                
            }
            Console.ReadLine();
        }
    }
}
