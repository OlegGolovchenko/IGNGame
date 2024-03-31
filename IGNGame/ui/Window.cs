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
        private void KeyHandler(IntPtr window, int key, int scancode, int action, int mods) 
        {
            Console.WriteLine(key);
        }

        public Window(string title, string[] args)
        {
            Natives.glfwSetErrorCallback(ErrorHandler);
            if (Natives.glfwInit() != Natives.GLFW_TRUE)
            {
                throw new Exception("Unable to initialize GLFW");
            }
            Natives.glfwWindowHint(Natives.GLFW_CONTEXT_VERSION_MAJOR, 2);
            Natives.glfwWindowHint(Natives.GLFW_CONTEXT_VERSION_MINOR, 0);
            this.window = Natives.glfwCreateWindow(1366,768, title, IntPtr.Zero, IntPtr.Zero);
            if(this.window == IntPtr.Zero)
            {
                throw new Exception("Unable to create GLFW window");
            }

            Natives.glfwSetKeyCallback(this.window, KeyHandler);

            Natives.glfwMakeContextCurrent(this.window);
            var length = args.Length;
            Natives.glutInit(ref length, args);
        }

        public void Render()
        {
            while (Natives.glfwWindowShouldClose(this.window) != Natives.GLFW_TRUE)
            {
                int width = 0;
                int height = 0;
                Natives.glfwGetFramebufferSize(this.window, ref width, ref height);
                Natives.glViewport(0, 0, width, height);
                Natives.glfwSwapBuffers(this.window);
                Natives.glfwPollEvents();
            }
        }

        public void Dispose()
        {
            Natives.glfwDestroyWindow(this.window);
            Natives.glfwTerminate();
        }
    }
}
