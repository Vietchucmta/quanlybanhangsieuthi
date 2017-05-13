using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using bai6quanlysieuthi.Controller;
using bai6quanlysieuthi.Views;

namespace bai6quanlysieuthi.Views
{
    public partial class KhachHang : Form
    {
        public KhachHang()
        {
            InitializeComponent();
        }

#region menustrip
        private void menuTrangChu_Click(object sender, EventArgs e)
        {
            TrangChu f = new TrangChu();
            this.Hide();
            f.ShowDialog();
            this.Close();
        }

     
        private void menuHangHoa_Click(object sender, EventArgs e)
        {
            HangHoa f = new HangHoa();
            this.Hide();
            f.ShowDialog();
            this.Close();
        }

        private void menuNhanVien_Click(object sender, EventArgs e)
        {
            NhanVien f = new NhanVien();
            this.Hide();
            f.ShowDialog();
            this.Close();
        }

        private void menuHuongDan_Click(object sender, EventArgs e)
        {
            HuongDan f = new HuongDan();
            f.ShowDialog();
        }
        #endregion

        #region khachhang

#region xem khách hàng
        private void btnViewKh_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            ViewKhachHang();
        }

        void ViewKhachHang()
        {
            dgvKh.DataSource = KhachhangController.Instance.XemKhachHang();
            dgvKh.Columns["ma"].HeaderText = @"Mã";
            dgvKh.Columns["ma"].Width = 40;
            dgvKh.Columns["ten"].HeaderText = @"Họ và tên";
            dgvKh.Columns["ten"].Width = 160;
            dgvKh.Columns["diachi"].HeaderText = @"Địa chỉ";
            dgvKh.Columns["diachi"].Width = 180;
            dgvKh.Columns["sodienthoai"].HeaderText = @"Số điện thoại";
            dgvKh.Columns["sodienthoai"].Width = 120;
            dgvKh.Columns["uudai"].HeaderText = @"Ưu đãi";
            dgvKh.Columns["uudai"].Width = 55;
        }

        private void dgvKh_CellClick(object sender,DataGridViewCellEventArgs e)
        {
            txtMakh.Text = dgvKh.CurrentRow.Cells[0].Value.ToString();
            txtTenkh.Text = dgvKh.CurrentRow.Cells[1].Value.ToString();
            txtDiachi.Text = dgvKh.CurrentRow.Cells[2].Value.ToString();
            txtSodt.Text = dgvKh.CurrentRow.Cells[3].Value.ToString();
            txtUudai.Text = dgvKh.CurrentRow.Cells[4].Value.ToString();
        }
       
        #endregion

#region thêm khách hàng
        private void btnInsertKh_Click(object sender, EventArgs e)
        {
            
        }
#endregion

#region sửa khách hàng
        private void btnUpdate_Click(object sender, EventArgs e)
        {

        }
        #endregion

#region xóa khách hàng
        private void btnDeleteKh_Click(object sender, EventArgs e)
        {

        }
        #endregion

#region tìm khách hàng
        private void btnSearchKh_Click(object sender, EventArgs e)
        {

        }
        #endregion

        private void btnExitKH_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion

        #region Hóa đơn
        
#region Xem Hóa Đơn
        private void btnViewHD_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            ViewKhachMH();
            ViewHoaDon();
        }
        // xem hóa đơn
        void ViewHoaDon()
        {
            dgvHoaDon.DataSource = HoaDonController.Instance.XemHoaDon();
            dgvHoaDon.Columns["ma"].HeaderText = @"Mã";
            dgvHoaDon.Columns["ma"].Width = 45;
            dgvHoaDon.Columns["manhanvien"].HeaderText = @"Mã nhân viên";
            dgvHoaDon.Columns["manhanvien"].Width = 80;
            dgvHoaDon.Columns["ngaylap"].HeaderText = @"Ngày lập";
            dgvHoaDon.Columns["ngaylap"].Width = 90;
            dgvHoaDon.Columns["tonggiatri"].HeaderText = @"Tổng giá trị";
            dgvHoaDon.Columns["tonggiatri"].Width = 80;
            dgvHoaDon.Columns["thanhtien"].HeaderText = @"Thành tiền";
            dgvHoaDon.Columns["thanhtien"].Width = 80;
        }

        // xem khách mua hàng
        void ViewKhachMH()
        {
            dgvKMH.DataSource = KMHController.Instance.XemKhachMH();
            dgvKMH.Columns["stt"].HeaderText = @"STT";
            dgvKMH.Columns["stt"].Width = 45;
            dgvKMH.Columns["makhachhang"].HeaderText = @"Mã khách hàng";
            dgvKMH.Columns["makhachhang"].Width = 100;
            dgvKMH.Columns["mahoadon"].HeaderText = @"Mã hóa đơn";
            dgvKMH.Columns["mahoadon"].Width = 100;
        }

        private void dgvHoaDon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaHD.Text = dgvHoaDon.CurrentRow.Cells[0].Value.ToString();
            dtpNgayLap.Text = dgvHoaDon.CurrentRow.Cells[1].Value.ToString();
            txtMaNhanVien.Text = dgvHoaDon.CurrentRow.Cells[4].Value.ToString();
            txtTongGiaTri.Text = dgvHoaDon.CurrentRow.Cells[2].Value.ToString();
            txtThanhTien.Text = dgvHoaDon.CurrentRow.Cells[3].Value.ToString();
        }
        #endregion

        #region Thêm hóa đơn
        private void btnInsertHD_Click(object sender, EventArgs e)
        {

        }
        #endregion

#region Sửa hóa đơn
        private void btnUpdateHD_Click(object sender, EventArgs e)
        {

        }
        #endregion

#region Xóa hóa đơn
        private void btnDeleteHD_Click(object sender, EventArgs e)
        {

        }
        #endregion

        private void btnExitHD_Click(object sender, EventArgs e)
        {
            this.Close();
        }

#region Tìm kiếm hóa đơn
        private void btnSearchHD_Click(object sender, EventArgs e)
        {

        }
        #endregion

#region chi tiết hóa đon
        private void btnChiTietHD_Click(object sender, EventArgs e)
        {
            ChiTiet_HD f = new ChiTiet_HD();
            f.ShowDialog();
        }
        #endregion

        #endregion

        
    }
}
