using System;

namespace DesignPatternsDemo.AdapterPattern
{
    public interface IAdvancedMediaPlayer
    {
        void PlayVlc(String fileName);
        void PlayMp4(String fileName);
    }
}