namespace DoAnCuoiKy
{
    partial class DoiMatKhau
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
            this.btn_ThoatDangNhap = new System.Windows.Forms.Button();
            this.btn_DoiMatKhau = new System.Windows.Forms.Button();
            this.txt_TypePass = new System.Windows.Forms.TextBox();
            this.lbl_MKMoi = new System.Windows.Forms.Label();
            this.listBox_AllAccount = new System.Windows.Forms.ListBox();
            this.txt_RetypePass = new System.Windows.Forms.TextBox();
            this.lbl_MKMoi_Again = new System.Windows.Forms.Label();
            this.label_Acc = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_ThoatDangNhap
            // 
            this.btn_ThoatDangNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ThoatDangNhap.Location = new System.Drawing.Point(290, 316);
            this.btn_ThoatDangNhap.Name = "btn_ThoatDangNhap";
            this.btn_ThoatDangNhap.Size = new System.Drawing.Size(213, 48);
            this.btn_ThoatDangNhap.TabIndex = 12;
            this.btn_ThoatDangNhap.Text = "Thoát";
            this.btn_ThoatDangNhap.UseVisualStyleBackColor = true;
            // 
            // btn_DoiMatKhau
            // 
            this.btn_DoiMatKhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_DoiMatKhau.Location = new System.Drawing.Point(71, 316);
            this.btn_DoiMatKhau.Name = "btn_DoiMatKhau";
            this.btn_DoiMatKhau.Size = new System.Drawing.Size(213, 48);
            this.btn_DoiMatKhau.TabIndex = 11;
            this.btn_DoiMatKhau.Text = "Đổi mật khẩu";
            this.btn_DoiMatKhau.UseVisualStyleBackColor = true;
            // 
            // txt_TypePass
            // 
            this.txt_TypePass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TypePass.Location = new System.Drawing.Point(206, 155);
            this.txt_TypePass.Name = "txt_TypePass";
            this.txt_TypePass.Size = new System.Drawing.Size(310, 30);
            this.txt_TypePass.TabIndex = 8;
            // 
            // lbl_MKMoi
            // 
            this.lbl_MKMoi.AutoSize = true;
            this.lbl_MKMoi.Font = new System.Drawing.Font("Montserrat", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_MKMoi.Location = new System.Drawing.Point(12, 159);
            this.lbl_MKMoi.Name = "lbl_MKMoi";
            this.lbl_MKMoi.Size = new System.Drawing.Size(146, 25);
            this.lbl_MKMoi.TabIndex = 7;
            this.lbl_MKMoi.Text = "Mật khẩu mới:";
            // 
            // listBox_AllAccount
            // 
            this.listBox_AllAccount.FormattingEnabled = true;
            this.listBox_AllAccount.ItemHeight = 18;
            this.listBox_AllAccount.Location = new System.Drawing.Point(83, 59);
            this.listBox_AllAccount.Name = "listBox_AllAccount";
            this.listBox_AllAccount.Size = new System.Drawing.Size(383, 22);
            this.listBox_AllAccount.TabIndex = 13;
            // 
            // txt_RetypePass
            // 
            this.txt_RetypePass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_RetypePass.Location = new System.Drawing.Point(206, 209);
            this.txt_RetypePass.Name = "txt_RetypePass";
            this.txt_RetypePass.Size = new System.Drawing.Size(310, 30);
            this.txt_RetypePass.TabIndex = 15;
            // 
            // lbl_MKMoi_Again
            // 
            this.lbl_MKMoi_Again.AutoSize = true;
            this.lbl_MKMoi_Again.Font = new System.Drawing.Font("Montserrat", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_MKMoi_Again.Location = new System.Drawing.Point(12, 213);
            this.lbl_MKMoi_Again.Name = "lbl_MKMoi_Again";
            this.lbl_MKMoi_Again.Size = new System.Drawing.Size(188, 25);
            this.lbl_MKMoi_Again.TabIndex = 14;
            this.lbl_MKMoi_Again.Text = "Nhập lại mật khẩu:";
            // 
            // label_Acc
            // 
            this.label_Acc.AutoSize = true;
            this.label_Acc.Font = new System.Drawing.Font("Montserrat Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Acc.Location = new System.Drawing.Point(138, 18);
            this.label_Acc.Name = "label_Acc";
            this.label_Acc.Size = new System.Drawing.Size(243, 28);
            this.label_Acc.TabIndex = 16;
            this.label_Acc.Text = "Các tài khoản hiện có";
            // 
            // DoiMatKhau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(561, 400);
            this.Controls.Add(this.label_Acc);
            this.Controls.Add(this.txt_RetypePass);
            this.Controls.Add(this.lbl_MKMoi_Again);
            this.Controls.Add(this.listBox_AllAccount);
            this.Controls.Add(this.btn_ThoatDangNhap);
            this.Controls.Add(this.btn_DoiMatKhau);
            this.Controls.Add(this.txt_TypePass);
            this.Controls.Add(this.lbl_MKMoi);
            this.Font = new System.Drawing.Font("Montserrat", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "DoiMatKhau";
            this.Text = "DoiMatKhau";
            this.Load += new System.EventHandler(this.DoiMatKhau_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_ThoatDangNhap;
        private System.Windows.Forms.Button btn_DoiMatKhau;
        private System.Windows.Forms.TextBox txt_TypePass;
        private System.Windows.Forms.Label lbl_MKMoi;
        private System.Windows.Forms.ListBox listBox_AllAccount;
        private System.Windows.Forms.TextBox txt_RetypePass;
        private System.Windows.Forms.Label lbl_MKMoi_Again;
        private System.Windows.Forms.Label label_Acc;
    }
}