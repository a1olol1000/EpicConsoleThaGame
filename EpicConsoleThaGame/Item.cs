namespace EpicConsoleThaGame;

public class Item
{
    private int _id;
    private int _globalId;
    public int globalId {get{return _globalId;}set{_globalId=value;}}
    public int item_id {get{return _id;} set{ _id =globalId; globalId++;}}
}
