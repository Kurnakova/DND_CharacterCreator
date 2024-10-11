using System.Runtime.InteropServices;
using DND_CharacterCreator.Constants;
using DND_CharacterCreator.Enums;
using DND_CharacterCreator.Models;

Console.WriteLine("Введите данные о персонаже.");
Console.Write("Имя: ");
string name = CreateName();
Console.WriteLine($"Введите значения характеристик (в диапазоне от {CharacteristicConstant.MinLimit} до {CharacteristicConstant.MaxLimit}).");
Console.Write("Сила: ");
int strength = CreateCharacteristic();
Console.Write("Ловкость: ");
int dexterity = CreateCharacteristic();
Console.Write("Телосложение: ");
int constitution = CreateCharacteristic();
Console.Write("Интеллект: ");
int intelligence = CreateCharacteristic();
Console.Write("Мудрость: ");
int wisdom = CreateCharacteristic();
Console.Write("Харизма: ");
int charisma = CreateCharacteristic();
Console.WriteLine("Выберите расу (номер):");
Console.WriteLine(new AllSpecies().Print());
Species species = CreateSpecies();
SubSpecies subSpecies = CreateSubSpecies(species.Type);

Person person = new(name, species, subSpecies, strength, dexterity, constitution, intelligence, wisdom, charisma);
Console.WriteLine(person.Print());

string CreateName()
{
    string? name;
    while (true)
    {
        name = Console.ReadLine();
        if (string.IsNullOrWhiteSpace(name))
        {
            Console.Write("Имя должно содержать символы. \nИмя: ");
        }
        else
        {
            break;
        }
    }
    return name;
}
int CreateCharacteristic()
{
    int number;
    while (true)
    {
        var input = Console.ReadLine();
        if (int.TryParse(input, out number))
        {
            if (number >= CharacteristicConstant.MinLimit && number <= CharacteristicConstant.MaxLimit)
            {
                break;
            }
            else
            {
                Console.Write($"Значение должно быть в диапазоне от {CharacteristicConstant.MinLimit} до {CharacteristicConstant.MaxLimit}. \nЗначение: ");
            }

        }
        else
        {
            Console.Write("Значение характеристики должно быть числом. \nЗначение: ");
        }
    }
    return number;
}
Species CreateSpecies()
{
    SpeciesType type = SpeciesType.Dwarf;
    bool invalidOption = true;
    while (invalidOption)
    {
        int speciesOption = Convert.ToInt32(Console.ReadLine());
        type = (SpeciesType)speciesOption;
        invalidOption = speciesOption < 1 || speciesOption > 3;
        if (invalidOption)
        {
            Console.WriteLine("Неверное число. Введите число из списка.");
        }
    }
    return new Species(type);
}

SubSpecies CreateSubSpecies(SpeciesType speciesType)
{
    SubSpeciesType subSpeciesType = SubSpeciesType.Drow;
    Console.WriteLine("Выберете подрасу:");
    if (speciesType == SpeciesType.Elf)
    {
        int numberOfSubSpecies = SpeciesConstant.ElfSubSpeciesNumber;
        Console.WriteLine(new AllSubSpecies().PrintElves());
        int subSpeciesOption = ChooseSubSpecies(numberOfSubSpecies);
        subSpeciesType = (SubSpeciesType)(100 + subSpeciesOption);
    }
    else if (speciesType == SpeciesType.Dwarf)
    {
        int numberOfSubSpecies = SpeciesConstant.DwarfSubSpeciesNumber;
        Console.WriteLine(new AllSubSpecies().PrintDwarves());
        int subSpeciesOption = ChooseSubSpecies(numberOfSubSpecies);
        subSpeciesType = (SubSpeciesType)(200 + subSpeciesOption);
    }
    else if (speciesType == SpeciesType.Gnome)
    {
        int numberOfSubSpecies = SpeciesConstant.GnomeSubSpeciesNumber;
        Console.WriteLine(new AllSubSpecies().PrintGnomes());
        int option = ChooseSubSpecies(numberOfSubSpecies);
    }
    return new SubSpecies(speciesType, subSpeciesType);
}

int ChooseSubSpecies(int numberOfSubSpecies)
{
    int speciesOption = 1;
    bool invalidOption = true;
    while (invalidOption)
    {
        speciesOption = Convert.ToInt32(Console.ReadLine());
        invalidOption = speciesOption < 1 || speciesOption > numberOfSubSpecies;
        if (invalidOption)
        {
            Console.WriteLine("Неверное число. Введите число из списка.");
        }
    }
    return speciesOption;
}

