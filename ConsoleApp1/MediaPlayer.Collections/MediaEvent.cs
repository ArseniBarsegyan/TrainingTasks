using MediaPlayer.Data.Classes;
using MediaPlayer.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace MediaPlayer.Collections
{
    public class MediaEvent : PlaingEntity
    {
        private readonly List<IMediaItem> _mediaItems = new List<IMediaItem>();
        public MediaEvent(List<IMediaItem> mediaItems)
        {
            AddVideoAndAudioOnly(mediaItems);
        }
        private void AddVideoAndAudioOnly(List<IMediaItem> mediaItems)
        {
            foreach (var item in mediaItems)
            {
                switch (item)
                {
                    case Video video:
                        _mediaItems.Add(video);
                        break;
                    case Audio audio:
                        _mediaItems.Add(audio);
                        break;
                    case RemoteVideo rVideo:
                        _mediaItems.Add(rVideo);
                        break;
                    case RemoteAudio rAudio:
                        _mediaItems.Add(rAudio);
                        break;
                }
            }
        }
    }
}
