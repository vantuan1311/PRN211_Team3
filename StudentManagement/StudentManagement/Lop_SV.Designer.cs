namespace StudentManagement
{
    partial class Lop_SV
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
            this.txtSinhVien = new System.Windows.Forms.TextBox();
            this.lbSinhVien = new System.Windows.Forms.Label();
            this.btnQuayLai = new System.Windows.Forms.Button();
            this.txtTK = new System.Windows.Forms.TextBox();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.txtLop_SV = new System.Windows.Forms.TextBox();
            this.btnXoa = new System.Windows.Forms.Button();
            this.dgLop_SV = new System.Windows.Forms.DataGridView();
            this.lbLop = new System.Windows.Forms.Label();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnDong = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgLop_SV)).BeginInit();
            this.SuspendLayout();
            // 
            // txtSinhVien
            // 
            this.txtSinhVien.Location = new System.Drawing.Point(167, 90);
            this.txtSinhVien.Name = "txtSinhVien";
            this.txtSinhVien.Size = new System.Drawing.Size(255, 27);
            this.txtSinhVien.TabIndex = 43;
            // 
            // lbSinhVien
            // 
            this.lbSinhVien.AutoSize = true;
            this.lbSinhVien.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbSinhVien.Location = new System.Drawing.Point(24, 89);
            this.lbSinhVien.Name = "lbSinhVien";
            this.lbSinhVien.Size = new System.Drawing.Size(130, 28);
            this.lbSinhVien.TabIndex = 42;
            this.lbSinhVien.Text = "Mã Sinh Viên:";
            // 
            // btnQuayLai
            // 
            this.btnQuayLai.Location = new System.Drawing.Point(314, 192);
            this.btnQuayLai.Name = "btnQuayLai";
            this.btnQuayLai.Size = new System.Drawing.Size(94, 29);
            this.btnQuayLai.TabIndex = 41;
            this.btnQuayLai.Text = "Quay Lại";
            this.btnQuayLai.UseVisualStyleBackColor = true;
            this.btnQuayLai.Click += new System.EventHandler(this.btnQuayLai_Click);
            // 
            // txtTK
            // 
            this.txtTK.Location = new System.Drawing.Point(153, 276);
            this.txtTK.Name = "txtTK";
            this.txtTK.Size = new System.Drawing.Size(255, 27);
            this.txtTK.TabIndex = 40;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Location = new System.Drawing.Point(24, 274);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(94, 29);
            this.btnTimKiem.TabIndex = 39;
            this.btnTimKiem.Text = "Tìm Kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // txtLop_SV
            // 
            this.txtLop_SV.Location = new System.Drawing.Point(167, 25);
            this.txtLop_SV.Name = "txtLop_SV";
            this.txtLop_SV.Size = new System.Drawing.Size(255, 27);
            this.txtLop_SV.TabIndex = 38;
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(167, 192);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(94, 29);
            this.btnXoa.TabIndex = 36;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // dgLop_SV
            // 
            this.dgLop_SV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgLop_SV.Location = new System.Drawing.Point(445, 25);
            this.dgLop_SV.Name = "dgLop_SV";
            this.dgLop_SV.RowHeadersWidth = 51;
            this.dgLop_SV.RowTemplate.Height = 29;
            this.dgLop_SV.Size = new System.Drawing.Size(598, 398);
            this.dgLop_SV.TabIndex = 35;
            this.dgLop_SV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgLop_SV_CellClick);
            // 
            // lbLop
            // 
            this.lbLop.AutoSize = true;
            this.lbLop.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbLop.Location = new System.Drawing.Point(24, 25);
            this.lbLop.Name = "lbLop";
            this.lbLop.Size = new System.Drawing.Size(82, 28);
            this.lbLop.TabIndex = 34;
            this.lbLop.Text = "Mã Lớp:";
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(24, 192);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(94, 29);
            this.btnThem.TabIndex = 33;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnDong
            // 
            this.btnDong.Location = new System.Drawing.Point(24, 369);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(94, 29);
            this.btnDong.TabIndex = 44;
            this.btnDong.Text = "Đóng";
            this.btnDong.UseVisualStyleBackColor = true;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // Lop_SV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1139, 464);
            this.Controls.Add(this.btnDong);
            this.Controls.Add(this.txtSinhVien);
            this.Controls.Add(this.lbSinhVien);
            this.Controls.Add(this.btnQuayLai);
            this.Controls.Add(this.txtTK);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.txtLop_SV);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.dgLop_SV);
            this.Controls.Add(this.lbLop);
            this.Controls.Add(this.btnThem);
            this.Name = "Lop_SV";
            this.Text = "Lop_SV";
            this.Load += new System.EventHandler(this.Lop_SV_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgLop_SV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSinhVien;
        private System.Windows.Forms.Label lbSinhVien;
        private System.Windows.Forms.Button btnQuayLai;
        private System.Windows.Forms.TextBox txtTK;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.TextBox txtLop_SV;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.DataGridView dgLop_SV;
        private System.Windows.Forms.Label lbLop;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnDong;
    }
}