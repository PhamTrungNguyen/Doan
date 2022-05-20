namespace DoAn.Admin.DuLieu
{
    partial class AddPhim
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
            this.lblMovieID = new System.Windows.Forms.Label();
            this.txtPhimMa = new System.Windows.Forms.TextBox();
            this.lblMovieName = new System.Windows.Forms.Label();
            this.txtPhimTen = new System.Windows.Forms.TextBox();
            this.lblMovieProductor = new System.Windows.Forms.Label();
            this.lblMovieDirector = new System.Windows.Forms.Label();
            this.lblMovieGenre = new System.Windows.Forms.Label();
            this.lblMovieYear = new System.Windows.Forms.Label();
            this.lblMovieLength = new System.Windows.Forms.Label();
            this.lblMovieStartDate = new System.Windows.Forms.Label();
            this.lblMovieEndDate = new System.Windows.Forms.Label();
            this.txtPhimThoiLuong = new System.Windows.Forms.TextBox();
            this.txtPhimSanXuat = new System.Windows.Forms.TextBox();
            this.txtPhimDaoDien = new System.Windows.Forms.TextBox();
            this.txtPhimNamSX = new System.Windows.Forms.TextBox();
            this.dtpPhimNgayKC = new System.Windows.Forms.DateTimePicker();
            this.dtpPhimNgayKT = new System.Windows.Forms.DateTimePicker();
            this.picFilm = new System.Windows.Forms.PictureBox();
            this.btnUpLoadPictureFilm = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.cboTheLoai = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.picFilm)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblMovieID
            // 
            this.lblMovieID.AutoSize = true;
            this.lblMovieID.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMovieID.Location = new System.Drawing.Point(25, 17);
            this.lblMovieID.Name = "lblMovieID";
            this.lblMovieID.Size = new System.Drawing.Size(113, 26);
            this.lblMovieID.TabIndex = 43;
            this.lblMovieID.Text = "Mã phim:";
            // 
            // txtPhimMa
            // 
            this.txtPhimMa.Location = new System.Drawing.Point(176, 15);
            this.txtPhimMa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPhimMa.Name = "txtPhimMa";
            this.txtPhimMa.Size = new System.Drawing.Size(164, 26);
            this.txtPhimMa.TabIndex = 45;
            // 
            // lblMovieName
            // 
            this.lblMovieName.AutoSize = true;
            this.lblMovieName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMovieName.Location = new System.Drawing.Point(23, 50);
            this.lblMovieName.Name = "lblMovieName";
            this.lblMovieName.Size = new System.Drawing.Size(117, 26);
            this.lblMovieName.TabIndex = 36;
            this.lblMovieName.Text = "Tên phim:";
            // 
            // txtPhimTen
            // 
            this.txtPhimTen.Location = new System.Drawing.Point(176, 57);
            this.txtPhimTen.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPhimTen.Name = "txtPhimTen";
            this.txtPhimTen.Size = new System.Drawing.Size(164, 26);
            this.txtPhimTen.TabIndex = 51;
            // 
            // lblMovieProductor
            // 
            this.lblMovieProductor.AutoSize = true;
            this.lblMovieProductor.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMovieProductor.Location = new System.Drawing.Point(409, 20);
            this.lblMovieProductor.Name = "lblMovieProductor";
            this.lblMovieProductor.Size = new System.Drawing.Size(109, 26);
            this.lblMovieProductor.TabIndex = 38;
            this.lblMovieProductor.Text = "Sản xuất:";
            // 
            // lblMovieDirector
            // 
            this.lblMovieDirector.AutoSize = true;
            this.lblMovieDirector.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMovieDirector.Location = new System.Drawing.Point(409, 100);
            this.lblMovieDirector.Name = "lblMovieDirector";
            this.lblMovieDirector.Size = new System.Drawing.Size(111, 26);
            this.lblMovieDirector.TabIndex = 39;
            this.lblMovieDirector.Text = "Đạo diễn:";
            // 
            // lblMovieGenre
            // 
            this.lblMovieGenre.AutoSize = true;
            this.lblMovieGenre.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMovieGenre.Location = new System.Drawing.Point(25, 90);
            this.lblMovieGenre.Name = "lblMovieGenre";
            this.lblMovieGenre.Size = new System.Drawing.Size(103, 26);
            this.lblMovieGenre.TabIndex = 40;
            this.lblMovieGenre.Text = "Thể loại:";
            this.lblMovieGenre.Click += new System.EventHandler(this.lblMovieGenre_Click);
            // 
            // lblMovieYear
            // 
            this.lblMovieYear.AutoSize = true;
            this.lblMovieYear.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMovieYear.Location = new System.Drawing.Point(409, 63);
            this.lblMovieYear.Name = "lblMovieYear";
            this.lblMovieYear.Size = new System.Drawing.Size(103, 26);
            this.lblMovieYear.TabIndex = 41;
            this.lblMovieYear.Text = "Năm SX:";
            // 
            // lblMovieLength
            // 
            this.lblMovieLength.AutoSize = true;
            this.lblMovieLength.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMovieLength.Location = new System.Drawing.Point(23, 136);
            this.lblMovieLength.Name = "lblMovieLength";
            this.lblMovieLength.Size = new System.Drawing.Size(133, 26);
            this.lblMovieLength.TabIndex = 35;
            this.lblMovieLength.Text = "Thời lượng:";
            // 
            // lblMovieStartDate
            // 
            this.lblMovieStartDate.AutoSize = true;
            this.lblMovieStartDate.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMovieStartDate.Location = new System.Drawing.Point(409, 137);
            this.lblMovieStartDate.Name = "lblMovieStartDate";
            this.lblMovieStartDate.Size = new System.Drawing.Size(115, 26);
            this.lblMovieStartDate.TabIndex = 42;
            this.lblMovieStartDate.Text = "Ngày KC:";
            // 
            // lblMovieEndDate
            // 
            this.lblMovieEndDate.AutoSize = true;
            this.lblMovieEndDate.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMovieEndDate.Location = new System.Drawing.Point(409, 180);
            this.lblMovieEndDate.Name = "lblMovieEndDate";
            this.lblMovieEndDate.Size = new System.Drawing.Size(111, 26);
            this.lblMovieEndDate.TabIndex = 44;
            this.lblMovieEndDate.Text = "Ngày KT:";
            // 
            // txtPhimThoiLuong
            // 
            this.txtPhimThoiLuong.Location = new System.Drawing.Point(176, 138);
            this.txtPhimThoiLuong.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPhimThoiLuong.Name = "txtPhimThoiLuong";
            this.txtPhimThoiLuong.Size = new System.Drawing.Size(164, 26);
            this.txtPhimThoiLuong.TabIndex = 47;
            // 
            // txtPhimSanXuat
            // 
            this.txtPhimSanXuat.Location = new System.Drawing.Point(562, 26);
            this.txtPhimSanXuat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPhimSanXuat.Name = "txtPhimSanXuat";
            this.txtPhimSanXuat.Size = new System.Drawing.Size(188, 26);
            this.txtPhimSanXuat.TabIndex = 48;
            // 
            // txtPhimDaoDien
            // 
            this.txtPhimDaoDien.Location = new System.Drawing.Point(562, 107);
            this.txtPhimDaoDien.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPhimDaoDien.Name = "txtPhimDaoDien";
            this.txtPhimDaoDien.Size = new System.Drawing.Size(188, 26);
            this.txtPhimDaoDien.TabIndex = 49;
            // 
            // txtPhimNamSX
            // 
            this.txtPhimNamSX.Location = new System.Drawing.Point(562, 65);
            this.txtPhimNamSX.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPhimNamSX.Name = "txtPhimNamSX";
            this.txtPhimNamSX.Size = new System.Drawing.Size(188, 26);
            this.txtPhimNamSX.TabIndex = 50;
            // 
            // dtpPhimNgayKC
            // 
            this.dtpPhimNgayKC.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpPhimNgayKC.Location = new System.Drawing.Point(562, 137);
            this.dtpPhimNgayKC.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpPhimNgayKC.Name = "dtpPhimNgayKC";
            this.dtpPhimNgayKC.Size = new System.Drawing.Size(226, 26);
            this.dtpPhimNgayKC.TabIndex = 52;
            // 
            // dtpPhimNgayKT
            // 
            this.dtpPhimNgayKT.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpPhimNgayKT.Location = new System.Drawing.Point(562, 180);
            this.dtpPhimNgayKT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpPhimNgayKT.Name = "dtpPhimNgayKT";
            this.dtpPhimNgayKT.Size = new System.Drawing.Size(226, 26);
            this.dtpPhimNgayKT.TabIndex = 53;
            // 
            // picFilm
            // 
            this.picFilm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picFilm.Location = new System.Drawing.Point(1061, 2);
            this.picFilm.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picFilm.Name = "picFilm";
            this.picFilm.Size = new System.Drawing.Size(209, 271);
            this.picFilm.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picFilm.TabIndex = 55;
            this.picFilm.TabStop = false;
            // 
            // btnUpLoadPictureFilm
            // 
            this.btnUpLoadPictureFilm.Location = new System.Drawing.Point(1094, 289);
            this.btnUpLoadPictureFilm.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUpLoadPictureFilm.Name = "btnUpLoadPictureFilm";
            this.btnUpLoadPictureFilm.Size = new System.Drawing.Size(143, 51);
            this.btnUpLoadPictureFilm.TabIndex = 56;
            this.btnUpLoadPictureFilm.Text = "Chọn hình ảnh";
            this.btnUpLoadPictureFilm.UseVisualStyleBackColor = true;
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(193, 239);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(100, 55);
            this.btnOk.TabIndex = 57;
            this.btnOk.Text = "Ok";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(502, 239);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(100, 55);
            this.btnThoat.TabIndex = 57;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // cboTheLoai
            // 
            this.cboTheLoai.FormattingEnabled = true;
            this.cboTheLoai.Location = new System.Drawing.Point(176, 92);
            this.cboTheLoai.Name = "cboTheLoai";
            this.cboTheLoai.Size = new System.Drawing.Size(164, 28);
            this.cboTheLoai.TabIndex = 58;
            this.cboTheLoai.SelectedIndexChanged += new System.EventHandler(this.cboTheLoai_SelectedIndexChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.cboTheLoai);
            this.panel2.Controls.Add(this.btnThoat);
            this.panel2.Controls.Add(this.btnOk);
            this.panel2.Controls.Add(this.btnUpLoadPictureFilm);
            this.panel2.Controls.Add(this.picFilm);
            this.panel2.Controls.Add(this.dtpPhimNgayKT);
            this.panel2.Controls.Add(this.dtpPhimNgayKC);
            this.panel2.Controls.Add(this.txtPhimNamSX);
            this.panel2.Controls.Add(this.txtPhimDaoDien);
            this.panel2.Controls.Add(this.txtPhimSanXuat);
            this.panel2.Controls.Add(this.txtPhimThoiLuong);
            this.panel2.Controls.Add(this.lblMovieEndDate);
            this.panel2.Controls.Add(this.lblMovieStartDate);
            this.panel2.Controls.Add(this.lblMovieLength);
            this.panel2.Controls.Add(this.lblMovieYear);
            this.panel2.Controls.Add(this.lblMovieGenre);
            this.panel2.Controls.Add(this.lblMovieDirector);
            this.panel2.Controls.Add(this.lblMovieProductor);
            this.panel2.Controls.Add(this.txtPhimTen);
            this.panel2.Controls.Add(this.lblMovieName);
            this.panel2.Controls.Add(this.txtPhimMa);
            this.panel2.Controls.Add(this.lblMovieID);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(793, 336);
            this.panel2.TabIndex = 2;
            // 
            // AddPhim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(793, 335);
            this.Controls.Add(this.panel2);
            this.Name = "AddPhim";
            this.Text = "AddPhim";
            ((System.ComponentModel.ISupportInitialize)(this.picFilm)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblMovieID;
        private System.Windows.Forms.TextBox txtPhimMa;
        private System.Windows.Forms.Label lblMovieName;
        private System.Windows.Forms.TextBox txtPhimTen;
        private System.Windows.Forms.Label lblMovieProductor;
        private System.Windows.Forms.Label lblMovieDirector;
        private System.Windows.Forms.Label lblMovieGenre;
        private System.Windows.Forms.Label lblMovieYear;
        private System.Windows.Forms.Label lblMovieLength;
        private System.Windows.Forms.Label lblMovieStartDate;
        private System.Windows.Forms.Label lblMovieEndDate;
        private System.Windows.Forms.TextBox txtPhimThoiLuong;
        private System.Windows.Forms.TextBox txtPhimSanXuat;
        private System.Windows.Forms.TextBox txtPhimDaoDien;
        private System.Windows.Forms.TextBox txtPhimNamSX;
        private System.Windows.Forms.DateTimePicker dtpPhimNgayKC;
        private System.Windows.Forms.DateTimePicker dtpPhimNgayKT;
        private System.Windows.Forms.PictureBox picFilm;
        private System.Windows.Forms.Button btnUpLoadPictureFilm;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.ComboBox cboTheLoai;
        private System.Windows.Forms.Panel panel2;
    }
}