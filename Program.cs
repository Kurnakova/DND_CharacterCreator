using DND_Modifications.Models;

Console.WriteLine("Введите в консоль данные о персонаже.");
Console.Write("Имя: ");
string name = CreateName();
Console.WriteLine("Введите значения характеристик.");
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
Console.WriteLine("Выберите расу (введите её номер в консоль):");
Console.WriteLine(Ancestry.ListAllAncestries());
Ancestry ancestry = CreateAncestry(); 

Person person = new (name, ancestry, strength, dexterity, constitution, intelligence, wisdom, charisma);
Console.WriteLine(person.GetInfo());

// Методы
string CreateName()
{
    string? name;
    while (true)
    {
        name = Console.ReadLine();
        if(string.IsNullOrWhiteSpace(name))
        {
            Console.WriteLine("Имя должно содержать символы. \nВведите новое имя:");
        }
        else
            break;
    }
    return name;
}
int CreateCharacteristic()
    {
        int number;
        while(true)
        {
            var input = Console.ReadLine();
            if (int.TryParse(input, out number))
                {
                    if(number >= 1 && number <= 20)
                        break;
                    else
                        Console.WriteLine("Значение должно быть в диапазоне от 1 до 20. \nВведите новое значение:");

                }
            else
            {
                Console.WriteLine("Значение характеристики должно быть числом. \nВведите новое значение:");
            }
        }
        return number;
    }
Ancestry CreateAncestry()
{
    AncestryType type = AncestryType.Dwarf;
    bool InvalidOption = true;
    while (InvalidOption)
    {
       int ancestryOption = Convert.ToInt32(Console.ReadLine());
       type = (AncestryType)ancestryOption;
       InvalidOption = ancestryOption < 1 || ancestryOption > 3;
       if (InvalidOption)
            Console.WriteLine("Неверное число. Введите число из списка.");
    }
    return new Ancestry(type);
}