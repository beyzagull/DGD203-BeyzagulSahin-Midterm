// I used artificial intelligence while creating this game

using System;

public class Game
{
    private GameState _state;

    public Game()
    {
        _state = new GameState();
    }

    public void Run()
    {
        GameUI.DisplayIntro();
        _state.PlayerName = GameUI.GetPlayerName();

        for (int i = 0; i < Question.Questions.Length; i++)
        {
            GameUI.DisplayGameState(_state, i, Question.Questions.Length);
            GameUI.DisplayQuestion(i);

            int answer = GameUI.GetPlayerChoice();
            _state.PlayerChoices.Add(Question.Options[i][answer - 1]);
            _state.UpdateSurvivalProbability(i, answer);
        }

        GameUI.DisplayGameOver(_state);
        GameAnalyzer.AnalyzeChoices(_state);

        Console.WriteLine("\nPress any key to exit...");
        Console.ReadKey();
    }
}
