// I used artificial intelligence while creating this game

using System;
using System.Collections.Generic;

public class GameState
{
    public double SurvivalProbability { get; set; }
    public List<string> PlayerChoices { get; set; }
    public bool BetrayedSomeone { get; set; }
    public string PlayerName { get; set; }

    public GameState()
    {
        SurvivalProbability = 100.0;
        PlayerChoices = new List<string>();
        BetrayedSomeone = false;
        PlayerName = string.Empty;
    }

    public void UpdateSurvivalProbability(int questionIndex, int answer)
    {
        switch (questionIndex)
        {
            case 0:
                if (answer == 3) { SurvivalProbability -= 20; BetrayedSomeone = true; }
                if (answer == 2) SurvivalProbability -= 15;
                if (answer == 1) SurvivalProbability -= 10;
                break;
            case 1:
                if (answer == 3) { SurvivalProbability -= 15; BetrayedSomeone = true; }
                if (answer == 1) SurvivalProbability += 5;
                break;
            case 2:
                if (answer == 2) SurvivalProbability += 10;
                if (answer == 1) SurvivalProbability += 5;
                break;
            case 3:
                if (answer == 3) { SurvivalProbability -= 20; BetrayedSomeone = true; }
                if (answer == 4) SurvivalProbability += 10;
                break;
            case 4:
                if (answer == 1) SurvivalProbability += 15;
                if (answer == 3) { SurvivalProbability -= 20; BetrayedSomeone = true; }
                break;
            case 5:
                if (answer == 3) { SurvivalProbability -= 25; BetrayedSomeone = true; }
                if (answer == 1) SurvivalProbability += 10;
                break;
            case 6:
                if (answer == 3) { SurvivalProbability -= 30; BetrayedSomeone = true; }
                if (answer == 4) SurvivalProbability += 15;
                break;
        }

        SurvivalProbability = Math.Max(0, Math.Min(100, SurvivalProbability));
    }
}
