using org.igrok_net.game.ui;
using org.igrok_net.game.ui.natives;

namespace IGNGame64
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Natives.getGlutTimesNewRoman24());
            Window window = new Window("IgRok-NET Game v0.0.1", args);
            window.Render();
        }
    }
}
