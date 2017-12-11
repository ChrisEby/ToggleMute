using System;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace ToggleMute
{
    class Program
    {
        private const int AppCommandVolumeMute = 0x80000;
        private const int Message = 0x319;

        [DllImport("user32.dll")]
        public static extern IntPtr SendMessageW(IntPtr hWnd, int Msg, IntPtr wParam, IntPtr lParam);

        static void Main(string[] args)
        {
            var handle = Process.GetCurrentProcess().MainWindowHandle;
            
            Console.WriteLine("Toggling Mute");
            SendMessageW(handle, Message, handle, (IntPtr)AppCommandVolumeMute);
        }
    }
}