using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XE08.CustomControls
{
    public partial class SplitLine : UserControl
    {
        public SplitLine()
        {
            InitializeComponent();
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
           
            //GraphicsPath path = new GraphicsPath();
            //Point p1 = new Point(0, 0);
            //Point p2 = new Point(this.Width, this.Height);
            //path.AddLine(p1, p2);
            //pe.Graphics.SetClip(path);
            //using(SolidBrush brush = new SolidBrush(this.BackColor))
            //{
            //    pe.Graphics.FillPath(brush, path);
            //}
            base.OnPaint(pe);
        }
    }
}
