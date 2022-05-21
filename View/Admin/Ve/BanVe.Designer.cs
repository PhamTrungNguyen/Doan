namespace DoAn.View.Admin.Ve
{
    partial class BanVe
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
            this.panel61 = new System.Windows.Forms.Panel();
            this.btnAddTicketsByShowTime = new System.Windows.Forms.Button();
            this.btnAllListShowTimes = new System.Windows.Forms.Button();
            this.btnShowShowTimeNotCreateTickets = new System.Windows.Forms.Button();
            this.btnDeleteTicketsByShowTime = new System.Windows.Forms.Button();
            this.lsvLichChieu = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel61.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel61
            // 
            this.panel61.Controls.Add(this.btnAddTicketsByShowTime);
            this.panel61.Controls.Add(this.btnAllListShowTimes);
            this.panel61.Controls.Add(this.btnShowShowTimeNotCreateTickets);
            this.panel61.Controls.Add(this.btnDeleteTicketsByShowTime);
            this.panel61.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel61.Location = new System.Drawing.Point(0, 0);
            this.panel61.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel61.Name = "panel61";
            this.panel61.Size = new System.Drawing.Size(1077, 80);
            this.panel61.TabIndex = 11;
            this.panel61.Paint += new System.Windows.Forms.PaintEventHandler(this.panel61_Paint);
            // 
            // btnAddTicketsByShowTime
            // 
            this.btnAddTicketsByShowTime.Location = new System.Drawing.Point(4, 5);
            this.btnAddTicketsByShowTime.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAddTicketsByShowTime.Name = "btnAddTicketsByShowTime";
            this.btnAddTicketsByShowTime.Size = new System.Drawing.Size(173, 71);
            this.btnAddTicketsByShowTime.TabIndex = 0;
            this.btnAddTicketsByShowTime.Text = "Tự Động Thêm Vé Theo Lịch Chiếu\r\n";
            this.btnAddTicketsByShowTime.UseVisualStyleBackColor = true;
            this.btnAddTicketsByShowTime.Click += new System.EventHandler(this.btnAddTicketsByShowTime_Click);
            // 
            // btnAllListShowTimes
            // 
            this.btnAllListShowTimes.Location = new System.Drawing.Point(547, 5);
            this.btnAllListShowTimes.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAllListShowTimes.Name = "btnAllListShowTimes";
            this.btnAllListShowTimes.Size = new System.Drawing.Size(173, 71);
            this.btnAllListShowTimes.TabIndex = 3;
            this.btnAllListShowTimes.Text = "Xem Tất Cả Lịch Chiếu\r\n";
            this.btnAllListShowTimes.UseVisualStyleBackColor = true;
            this.btnAllListShowTimes.Click += new System.EventHandler(this.btnAllListShowTimes_Click);
            // 
            // btnShowShowTimeNotCreateTickets
            // 
            this.btnShowShowTimeNotCreateTickets.Location = new System.Drawing.Point(366, 5);
            this.btnShowShowTimeNotCreateTickets.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnShowShowTimeNotCreateTickets.Name = "btnShowShowTimeNotCreateTickets";
            this.btnShowShowTimeNotCreateTickets.Size = new System.Drawing.Size(173, 71);
            this.btnShowShowTimeNotCreateTickets.TabIndex = 3;
            this.btnShowShowTimeNotCreateTickets.Text = "Xem Lịch Chiếu Chưa Được Tạo Vé";
            this.btnShowShowTimeNotCreateTickets.UseVisualStyleBackColor = true;
            this.btnShowShowTimeNotCreateTickets.Click += new System.EventHandler(this.btnShowShowTimeNotCreateTickets_Click);
            // 
            // btnDeleteTicketsByShowTime
            // 
            this.btnDeleteTicketsByShowTime.Location = new System.Drawing.Point(185, 5);
            this.btnDeleteTicketsByShowTime.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDeleteTicketsByShowTime.Name = "btnDeleteTicketsByShowTime";
            this.btnDeleteTicketsByShowTime.Size = new System.Drawing.Size(173, 71);
            this.btnDeleteTicketsByShowTime.TabIndex = 1;
            this.btnDeleteTicketsByShowTime.Text = "Xóa Vé Theo Lịch Chiếu";
            this.btnDeleteTicketsByShowTime.UseVisualStyleBackColor = true;
            this.btnDeleteTicketsByShowTime.Click += new System.EventHandler(this.btnDeleteTicketsByShowTime_Click);
            // 
            // lsvLichChieu
            // 
            this.lsvLichChieu.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.lsvLichChieu.FullRowSelect = true;
            this.lsvLichChieu.GridLines = true;
            this.lsvLichChieu.HideSelection = false;
            this.lsvLichChieu.Location = new System.Drawing.Point(247, 4);
            this.lsvLichChieu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lsvLichChieu.Name = "lsvLichChieu";
            this.lsvLichChieu.Size = new System.Drawing.Size(713, 663);
            this.lsvLichChieu.TabIndex = 9;
            this.lsvLichChieu.UseCompatibleStateImageBehavior = false;
            this.lsvLichChieu.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Tên Phòng Chiếu";
            this.columnHeader1.Width = 120;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Tên Phim";
            this.columnHeader2.Width = 150;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Thời Gian";
            this.columnHeader3.Width = 150;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Trạng Thái";
            this.columnHeader4.Width = 100;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lsvLichChieu);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(-79, 80);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1156, 663);
            this.panel1.TabIndex = 13;
            // 
            // BanVe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel61);
            this.Name = "BanVe";
            this.Size = new System.Drawing.Size(1077, 743);
            this.panel61.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel61;
        private System.Windows.Forms.Button btnAddTicketsByShowTime;
        private System.Windows.Forms.Button btnAllListShowTimes;
        private System.Windows.Forms.Button btnShowShowTimeNotCreateTickets;
        private System.Windows.Forms.Button btnDeleteTicketsByShowTime;
        private System.Windows.Forms.ListView lsvLichChieu;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Panel panel1;
    }
}
