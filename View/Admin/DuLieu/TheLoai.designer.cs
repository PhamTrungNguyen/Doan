namespace pbl3.Admin.DuLieu
{
    partial class TheLoai
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
            this.btnTheLoaiThemXem = new System.Windows.Forms.Button();
            this.btnTheLoaiXoa = new System.Windows.Forms.Button();
            this.btnTheLoaiSua = new System.Windows.Forms.Button();
            this.btnTheLoaiThem = new System.Windows.Forms.Button();
            this.txtTheLoaiTen = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTheLoaiMa = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvTheLoai = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTheLoai)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnTheLoaiThemXem);
            this.panel1.Controls.Add(this.btnTheLoaiXoa);
            this.panel1.Controls.Add(this.btnTheLoaiSua);
            this.panel1.Controls.Add(this.btnTheLoaiThem);
            this.panel1.Controls.Add(this.txtTheLoaiTen);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtTheLoaiMa);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(353, 661);
            this.panel1.TabIndex = 0;
            // 
            // btnTheLoaiThemXem
            // 
            this.btnTheLoaiThemXem.Location = new System.Drawing.Point(166, 267);
            this.btnTheLoaiThemXem.Name = "btnTheLoaiThemXem";
            this.btnTheLoaiThemXem.Size = new System.Drawing.Size(109, 42);
            this.btnTheLoaiThemXem.TabIndex = 3;
            this.btnTheLoaiThemXem.Text = "Xem";
            this.btnTheLoaiThemXem.UseVisualStyleBackColor = true;
            this.btnTheLoaiThemXem.Click += new System.EventHandler(this.btnTheLoaiThemXem_Click);
            // 
            // btnTheLoaiXoa
            // 
            this.btnTheLoaiXoa.Location = new System.Drawing.Point(37, 267);
            this.btnTheLoaiXoa.Name = "btnTheLoaiXoa";
            this.btnTheLoaiXoa.Size = new System.Drawing.Size(109, 42);
            this.btnTheLoaiXoa.TabIndex = 4;
            this.btnTheLoaiXoa.Text = "Xóa";
            this.btnTheLoaiXoa.UseVisualStyleBackColor = true;
            this.btnTheLoaiXoa.Click += new System.EventHandler(this.btnTheLoaiXoa_Click);
            // 
            // btnTheLoaiSua
            // 
            this.btnTheLoaiSua.Location = new System.Drawing.Point(166, 219);
            this.btnTheLoaiSua.Name = "btnTheLoaiSua";
            this.btnTheLoaiSua.Size = new System.Drawing.Size(109, 42);
            this.btnTheLoaiSua.TabIndex = 5;
            this.btnTheLoaiSua.Text = "Sửa";
            this.btnTheLoaiSua.UseVisualStyleBackColor = true;
            this.btnTheLoaiSua.Click += new System.EventHandler(this.btnTheLoaiSua_Click);
            // 
            // btnTheLoaiThem
            // 
            this.btnTheLoaiThem.Location = new System.Drawing.Point(37, 219);
            this.btnTheLoaiThem.Name = "btnTheLoaiThem";
            this.btnTheLoaiThem.Size = new System.Drawing.Size(109, 42);
            this.btnTheLoaiThem.TabIndex = 6;
            this.btnTheLoaiThem.Text = "Thêm";
            this.btnTheLoaiThem.UseVisualStyleBackColor = true;
            this.btnTheLoaiThem.Click += new System.EventHandler(this.btnTheLoaiThem_Click);
            // 
            // txtTheLoaiTen
            // 
            this.txtTheLoaiTen.Location = new System.Drawing.Point(27, 142);
            this.txtTheLoaiTen.Name = "txtTheLoaiTen";
            this.txtTheLoaiTen.Size = new System.Drawing.Size(187, 30);
            this.txtTheLoaiTen.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tên thể loại:";
            // 
            // txtTheLoaiMa
            // 
            this.txtTheLoaiMa.Location = new System.Drawing.Point(27, 50);
            this.txtTheLoaiMa.Name = "txtTheLoaiMa";
            this.txtTheLoaiMa.Size = new System.Drawing.Size(187, 30);
            this.txtTheLoaiMa.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã thể loại:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgvTheLoai);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(353, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(703, 661);
            this.panel2.TabIndex = 1;
            // 
            // dgvTheLoai
            // 
            this.dgvTheLoai.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTheLoai.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTheLoai.Location = new System.Drawing.Point(0, 0);
            this.dgvTheLoai.Name = "dgvTheLoai";
            this.dgvTheLoai.RowHeadersWidth = 62;
            this.dgvTheLoai.RowTemplate.Height = 28;
            this.dgvTheLoai.Size = new System.Drawing.Size(703, 661);
            this.dgvTheLoai.TabIndex = 0;
            this.dgvTheLoai.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvTheLoai_RowHeaderMouseClick);
            // 
            // TheLoai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "TheLoai";
            this.Size = new System.Drawing.Size(1056, 661);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTheLoai)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtTheLoaiTen;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTheLoaiMa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgvTheLoai;
        private System.Windows.Forms.Button btnTheLoaiThemXem;
        private System.Windows.Forms.Button btnTheLoaiXoa;
        private System.Windows.Forms.Button btnTheLoaiSua;
        private System.Windows.Forms.Button btnTheLoaiThem;
    }
}
