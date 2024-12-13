namespace AdventOfCode.Year2022.Day02;

public class Outcome
{
    public Outcome(string name)
    {
        if      (name == "Lose") {Points = 0;}
        else if (name == "Draw") {Points = 3;}
        else if (name == "Win")  {Points = 6;}
        else {throw new Exception($"Invalid outcome {name}");}
        Name = name;
    }
    public Outcome(char cipherChar)
    {
        if      (cipherChar == 'X') {Points = 0; Name = "Lose";}
        else if (cipherChar == 'Y') {Points = 3; Name = "Draw";}
        else if (cipherChar == 'Z') {Points = 6; Name = "Win";}
        else {throw new Exception($"Invalid outcome {cipherChar}");}
    }

    public string Name { get; } // [todo] Make type safe? Enums?
    public int Points { get; }
}