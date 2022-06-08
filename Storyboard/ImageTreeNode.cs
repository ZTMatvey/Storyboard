using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Storyboard
{
    public sealed class ImageTreeNode: ITreeNode
    {
        private readonly Bitmap _image;
        public ImageTreeNode(string filename)
        {
            _image = new Bitmap(filename);
        }
        public Bitmap Render()=> _image;
    }
}
