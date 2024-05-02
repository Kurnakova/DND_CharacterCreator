class Person
{
    string? _name;
    int _strength;
    int _dexterity;
    int _constitution;
    int _intelligence;
    int _wisdom;
    int _charisma;
    int _strengthModifier;
    int _dexterityModifier;
    int _constitutionModifier;
    int _intelligenceModifier;
    int _wisdomModifier;
    int _charismaModifier;

    Ancestry _ancestry;
    //Методы
    public void GetInfo()
    {
        Console.WriteLine($"Имя: {_name}, Происхождение: {_ancestry._name}");
        Console.WriteLine($"Сила: {_strength} ({GetModifierString(_strength)}), Ловкость:{_dexterity} ({GetModifierString(_dexterity)}), Телосложение: {_constitution} ({GetModifierString(_constitution)}), Интеллект: {_intelligence} ({GetModifierString(_intelligence)}), Мудрость: {_wisdom} ({GetModifierString(_wisdom)}), Харизма: {_charisma} ({GetModifierString(_charisma)})");
    }
    public int GetModifierInt(int characteristic)
    {
        decimal modifierDecimal = (Math.Floor((decimal)(characteristic - 10)/2));
        int modifier = Convert.ToInt32(modifierDecimal);
        return modifier;
    }
    public string GetModifierString(int characteristic)
    {
        int modifier = GetModifierInt(characteristic);
        if (modifier > 0)
            return $"+{modifier}";
        else
            return $"{modifier}";
    }
    int AddAncestryBonus(int characteristic, int bonus)
    {
        characteristic += bonus;
        return characteristic;
    }

    void SetCharacteristic(ref int characteristic, int number, ref int modifier, int ancestryBonus)
    {
        characteristic = number;
        characteristic = AddAncestryBonus(characteristic, ancestryBonus);
        modifier = GetModifierInt(characteristic);
    }

    public Person (string name, Ancestry ancestry, int strength, int dexterity, int constitution, int intelligence, int wisdom, int charisma)
    {
        _name = name;
        _ancestry = ancestry;
        SetCharacteristic(ref _strength, strength, ref _strengthModifier, ancestry._strBonus);
        SetCharacteristic(ref _dexterity, dexterity, ref _dexterityModifier, ancestry._dexBonus);
        SetCharacteristic(ref _constitution, constitution, ref _constitutionModifier, ancestry._conBonus);
        SetCharacteristic(ref _intelligence, intelligence, ref _intelligenceModifier, ancestry._intBonus);
        SetCharacteristic(ref _wisdom, wisdom, ref _wisdomModifier, ancestry._wisBonus);
        SetCharacteristic(ref _charisma, charisma, ref _charismaModifier, ancestry._chaBonus);
    }
}
class Ancestry
{
    public string _name = "undefined ancestry";
    public int _strBonus = 0;
    public int _dexBonus = 0;
    public int _conBonus = 0;
    public int _intBonus = 0;
    public int _wisBonus = 0;
    public int _chaBonus = 0;
    public Ancestry(string name, int strBonus = 0, int dexBonus = 0, int conBonus = 0, int intBonus = 0, int wisBonus = 0, int chaBonus = 0)
    {
        _name = name;
        _strBonus = strBonus;
        _dexBonus = dexBonus;
        _conBonus = conBonus;
        _intBonus = intBonus;
        _wisBonus = wisBonus;
        _chaBonus = chaBonus;
    }
}