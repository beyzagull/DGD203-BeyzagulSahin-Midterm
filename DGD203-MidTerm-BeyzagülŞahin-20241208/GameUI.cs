// I used artificial intelligence while creating this game

using System;

public class GameUI
{
    public static void DisplayIntro()
    {
        try
        {
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("THE INTERROGATION ROOM");
            Console.WriteLine("=====================\n");
            Console.WriteLine("You find yourself in a cold, dimly lit interrogation room.");
            Console.WriteLine("The events of the afternoon flash through your mind:");
            Console.WriteLine("What started as a dare with your friends turned into a candy store theft.");
            Console.WriteLine("Now you're facing tough questions from the police...");
            Console.WriteLine("Your choices will determine not just your fate, but your friends' as well.\n");
        }
        finally
        {
            Console.ResetColor();
        }
    }

    public static string GetPlayerName()
    {
        string name;
        do
        {
            try
            {
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.Write("Enter your name: ");
                name = Console.ReadLine()?.Trim() ?? "";
                if (string.IsNullOrWhiteSpace(name))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Please enter a valid name!");
                }
            }
            finally
            {
                Console.ResetColor();
            }
        } while (string.IsNullOrWhiteSpace(name));
        return name;
    }

    public static void DisplayClues()
    {
        try
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("IMPORTANT CLUES:");
            Console.WriteLine("===============");
            foreach (var clue in Question.Clues)
            {
                Console.WriteLine(clue);
            }
            Console.WriteLine();
        }
        finally
        {
            Console.ResetColor();
        }
    }

    public static void DisplayGameState(GameState state, int currentQuestion, int totalQuestions)
    {
        try
        {
            Console.Clear();
            DisplayClues();

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine($"Current Survival Probability: {state.SurvivalProbability:F1}%");
            Console.WriteLine("===============================\n");
            
            Console.WriteLine($"Question {currentQuestion + 1} of {totalQuestions}");
            
            int percentage = (currentQuestion * 100) / (totalQuestions - 1);
            string progressBar = "";
            
            Console.Write("Progress: [");
            for (int p = 0; p <= 100; p += 5)
            {
                progressBar += (p <= percentage) ? "■" : "□";
            }
            Console.WriteLine($"{progressBar}] {percentage}%\n");
        }
        finally
        {
            Console.ResetColor();
        }
    }

    public static void DisplayQuestion(int index)
    {
        try
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(Question.Questions[index]);
            Console.ResetColor();

            ConsoleColor[] optionColors = { ConsoleColor.Green, ConsoleColor.Blue, ConsoleColor.Red, ConsoleColor.Yellow };
            for (int j = 0; j < 4; j++)
            {
                Console.ForegroundColor = optionColors[j];
                Console.WriteLine($"{j + 1}. {Question.Options[index][j]}");
            }
            Console.ResetColor();
        }
        catch
        {
            Console.ResetColor();
        }
    }

    public static int GetPlayerChoice()
    {
        int answer;
        do
        {
            try
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write("\nYour choice (1-4): ");
                Console.ResetColor();
                
                if (!int.TryParse(Console.ReadLine(), out answer) || answer < 1 || answer > 4)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Please enter a number between 1 and 4!");
                    Console.ResetColor();
                }
            }
            catch
            {
                answer = 0;
                Console.ResetColor();
            }
        } while (answer < 1 || answer > 4);

        return answer;
    }

    public static void DisplayGameOver(GameState state)
    {
        try
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\nINTERROGATION COMPLETE");
            Console.WriteLine("=====================\n");
            Console.ResetColor();

            if (!state.BetrayedSomeone && state.SurvivalProbability >= 50)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"Congratulations, {state.PlayerName}! You've successfully protected yourself and your friends!");
                Console.WriteLine("The police don't have enough evidence to press charges.");
                Console.WriteLine($"Final Survival Probability: {state.SurvivalProbability:F1}%\n");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Game Over, {state.PlayerName}.");
                if (state.BetrayedSomeone)
                    Console.WriteLine("You betrayed your friends, and in the end, that only made things worse.");
                else
                    Console.WriteLine("Your inconsistent story led to everyone getting in trouble.");
                Console.WriteLine($"Final Survival Probability: {state.SurvivalProbability:F1}%\n");
            }
        }
        finally
        {
            Console.ResetColor();
        }
    }
}
