using MediaPlayer.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace MediaPlayer.Collections.Interfaces
{
    public interface IMediaCollection
    {
        void Play(List<IMediaItem> list);
    }
}
