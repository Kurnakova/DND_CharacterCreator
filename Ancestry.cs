class Ancestry
{
    public string _name { get; } = "undefined ancestry";
    public int _strengthBonus { get; } = 0;
    public int _dexterityBonus { get; } = 0;
    public int _constitutionBonus { get; } = 0;
    public int _intelligenceBonus { get; } = 0;
    public int _wisdomBonus { get; } = 0;
    public int _charismaBonus { get; } = 0;
    CreatureSize size;

    public Ancestry (int type)
    {
        if (type == 1)
        {
            _name = "Эльф";
            _dexterityBonus = 2;
            _wisdomBonus = 1;
            size = CreatureSize.Medium;
        }
        else if (type == 2)
        {
            _name = "Дварф";
            _strengthBonus = 1;
            _constitutionBonus = 2;
            size = CreatureSize.Medium;
        }
        else if (type == 3)
        {
            _name = "Гном";
            _dexterityBonus = 1;
            _intelligenceBonus = 2;
            size = CreatureSize.Small;
        }
    }
}
