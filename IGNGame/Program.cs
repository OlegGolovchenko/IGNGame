using org.igrok_net.game.ui;

namespace org.igrok_net.game;

class Program
{
    public static void Main(string[] args)
    {
#if WINDOWS
        Console.WriteLine("windows platform detected!");
#endif
        Window window = new Window("IgRok-NET Game v0.0.1", args);
        window.Render();
    }
}
