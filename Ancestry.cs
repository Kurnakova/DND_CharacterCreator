class Ancestry
{
    static int lastID = 0;
    public int _ID { get; } = 0;
    public string _name { get; } = "undefined ancestry";
    public int _strBonus { get; } = 0;
    public int _dexBonus { get; } = 0;
    public int _conBonus { get; } = 0;
    public int _intBonus { get; } = 0;
    public int _wisBonus { get; } = 0;
    public int _chaBonus { get; } = 0;

    public Ancestry( string name, int strBonus = 0, int dexBonus = 0, int conBonus = 0, int intBonus = 0, int wisBonus = 0, int chaBonus = 0 )
    {
        
        lastID++;
        _ID = lastID;
        _name = name;
        _strBonus = strBonus;
        _dexBonus = dexBonus;
        _conBonus = conBonus;
        _intBonus = intBonus;
        _wisBonus = wisBonus;
        _chaBonus = chaBonus;
    }
    public Ancestry (int type)
    {
        if (type == 1)
        {
            _name = "Эльф";
            _dexBonus = 2;
            _wisBonus = 1;
        }
        else-if (type == 2)
        {
            _name = "Дварф";
            _strBonus = 1;
            _conBonus = 2;
        }
        else-if (type == 3)
        {
            _name = "Гном";
            _dexBonus = 1;
            _intBonus = 2;
        }
    }
}
