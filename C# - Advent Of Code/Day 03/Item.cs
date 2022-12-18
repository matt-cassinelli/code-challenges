namespace AoC.Y2022.D03;

class Item
{
    public Item(char id) { Id = id; }
    public char Id { get; }
    public int Priority
    { 
        get // [todo] Check that this is lazy - not needed for every item.
        {
            if (char.IsUpper(Id))
                return Id - 38; // Don't ask...
            else
                return Id - 96;
        }
    }
}