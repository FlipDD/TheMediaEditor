using System;
using System.Drawing;

namespace TheMediaEditor
{
    public class EditActions
    {
        public Action<Size> ResizeAction { get; set; }

        // DECLARE an Action<int> to store the action to be executed when the image is rotated, call it _rotateAction:
        public Action<int> RotateAction { get; set; }

        // DECLARE an Action<bool> to store the action to be executed when the image is flipped, call it _flipAction:
        public Action<bool> FlipAction { get; set; }

        // DECLARE an Action<int> to store the action to be executed when we apply contrast to the image, call it _contrastAction:
        public Action<int> ContrastAction { get; set; }

        // DECLARE an Action<int> to store the action to be executed when we apply brightness to the image, call it _brightnessAction:
        public Action<int> BrightnessAction { get; set; }

        // DECLARE an Action<int> to store the action to be executed when we apply saturation to the image, call it _saturationAction:
        public Action<int> SaturationAction { get; set; }

        // DECLARE an Action to be executed when we remove the filters of the image, call it _removeFilter:
        public Action RemoveFilter { get; set; }

        // DECLARE an Action to be executed when we apply a black and white filter to the image, call it _blackWhiteFilter:
        public Action BlackWhiteFilter { get; set; }

        // DECLARE an Action to be executed when we apply a comic filter to the image, call it _comicFilter:
        public Action ComicFilter { get; set; }

        // DECLARE an Action to be executed when we apply a lomography filter to the image, call it _lomoFilter:
        public Action LomoFilter { get; set; }

        // DECLARE an Action to be executed when we apply a sepia filter to the image, call it _sepiaFilter:
        public Action SepiaFilter { get; set; }

        // DECLARE an Action to be executed when we apply an invert filter to the image, call it _invertFilter:
        public Action InvertFilter { get; set; }

        // DECLARE an Action to be executed when we reset the edits applied to the image, call it _invertFilter:
        public Action ResetEdits { get; set; }
    }
}