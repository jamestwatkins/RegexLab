using System;
using System.Text.RegularExpressions;


namespace RegExLab
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {

                string name = GetName("Please enter your name:\n");

                string email = GetEmail($"Thank you {name}, now please enter your email:\n");


                string phoneNumber = GetNumber($"So, {name}, can I have your number?\n");

                string date = GetDate($"Now, {name}, enter a date:\n");


                string element = GetHtml($"Last but not least, {name}, give me an HTML element:\n");


                Console.WriteLine("Here's your info:\n");

                Console.WriteLine($"Name: {name}\n");

                Console.WriteLine($"Email: {email}\n");

                Console.WriteLine($"Phone Number: {phoneNumber}\n");

                Console.WriteLine($"Date: {date}\n");

                Console.WriteLine($"HTML element: {element}\n");

                Console.WriteLine("y to continue:");

                string repeat = Console.ReadLine();

                if(repeat == "y")
                {
                    continue;
                }
                else
                {
                    break;
                }
            }
        }


        public static string GetName(string message)
        {
            while (true)
            {

                Console.WriteLine(message);

                string input = Console.ReadLine();



                bool isName = Regex.IsMatch(input, "(\\b[A-Z][a-z]{0,29})");

                if (isName)
                {
                    return input;

                }
                else
                {
                    Console.WriteLine("That's not a valid name!");
                    continue;
                }

            }

        }

        public static string GetEmail(string message)
        {

            while (true) {

                Console.WriteLine(message);

                string input = Console.ReadLine();

                bool isEmail = Regex.IsMatch(input, "(\\b([A-Za-z0-9]{5,30}@[A-Za-z0-9]{5,30}.[A-Za-z]{2,3}))");

                if (isEmail)
                {
                    return input;
                }
                else
                {
                    Console.WriteLine("That's not a valid email!");
    
                    continue;
                }
            }



        }

        public static string GetNumber(string message)
        {
            while (true)
            {

                Console.WriteLine(message);

                string input = Console.ReadLine();

                bool isNum = Regex.IsMatch(input, "(\\b([0-9]{3}-[0-9]{3}-[0-9]{4}))");

                if (isNum)
                {
                    return input;
                }
                else
                {
                    Console.WriteLine("That's not a valid phone number!");

                    continue;
                }
            }
        }

        public static string GetDate(string message)
        {
            while (true)
            {

                Console.WriteLine(message);

                string input = Console.ReadLine();

                bool isDate = Regex.IsMatch(input, "(\\b(([0-2][0-9]|3[01])[/](0[1-9]|1[0-2])[/]([0-9]{4})))");


                if (isDate)
                {
                    return input;
                }
                else
                {
                    Console.WriteLine("That's not a valid date!");

                    continue;
                }

            }

        }

        public static string GetHtml(string message)
        {
            while (true)
            {

                Console.WriteLine(message);

                string input = Console.ReadLine();

                bool isHtml = Regex.IsMatch(input, "(([<]([a-z][a-z0-9]*)[>]).*([<][/](\\3)+[>]))");


                if (isHtml)
                {
                    return input;
                }
                else
                {
                    Console.WriteLine("That's not a HTML element!!");

                    continue;
                }

            }



        }


    }
}
