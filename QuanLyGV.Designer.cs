﻿
namespace QuanLy_HS_GV_THPT
{
    partial class QuanLyGV
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QuanLyGV));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.reset = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.helpBTN = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ReturnGV = new System.Windows.Forms.Button();
            this.Search = new System.Windows.Forms.Button();
            this.Xoa = new System.Windows.Forms.Button();
            this.Sua = new System.Windows.Forms.Button();
            this.Them = new System.Windows.Forms.Button();
            this.txtDate = new System.Windows.Forms.DateTimePicker();
            this.txtGioiTinh = new System.Windows.Forms.ComboBox();
            this.txtMaGV = new System.Windows.Forms.TextBox();
            this.txtTenGV = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.DiaChi = new System.Windows.Forms.Label();
            this.Phone = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.DodgerBlue;
            this.groupBox2.Controls.Add(this.reset);
            this.groupBox2.Controls.Add(this.txtSearch);
            this.groupBox2.Controls.Add(this.helpBTN);
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Controls.Add(this.ReturnGV);
            this.groupBox2.Controls.Add(this.Search);
            this.groupBox2.Controls.Add(this.Xoa);
            this.groupBox2.Controls.Add(this.Sua);
            this.groupBox2.Controls.Add(this.Them);
            this.groupBox2.Controls.Add(this.txtDate);
            this.groupBox2.Controls.Add(this.txtGioiTinh);
            this.groupBox2.Controls.Add(this.txtMaGV);
            this.groupBox2.Controls.Add(this.txtTenGV);
            this.groupBox2.Controls.Add(this.txtPhone);
            this.groupBox2.Controls.Add(this.txtDiaChi);
            this.groupBox2.Controls.Add(this.DiaChi);
            this.groupBox2.Controls.Add(this.Phone);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(1, -1);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Size = new System.Drawing.Size(836, 371);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // reset
            // 
            this.reset.Image = ((System.Drawing.Image)(resources.GetObject("reset.Image")));
            this.reset.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.reset.Location = new System.Drawing.Point(116, 336);
            this.reset.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.reset.Name = "reset";
            this.reset.Size = new System.Drawing.Size(65, 25);
            this.reset.TabIndex = 19;
            this.reset.Text = "Reset";
            this.reset.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.reset.UseVisualStyleBackColor = true;
            this.reset.Click += new System.EventHandler(this.reset_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(82, 262);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(109, 22);
            this.txtSearch.TabIndex = 18;
            this.txtSearch.TextChanged += new System.EventHandler(this.textTim_TextChanged);
            // 
            // helpBTN
            // 
            this.helpBTN.BackColor = System.Drawing.Color.White;
            this.helpBTN.Image = global::QuanLy_HS_GV_THPT.Properties.Resources.help;
            this.helpBTN.Location = new System.Drawing.Point(127, 0);
            this.helpBTN.Margin = new System.Windows.Forms.Padding(2);
            this.helpBTN.Name = "helpBTN";
            this.helpBTN.Size = new System.Drawing.Size(25, 24);
            this.helpBTN.TabIndex = 18;
            this.helpBTN.UseVisualStyleBackColor = false;
            this.helpBTN.Click += new System.EventHandler(this.helpBTN_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(206, 0);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(630, 371);
            this.dataGridView1.TabIndex = 17;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // ReturnGV
            // 
            this.ReturnGV.BackColor = System.Drawing.Color.White;
            this.ReturnGV.Image = ((System.Drawing.Image)(resources.GetObject("ReturnGV.Image")));
            this.ReturnGV.Location = new System.Drawing.Point(0, 0);
            this.ReturnGV.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ReturnGV.Name = "ReturnGV";
            this.ReturnGV.Size = new System.Drawing.Size(33, 30);
            this.ReturnGV.TabIndex = 16;
            this.ReturnGV.UseVisualStyleBackColor = false;
            this.ReturnGV.Click += new System.EventHandler(this.ReturnGV_Click);
            // 
            // Search
            // 
            this.Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Search.Image = ((System.Drawing.Image)(resources.GetObject("Search.Image")));
            this.Search.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Search.Location = new System.Drawing.Point(8, 258);
            this.Search.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(59, 25);
            this.Search.TabIndex = 15;
            this.Search.Text = "Tìm Kiếm";
            this.Search.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Search.UseVisualStyleBackColor = true;
            this.Search.Click += new System.EventHandler(this.TimKiem_Click);
            // 
            // Xoa
            // 
            this.Xoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Xoa.Image = ((System.Drawing.Image)(resources.GetObject("Xoa.Image")));
            this.Xoa.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Xoa.Location = new System.Drawing.Point(116, 295);
            this.Xoa.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Xoa.Name = "Xoa";
            this.Xoa.Size = new System.Drawing.Size(65, 24);
            this.Xoa.TabIndex = 14;
            this.Xoa.Text = "Xóa";
            this.Xoa.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Xoa.UseVisualStyleBackColor = true;
            this.Xoa.Click += new System.EventHandler(this.Xoa_Click);
            // 
            // Sua
            // 
            this.Sua.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sua.Image = ((System.Drawing.Image)(resources.GetObject("Sua.Image")));
            this.Sua.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Sua.Location = new System.Drawing.Point(8, 336);
            this.Sua.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Sua.Name = "Sua";
            this.Sua.Size = new System.Drawing.Size(59, 25);
            this.Sua.TabIndex = 13;
            this.Sua.Text = "Sửa";
            this.Sua.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Sua.UseVisualStyleBackColor = true;
            this.Sua.Click += new System.EventHandler(this.Sua_Click);
            // 
            // Them
            // 
            this.Them.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Them.Image = ((System.Drawing.Image)(resources.GetObject("Them.Image")));
            this.Them.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Them.Location = new System.Drawing.Point(8, 295);
            this.Them.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Them.Name = "Them";
            this.Them.Size = new System.Drawing.Size(58, 24);
            this.Them.TabIndex = 12;
            this.Them.Text = "Thêm";
            this.Them.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Them.UseVisualStyleBackColor = true;
            // 
            // txtDate
            // 
            this.txtDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtDate.Location = new System.Drawing.Point(82, 148);
            this.txtDate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(110, 22);
            this.txtDate.TabIndex = 11;
            // 
            // txtGioiTinh
            // 
            this.txtGioiTinh.FormattingEnabled = true;
            this.txtGioiTinh.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.txtGioiTinh.Location = new System.Drawing.Point(82, 112);
            this.txtGioiTinh.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtGioiTinh.Name = "txtGioiTinh";
            this.txtGioiTinh.Size = new System.Drawing.Size(110, 24);
            this.txtGioiTinh.TabIndex = 10;
            this.txtGioiTinh.SelectedIndexChanged += new System.EventHandler(this.txtGioiTinh_SelectedIndexChanged);
            // 
            // txtMaGV
            // 
            this.txtMaGV.Location = new System.Drawing.Point(82, 39);
            this.txtMaGV.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtMaGV.Name = "txtMaGV";
            this.txtMaGV.Size = new System.Drawing.Size(110, 22);
            this.txtMaGV.TabIndex = 9;
            // 
            // txtTenGV
            // 
            this.txtTenGV.Location = new System.Drawing.Point(82, 76);
            this.txtTenGV.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtTenGV.Name = "txtTenGV";
            this.txtTenGV.Size = new System.Drawing.Size(110, 22);
            this.txtTenGV.TabIndex = 8;
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(82, 186);
            this.txtPhone.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(110, 22);
            this.txtPhone.TabIndex = 7;
            this.txtPhone.TextChanged += new System.EventHandler(this.txtPhone_TextChanged);
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(82, 221);
            this.txtDiaChi.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(110, 22);
            this.txtDiaChi.TabIndex = 6;
            this.txtDiaChi.TextChanged += new System.EventHandler(this.txtDiaChi_TextChanged);
            // 
            // DiaChi
            // 
            this.DiaChi.AutoSize = true;
            this.DiaChi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DiaChi.Location = new System.Drawing.Point(4, 221);
            this.DiaChi.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.DiaChi.Name = "DiaChi";
            this.DiaChi.Size = new System.Drawing.Size(58, 17);
            this.DiaChi.TabIndex = 5;
            this.DiaChi.Text = "Địa chỉ";
            this.DiaChi.Click += new System.EventHandler(this.DiaChi_Click);
            // 
            // Phone
            // 
            this.Phone.AutoSize = true;
            this.Phone.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Phone.Location = new System.Drawing.Point(5, 186);
            this.Phone.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Phone.Name = "Phone";
            this.Phone.Size = new System.Drawing.Size(54, 17);
            this.Phone.TabIndex = 4;
            this.Phone.Text = "Phone";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(4, 148);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(4, 112);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Giới Tính";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(4, 76);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên GV";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(4, 39);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã GV";
            // 
            // QuanLyGV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(833, 366);
            this.Controls.Add(this.groupBox2);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "QuanLyGV";
            this.Text = "QuanLyGV";
            this.Load += new System.EventHandler(this.QuanLyGV_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtMaGV;
        private System.Windows.Forms.TextBox txtTenGV;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.Label DiaChi;
        private System.Windows.Forms.Label Phone;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Search;
        private System.Windows.Forms.Button Xoa;
        private System.Windows.Forms.Button Sua;
        private System.Windows.Forms.Button Them;
        private System.Windows.Forms.DateTimePicker txtDate;
        private System.Windows.Forms.ComboBox txtGioiTinh;
        private System.Windows.Forms.Button ReturnGV;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button reset;
        private System.Windows.Forms.Button helpBTN;
    }
}

