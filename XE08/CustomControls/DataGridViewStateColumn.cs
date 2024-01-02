using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XE08.CustomControls
{
    public class DataGridViewStateColumn: DataGridViewColumn
    {
         public DataGridViewStateColumn()
        {
            this.CellTemplate = new DataGridViewStateCell();
        }
    }
}
