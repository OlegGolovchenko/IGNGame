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

                [DllImport("ignnatives")]
                public static extern IntPtr getGlutTimesNewRoman10();
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
                [DllImport("glut")]
                public static extern void glutBitmapString(IntPtr font, [MarshalAs(UnmanagedType.LPStr)] string text);
                #endregion

                #region "GL Functions"
#if WINDOWS
        public const string GL_LIB = "opengl32";
        public const string GLU_LIB = "opengl32";
#else
                public const string GL_LIB = "GL";
                public const string GLU_LIB = "GLU";
#endif
                public const uint GL_MATRIX_MODE = 0x0BA0;
                public const uint GL_MODELVIEW = 0x1700;
                public const uint GL_PROJECTION = 0x1701;
                public const uint GL_TEXTURE = 0x1702;

                [DllImport(GL_LIB)]
                public static extern void glMatrixMode([MarshalAs(UnmanagedType.U4)] uint mode);
                [DllImport(GL_LIB)]
                public static extern void glLoadIdentity();
                [DllImport(GL_LIB)]
                public static extern void glViewport([MarshalAs(UnmanagedType.I4)] int x, [MarshalAs(UnmanagedType.I4)] int y, [MarshalAs(UnmanagedType.I4)] int width, [MarshalAs(UnmanagedType.I4)] int height);
                [DllImport(GL_LIB)]
                public static extern void glOrtho(double left, double right, double bottom, double top, double nearVal, double farVal);
                [DllImport(GL_LIB)]
                public static extern void glClear([MarshalAs(UnmanagedType.I4)] uint mask);
                [DllImport(GL_LIB)]
                public static extern void glClearColor(float red, float green, float blue, float alpha);
                [DllImport(GL_LIB)]
                public static extern void glRasterPos2s(short x, short y);
                [DllImport(GL_LIB)]
                public static extern void glRasterPos2i(int x, int y);
                [DllImport(GL_LIB)]
                public static extern void glRasterPos2f(float x, float y);
                [DllImport(GL_LIB)]
                public static extern void glRasterPos2d(double x, double y);
                [DllImport(GL_LIB)]
                public static extern void glRasterPos3s(short x, short y, short z);
                [DllImport(GL_LIB)]
                public static extern void glRasterPos3i(int x, int y, int z);
                [DllImport(GL_LIB)]
                public static extern void glRasterPos3f(float x, float y, float z);
                [DllImport(GL_LIB)]
                public static extern void glRasterPos3d(double x, double y, double z);
                [DllImport(GL_LIB)]
                public static extern void glRasterPos4s(short x, short y, short z, short w);
                [DllImport(GL_LIB)]
                public static extern void glRasterPos4i(int x, int y, int z, int w);
                [DllImport(GL_LIB)]
                public static extern void glRasterPos4f(float x, float y, float z, float w);
                [DllImport(GL_LIB)]
                public static extern void glRasterPos4d(double x, double y, double z, double w);
                [DllImport(GL_LIB)]
                public static extern void glColor4f(float red, float green, float blue, float alpha);
                #endregion
        }
}
