﻿
namespace AICSenderFake
{
    partial class FrmAICSenderFake
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAICSenderFake));
            this.lblTrangThai = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnKetNoi = new System.Windows.Forms.Button();
            this.txtServerAIC = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtGhe = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lbl1ThongBao = new System.Windows.Forms.Label();
            this.rdnHuy = new System.Windows.Forms.RadioButton();
            this.btn1Gui = new System.Windows.Forms.Button();
            this.rd1DangKy = new System.Windows.Forms.RadioButton();
            this.rd1Huy = new System.Windows.Forms.RadioButton();
            this.numLenh = new System.Windows.Forms.NumericUpDown();
            this.btnnGui = new System.Windows.Forms.Button();
            this.lblnThongBao = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.rdnDangKy = new System.Windows.Forms.RadioButton();
            this.rdnNgauNhien = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.grpSend = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numLenh)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.grpSend.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTrangThai
            // 
            this.lblTrangThai.AutoSize = true;
            this.lblTrangThai.Location = new System.Drawing.Point(171, 135);
            this.lblTrangThai.Name = "lblTrangThai";
            this.lblTrangThai.Size = new System.Drawing.Size(61, 13);
            this.lblTrangThai.TabIndex = 7;
            this.lblTrangThai.Text = "Chờ kết nối";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(93, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Trạng thái:";
            // 
            // btnHuy
            // 
            this.btnHuy.Enabled = false;
            this.btnHuy.Location = new System.Drawing.Point(422, 95);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(96, 23);
            this.btnHuy.TabIndex = 5;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnKetNoi
            // 
            this.btnKetNoi.Location = new System.Drawing.Point(320, 96);
            this.btnKetNoi.Name = "btnKetNoi";
            this.btnKetNoi.Size = new System.Drawing.Size(96, 23);
            this.btnKetNoi.TabIndex = 4;
            this.btnKetNoi.Text = "Kết nối";
            this.btnKetNoi.UseVisualStyleBackColor = true;
            this.btnKetNoi.Click += new System.EventHandler(this.btnKetNoi_Click);
            // 
            // txtServerAIC
            // 
            this.txtServerAIC.Location = new System.Drawing.Point(96, 98);
            this.txtServerAIC.Name = "txtServerAIC";
            this.txtServerAIC.Size = new System.Drawing.Size(207, 20);
            this.txtServerAIC.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(281, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(175, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "AIC Sender Fake";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Server AIC";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(17, 174);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(271, 24);
            this.label7.TabIndex = 27;
            this.label7.Text = "Giả lập gửi n lệnh Random vị trí";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(17, 53);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(156, 24);
            this.label5.TabIndex = 22;
            this.label5.Text = "Giả lập gửi 1 lệnh";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(163, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(112, 61);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // txtGhe
            // 
            this.txtGhe.Location = new System.Drawing.Point(49, 19);
            this.txtGhe.Name = "txtGhe";
            this.txtGhe.Size = new System.Drawing.Size(62, 20);
            this.txtGhe.TabIndex = 24;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(27, 13);
            this.label6.TabIndex = 23;
            this.label6.Text = "Ghế";
            // 
            // lbl1ThongBao
            // 
            this.lbl1ThongBao.AutoSize = true;
            this.lbl1ThongBao.Location = new System.Drawing.Point(17, 54);
            this.lbl1ThongBao.Name = "lbl1ThongBao";
            this.lbl1ThongBao.Size = new System.Drawing.Size(0, 13);
            this.lbl1ThongBao.TabIndex = 35;
            // 
            // rdnHuy
            // 
            this.rdnHuy.AutoSize = true;
            this.rdnHuy.Location = new System.Drawing.Point(239, 22);
            this.rdnHuy.Name = "rdnHuy";
            this.rdnHuy.Size = new System.Drawing.Size(44, 17);
            this.rdnHuy.TabIndex = 32;
            this.rdnHuy.Text = "Hủy";
            this.rdnHuy.UseVisualStyleBackColor = true;
            // 
            // btn1Gui
            // 
            this.btn1Gui.Location = new System.Drawing.Point(296, 17);
            this.btn1Gui.Name = "btn1Gui";
            this.btn1Gui.Size = new System.Drawing.Size(96, 23);
            this.btn1Gui.TabIndex = 25;
            this.btn1Gui.Text = "Gửi";
            this.btn1Gui.UseVisualStyleBackColor = true;
            this.btn1Gui.Click += new System.EventHandler(this.btn1Gui_Click);
            // 
            // rd1DangKy
            // 
            this.rd1DangKy.AutoSize = true;
            this.rd1DangKy.Checked = true;
            this.rd1DangKy.Location = new System.Drawing.Point(144, 21);
            this.rd1DangKy.Name = "rd1DangKy";
            this.rd1DangKy.Size = new System.Drawing.Size(65, 17);
            this.rd1DangKy.TabIndex = 29;
            this.rd1DangKy.TabStop = true;
            this.rd1DangKy.Text = "Đăng ký";
            this.rd1DangKy.UseVisualStyleBackColor = true;
            // 
            // rd1Huy
            // 
            this.rd1Huy.AutoSize = true;
            this.rd1Huy.Location = new System.Drawing.Point(226, 21);
            this.rd1Huy.Name = "rd1Huy";
            this.rd1Huy.Size = new System.Drawing.Size(44, 17);
            this.rd1Huy.TabIndex = 30;
            this.rd1Huy.Text = "Hủy";
            this.rd1Huy.UseVisualStyleBackColor = true;
            // 
            // numLenh
            // 
            this.numLenh.Location = new System.Drawing.Point(63, 19);
            this.numLenh.Name = "numLenh";
            this.numLenh.Size = new System.Drawing.Size(62, 20);
            this.numLenh.TabIndex = 34;
            this.numLenh.Value = new decimal(new int[] {
            66,
            0,
            0,
            0});
            // 
            // btnnGui
            // 
            this.btnnGui.Location = new System.Drawing.Point(400, 19);
            this.btnnGui.Name = "btnnGui";
            this.btnnGui.Size = new System.Drawing.Size(96, 23);
            this.btnnGui.TabIndex = 26;
            this.btnnGui.Text = "Gửi";
            this.btnnGui.UseVisualStyleBackColor = true;
            this.btnnGui.Click += new System.EventHandler(this.btnnGui_Click);
            // 
            // lblnThongBao
            // 
            this.lblnThongBao.AutoSize = true;
            this.lblnThongBao.Location = new System.Drawing.Point(17, 58);
            this.lblnThongBao.Name = "lblnThongBao";
            this.lblnThongBao.Size = new System.Drawing.Size(0, 13);
            this.lblnThongBao.TabIndex = 36;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(14, 24);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 13);
            this.label8.TabIndex = 28;
            this.label8.Text = "Số lệnh";
            // 
            // rdnDangKy
            // 
            this.rdnDangKy.AutoSize = true;
            this.rdnDangKy.Checked = true;
            this.rdnDangKy.Location = new System.Drawing.Point(159, 22);
            this.rdnDangKy.Name = "rdnDangKy";
            this.rdnDangKy.Size = new System.Drawing.Size(65, 17);
            this.rdnDangKy.TabIndex = 31;
            this.rdnDangKy.TabStop = true;
            this.rdnDangKy.Text = "Đăng ký";
            this.rdnDangKy.UseVisualStyleBackColor = true;
            // 
            // rdnNgauNhien
            // 
            this.rdnNgauNhien.AutoSize = true;
            this.rdnNgauNhien.Location = new System.Drawing.Point(292, 22);
            this.rdnNgauNhien.Name = "rdnNgauNhien";
            this.rdnNgauNhien.Size = new System.Drawing.Size(80, 17);
            this.rdnNgauNhien.TabIndex = 33;
            this.rdnNgauNhien.Text = "Ngẫu nhiên";
            this.rdnNgauNhien.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.numLenh);
            this.groupBox3.Controls.Add(this.btnnGui);
            this.groupBox3.Controls.Add(this.lblnThongBao);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.rdnDangKy);
            this.groupBox3.Controls.Add(this.rdnNgauNhien);
            this.groupBox3.Controls.Add(this.rdnHuy);
            this.groupBox3.Location = new System.Drawing.Point(7, 217);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(572, 77);
            this.groupBox3.TabIndex = 38;
            this.groupBox3.TabStop = false;
            // 
            // grpSend
            // 
            this.grpSend.Controls.Add(this.groupBox3);
            this.grpSend.Controls.Add(this.groupBox2);
            this.grpSend.Controls.Add(this.label7);
            this.grpSend.Controls.Add(this.label5);
            this.grpSend.Enabled = false;
            this.grpSend.Location = new System.Drawing.Point(9, 170);
            this.grpSend.Name = "grpSend";
            this.grpSend.Size = new System.Drawing.Size(585, 331);
            this.grpSend.TabIndex = 8;
            this.grpSend.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtGhe);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.lbl1ThongBao);
            this.groupBox2.Controls.Add(this.btn1Gui);
            this.groupBox2.Controls.Add(this.rd1DangKy);
            this.groupBox2.Controls.Add(this.rd1Huy);
            this.groupBox2.Location = new System.Drawing.Point(7, 81);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(572, 73);
            this.groupBox2.TabIndex = 37;
            this.groupBox2.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.grpSend);
            this.groupBox1.Controls.Add(this.lblTrangThai);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.btnHuy);
            this.groupBox1.Controls.Add(this.btnKetNoi);
            this.groupBox1.Controls.Add(this.txtServerAIC);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(601, 496);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // FrmAICSenderFake
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(625, 525);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmAICSenderFake";
            this.Text = "AIC Sender";
            this.Load += new System.EventHandler(this.FrmAICSenderFake_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numLenh)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.grpSend.ResumeLayout(false);
            this.grpSend.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTrangThai;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnKetNoi;
        private System.Windows.Forms.TextBox txtServerAIC;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtGhe;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbl1ThongBao;
        private System.Windows.Forms.RadioButton rdnHuy;
        private System.Windows.Forms.Button btn1Gui;
        private System.Windows.Forms.RadioButton rd1DangKy;
        private System.Windows.Forms.RadioButton rd1Huy;
        private System.Windows.Forms.NumericUpDown numLenh;
        private System.Windows.Forms.Button btnnGui;
        private System.Windows.Forms.Label lblnThongBao;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RadioButton rdnDangKy;
        private System.Windows.Forms.RadioButton rdnNgauNhien;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox grpSend;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

