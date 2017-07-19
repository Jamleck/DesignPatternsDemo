﻿using System;
using DesignPatternsDemo.Core;

namespace DesignPatternsDemo.AdapterPattern
{
    public class AdapterPatternDemo : IDemo
    {
        public void Demo()
        {
            Console.WriteLine("Adapter pattern demo...");
            var audioPlayer = new AudioPlayer();

            audioPlayer.Play("mp3", "beyond the horizon.mp3");
            audioPlayer.Play("mp4", "alone.mp4");
            audioPlayer.Play("vlc", "far far away.vlc");
            audioPlayer.Play("avi", "mind me.avi");
        }
    }
}