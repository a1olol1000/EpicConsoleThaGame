using EpicConsoleThaGame;

Console.Title = "Epic Console Tha Game";
Console.SetWindowPosition(0,0);
Console.SetWindowSize(Console.LargestWindowWidth,Console.LargestWindowHeight);
bool gameloop = true;
int frameRateCheck = 20;
int frameRate = 1000/frameRateCheck;
int frame = 0;
Food food= new();
food.foods =new();
food.foods.Add("apple",3);
food.foodfeed = food.foods["apple"];
while (gameloop) 
{
    Console.Clear();
    Console.WriteLine(frame);
    if (frame>frameRateCheck)
    {
        frame= 0;
    }
    ControlWriter.Controler();
    if (Console.ReadKey().Key == ConsoleKey.I)
    {
        ControlWriter.InventoryControls();
        Console.ReadLine();
    }
    if (Console.ReadKey().Key == ConsoleKey.A)
    {
        
    }
    if (Console.ReadKey().Key == ConsoleKey.D)
    {
        
    }
    if (Console.ReadKey().Key == ConsoleKey.E)
    {
        
    }

    Console.WriteLine("blabla");
    Console.WriteLine("blabla");
    Thread.Sleep(frameRate);
    frame++;
}
