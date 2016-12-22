﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.CSharp_and_dotNet
{
    class Program
    {
        static void Main()
        {
            /* 
             .NET is an umbrella term which comprises of FCL (Framework Class Library)
             and many languages(C#, VB.NET, C++/CLI,...),  which compiles source code 
             and outputs IL (Intermediate Language). IL will be consumed by CLR (Common Language Runtime)
             and converts it into platform specific code during runtime by the JIT (just-in-time) compiler.

             C# is a programming language using which you can develop software utilizing the FCL and 
             can target many platforms (Windows, Linux - using Mono, iOS - using Xamarin, ...)
             */
            string text = " ";
            File.WriteAllText("output.txt", text);

        }
    }
}
