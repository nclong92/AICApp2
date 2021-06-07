
namespace AICListener
{
    partial class FrmAICListener
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAICListener));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnXuatExcel = new System.Windows.Forms.Button();
            this.lblTrangThai = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnKetNoi = new System.Windows.Forms.Button();
            this.txtServerAIC = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabListener = new System.Windows.Forms.TabControl();
            this.tabDanhSachDangKy = new System.Windows.Forms.TabPage();
            this.tabLichSu = new System.Windows.Forms.TabPage();
            this.lvLichSu = new System.Windows.Forms.ListView();
            this.colHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvDanhSachDangKy = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabListener.SuspendLayout();
            this.tabDanhSachDangKy.SuspendLayout();
            this.tabLichSu.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tabListener);
            this.groupBox1.Controls.Add(this.txtSearch);
            this.groupBox1.Controls.Add(this.btnXuatExcel);
            this.groupBox1.Controls.Add(this.lblTrangThai);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.btnHuy);
            this.groupBox1.Controls.Add(this.btnKetNoi);
            this.groupBox1.Controls.Add(this.txtServerAIC);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(856, 632);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(694, 161);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(153, 20);
            this.txtSearch.TabIndex = 12;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // btnXuatExcel
            // 
            this.btnXuatExcel.Location = new System.Drawing.Point(588, 159);
            this.btnXuatExcel.Name = "btnXuatExcel";
            this.btnXuatExcel.Size = new System.Drawing.Size(100, 23);
            this.btnXuatExcel.TabIndex = 10;
            this.btnXuatExcel.Text = "Xuất Excel";
            this.btnXuatExcel.UseVisualStyleBackColor = true;
            this.btnXuatExcel.Click += new System.EventHandler(this.btnXuatExcel_Click);
            // 
            // lblTrangThai
            // 
            this.lblTrangThai.AutoSize = true;
            this.lblTrangThai.Location = new System.Drawing.Point(155, 129);
            this.lblTrangThai.Name = "lblTrangThai";
            this.lblTrangThai.Size = new System.Drawing.Size(61, 13);
            this.lblTrangThai.TabIndex = 9;
            this.lblTrangThai.Text = "Chờ kết nối";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(81, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Trạng thái:";
            // 
            // btnHuy
            // 
            this.btnHuy.Enabled = false;
            this.btnHuy.Location = new System.Drawing.Point(346, 92);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(100, 23);
            this.btnHuy.TabIndex = 7;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnKetNoi
            // 
            this.btnKetNoi.Location = new System.Drawing.Point(240, 93);
            this.btnKetNoi.Name = "btnKetNoi";
            this.btnKetNoi.Size = new System.Drawing.Size(100, 23);
            this.btnKetNoi.TabIndex = 6;
            this.btnKetNoi.Text = "Kết nối";
            this.btnKetNoi.UseVisualStyleBackColor = true;
            this.btnKetNoi.Click += new System.EventHandler(this.btnKetNoi_Click);
            // 
            // txtServerAIC
            // 
            this.txtServerAIC.Location = new System.Drawing.Point(81, 95);
            this.txtServerAIC.Name = "txtServerAIC";
            this.txtServerAIC.Size = new System.Drawing.Size(153, 20);
            this.txtServerAIC.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Server AIC";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(382, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "AIC Listener";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(260, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 56);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // tabListener
            // 
            this.tabListener.Controls.Add(this.tabDanhSachDangKy);
            this.tabListener.Controls.Add(this.tabLichSu);
            this.tabListener.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabListener.Location = new System.Drawing.Point(20, 187);
            this.tabListener.Name = "tabListener";
            this.tabListener.SelectedIndex = 0;
            this.tabListener.Size = new System.Drawing.Size(827, 438);
            this.tabListener.TabIndex = 14;
            this.tabListener.Tag = "";
            this.tabListener.SelectedIndexChanged += new System.EventHandler(this.tabListener_SelectedIndexChanged);
            // 
            // tabDanhSachDangKy
            // 
            this.tabDanhSachDangKy.Controls.Add(this.lvDanhSachDangKy);
            this.tabDanhSachDangKy.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabDanhSachDangKy.Location = new System.Drawing.Point(4, 29);
            this.tabDanhSachDangKy.Name = "tabDanhSachDangKy";
            this.tabDanhSachDangKy.Padding = new System.Windows.Forms.Padding(3);
            this.tabDanhSachDangKy.Size = new System.Drawing.Size(819, 405);
            this.tabDanhSachDangKy.TabIndex = 0;
            this.tabDanhSachDangKy.Text = "Danh sách đăng ký";
            this.tabDanhSachDangKy.UseVisualStyleBackColor = true;
            // 
            // tabLichSu
            // 
            this.tabLichSu.Controls.Add(this.lvLichSu);
            this.tabLichSu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabLichSu.Location = new System.Drawing.Point(4, 29);
            this.tabLichSu.Name = "tabLichSu";
            this.tabLichSu.Padding = new System.Windows.Forms.Padding(3);
            this.tabLichSu.Size = new System.Drawing.Size(819, 399);
            this.tabLichSu.TabIndex = 1;
            this.tabLichSu.Text = "Lịch sử";
            this.tabLichSu.UseVisualStyleBackColor = true;
            // 
            // lvLichSu
            // 
            this.lvLichSu.Alignment = System.Windows.Forms.ListViewAlignment.Default;
            this.lvLichSu.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colHeader});
            this.lvLichSu.HideSelection = false;
            this.lvLichSu.Location = new System.Drawing.Point(6, 6);
            this.lvLichSu.Name = "lvLichSu";
            this.lvLichSu.Size = new System.Drawing.Size(807, 394);
            this.lvLichSu.TabIndex = 15;
            this.lvLichSu.UseCompatibleStateImageBehavior = false;
            this.lvLichSu.View = System.Windows.Forms.View.Details;
            // 
            // colHeader
            // 
            this.colHeader.Text = "Chi tiết";
            this.colHeader.Width = 799;
            // 
            // lvDanhSachDangKy
            // 
            this.lvDanhSachDangKy.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.lvDanhSachDangKy.HideSelection = false;
            this.lvDanhSachDangKy.Location = new System.Drawing.Point(4, 7);
            this.lvDanhSachDangKy.Name = "lvDanhSachDangKy";
            this.lvDanhSachDangKy.Size = new System.Drawing.Size(809, 392);
            this.lvDanhSachDangKy.TabIndex = 0;
            this.lvDanhSachDangKy.UseCompatibleStateImageBehavior = false;
            this.lvDanhSachDangKy.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Danh sách đăng ký";
            this.columnHeader1.Width = 803;
            // 
            // FrmAICListener
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(875, 651);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmAICListener";
            this.Text = "AIC Listener";
            this.Load += new System.EventHandler(this.FrmAICListener_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabListener.ResumeLayout(false);
            this.tabDanhSachDangKy.ResumeLayout(false);
            this.tabLichSu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnXuatExcel;
        private System.Windows.Forms.Label lblTrangThai;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnKetNoi;
        private System.Windows.Forms.TextBox txtServerAIC;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TabControl tabListener;
        private System.Windows.Forms.TabPage tabDanhSachDangKy;
        private System.Windows.Forms.TabPage tabLichSu;
        private System.Windows.Forms.ListView lvLichSu;
        private System.Windows.Forms.ColumnHeader colHeader;
        private System.Windows.Forms.ListView lvDanhSachDangKy;
        private System.Windows.Forms.ColumnHeader columnHeader1;
    }
}

