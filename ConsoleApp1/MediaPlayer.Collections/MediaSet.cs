using MediaPlayer.Collections.Interfaces;
using MediaPlayer.Data.Classes;
using MediaPlayer.Data.Interfaces;
using System;
using System.Collections.Generic;

namespace MediaPlayer.Collections
{
    public class MediaSet : IMediaCollection
    {
        private List<IMediaItem> _mediaItems = new List<IMediaItem>();

        public MediaSet(IEnumerable<IMediaItem> mediaItems)
        {
            AddAudioAndImagesOnly(mediaItems);
        }

        private void AddAudioAndImagesOnly(IEnumerable<IMediaItem> mediaItems)
        {
            foreach (var item in mediaItems)
            {
                if (item is Audio audio)
                {
                    _mediaItems.Add(audio);
                }
                else if (item is Image image)
                {
                    _mediaItems.Add(image);
                }
            }
        }

        public void RewriteItems(IEnumerable<IMediaItem> mediaItems)
        {
            _mediaItems = new List<IMediaItem>();
            AddAudioAndImagesOnly(mediaItems);
            Console.WriteLine("MediaSet rewrited");
        }

        public void Play()
        {
            foreach (var item in _mediaItems)
            {
                item.Play();
            }
        }
    }
}
