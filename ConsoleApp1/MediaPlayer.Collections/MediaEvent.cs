using MediaPlayer.Data.Classes;
using MediaPlayer.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace MediaPlayer.Collections
{
    public class MediaEvent
    {
        private readonly List<IMediaItem> _mediaItems = new List<IMediaItem>();
        public MediaEvent(List<IMediaItem> mediaItems)
        {
            AddVideoAndAudioOnly(mediaItems);
        }
        public void Play()
        {
            foreach (var item in _mediaItems)
            {
                item.Play();
            }
        }
        private void AddVideoAndAudioOnly(List<IMediaItem> mediaItems)
        {
            foreach (var item in mediaItems)
            {
                if (item is Video video)
                {
                    _mediaItems.Add(video);
                }
                else if (item is Audio audio)
                {
                    _mediaItems.Add(audio);
                }
                else if (item is RemoteVideo rVideo)
                {
                    _mediaItems.Add(rVideo);
                }
                else if (item is RemoteAudio rAudio)
                {
                    _mediaItems.Add(rAudio);
                }
            }
        }
    }
}
