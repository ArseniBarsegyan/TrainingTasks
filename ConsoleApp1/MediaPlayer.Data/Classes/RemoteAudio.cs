using MediaPlayer.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace MediaPlayer.Data.Classes
{
    public class RemoteAudio : IMediaItem
    {
        public void Play()
        {
            Console.WriteLine("Downloading and playing audio");
        }
    }
}
