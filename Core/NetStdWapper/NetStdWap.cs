using System;

namespace NetStdWapper
{
    public class NetStdWap
    {
        [DllImport(@"DLLs\Demo.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern int Add(int a, int b);
    }
}
