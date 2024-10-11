namespace DND_CharacterCreator.Models;

public class Person
{
    private readonly string? _name;
    private readonly Characteristic _strength;
    private readonly Characteristic _dexterity;
    private readonly Characteristic _constitution;
    private readonly Characteristic _intelligence;
    private readonly Characteristic _wisdom;
    private readonly Characteristic _charisma;

    private readonly Species _species;
    private readonly SubSpecies _subSpecies;

    public Person(
        string name,
        Species species,
        SubSpecies subSpecies,
        int strength,
        int dexterity,
        int constitution,
        int intelligence,
        int wisdom,
        int charisma
    )
    {
        _name = name;
        _species = species;
        _subSpecies = subSpecies;
        _strength = new Characteristic(strength + species.Strength + _subSpecies.Strength);
        _dexterity = new Characteristic(dexterity + species.Dexterity + _subSpecies.Dexterity);
        _constitution = new Characteristic(constitution + species.Constitution + _subSpecies.Constitution);
        _intelligence = new Characteristic(intelligence + species.Intelligence + _subSpecies.Wisdom);
        _wisdom = new Characteristic(wisdom + species.Wisdom + _subSpecies.Intelligence);
        _charisma = new Characteristic(charisma + species.Charisma + _subSpecies.Charisma);
    }
    public string Print()
    {
        string info = $"Имя: {_name}, Раса: {_species.Name} \n";
        info += $"Сила: {_strength.Value} ({_strength.PrintModifier()}), ";
        info += $"Ловкость: {_dexterity.Value} ({_dexterity.PrintModifier()}), ";
        info += $"Телосложение: {_constitution.Value} ({_constitution.PrintModifier()}), ";
        info += $"Интеллект: {_intelligence.Value} ({_intelligence.PrintModifier()}), ";
        info += $"Мудрость: {_wisdom.Value} ({_wisdom.PrintModifier()}), ";
        info += $"Харизма: {_charisma.Value} ({_charisma.PrintModifier()})";
        return info;
    }
}
