﻿using System;
using System.Runtime.InteropServices;

namespace NetCoreWapper
{
    public class NetCoreWap
    {
        [DllImport(@"DLLs\Demo.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern int Add(int a, int b);
    }
}
