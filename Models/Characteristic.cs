class Characteristic
{
    public int value { get; set; } = 0;
    public int GetModifierInt()
    {
        decimal modifierDecimal = (Math.Floor((decimal)(value - 10)/2));
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
        this.value = value;
    }
}
