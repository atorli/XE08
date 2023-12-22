using System.Drawing;
using System.Windows.Forms;

namespace XE08.Forms
{
    partial class MainFrm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainFrm));
            this.header = new System.Windows.Forms.Panel();
            this.header_tab_layout = new System.Windows.Forms.TableLayoutPanel();
            this.header_lab = new System.Windows.Forms.Label();
            this.header_right = new System.Windows.Forms.TableLayoutPanel();
            this.time_label = new System.Windows.Forms.Label();
            this.date_label = new System.Windows.Forms.Label();
            this.logo = new System.Windows.Forms.PictureBox();
            this.body = new System.Windows.Forms.Panel();
            this.body_tab_layout = new System.Windows.Forms.TableLayoutPanel();
            this.body_right_tab_layout = new System.Windows.Forms.TableLayoutPanel();
            this.flow_dgv = new System.Windows.Forms.DataGridView();
            this.check_flow_col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.check_item_col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status_col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.right_top_panel = new System.Windows.Forms.Panel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.label5 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.dotLine1 = new XE08.CustomControls.DotLine();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.splitLine1 = new XE08.CustomControls.SplitLine();
            this.title_label = new System.Windows.Forms.Label();
            this.header_split_line = new XE08.CustomControls.SplitLine();
            this.refresh_timer = new System.Windows.Forms.Timer(this.components);
            this.header.SuspendLayout();
            this.header_tab_layout.SuspendLayout();
            this.header_right.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.body.SuspendLayout();
            this.body_tab_layout.SuspendLayout();
            this.body_right_tab_layout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.flow_dgv)).BeginInit();
            this.right_top_panel.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // header
            // 
            this.header.BackColor = System.Drawing.Color.Transparent;
            this.header.Controls.Add(this.header_tab_layout);
            this.header.Dock = System.Windows.Forms.DockStyle.Top;
            this.header.Font = new System.Drawing.Font("Microsoft YaHei", 42F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.header.Location = new System.Drawing.Point(0, 0);
            this.header.Margin = new System.Windows.Forms.Padding(0);
            this.header.Name = "header";
            this.header.Padding = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.header.Size = new System.Drawing.Size(1182, 114);
            this.header.TabIndex = 0;
            // 
            // header_tab_layout
            // 
            this.header_tab_layout.BackColor = System.Drawing.Color.Transparent;
            this.header_tab_layout.ColumnCount = 3;
            this.header_tab_layout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.header_tab_layout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.header_tab_layout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.header_tab_layout.Controls.Add(this.header_lab, 1, 0);
            this.header_tab_layout.Controls.Add(this.header_right, 2, 0);
            this.header_tab_layout.Controls.Add(this.logo, 0, 0);
            this.header_tab_layout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.header_tab_layout.Location = new System.Drawing.Point(0, 3);
            this.header_tab_layout.Margin = new System.Windows.Forms.Padding(0);
            this.header_tab_layout.Name = "header_tab_layout";
            this.header_tab_layout.RowCount = 1;
            this.header_tab_layout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.header_tab_layout.Size = new System.Drawing.Size(1182, 108);
            this.header_tab_layout.TabIndex = 0;
            // 
            // header_lab
            // 
            this.header_lab.BackColor = System.Drawing.Color.Transparent;
            this.header_lab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.header_lab.Font = new System.Drawing.Font("Microsoft YaHei", 38F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.header_lab.ForeColor = System.Drawing.Color.DodgerBlue;
            this.header_lab.Location = new System.Drawing.Point(295, 0);
            this.header_lab.Margin = new System.Windows.Forms.Padding(0);
            this.header_lab.Name = "header_lab";
            this.header_lab.Size = new System.Drawing.Size(591, 108);
            this.header_lab.TabIndex = 0;
            this.header_lab.Text = "XE08线末检测器";
            this.header_lab.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // header_right
            // 
            this.header_right.ColumnCount = 1;
            this.header_right.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.header_right.Controls.Add(this.time_label, 0, 1);
            this.header_right.Controls.Add(this.date_label, 0, 0);
            this.header_right.Dock = System.Windows.Forms.DockStyle.Fill;
            this.header_right.Font = new System.Drawing.Font("Microsoft YaHei", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.header_right.Location = new System.Drawing.Point(886, 0);
            this.header_right.Margin = new System.Windows.Forms.Padding(0);
            this.header_right.Name = "header_right";
            this.header_right.RowCount = 2;
            this.header_right.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.header_right.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.header_right.Size = new System.Drawing.Size(296, 108);
            this.header_right.TabIndex = 1;
            // 
            // time_label
            // 
            this.time_label.Dock = System.Windows.Forms.DockStyle.Fill;
            this.time_label.Font = new System.Drawing.Font("Microsoft YaHei", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.time_label.Location = new System.Drawing.Point(0, 54);
            this.time_label.Margin = new System.Windows.Forms.Padding(0);
            this.time_label.Name = "time_label";
            this.time_label.Size = new System.Drawing.Size(296, 54);
            this.time_label.TabIndex = 1;
            this.time_label.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // date_label
            // 
            this.date_label.Dock = System.Windows.Forms.DockStyle.Fill;
            this.date_label.Font = new System.Drawing.Font("Microsoft YaHei", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.date_label.Location = new System.Drawing.Point(0, 0);
            this.date_label.Margin = new System.Windows.Forms.Padding(0);
            this.date_label.Name = "date_label";
            this.date_label.Size = new System.Drawing.Size(296, 54);
            this.date_label.TabIndex = 0;
            this.date_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // logo
            // 
            this.logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.logo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.logo.Image = global::XE08.Properties.Resources.LOGO;
            this.logo.Location = new System.Drawing.Point(30, 0);
            this.logo.Margin = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(265, 108);
            this.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logo.TabIndex = 2;
            this.logo.TabStop = false;
            // 
            // body
            // 
            this.body.Controls.Add(this.body_tab_layout);
            this.body.Controls.Add(this.header_split_line);
            this.body.Dock = System.Windows.Forms.DockStyle.Fill;
            this.body.Location = new System.Drawing.Point(0, 114);
            this.body.Margin = new System.Windows.Forms.Padding(0);
            this.body.Name = "body";
            this.body.Size = new System.Drawing.Size(1182, 639);
            this.body.TabIndex = 1;
            // 
            // body_tab_layout
            // 
            this.body_tab_layout.ColumnCount = 2;
            this.body_tab_layout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 55F));
            this.body_tab_layout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45F));
            this.body_tab_layout.Controls.Add(this.body_right_tab_layout, 1, 0);
            this.body_tab_layout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.body_tab_layout.Location = new System.Drawing.Point(0, 3);
            this.body_tab_layout.Margin = new System.Windows.Forms.Padding(0);
            this.body_tab_layout.Name = "body_tab_layout";
            this.body_tab_layout.RowCount = 1;
            this.body_tab_layout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.body_tab_layout.Size = new System.Drawing.Size(1182, 636);
            this.body_tab_layout.TabIndex = 1;
            // 
            // body_right_tab_layout
            // 
            this.body_right_tab_layout.ColumnCount = 1;
            this.body_right_tab_layout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.body_right_tab_layout.Controls.Add(this.flow_dgv, 0, 1);
            this.body_right_tab_layout.Controls.Add(this.right_top_panel, 0, 0);
            this.body_right_tab_layout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.body_right_tab_layout.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.body_right_tab_layout.Location = new System.Drawing.Point(650, 0);
            this.body_right_tab_layout.Margin = new System.Windows.Forms.Padding(0);
            this.body_right_tab_layout.Name = "body_right_tab_layout";
            this.body_right_tab_layout.RowCount = 2;
            this.body_right_tab_layout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.body_right_tab_layout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.body_right_tab_layout.Size = new System.Drawing.Size(532, 636);
            this.body_right_tab_layout.TabIndex = 0;
            // 
            // flow_dgv
            // 
            this.flow_dgv.AllowUserToAddRows = false;
            this.flow_dgv.AllowUserToDeleteRows = false;
            this.flow_dgv.BackgroundColor = System.Drawing.SystemColors.Control;
            this.flow_dgv.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.flow_dgv.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.flow_dgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.flow_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.flow_dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.check_flow_col,
            this.check_item_col,
            this.status_col});
            this.flow_dgv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flow_dgv.EnableHeadersVisualStyles = false;
            this.flow_dgv.GridColor = System.Drawing.Color.White;
            this.flow_dgv.Location = new System.Drawing.Point(0, 318);
            this.flow_dgv.Margin = new System.Windows.Forms.Padding(0);
            this.flow_dgv.Name = "flow_dgv";
            this.flow_dgv.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.flow_dgv.RowHeadersVisible = false;
            this.flow_dgv.RowHeadersWidth = 51;
            this.flow_dgv.RowTemplate.Height = 23;
            this.flow_dgv.Size = new System.Drawing.Size(532, 318);
            this.flow_dgv.TabIndex = 0;
            this.flow_dgv.CellMouseLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.flow_dgv_CellMouseLeave);
            this.flow_dgv.CellMouseMove += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.flow_dgv_CellMouseMove);
            // 
            // check_flow_col
            // 
            this.check_flow_col.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.check_flow_col.HeaderText = "检测流程";
            this.check_flow_col.MinimumWidth = 6;
            this.check_flow_col.Name = "check_flow_col";
            this.check_flow_col.ReadOnly = true;
            // 
            // check_item_col
            // 
            this.check_item_col.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.check_item_col.HeaderText = "检测项";
            this.check_item_col.MinimumWidth = 6;
            this.check_item_col.Name = "check_item_col";
            this.check_item_col.ReadOnly = true;
            // 
            // status_col
            // 
            this.status_col.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.status_col.HeaderText = "状态";
            this.status_col.MinimumWidth = 6;
            this.status_col.Name = "status_col";
            this.status_col.ReadOnly = true;
            // 
            // right_top_panel
            // 
            this.right_top_panel.Controls.Add(this.tableLayoutPanel4);
            this.right_top_panel.Controls.Add(this.tableLayoutPanel1);
            this.right_top_panel.Controls.Add(this.flowLayoutPanel1);
            this.right_top_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.right_top_panel.Location = new System.Drawing.Point(0, 0);
            this.right_top_panel.Margin = new System.Windows.Forms.Padding(0);
            this.right_top_panel.Name = "right_top_panel";
            this.right_top_panel.Size = new System.Drawing.Size(532, 318);
            this.right_top_panel.TabIndex = 1;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 3;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 112F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Controls.Add(this.label4, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.tableLayoutPanel5, 2, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(0, 268);
            this.tableLayoutPanel4.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(532, 50);
            this.tableLayoutPanel4.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Location = new System.Drawing.Point(43, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 50);
            this.label4.TabIndex = 0;
            this.label4.Text = "标签信息:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 1;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.Controls.Add(this.label5, 0, 1);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(152, 0);
            this.tableLayoutPanel5.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 3;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(380, 50);
            this.tableLayoutPanel5.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Location = new System.Drawing.Point(0, 12);
            this.label5.Margin = new System.Windows.Forms.Padding(0, 0, 40, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(340, 25);
            this.label5.TabIndex = 0;
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 3F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.dotLine1, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 71);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(532, 197);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 112F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.label1, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.label2, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.label3, 1, 2);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(264, 197);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(43, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 65);
            this.label1.TabIndex = 0;
            this.label1.Text = "上升时间:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(43, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 65);
            this.label2.TabIndex = 1;
            this.label2.Text = "上升电流:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(43, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 67);
            this.label3.TabIndex = 2;
            this.label3.Text = "交付位置:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(267, 0);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(265, 197);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // dotLine1
            // 
            this.dotLine1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dotLine1.DotLineLen = 15;
            this.dotLine1.DotLineWidth = 3;
            this.dotLine1.GapLen = 5;
            this.dotLine1.Location = new System.Drawing.Point(264, 0);
            this.dotLine1.Margin = new System.Windows.Forms.Padding(0);
            this.dotLine1.Name = "dotLine1";
            this.dotLine1.Size = new System.Drawing.Size(3, 197);
            this.dotLine1.TabIndex = 2;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.splitLine1);
            this.flowLayoutPanel1.Controls.Add(this.title_label);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.BottomUp;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(532, 71);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // splitLine1
            // 
            this.splitLine1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.splitLine1.BackColor = System.Drawing.Color.Orange;
            this.splitLine1.Location = new System.Drawing.Point(3, 65);
            this.splitLine1.Name = "splitLine1";
            this.splitLine1.Size = new System.Drawing.Size(170, 3);
            this.splitLine1.TabIndex = 1;
            // 
            // title_label
            // 
            this.title_label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.title_label.Font = new System.Drawing.Font("Microsoft YaHei", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.title_label.ForeColor = System.Drawing.Color.Orange;
            this.title_label.Location = new System.Drawing.Point(0, 12);
            this.title_label.Margin = new System.Windows.Forms.Padding(0);
            this.title_label.Name = "title_label";
            this.title_label.Size = new System.Drawing.Size(230, 50);
            this.title_label.TabIndex = 0;
            this.title_label.Text = "测试数据：";
            this.title_label.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // header_split_line
            // 
            this.header_split_line.BackColor = System.Drawing.Color.DodgerBlue;
            this.header_split_line.Dock = System.Windows.Forms.DockStyle.Top;
            this.header_split_line.Location = new System.Drawing.Point(0, 0);
            this.header_split_line.Name = "header_split_line";
            this.header_split_line.Size = new System.Drawing.Size(1182, 3);
            this.header_split_line.TabIndex = 0;
            // 
            // refresh_timer
            // 
            this.refresh_timer.Enabled = true;
            this.refresh_timer.Interval = 950;
            this.refresh_timer.Tick += new System.EventHandler(this.refresh_timer_Tick);
            // 
            // MainFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1182, 753);
            this.Controls.Add(this.body);
            this.Controls.Add(this.header);
            this.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "MainFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "XE08线末检机";
            this.Load += new System.EventHandler(this.MainFrm_Load);
            this.header.ResumeLayout(false);
            this.header_tab_layout.ResumeLayout(false);
            this.header_right.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.body.ResumeLayout(false);
            this.body_tab_layout.ResumeLayout(false);
            this.body_right_tab_layout.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.flow_dgv)).EndInit();
            this.right_top_panel.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel header;
        private System.Windows.Forms.Label header_lab;
        private System.Windows.Forms.TableLayoutPanel header_tab_layout;
        private System.Windows.Forms.TableLayoutPanel header_right;
        private System.Windows.Forms.Label date_label;
        private System.Windows.Forms.Label time_label;
        private System.Windows.Forms.Panel body;
        private CustomControls.SplitLine header_split_line;
        private System.Windows.Forms.TableLayoutPanel body_tab_layout;
        private System.Windows.Forms.TableLayoutPanel body_right_tab_layout;
        private System.Windows.Forms.DataGridView flow_dgv;
        private System.Windows.Forms.Label title_label;
        private CustomControls.SplitLine splitLine1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Timer refresh_timer;
        private System.Windows.Forms.Panel right_top_panel;
        private System.Windows.Forms.PictureBox logo;
        private DataGridViewTextBoxColumn check_flow_col;
        private DataGridViewTextBoxColumn check_item_col;
        private DataGridViewTextBoxColumn status_col;
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private TableLayoutPanel tableLayoutPanel3;
        private CustomControls.DotLine dotLine1;
        private Label label1;
        private Label label2;
        private Label label3;
        private TableLayoutPanel tableLayoutPanel4;
        private Label label4;
        private TableLayoutPanel tableLayoutPanel5;
        private Label label5;
    }
}

