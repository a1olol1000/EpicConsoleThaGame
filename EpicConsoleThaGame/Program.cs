Console.Title = "Epic Console Tha Game";
Console.SetWindowPosition(0,0);
Console.SetWindowSize(Console.LargestWindowWidth,Console.LargestWindowHeight);
bool gameloop = true;
int frameRateCheck = 20;
int frameRate = 1000/frameRateCheck;
int frame = 0;

while (gameloop) 
{
    Console.Clear();
    Console.WriteLine(frame);
    if (frame>frameRateCheck)
    {
        frame= 0;
    }
    if (Console.ReadKey().Key == ConsoleKey.A)
    {
        Console.WriteLine("dfijbvdfjhvbqeifobverhbdfihbidfvbiqefuvbiuqefvboiuqwhbpiuwedhvpiuqehvipuqehvpiweuhvpieuqhvpieruqhpeqofivh");
    }
    Console.WriteLine("blabla");
    Console.WriteLine("blabla");
    Thread.Sleep(frameRate);
    frame++;
}
