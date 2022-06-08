using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Storyboard
{
    public sealed class ColumnAdder: IBitmapAdder
    {
        public Bitmap AddBitmap(Bitmap sourceBitmap, Bitmap bitmapToAdd)
        {
            if (sourceBitmap == null)
                return bitmapToAdd.ResizeByWidth(bitmapToAdd.Width);
            var sourceWidth = sourceBitmap.Width;
            var resizedBitmapToAdd = bitmapToAdd.ResizeByWidth(sourceWidth);
            var result = new Bitmap(sourceWidth, sourceBitmap.Height + resizedBitmapToAdd.Height);
            using var graphics = Graphics.FromImage(result);
            graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
            graphics.DrawImage(sourceBitmap, 0, 0);
            graphics.DrawImage(resizedBitmapToAdd, 0, sourceBitmap.Height);
            return result;
        }
    }
}
