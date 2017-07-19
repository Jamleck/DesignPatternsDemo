using System;

namespace DesignPatternsDemo.AdapterPattern
{
    public class MediaAdapter : IMediaPlayer
    {
        readonly IAdvancedMediaPlayer _advancedMusicPlayer;


        public MediaAdapter(string audioType)
        {
            if (audioType.Equals("vlc", StringComparison.InvariantCultureIgnoreCase))
            {
                _advancedMusicPlayer = new VlcPlayer();

            }
            else if (audioType.Equals("mp4", StringComparison.InvariantCultureIgnoreCase))
            {
                _advancedMusicPlayer = new Mp4Player();
            }
        }

        public void Play(string audioType, string fileName)
        {
            if (audioType.Equals("vlc", StringComparison.InvariantCultureIgnoreCase))
            {
                _advancedMusicPlayer.PlayVlc(fileName);

            }
            else if (audioType.Equals("mp4", StringComparison.InvariantCultureIgnoreCase))
            {
                _advancedMusicPlayer.PlayMp4(fileName);
            }
        }
    }
}