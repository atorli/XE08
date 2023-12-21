using System.Drawing.Drawing2D;
using System.Drawing;
using System.Windows.Forms;
using System.ComponentModel;

namespace XE08.CustomControls
{
    partial class DotLine
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // DotLine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "DotLine";
            this.Size = new System.Drawing.Size(118, 283);
            this.ResumeLayout(false);

        }
        #endregion

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
        [Browsable (true)]
        public Brush DotLineBrush { get; set; } = Brushes.DodgerBlue;
        
        /// <summary>
        /// 绘制点线
        /// </summary>
        /// <param name="e"></param>
        protected override void OnPaint(PaintEventArgs e)
        {
            int x = this.Width / 2;
            int y = 0;

            int nums = this.Height / (GapLen + DotLineLen);

            using (Pen pen = new Pen(DotLineBrush, DotLineWidth))
            {
                for (int i = 0; i < nums; i++)
                {
                    e.Graphics.DrawLine(pen, new Point(x, y), new Point(x, y += DotLineLen));
                    y += GapLen;
                }

                if(y < this.Height)
                {
                    e.Graphics.DrawLine(pen, new Point(x, y), new Point(x, this.Height));
                }
            }             
        }

    }
}
