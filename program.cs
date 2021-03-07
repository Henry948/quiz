using System;

namespace Quiz
{
    class Program
    {
        static void Main(string[] args)
        {
            // Start of the Quiz
            Console.WriteLine("Welcome to 'The Quiz'\nPress enter to begin: ");
            string entry = Console.ReadLine();

            //awaits user to press enter to run the program
            Tools.SetUpInputStream(entry);
            
            // Array to store the questions
            string[] questions = new string[] 
            {
                "VW manufactures the RS5, TRUE or FALSE?",
                "The MK6 Golf R is a 2.0L 4 wheel drive saloon, TRUE or FALSE?",
                "America is the home country of Nissan, TRUE or FALSE?",
                "Honda only manufacture cars for Asia, TRUE or FALSE?"
            };

            //array to store the set answers for the questions
            bool[] answers = new bool[] 
            {
                false, 
                false, 
                false, 
                false, 
            };

            // array to store the responses from the user
            bool[] responses = new bool[4];

            // if statement to ensure that the questions never exceed the answers
            if (questions.Length != answers.Length)
            {
                Console.WriteLine("There seems to be an error");
            }

            // Start of the functionality of the program
            int askingIndex = 0;

            // foreach question in questions the below code will run
            foreach(string question in questions)
            {
                string input;
                bool isBool;
                bool inputBool;

                Console.WriteLine(question);
                input = Console.ReadLine();

                isBool = Boolean.TryParse(input, out inputBool);

                // While the user input does not equal a boolean run the below code until the desired input is met
                while(isBool == false)
                {
                    Console.WriteLine("Please respond with 'true' or 'false'.");
                    input = Console.ReadLine();
                    isBool = Boolean.TryParse(input, out inputBool);
                }

                // store answer in responses then move onto the next question
                responses[askingIndex] = inputBool;
                askingIndex++;
            }

            // below was for testing the responses array

            // foreach(bool response in responses)
            // {
            //     Console.WriteLine(response);
            // }

            // Scoring the User
            int scoringIndex = 0;
            int score = 0;

            // for each answer in answers the below code will run
            foreach(bool answer in answers)
            {
                // This checks the user input at the current value of scoring index
                bool responseIndex = responses[scoringIndex];
                Console.WriteLine($"Input: {responseIndex} | Answer: {answer}");

                // This will check that both values are the same and add 1 to the users score
                if(responseIndex == answer)
                {
                    score++;
                }

                scoringIndex++;

            }
            
            // added a switch case to give different outputs dependent on the score
            switch(score)
            {
                case 1:
                   Console.WriteLine($"you scored {score} out of 4! Better luck next time");
                break;
                case 2:
                    Console.WriteLine($"you scored {score} out of 4! Halfway there!");
                break;
                case 3:
                    Console.WriteLine($"you scored {score} out of 4! Almost there!");
                break;
                case 4:
                    Console.WriteLine($"Congratulations you scored full marks with {score}");
                break;
                default:
                break;
            }
        }
    }
}