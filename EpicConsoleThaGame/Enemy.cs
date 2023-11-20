namespace EpicConsoleThaGame;

public class Enemy
{
    private int _maxHp=100000;
    private int _hp = 100;
    public int health {get{return _hp;}set{_hp = Math.Min(Math.Max(value,0),_maxHp);}}

    private Inventory inventory = new();
}
