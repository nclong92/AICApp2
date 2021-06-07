
namespace AICServerFake
{
    partial class FrmAICServerFake
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblTrangThai = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lvLichSu = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label2 = new System.Windows.Forms.Label();
            this.btnDung = new System.Windows.Forms.Button();
            this.btnKhoiDong = new System.Windows.Forms.Button();
            this.txtUrl = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblTrangThai);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.lvLichSu);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnDung);
            this.groupBox1.Controls.Add(this.btnKhoiDong);
            this.groupBox1.Controls.Add(this.txtUrl);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(745, 588);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Server";
            // 
            // lblTrangThai
            // 
            this.lblTrangThai.AutoSize = true;
            this.lblTrangThai.Location = new System.Drawing.Point(87, 88);
            this.lblTrangThai.Name = "lblTrangThai";
            this.lblTrangThai.Size = new System.Drawing.Size(54, 13);
            this.lblTrangThai.TabIndex = 7;
            this.lblTrangThai.Text = "Đang chờ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Trạng thái:";
            // 
            // lvLichSu
            // 
            this.lvLichSu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lvLichSu.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.lvLichSu.HideSelection = false;
            this.lvLichSu.Location = new System.Drawing.Point(22, 157);
            this.lvLichSu.Name = "lvLichSu";
            this.lvLichSu.Size = new System.Drawing.Size(717, 420);
            this.lvLichSu.TabIndex = 5;
            this.lvLichSu.UseCompatibleStateImageBehavior = false;
            this.lvLichSu.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Chi tiết";
            this.columnHeader1.Width = 716;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(19, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Lịch sử";
            // 
            // btnDung
            // 
            this.btnDung.Location = new System.Drawing.Point(202, 53);
            this.btnDung.Name = "btnDung";
            this.btnDung.Size = new System.Drawing.Size(103, 23);
            this.btnDung.TabIndex = 3;
            this.btnDung.Text = "Dừng";
            this.btnDung.UseVisualStyleBackColor = true;
            this.btnDung.Click += new System.EventHandler(this.btnDung_Click);
            // 
            // btnKhoiDong
            // 
            this.btnKhoiDong.Location = new System.Drawing.Point(85, 53);
            this.btnKhoiDong.Name = "btnKhoiDong";
            this.btnKhoiDong.Size = new System.Drawing.Size(103, 23);
            this.btnKhoiDong.TabIndex = 2;
            this.btnKhoiDong.Text = "Khởi động";
            this.btnKhoiDong.UseVisualStyleBackColor = true;
            this.btnKhoiDong.Click += new System.EventHandler(this.btnKhoiDong_Click);
            // 
            // txtUrl
            // 
            this.txtUrl.Location = new System.Drawing.Point(85, 26);
            this.txtUrl.Name = "txtUrl";
            this.txtUrl.Size = new System.Drawing.Size(220, 20);
            this.txtUrl.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Url";
            // 
            // FrmAICServerFake
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(770, 607);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmAICServerFake";
            this.Text = "AIC Server";
            this.Load += new System.EventHandler(this.FrmAICServerFake_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListView lvLichSu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnDung;
        private System.Windows.Forms.Button btnKhoiDong;
        private System.Windows.Forms.TextBox txtUrl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.Label lblTrangThai;
        private System.Windows.Forms.Label label3;
    }
}

