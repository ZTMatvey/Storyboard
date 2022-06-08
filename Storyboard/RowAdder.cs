using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Storyboard
{
    public sealed class RowAdder: IBitmapAdder
    {
        public Bitmap AddBitmap(Bitmap sourceBitmap, Bitmap bitmapToAdd)
        {
            if (sourceBitmap == null)
                return bitmapToAdd.ResizeByHeight(bitmapToAdd.Height);
            var sourceHeight = sourceBitmap.Height;
            var resizedBitmapToAdd = bitmapToAdd.ResizeByHeight(sourceHeight);
            var result = new Bitmap(sourceBitmap.Width + resizedBitmapToAdd.Width, sourceHeight);
            using var graphics = Graphics.FromImage(result);
            graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
            graphics.DrawImage(sourceBitmap, 0, 0);
            graphics.DrawImage(resizedBitmapToAdd, sourceBitmap.Width, 0);
            return result;
        }
    }
}
