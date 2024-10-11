using DND_CharacterCreator.Constants;
using DND_CharacterCreator.Enums;

namespace DND_CharacterCreator.Models;

public class SubSpecies 
{
    public SubSpeciesType Type { get; }
    public string Name { get; }
    public int Strength { get; }
    public int Dexterity { get; }
    public int Constitution { get; }
    public int Intelligence { get; }
    public int Wisdom { get; }
    public int Charisma { get; }

    public SubSpecies(SpeciesType speciesType, SubSpeciesType type)
    {
        Type = type;
        if (speciesType == SpeciesType.Elf)
        {
            if (type == SubSpeciesType.HighElf)
            {
                Name = SubSpeciesConstant.HighElfName;
                Intelligence = SubSpeciesConstant.HighElfIntelligence;
            }
            else if (type == SubSpeciesType.WoodElf)
            {
                Name = SubSpeciesConstant.WoodElfName;
                Wisdom = SubSpeciesConstant.WoodElfWisdom;
            }
            else if (type == SubSpeciesType.Drow)
            {
                Name = SubSpeciesConstant.DrowName;
                Charisma = SubSpeciesConstant.DrowCharisma;
            }
            else
            {
                throw new NotImplementedException();
            }
        }
        else if (speciesType == SpeciesType.Dwarf)
        {
            if (type == SubSpeciesType.HillDwarf)
            {
                Name = SubSpeciesConstant.HillDwarfName;
                Wisdom = SubSpeciesConstant.HillDwarfWisdom;
            }
            else if (type == SubSpeciesType.MountainDwarf)
            {
                Name = SubSpeciesConstant.MountainDwarfName;
                Strength = SubSpeciesConstant.MountainDwarfStrength;
            }
            else
            {
                throw new NotImplementedException();
            }
        }
        else if (speciesType == SpeciesType.Gnome)
        {
            if (type == SubSpeciesType.ForestGnome)
            {
                Name = SubSpeciesConstant.ForestGnomeName;
                Dexterity = SubSpeciesConstant.ForestGnomeDexterity;
            }
            else if (type == SubSpeciesType.RockGnome)
            {
                Name = SubSpeciesConstant.RockGnomeName;
                Constitution = SubSpeciesConstant.RockGnomeConstitution;
            }
            else
            {
                throw new NotImplementedException();
            }
        }
        else
        {
            throw new NotImplementedException();
        }
    }
}
