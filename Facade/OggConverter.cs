using System;
using System.Collections.Generic;
using System.Text;

namespace Facade
{
    public class OggConverter
    {
        public string Convert(string file)
        {
            return $"{file} as Ogg format";
        }
    }
}
