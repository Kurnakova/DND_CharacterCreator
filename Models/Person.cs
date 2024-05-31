namespace DND_Modifications.Models
{
    class Person
    {
        private readonly string? _name;
        private readonly Characteristic _strength = new(0);
        private readonly Characteristic _dexterity = new(0);
        private readonly Characteristic _constitution = new(0);
        private readonly Characteristic _intelligence = new(0);
        private readonly Characteristic _wisdom = new(0);
        private readonly Characteristic _charisma = new(0);

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
        public string GetInfo()
        {
            string info = $"Имя: {_name}, Происхождение: {_ancestry.Name} \n";
            info += $"Сила: {_strength.Value} ({_strength.GetModifier()}), ";
            info += $"Ловкость:{_dexterity.Value} ({_dexterity.GetModifier()}), ";
            info += $"Телосложение: {_constitution.Value} ({_constitution.GetModifier()}), ";
            info += $"Интеллект: {_intelligence.Value} ({_intelligence.GetModifier()}), ";
            info += $"Мудрость: {_wisdom.Value} ({_wisdom.GetModifier()}), ";
            info += $"Харизма: {_charisma.Value} ({_charisma.GetModifier()})";
            return info;
        }
    }
}