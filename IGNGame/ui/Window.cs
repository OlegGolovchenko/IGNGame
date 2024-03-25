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

        public Window(string title)
        {
            Natives.glfwSetErrorCallback(ErrorHandler);
            if (Natives.glfwInit() != Natives.GLFW_TRUE)
            {
                throw new Exception("Unable to initialize GLFW");
            }
            this.window = Natives.glfwCreateWindow(1366,768, title, IntPtr.Zero, IntPtr.Zero);
            if(this.window == IntPtr.Zero)
            {
                throw new Exception("Unable to create GLFW window");
            }
        }

        public void Dispose()
        {
            Natives.glfwTerminate();
        }
    }
}
