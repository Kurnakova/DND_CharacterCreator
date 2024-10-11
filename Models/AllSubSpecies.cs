using DND_CharacterCreator.Constants;

namespace DND_CharacterCreator.Models;

public class AllSubSpecies
{
    public string PrintElves()
    {
        string info = $"1. {SubSpeciesConstant.HighElfName} (+{SubSpeciesConstant.HighElfIntelligence} к интеллекту)\n";
        info += $"2. {SubSpeciesConstant.WoodElfName} (+{SubSpeciesConstant.WoodElfWisdom} к мудрости)\n";
        info += $"3. {SubSpeciesConstant.DrowName} (+{SubSpeciesConstant.DrowCharisma} к харизме)";
        return info;
    }
    public string PrintDwarves()
    {
        string info = $"1. {SubSpeciesConstant.HillDwarfName} (+{SubSpeciesConstant.HillDwarfWisdom} к мудрости)\n";
        info += $"2. {SubSpeciesConstant.MountainDwarfName} (+{SubSpeciesConstant.MountainDwarfStrength} к силе)\n";
        return info;
    }
    public string PrintGnomes()
    {
        string info = $"1. {SubSpeciesConstant.ForestGnomeName} (+{SubSpeciesConstant.ForestGnomeDexterity} к ловкости)\n";
        info += $"2. {SubSpeciesConstant.RockGnomeName} (+{SubSpeciesConstant.RockGnomeConstitution} к телосложению)\n";
        return info;
    }
}
