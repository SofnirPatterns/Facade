using System;
using System.Collections.Generic;
using System.Text;

namespace Facade
{
    public class MPEG4Converter
    {
        public string Convert(string file)
        {
            return $"{file} as MPEG4 format";
        }
    }
}
