// I used artificial intelligence while creating this game

public class Question
{
    public static readonly string[] Questions = {
        "Detective Johnson: \"Interesting... The store owner mentioned hearing laughter at 3:45 PM, but the alarm didn't go off until 3:47 PM. What were you doing in those two minutes?\"",
        "Detective Smith: \"A student from West High saw someone with a red backpack running. The same person dropped this butterfly charm bracelet. Quite a coincidence, wouldn't you say?\"",
        "Detective Johnson: \"We found a torn receipt by the dumpster. The total matches exactly what was taken. Someone must have checked prices beforehand. Care to explain?\"",
        "Detective Smith: \"Your friend Mike is in the next room. He seems nervous about that red backpack. Should we ask him about it?\"",
        "Detective Johnson: \"The security camera shows static at exactly 3:47 PM. The store owner claims he heard voices discussing 'the perfect timing.' What timing were you discussing?\"",
        "Detective Smith: \"A teacher reported seeing Sarah wearing this same bracelet during third period. But you're saying you haven't seen her today?\"",
        "Detective Johnson: \"Final question. We have three different statements: the store owner heard laughter, a witness saw the red backpack, and we have this bracelet. How do you explain all three?\""
    };

    public static readonly string[][] Options = {
        new[] {
            "\"I was at basketball practice until 4 PM\"",
            "\"We were just browsing, nothing suspicious\"",
            "\"Maybe Sarah knows, she usually hangs out there\"",
            "\"I need to consult with a lawyer before answering\""
        },
        new[] {
            "\"Many students have red backpacks and similar bracelets\"",
            "\"That bracelet could've been there for days\"",
            "\"Sarah mentioned losing her bracelet yesterday\"",
            "\"I don't feel comfortable speculating about others\""
        },
        new[] {
            "\"Anyone could have checked prices, it's a public store\"",
            "\"That receipt could be from any customer\"",
            "\"Mike always checks prices before buying anything\"",
            "\"I don't know anything about any receipt\""
        },
        new[] {
            "\"Mike wasn't even at school today\"",
            "\"Why are you trying to pit us against each other?\"",
            "\"The red backpack belongs to Mike\"",
            "\"I can't speak for Mike's nervousness\""
        },
        new[] {
            "\"The security system in that area is unreliable\"",
            "\"We were discussing the timing of the basketball game\"",
            "\"Sarah mentioned something about camera timing\"",
            "\"I don't recall any discussions about timing\""
        },
        new[] {
            "\"Many students have similar bracelets\"",
            "\"I haven't paid attention to Sarah's jewelry\"",
            "\"Yes, that's definitely Sarah's bracelet\"",
            "\"School records can confirm where everyone was\""
        },
        new[] {
            "\"These could all be unrelated coincidences\"",
            "\"I think you're connecting unrelated events\"",
            "\"I'll tell you everything about Sarah and Mike\"",
            "\"I maintain my right to remain silent\""
        }
    };

    public static readonly string[] Clues = {
        "Clue #1: The store's security footage shows static interference at 3:47 PM",
        "Clue #2: A receipt for $47.83 was found torn near the dumpster",
        "Clue #3: The witness claims one person was wearing a red backpack",
        "Clue #4: Sarah's bracelet has a unique butterfly charm",
        "Clue #5: The store owner mentioned hearing laughter before the alarm"
    };
}
