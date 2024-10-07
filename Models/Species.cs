using DND_CharacterCreator.Constants;
using DND_CharacterCreator.Enums;

namespace DND_CharacterCreator.Models;

public class Species 
{
    public string Name { get; }
    public int Strength { get; }
    public int Dexterity { get; }
    public int Constitution { get; }
    public int Intelligence { get; }
    public int Wisdom { get; }
    public int Charisma { get; }
    public CreatureSize Size { get; }

    public Species(SpeciesType type)
    {
        if (type == SpeciesType.Elf)
        {
            Name = SpeciesConstant.ElfName;
            Dexterity = SpeciesConstant.ElfDexterity;
            Size = CreatureSize.Medium;
        }
        else if (type == SpeciesType.Dwarf)
        {
            Name = SpeciesConstant.DwarfName;
            Constitution = SpeciesConstant.DwarfConstitution;
            Size = CreatureSize.Medium;
        }
        else if (type == SpeciesType.Gnome)
        {
            Name = SpeciesConstant.GnomeName;
            Intelligence = SpeciesConstant.GnomeIntelligence;
            Size = CreatureSize.Small;
        }
        else
        {
            throw new NotImplementedException();
        }
    }
}
