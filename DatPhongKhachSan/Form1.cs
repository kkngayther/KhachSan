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
            //DataGrid myGrid = new DataGrid();
            //khoiTao();
            dataGridView.Columns.Clear();
            dt.Columns.Add("Ma", typeof(string));
            dt.Columns.Add("Loai", typeof(string));
            dt.Columns.Add("Gia", typeof(double));
            dt.Columns.Add("TT", typeof(string));
            dt.Columns.Add("Ngay", typeof(int));
        }
        private void khoiTao()
        {
            List<Phong> dsPhong = new List<Phong>();
            dsPhong.Add(new Phong() { maPhong = "A001", loaiPhong = "A", giaPhong = 150000, tinhTrangPhong = 0, soNgayO = 0 });
            dataGridView.DataSource = dsPhong;
        }

        private void btnThemPhong_Click(object sender, EventArgs e)
        {
            try
            {
                string ma, loai, tt;
                int ngay;
                double gia;
                ma = txtMaPhong.Text;
                loai = txtLoaiPhong.Text;
                gia = Convert.ToDouble(txtGiaPhong.Text);
                tt = txtTinhTrangPhong.Text;
                ngay = Convert.ToInt32(txtSoNgayO.Text);
                dt.Rows.Add(ma, loai, gia, tt, ngay);
                dataGridView.DataSource = dt;

            }
            catch { MessageBox.Show("Dữ liệu nhập vào có lỗi !!!"); };
        }
    }
}
