namespace StudentManagement
{
    partial class FrmSinhVien
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
            this.txtMaSV = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.MaSV = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.btnNam = new System.Windows.Forms.RadioButton();
            this.btnNu = new System.Windows.Forms.RadioButton();
            this.dgSinhVien = new System.Windows.Forms.DataGridView();
            this.button_ThemMoi = new System.Windows.Forms.Button();
            this.button_Xoa = new System.Windows.Forms.Button();
            this.button_XemDiem = new System.Windows.Forms.Button();
            this.txtTimkiem_Ten = new System.Windows.Forms.TextBox();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.rdbTimkiem_Nu = new System.Windows.Forms.RadioButton();
            this.rdbTimkiem_Nam = new System.Windows.Forms.RadioButton();
            this.rdbTimkiem_Tatca = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgSinhVien)).BeginInit();
            this.SuspendLayout();
            // 
            // txtMaSV
            // 
            this.txtMaSV.Location = new System.Drawing.Point(897, 223);
            this.txtMaSV.Name = "txtMaSV";
            this.txtMaSV.Size = new System.Drawing.Size(183, 27);
            this.txtMaSV.TabIndex = 0;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(1214, 263);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(183, 27);
            this.txtEmail.TabIndex = 1;
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(897, 308);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(183, 27);
            this.txtDiaChi.TabIndex = 4;
            // 
            // txtTen
            // 
            this.txtTen.Location = new System.Drawing.Point(897, 266);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(183, 27);
            this.txtTen.TabIndex = 5;
            // 
            // MaSV
            // 
            this.MaSV.AutoSize = true;
            this.MaSV.Location = new System.Drawing.Point(823, 226);
            this.MaSV.Name = "MaSV";
            this.MaSV.Size = new System.Drawing.Size(51, 20);
            this.MaSV.TabIndex = 6;
            this.MaSV.Text = "Mã SV";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(823, 269);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Tên";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(823, 311);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Địa Chỉ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1121, 308);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Giới Tính";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1121, 223);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Ngày Sinh";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1121, 266);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "Email";
            // 
            // txtNgaySinh
            // 
            this.txtNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtNgaySinh.Location = new System.Drawing.Point(1214, 220);
            this.txtNgaySinh.Name = "txtNgaySinh";
            this.txtNgaySinh.Size = new System.Drawing.Size(183, 27);
            this.txtNgaySinh.TabIndex = 12;
            this.txtNgaySinh.Value = new System.DateTime(2022, 7, 15, 0, 0, 0, 0);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(562, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(306, 41);
            this.label1.TabIndex = 13;
            this.label1.Text = "Danh Sách Sinh Viên";
            // 
            // btnNam
            // 
            this.btnNam.AutoSize = true;
            this.btnNam.Location = new System.Drawing.Point(1214, 304);
            this.btnNam.Name = "btnNam";
            this.btnNam.Size = new System.Drawing.Size(62, 24);
            this.btnNam.TabIndex = 14;
            this.btnNam.TabStop = true;
            this.btnNam.Text = "Nam";
            this.btnNam.UseVisualStyleBackColor = true;
            // 
            // btnNu
            // 
            this.btnNu.AutoSize = true;
            this.btnNu.Location = new System.Drawing.Point(1347, 304);
            this.btnNu.Name = "btnNu";
            this.btnNu.Size = new System.Drawing.Size(50, 24);
            this.btnNu.TabIndex = 15;
            this.btnNu.TabStop = true;
            this.btnNu.Text = "Nữ";
            this.btnNu.UseVisualStyleBackColor = true;
            // 
            // dgSinhVien
            // 
            this.dgSinhVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgSinhVien.Location = new System.Drawing.Point(15, 130);
            this.dgSinhVien.Name = "dgSinhVien";
            this.dgSinhVien.RowHeadersWidth = 51;
            this.dgSinhVien.RowTemplate.Height = 29;
            this.dgSinhVien.Size = new System.Drawing.Size(776, 345);
            this.dgSinhVien.TabIndex = 16;
            this.dgSinhVien.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgSinhVien_CellContentClick);
            // 
            // button_ThemMoi
            // 
            this.button_ThemMoi.Location = new System.Drawing.Point(1051, 368);
            this.button_ThemMoi.Name = "button_ThemMoi";
            this.button_ThemMoi.Size = new System.Drawing.Size(183, 29);
            this.button_ThemMoi.TabIndex = 17;
            this.button_ThemMoi.Text = "Thêm mới / Sửa";
            this.button_ThemMoi.UseVisualStyleBackColor = true;
            this.button_ThemMoi.Click += new System.EventHandler(this.button_ThemMoi_Click);
            // 
            // button_Xoa
            // 
            this.button_Xoa.Location = new System.Drawing.Point(897, 368);
            this.button_Xoa.Name = "button_Xoa";
            this.button_Xoa.Size = new System.Drawing.Size(94, 29);
            this.button_Xoa.TabIndex = 19;
            this.button_Xoa.Text = "Xóa";
            this.button_Xoa.UseVisualStyleBackColor = true;
            this.button_Xoa.Click += new System.EventHandler(this.button_Xoa_Click);
            // 
            // button_XemDiem
            // 
            this.button_XemDiem.Location = new System.Drawing.Point(1303, 368);
            this.button_XemDiem.Name = "button_XemDiem";
            this.button_XemDiem.Size = new System.Drawing.Size(94, 29);
            this.button_XemDiem.TabIndex = 20;
            this.button_XemDiem.Text = "Xem Điểm";
            this.button_XemDiem.UseVisualStyleBackColor = true;
            this.button_XemDiem.Click += new System.EventHandler(this.button_XemDiem_Click);
            // 
            // txtTimkiem_Ten
            // 
            this.txtTimkiem_Ten.Location = new System.Drawing.Point(948, 130);
            this.txtTimkiem_Ten.Name = "txtTimkiem_Ten";
            this.txtTimkiem_Ten.PlaceholderText = "Nhập tên sinh viên";
            this.txtTimkiem_Ten.Size = new System.Drawing.Size(183, 27);
            this.txtTimkiem_Ten.TabIndex = 21;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Location = new System.Drawing.Point(825, 130);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(94, 29);
            this.btnTimKiem.TabIndex = 22;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // rdbTimkiem_Nu
            // 
            this.rdbTimkiem_Nu.AutoSize = true;
            this.rdbTimkiem_Nu.Location = new System.Drawing.Point(1250, 130);
            this.rdbTimkiem_Nu.Name = "rdbTimkiem_Nu";
            this.rdbTimkiem_Nu.Size = new System.Drawing.Size(50, 24);
            this.rdbTimkiem_Nu.TabIndex = 24;
            this.rdbTimkiem_Nu.TabStop = true;
            this.rdbTimkiem_Nu.Text = "Nữ";
            this.rdbTimkiem_Nu.UseVisualStyleBackColor = true;
            // 
            // rdbTimkiem_Nam
            // 
            this.rdbTimkiem_Nam.AutoSize = true;
            this.rdbTimkiem_Nam.Location = new System.Drawing.Point(1161, 132);
            this.rdbTimkiem_Nam.Name = "rdbTimkiem_Nam";
            this.rdbTimkiem_Nam.Size = new System.Drawing.Size(62, 24);
            this.rdbTimkiem_Nam.TabIndex = 23;
            this.rdbTimkiem_Nam.TabStop = true;
            this.rdbTimkiem_Nam.Text = "Nam";
            this.rdbTimkiem_Nam.UseVisualStyleBackColor = true;
            // 
            // rdbTimkiem_Tatca
            // 
            this.rdbTimkiem_Tatca.AutoSize = true;
            this.rdbTimkiem_Tatca.Location = new System.Drawing.Point(1327, 130);
            this.rdbTimkiem_Tatca.Name = "rdbTimkiem_Tatca";
            this.rdbTimkiem_Tatca.Size = new System.Drawing.Size(70, 24);
            this.rdbTimkiem_Tatca.TabIndex = 25;
            this.rdbTimkiem_Tatca.TabStop = true;
            this.rdbTimkiem_Tatca.Text = "Tất cả";
            this.rdbTimkiem_Tatca.UseVisualStyleBackColor = true;
            // 
            // FrmSinhVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1422, 555);
            this.Controls.Add(this.rdbTimkiem_Tatca);
            this.Controls.Add(this.rdbTimkiem_Nu);
            this.Controls.Add(this.rdbTimkiem_Nam);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.txtTimkiem_Ten);
            this.Controls.Add(this.button_XemDiem);
            this.Controls.Add(this.button_Xoa);
            this.Controls.Add(this.button_ThemMoi);
            this.Controls.Add(this.dgSinhVien);
            this.Controls.Add(this.btnNu);
            this.Controls.Add(this.btnNam);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNgaySinh);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.MaSV);
            this.Controls.Add(this.txtTen);
            this.Controls.Add(this.txtDiaChi);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtMaSV);
            this.Name = "FrmSinhVien";
            this.Text = "Sinh Viên";
            this.Load += new System.EventHandler(this.FrmSinhVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgSinhVien)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMaSV;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.Label MaSV;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker txtNgaySinh;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton btnNam;
        private System.Windows.Forms.RadioButton btnNu;
        private System.Windows.Forms.DataGridView dgSinhVien;
        private System.Windows.Forms.Button button_ThemMoi;
        private System.Windows.Forms.Button button_Xoa;
        private System.Windows.Forms.Button button_XemDiem;
        private System.Windows.Forms.TextBox txtTimkiem_Ten;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.RadioButton rdbTimkiem_Nu;
        private System.Windows.Forms.RadioButton rdbTimkiem_Nam;
        private System.Windows.Forms.RadioButton rdbTimkiem_Tatca;
    }
}