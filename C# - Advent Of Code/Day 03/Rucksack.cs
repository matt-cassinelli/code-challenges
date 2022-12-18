namespace AoC.Y2022.D03;

class Rucksack
{
    public Rucksack(string items)
    {
        Items = new List<Item>();
        foreach (char id in items)
        {
            Items.Add(new Item(id));
        }
    }

    public List<Item> Items { get; }
    private List<Item> compartment1 { get => Items.GetRange(0, Items.Count / 2); }
    private List<Item> compartment2 { get => Items.GetRange(Items.Count / 2, Items.Count / 2); }
    public Item CommonItem { get => compartment1.IntersectBy(compartment2.Select(i => i.Id), i => i.Id).First(); }
}