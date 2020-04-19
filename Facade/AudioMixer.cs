using System;
using System.Collections.Generic;
using System.Text;

namespace Facade
{
    public class AudioMixer
    {
        public string IncreaseAudioQuality(string file)
        {
            return $"{file} with good audio quality";
        }
    }
}
