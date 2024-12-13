namespace AdventOfCode.Year2022.Day03;

class Item
{
    public Item(char id)
    { 
        Id = id;
    }

    public char Id { get; }
    public int Priority => char.IsUpper(Id) ? Id - 38 : Id - 96;
}
