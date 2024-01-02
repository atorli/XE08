using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XE08.CustomControls
{
    public class DataGridViewStateCell: DataGridViewTextBoxCell
    {
        protected override void Paint(Graphics graphics, Rectangle clipBounds, Rectangle cellBounds, int rowIndex, DataGridViewElementStates cellState, object value, object formattedValue, string errorText, DataGridViewCellStyle cellStyle, DataGridViewAdvancedBorderStyle advancedBorderStyle, DataGridViewPaintParts paintParts)
        {
            base.Paint(graphics, clipBounds, cellBounds, rowIndex, cellState, value, formattedValue, errorText, cellStyle, advancedBorderStyle, paintParts);
            graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;            
            int width = (cellBounds.Width < cellBounds.Height ? cellBounds.Width : cellBounds.Height)-2;
            using (SolidBrush brush = new SolidBrush(cellStyle.ForeColor))
            {
                graphics.FillEllipse(brush, new Rectangle(cellBounds.X + (cellBounds.Width / 2) - (width / 2), cellBounds.Y + (cellBounds.Height / 2) - (width / 2), width, width));
            }                
        }
    }
}
