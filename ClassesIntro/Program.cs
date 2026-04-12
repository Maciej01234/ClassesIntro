using ClassesIntro;
// See https://aka.ms/new-console-template for more information
// string playerAvatar = "@";
// Console.WriteLine(playerAvatar);
Player hero = new Player();
hero.Display();

while (true)
{
    hero.Display();
    ConsoleKeyInfo keyInfo = Console.ReadKey(true);
    hero.ClearPlayerPosition();
    
    
    if (keyInfo.Key == ConsoleKey.A)
    {
        // ruch w lewo
        hero.Move(-1, 0);
    }
    else if (keyInfo.Key == ConsoleKey.D)
    {
        // ruch w prawo
        hero.Move(1, 0);
    }
    else if (keyInfo.Key == ConsoleKey.W)
    {
        // ruch w górę
        hero.Move(0, -1);
    }
    else if (keyInfo.Key == ConsoleKey.S)
    {
        // ruch w dół
        hero.Move(0, 1);
    }

}