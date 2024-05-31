namespace DND_Modifications.Models
{
    class Characteristic
    {
        public int Value { get; }
        public Characteristic(int value)
        {
            Value = value;
        }
        public int GetModifierNumber()
        {
            decimal modifierDecimal = Math.Floor((decimal)(Value - 10)/2);
            int modifier = Convert.ToInt32(modifierDecimal);
            return modifier;
        }
        public string GetModifier()
        {
            int modifier = GetModifierNumber();
            if (modifier > 0)
                return $"+{modifier}";
            else
                return $"{modifier}";
        }
    }
}