using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DatPhongKhachSan
{
    public partial class Form1 : Form
    {
        DataTable dt = new DataTable();
        public Form1()
        {
            InitializeComponent();
            dataGridView.Columns.Clear();
            dt.Columns.Add("Mã Phòng", typeof(string));
            dt.Columns.Add("Loại Phòng", typeof(string));
            dt.Columns.Add("Giá Phòng", typeof(double));
            dt.Columns.Add("Tình Trạng Phòng", typeof(string));
            dt.Columns.Add("Số Ngày Ở", typeof(int));
            khoiTao();
        }
        private void khoiTao()
        {
            dt.Rows.Add("A001", "A", 150000, 0, 0);
            dt.Rows.Add("A002", "A", 150000, 0, 0);
            dt.Rows.Add("B001", "B", 200000, 1, 2);
            dt.Rows.Add("B002", "B", 200000, 0, 0);
            dt.Rows.Add("C001", "C", 300000, 0, 0);
            dt.Rows.Add("C002", "C", 300000, 1, 10);
            dt.Rows.Add("C003", "C", 300000, 0, 0);
            dataGridView.DataSource = dt;
        }
        private void trangThai()
        {
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                int temp = Convert.ToInt32(dt.Rows[i].ToString());
                if (temp == 1)
                    dataGridView.BackgroundColor = Color.Red;
            }    
        }

        private void btnThemPhong_Click(object sender, EventArgs e)
        {
            try
            {
                string ma, loai, tt;
                int ngay;
                double gia;
                ma = txtMaPhong.Text;
                loai = cbLoaiPhong.Text;
                gia = Convert.ToDouble(txtGiaPhong.Text);
                tt = cbTinhTrangPhong.Text;
                ngay = Convert.ToInt32(txtSoNgayO.Text);
                dt.Rows.Add(ma, loai, gia, tt, ngay);
                dataGridView.DataSource = dt;
            }
            catch { MessageBox.Show("Dữ liệu nhập vào có lỗi !!!"); };
        }
        private int kiemTraPhong(string thongTin)
        {
            int kiemTra = -1;
            for(int i = 0; i < dt.Rows.Count; i++)
            {
                string tam = dt.Rows[i].ItemArray[0].ToString();
                if (tam == thongTin)
                {
                    kiemTra = i;
                    break;
                }
            }    
            return kiemTra;
        }
        private void btnDatPhong_Click(object sender, EventArgs e)
        {
            string ma, tt;
            int ngay;
            ma = txtMaPhong.Text;
            tt = cbTinhTrangPhong.Text;
            ngay = Convert.ToInt32(txtSoNgayO.Text);

            int tam = kiemTraPhong(ma);
            dataGridView.Rows[tam].Cells[3].Value = 1;
            dataGridView.Rows[tam].Cells[4].Value = ngay;
            MessageBox.Show("Đặt phòng thành công!!!");
        }

        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                dataGridView.CurrentRow.Selected = true;
                txtMaPhong.Text = dataGridView.Rows[e.RowIndex].Cells["Mã Phòng"].FormattedValue.ToString();
                cbLoaiPhong.Text = dataGridView.Rows[e.RowIndex].Cells["Loại Phòng"].FormattedValue.ToString();
                txtGiaPhong.Text = dataGridView.Rows[e.RowIndex].Cells["Giá Phòng"].FormattedValue.ToString();
                cbTinhTrangPhong.Text = dataGridView.Rows[e.RowIndex].Cells["Tình Trạng Phòng"].FormattedValue.ToString();
                txtSoNgayO.Text = dataGridView.Rows[e.RowIndex].Cells["Số Ngày Ở"].FormattedValue.ToString();
            }
        }

        private void btnHuyPhong_Click(object sender, EventArgs e)
        {
            string ma;
            ma = txtMaPhong.Text;
            int tam = kiemTraPhong(ma);
            dataGridView.Rows[tam].Cells[3].Value = 0;
            dataGridView.Rows[tam].Cells[4].Value = 0;
            MessageBox.Show("Hủy phòng thành công!!!");
        }
        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            string ma = txtMaPhong.Text;
            int tam = kiemTraPhong(ma);
            dataGridView.Rows[tam].Cells[3].Value = 0;
            dataGridView.Rows[tam].Cells[4].Value = 0;
            int ngay = Convert.ToInt32(txtSoNgayO.Text);
            double gia = Convert.ToDouble(txtGiaPhong.Text);
            double thanhTien = ngay * gia;
            MessageBox.Show("Số tiền cần thanh toán: " + thanhTien + " đồng.");
        }
    }
}
