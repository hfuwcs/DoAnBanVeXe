namespace DoAnCuoiKy
{
    partial class QuanLyDoanhThuChuyen
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
            this.lblDoanhThu = new System.Windows.Forms.Label();
            this.lblTuNgay = new System.Windows.Forms.Label();
            this.lblTuyen = new System.Windows.Forms.Label();
            this.lblTongDoanhThu = new System.Windows.Forms.Label();
            this.txtTongDoanhThu = new System.Windows.Forms.TextBox();
            this.cboTuyen = new System.Windows.Forms.ComboBox();
            this.lblDenNgay = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.btnTinh = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblDoanhThu
            // 
            this.lblDoanhThu.AutoSize = true;
            this.lblDoanhThu.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDoanhThu.ForeColor = System.Drawing.Color.OrangeRed;
            this.lblDoanhThu.Location = new System.Drawing.Point(23, 18);
            this.lblDoanhThu.Name = "lblDoanhThu";
            this.lblDoanhThu.Size = new System.Drawing.Size(119, 25);
            this.lblDoanhThu.TabIndex = 0;
            this.lblDoanhThu.Text = "Doanh Thu";
            // 
            // lblTuNgay
            // 
            this.lblTuNgay.AutoSize = true;
            this.lblTuNgay.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblTuNgay.Location = new System.Drawing.Point(47, 87);
            this.lblTuNgay.Name = "lblTuNgay";
            this.lblTuNgay.Size = new System.Drawing.Size(64, 17);
            this.lblTuNgay.TabIndex = 1;
            this.lblTuNgay.Text = "Từ ngày:";
            // 
            // lblTuyen
            // 
            this.lblTuyen.AutoSize = true;
            this.lblTuyen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblTuyen.Location = new System.Drawing.Point(47, 174);
            this.lblTuyen.Name = "lblTuyen";
            this.lblTuyen.Size = new System.Drawing.Size(52, 17);
            this.lblTuyen.TabIndex = 2;
            this.lblTuyen.Text = "Tuyến:";
            // 
            // lblTongDoanhThu
            // 
            this.lblTongDoanhThu.AutoSize = true;
            this.lblTongDoanhThu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblTongDoanhThu.Location = new System.Drawing.Point(47, 261);
            this.lblTongDoanhThu.Name = "lblTongDoanhThu";
            this.lblTongDoanhThu.Size = new System.Drawing.Size(113, 17);
            this.lblTongDoanhThu.TabIndex = 3;
            this.lblTongDoanhThu.Text = "Tổng doanh thu:";
            // 
            // txtTongDoanhThu
            // 
            this.txtTongDoanhThu.Enabled = false;
            this.txtTongDoanhThu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtTongDoanhThu.Location = new System.Drawing.Point(201, 258);
            this.txtTongDoanhThu.Name = "txtTongDoanhThu";
            this.txtTongDoanhThu.Size = new System.Drawing.Size(396, 23);
            this.txtTongDoanhThu.TabIndex = 4;
            // 
            // cboTuyen
            // 
            this.cboTuyen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cboTuyen.FormattingEnabled = true;
            this.cboTuyen.Location = new System.Drawing.Point(201, 170);
            this.cboTuyen.Name = "cboTuyen";
            this.cboTuyen.Size = new System.Drawing.Size(396, 24);
            this.cboTuyen.TabIndex = 5;
            // 
            // lblDenNgay
            // 
            this.lblDenNgay.AutoSize = true;
            this.lblDenNgay.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblDenNgay.Location = new System.Drawing.Point(378, 87);
            this.lblDenNgay.Name = "lblDenNgay";
            this.lblDenNgay.Size = new System.Drawing.Size(73, 17);
            this.lblDenNgay.TabIndex = 6;
            this.lblDenNgay.Text = "Đến ngày:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.dateTimePicker1.Location = new System.Drawing.Point(201, 87);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(140, 20);
            this.dateTimePicker1.TabIndex = 7;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.dateTimePicker2.Location = new System.Drawing.Point(457, 87);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(140, 20);
            this.dateTimePicker2.TabIndex = 8;
            // 
            // btnTinh
            // 
            this.btnTinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnTinh.Location = new System.Drawing.Point(381, 361);
            this.btnTinh.Name = "btnTinh";
            this.btnTinh.Size = new System.Drawing.Size(75, 32);
            this.btnTinh.TabIndex = 9;
            this.btnTinh.Text = "Tính";
            this.btnTinh.UseVisualStyleBackColor = true;
            // 
            // btnThoat
            // 
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnThoat.Location = new System.Drawing.Point(522, 361);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 32);
            this.btnThoat.TabIndex = 10;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            // 
            // QuanLyDoanhThuChuyen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 543);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnTinh);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.lblDenNgay);
            this.Controls.Add(this.cboTuyen);
            this.Controls.Add(this.txtTongDoanhThu);
            this.Controls.Add(this.lblTongDoanhThu);
            this.Controls.Add(this.lblTuyen);
            this.Controls.Add(this.lblTuNgay);
            this.Controls.Add(this.lblDoanhThu);
            this.Name = "QuanLyDoanhThuChuyen";
            this.Text = "QuanLyDoanhThuChuyen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDoanhThu;
        private System.Windows.Forms.Label lblTuNgay;
        private System.Windows.Forms.Label lblTuyen;
        private System.Windows.Forms.Label lblTongDoanhThu;
        private System.Windows.Forms.TextBox txtTongDoanhThu;
        private System.Windows.Forms.ComboBox cboTuyen;
        private System.Windows.Forms.Label lblDenNgay;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Button btnTinh;
        private System.Windows.Forms.Button btnThoat;
    }
}