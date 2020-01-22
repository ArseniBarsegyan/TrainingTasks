using MediaPlayer.Collections.Interfaces;
using MediaPlayer.Data.Classes;
using MediaPlayer.Data.Interfaces;
using System.Collections.Generic;

namespace MediaPlayer.Collections
{
    public class MediaDrive : IMediaCollection
    {
        private readonly List<IMediaItem> _mediaItems = new List<IMediaItem>();
        public MediaDrive(List<IMediaItem> mediaItems)
        {
            AddAudioAndImagesOnly(mediaItems);
        }

        public void Play()
        {
            foreach (var item in _mediaItems)
            {
                item.Play();
            }
        }

        private void AddAudioAndImagesOnly(List<IMediaItem> mediaItems)
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
    }
}
