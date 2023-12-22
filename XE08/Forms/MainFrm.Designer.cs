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
            this.tableLayoutPanel15 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.label5 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel8 = new System.Windows.Forms.TableLayoutPanel();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel11 = new System.Windows.Forms.TableLayoutPanel();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.tableLayoutPanel9 = new System.Windows.Forms.TableLayoutPanel();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.tableLayoutPanel10 = new System.Windows.Forms.TableLayoutPanel();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.tableLayoutPanel12 = new System.Windows.Forms.TableLayoutPanel();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.tableLayoutPanel13 = new System.Windows.Forms.TableLayoutPanel();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.tableLayoutPanel14 = new System.Windows.Forms.TableLayoutPanel();
            this.label24 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.tableLayoutPanel16 = new System.Windows.Forms.TableLayoutPanel();
            this.title_label = new System.Windows.Forms.Label();
            this.tableLayoutPanel17 = new System.Windows.Forms.TableLayoutPanel();
            this.refresh_timer = new System.Windows.Forms.Timer(this.components);
            this.label26 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.dotLine1 = new XE08.CustomControls.DotLine();
            this.splitLine1 = new XE08.CustomControls.SplitLine();
            this.header_split_line = new XE08.CustomControls.SplitLine();
            this.panel1 = new System.Windows.Forms.Panel();
            this.header.SuspendLayout();
            this.header_tab_layout.SuspendLayout();
            this.header_right.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.body.SuspendLayout();
            this.body_tab_layout.SuspendLayout();
            this.body_right_tab_layout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.flow_dgv)).BeginInit();
            this.tableLayoutPanel15.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel8.SuspendLayout();
            this.tableLayoutPanel7.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel11.SuspendLayout();
            this.tableLayoutPanel9.SuspendLayout();
            this.tableLayoutPanel10.SuspendLayout();
            this.tableLayoutPanel12.SuspendLayout();
            this.tableLayoutPanel13.SuspendLayout();
            this.tableLayoutPanel14.SuspendLayout();
            this.tableLayoutPanel16.SuspendLayout();
            this.tableLayoutPanel17.SuspendLayout();
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
            this.body_tab_layout.Controls.Add(this.panel1, 0, 0);
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
            this.body_right_tab_layout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.body_right_tab_layout.Controls.Add(this.flow_dgv, 0, 1);
            this.body_right_tab_layout.Controls.Add(this.tableLayoutPanel15, 0, 0);
            this.body_right_tab_layout.Controls.Add(this.tableLayoutPanel17, 0, 2);
            this.body_right_tab_layout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.body_right_tab_layout.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.body_right_tab_layout.Location = new System.Drawing.Point(650, 0);
            this.body_right_tab_layout.Margin = new System.Windows.Forms.Padding(0);
            this.body_right_tab_layout.Name = "body_right_tab_layout";
            this.body_right_tab_layout.RowCount = 3;
            this.body_right_tab_layout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 44.44444F));
            this.body_right_tab_layout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 44.44444F));
            this.body_right_tab_layout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.body_right_tab_layout.Size = new System.Drawing.Size(532, 636);
            this.body_right_tab_layout.TabIndex = 0;
            // 
            // flow_dgv
            // 
            this.flow_dgv.AllowUserToAddRows = false;
            this.flow_dgv.AllowUserToDeleteRows = false;
            this.flow_dgv.BackgroundColor = System.Drawing.SystemColors.Control;
            this.flow_dgv.BorderStyle = System.Windows.Forms.BorderStyle.None;
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
            this.flow_dgv.Location = new System.Drawing.Point(0, 282);
            this.flow_dgv.Margin = new System.Windows.Forms.Padding(0);
            this.flow_dgv.Name = "flow_dgv";
            this.flow_dgv.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.flow_dgv.RowHeadersVisible = false;
            this.flow_dgv.RowHeadersWidth = 51;
            this.flow_dgv.RowTemplate.Height = 23;
            this.flow_dgv.Size = new System.Drawing.Size(532, 282);
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
            // tableLayoutPanel15
            // 
            this.tableLayoutPanel15.ColumnCount = 1;
            this.tableLayoutPanel15.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel15.Controls.Add(this.tableLayoutPanel4, 0, 2);
            this.tableLayoutPanel15.Controls.Add(this.tableLayoutPanel1, 0, 1);
            this.tableLayoutPanel15.Controls.Add(this.tableLayoutPanel16, 0, 0);
            this.tableLayoutPanel15.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel15.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel15.Name = "tableLayoutPanel15";
            this.tableLayoutPanel15.RowCount = 3;
            this.tableLayoutPanel15.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel15.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 65F));
            this.tableLayoutPanel15.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel15.Size = new System.Drawing.Size(526, 276);
            this.tableLayoutPanel15.TabIndex = 1;
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
            this.tableLayoutPanel4.Location = new System.Drawing.Point(0, 234);
            this.tableLayoutPanel4.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(526, 42);
            this.tableLayoutPanel4.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Location = new System.Drawing.Point(43, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 42);
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
            this.tableLayoutPanel5.Size = new System.Drawing.Size(374, 42);
            this.tableLayoutPanel5.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Location = new System.Drawing.Point(0, 8);
            this.label5.Margin = new System.Windows.Forms.Padding(0, 0, 40, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(334, 25);
            this.label5.TabIndex = 0;
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 1F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.dotLine1, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 55);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(526, 179);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 112F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel8, 2, 3);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel7, 2, 2);
            this.tableLayoutPanel2.Controls.Add(this.label1, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.label2, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.label3, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel6, 2, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 4;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(262, 179);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // tableLayoutPanel8
            // 
            this.tableLayoutPanel8.ColumnCount = 2;
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableLayoutPanel8.Controls.Add(this.label10, 0, 1);
            this.tableLayoutPanel8.Controls.Add(this.label11, 1, 1);
            this.tableLayoutPanel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel8.Location = new System.Drawing.Point(152, 128);
            this.tableLayoutPanel8.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel8.Name = "tableLayoutPanel8";
            this.tableLayoutPanel8.RowCount = 3;
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel8.Size = new System.Drawing.Size(110, 51);
            this.tableLayoutPanel8.TabIndex = 4;
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label10.Location = new System.Drawing.Point(0, 10);
            this.label10.Margin = new System.Windows.Forms.Padding(0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(65, 30);
            this.label10.TabIndex = 0;
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            this.label11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label11.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label11.Location = new System.Drawing.Point(65, 10);
            this.label11.Margin = new System.Windows.Forms.Padding(0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(45, 30);
            this.label11.TabIndex = 1;
            this.label11.Text = "mm";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel7
            // 
            this.tableLayoutPanel7.ColumnCount = 2;
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableLayoutPanel7.Controls.Add(this.label8, 0, 1);
            this.tableLayoutPanel7.Controls.Add(this.label9, 1, 1);
            this.tableLayoutPanel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel7.Location = new System.Drawing.Point(152, 79);
            this.tableLayoutPanel7.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel7.Name = "tableLayoutPanel7";
            this.tableLayoutPanel7.RowCount = 3;
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel7.Size = new System.Drawing.Size(110, 49);
            this.tableLayoutPanel7.TabIndex = 4;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label8.Location = new System.Drawing.Point(0, 9);
            this.label8.Margin = new System.Windows.Forms.Padding(0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 30);
            this.label8.TabIndex = 0;
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label9.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label9.Location = new System.Drawing.Point(65, 9);
            this.label9.Margin = new System.Windows.Forms.Padding(0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(45, 30);
            this.label9.TabIndex = 1;
            this.label9.Text = "A";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(43, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 49);
            this.label1.TabIndex = 0;
            this.label1.Text = "上升时间:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(43, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 49);
            this.label2.TabIndex = 1;
            this.label2.Text = "上升电流:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(43, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 51);
            this.label3.TabIndex = 2;
            this.label3.Text = "交付位置:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 2;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableLayoutPanel6.Controls.Add(this.label6, 0, 1);
            this.tableLayoutPanel6.Controls.Add(this.label7, 1, 1);
            this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel6.Location = new System.Drawing.Point(152, 30);
            this.tableLayoutPanel6.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 3;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(110, 49);
            this.tableLayoutPanel6.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Location = new System.Drawing.Point(0, 9);
            this.label6.Margin = new System.Windows.Forms.Padding(0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 30);
            this.label6.TabIndex = 0;
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.Location = new System.Drawing.Point(65, 9);
            this.label7.Margin = new System.Windows.Forms.Padding(0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 30);
            this.label7.TabIndex = 1;
            this.label7.Text = "S";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 3;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel11, 1, 3);
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel9, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.label12, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.label13, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel10, 1, 2);
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel12, 2, 1);
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel13, 2, 2);
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel14, 2, 3);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(263, 0);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 4;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(263, 179);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // tableLayoutPanel11
            // 
            this.tableLayoutPanel11.ColumnCount = 2;
            this.tableLayoutPanel11.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel11.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableLayoutPanel11.Controls.Add(this.label18, 0, 1);
            this.tableLayoutPanel11.Controls.Add(this.label19, 1, 1);
            this.tableLayoutPanel11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel11.Location = new System.Drawing.Point(40, 128);
            this.tableLayoutPanel11.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel11.Name = "tableLayoutPanel11";
            this.tableLayoutPanel11.RowCount = 3;
            this.tableLayoutPanel11.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel11.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel11.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel11.Size = new System.Drawing.Size(111, 51);
            this.tableLayoutPanel11.TabIndex = 5;
            // 
            // label18
            // 
            this.label18.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label18.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label18.Location = new System.Drawing.Point(0, 10);
            this.label18.Margin = new System.Windows.Forms.Padding(0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(66, 30);
            this.label18.TabIndex = 0;
            this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label19
            // 
            this.label19.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label19.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label19.Location = new System.Drawing.Point(66, 10);
            this.label19.Margin = new System.Windows.Forms.Padding(0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(45, 30);
            this.label19.TabIndex = 1;
            this.label19.Text = "mm";
            this.label19.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel9
            // 
            this.tableLayoutPanel9.ColumnCount = 2;
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableLayoutPanel9.Controls.Add(this.label14, 0, 1);
            this.tableLayoutPanel9.Controls.Add(this.label15, 1, 1);
            this.tableLayoutPanel9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel9.Location = new System.Drawing.Point(40, 30);
            this.tableLayoutPanel9.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel9.Name = "tableLayoutPanel9";
            this.tableLayoutPanel9.RowCount = 3;
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel9.Size = new System.Drawing.Size(111, 49);
            this.tableLayoutPanel9.TabIndex = 4;
            // 
            // label14
            // 
            this.label14.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label14.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label14.Location = new System.Drawing.Point(0, 9);
            this.label14.Margin = new System.Windows.Forms.Padding(0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(66, 30);
            this.label14.TabIndex = 0;
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label15
            // 
            this.label15.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label15.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label15.Location = new System.Drawing.Point(66, 9);
            this.label15.Margin = new System.Windows.Forms.Padding(0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(45, 30);
            this.label15.TabIndex = 1;
            this.label15.Text = "S";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label12
            // 
            this.label12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label12.Location = new System.Drawing.Point(40, 0);
            this.label12.Margin = new System.Windows.Forms.Padding(0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(111, 30);
            this.label12.TabIndex = 0;
            this.label12.Text = "最小值:";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label13.Location = new System.Drawing.Point(151, 0);
            this.label13.Margin = new System.Windows.Forms.Padding(0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(112, 30);
            this.label13.TabIndex = 1;
            this.label13.Text = "最大值:";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tableLayoutPanel10
            // 
            this.tableLayoutPanel10.ColumnCount = 2;
            this.tableLayoutPanel10.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel10.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableLayoutPanel10.Controls.Add(this.label16, 0, 1);
            this.tableLayoutPanel10.Controls.Add(this.label17, 1, 1);
            this.tableLayoutPanel10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel10.Location = new System.Drawing.Point(40, 79);
            this.tableLayoutPanel10.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel10.Name = "tableLayoutPanel10";
            this.tableLayoutPanel10.RowCount = 3;
            this.tableLayoutPanel10.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel10.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel10.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel10.Size = new System.Drawing.Size(111, 49);
            this.tableLayoutPanel10.TabIndex = 5;
            // 
            // label16
            // 
            this.label16.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label16.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label16.Location = new System.Drawing.Point(0, 9);
            this.label16.Margin = new System.Windows.Forms.Padding(0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(66, 30);
            this.label16.TabIndex = 0;
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label17
            // 
            this.label17.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label17.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label17.Location = new System.Drawing.Point(66, 9);
            this.label17.Margin = new System.Windows.Forms.Padding(0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(45, 30);
            this.label17.TabIndex = 1;
            this.label17.Text = "A";
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel12
            // 
            this.tableLayoutPanel12.ColumnCount = 2;
            this.tableLayoutPanel12.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel12.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableLayoutPanel12.Controls.Add(this.label20, 0, 1);
            this.tableLayoutPanel12.Controls.Add(this.label21, 1, 1);
            this.tableLayoutPanel12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel12.Location = new System.Drawing.Point(151, 30);
            this.tableLayoutPanel12.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel12.Name = "tableLayoutPanel12";
            this.tableLayoutPanel12.RowCount = 3;
            this.tableLayoutPanel12.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel12.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel12.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel12.Size = new System.Drawing.Size(112, 49);
            this.tableLayoutPanel12.TabIndex = 6;
            // 
            // label20
            // 
            this.label20.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label20.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label20.Location = new System.Drawing.Point(0, 9);
            this.label20.Margin = new System.Windows.Forms.Padding(0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(67, 30);
            this.label20.TabIndex = 0;
            this.label20.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label21
            // 
            this.label21.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label21.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label21.Location = new System.Drawing.Point(67, 9);
            this.label21.Margin = new System.Windows.Forms.Padding(0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(45, 30);
            this.label21.TabIndex = 1;
            this.label21.Text = "S";
            this.label21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel13
            // 
            this.tableLayoutPanel13.ColumnCount = 2;
            this.tableLayoutPanel13.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel13.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableLayoutPanel13.Controls.Add(this.label22, 0, 1);
            this.tableLayoutPanel13.Controls.Add(this.label23, 1, 1);
            this.tableLayoutPanel13.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel13.Location = new System.Drawing.Point(151, 79);
            this.tableLayoutPanel13.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel13.Name = "tableLayoutPanel13";
            this.tableLayoutPanel13.RowCount = 3;
            this.tableLayoutPanel13.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel13.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel13.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel13.Size = new System.Drawing.Size(112, 49);
            this.tableLayoutPanel13.TabIndex = 7;
            // 
            // label22
            // 
            this.label22.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label22.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label22.Location = new System.Drawing.Point(0, 9);
            this.label22.Margin = new System.Windows.Forms.Padding(0);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(67, 30);
            this.label22.TabIndex = 0;
            this.label22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label23
            // 
            this.label23.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label23.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label23.Location = new System.Drawing.Point(67, 9);
            this.label23.Margin = new System.Windows.Forms.Padding(0);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(45, 30);
            this.label23.TabIndex = 1;
            this.label23.Text = "A";
            this.label23.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel14
            // 
            this.tableLayoutPanel14.ColumnCount = 2;
            this.tableLayoutPanel14.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel14.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableLayoutPanel14.Controls.Add(this.label24, 0, 1);
            this.tableLayoutPanel14.Controls.Add(this.label25, 1, 1);
            this.tableLayoutPanel14.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel14.Location = new System.Drawing.Point(151, 128);
            this.tableLayoutPanel14.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel14.Name = "tableLayoutPanel14";
            this.tableLayoutPanel14.RowCount = 3;
            this.tableLayoutPanel14.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel14.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel14.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel14.Size = new System.Drawing.Size(112, 51);
            this.tableLayoutPanel14.TabIndex = 8;
            // 
            // label24
            // 
            this.label24.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label24.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label24.Location = new System.Drawing.Point(0, 10);
            this.label24.Margin = new System.Windows.Forms.Padding(0);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(67, 30);
            this.label24.TabIndex = 0;
            this.label24.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label25
            // 
            this.label25.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label25.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label25.Location = new System.Drawing.Point(67, 10);
            this.label25.Margin = new System.Windows.Forms.Padding(0);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(45, 30);
            this.label25.TabIndex = 1;
            this.label25.Text = "mm";
            this.label25.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel16
            // 
            this.tableLayoutPanel16.ColumnCount = 3;
            this.tableLayoutPanel16.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 190F));
            this.tableLayoutPanel16.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel16.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel16.Controls.Add(this.title_label, 0, 0);
            this.tableLayoutPanel16.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel16.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel16.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel16.Name = "tableLayoutPanel16";
            this.tableLayoutPanel16.RowCount = 1;
            this.tableLayoutPanel16.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel16.Size = new System.Drawing.Size(526, 55);
            this.tableLayoutPanel16.TabIndex = 5;
            // 
            // title_label
            // 
            this.title_label.Dock = System.Windows.Forms.DockStyle.Fill;
            this.title_label.Font = new System.Drawing.Font("Microsoft YaHei", 21.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.title_label.ForeColor = System.Drawing.Color.Orange;
            this.title_label.Location = new System.Drawing.Point(0, 0);
            this.title_label.Margin = new System.Windows.Forms.Padding(0);
            this.title_label.Name = "title_label";
            this.title_label.Size = new System.Drawing.Size(190, 55);
            this.title_label.TabIndex = 0;
            this.title_label.Text = "测试数据：";
            this.title_label.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // tableLayoutPanel17
            // 
            this.tableLayoutPanel17.ColumnCount = 2;
            this.tableLayoutPanel17.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel17.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel17.Controls.Add(this.splitLine1, 0, 0);
            this.tableLayoutPanel17.Controls.Add(this.label26, 0, 1);
            this.tableLayoutPanel17.Controls.Add(this.label27, 1, 1);
            this.tableLayoutPanel17.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel17.Location = new System.Drawing.Point(0, 564);
            this.tableLayoutPanel17.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel17.Name = "tableLayoutPanel17";
            this.tableLayoutPanel17.RowCount = 2;
            this.tableLayoutPanel17.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 15F));
            this.tableLayoutPanel17.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel17.Size = new System.Drawing.Size(532, 72);
            this.tableLayoutPanel17.TabIndex = 2;
            // 
            // refresh_timer
            // 
            this.refresh_timer.Enabled = true;
            this.refresh_timer.Interval = 950;
            this.refresh_timer.Tick += new System.EventHandler(this.refresh_timer_Tick);
            // 
            // label26
            // 
            this.label26.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label26.Font = new System.Drawing.Font("Microsoft YaHei", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label26.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label26.Location = new System.Drawing.Point(3, 15);
            this.label26.Margin = new System.Windows.Forms.Padding(3, 0, 3, 5);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(260, 52);
            this.label26.TabIndex = 1;
            this.label26.Text = "测试结果:";
            this.label26.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.BackColor = System.Drawing.Color.LimeGreen;
            this.label27.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label27.Font = new System.Drawing.Font("Microsoft YaHei", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label27.ForeColor = System.Drawing.Color.White;
            this.label27.Location = new System.Drawing.Point(269, 15);
            this.label27.Margin = new System.Windows.Forms.Padding(3, 0, 3, 5);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(260, 52);
            this.label27.TabIndex = 2;
            this.label27.Text = "OK";
            this.label27.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dotLine1
            // 
            this.dotLine1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dotLine1.DotLineLen = 15;
            this.dotLine1.DotLineWidth = 1;
            this.dotLine1.GapLen = 5;
            this.dotLine1.Location = new System.Drawing.Point(262, 0);
            this.dotLine1.Margin = new System.Windows.Forms.Padding(0);
            this.dotLine1.Name = "dotLine1";
            this.dotLine1.Size = new System.Drawing.Size(1, 179);
            this.dotLine1.TabIndex = 2;
            // 
            // splitLine1
            // 
            this.splitLine1.BackColor = System.Drawing.Color.DodgerBlue;
            this.tableLayoutPanel17.SetColumnSpan(this.splitLine1, 2);
            this.splitLine1.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitLine1.Location = new System.Drawing.Point(0, 5);
            this.splitLine1.Margin = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.splitLine1.Name = "splitLine1";
            this.splitLine1.Size = new System.Drawing.Size(532, 3);
            this.splitLine1.TabIndex = 0;
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
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(644, 630);
            this.panel1.TabIndex = 1;
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
            this.tableLayoutPanel15.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel8.ResumeLayout(false);
            this.tableLayoutPanel7.ResumeLayout(false);
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanel11.ResumeLayout(false);
            this.tableLayoutPanel9.ResumeLayout(false);
            this.tableLayoutPanel10.ResumeLayout(false);
            this.tableLayoutPanel12.ResumeLayout(false);
            this.tableLayoutPanel13.ResumeLayout(false);
            this.tableLayoutPanel14.ResumeLayout(false);
            this.tableLayoutPanel16.ResumeLayout(false);
            this.tableLayoutPanel17.ResumeLayout(false);
            this.tableLayoutPanel17.PerformLayout();
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
        private System.Windows.Forms.Timer refresh_timer;
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
        private TableLayoutPanel tableLayoutPanel4;
        private Label label4;
        private TableLayoutPanel tableLayoutPanel5;
        private Label label5;
        private TableLayoutPanel tableLayoutPanel6;
        private Label label6;
        private Label label3;
        private Label label7;
        private TableLayoutPanel tableLayoutPanel8;
        private Label label10;
        private Label label11;
        private TableLayoutPanel tableLayoutPanel7;
        private Label label8;
        private Label label9;
        private Label label12;
        private Label label13;
        private TableLayoutPanel tableLayoutPanel11;
        private Label label18;
        private Label label19;
        private TableLayoutPanel tableLayoutPanel9;
        private Label label14;
        private Label label15;
        private TableLayoutPanel tableLayoutPanel10;
        private Label label16;
        private Label label17;
        private TableLayoutPanel tableLayoutPanel12;
        private Label label20;
        private Label label21;
        private TableLayoutPanel tableLayoutPanel13;
        private Label label22;
        private Label label23;
        private TableLayoutPanel tableLayoutPanel14;
        private Label label24;
        private Label label25;
        private TableLayoutPanel tableLayoutPanel15;
        private TableLayoutPanel tableLayoutPanel16;
        private TableLayoutPanel tableLayoutPanel17;
        private CustomControls.SplitLine splitLine1;
        private Label label26;
        private Label label27;
        private Panel panel1;
    }
}

