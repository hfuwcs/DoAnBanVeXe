namespace DoAnCuoiKy
{
    partial class BanVeXe
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
            this.btn_TrangChu = new System.Windows.Forms.Button();
            this.btn_MuaVe = new System.Windows.Forms.Button();
            this.btn_QuanLyChuyen = new System.Windows.Forms.Button();
            this.btn_Thoat = new System.Windows.Forms.Button();
            this.btn_DangNhap = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_TrangChu
            // 
            this.btn_TrangChu.Font = new System.Drawing.Font("Times New Roman", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_TrangChu.Location = new System.Drawing.Point(56, 22);
            this.btn_TrangChu.Name = "btn_TrangChu";
            this.btn_TrangChu.Size = new System.Drawing.Size(264, 84);
            this.btn_TrangChu.TabIndex = 2;
            this.btn_TrangChu.Text = "Trang chủ";
            this.btn_TrangChu.UseVisualStyleBackColor = true;
            this.btn_TrangChu.Click += new System.EventHandler(this.btn_TrangChu_Click);
            // 
            // btn_MuaVe
            // 
            this.btn_MuaVe.Font = new System.Drawing.Font("Times New Roman", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_MuaVe.Location = new System.Drawing.Point(56, 136);
            this.btn_MuaVe.Name = "btn_MuaVe";
            this.btn_MuaVe.Size = new System.Drawing.Size(264, 84);
            this.btn_MuaVe.TabIndex = 3;
            this.btn_MuaVe.Text = "Mua Vé";
            this.btn_MuaVe.UseVisualStyleBackColor = true;
            // 
            // btn_QuanLyChuyen
            // 
            this.btn_QuanLyChuyen.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_QuanLyChuyen.Location = new System.Drawing.Point(56, 250);
            this.btn_QuanLyChuyen.Name = "btn_QuanLyChuyen";
            this.btn_QuanLyChuyen.Size = new System.Drawing.Size(264, 110);
            this.btn_QuanLyChuyen.TabIndex = 4;
            this.btn_QuanLyChuyen.Text = "Quản lý chuyến";
            this.btn_QuanLyChuyen.UseVisualStyleBackColor = true;
            // 
            // btn_Thoat
            // 
            this.btn_Thoat.Font = new System.Drawing.Font("Times New Roman", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Thoat.Location = new System.Drawing.Point(55, 390);
            this.btn_Thoat.Name = "btn_Thoat";
            this.btn_Thoat.Size = new System.Drawing.Size(264, 84);
            this.btn_Thoat.TabIndex = 5;
            this.btn_Thoat.Text = "Thoát";
            this.btn_Thoat.UseVisualStyleBackColor = true;
            this.btn_Thoat.Click += new System.EventHandler(this.btn_Thoat_Click);
            // 
            // btn_DangNhap
            // 
            this.btn_DangNhap.Font = new System.Drawing.Font("Times New Roman", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_DangNhap.Location = new System.Drawing.Point(1161, 33);
            this.btn_DangNhap.Name = "btn_DangNhap";
            this.btn_DangNhap.Size = new System.Drawing.Size(264, 84);
            this.btn_DangNhap.TabIndex = 6;
            this.btn_DangNhap.Text = "Đăng Nhập";
            this.btn_DangNhap.UseVisualStyleBackColor = true;
            this.btn_DangNhap.Click += new System.EventHandler(this.btn_DangNhap_Click);
            // 
            // BanVeXe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::DoAnCuoiKy.Properties.Resources.futa;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1454, 669);
            this.Controls.Add(this.btn_DangNhap);
            this.Controls.Add(this.btn_Thoat);
            this.Controls.Add(this.btn_QuanLyChuyen);
            this.Controls.Add(this.btn_MuaVe);
            this.Controls.Add(this.btn_TrangChu);
            this.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "BanVeXe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_TrangChu;
        private System.Windows.Forms.Button btn_MuaVe;
        private System.Windows.Forms.Button btn_DangNhap;
        public System.Windows.Forms.Button btn_QuanLyChuyen;
        public System.Windows.Forms.Button btn_Thoat;
    }
}

