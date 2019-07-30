using System;

namespace Fortune_Teller
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Greetings!! and welcome to the Fortune Teller!! \n" + "\n" + "Type your first name");

            string fName = Console.ReadLine();


            Console.WriteLine("");
            Console.WriteLine($"Ok {fName}, Now I need your last name.");
            string lName = Console.ReadLine();


            Console.WriteLine("");
            Console.WriteLine($"{lName}, I like your  last name");
            string name = (fName + " " + lName);


            Console.WriteLine("");
            Console.WriteLine($"Alright {name}, using numbers, please type how old are you?");
            int nAge = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("");
            Console.WriteLine($"So your age is {nAge}? \n" +
                $"Wow, you're as old as a dinosaur, \n" +
                $"\n" +
                $"Using numbers, what is your birth month?\n" +
                $"(Hint, January = 1, May = 5, etc. etc.");
            int nMonth = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("");
            Console.WriteLine($"Ok, {name}, What is your favorite ROYGBIV color?\n" +
                "if you do not know what ROYGBIV is? type,\"help\"");
            string tColor = Console.ReadLine().ToLower();


            while (tColor == "help")
            {
                Console.WriteLine("ROYGBIV is the acryonm for primary colors, Red, Orange, Yellow, Green, Blue, Indigo, and Violet.");
                tColor = Console.ReadLine();
            }


            Console.WriteLine("");
            Console.WriteLine($"Your final question {name}, How many siblings do you have?");
            int nSiblings = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("");
            Console.WriteLine("Ok, I have all the information I need to read your fortune!\n");
            Console.WriteLine("\n" +
                "\n" +

                "Push Y if you would like to know your future...\n" +
                "\n" +
                "Push N if you do not care about your future...");
            string fate = Console.ReadLine();
            Console.WriteLine("\n" +"\n" +"\n" +"\n");


            int age = 0;
            float income = 0.0f;
            string siblings = "Unknown1";
            string color = "Unknown2";

            if (fate.ToLower() == "y")
            {



                if (nAge % 2 == 0)
                {
                    age = 89;
                }
                else
                {
                    age = 17;
                }



                if (nMonth <= 4)
                {
                    income = 3.52f;
                }
                else if (nMonth >= 5 || nMonth <= 8)
                {
                    income = 3131313;
                }
                else if (nMonth >= 9)
                {
                    income = 67;
                }



                switch (tColor)
                {
                    case "red":
                        color = "Ferrari";
                        break;
                    case "orange":
                        color = "Ducati";
                        break;
                    case "yellow":
                        color = "Horse";
                        break;
                    case "green":
                        color = "Porsche 356";
                        break;
                    case "blue":
                        color = "a wagon";
                        break;
                    case "indigo":
                        color = "Camel Trophy Defender";
                        break;
                    case "violet":
                        color = "a Buick?";
                        break;
                    default:
                        color = "unknown";
                        break;
                }



                if (nSiblings >= 3)
                {
                    siblings = "Your own island, probably to get away from your family";
                }

                else if (nSiblings < 0)
                {
                    siblings = "a hole in the Grand Caynon";
                }

                else
                {
                    switch (nSiblings)
                    {
                        case 0:
                            siblings = "Sedona";
                            break;
                        case 1:
                            siblings = "Madrid, Spain";
                            break;
                        case 2:
                            siblings = "Vancover, British Columbia";
                            break;
                    }
                }



                Console.WriteLine($"{name}, You will retire in {age} years, \n" +
            $"your bank account will have {income} measley dollars in it, \n" +
            $"You will have a vacation home in {siblings}, \n" +
            $"And your only form of transportation will be by {color}");

            }

            else if (fate.ToLower() == "n")

            {
                Console.WriteLine("What? Not a risk taker");
            }


            Console.WriteLine("");
            Console.WriteLine($"Thank you {name} for playing.\n" +
                $"\n" +
                $"Goodbye.");
            Console.ReadLine();



        }
    }
}
