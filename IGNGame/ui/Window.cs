using org.igrok_net.game.ui.natives;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace org.igrok_net.game.ui
{
    public class Window : IDisposable
    {
        private IntPtr window;
        private void ErrorHandler(int error, string description)
        {
            Console.WriteLine($"GLFW error {error} '{description}'!");
        }

        public Window()
        {
            Natives.glfwSetErrorCallback(ErrorHandler);
            if (Natives.glfwInit() != Natives.GLFW_TRUE)
            {
                Console.WriteLine("Failed to init glfw");
            }
        }

        public void Dispose()
        {
            Natives.glfwTerminate();
        }
    }
}
