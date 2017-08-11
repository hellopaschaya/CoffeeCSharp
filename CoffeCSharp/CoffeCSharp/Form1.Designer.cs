namespace CoffeCSharp
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint1 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, "0,0,0,0");
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.tsMain = new System.Windows.Forms.ToolStrip();
            this.btExit = new System.Windows.Forms.ToolStripButton();
            this.btManageOrders = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btPrivilege = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btMangeCustomer = new System.Windows.Forms.ToolStripButton();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvDrink = new System.Windows.Forms.DataGridView();
            this.dgvOther = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelLeft = new System.Windows.Forms.Panel();
            this.lbSumtotal = new System.Windows.Forms.Label();
            this.dgvShowResult = new System.Windows.Forms.DataGridView();
            this.sno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label15 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.cbbCustomer = new System.Windows.Forms.ComboBox();
            this.lbDC = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.btClear = new System.Windows.Forms.Button();
            this.btCal = new System.Windows.Forms.Button();
            this.lbSum = new System.Windows.Forms.Label();
            this.lbSumDrink = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panelRight = new System.Windows.Forms.Panel();
            this.cShowDetail = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tsMain.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDrink)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOther)).BeginInit();
            this.panel1.SuspendLayout();
            this.panelLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShowResult)).BeginInit();
            this.panelRight.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cShowDetail)).BeginInit();
            this.SuspendLayout();
            // 
            // tsMain
            // 
            this.tsMain.AutoSize = false;
            this.tsMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btExit,
            this.btManageOrders,
            this.toolStripSeparator1,
            this.btPrivilege,
            this.toolStripSeparator2,
            this.btMangeCustomer});
            this.tsMain.Location = new System.Drawing.Point(0, 0);
            this.tsMain.Name = "tsMain";
            this.tsMain.Size = new System.Drawing.Size(1354, 45);
            this.tsMain.TabIndex = 0;
            this.tsMain.Text = "toolStrip1";
            // 
            // btExit
            // 
            this.btExit.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btExit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btExit.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btExit.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btExit.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btExit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btExit.Name = "btExit";
            this.btExit.Padding = new System.Windows.Forms.Padding(5);
            this.btExit.Size = new System.Drawing.Size(45, 42);
            this.btExit.Text = "Exit";
            this.btExit.Click += new System.EventHandler(this.tsbtExit_Click);
            // 
            // btManageOrders
            // 
            this.btManageOrders.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btManageOrders.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btManageOrders.Font = new System.Drawing.Font("Arial", 9.75F);
            this.btManageOrders.Image = ((System.Drawing.Image)(resources.GetObject("btManageOrders.Image")));
            this.btManageOrders.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btManageOrders.Name = "btManageOrders";
            this.btManageOrders.Padding = new System.Windows.Forms.Padding(5);
            this.btManageOrders.Size = new System.Drawing.Size(107, 42);
            this.btManageOrders.Text = "ManageOrders";
            this.btManageOrders.Click += new System.EventHandler(this.btManageOrders_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 45);
            // 
            // btPrivilege
            // 
            this.btPrivilege.BackColor = System.Drawing.Color.Lime;
            this.btPrivilege.Font = new System.Drawing.Font("Arial", 9.75F);
            this.btPrivilege.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.btPrivilege.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btPrivilege.Name = "btPrivilege";
            this.btPrivilege.Padding = new System.Windows.Forms.Padding(5);
            this.btPrivilege.Size = new System.Drawing.Size(118, 42);
            this.btPrivilege.Text = "Check 10 Free 1";
            this.btPrivilege.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            this.btPrivilege.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btPrivilege.Click += new System.EventHandler(this.btPrivilege_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 45);
            // 
            // btMangeCustomer
            // 
            this.btMangeCustomer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btMangeCustomer.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btMangeCustomer.Font = new System.Drawing.Font("Arial", 9.75F);
            this.btMangeCustomer.Image = ((System.Drawing.Image)(resources.GetObject("btMangeCustomer.Image")));
            this.btMangeCustomer.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btMangeCustomer.Name = "btMangeCustomer";
            this.btMangeCustomer.Padding = new System.Windows.Forms.Padding(5);
            this.btMangeCustomer.Size = new System.Drawing.Size(124, 42);
            this.btMangeCustomer.Text = "ManageCustomer";
            this.btMangeCustomer.Click += new System.EventHandler(this.btMangeCustomer_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.dgvDrink, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.dgvOther, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 45);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 19.7861F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80.21391F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1354, 208);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(671, 41);
            this.label1.TabIndex = 0;
            this.label1.Text = "เครื่องดื่ม";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.UseCompatibleTextRendering = true;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(680, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(671, 41);
            this.label2.TabIndex = 0;
            this.label2.Text = "รายการอื่นๆ";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.UseCompatibleTextRendering = true;
            // 
            // dgvDrink
            // 
            this.dgvDrink.AllowUserToAddRows = false;
            this.dgvDrink.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDrink.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDrink.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDrink.EnableHeadersVisualStyles = false;
            this.dgvDrink.Location = new System.Drawing.Point(3, 44);
            this.dgvDrink.Name = "dgvDrink";
            this.dgvDrink.ReadOnly = true;
            this.dgvDrink.RightToLeft = System.Windows.Forms.RightToLeft.No;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgvDrink.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDrink.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvDrink.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDrink.Size = new System.Drawing.Size(671, 161);
            this.dgvDrink.TabIndex = 1;
            this.dgvDrink.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDrink_CellClick);
            this.dgvDrink.Leave += new System.EventHandler(this.dgvDrink_Leave);
            // 
            // dgvOther
            // 
            this.dgvOther.AllowUserToAddRows = false;
            this.dgvOther.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvOther.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvOther.EnableHeadersVisualStyles = false;
            this.dgvOther.Location = new System.Drawing.Point(680, 44);
            this.dgvOther.Name = "dgvOther";
            this.dgvOther.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgvOther.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvOther.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvOther.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOther.Size = new System.Drawing.Size(671, 161);
            this.dgvOther.TabIndex = 1;
            this.dgvOther.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvOther_CellClick);
            this.dgvOther.Leave += new System.EventHandler(this.dgvOther_Leave);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panelLeft);
            this.panel1.Controls.Add(this.panelRight);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 253);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1354, 393);
            this.panel1.TabIndex = 4;
            // 
            // panelLeft
            // 
            this.panelLeft.Controls.Add(this.lbSumtotal);
            this.panelLeft.Controls.Add(this.dgvShowResult);
            this.panelLeft.Controls.Add(this.label15);
            this.panelLeft.Controls.Add(this.label3);
            this.panelLeft.Controls.Add(this.label16);
            this.panelLeft.Controls.Add(this.cbbCustomer);
            this.panelLeft.Controls.Add(this.lbDC);
            this.panelLeft.Controls.Add(this.label4);
            this.panelLeft.Controls.Add(this.label12);
            this.panelLeft.Controls.Add(this.label13);
            this.panelLeft.Controls.Add(this.btClear);
            this.panelLeft.Controls.Add(this.btCal);
            this.panelLeft.Controls.Add(this.lbSum);
            this.panelLeft.Controls.Add(this.lbSumDrink);
            this.panelLeft.Controls.Add(this.label10);
            this.panelLeft.Controls.Add(this.label7);
            this.panelLeft.Controls.Add(this.label8);
            this.panelLeft.Controls.Add(this.label5);
            this.panelLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft.Location = new System.Drawing.Point(0, 0);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(660, 393);
            this.panelLeft.TabIndex = 29;
            // 
            // lbSumtotal
            // 
            this.lbSumtotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbSumtotal.Enabled = false;
            this.lbSumtotal.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold);
            this.lbSumtotal.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lbSumtotal.Location = new System.Drawing.Point(401, 326);
            this.lbSumtotal.Margin = new System.Windows.Forms.Padding(10, 10, 3, 0);
            this.lbSumtotal.Name = "lbSumtotal";
            this.lbSumtotal.Size = new System.Drawing.Size(115, 31);
            this.lbSumtotal.TabIndex = 38;
            this.lbSumtotal.Text = "0";
            this.lbSumtotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvShowResult
            // 
            this.dgvShowResult.AllowUserToAddRows = false;
            this.dgvShowResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvShowResult.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sno});
            this.dgvShowResult.Location = new System.Drawing.Point(14, 47);
            this.dgvShowResult.Name = "dgvShowResult";
            this.dgvShowResult.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgvShowResult.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvShowResult.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvShowResult.RowTemplate.ReadOnly = true;
            this.dgvShowResult.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvShowResult.Size = new System.Drawing.Size(630, 146);
            this.dgvShowResult.TabIndex = 31;
            this.dgvShowResult.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvShowResult_CellDoubleClick);
            this.dgvShowResult.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dgvShowResult_RowPostPaint);
            this.dgvShowResult.Leave += new System.EventHandler(this.dgvShowResult_Leave);
            // 
            // sno
            // 
            this.sno.HeaderText = "รายการที่";
            this.sno.Name = "sno";
            this.sno.ReadOnly = true;
            // 
            // label15
            // 
            this.label15.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold);
            this.label15.Location = new System.Drawing.Point(529, 326);
            this.label15.Margin = new System.Windows.Forms.Padding(10, 10, 3, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(92, 31);
            this.label15.TabIndex = 39;
            this.label15.Text = "บาท";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(10, 10);
            this.label3.Margin = new System.Windows.Forms.Padding(10, 10, 3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 31);
            this.label3.TabIndex = 28;
            this.label3.Text = "เลือกชื่อลูกค้า";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label16
            // 
            this.label16.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold);
            this.label16.Location = new System.Drawing.Point(271, 326);
            this.label16.Margin = new System.Windows.Forms.Padding(10, 10, 3, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(115, 31);
            this.label16.TabIndex = 40;
            this.label16.Text = "ราคาทั้งหมด";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbbCustomer
            // 
            this.cbbCustomer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbCustomer.Font = new System.Drawing.Font("Arial", 15F);
            this.cbbCustomer.FormattingEnabled = true;
            this.cbbCustomer.Location = new System.Drawing.Point(144, 10);
            this.cbbCustomer.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.cbbCustomer.Name = "cbbCustomer";
            this.cbbCustomer.Size = new System.Drawing.Size(180, 31);
            this.cbbCustomer.TabIndex = 29;
            this.cbbCustomer.SelectionChangeCommitted += new System.EventHandler(this.cbbCustomer_SelectionChangeCommitted);
            // 
            // lbDC
            // 
            this.lbDC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbDC.Enabled = false;
            this.lbDC.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold);
            this.lbDC.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lbDC.Location = new System.Drawing.Point(401, 285);
            this.lbDC.Margin = new System.Windows.Forms.Padding(10, 10, 3, 0);
            this.lbDC.Name = "lbDC";
            this.lbDC.Size = new System.Drawing.Size(115, 31);
            this.lbDC.TabIndex = 35;
            this.lbDC.Text = "0";
            this.lbDC.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(346, 10);
            this.label4.Margin = new System.Windows.Forms.Padding(10, 10, 3, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(275, 31);
            this.label4.TabIndex = 30;
            this.label4.Text = "ครบ 10  แก้ว ฟรี 1 แก้ว (มูลค่า 25 บาท)";
            // 
            // label12
            // 
            this.label12.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold);
            this.label12.Location = new System.Drawing.Point(529, 285);
            this.label12.Margin = new System.Windows.Forms.Padding(10, 10, 3, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(92, 31);
            this.label12.TabIndex = 36;
            this.label12.Text = "บาท";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label13
            // 
            this.label13.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold);
            this.label13.Location = new System.Drawing.Point(271, 285);
            this.label13.Margin = new System.Windows.Forms.Padding(10, 10, 3, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(115, 31);
            this.label13.TabIndex = 37;
            this.label13.Text = "ส่วนลด";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btClear
            // 
            this.btClear.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btClear.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.btClear.Location = new System.Drawing.Point(121, 209);
            this.btClear.Name = "btClear";
            this.btClear.Size = new System.Drawing.Size(101, 44);
            this.btClear.TabIndex = 33;
            this.btClear.Text = "ล้าง";
            this.btClear.UseVisualStyleBackColor = false;
            this.btClear.Click += new System.EventHandler(this.btClear_Click);
            // 
            // btCal
            // 
            this.btCal.BackColor = System.Drawing.Color.Lime;
            this.btCal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btCal.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.btCal.Location = new System.Drawing.Point(14, 209);
            this.btCal.Name = "btCal";
            this.btCal.Size = new System.Drawing.Size(101, 44);
            this.btCal.TabIndex = 34;
            this.btCal.Text = "คิดเงิน";
            this.btCal.UseVisualStyleBackColor = false;
            this.btCal.Click += new System.EventHandler(this.btCal_Click);
            // 
            // lbSum
            // 
            this.lbSum.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbSum.Enabled = false;
            this.lbSum.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold);
            this.lbSum.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lbSum.Location = new System.Drawing.Point(401, 244);
            this.lbSum.Margin = new System.Windows.Forms.Padding(10, 10, 3, 0);
            this.lbSum.Name = "lbSum";
            this.lbSum.Size = new System.Drawing.Size(115, 31);
            this.lbSum.TabIndex = 27;
            this.lbSum.Text = "0";
            this.lbSum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbSumDrink
            // 
            this.lbSumDrink.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbSumDrink.Enabled = false;
            this.lbSumDrink.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold);
            this.lbSumDrink.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lbSumDrink.Location = new System.Drawing.Point(401, 203);
            this.lbSumDrink.Margin = new System.Windows.Forms.Padding(10, 10, 3, 0);
            this.lbSumDrink.Name = "lbSumDrink";
            this.lbSumDrink.Size = new System.Drawing.Size(115, 31);
            this.lbSumDrink.TabIndex = 28;
            this.lbSumDrink.Text = "0";
            this.lbSumDrink.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold);
            this.label10.Location = new System.Drawing.Point(529, 244);
            this.label10.Margin = new System.Windows.Forms.Padding(10, 10, 3, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(92, 31);
            this.label10.TabIndex = 29;
            this.label10.Text = "บาท";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(529, 203);
            this.label7.Margin = new System.Windows.Forms.Padding(10, 10, 3, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 31);
            this.label7.TabIndex = 30;
            this.label7.Text = "รายการ";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(271, 244);
            this.label8.Margin = new System.Windows.Forms.Padding(10, 10, 3, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(115, 31);
            this.label8.TabIndex = 31;
            this.label8.Text = "ราคารวม";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(271, 203);
            this.label5.Margin = new System.Windows.Forms.Padding(10, 10, 3, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 31);
            this.label5.TabIndex = 32;
            this.label5.Text = "รวมทั้งหมด";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelRight
            // 
            this.panelRight.Controls.Add(this.cShowDetail);
            this.panelRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelRight.Location = new System.Drawing.Point(666, 0);
            this.panelRight.Name = "panelRight";
            this.panelRight.Size = new System.Drawing.Size(688, 393);
            this.panelRight.TabIndex = 28;
            // 
            // cShowDetail
            // 
            chartArea1.Name = "ChartArea1";
            this.cShowDetail.ChartAreas.Add(chartArea1);
            this.cShowDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            legend1.Font = new System.Drawing.Font("Arial", 18F);
            legend1.IsTextAutoFit = false;
            legend1.Name = "Legend1";
            legend1.TitleFont = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold);
            this.cShowDetail.Legends.Add(legend1);
            this.cShowDetail.Location = new System.Drawing.Point(0, 0);
            this.cShowDetail.Name = "cShowDetail";
            this.cShowDetail.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.EarthTones;
            series1.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.Center;
            series1.BackHatchStyle = System.Windows.Forms.DataVisualization.Charting.ChartHatchStyle.OutlinedDiamond;
            series1.ChartArea = "ChartArea1";
            series1.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold);
            series1.IsValueShownAsLabel = true;
            series1.IsVisibleInLegend = false;
            series1.Legend = "Legend1";
            series1.MarkerSize = 3;
            series1.Name = "Series1";
            series1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.EarthTones;
            dataPoint1.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series1.Points.Add(dataPoint1);
            series1.SmartLabelStyle.AllowOutsidePlotArea = System.Windows.Forms.DataVisualization.Charting.LabelOutsidePlotAreaStyle.Yes;
            series1.YValuesPerPoint = 4;
            this.cShowDetail.Series.Add(series1);
            this.cShowDetail.Size = new System.Drawing.Size(688, 393);
            this.cShowDetail.TabIndex = 32;
            this.cShowDetail.Text = "chart1";
            title1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            title1.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.Center;
            title1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title1.Name = "Title1";
            title1.Text = "TOP 5 BEST SELLER";
            this.cShowDetail.Titles.Add(title1);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.ClientSize = new System.Drawing.Size(1354, 646);
            this.ControlBox = false;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tsMain);
            this.Font = new System.Drawing.Font("Arial", 9.75F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Coffee Program";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.tsMain.ResumeLayout(false);
            this.tsMain.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDrink)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOther)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panelLeft.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvShowResult)).EndInit();
            this.panelRight.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cShowDetail)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip tsMain;
        private System.Windows.Forms.ToolStripButton btExit;
        private System.Windows.Forms.ToolStripButton btManageOrders;
        private System.Windows.Forms.ToolStripButton btPrivilege;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton btMangeCustomer;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvDrink;
        private System.Windows.Forms.DataGridView dgvOther;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.Label lbSumtotal;
        private System.Windows.Forms.DataGridView dgvShowResult;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ComboBox cbbCustomer;
        private System.Windows.Forms.Label lbDC;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btClear;
        private System.Windows.Forms.Button btCal;
        private System.Windows.Forms.Label lbSum;
        private System.Windows.Forms.Label lbSumDrink;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panelRight;
        private System.Windows.Forms.DataVisualization.Charting.Chart cShowDetail;
        private System.Windows.Forms.DataGridViewTextBoxColumn sno;
    }
}

