namespace pbl3.Admin.DuLieu
{
    partial class LoaiManHinh
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
            this.dgvManHinh = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.BtnManHinhXem = new System.Windows.Forms.Button();
            this.txttxtManHinhTen = new System.Windows.Forms.TextBox();
            this.BtnManHinhSua = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnManHinhXoa = new System.Windows.Forms.Button();
            this.BtnManHinhThem = new System.Windows.Forms.Button();
            this.txtManHinhMa = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvManHinh)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgvManHinh);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(368, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(557, 511);
            this.panel1.TabIndex = 0;
            // 
            // dgvManHinh
            // 
            this.dgvManHinh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvManHinh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvManHinh.Location = new System.Drawing.Point(0, 0);
            this.dgvManHinh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvManHinh.Name = "dgvManHinh";
            this.dgvManHinh.RowHeadersWidth = 62;
            this.dgvManHinh.RowTemplate.Height = 28;
            this.dgvManHinh.Size = new System.Drawing.Size(557, 511);
            this.dgvManHinh.TabIndex = 0;
            this.dgvManHinh.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvManHinh_RowHeaderMouseClick);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.BtnManHinhXem);
            this.panel2.Controls.Add(this.txttxtManHinhTen);
            this.panel2.Controls.Add(this.BtnManHinhSua);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.BtnManHinhXoa);
            this.panel2.Controls.Add(this.BtnManHinhThem);
            this.panel2.Controls.Add(this.txtManHinhMa);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(368, 511);
            this.panel2.TabIndex = 1;
            // 
            // BtnManHinhXem
            // 
            this.BtnManHinhXem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnManHinhXem.Location = new System.Drawing.Point(44, 231);
            this.BtnManHinhXem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnManHinhXem.Name = "BtnManHinhXem";
            this.BtnManHinhXem.Size = new System.Drawing.Size(94, 36);
            this.BtnManHinhXem.TabIndex = 2;
            this.BtnManHinhXem.Text = "Xem";
            this.BtnManHinhXem.UseVisualStyleBackColor = true;
            this.BtnManHinhXem.Click += new System.EventHandler(this.BtnManHinhXem_Click);
            // 
            // txttxtManHinhTen
            // 
            this.txttxtManHinhTen.Location = new System.Drawing.Point(23, 133);
            this.txttxtManHinhTen.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txttxtManHinhTen.Name = "txttxtManHinhTen";
            this.txttxtManHinhTen.Size = new System.Drawing.Size(233, 30);
            this.txttxtManHinhTen.TabIndex = 3;
            // 
            // BtnManHinhSua
            // 
            this.BtnManHinhSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnManHinhSua.Location = new System.Drawing.Point(145, 231);
            this.BtnManHinhSua.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnManHinhSua.Name = "BtnManHinhSua";
            this.BtnManHinhSua.Size = new System.Drawing.Size(94, 36);
            this.BtnManHinhSua.TabIndex = 2;
            this.BtnManHinhSua.Text = "Sửa";
            this.BtnManHinhSua.UseVisualStyleBackColor = true;
            this.BtnManHinhSua.Click += new System.EventHandler(this.BtnManHinhSua_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(19, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tên màn hình :";
            // 
            // BtnManHinhXoa
            // 
            this.BtnManHinhXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnManHinhXoa.Location = new System.Drawing.Point(145, 179);
            this.BtnManHinhXoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnManHinhXoa.Name = "BtnManHinhXoa";
            this.BtnManHinhXoa.Size = new System.Drawing.Size(94, 36);
            this.BtnManHinhXoa.TabIndex = 2;
            this.BtnManHinhXoa.Text = "Xóa";
            this.BtnManHinhXoa.UseVisualStyleBackColor = true;
            this.BtnManHinhXoa.Click += new System.EventHandler(this.BtnManHinhXoa_Click);
            // 
            // BtnManHinhThem
            // 
            this.BtnManHinhThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnManHinhThem.Location = new System.Drawing.Point(44, 179);
            this.BtnManHinhThem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnManHinhThem.Name = "BtnManHinhThem";
            this.BtnManHinhThem.Size = new System.Drawing.Size(94, 36);
            this.BtnManHinhThem.TabIndex = 2;
            this.BtnManHinhThem.Text = "Thêm";
            this.BtnManHinhThem.UseVisualStyleBackColor = true;
            this.BtnManHinhThem.Click += new System.EventHandler(this.BtnManHinhThem_Click);
            // 
            // txtManHinhMa
            // 
            this.txtManHinhMa.Location = new System.Drawing.Point(23, 38);
            this.txtManHinhMa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtManHinhMa.Name = "txtManHinhMa";
            this.txtManHinhMa.Size = new System.Drawing.Size(233, 30);
            this.txtManHinhMa.TabIndex = 1;
            this.txtManHinhMa.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã Loại màn hình :";
            // 
            // LoaiManHinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "LoaiManHinh";
            this.Size = new System.Drawing.Size(925, 511);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvManHinh)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvManHinh;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txttxtManHinhTen;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtManHinhMa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnManHinhThem;
        private System.Windows.Forms.Button BtnManHinhXoa;
        private System.Windows.Forms.Button BtnManHinhXem;
        private System.Windows.Forms.Button BtnManHinhSua;
    }
}
