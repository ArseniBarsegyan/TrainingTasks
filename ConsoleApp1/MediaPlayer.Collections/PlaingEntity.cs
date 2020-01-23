using MediaPlayer.Collections.Interfaces;
using MediaPlayer.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace MediaPlayer.Collections
{
    public  abstract class PlaingEntity: IMediaCollection
    {
        public void Play(List <IMediaItem> list)
        {
            foreach (var item in list)
            {
                item.Play();
            }
        }        
    }
}
