namespace StudentManagement
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.picture_LopHoc = new System.Windows.Forms.PictureBox();
            this.picture_SV = new System.Windows.Forms.PictureBox();
            this.picture_MonHoc = new System.Windows.Forms.PictureBox();
            this.picture_Diem = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picture_LopHoc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_SV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_MonHoc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_Diem)).BeginInit();
            this.SuspendLayout();
            // 
            // picture_LopHoc
            // 
            this.picture_LopHoc.Image = ((System.Drawing.Image)(resources.GetObject("picture_LopHoc.Image")));
            this.picture_LopHoc.Location = new System.Drawing.Point(355, 32);
            this.picture_LopHoc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picture_LopHoc.Name = "picture_LopHoc";
            this.picture_LopHoc.Size = new System.Drawing.Size(175, 150);
            this.picture_LopHoc.TabIndex = 0;
            this.picture_LopHoc.TabStop = false;
            this.picture_LopHoc.Click += new System.EventHandler(this.picture_LopHoc_Click);
            // 
            // picture_SV
            // 
            this.picture_SV.Image = ((System.Drawing.Image)(resources.GetObject("picture_SV.Image")));
            this.picture_SV.Location = new System.Drawing.Point(91, 32);
            this.picture_SV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picture_SV.Name = "picture_SV";
            this.picture_SV.Size = new System.Drawing.Size(175, 150);
            this.picture_SV.TabIndex = 1;
            this.picture_SV.TabStop = false;
            this.picture_SV.Click += new System.EventHandler(this.picture_SV_Click);
            // 
            // picture_MonHoc
            // 
            this.picture_MonHoc.Image = ((System.Drawing.Image)(resources.GetObject("picture_MonHoc.Image")));
            this.picture_MonHoc.Location = new System.Drawing.Point(91, 229);
            this.picture_MonHoc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picture_MonHoc.Name = "picture_MonHoc";
            this.picture_MonHoc.Size = new System.Drawing.Size(175, 150);
            this.picture_MonHoc.TabIndex = 2;
            this.picture_MonHoc.TabStop = false;
            this.picture_MonHoc.Click += new System.EventHandler(this.picture_MonHoc_Click);
            // 
            // picture_Diem
            // 
            this.picture_Diem.Image = ((System.Drawing.Image)(resources.GetObject("picture_Diem.Image")));
            this.picture_Diem.Location = new System.Drawing.Point(355, 229);
            this.picture_Diem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picture_Diem.Name = "picture_Diem";
            this.picture_Diem.Size = new System.Drawing.Size(175, 150);
            this.picture_Diem.TabIndex = 3;
            this.picture_Diem.TabStop = false;
            this.picture_Diem.Click += new System.EventHandler(this.picture_Diem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(145, 188);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Sinh Viên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(413, 188);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Lớp Học";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(145, 388);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Môn Học";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(413, 388);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "Điểm";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(628, 419);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.picture_Diem);
            this.Controls.Add(this.picture_MonHoc);
            this.Controls.Add(this.picture_SV);
            this.Controls.Add(this.picture_LopHoc);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picture_LopHoc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_SV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_MonHoc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_Diem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picture_LopHoc;
        private System.Windows.Forms.PictureBox picture_SV;
        private System.Windows.Forms.PictureBox picture_MonHoc;
        private System.Windows.Forms.PictureBox picture_Diem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}
