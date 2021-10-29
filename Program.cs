using System;

namespace trialproj
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your first name please");
            var firstName=Console.ReadLine();
            Console.WriteLine("Enter your second name please");
            var secondName=Console.ReadLine();

            var username = firstName + secondName;
            Console.WriteLine("Your name is:"+username );

            Console.WriteLine("Area of residency");
            var area=Console.ReadLine();
            Console.WriteLine("Your area of residency is:"+area);
            Console.WriteLine("KISII IS YOUR COUNTY");
            Console.WriteLine("KENYA IS YOUR COUNTRY");

            Console.WriteLine("Enter your age please");
            var age=Console.ReadLine();
            Console.WriteLine("Your age is:"+age);

            var newage = int.Parse(age);

            if(newage<=18)
            {
                Console.WriteLine("Not eligible to vote in the system");
            }
            else
            {
                Console.WriteLine("Congratulations! you are now eligible to secure a voter card in our system, now you can go for a registration form");
            }

            Console.WriteLine("Would you like to manipulate a sum of your choice(YES/NO)");
            var accept = Console.ReadLine();

            if (accept =="yes")
            {
                Console.WriteLine("Keenly follow the steps ahead");
            }
            if(accept=="no")
            {
                Console.WriteLine("Thank you for choosing our sytem");
            }

            Console.WriteLine("Enter the first number you would wish to manipulate");
            var firstnumber=Console.ReadLine();
            Console.WriteLine("Enter the second number please");
            var secondnumber=Console.ReadLine();
            Console.WriteLine("Enter an operator please(/, +, *, -)");
            var sign=Console.ReadLine();    

            var firstNum=int.Parse(firstnumber);
            var secondNum=int.Parse(secondnumber);  

            if(sign == "/")
            {
                Console.WriteLine(firstNum/secondNum);
            }
            if(sign == "+")
            {
                Console.WriteLine(firstNum+secondNum);
            }
            if (sign == "-")
            {
                Console.WriteLine(secondNum-firstNum);
            }
            if (sign == "*")
            {
                Console.WriteLine(secondNum*firstNum);
            }
            int day = 5;
            switch (day)
            {
                case 1:
                        Console.WriteLine(  "Monday");
                    break;  
                    case 2:
                    Console.WriteLine("Tuesday");
                    break;  
                    case 3:
                    Console.WriteLine("Wednesday");
                    break;
                    case 4:
                    Console.WriteLine("Thursaday");
                    break;
                    case 5:
                    Console.WriteLine("Friday");
                    break;
                    case 6:
                    Console.WriteLine("Saturday");
                    break;
                    case 7:
                    Console.WriteLine("Sunday");
                    break;  
                        }

        }
    }
}
