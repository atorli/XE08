using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XE08.Forms
{
    public partial class MainFrm : Form
    {
        public MainFrm()
        {
            InitializeComponent();
        }

        private void MainFrm_Load(object sender, EventArgs e)
        {
            var now = DateTime.Now;
            string date = now.ToString("yyyy.MM.dd");
            string time = now.ToString("HH:mm:ss");
            this.date_label.Text = date;
            this.time_label.Text = time;
        }

        private void refresh_timer_Tick(object sender, EventArgs e)
        {
            var now = DateTime.Now;
            string date = now.ToString("yyyy.MM.dd");
            string time = now.ToString("HH:mm:ss");
            this.date_label.Text = date;
            this.time_label.Text = time;
        }

        private void flow_dgv_CellMouseMove(object sender, DataGridViewCellMouseEventArgs e)
        {
            int i = e.RowIndex;
            int j = e.ColumnIndex;
            if( i == -1)
            {                
                flow_dgv.Columns[j].HeaderCell.Style.BackColor = Color.DarkBlue;
            }               
        }

        private void flow_dgv_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            int j = e.ColumnIndex;
            if(i == -1)
            {
                flow_dgv.Columns[j].HeaderCell.Style.BackColor = Color.DodgerBlue;
            }
        }
    }
}
