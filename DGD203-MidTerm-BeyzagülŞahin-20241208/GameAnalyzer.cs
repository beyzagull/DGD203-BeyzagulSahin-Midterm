// I used artificial intelligence while creating this game

using System;

public class GameAnalyzer
{
    public static void AnalyzeChoices(GameState state)
    {
        Console.ForegroundColor = ConsoleColor.DarkYellow;
        Console.WriteLine("CHOICE ANALYSIS:");
        Console.WriteLine("===============");
        Console.ResetColor();

        for (int i = 0; i < state.PlayerChoices.Count; i++)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write($"Question {i + 1}: ");
            
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine(state.PlayerChoices[i]);
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.Yellow;
            AnalyzeChoice(i, state.PlayerChoices[i]);
            Console.WriteLine();
        }
    }

    private static void AnalyzeChoice(int questionIndex, string choice)
    {
        var random = new Random();
        string[] analyses;

        switch (questionIndex)
        {
            case 0:
                if (choice.Contains("basketball practice"))
                    analyses = new[] {
                        "Analysis: Your basketball alibi creates a timeline conflict - a critical error in your defense.",
                        "Analysis: Claiming to be at practice shows confidence, but the timestamps tell a different story.",
                        "Analysis: The basketball practice excuse might have worked, if not for the precise timing evidence.",
                        "Analysis: An ambitious attempt to establish an alibi, but it contradicts multiple witness statements."
                    };
                else if (choice.Contains("lawyer"))
                    analyses = new[] {
                        "Analysis: Early legal caution suggests prior experience with interrogations.",
                        "Analysis: Requesting a lawyer immediately raised eyebrows - why so defensive so soon?",
                        "Analysis: A legally smart move, but it may have made you appear more suspicious.",
                        "Analysis: Your quick legal defense suggests you anticipated this conversation."
                    };
                else if (choice.Contains("Sarah"))
                    analyses = new[] {
                        "Analysis: Deflecting to Sarah this early showed signs of panic under pressure.",
                        "Analysis: Your quick mention of Sarah suggests a prepared narrative.",
                        "Analysis: Bringing up Sarah's name unprompted revealed your nervous state.",
                        "Analysis: An attempt to shift focus that may have inadvertently implicated your friend."
                    };
                else
                    analyses = new[] {
                        "Analysis: Your vague response failed to address the specific time gap in question.",
                        "Analysis: Keeping it general might work in normal conversation, but not with these specifics.",
                        "Analysis: The casual browsing excuse doesn't explain the suspicious timing.",
                        "Analysis: A non-committal response that raised more questions than it answered."
                    };
                break;

            case 1:
                if (choice.Contains("similar bracelets"))
                    analyses = new[] {
                        "Analysis: Attempting to generalize unique evidence shows quick thinking, but lacks credibility.",
                        "Analysis: The butterfly charm detail makes your generalization less convincing.",
                        "Analysis: A clever deflection, but it doesn't explain the specific design match.",
                        "Analysis: Your attempt to minimize the bracelet's uniqueness contradicts school records."
                    };
                else if (choice.Contains("don't feel comfortable"))
                    analyses = new[] {
                        "Analysis: Your diplomatic refusal suggests experience with careful conversation.",
                        "Analysis: Taking the moral high ground about speculation shows composure.",
                        "Analysis: A professional response that neither confirms nor denies involvement.",
                        "Analysis: Your careful wording maintains loyalty while protecting yourself."
                    };
                else if (choice.Contains("yesterday"))
                    analyses = new[] {
                        "Analysis: The timeline you suggested conflicts with the teacher's statement.",
                        "Analysis: Creating an alternative timeline is risky when witnesses are involved.",
                        "Analysis: Your story about yesterday doesn't align with today's evidence.",
                        "Analysis: A bold attempt to reframe the timeline that backfired."
                    };
                else
                    analyses = new[] {
                        "Analysis: Your noncommittal response seems evasive given the specific evidence.",
                        "Analysis: Avoiding direct answers about the bracelet suggests hidden knowledge.",
                        "Analysis: The vague response contrasts with the detailed nature of the evidence.",
                        "Analysis: Your cautious approach might be interpreted as concealing information."
                    };
                break;

            case 2:
                if (choice.Contains("Mike"))
                    analyses = new[] {
                        "Analysis: Mentioning Mike without prompting suggests premeditated blame shifting.",
                        "Analysis: Your quick reference to Mike's habits seems suspiciously detailed.",
                        "Analysis: Bringing Mike into the conversation reveals internal group tensions.",
                        "Analysis: The specific detail about Mike's behavior appears too convenient."
                    };
                else if (choice.Contains("don't know"))
                    analyses = new[] {
                        "Analysis: Claiming ignorance about such a specific piece of evidence seems calculated.",
                        "Analysis: Your complete denial appears rehearsed given the evidence specifics.",
                        "Analysis: The choice to plead ignorance might work against your credibility.",
                        "Analysis: Total denial of knowledge conflicts with other known facts."
                    };
                else if (choice.Contains("public store"))
                    analyses = new[] {
                        "Analysis: Your logical approach to the receipt shows strategic thinking.",
                        "Analysis: Using common sense to explain evidence demonstrates confidence.",
                        "Analysis: A reasonable explanation that still doesn't address the torn condition.",
                        "Analysis: Your rational response provides plausible deniability."
                    };
                else
                    analyses = new[] {
                        "Analysis: Your measured response about the receipt maintains ambiguity.",
                        "Analysis: Staying neutral about the evidence shows calculated restraint.",
                        "Analysis: The balanced answer preserves multiple possible explanations.",
                        "Analysis: Your careful handling of the receipt question shows forethought."
                    };
                break;

            case 3:
                if (choice.Contains("Mike wasn't"))
                    analyses = new[] {
                        "Analysis: The alibi for Mike contradicts existing evidence.",
                        "Analysis: Your defense of Mike seems rehearsed and potentially false.",
                        "Analysis: Creating an alibi for Mike raises suspicion about coordination.",
                        "Analysis: The quick defense of Mike suggests prior planning."
                    };
                else if (choice.Contains("pit us"))
                    analyses = new[] {
                        "Analysis: Challenging interrogation tactics shows psychological awareness.",
                        "Analysis: Your defensive response indicates group loyalty.",
                        "Analysis: Questioning police methods reveals strategic thinking.",
                        "Analysis: The confrontational approach might be seen as deflection."
                    };
                else if (choice.Contains("belongs to Mike"))
                    analyses = new[] {
                        "Analysis: Your willingness to implicate Mike reveals cracks under pressure.",
                        "Analysis: Sacrificing Mike's trust might have long-term consequences.",
                        "Analysis: The specific accusation against Mike seems opportunistic.",
                        "Analysis: Your betrayal of Mike suggests a calculated decision under pressure."
                    };
                else
                    analyses = new[] {
                        "Analysis: Maintaining neutrality about Mike shows group solidarity.",
                        "Analysis: Your careful response protects both yourself and others.",
                        "Analysis: Avoiding speculation about Mike's behavior shows loyalty.",
                        "Analysis: The diplomatic approach maintains group trust."
                    };
                break;

            case 4:
                if (choice.Contains("unreliable"))
                    analyses = new[] {
                        "Analysis: Knowledge of security systems suggests prior planning.",
                        "Analysis: Your technical insight raises questions about preparation.",
                        "Analysis: Specific knowledge about security could imply premeditation.",
                        "Analysis: The detailed response about system reliability seems suspicious."
                    };
                else if (choice.Contains("basketball game"))
                    analyses = new[] {
                        "Analysis: The basketball excuse conflicts with your earlier timeline.",
                        "Analysis: Returning to the sports alibi shows consistency but lacks credibility.",
                        "Analysis: Your commitment to the basketball story might be your undoing.",
                        "Analysis: Maintaining the sports narrative despite contradictions is risky."
                    };
                else if (choice.Contains("Sarah"))
                    analyses = new[] {
                        "Analysis: Continuing to implicate Sarah shows a pattern of deflection.",
                        "Analysis: Your persistent focus on Sarah's role seems calculated.",
                        "Analysis: Attributing technical knowledge to Sarah raises new questions.",
                        "Analysis: The attempt to shift technical details to Sarah lacks credibility."
                    };
                else
                    analyses = new[] {
                        "Analysis: Memory gaps about specific conversations seem convenient.",
                        "Analysis: Your selective memory about timing discussions is noteworthy.",
                        "Analysis: Claiming no recall conflicts with detailed witness statements.",
                        "Analysis: The memory lapse defense weakens your overall credibility."
                    };
                break;

            case 5:
                if (choice.Contains("similar bracelets"))
                    analyses = new[] {
                        "Analysis: Reusing the similarity argument weakens your overall defense.",
                        "Analysis: Your repeated bracelet explanation loses impact with each use.",
                        "Analysis: Sticking to the same defense suggests limited options.",
                        "Analysis: The recycled explanation about bracelets shows desperation."
                    };
                else if (choice.Contains("school records"))
                    analyses = new[] {
                        "Analysis: Invoking official records is either very brave or very foolish.",
                        "Analysis: Your confidence in school documentation could be double-edged.",
                        "Analysis: Suggesting record verification shows either truth or bluff.",
                        "Analysis: The bold move to reference records indicates strategic thinking."
                    };
                else if (choice.Contains("definitely Sarah's"))
                    analyses = new[] {
                        "Analysis: The sudden certainty about Sarah's bracelet contradicts earlier statements.",
                        "Analysis: Your changing story about the bracelet damages credibility.",
                        "Analysis: The shift in certainty about ownership seems suspicious.",
                        "Analysis: Your inconsistent bracelet narrative raises red flags."
                    };
                else
                    analyses = new[] {
                        "Analysis: Claiming ignorance about a friend's jewelry seems implausible.",
                        "Analysis: Your detachment from Sarah's accessories appears artificial.",
                        "Analysis: The attempt to distance yourself from Sarah lacks authenticity.",
                        "Analysis: Your feigned ignorance about the bracelet strains belief."
                    };
                break;

            case 6:
                if (choice.Contains("unrelated coincidences"))
                    analyses = new[] {
                        "Analysis: Your grasp of reasonable doubt principles shows legal awareness.",
                        "Analysis: The coincidence defense demonstrates sophisticated thinking.",
                        "Analysis: Attempting to disconnect evidence shows strategic planning.",
                        "Analysis: Your logical deconstruction of evidence reveals careful thought."
                    };
                else if (choice.Contains("connecting unrelated"))
                    analyses = new[] {
                        "Analysis: Challenging evidence connections shows investigative knowledge.",
                        "Analysis: Your analytical approach to evidence suggests preparation.",
                        "Analysis: The attempt to discredit evidence links shows critical thinking.",
                        "Analysis: Your methodical evidence challenge indicates strategic defense."
                    };
                else if (choice.Contains("tell you everything"))
                    analyses = new[] {
                        "Analysis: The final breakdown reveals the pressure's effectiveness.",
                        "Analysis: Your willingness to confess suggests guilt and weakness.",
                        "Analysis: Breaking loyalty at the end undermines previous defenses.",
                        "Analysis: The last-minute confession destroys group trust."
                    };
                else
                    analyses = new[] {
                        "Analysis: Maintaining silence shows remarkable final resolve.",
                        "Analysis: Your composed legal stance demonstrates preparation.",
                        "Analysis: The choice to stay silent leaves questions but preserves rights.",
                        "Analysis: Your final resistance suggests either innocence or skilled deception."
                    };
                break;

            default:
                analyses = new[] { "Analysis: Choice analysis not available." };
                break;
        }

        Console.WriteLine(analyses[random.Next(analyses.Length)]);
    }
}
