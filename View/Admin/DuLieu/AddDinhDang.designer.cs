namespace pbl3.View.Admin.DuLieu
{
    partial class AddDinhDang
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
            this.btnDinhDangCancel = new System.Windows.Forms.Button();
            this.btnDinhDangOk = new System.Windows.Forms.Button();
            this.cbbDinhDangMaMH = new System.Windows.Forms.ComboBox();
            this.lblFormat_ScreenName = new System.Windows.Forms.Label();
            this.cbbDinhDangMaPhim = new System.Windows.Forms.ComboBox();
            this.lblFormat_ScreenID = new System.Windows.Forms.Label();
            this.lblFormat_MovieName = new System.Windows.Forms.Label();
            this.lblFormat_MovieID = new System.Windows.Forms.Label();
            this.txtDinhDangTenMH = new System.Windows.Forms.TextBox();
            this.lblFormatID = new System.Windows.Forms.Label();
            this.txtDinhDangTenPhim = new System.Windows.Forms.TextBox();
            this.txtDinhDangMaDinhDang = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnDinhDangCancel
            // 
            this.btnDinhDangCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDinhDangCancel.Location = new System.Drawing.Point(544, 173);
            this.btnDinhDangCancel.Name = "btnDinhDangCancel";
            this.btnDinhDangCancel.Size = new System.Drawing.Size(119, 53);
            this.btnDinhDangCancel.TabIndex = 74;
            this.btnDinhDangCancel.Text = "Cancel";
            this.btnDinhDangCancel.UseVisualStyleBackColor = true;
            // 
            // btnDinhDangOk
            // 
            this.btnDinhDangOk.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDinhDangOk.Location = new System.Drawing.Point(278, 173);
            this.btnDinhDangOk.Name = "btnDinhDangOk";
            this.btnDinhDangOk.Size = new System.Drawing.Size(119, 53);
            this.btnDinhDangOk.TabIndex = 75;
            this.btnDinhDangOk.Text = "Ok";
            this.btnDinhDangOk.UseVisualStyleBackColor = true;
            this.btnDinhDangOk.Click += new System.EventHandler(this.btnDinhDangOk_Click);
            // 
            // cbbDinhDangMaMH
            // 
            this.cbbDinhDangMaMH.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbDinhDangMaMH.FormattingEnabled = true;
            this.cbbDinhDangMaMH.Location = new System.Drawing.Point(187, 40);
            this.cbbDinhDangMaMH.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbbDinhDangMaMH.Name = "cbbDinhDangMaMH";
            this.cbbDinhDangMaMH.Size = new System.Drawing.Size(259, 28);
            this.cbbDinhDangMaMH.TabIndex = 70;
            this.cbbDinhDangMaMH.SelectedIndexChanged += new System.EventHandler(this.cbbDinhDangMaMH_SelectedIndexChanged);
            // 
            // lblFormat_ScreenName
            // 
            this.lblFormat_ScreenName.AutoSize = true;
            this.lblFormat_ScreenName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFormat_ScreenName.Location = new System.Drawing.Point(10, 83);
            this.lblFormat_ScreenName.Name = "lblFormat_ScreenName";
            this.lblFormat_ScreenName.Size = new System.Drawing.Size(161, 26);
            this.lblFormat_ScreenName.TabIndex = 65;
            this.lblFormat_ScreenName.Text = "Tên màn hình:";
            // 
            // cbbDinhDangMaPhim
            // 
            this.cbbDinhDangMaPhim.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbDinhDangMaPhim.FormattingEnabled = true;
            this.cbbDinhDangMaPhim.Location = new System.Drawing.Point(694, 37);
            this.cbbDinhDangMaPhim.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbbDinhDangMaPhim.Name = "cbbDinhDangMaPhim";
            this.cbbDinhDangMaPhim.Size = new System.Drawing.Size(259, 28);
            this.cbbDinhDangMaPhim.TabIndex = 71;
            this.cbbDinhDangMaPhim.SelectedIndexChanged += new System.EventHandler(this.cbbDinhDangMaPhim_SelectedIndexChanged);
            // 
            // lblFormat_ScreenID
            // 
            this.lblFormat_ScreenID.AutoSize = true;
            this.lblFormat_ScreenID.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFormat_ScreenID.Location = new System.Drawing.Point(10, 41);
            this.lblFormat_ScreenID.Name = "lblFormat_ScreenID";
            this.lblFormat_ScreenID.Size = new System.Drawing.Size(157, 26);
            this.lblFormat_ScreenID.TabIndex = 66;
            this.lblFormat_ScreenID.Text = "Mã màn hình:";
            // 
            // lblFormat_MovieName
            // 
            this.lblFormat_MovieName.AutoSize = true;
            this.lblFormat_MovieName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFormat_MovieName.Location = new System.Drawing.Point(517, 79);
            this.lblFormat_MovieName.Name = "lblFormat_MovieName";
            this.lblFormat_MovieName.Size = new System.Drawing.Size(117, 26);
            this.lblFormat_MovieName.TabIndex = 67;
            this.lblFormat_MovieName.Text = "Tên phim:";
            // 
            // lblFormat_MovieID
            // 
            this.lblFormat_MovieID.AutoSize = true;
            this.lblFormat_MovieID.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFormat_MovieID.Location = new System.Drawing.Point(517, 38);
            this.lblFormat_MovieID.Name = "lblFormat_MovieID";
            this.lblFormat_MovieID.Size = new System.Drawing.Size(113, 26);
            this.lblFormat_MovieID.TabIndex = 68;
            this.lblFormat_MovieID.Text = "Mã phim:";
            // 
            // txtDinhDangTenMH
            // 
            this.txtDinhDangTenMH.Location = new System.Drawing.Point(187, 86);
            this.txtDinhDangTenMH.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDinhDangTenMH.Name = "txtDinhDangTenMH";
            this.txtDinhDangTenMH.ReadOnly = true;
            this.txtDinhDangTenMH.Size = new System.Drawing.Size(259, 26);
            this.txtDinhDangTenMH.TabIndex = 62;
            // 
            // lblFormatID
            // 
            this.lblFormatID.AutoSize = true;
            this.lblFormatID.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFormatID.Location = new System.Drawing.Point(10, 126);
            this.lblFormatID.Name = "lblFormatID";
            this.lblFormatID.Size = new System.Drawing.Size(163, 26);
            this.lblFormatID.TabIndex = 69;
            this.lblFormatID.Text = "Mã định dạng:";
            // 
            // txtDinhDangTenPhim
            // 
            this.txtDinhDangTenPhim.Location = new System.Drawing.Point(694, 78);
            this.txtDinhDangTenPhim.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDinhDangTenPhim.Name = "txtDinhDangTenPhim";
            this.txtDinhDangTenPhim.ReadOnly = true;
            this.txtDinhDangTenPhim.Size = new System.Drawing.Size(259, 26);
            this.txtDinhDangTenPhim.TabIndex = 63;
            // 
            // txtDinhDangMaDinhDang
            // 
            this.txtDinhDangMaDinhDang.Location = new System.Drawing.Point(187, 125);
            this.txtDinhDangMaDinhDang.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDinhDangMaDinhDang.Name = "txtDinhDangMaDinhDang";
            this.txtDinhDangMaDinhDang.Size = new System.Drawing.Size(259, 26);
            this.txtDinhDangMaDinhDang.TabIndex = 64;
            // 
            // AddDinhDang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(996, 248);
            this.Controls.Add(this.btnDinhDangCancel);
            this.Controls.Add(this.btnDinhDangOk);
            this.Controls.Add(this.cbbDinhDangMaMH);
            this.Controls.Add(this.lblFormat_ScreenName);
            this.Controls.Add(this.cbbDinhDangMaPhim);
            this.Controls.Add(this.lblFormat_ScreenID);
            this.Controls.Add(this.lblFormat_MovieName);
            this.Controls.Add(this.lblFormat_MovieID);
            this.Controls.Add(this.txtDinhDangTenMH);
            this.Controls.Add(this.lblFormatID);
            this.Controls.Add(this.txtDinhDangTenPhim);
            this.Controls.Add(this.txtDinhDangMaDinhDang);
            this.Name = "AddDinhDang";
            this.Text = "AddDinhDang";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnDinhDangCancel;
        private System.Windows.Forms.Button btnDinhDangOk;
        private System.Windows.Forms.ComboBox cbbDinhDangMaMH;
        private System.Windows.Forms.Label lblFormat_ScreenName;
        private System.Windows.Forms.ComboBox cbbDinhDangMaPhim;
        private System.Windows.Forms.Label lblFormat_ScreenID;
        private System.Windows.Forms.Label lblFormat_MovieName;
        private System.Windows.Forms.Label lblFormat_MovieID;
        private System.Windows.Forms.TextBox txtDinhDangTenMH;
        private System.Windows.Forms.Label lblFormatID;
        private System.Windows.Forms.TextBox txtDinhDangTenPhim;
        private System.Windows.Forms.TextBox txtDinhDangMaDinhDang;
    }
}