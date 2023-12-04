namespace EpicConsoleThaGame;

public class Food: Item
{
    public Dictionary<string,int> foods =new();
    public string foodname;
    public int foodfeed;
    public int Eat(string foodname,int foodfeed,Player target)
    {
        int value =0;
        value += foodfeed;
        Console.WriteLine($"{target.playername} Eats {foodname} healing: {foodfeed} health");
        return value;
    }
}
