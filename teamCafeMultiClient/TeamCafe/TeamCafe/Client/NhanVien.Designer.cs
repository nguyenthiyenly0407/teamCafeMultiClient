namespace TeamCafe.Client
{
    partial class NhanVien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NhanVien));
            this.flowPanel_Table = new System.Windows.Forms.FlowLayoutPanel();
            this.nmThemMon = new System.Windows.Forms.NumericUpDown();
            this.btnThemMon = new System.Windows.Forms.Button();
            this.cbFood = new System.Windows.Forms.ComboBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.cbCategory = new System.Windows.Forms.ComboBox();
            this.textBox_totalPrice = new System.Windows.Forms.TextBox();
            this.nmGiamGia = new System.Windows.Forms.NumericUpDown();
            this.btnGiamGia = new System.Windows.Forms.Button();
            this.btnThanhToan = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvBill = new System.Windows.Forms.ListView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.thongTinTaiKhoanTool = new System.Windows.Forms.ToolStripMenuItem();
            this.thongTinCaNhan = new System.Windows.Forms.ToolStripMenuItem();
            this.dangXuat = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            ((System.ComponentModel.ISupportInitialize)(this.nmThemMon)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmGiamGia)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowPanel_Table
            // 
            this.flowPanel_Table.AutoScroll = true;
            this.flowPanel_Table.Location = new System.Drawing.Point(16, 34);
            this.flowPanel_Table.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.flowPanel_Table.Name = "flowPanel_Table";
            this.flowPanel_Table.Size = new System.Drawing.Size(764, 593);
            this.flowPanel_Table.TabIndex = 18;
            // 
            // nmThemMon
            // 
            this.nmThemMon.Location = new System.Drawing.Point(354, 25);
            this.nmThemMon.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.nmThemMon.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.nmThemMon.Name = "nmThemMon";
            this.nmThemMon.Size = new System.Drawing.Size(66, 25);
            this.nmThemMon.TabIndex = 8;
            this.nmThemMon.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnThemMon
            // 
            this.btnThemMon.Location = new System.Drawing.Point(461, 22);
            this.btnThemMon.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnThemMon.Name = "btnThemMon";
            this.btnThemMon.Size = new System.Drawing.Size(125, 32);
            this.btnThemMon.TabIndex = 7;
            this.btnThemMon.Text = "Thêm món";
            this.btnThemMon.UseVisualStyleBackColor = true;
            this.btnThemMon.Click += new System.EventHandler(this.btnThemMon_Click);
            // 
            // cbFood
            // 
            this.cbFood.FormattingEnabled = true;
            this.cbFood.Location = new System.Drawing.Point(5, 42);
            this.cbFood.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.cbFood.Name = "cbFood";
            this.cbFood.Size = new System.Drawing.Size(309, 26);
            this.cbFood.TabIndex = 6;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.nmThemMon);
            this.panel4.Controls.Add(this.btnThemMon);
            this.panel4.Controls.Add(this.cbFood);
            this.panel4.Controls.Add(this.cbCategory);
            this.panel4.Location = new System.Drawing.Point(794, 34);
            this.panel4.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(609, 78);
            this.panel4.TabIndex = 16;
            // 
            // cbCategory
            // 
            this.cbCategory.FormattingEnabled = true;
            this.cbCategory.Location = new System.Drawing.Point(5, 4);
            this.cbCategory.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.cbCategory.Name = "cbCategory";
            this.cbCategory.Size = new System.Drawing.Size(309, 26);
            this.cbCategory.TabIndex = 5;
            this.cbCategory.SelectedIndexChanged += new System.EventHandler(this.cbCategory_SelectedIndexChanged);
            // 
            // textBox_totalPrice
            // 
            this.textBox_totalPrice.Location = new System.Drawing.Point(255, 28);
            this.textBox_totalPrice.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.textBox_totalPrice.Name = "textBox_totalPrice";
            this.textBox_totalPrice.ReadOnly = true;
            this.textBox_totalPrice.Size = new System.Drawing.Size(213, 25);
            this.textBox_totalPrice.TabIndex = 14;
            this.textBox_totalPrice.Text = "0";
            this.textBox_totalPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // nmGiamGia
            // 
            this.nmGiamGia.Location = new System.Drawing.Point(5, 52);
            this.nmGiamGia.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.nmGiamGia.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.nmGiamGia.Name = "nmGiamGia";
            this.nmGiamGia.Size = new System.Drawing.Size(124, 25);
            this.nmGiamGia.TabIndex = 11;
            this.nmGiamGia.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnGiamGia
            // 
            this.btnGiamGia.Location = new System.Drawing.Point(1, 9);
            this.btnGiamGia.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnGiamGia.Name = "btnGiamGia";
            this.btnGiamGia.Size = new System.Drawing.Size(129, 36);
            this.btnGiamGia.TabIndex = 10;
            this.btnGiamGia.Text = "Giảm giá (%)";
            this.btnGiamGia.UseVisualStyleBackColor = true;
            // 
            // btnThanhToan
            // 
            this.btnThanhToan.Location = new System.Drawing.Point(479, 4);
            this.btnThanhToan.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnThanhToan.Name = "btnThanhToan";
            this.btnThanhToan.Size = new System.Drawing.Size(125, 73);
            this.btnThanhToan.TabIndex = 9;
            this.btnThanhToan.Text = "Thanh toán";
            this.btnThanhToan.UseVisualStyleBackColor = true;
            this.btnThanhToan.Click += new System.EventHandler(this.btnThanhToan_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.textBox_totalPrice);
            this.panel3.Controls.Add(this.nmGiamGia);
            this.panel3.Controls.Add(this.btnGiamGia);
            this.panel3.Controls.Add(this.btnThanhToan);
            this.panel3.Location = new System.Drawing.Point(794, 544);
            this.panel3.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(609, 82);
            this.panel3.TabIndex = 14;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Thành tiền";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader4.Width = 100;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Đơn giá";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader3.Width = 66;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Số lượng";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 65;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "            Tên món ";
            this.columnHeader1.Width = 129;
            // 
            // lvBill
            // 
            this.lvBill.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.lvBill.GridLines = true;
            this.lvBill.HideSelection = false;
            this.lvBill.Location = new System.Drawing.Point(5, 4);
            this.lvBill.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.lvBill.Name = "lvBill";
            this.lvBill.Size = new System.Drawing.Size(600, 411);
            this.lvBill.TabIndex = 4;
            this.lvBill.UseCompatibleStateImageBehavior = false;
            this.lvBill.View = System.Windows.Forms.View.Details;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lvBill);
            this.panel2.Location = new System.Drawing.Point(794, 116);
            this.panel2.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(614, 421);
            this.panel2.TabIndex = 12;
            // 
            // thongTinTaiKhoanTool
            // 
            this.thongTinTaiKhoanTool.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thongTinCaNhan,
            this.dangXuat});
            this.thongTinTaiKhoanTool.Name = "thongTinTaiKhoanTool";
            this.thongTinTaiKhoanTool.Size = new System.Drawing.Size(182, 29);
            this.thongTinTaiKhoanTool.Text = "Thông tin tài khoản";
            // 
            // thongTinCaNhan
            // 
            this.thongTinCaNhan.Name = "thongTinCaNhan";
            this.thongTinCaNhan.Size = new System.Drawing.Size(256, 34);
            this.thongTinCaNhan.Text = "Thông tin cá nhân";
            this.thongTinCaNhan.Click += new System.EventHandler(this.thongTinCaNhan_Click);
            // 
            // dangXuat
            // 
            this.dangXuat.Name = "dangXuat";
            this.dangXuat.Size = new System.Drawing.Size(256, 34);
            this.dangXuat.Text = "Đăng xuất";
            this.dangXuat.Click += new System.EventHandler(this.dangXuat_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thongTinTaiKhoanTool});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(6, 1, 0, 1);
            this.menuStrip1.Size = new System.Drawing.Size(1529, 31);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // NhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaShell;
            this.ClientSize = new System.Drawing.Size(1529, 884);
            this.Controls.Add(this.flowPanel_Table);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "NhanVien";
            this.Text = "Nhân Viên";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.NhanVien_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.nmThemMon)).EndInit();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nmGiamGia)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowPanel_Table;
        private System.Windows.Forms.NumericUpDown nmThemMon;
        private System.Windows.Forms.Button btnThemMon;
        private System.Windows.Forms.ComboBox cbFood;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.ComboBox cbCategory;
        private System.Windows.Forms.TextBox textBox_totalPrice;
        private System.Windows.Forms.NumericUpDown nmGiamGia;
        private System.Windows.Forms.Button btnGiamGia;
        private System.Windows.Forms.Button btnThanhToan;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ListView lvBill;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ToolStripMenuItem thongTinTaiKhoanTool;
        private System.Windows.Forms.ToolStripMenuItem thongTinCaNhan;
        private System.Windows.Forms.ToolStripMenuItem dangXuat;
        private System.Windows.Forms.MenuStrip menuStrip1;
    }
}