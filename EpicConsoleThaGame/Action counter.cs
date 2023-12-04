namespace EpicConsoleThaGame;

public class Action_counter
{
    
    private int _doAction;
    public int doActionNumber
    {
        get
        {
            return _doAction;
        }
        set
        {
            _doAction = _doAction ++;
            if (_doAction >20)
            {
                _doAction =0;
            }
        }
    }
    public string DoAction()
    {
        int doActionNumber = new();
        if (doActionNumber >= 20)
        {
            return  "stop";
        }
        return "";
    }
}
