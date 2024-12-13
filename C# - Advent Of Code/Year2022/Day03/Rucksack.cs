namespace AdventOfCode.Year2022.Day03;

class Rucksack
{
    public Rucksack(string items)
    {
        Items = [];
        foreach (char id in items)
        {
            Items.Add(new Item(id));
        }
    }

    public List<Item> Items { get; }
    private List<Item> compartment1 => Items.GetRange(0, Items.Count / 2);
    private List<Item> compartment2 => Items.GetRange(Items.Count / 2, Items.Count / 2);
    public Item CommonItem => compartment1.IntersectBy(compartment2.Select(i => i.Id), i => i.Id).First();
}
