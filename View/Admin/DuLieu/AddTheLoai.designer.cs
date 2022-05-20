namespace DoAn.Admin.DuLieu
{
    partial class AddTheLoai
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
            this.btnTheLoaiThoat = new System.Windows.Forms.Button();
            this.btnTheLoaiOK = new System.Windows.Forms.Button();
            this.txtTheLoaiTen = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTheLoaiMa = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnTheLoaiThoat
            // 
            this.btnTheLoaiThoat.Location = new System.Drawing.Point(220, 143);
            this.btnTheLoaiThoat.Name = "btnTheLoaiThoat";
            this.btnTheLoaiThoat.Size = new System.Drawing.Size(109, 42);
            this.btnTheLoaiThoat.TabIndex = 15;
            this.btnTheLoaiThoat.Text = "Cancel";
            this.btnTheLoaiThoat.UseVisualStyleBackColor = true;
            // 
            // btnTheLoaiOK
            // 
            this.btnTheLoaiOK.Location = new System.Drawing.Point(60, 143);
            this.btnTheLoaiOK.Name = "btnTheLoaiOK";
            this.btnTheLoaiOK.Size = new System.Drawing.Size(109, 42);
            this.btnTheLoaiOK.TabIndex = 16;
            this.btnTheLoaiOK.Text = "Ok";
            this.btnTheLoaiOK.UseVisualStyleBackColor = true;
            this.btnTheLoaiOK.Click += new System.EventHandler(this.btnTheLoaiOK_Click);
            // 
            // txtTheLoaiTen
            // 
            this.txtTheLoaiTen.Location = new System.Drawing.Point(340, 66);
            this.txtTheLoaiTen.Name = "txtTheLoaiTen";
            this.txtTheLoaiTen.Size = new System.Drawing.Size(187, 26);
            this.txtTheLoaiTen.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(335, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 25);
            this.label2.TabIndex = 8;
            this.label2.Text = "Tên thể loại:";
            // 
            // txtTheLoaiMa
            // 
            this.txtTheLoaiMa.Location = new System.Drawing.Point(60, 66);
            this.txtTheLoaiMa.Name = "txtTheLoaiMa";
            this.txtTheLoaiMa.Size = new System.Drawing.Size(187, 26);
            this.txtTheLoaiMa.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(55, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 25);
            this.label1.TabIndex = 9;
            this.label1.Text = "Mã thể loại:";
            // 
            // AddTheLoai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(661, 247);
            this.Controls.Add(this.btnTheLoaiThoat);
            this.Controls.Add(this.btnTheLoaiOK);
            this.Controls.Add(this.txtTheLoaiTen);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTheLoaiMa);
            this.Controls.Add(this.label1);
            this.Name = "AddTheLoai";
            this.Text = "AddTheLoai";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnTheLoaiThoat;
        private System.Windows.Forms.Button btnTheLoaiOK;
        private System.Windows.Forms.TextBox txtTheLoaiTen;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTheLoaiMa;
        private System.Windows.Forms.Label label1;
    }
}