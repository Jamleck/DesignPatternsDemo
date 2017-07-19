using System;

namespace DesignPatternsDemo.AdapterPattern
{
    public class AudioPlayer : IMediaPlayer
    {
        private MediaAdapter _mediaAdapter;

        public void Play(string audioType, string fileName)
        {
            //inbuilt support to play mp3 music files
            if (audioType.Equals("mp3", StringComparison.InvariantCultureIgnoreCase))
            {
                Console.WriteLine("Playing mp3 file. Name: " + fileName);
            }
            else if (audioType.Equals("vlc", StringComparison.CurrentCultureIgnoreCase) || audioType.Equals("mp4", StringComparison.CurrentCultureIgnoreCase))
            {
                _mediaAdapter = new MediaAdapter(audioType);
                _mediaAdapter.Play(audioType, fileName);
            }



        }
    }
}