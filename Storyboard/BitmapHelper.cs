using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Storyboard
{
    public static class BitmapHelper
    {
        public static Bitmap Resize(this Bitmap bpmToResize, Size size)
        {
            var sourceWidth = bpmToResize.Width;
            var sourceHeight = bpmToResize.Height;
            float nPercent = 0;
            float nPercentW = 0;
            float nPercentH = 0;
            nPercentW = ((float)size.Width / (float)sourceWidth);
            nPercentH = ((float)size.Height / (float)sourceHeight);
            nPercent = nPercentH < nPercentW ? nPercentH : nPercentW;
            var destWidth = (int)(sourceWidth * nPercent);
            var destHeight = (int)(sourceHeight * nPercent);
            var bitmap = new Bitmap(destWidth, destHeight);
            using var graphics = Graphics.FromImage((System.Drawing.Image)bitmap);
            graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
            graphics.DrawImage(bpmToResize, 0, 0, destWidth, destHeight);
            return bitmap;
        }
        public static Bitmap ResizeByWidth(this Bitmap bitmap, int newWidth)
        {
            var sizeRatio = newWidth / (double)bitmap.Width;
            var newHeight = (int)Math.Round(bitmap.Height * sizeRatio);
            var newSize = new Size(newWidth, newHeight);
            return bitmap.Resize(newSize);
        }
        public static Bitmap ResizeByHeight(this Bitmap bitmap, int newHeight)
        {
            var sizeRatio = newHeight / (double)bitmap.Height;
            var newWidth = (int)Math.Round(bitmap.Width * sizeRatio);
            var newSize = new Size(newWidth, newHeight);
            return bitmap.Resize(newSize);
        }
    }
}
