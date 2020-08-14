using System.Diagnostics;
using System.Runtime.InteropServices;

namespace SafeKillMongo
{
    class Program
    {
        static void Main(string[] args)
        {
            int thisInt = int.Parse(args[0]);
            if(string.IsNullOrEmpty(thisInt.ToString()))
                return;
            FreeConsole();
            if(AttachConsole((uint)thisInt))
            {

                GenerateConsoleCtrlEvent(CtrlCEvent, 0);
            }
            AttachConsole((uint)Process.GetCurrentProcess().Id);
        }

        private const int CtrlCEvent = 0;
        [DllImport("kernel32.dll")]
        private static extern bool GenerateConsoleCtrlEvent(uint dwCtrlEvent, uint dwProcessGroupId);
        [DllImport("kernel32.dll", SetLastError = true)]
        private static extern bool AttachConsole(uint dwProcessId);
        [DllImport("kernel32.dll", SetLastError = true, ExactSpelling = true)]
        private static extern bool FreeConsole();

        // Delegate type to be used as the Handler Routine for SCCH
    }
}
