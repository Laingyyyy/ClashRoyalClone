using System;
using Core;

namespace DesktopGl;

public class Program
{
    public static void Main(string[] args)
    {
        using var game = new Game1();
        game.Run();
    }
}