using MediaPlayer.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace MediaPlayer.Data.Classes
{
    public class RemoteVideo : IMediaItem
    {
        public void Play()
        {
            Console.WriteLine("Downloading and playing video");
        }
    }
}
