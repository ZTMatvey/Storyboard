using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Storyboard
{
    public partial class Storyboarad : Form
    {
        private static readonly int W = 600;
        public Storyboarad()
        {
            InitializeComponent();
            Shown += (o, e) =>
            {
                DirectionalTreeNode directional = new DirectionalTreeNode(Enumerations.Direction.Row);
                directional.Add(new ImageTreeNode("../../../Assets/pics/1.jpg"));
                var second = new DirectionalTreeNode(Enumerations.Direction.Column);
                second.Add(new ImageTreeNode("../../../Assets/pics/3.jpg"));
                var third = new DirectionalTreeNode(Enumerations.Direction.Row);
                third.Add(new ImageTreeNode("../../../Assets/pics/5.jpg"));
                third.Add(new ImageTreeNode("../../../Assets/pics/6.jpg"));
                second.Add(third);
                second.Add(new ImageTreeNode("../../../Assets/pics/4.jpg"));
                directional.Add(second);
                directional.Add(new ImageTreeNode("../../../Assets/pics/2.jpg"));
                var another = new DirectionalTreeNode(Enumerations.Direction.Column);
                another.Add(new ImageTreeNode("../../../Assets/pics/7.jpg"));
                another.Add(new ImageTreeNode("../../../Assets/pics/8.jpg"));
                directional.Add(another);
                pictureBox1.Image = directional.Render().ResizeByWidth(W);
            };
        }
        
    }
}
