﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTimeDisplay
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime dt=DateTime.Now;
            Console.WriteLine(dt.FormatToString(1));
            Console.WriteLine(dt.FormatToString(7));
            // this not my rep 2
        }
    }
}
