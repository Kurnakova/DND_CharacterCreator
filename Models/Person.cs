class Person
{
    private readonly string? _name;
    private readonly Characteristic _strength = new Characteristic(0);
    private readonly Characteristic _dexterity = new Characteristic(0);
    private readonly Characteristic _constitution = new Characteristic(0);
    private readonly Characteristic _intelligence = new Characteristic(0);
    private readonly Characteristic _wisdom = new Characteristic(0);
    private readonly Characteristic _charisma = new Characteristic(0);

    private readonly Ancestry _ancestry;
    //Методы
    public void GetInfo()
    {
        Console.WriteLine($"Имя: {_name}, Происхождение: {_ancestry.Name}");
        Console.WriteLine($"Сила: {_strength.Value} ({_strength.GetModifierString()}), Ловкость:{_dexterity.Value} ({_dexterity.GetModifierString()}), Телосложение: {_constitution.Value} ({_constitution.GetModifierString()}), Интеллект: {_intelligence.Value} ({_intelligence.GetModifierString()}), Мудрость: {_wisdom.Value} ({_wisdom.GetModifierString()}), Харизма: {_charisma.Value} ({_charisma.GetModifierString()})");
    }
    
    public Person(
        string name, 
        Ancestry ancestry, 
        int strength, 
        int dexterity, 
        int constitution, 
        int intelligence, 
        int wisdom, 
        int charisma
    )
    {
        if (name == "" || name == " ")
            _name = "без имени";
        else
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