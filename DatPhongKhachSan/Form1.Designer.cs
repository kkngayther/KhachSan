namespace DatPhongKhachSan
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnThanhToan = new System.Windows.Forms.Button();
            this.btnHuyPhong = new System.Windows.Forms.Button();
            this.btnDatPhong = new System.Windows.Forms.Button();
            this.btnThemPhong = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSoNgayO = new System.Windows.Forms.TextBox();
            this.txtTinhTrangPhong = new System.Windows.Forms.TextBox();
            this.txtGiaPhong = new System.Windows.Forms.TextBox();
            this.txtLoaiPhong = new System.Windows.Forms.TextBox();
            this.txtMaPhong = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(27, 46);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(300, 170);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridView);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 262);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(884, 199);
            this.panel1.TabIndex = 15;
            // 
            // dataGridView
            // 
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView.Location = new System.Drawing.Point(0, 0);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(884, 199);
            this.dataGridView.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnThanhToan);
            this.panel2.Controls.Add(this.btnHuyPhong);
            this.panel2.Controls.Add(this.btnDatPhong);
            this.panel2.Controls.Add(this.btnThemPhong);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.txtSoNgayO);
            this.panel2.Controls.Add(this.txtTinhTrangPhong);
            this.panel2.Controls.Add(this.txtGiaPhong);
            this.panel2.Controls.Add(this.txtLoaiPhong);
            this.panel2.Controls.Add(this.txtMaPhong);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(884, 262);
            this.panel2.TabIndex = 16;
            // 
            // btnThanhToan
            // 
            this.btnThanhToan.FlatAppearance.BorderSize = 0;
            this.btnThanhToan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThanhToan.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThanhToan.Location = new System.Drawing.Point(758, 203);
            this.btnThanhToan.Name = "btnThanhToan";
            this.btnThanhToan.Size = new System.Drawing.Size(100, 33);
            this.btnThanhToan.TabIndex = 28;
            this.btnThanhToan.Text = "Thanh toán";
            this.btnThanhToan.UseVisualStyleBackColor = true;
            // 
            // btnHuyPhong
            // 
            this.btnHuyPhong.FlatAppearance.BorderSize = 0;
            this.btnHuyPhong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHuyPhong.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuyPhong.Location = new System.Drawing.Point(758, 144);
            this.btnHuyPhong.Name = "btnHuyPhong";
            this.btnHuyPhong.Size = new System.Drawing.Size(100, 33);
            this.btnHuyPhong.TabIndex = 27;
            this.btnHuyPhong.Text = "Hủy phòng";
            this.btnHuyPhong.UseVisualStyleBackColor = true;
            // 
            // btnDatPhong
            // 
            this.btnDatPhong.FlatAppearance.BorderSize = 0;
            this.btnDatPhong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDatPhong.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDatPhong.Location = new System.Drawing.Point(758, 85);
            this.btnDatPhong.Name = "btnDatPhong";
            this.btnDatPhong.Size = new System.Drawing.Size(100, 33);
            this.btnDatPhong.TabIndex = 26;
            this.btnDatPhong.Text = "Đặt phòng";
            this.btnDatPhong.UseVisualStyleBackColor = true;
            // 
            // btnThemPhong
            // 
            this.btnThemPhong.FlatAppearance.BorderSize = 0;
            this.btnThemPhong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThemPhong.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemPhong.Location = new System.Drawing.Point(758, 26);
            this.btnThemPhong.Name = "btnThemPhong";
            this.btnThemPhong.Size = new System.Drawing.Size(100, 33);
            this.btnThemPhong.TabIndex = 25;
            this.btnThemPhong.Text = "Thêm phòng";
            this.btnThemPhong.UseVisualStyleBackColor = true;
            this.btnThemPhong.Click += new System.EventHandler(this.btnThemPhong_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(369, 197);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 24;
            this.label5.Text = "Số ngày ở :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(336, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 13);
            this.label4.TabIndex = 23;
            this.label4.Text = "Tình trạng phòng :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(368, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "Giá phòng :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(364, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "Loại phòng :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(368, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 15);
            this.label1.TabIndex = 20;
            this.label1.Text = "Mã phòng :";
            // 
            // txtSoNgayO
            // 
            this.txtSoNgayO.Location = new System.Drawing.Point(436, 197);
            this.txtSoNgayO.Name = "txtSoNgayO";
            this.txtSoNgayO.Size = new System.Drawing.Size(300, 20);
            this.txtSoNgayO.TabIndex = 19;
            // 
            // txtTinhTrangPhong
            // 
            this.txtTinhTrangPhong.Location = new System.Drawing.Point(436, 159);
            this.txtTinhTrangPhong.Name = "txtTinhTrangPhong";
            this.txtTinhTrangPhong.Size = new System.Drawing.Size(300, 20);
            this.txtTinhTrangPhong.TabIndex = 18;
            // 
            // txtGiaPhong
            // 
            this.txtGiaPhong.Location = new System.Drawing.Point(436, 121);
            this.txtGiaPhong.Name = "txtGiaPhong";
            this.txtGiaPhong.Size = new System.Drawing.Size(300, 20);
            this.txtGiaPhong.TabIndex = 17;
            // 
            // txtLoaiPhong
            // 
            this.txtLoaiPhong.Location = new System.Drawing.Point(436, 83);
            this.txtLoaiPhong.Name = "txtLoaiPhong";
            this.txtLoaiPhong.Size = new System.Drawing.Size(300, 20);
            this.txtLoaiPhong.TabIndex = 16;
            // 
            // txtMaPhong
            // 
            this.txtMaPhong.Location = new System.Drawing.Point(436, 45);
            this.txtMaPhong.Name = "txtMaPhong";
            this.txtMaPhong.Size = new System.Drawing.Size(300, 20);
            this.txtMaPhong.TabIndex = 15;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 461);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Quản Lý Phòng Khách Sạn";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnThanhToan;
        private System.Windows.Forms.Button btnHuyPhong;
        private System.Windows.Forms.Button btnDatPhong;
        private System.Windows.Forms.Button btnThemPhong;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSoNgayO;
        private System.Windows.Forms.TextBox txtTinhTrangPhong;
        private System.Windows.Forms.TextBox txtGiaPhong;
        private System.Windows.Forms.TextBox txtLoaiPhong;
        private System.Windows.Forms.TextBox txtMaPhong;
    }
}

