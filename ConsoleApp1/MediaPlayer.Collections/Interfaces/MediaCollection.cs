using MediaPlayer.Data.Interfaces;

using System.Collections.Generic;

namespace MediaPlayer.Collections.Interfaces
{
    public abstract class MediaCollection
    {
        public void Play(List<IMediaItem> list)
        {
            foreach(var item in list)
            {
                item.Play();
            }
        }
    }
}
