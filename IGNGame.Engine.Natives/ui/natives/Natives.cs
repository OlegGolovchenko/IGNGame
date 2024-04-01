using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace org.igrok_net.game.ui.natives
{
    public delegate void GLFWErrorFunc([MarshalAs(UnmanagedType.I4)] int error, [MarshalAs(UnmanagedType.LPStr)] string description);
    public delegate void GLFWkeyfun(IntPtr window, [MarshalAs(UnmanagedType.I4)] int key, [MarshalAs(UnmanagedType.I4)] int scancode, [MarshalAs(UnmanagedType.I4)] int action, [MarshalAs(UnmanagedType.I4)] int mods);

    public static class Natives
    {
        [DllImport("ignnatives")]
        public static extern IntPtr getGlutTimesNewRoman24();
        #region "GLFW Functions"
        public const string GLFW_LIB = "glfw";
        public const int GLFW_TRUE = 1;
        public const int GLFW_FALSE = 0;
        public const int GLFW_CONTEXT_VERSION_MAJOR = 0x00022002;
        public const int GLFW_CONTEXT_VERSION_MINOR = 0x00022003;

        [DllImport(GLFW_LIB)]
        public static extern int glfwInit();
        [DllImport(GLFW_LIB)]
        public static extern void glfwTerminate();
        [DllImport(GLFW_LIB)]
        [return: MarshalAs(UnmanagedType.FunctionPtr)]
        public static extern GLFWErrorFunc glfwSetErrorCallback([MarshalAs(UnmanagedType.FunctionPtr)] GLFWErrorFunc errorFunc);
        [DllImport(GLFW_LIB)]
        public static extern IntPtr glfwCreateWindow([MarshalAs(UnmanagedType.I4)] int width, [MarshalAs(UnmanagedType.I4)] int height, [MarshalAs(UnmanagedType.LPStr)] string title, IntPtr monitor, IntPtr share);
        [DllImport(GLFW_LIB)]
        public static extern void glfwWindowHint([MarshalAs(UnmanagedType.I4)] int hint, [MarshalAs(UnmanagedType.I4)] int value);
        [DllImport(GLFW_LIB)]
        public static extern void glfwMakeContextCurrent(IntPtr window);
        [DllImport(GLFW_LIB)]
        [return: MarshalAs(UnmanagedType.I4)]
        public static extern int glfwWindowShouldClose(IntPtr window);
        [DllImport(GLFW_LIB)]
        public static extern void glfwDestroyWindow(IntPtr window);
        [DllImport(GLFW_LIB)]
        public static extern void glfwPollEvents();
        [DllImport(GLFW_LIB)]
        public static extern void glfwSwapBuffers(IntPtr window);
        [DllImport(GLFW_LIB)]
        [return: MarshalAs(UnmanagedType.FunctionPtr)]
        public static extern GLFWkeyfun glfwSetKeyCallback(IntPtr window, [MarshalAs(UnmanagedType.FunctionPtr)] GLFWkeyfun callback);
        [DllImport(GLFW_LIB)]
        public static extern void glfwGetFramebufferSize(IntPtr window, [MarshalAs(UnmanagedType.I4)] ref int width, [MarshalAs(UnmanagedType.I4)] ref int height);
        #endregion

        #region "GLUT Functions"
        [DllImport("glut")]
        public static extern void glutInit([MarshalAs(UnmanagedType.I4)] ref int argcp, [MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.LPStr)] string[] argv);
        #endregion

        #region "GL Functions"
#if WINDOWS
        public const string GL_LIB = "opengl32";
        public const string GLU_LIB = "opengl32";
#else
        public const string GL_LIB = "GL";
        public const string GLU_LIB = "GLU";
#endif
        public const int GL_PROJECTION = 5889;
        [DllImport(GL_LIB)]
        public static extern void glMatrixMode(int mode);
        [DllImport(GL_LIB)]
        public static extern void glLoadIdentity();
        [DllImport(GL_LIB)]
        public static extern void glViewport([MarshalAs(UnmanagedType.I4)] int x, [MarshalAs(UnmanagedType.I4)] int y, [MarshalAs(UnmanagedType.I4)] int width, [MarshalAs(UnmanagedType.I4)] int height);
        #endregion
    }
}
