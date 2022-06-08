using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Storyboard
{
    public interface IBitmapAdder
    {
        Bitmap AddBitmap(Bitmap sourceBitmap, Bitmap bitmapToAdd);
    }
}
