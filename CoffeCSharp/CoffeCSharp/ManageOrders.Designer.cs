namespace CoffeCSharp
{
    partial class ManageOrders
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btExit = new System.Windows.Forms.ToolStripButton();
            this.tsMain = new System.Windows.Forms.ToolStrip();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvDrink = new System.Windows.Forms.DataGridView();
            this.dgvOther = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.tbShowProPrice = new System.Windows.Forms.TextBox();
            this.tbShowProName = new System.Windows.Forms.TextBox();
            this.tbShowProID = new System.Windows.Forms.TextBox();
            this.btSave = new System.Windows.Forms.Button();
            this.btCancel = new System.Windows.Forms.Button();
            this.rbSpin = new System.Windows.Forms.RadioButton();
            this.rbCool = new System.Windows.Forms.RadioButton();
            this.rbHot = new System.Windows.Forms.RadioButton();
            this.cbbType = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btAdd = new System.Windows.Forms.Button();
            this.btUpdate = new System.Windows.Forms.Button();
            this.btDelete = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btSearch = new System.Windows.Forms.Button();
            this.tbSearchID = new System.Windows.Forms.TextBox();
            this.rbOther = new System.Windows.Forms.RadioButton();
            this.rbDrink = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.tsMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDrink)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOther)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
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
            this.btExit.Size = new System.Drawing.Size(91, 42);
            this.btExit.Text = "Home(ESC)";
            this.btExit.Click += new System.EventHandler(this.btExit_Click);
            // 
            // tsMain
            // 
            this.tsMain.AutoSize = false;
            this.tsMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btExit});
            this.tsMain.Location = new System.Drawing.Point(0, 0);
            this.tsMain.Name = "tsMain";
            this.tsMain.Size = new System.Drawing.Size(1082, 45);
            this.tsMain.TabIndex = 1;
            this.tsMain.Text = "toolStrip1";
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(0, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1082, 61);
            this.label1.TabIndex = 2;
            this.label1.Text = "Manage Orders";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(544, 50);
            this.label2.TabIndex = 1;
            this.label2.Text = "เครื่องดื่ม";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.UseCompatibleTextRendering = true;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(3, 336);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(544, 42);
            this.label3.TabIndex = 2;
            this.label3.Text = "รายการอื่นๆ";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label3.UseCompatibleTextRendering = true;
            // 
            // dgvDrink
            // 
            this.dgvDrink.AllowUserToAddRows = false;
            this.dgvDrink.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDrink.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvDrink.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDrink.EnableHeadersVisualStyles = false;
            this.dgvDrink.Location = new System.Drawing.Point(3, 53);
            this.dgvDrink.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
            this.dgvDrink.Name = "dgvDrink";
            this.dgvDrink.ReadOnly = true;
            this.dgvDrink.RightToLeft = System.Windows.Forms.RightToLeft.No;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgvDrink.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvDrink.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvDrink.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDrink.Size = new System.Drawing.Size(544, 273);
            this.dgvDrink.TabIndex = 3;
            this.dgvDrink.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDrink_CellClick);
            // 
            // dgvOther
            // 
            this.dgvOther.AllowUserToAddRows = false;
            this.dgvOther.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvOther.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvOther.EnableHeadersVisualStyles = false;
            this.dgvOther.Location = new System.Drawing.Point(3, 381);
            this.dgvOther.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
            this.dgvOther.Name = "dgvOther";
            this.dgvOther.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgvOther.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvOther.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvOther.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOther.Size = new System.Drawing.Size(544, 274);
            this.dgvOther.TabIndex = 4;
            this.dgvOther.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvOther_CellClick);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.dgvOther, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.dgvDrink, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 106);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.93507F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 85.06493F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 42F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 286F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(550, 665);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(550, 106);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(532, 665);
            this.panel1.TabIndex = 4;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.panel3);
            this.groupBox2.Controls.Add(this.panel2);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox2.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold);
            this.groupBox2.Location = new System.Drawing.Point(0, 218);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(532, 447);
            this.groupBox2.TabIndex = 31;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "เพิ่มเมนูสินค้า";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.tbShowProPrice);
            this.panel3.Controls.Add(this.tbShowProName);
            this.panel3.Controls.Add(this.tbShowProID);
            this.panel3.Controls.Add(this.btSave);
            this.panel3.Controls.Add(this.btCancel);
            this.panel3.Controls.Add(this.rbSpin);
            this.panel3.Controls.Add(this.rbCool);
            this.panel3.Controls.Add(this.rbHot);
            this.panel3.Controls.Add(this.cbbType);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(3, 126);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(526, 318);
            this.panel3.TabIndex = 38;
            // 
            // tbShowProPrice
            // 
            this.tbShowProPrice.Enabled = false;
            this.tbShowProPrice.Location = new System.Drawing.Point(131, 146);
            this.tbShowProPrice.MaxLength = 10;
            this.tbShowProPrice.Name = "tbShowProPrice";
            this.tbShowProPrice.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbShowProPrice.Size = new System.Drawing.Size(173, 30);
            this.tbShowProPrice.TabIndex = 42;
            this.tbShowProPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbShowProPrice_KeyPress);
            // 
            // tbShowProName
            // 
            this.tbShowProName.Enabled = false;
            this.tbShowProName.Location = new System.Drawing.Point(131, 105);
            this.tbShowProName.MaxLength = 20;
            this.tbShowProName.Name = "tbShowProName";
            this.tbShowProName.Size = new System.Drawing.Size(173, 30);
            this.tbShowProName.TabIndex = 41;
            // 
            // tbShowProID
            // 
            this.tbShowProID.Enabled = false;
            this.tbShowProID.Location = new System.Drawing.Point(131, 65);
            this.tbShowProID.Name = "tbShowProID";
            this.tbShowProID.Size = new System.Drawing.Size(173, 30);
            this.tbShowProID.TabIndex = 40;
            // 
            // btSave
            // 
            this.btSave.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btSave.Enabled = false;
            this.btSave.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.btSave.Location = new System.Drawing.Point(121, 217);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(101, 44);
            this.btSave.TabIndex = 37;
            this.btSave.Text = "บันทึก";
            this.btSave.UseVisualStyleBackColor = false;
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
            // 
            // btCancel
            // 
            this.btCancel.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btCancel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.btCancel.Location = new System.Drawing.Point(228, 217);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(101, 44);
            this.btCancel.TabIndex = 38;
            this.btCancel.Text = "ยกเลิก";
            this.btCancel.UseVisualStyleBackColor = false;
            this.btCancel.Click += new System.EventHandler(this.btCancel_Click);
            // 
            // rbSpin
            // 
            this.rbSpin.AutoSize = true;
            this.rbSpin.Enabled = false;
            this.rbSpin.Location = new System.Drawing.Point(441, 21);
            this.rbSpin.Name = "rbSpin";
            this.rbSpin.Size = new System.Drawing.Size(48, 28);
            this.rbSpin.TabIndex = 34;
            this.rbSpin.TabStop = true;
            this.rbSpin.Text = "ปั่น";
            this.rbSpin.UseVisualStyleBackColor = true;
            // 
            // rbCool
            // 
            this.rbCool.AutoSize = true;
            this.rbCool.Enabled = false;
            this.rbCool.Location = new System.Drawing.Point(379, 21);
            this.rbCool.Name = "rbCool";
            this.rbCool.Size = new System.Drawing.Size(53, 28);
            this.rbCool.TabIndex = 33;
            this.rbCool.TabStop = true;
            this.rbCool.Text = "เย็น";
            this.rbCool.UseVisualStyleBackColor = true;
            // 
            // rbHot
            // 
            this.rbHot.AutoSize = true;
            this.rbHot.Checked = true;
            this.rbHot.Enabled = false;
            this.rbHot.Location = new System.Drawing.Point(317, 21);
            this.rbHot.Name = "rbHot";
            this.rbHot.Size = new System.Drawing.Size(56, 28);
            this.rbHot.TabIndex = 32;
            this.rbHot.TabStop = true;
            this.rbHot.Text = "ร้อน";
            this.rbHot.UseVisualStyleBackColor = true;
            // 
            // cbbType
            // 
            this.cbbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbType.Enabled = false;
            this.cbbType.Font = new System.Drawing.Font("Arial", 15F);
            this.cbbType.FormattingEnabled = true;
            this.cbbType.Location = new System.Drawing.Point(131, 20);
            this.cbbType.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.cbbType.Name = "cbbType";
            this.cbbType.Size = new System.Drawing.Size(180, 31);
            this.cbbType.TabIndex = 31;
            this.cbbType.SelectionChangeCommitted += new System.EventHandler(this.cbbType_SelectionChangeCommitted);
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold);
            this.label9.Location = new System.Drawing.Point(328, 145);
            this.label9.Margin = new System.Windows.Forms.Padding(10, 10, 3, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(115, 31);
            this.label9.TabIndex = 30;
            this.label9.Text = "บาท";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(7, 146);
            this.label8.Margin = new System.Windows.Forms.Padding(10, 10, 3, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(115, 31);
            this.label8.TabIndex = 30;
            this.label8.Text = "ราคา";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(7, 105);
            this.label7.Margin = new System.Windows.Forms.Padding(10, 10, 3, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(115, 31);
            this.label7.TabIndex = 30;
            this.label7.Text = "ชื่อสินค้า";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(10, 64);
            this.label6.Margin = new System.Windows.Forms.Padding(10, 10, 3, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(115, 31);
            this.label6.TabIndex = 30;
            this.label6.Text = "รหัสสินค้า";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(10, 23);
            this.label5.Margin = new System.Windows.Forms.Padding(10, 10, 3, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 31);
            this.label5.TabIndex = 30;
            this.label5.Text = "ประเภทสินค้า";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btAdd);
            this.panel2.Controls.Add(this.btUpdate);
            this.panel2.Controls.Add(this.btDelete);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(3, 26);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(526, 100);
            this.panel2.TabIndex = 37;
            // 
            // btAdd
            // 
            this.btAdd.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btAdd.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.btAdd.Location = new System.Drawing.Point(14, 23);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(101, 44);
            this.btAdd.TabIndex = 36;
            this.btAdd.Text = "เพิ่ม";
            this.btAdd.UseVisualStyleBackColor = false;
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // btUpdate
            // 
            this.btUpdate.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btUpdate.Enabled = false;
            this.btUpdate.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.btUpdate.Location = new System.Drawing.Point(228, 23);
            this.btUpdate.Name = "btUpdate";
            this.btUpdate.Size = new System.Drawing.Size(101, 44);
            this.btUpdate.TabIndex = 36;
            this.btUpdate.Text = "อัพเดท";
            this.btUpdate.UseVisualStyleBackColor = false;
            this.btUpdate.Click += new System.EventHandler(this.btUpdate_Click);
            // 
            // btDelete
            // 
            this.btDelete.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btDelete.Enabled = false;
            this.btDelete.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.btDelete.Location = new System.Drawing.Point(121, 23);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(101, 44);
            this.btDelete.TabIndex = 36;
            this.btDelete.Text = "ลบ";
            this.btDelete.UseVisualStyleBackColor = false;
            this.btDelete.Click += new System.EventHandler(this.btDelete_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btSearch);
            this.groupBox1.Controls.Add(this.tbSearchID);
            this.groupBox1.Controls.Add(this.rbOther);
            this.groupBox1.Controls.Add(this.rbDrink);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold);
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(532, 212);
            this.groupBox1.TabIndex = 30;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ค้นหารหัสสินค้า";
            // 
            // btSearch
            // 
            this.btSearch.BackColor = System.Drawing.Color.Lime;
            this.btSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btSearch.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.btSearch.Location = new System.Drawing.Point(141, 111);
            this.btSearch.Name = "btSearch";
            this.btSearch.Size = new System.Drawing.Size(101, 44);
            this.btSearch.TabIndex = 37;
            this.btSearch.Text = "ค้นหา(Enter)";
            this.btSearch.UseVisualStyleBackColor = false;
            this.btSearch.Click += new System.EventHandler(this.btSearch_Click);
            // 
            // tbSearchID
            // 
            this.tbSearchID.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbSearchID.Location = new System.Drawing.Point(141, 55);
            this.tbSearchID.MaxLength = 4;
            this.tbSearchID.Name = "tbSearchID";
            this.tbSearchID.Size = new System.Drawing.Size(173, 30);
            this.tbSearchID.TabIndex = 36;
            this.tbSearchID.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbSearchID_KeyDown);
            // 
            // rbOther
            // 
            this.rbOther.AutoSize = true;
            this.rbOther.Location = new System.Drawing.Point(449, 56);
            this.rbOther.Name = "rbOther";
            this.rbOther.Size = new System.Drawing.Size(56, 28);
            this.rbOther.TabIndex = 31;
            this.rbOther.TabStop = true;
            this.rbOther.Text = "อื่นๆ";
            this.rbOther.UseVisualStyleBackColor = true;
            // 
            // rbDrink
            // 
            this.rbDrink.AutoSize = true;
            this.rbDrink.Checked = true;
            this.rbDrink.Location = new System.Drawing.Point(335, 56);
            this.rbDrink.Name = "rbDrink";
            this.rbDrink.Size = new System.Drawing.Size(87, 28);
            this.rbDrink.TabIndex = 31;
            this.rbDrink.TabStop = true;
            this.rbDrink.Text = "เครื่องดื่ม";
            this.rbDrink.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(13, 55);
            this.label4.Margin = new System.Windows.Forms.Padding(10, 10, 3, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 31);
            this.label4.TabIndex = 29;
            this.label4.Text = "รหัสสินค้า";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ManageOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1082, 771);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tsMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ManageOrders";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ManageOrders";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ManageOrders_Load);
            this.tsMain.ResumeLayout(false);
            this.tsMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDrink)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOther)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStripButton btExit;
        private System.Windows.Forms.ToolStrip tsMain;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvDrink;
        private System.Windows.Forms.DataGridView dgvOther;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rbOther;
        private System.Windows.Forms.RadioButton rbDrink;
        private System.Windows.Forms.Button btUpdate;
        private System.Windows.Forms.Button btDelete;
        private System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton rbSpin;
        private System.Windows.Forms.RadioButton rbCool;
        private System.Windows.Forms.RadioButton rbHot;
        private System.Windows.Forms.ComboBox cbbType;
        private System.Windows.Forms.Button btSave;
        private System.Windows.Forms.Button btCancel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbShowProPrice;
        private System.Windows.Forms.TextBox tbShowProName;
        private System.Windows.Forms.TextBox tbShowProID;
        private System.Windows.Forms.TextBox tbSearchID;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btSearch;

    }
}