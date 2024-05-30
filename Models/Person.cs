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
        _strength = new Characteristic (strength + ancestry.Strength);
        _dexterity = new Characteristic (dexterity + ancestry.Dexterity);
        _constitution = new Characteristic (constitution + ancestry.Constitution);
        _intelligence = new Characteristic (intelligence + ancestry.Intelligence);
        _wisdom = new Characteristic (wisdom + ancestry.Wisdom);
        _charisma = new Characteristic (charisma + ancestry.Charisma);
    }
    //Методы
    public void GetInfo()
    {
        Console.WriteLine($"Имя: {_name}, Происхождение: {_ancestry.Name}");
        Console.WriteLine($"Сила: {_strength.Value} ({_strength.GetModifier()}), Ловкость:{_dexterity.Value} ({_dexterity.GetModifier()}), Телосложение: {_constitution.Value} ({_constitution.GetModifier()}), Интеллект: {_intelligence.Value} ({_intelligence.GetModifier()}), Мудрость: {_wisdom.Value} ({_wisdom.GetModifier()}), Харизма: {_charisma.Value} ({_charisma.GetModifier()})");
    }

}