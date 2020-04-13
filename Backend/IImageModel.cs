﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backend
{
    public interface IImageModel
    {
        void Initialise(Image currentImage, IImageEditor imageEditor);
    }
}
