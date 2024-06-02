namespace DND_CharacterCreator.Models;

public class Characteristic
{
    public int Value { get; }
    public Characteristic(int value)
    {
        Value = value;
    }
    public int CalcModifier()
    {
        decimal modifierDecimal = Math.Floor((decimal)(Value - 10)/2);
        int modifier = Convert.ToInt32(modifierDecimal);
        return modifier;
    }
    public string PrintModifier()
    {
        int modifier = CalcModifier();
        if (modifier > 0)
            return $"+{modifier}";
        else
            return $"{modifier}";
    }
}
