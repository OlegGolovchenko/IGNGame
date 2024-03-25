using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace org.igrok_net.game.ui.natives
{
    public delegate void GLFWErrorFunc(int error, [MarshalAs(UnmanagedType.LPStr)] string description);

    internal static class Natives
    {
        public const int GLFW_TRUE = 1;
        public const int GLFW_FALSE = 0;

        [DllImport("glfw3")]
        public static extern int glfwInit();
        [DllImport("glfw3")]
        public static extern void glfwTerminate();
        [DllImport("glfw3")]
        [return: MarshalAs(UnmanagedType.FunctionPtr)]
        public static extern GLFWErrorFunc glfwSetErrorCallback([MarshalAs(UnmanagedType.FunctionPtr)] GLFWErrorFunc errorFunc);
        [DllImport("glfw3")]
        public static extern 
    }
}
