﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsDemo.AdapterPattern
{
    public class VlcPlayer : IAdvancedMediaPlayer
    {
        public void PlayVlc(string fileName)
        {
           Console.WriteLine("Playing vlc file. Name: " + fileName);

        }

        public void PlayMp4(string fileName)
        {
           // do nothing
        }
    }
}
