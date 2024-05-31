namespace DND_Modifications.Models
{
    public class Characteristic
    {
        public int Value { get; }
        public Characteristic(int value)
        {
            Value = value;
        }
        public int CountModifierNumber()
        {
            decimal modifierDecimal = Math.Floor((decimal)(Value - 10)/2);
            int modifier = Convert.ToInt32(modifierDecimal);
            return modifier;
        }
        public string GetModifier()
        {
            int modifier = CountModifierNumber();
            if (modifier > 0)
                return $"+{modifier}";
            else
                return $"{modifier}";
        }
    }
}