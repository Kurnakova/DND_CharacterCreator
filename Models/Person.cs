class Person
{
    string? _name;
    private readonly Characteristic _strength = new Characteristic(0);
    private readonly Characteristic _dexterity = new Characteristic(0);
    private readonly Characteristic _constitution = new Characteristic(0);
    private readonly Characteristic _intelligence = new Characteristic(0);
    private readonly Characteristic _wisdom = new Characteristic(0);
    private readonly Characteristic _charisma = new Characteristic(0);

    Ancestry _ancestry;
    //Методы
    public void GetInfo()
    {
        Console.WriteLine($"Имя: {_name}, Происхождение: {_ancestry.Name}");
        Console.WriteLine($"Сила: {_strength.value} ({_strength.GetModifierString()}), Ловкость:{_dexterity.value} ({_dexterity.GetModifierString()}), Телосложение: {_constitution.value} ({_constitution.GetModifierString()}), Интеллект: {_intelligence.value} ({_intelligence.GetModifierString()}), Мудрость: {_wisdom.value} ({_wisdom.GetModifierString()}), Харизма: {_charisma.value} ({_charisma.GetModifierString()})");
    }
    
    public Person (string name, Ancestry ancestry, int strength, int dexterity, int constitution, int intelligence, int wisdom, int charisma)
    {
        _name = name;
        _ancestry = ancestry;
        _strength = new Characteristic (strength + ancestry.StrengthBonus);
        _dexterity = new Characteristic (dexterity + ancestry.DexterityBonus);
        _constitution = new Characteristic (constitution + ancestry.ConstitutionBonus);
        _intelligence = new Characteristic (intelligence + ancestry.IntelligenceBonus);
        _wisdom = new Characteristic (wisdom + ancestry.WisdomBonus);
        _charisma = new Characteristic (charisma + ancestry.CharismaBonus);
    }
}
