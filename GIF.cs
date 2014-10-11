using System;
using System.Drawing;
using System.Drawing.Imaging;

namespace GIF2WebM
{
    class GIF
    {
        public Image gif;
        FrameDimension dimension;
        public Int32 frame_count;

        public GIF(Image _gif)
        {
            // Set our variables for global use throughout the class
            gif = _gif;
            dimension = new FrameDimension(gif.FrameDimensionsList[0]);
            frame_count = gif.GetFrameCount(dimension);
        }

        public Image frame(int index)
        {
            // Select the active frame and then return
            // then clone the frame to return so we don't
            // send the one in the actual gif
            gif.SelectActiveFrame(dimension, index);
            return (Image)gif.Clone();
        }
    }
}
