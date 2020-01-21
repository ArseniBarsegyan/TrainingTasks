using MediaPlayer.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace MediaPlayer.Data.Classes
{
    public class Image : IMediaItem
    {
        public void Play()
        {
            Console.WriteLine("Showing image");
        }
    }
}
