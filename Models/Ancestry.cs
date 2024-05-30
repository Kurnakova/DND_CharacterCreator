class Ancestry
{
    public string? Name { get; }
    public int StrengthBonus { get; }
    public int DexterityBonus { get; }
    public int ConstitutionBonus { get; }
    public int IntelligenceBonus { get; }
    public int WisdomBonus { get; }
    public int CharismaBonus { get; }
    public CreatureSize Size { get; }

    public Ancestry (AncestryType type)
    {
        if (type == AncestryType.Elf)
        {
            Name = "Эльф";
            DexterityBonus = 2;
            WisdomBonus = 1;
            Size = CreatureSize.Medium;
        }
        else if (type == AncestryType.Dwarf)
        {
            Name = "Дварф";
            StrengthBonus = 1;
            ConstitutionBonus = 2;
            Size = CreatureSize.Medium;
        }
        else if (type == AncestryType.Gnome)
        {
            Name = "Гном";
            DexterityBonus = 1;
            IntelligenceBonus = 2;
            Size = CreatureSize.Small;
        }
    }
}
