class Ancestry
{
    public string? Name { get; }
    public int Strength { get; }
    public int Dexterity { get; }
    public int Constitution { get; }
    public int Intelligence { get; }
    public int Wisdom { get; }
    public int Charisma { get; }
    public CreatureSize Size { get; }

    public Ancestry(AncestryType type)
    {
        if (type == AncestryType.Elf)
        {
            Name = "Эльф";
            Dexterity = 2;
            Wisdom = 1;
            Size = CreatureSize.Medium;
        }
        else if (type == AncestryType.Dwarf)
        {
            Name = "Дварф";
            Strength = 1;
            Constitution = 2;
            Size = CreatureSize.Medium;
        }
        else if (type == AncestryType.Gnome)
        {
            Name = "Гном";
            Dexterity = 1;
            Intelligence = 2;
            Size = CreatureSize.Small;
        }
    }
}
