Console.Title = "Epic Console Tha Game";
Console.SetWindowPosition(0,0);
Console.SetWindowSize(Console.LargestWindowWidth,Console.LargestWindowHeight);
bool gameloop = true;
int frameRateCheck = 20;
int frameRate = 1000/frameRateCheck;
int frame = 0;
while(true) {  if (Console.KeyAvailable) { if (Console.ReadKey().Key == ConsoleKey.Escape) { do { Console.WriteLine("Press enter to resume"); } while (Console.ReadKey().Key != ConsoleKey.Enter); } } Thread.Sleep(100);}
while (gameloop) 
{
    Console.Clear();
    Console.WriteLine(frame);
    if (frame>frameRateCheck)
    {
        frame= 0;
    }
    if (true)
    {
        
    }
    Console.WriteLine("blabla");
    Console.WriteLine("blabla");
    Thread.Sleep(frameRate);
    frame++;
}
