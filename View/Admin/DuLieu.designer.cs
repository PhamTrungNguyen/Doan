namespace pbl3
{
    partial class DuLieu
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnLichChieu = new System.Windows.Forms.Button();
            this.btnDinhDang = new System.Windows.Forms.Button();
            this.btnPhim = new System.Windows.Forms.Button();
            this.btnTheLoai = new System.Windows.Forms.Button();
            this.btnPhongChieu = new System.Windows.Forms.Button();
            this.btnLoaiManHinh = new System.Windows.Forms.Button();
            this.pbDuLieu = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Aqua;
            this.panel1.Controls.Add(this.btnLichChieu);
            this.panel1.Controls.Add(this.btnDinhDang);
            this.panel1.Controls.Add(this.btnPhim);
            this.panel1.Controls.Add(this.btnTheLoai);
            this.panel1.Controls.Add(this.btnPhongChieu);
            this.panel1.Controls.Add(this.btnLoaiManHinh);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1103, 76);
            this.panel1.TabIndex = 0;
            // 
            // btnLichChieu
            // 
            this.btnLichChieu.Location = new System.Drawing.Point(835, 15);
            this.btnLichChieu.Name = "btnLichChieu";
            this.btnLichChieu.Size = new System.Drawing.Size(142, 48);
            this.btnLichChieu.TabIndex = 0;
            this.btnLichChieu.Text = "Lịch Chiếu";
            this.btnLichChieu.UseVisualStyleBackColor = true;
            this.btnLichChieu.Click += new System.EventHandler(this.btnLichChieu_Click);
            // 
            // btnDinhDang
            // 
            this.btnDinhDang.Location = new System.Drawing.Point(668, 15);
            this.btnDinhDang.Name = "btnDinhDang";
            this.btnDinhDang.Size = new System.Drawing.Size(142, 48);
            this.btnDinhDang.TabIndex = 0;
            this.btnDinhDang.Text = "Định Dạng";
            this.btnDinhDang.UseVisualStyleBackColor = true;
            this.btnDinhDang.Click += new System.EventHandler(this.btnDinhDang_Click);
            // 
            // btnPhim
            // 
            this.btnPhim.Location = new System.Drawing.Point(498, 15);
            this.btnPhim.Name = "btnPhim";
            this.btnPhim.Size = new System.Drawing.Size(142, 48);
            this.btnPhim.TabIndex = 0;
            this.btnPhim.Text = "Phim";
            this.btnPhim.UseVisualStyleBackColor = true;
            this.btnPhim.Click += new System.EventHandler(this.btnPhim_Click);
            // 
            // btnTheLoai
            // 
            this.btnTheLoai.Location = new System.Drawing.Point(331, 15);
            this.btnTheLoai.Name = "btnTheLoai";
            this.btnTheLoai.Size = new System.Drawing.Size(142, 48);
            this.btnTheLoai.TabIndex = 0;
            this.btnTheLoai.Text = "Thể Loại";
            this.btnTheLoai.UseVisualStyleBackColor = true;
            this.btnTheLoai.Click += new System.EventHandler(this.btnTheLoai_Click);
            // 
            // btnPhongChieu
            // 
            this.btnPhongChieu.Location = new System.Drawing.Point(166, 15);
            this.btnPhongChieu.Name = "btnPhongChieu";
            this.btnPhongChieu.Size = new System.Drawing.Size(142, 48);
            this.btnPhongChieu.TabIndex = 0;
            this.btnPhongChieu.Text = "Phòng Chiếu";
            this.btnPhongChieu.UseVisualStyleBackColor = true;
            this.btnPhongChieu.Click += new System.EventHandler(this.btnPhongChieu_Click);
            // 
            // btnLoaiManHinh
            // 
            this.btnLoaiManHinh.Location = new System.Drawing.Point(8, 15);
            this.btnLoaiManHinh.Name = "btnLoaiManHinh";
            this.btnLoaiManHinh.Size = new System.Drawing.Size(142, 48);
            this.btnLoaiManHinh.TabIndex = 0;
            this.btnLoaiManHinh.Text = "Loại màn hình";
            this.btnLoaiManHinh.UseVisualStyleBackColor = true;
            this.btnLoaiManHinh.Click += new System.EventHandler(this.btnLoaiManHinh_Click);
            // 
            // pbDuLieu
            // 
            this.pbDuLieu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbDuLieu.Location = new System.Drawing.Point(0, 76);
            this.pbDuLieu.Name = "pbDuLieu";
            this.pbDuLieu.Size = new System.Drawing.Size(1103, 523);
            this.pbDuLieu.TabIndex = 1;
            // 
            // DuLieu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pbDuLieu);
            this.Controls.Add(this.panel1);
            this.Name = "DuLieu";
            this.Size = new System.Drawing.Size(1103, 599);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnDinhDang;
        private System.Windows.Forms.Button btnPhim;
        private System.Windows.Forms.Button btnTheLoai;
        private System.Windows.Forms.Button btnPhongChieu;
        private System.Windows.Forms.Button btnLoaiManHinh;
        private System.Windows.Forms.Button btnLichChieu;
        private System.Windows.Forms.Panel pbDuLieu;
    }
}
