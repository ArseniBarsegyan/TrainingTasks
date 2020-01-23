using MediaPlayer.Collections;
using MediaPlayer.Collections.Interfaces;
using MediaPlayer.Data.Classes;
using MediaPlayer.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    /// <summary>
    /// 1. Разобраться что происходит
    /// 2. Дописать MediaEvent и MediaSeries
    /// 3. Написать класс MediaPlayer в ConsoleApp1.
    /// 4. В методе Main продемонстрировать работу плеера
    /// (создать разные коллекции, айтемы для них и проиграть их в плеере)
    /// </summary>
    public class Program
    {
        public static void Main(string[] args)
        {
            List<IMediaItem> mediaList = new List<IMediaItem>();
            IMediaItem audio1 = new Audio();                     
            IMediaItem image1 = new Image(); 
            IMediaItem audio2 = new Audio();
            mediaList.Add(audio1); mediaList.Add(image1); mediaList.Add(audio1);
            IMediaCollection mediaDrive = new MediaDrive(mediaList);
            MediaPlayer mediaPlayer = new MediaPlayer();
            mediaPlayer.PlayMedia(mediaDrive, mediaList);

            Console.ReadKey();
        }
    }
}
