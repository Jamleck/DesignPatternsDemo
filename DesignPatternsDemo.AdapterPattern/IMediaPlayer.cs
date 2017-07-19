using System;

namespace DesignPatternsDemo.AdapterPattern
{
    public interface IMediaPlayer
    {
        void Play(String audioType, String fileName);
    }
}