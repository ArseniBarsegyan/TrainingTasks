using MediaPlayer.Collections.Interfaces;
using MediaPlayer.Data.Classes;
using MediaPlayer.Data.Interfaces;

using System.Collections.Generic;

namespace MediaPlayer.Collections
{
    public class MediaSeries: MediaCollection
    {
        private readonly List<IMediaItem> _mediaItems = new List<IMediaItem>();
        public MediaSeries (List<IMediaItem> mediaItems)
        {
            AddVideoAndImagesOnly(mediaItems);
        }
        private void AddVideoAndImagesOnly(List<IMediaItem> mediaItems)
        {
            foreach (var item in mediaItems)
            {
                if (item is Video video)
                {
                    _mediaItems.Add(video);
                }
                else if (item is Image image)
                {
                    _mediaItems.Add(image);
                }
            }
        }
    }
}
