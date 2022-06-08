using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Storyboard
{
    public struct Padding
    {
        private int _top;
        private int _bottom;
        private int _left;
        private int _right;
        public int Top => _top;
        public int Bottom => _bottom;
        public int Left => _left;
        public int Right => _right;

        public Padding(int x): this()
        {
            _top = _bottom = _left = _right = x;
        }

        public Padding(int top, int bottom, int left, int right) : this()
        {
            _top = top;
            _bottom = bottom;
            _left = left;
            _right = right;
        }
    }
}
