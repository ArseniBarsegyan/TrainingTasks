using MediaPlayer.Data.Interfaces;
using System;

namespace MediaPlayer.Data.Classes
{
    public class Audio : IMediaItem
    {
        public void Play()
        {
            Console.WriteLine("Playing audio");
        }
    }
}
