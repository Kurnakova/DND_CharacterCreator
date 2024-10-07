using DND_CharacterCreator.Constants;

namespace DND_CharacterCreator.Models;

public class AllSpecies
{
    public string Print()
    {
        string info = $"1. {SpeciesConstant.ElfName} (+{SpeciesConstant.ElfDexterity} к ловкости)\n";
        info += $"2. {SpeciesConstant.DwarfName} (+{SpeciesConstant.DwarfConstitution} к телосложению)\n";
        info += $"3. {SpeciesConstant.GnomeName} (+{SpeciesConstant.GnomeIntelligence} к интеллекту)";
        return info;
    }
}
