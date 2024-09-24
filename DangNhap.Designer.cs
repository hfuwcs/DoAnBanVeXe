namespace DoAnCuoiKy
{
    partial class DangNhap
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
            this.lbl_Email = new System.Windows.Forms.Label();
            this.txtBox_Email = new System.Windows.Forms.TextBox();
            this.lbl_Password = new System.Windows.Forms.Label();
            this.txtBox_Pass = new System.Windows.Forms.TextBox();
            this.btn_DangNhap = new System.Windows.Forms.Button();
            this.linkLabel_DangKy = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // lbl_Email
            // 
            this.lbl_Email.AutoSize = true;
            this.lbl_Email.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Email.Location = new System.Drawing.Point(79, 107);
            this.lbl_Email.Name = "lbl_Email";
            this.lbl_Email.Size = new System.Drawing.Size(72, 25);
            this.lbl_Email.TabIndex = 0;
            this.lbl_Email.Text = "Email:";
            // 
            // txtBox_Email
            // 
            this.txtBox_Email.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBox_Email.Location = new System.Drawing.Point(206, 104);
            this.txtBox_Email.Name = "txtBox_Email";
            this.txtBox_Email.Size = new System.Drawing.Size(279, 30);
            this.txtBox_Email.TabIndex = 1;
            // 
            // lbl_Password
            // 
            this.lbl_Password.AutoSize = true;
            this.lbl_Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Password.Location = new System.Drawing.Point(79, 154);
            this.lbl_Password.Name = "lbl_Password";
            this.lbl_Password.Size = new System.Drawing.Size(113, 25);
            this.lbl_Password.TabIndex = 2;
            this.lbl_Password.Text = "Password:";
            // 
            // txtBox_Pass
            // 
            this.txtBox_Pass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBox_Pass.Location = new System.Drawing.Point(206, 151);
            this.txtBox_Pass.Name = "txtBox_Pass";
            this.txtBox_Pass.Size = new System.Drawing.Size(279, 30);
            this.txtBox_Pass.TabIndex = 3;
            this.txtBox_Pass.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            this.txtBox_Pass.Enter += new System.EventHandler(this.txtBox_Pass_Enter);
            this.txtBox_Pass.Leave += new System.EventHandler(this.txtBox_Pass_Leave);
            // 
            // btn_DangNhap
            // 
            this.btn_DangNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_DangNhap.Location = new System.Drawing.Point(178, 244);
            this.btn_DangNhap.Name = "btn_DangNhap";
            this.btn_DangNhap.Size = new System.Drawing.Size(213, 43);
            this.btn_DangNhap.TabIndex = 4;
            this.btn_DangNhap.Text = "Đăng nhập";
            this.btn_DangNhap.UseVisualStyleBackColor = true;
            this.btn_DangNhap.Click += new System.EventHandler(this.btn_DangNhap_Click);
            // 
            // linkLabel_DangKy
            // 
            this.linkLabel_DangKy.AutoSize = true;
            this.linkLabel_DangKy.Location = new System.Drawing.Point(313, 193);
            this.linkLabel_DangKy.Name = "linkLabel_DangKy";
            this.linkLabel_DangKy.Size = new System.Drawing.Size(172, 16);
            this.linkLabel_DangKy.TabIndex = 5;
            this.linkLabel_DangKy.TabStop = true;
            this.linkLabel_DangKy.Text = "Chưa có tài khoản? Đăng ký";
            // 
            // DangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(561, 356);
            this.Controls.Add(this.linkLabel_DangKy);
            this.Controls.Add(this.btn_DangNhap);
            this.Controls.Add(this.txtBox_Pass);
            this.Controls.Add(this.lbl_Password);
            this.Controls.Add(this.txtBox_Email);
            this.Controls.Add(this.lbl_Email);
            this.Name = "DangNhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DangNhap";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Email;
        private System.Windows.Forms.TextBox txtBox_Email;
        private System.Windows.Forms.Label lbl_Password;
        private System.Windows.Forms.TextBox txtBox_Pass;
        private System.Windows.Forms.Button btn_DangNhap;
        private System.Windows.Forms.LinkLabel linkLabel_DangKy;
    }
}