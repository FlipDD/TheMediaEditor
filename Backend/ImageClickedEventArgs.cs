﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backend
{
    public class ImageClickedEventArgs : EventArgs
    {
        public int index { get; }

        public ImageClickedEventArgs(int index)
        {
            this.index = index;
        }
    }
}
