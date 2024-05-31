using System.Security.Cryptography;
namespace PPS_W
{
    internal class program
    {

        static void Main()
        {
            Console.WriteLine("Welcome to weather guesser.");

            Console.WriteLine("1.Start");

            Console.WriteLine("2.Quit");
            
            var weather = "";
            var clothing = "";
            var result = "";

            replay();

           

            void randomweathergame()
            {
                Console.Clear();
                Random rnd = new Random();

                int RandomNumber = rnd.Next(1, 3);

                int CorrectAnswer = 0;

                switch (RandomNumber)
                {
                    case 1:
                        Console.WriteLine("Sun");
                        weather = "the sun is shining";

                        CorrectAnswer = 1;

                        Console.WriteLine("1.Shorts");
                        Console.WriteLine("2.Coat");
                        Console.WriteLine("3.Jacket");
                        break;
                    case 2:
                        Console.WriteLine("Snow");
                        weather = "it is snowing";

                        CorrectAnswer = 2;

                        Console.WriteLine("1.Shorts");
                        Console.WriteLine("2.Coat");
                        Console.WriteLine("3.Jacket");
                        break;
                    case 3:
                        Console.WriteLine("Rain");
                        weather = "it is raining";

                        CorrectAnswer = 3;

                        Console.WriteLine("1.Shorts");
                        Console.WriteLine("2.Coat");
                        Console.WriteLine("3.Jacket");
                        break;
                }

                var AnswerString = Console.ReadLine();
                switch (AnswerString)
                {
                    case "1":
                        clothing = "Shorts";
                        break;
                    case "2":
                        clothing = "Coat";
                        break;
                    case "3":
                        clothing = "Jacket";
                        break;
                }

                int Answer = Convert.ToInt32(AnswerString);


                if (Answer == CorrectAnswer)
                {
                    win();
                }
                else if (Answer != CorrectAnswer)
                {
                    lose();
                }

            }

            void lose()
            {
                result = "bad";
                Console.Clear();
                Console.WriteLine(weather+" outside and you wore your "+clothing+" , that was a "+result+" choice");
                Console.WriteLine("Play again?");
                Console.WriteLine("1.Yes");
                Console.WriteLine("2.No");
                replay();
            }

            void win()
            {
                result = "good";
                Console.Clear();
                Console.WriteLine(weather + " outside and you wore your " + clothing + ", that was a " + result + " choice");
                Console.WriteLine("Play again?");
                Console.WriteLine("1.Yes");
                Console.WriteLine("2.No");
                replay();
            }

            void replay()
            {
                var menu = Console.ReadLine();

                switch (menu)
                {
                    case "1":
                        randomweathergame();
                        break;
                    case "2":

                        Environment.Exit(0);

                        break;
                }
            }
        }
    }
}
