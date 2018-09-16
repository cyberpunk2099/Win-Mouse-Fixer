using System;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace WinMouseFixer
{
    public static class MouseInterceptor
    {
        internal static TimeSpan Delay = TimeSpan.FromMilliseconds(200.0);
        
        static readonly LowLevelMouseProc proc = HookCallback;
        static IntPtr hookID = IntPtr.Zero;
        static DateTime lastClicked = DateTime.MinValue;

        public static void Start()
        {
            if (hookID != IntPtr.Zero) return;
            hookID = SetHook(proc);
        }

        public static void Stop()
        {
            if (hookID == IntPtr.Zero) return;
            UnhookWindowsHookEx(hookID);
            hookID = IntPtr.Zero;
        }

        private static IntPtr SetHook(LowLevelMouseProc proc)
        {
            using (var process = Process.GetCurrentProcess())
            using (var module = process.MainModule)
            {
                return SetWindowsHookEx(
                    WH_MOUSE_LL,
                    proc,
                    GetModuleHandle(module.ModuleName),
                    0);
            }
        }

        delegate IntPtr LowLevelMouseProc(int nCode, IntPtr wParam, IntPtr lParam);

        static int fixCount = 0;

        public static Action<int> Fixed;

        static MouseMessages MSG_BUTTONDOWN = MouseMessages.WM_LBUTTONDOWN;

        public static bool TrackLeftButton
        {
            get { return MSG_BUTTONDOWN == MouseMessages.WM_LBUTTONDOWN; }
            set
            {
                MSG_BUTTONDOWN = value ? MouseMessages.WM_LBUTTONDOWN : MouseMessages.WM_RBUTTONDOWN;
            }
        }

        private static IntPtr HookCallback(int nCode, IntPtr wParam, IntPtr lParam)
        {
            if (nCode >= 0 && MSG_BUTTONDOWN == (MouseMessages)wParam)
            {
                var hook = (MSLLHOOKSTRUCT)Marshal.PtrToStructure(lParam, typeof(MSLLHOOKSTRUCT));
                var now = DateTime.Now;
                var prevClick = lastClicked;
                lastClicked = now;
                if (now - prevClick <= Delay)
                {
                    fixCount++;
                    Fixed?.Invoke(fixCount);
                    return new IntPtr(1);
                }
            }
            return CallNextHookEx(hookID, nCode, wParam, lParam);
        }

        private const int WH_MOUSE_LL = 14;

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern IntPtr SetWindowsHookEx(int idHook, LowLevelMouseProc lpfn, IntPtr hMod, uint dwThreadId);

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        private static extern bool UnhookWindowsHookEx(IntPtr hhk);

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern IntPtr CallNextHookEx(IntPtr hhk, int nCode, IntPtr wParam, IntPtr lParam);

        [DllImport("kernel32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
        private static extern IntPtr GetModuleHandle(string lpModuleName);

        enum MouseMessages
        {
            WM_LBUTTONDOWN = 0x0201,
            WM_LBUTTONUP   = 0x0202,
            WM_MOUSEMOVE   = 0x0200,
            WM_MOUSEWHEEL  = 0x020A,
            WM_RBUTTONDOWN = 0x0204,
            WM_RBUTTONUP   = 0x0205
        }

        [StructLayout(LayoutKind.Sequential)]
        struct POINT
        {
            public int x;
            public int y;
        }

        [StructLayout(LayoutKind.Sequential)]
        struct MSLLHOOKSTRUCT
        {
            public POINT pt;
            public uint mouseData;
            public uint flags;
            public uint time;
            public IntPtr dwExtraInfo;
        }
    }
}
