﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MVVMBuildProject.Model
{
    public class TextConverter
    {
        private readonly Func<string, string> _conversion;

        public TextConverter(Func<string, string> conversion)
        {
            _conversion = conversion;
        }

        public string ConvertText(string inputText)
        {
            return _conversion(inputText);
        }
    }
}
