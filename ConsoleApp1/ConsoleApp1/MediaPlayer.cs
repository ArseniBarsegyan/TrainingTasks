using System;
using System.Collections.Generic;
using System.Text;
using MediaPlayer.Collections;
using MediaPlayer.Collections.Interfaces;

namespace ConsoleApp1
{
    public class MediaPlayer
    {
        public void PlayMedia (IMediaCollection mediaCollection)
        {
            mediaCollection.Play();
        }
    }
}
