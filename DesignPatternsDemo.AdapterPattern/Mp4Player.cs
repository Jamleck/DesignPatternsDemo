using System;

namespace DesignPatternsDemo.AdapterPattern
{
    public class Mp4Player : IAdvancedMediaPlayer
    {
        public void PlayVlc(string fileName)
        {
            // do nothing
        }

        public void PlayMp4(string fileName)
        {
            Console.WriteLine("Playing mp4 file. Name: " + fileName);

        }
    }
}