class Characteristic
{
    public int Value { get; set; }
    public int GetModifierInt()
    {
        decimal modifierDecimal = Math.Floor((decimal)(Value - 10)/2);
        int modifier = Convert.ToInt32(modifierDecimal);
         return modifier;
    }
    public string GetModifierString()
    {
        int modifier = GetModifierInt();
        if (modifier > 0)
            return $"+{modifier}";
        else
            return $"{modifier}";
    }
    public Characteristic (int value)
    {
        Value = value;
    }
}
