using System;

namespace Quiz
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to 'The Quiz'\nPress enter to begin: ");
            string entry = Console.ReadLine();
            Tools.SetUpInputStream(entry);

            string[] questions = new string[] 
            {
                "VW manufactures the RS5, TRUE or FALSE?",
                "The MK6 Golf R is a 2.0L 4 wheel drive saloon, TRUE or FALSE?",
                "America is the home country of Nissan, TRUE or FALSE?",
                "Honda only manufacture cars for Asia, TRUE or FALSE?"
            };

            bool[] answers = new bool[] 
            {
                false, 
                false, 
                false, 
                false, 
            };

            bool[] responses = new bool[4];

            if (questions.Length != answers.Length)
            {
                Console.WriteLine("There seems to be an error");
            }

            int askingIndex = 0;

            foreach(string question in questions)
            {
                string input;
                bool isBool;
                bool inputBool;

                Console.WriteLine(question);
                input = Console.ReadLine();

                isBool = Boolean.TryParse(input, out inputBool);

                while(isBool == false)
                {
                    Console.WriteLine("Please respond with 'true' or 'false'.");
                    input = Console.ReadLine();
                    isBool = Boolean.TryParse(input, out inputBool);
                }

                responses[askingIndex] = inputBool;
                askingIndex++;
            }

            foreach(bool response in responses)
            {
                Console.WriteLine(response);
            }
        }
    }
}