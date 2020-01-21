using MediaPlayer.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace MediaPlayer.Data.Classes
{
    public class RemoteImage : IMediaItem
    {
        public void Play()
        {
            Console.WriteLine("Downloading and showing image");
        }
    }
}
