﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Tranlator tranlator = new LowerAsUtf8Translator();
            tranlator.WordTranlator();
        }
    }
}
