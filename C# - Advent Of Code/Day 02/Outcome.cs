namespace AoC.Y2022.D02;

public class Outcome
{
    public string Name { get; private set; } // [todo] Make type safe? Enums?
    public int Points { get; private set; }
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
}