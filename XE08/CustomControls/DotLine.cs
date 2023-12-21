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
    public partial class DotLine : UserControl
    {
        public DotLine()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 间隙长度
        /// </summary>
        [Browsable(true)]
        public int GapLen { get; set; } = 5;

        /// <summary>
        /// 点线长度
        /// </summary>
        [Browsable(true)]
        public int DotLineLen { get; set; } = 15;

        /// <summary>
        /// 点线宽度
        /// </summary>
        [Browsable(true)]
        public int DotLineWidth { get; set; } = 3;

        /// <summary>
        /// 点线颜色
        /// </summary>
        [Browsable(true)]
        public Brush DotLineBrush { get; set; } = Brushes.DodgerBlue;

        /// <summary>
        /// 绘制点线
        /// </summary>
        /// <param name="e"></param>
        protected override void OnPaint(PaintEventArgs e)
        {
            int x = 0;
            int y = 0;

            int nums = this.Height / (GapLen + DotLineLen);

            using (Pen pen = new Pen(DotLineBrush, DotLineWidth))
            {
                for (int i = 0; i < nums; i++)
                {
                    e.Graphics.DrawLine(pen, new Point(x, y), new Point(x, y += DotLineLen));
                    y += GapLen;
                }

                if (y < this.Height)
                {
                    e.Graphics.DrawLine(pen, new Point(x, y), new Point(x, this.Height));
                }
            }
        } 
    }
}
