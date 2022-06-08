using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Storyboard
{
    public sealed class DirectionalTreeNode: ITreeNode
    {
        private readonly IBitmapAdder _adder;
        public readonly Enumerations.Direction Direction;
        private List<ITreeNode> _elements = new();
        public DirectionalTreeNode(Enumerations.Direction direction)
        {
            Direction = direction;
            switch (direction)
            {
                case Enumerations.Direction.Row:
                    _adder = new RowAdder();
                    break;
                case Enumerations.Direction.Column:
                    _adder = new ColumnAdder();
                    break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(direction), direction, null);
            }
        }

        public void Add(ITreeNode treeNode)=> _elements.Add(treeNode);
        public Bitmap Render()
        {
            Bitmap previousResult = null;
            foreach (var element in _elements)
                previousResult = _adder.AddBitmap(previousResult, element.Render());
            return previousResult;
        }
    }
}
