using MediaPlayer.Collections.Interfaces;
using MediaPlayer.Data.Classes;
using MediaPlayer.Data.Interfaces;
using System.Collections.Generic;

namespace MediaPlayer.Collections
{
    public class MediaDrive : IMediaCollection
    {
        private readonly List<IMediaItem> _mediaItems;

        public MediaDrive(IEnumerable<IMediaItem> mediaItems)
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
    }
}
