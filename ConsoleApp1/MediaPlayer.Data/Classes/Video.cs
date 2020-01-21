using MediaPlayer.Data.Interfaces;
using System;

namespace MediaPlayer.Data.Classes
{
    public class Video : IMediaItem
    {
        public void Play()
        {
            Console.WriteLine("Playing video");
        }
    }
}
