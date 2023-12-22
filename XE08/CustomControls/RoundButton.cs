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
    public partial class RoundButton : UserControl
    {
        public RoundButton()
        {
            InitializeComponent();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            GraphicsPath path = new GraphicsPath();
            path.AddEllipse(e.ClipRectangle);
            Region region = new Region(path);
            e.Graphics.SetClip(region, CombineMode.Replace);
            e.Graphics.FillPath(Brushes.Green, path);
        }

    }
}
