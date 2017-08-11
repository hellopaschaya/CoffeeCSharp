namespace CoffeCSharp
{
    partial class RightCF
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
            this.tsMain = new System.Windows.Forms.ToolStrip();
            this.btExit = new System.Windows.Forms.ToolStripButton();
            this.lbShowRight = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.lblShowRightTotal = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel3 = new System.Windows.Forms.ToolStripLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbbCustomer = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btCal = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.udUnit = new System.Windows.Forms.NumericUpDown();
            this.tsMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.udUnit)).BeginInit();
            this.SuspendLayout();
            // 
            // tsMain
            // 
            this.tsMain.AutoSize = false;
            this.tsMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btExit,
            this.lbShowRight,
            this.toolStripLabel1,
            this.lblShowRightTotal,
            this.toolStripLabel3});
            this.tsMain.Location = new System.Drawing.Point(0, 0);
            this.tsMain.Name = "tsMain";
            this.tsMain.Size = new System.Drawing.Size(1082, 45);
            this.tsMain.TabIndex = 1;
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
            this.btExit.Size = new System.Drawing.Size(56, 42);
            this.btExit.Text = "Home";
            this.btExit.Click += new System.EventHandler(this.btExit_Click);
            // 
            // lbShowRight
            // 
            this.lbShowRight.Font = new System.Drawing.Font("Arial", 18F);
            this.lbShowRight.Name = "lbShowRight";
            this.lbShowRight.Size = new System.Drawing.Size(57, 42);
            this.lbShowRight.Text = "XXX";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Font = new System.Drawing.Font("Arial", 18F);
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(64, 42);
            this.toolStripLabel1.Text = "ซื้ออีก :";
            // 
            // lblShowRightTotal
            // 
            this.lblShowRightTotal.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold);
            this.lblShowRightTotal.ForeColor = System.Drawing.Color.Red;
            this.lblShowRightTotal.Name = "lblShowRightTotal";
            this.lblShowRightTotal.Size = new System.Drawing.Size(39, 42);
            this.lblShowRightTotal.Text = "xx";
            // 
            // toolStripLabel3
            // 
            this.toolStripLabel3.Font = new System.Drawing.Font("Arial", 18F);
            this.toolStripLabel3.Name = "toolStripLabel3";
            this.toolStripLabel3.Size = new System.Drawing.Size(181, 42);
            this.toolStripLabel3.Text = "แก้ว จะได้รับเพิ่ม 1 สิทธิ";
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(0, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1082, 41);
            this.label1.TabIndex = 2;
            this.label1.Text = "Check 10 Free 1";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(356, 159);
            this.label3.Margin = new System.Windows.Forms.Padding(10, 10, 3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 31);
            this.label3.TabIndex = 30;
            this.label3.Text = "เลือกชื่อลูกค้า";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbbCustomer
            // 
            this.cbbCustomer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbbCustomer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbCustomer.Enabled = false;
            this.cbbCustomer.Font = new System.Drawing.Font("Arial", 15F);
            this.cbbCustomer.FormattingEnabled = true;
            this.cbbCustomer.Location = new System.Drawing.Point(490, 159);
            this.cbbCustomer.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.cbbCustomer.Name = "cbbCustomer";
            this.cbbCustomer.Size = new System.Drawing.Size(268, 31);
            this.cbbCustomer.TabIndex = 31;
            this.cbbCustomer.SelectionChangeCommitted += new System.EventHandler(this.cbbCustomer_SelectionChangeCommitted);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(356, 203);
            this.label2.Margin = new System.Windows.Forms.Padding(10, 10, 3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 31);
            this.label2.TabIndex = 32;
            this.label2.Text = "จำนวน";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btCal
            // 
            this.btCal.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btCal.BackColor = System.Drawing.Color.Lime;
            this.btCal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btCal.Enabled = false;
            this.btCal.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.btCal.Location = new System.Drawing.Point(490, 257);
            this.btCal.Name = "btCal";
            this.btCal.Size = new System.Drawing.Size(268, 44);
            this.btCal.TabIndex = 35;
            this.btCal.Text = "ใช้สิทธิ";
            this.btCal.UseVisualStyleBackColor = false;
            this.btCal.Click += new System.EventHandler(this.btCal_Click);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(771, 204);
            this.label4.Margin = new System.Windows.Forms.Padding(10, 10, 3, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(203, 31);
            this.label4.TabIndex = 32;
            this.label4.Text = "สิทธิ";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // udUnit
            // 
            this.udUnit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.udUnit.Enabled = false;
            this.udUnit.Font = new System.Drawing.Font("Arial", 15F);
            this.udUnit.Location = new System.Drawing.Point(490, 204);
            this.udUnit.Name = "udUnit";
            this.udUnit.ReadOnly = true;
            this.udUnit.Size = new System.Drawing.Size(268, 30);
            this.udUnit.TabIndex = 36;
            this.udUnit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // RightCF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1082, 604);
            this.ControlBox = false;
            this.Controls.Add(this.udUnit);
            this.Controls.Add(this.btCal);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbbCustomer);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tsMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RightCF";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CheckFree";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.RightCF_Load);
            this.tsMain.ResumeLayout(false);
            this.tsMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.udUnit)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStrip tsMain;
        private System.Windows.Forms.ToolStripButton btExit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbbCustomer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btCal;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown udUnit;
        private System.Windows.Forms.ToolStripLabel lbShowRight;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripLabel lblShowRightTotal;
        private System.Windows.Forms.ToolStripLabel toolStripLabel3;
    }
}