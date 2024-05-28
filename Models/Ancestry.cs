class Ancestry
{
    public string? Name { get; }
    public int StrengthBonus { get; }
    public int DexterityBonus { get; }
    public int ConstitutionBonus { get; }
    public int IntelligenceBonus { get; }
    public int WisdomBonus { get; }
    public int CharismaBonus { get; }
    CreatureSize size { get; }

    public Ancestry (AncestryType type)
    {
        if (type == AncestryType.elf)
        {
            Name = "Эльф";
            DexterityBonus = 2;
            WisdomBonus = 1;
            size = CreatureSize.Medium;
        }
        else if (type == AncestryType.dwarf)
        {
            Name = "Дварф";
            StrengthBonus = 1;
            ConstitutionBonus = 2;
            size = CreatureSize.Medium;
        }
        else if (type == AncestryType.gnome)
        {
            Name = "Гном";
            DexterityBonus = 1;
            IntelligenceBonus = 2;
            size = CreatureSize.Small;
        }
    }
}
