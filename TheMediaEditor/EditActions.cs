using System;
using System.Drawing;

namespace TheMediaEditor
{
    public class EditActions
    {
        // DECLARE an Action<Size> to store the action to be executed when the image is resized, call it ResizeAction:
        public Action<Size> ResizeAction { get; set; }

        // DECLARE an Action<int> to store the action to be executed when the image is rotated, call it RotateAction:
        public Action<int> RotateAction { get; set; }

        // DECLARE an Action<bool> to store the action to be executed when the image is flipped, call it FlipAction:
        public Action<bool> FlipAction { get; set; }

        // DECLARE an Action<int> to store the action to be executed when we apply contrast to the image, call it ContrastAction:
        public Action<int> ContrastAction { get; set; }

        // DECLARE an Action<int> to store the action to be executed when we apply brightness to the image, call it BrightnessAction:
        public Action<int> BrightnessAction { get; set; }

        // DECLARE an Action<int> to store the action to be executed when we apply saturation to the image, call it SaturationAction:
        public Action<int> SaturationAction { get; set; }

        // DECLARE an Action to be executed when we remove the filters of the image, call it RemoveFilter:
        public Action RemoveFilter { get; set; }

        // DECLARE an Action to be executed when we apply a black and white filter to the image, call it BlackWhiteFilter:
        public Action BlackWhiteFilter { get; set; }

        // DECLARE an Action to be executed when we apply a comic filter to the image, call it ComicFilter:
        public Action ComicFilter { get; set; }

        // DECLARE an Action to be executed when we apply a lomography filter to the image, call it LomoFilter:
        public Action LomoFilter { get; set; }

        // DECLARE an Action to be executed when we apply a sepia filter to the image, call it SepiaFilter:
        public Action SepiaFilter { get; set; }

        // DECLARE an Action to be executed when we apply an invert filter to the image, call it InvertFilter:
        public Action InvertFilter { get; set; }

        // DECLARE an Action to be executed when we reset the edits applied to the image, call it InvertFilter:
        public Action ResetEdits { get; set; }
    }
}