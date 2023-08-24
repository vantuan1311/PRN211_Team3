namespace StudentManagement
{
    partial class FrmDiem
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
            this.dg_Diem = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMaSV = new System.Windows.Forms.TextBox();
            this.txtDiem = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTimkiem_MaSV = new System.Windows.Forms.TextBox();
            this.button_Timkiem = new System.Windows.Forms.Button();
            this.button_Them_Sua = new System.Windows.Forms.Button();
            this.button_Xoa = new System.Windows.Forms.Button();
            this.txtMaMon = new System.Windows.Forms.ComboBox();
            this.txtTimkiem_DiemTu = new System.Windows.Forms.TextBox();
            this.txtTimkiem_DiemDen = new System.Windows.Forms.TextBox();
            this.txtTimkiem_MonHoc = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dg_Diem)).BeginInit();
            this.SuspendLayout();
            // 
            // dg_Diem
            // 
            this.dg_Diem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_Diem.Location = new System.Drawing.Point(11, 174);
            this.dg_Diem.Name = "dg_Diem";
            this.dg_Diem.RowHeadersWidth = 51;
            this.dg_Diem.RowTemplate.Height = 29;
            this.dg_Diem.Size = new System.Drawing.Size(716, 242);
            this.dg_Diem.TabIndex = 0;
            this.dg_Diem.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dg_Diem_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(218, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(333, 45);
            this.label1.TabIndex = 1;
            this.label1.Text = "Bảng điểm sinh viên";
            // 
            // txtMaSV
            // 
            this.txtMaSV.Location = new System.Drawing.Point(68, 461);
            this.txtMaSV.Name = "txtMaSV";
            this.txtMaSV.Size = new System.Drawing.Size(125, 27);
            this.txtMaSV.TabIndex = 2;
            // 
            // txtDiem
            // 
            this.txtDiem.Location = new System.Drawing.Point(602, 461);
            this.txtDiem.Name = "txtDiem";
            this.txtDiem.Size = new System.Drawing.Size(125, 27);
            this.txtDiem.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 464);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Mã SV";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(272, 464);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Mã môn";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(551, 464);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Điểm";
            // 
            // txtTimkiem_MaSV
            // 
            this.txtTimkiem_MaSV.Location = new System.Drawing.Point(128, 89);
            this.txtTimkiem_MaSV.Name = "txtTimkiem_MaSV";
            this.txtTimkiem_MaSV.PlaceholderText = "Nhập mã SV";
            this.txtTimkiem_MaSV.Size = new System.Drawing.Size(138, 27);
            this.txtTimkiem_MaSV.TabIndex = 8;
            // 
            // button_Timkiem
            // 
            this.button_Timkiem.Location = new System.Drawing.Point(12, 87);
            this.button_Timkiem.Name = "button_Timkiem";
            this.button_Timkiem.Size = new System.Drawing.Size(94, 29);
            this.button_Timkiem.TabIndex = 9;
            this.button_Timkiem.Text = "Tìm kiếm";
            this.button_Timkiem.UseVisualStyleBackColor = true;
            this.button_Timkiem.Click += new System.EventHandler(this.button_Timkiem_Click);
            // 
            // button_Them_Sua
            // 
            this.button_Them_Sua.Location = new System.Drawing.Point(227, 512);
            this.button_Them_Sua.Name = "button_Them_Sua";
            this.button_Them_Sua.Size = new System.Drawing.Size(125, 29);
            this.button_Them_Sua.TabIndex = 10;
            this.button_Them_Sua.Text = "Thêm/Sửa điểm";
            this.button_Them_Sua.UseVisualStyleBackColor = true;
            this.button_Them_Sua.Click += new System.EventHandler(this.button_Them_Sua_Click);
            // 
            // button_Xoa
            // 
            this.button_Xoa.Location = new System.Drawing.Point(503, 512);
            this.button_Xoa.Name = "button_Xoa";
            this.button_Xoa.Size = new System.Drawing.Size(94, 29);
            this.button_Xoa.TabIndex = 11;
            this.button_Xoa.Text = "Xóa";
            this.button_Xoa.UseVisualStyleBackColor = true;
            this.button_Xoa.Click += new System.EventHandler(this.button_Xoa_Click);
            // 
            // txtMaMon
            // 
            this.txtMaMon.FormattingEnabled = true;
            this.txtMaMon.Location = new System.Drawing.Point(342, 461);
            this.txtMaMon.Name = "txtMaMon";
            this.txtMaMon.Size = new System.Drawing.Size(125, 28);
            this.txtMaMon.TabIndex = 12;
            // 
            // txtTimkiem_DiemTu
            // 
            this.txtTimkiem_DiemTu.Location = new System.Drawing.Point(445, 89);
            this.txtTimkiem_DiemTu.Name = "txtTimkiem_DiemTu";
            this.txtTimkiem_DiemTu.PlaceholderText = "Nhập điểm (từ)";
            this.txtTimkiem_DiemTu.Size = new System.Drawing.Size(138, 27);
            this.txtTimkiem_DiemTu.TabIndex = 13;
            this.txtTimkiem_DiemTu.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTimkiem_DiemTu_KeyPress);
            // 
            // txtTimkiem_DiemDen
            // 
            this.txtTimkiem_DiemDen.Location = new System.Drawing.Point(589, 89);
            this.txtTimkiem_DiemDen.Name = "txtTimkiem_DiemDen";
            this.txtTimkiem_DiemDen.PlaceholderText = "Nhập điểm (đến)";
            this.txtTimkiem_DiemDen.Size = new System.Drawing.Size(138, 27);
            this.txtTimkiem_DiemDen.TabIndex = 14;
            // 
            // txtTimkiem_MonHoc
            // 
            this.txtTimkiem_MonHoc.Location = new System.Drawing.Point(285, 89);
            this.txtTimkiem_MonHoc.Name = "txtTimkiem_MonHoc";
            this.txtTimkiem_MonHoc.PlaceholderText = "Nhập môn học";
            this.txtTimkiem_MonHoc.Size = new System.Drawing.Size(138, 27);
            this.txtTimkiem_MonHoc.TabIndex = 15;
            // 
            // FrmDiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(745, 563);
            this.Controls.Add(this.txtTimkiem_MonHoc);
            this.Controls.Add(this.txtTimkiem_DiemDen);
            this.Controls.Add(this.txtTimkiem_DiemTu);
            this.Controls.Add(this.txtMaMon);
            this.Controls.Add(this.button_Xoa);
            this.Controls.Add(this.button_Them_Sua);
            this.Controls.Add(this.button_Timkiem);
            this.Controls.Add(this.txtTimkiem_MaSV);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtDiem);
            this.Controls.Add(this.txtMaSV);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dg_Diem);
            this.Name = "FrmDiem";
            this.Text = "Điểm sinh viên";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmDiem_FormClosed);
            this.Load += new System.EventHandler(this.FrmDiem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dg_Diem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dg_Diem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMaSV;
        private System.Windows.Forms.TextBox txtDiem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTimkiem_MaSV;
        private System.Windows.Forms.Button button_Timkiem;
        private System.Windows.Forms.Button button_Them_Sua;
        private System.Windows.Forms.Button button_Xoa;
        private System.Windows.Forms.ComboBox txtMaMon;
        private System.Windows.Forms.TextBox txtTimkiem_DiemTu;
        private System.Windows.Forms.TextBox txtTimkiem_DiemDen;
        private System.Windows.Forms.TextBox txtTimkiem_MonHoc;
    }
}