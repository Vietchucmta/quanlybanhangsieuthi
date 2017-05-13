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

namespace bai6quanlysieuthi.Views
{
    public partial class HangHoa : Form
    {
        public HangHoa()
        {
            InitializeComponent();
        }
#region menu Hàng hóa
        private void menuTrangChu_Click(object sender, EventArgs e)
        {
            TrangChu f = new TrangChu();
            this.Hide();
            f.ShowDialog();
            this.Close();
        }

        private void menuKhachHang_Click(object sender, EventArgs e)
        {
            KhachHang f = new KhachHang();
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

        #region mặt hàng

#region View Mặt hàng

        private void btnView_MH_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            ViewMatHang();
        }
        void ViewMatHang()
        {
            dgvMatHang.DataSource = MatHangController.Instance.XemMatHang();
            dgvMatHang.Columns["ma"].HeaderText = @"Mã";
            dgvMatHang.Columns["ma"].Width = 45;
            dgvMatHang.Columns["ten"].HeaderText = @"Tên mặt hàng";
            dgvMatHang.Columns["ten"].Width = 80;
            dgvMatHang.Columns["loaimathang"].HeaderText = @"Loại mặt hàng";
            dgvMatHang.Columns["loaimathang"].Width = 60;
            dgvMatHang.Columns["donvitinh"].HeaderText = @"Đơn vị tính";
            dgvMatHang.Columns["donvitinh"].Width = 60;
            dgvMatHang.Columns["maquay"].HeaderText = @"Mã quầy";
            dgvMatHang.Columns["maquay"].Width = 60;
            dgvMatHang.Columns["manhacc"].Width = 60;
        }
        private void dgvMatHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaHang.Text = dgvMatHang.CurrentRow.Cells[0].Value.ToString();
            txtTenHang.Text = dgvMatHang.CurrentRow.Cells[1].Value.ToString();
            cbLoai.Text = dgvMatHang.CurrentRow.Cells[2].Value.ToString();
            cbDonViTinh.Text = dgvMatHang.CurrentRow.Cells[3].Value.ToString();
            cbMaQuay.Text = dgvMatHang.CurrentRow.Cells[4].Value.ToString();
            txtMaNCC.Text = dgvMatHang.CurrentRow.Cells[5].Value.ToString();
        }
        #endregion

        private void btnInsert_MH_Click(object sender, EventArgs e)
        {

        }

        private void btnUpdate_MH_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_MH_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_MH_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSearch_MH_Click(object sender, EventArgs e)
        {

        }
        #endregion

        #region Nhà sản xuất

#region  View Nhà sản xuất

        private void btnView_NSX_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            ViewNhaSanXuat();
        }

        void ViewNhaSanXuat()
        {
            dgvNSX.DataSource = NhaCCController.Instance.XemNhaCC();
            dgvNSX.Columns["ma"].HeaderText = @"Mã ncc";
            dgvNSX.Columns["ma"].Width = 45;
            dgvNSX.Columns["ten"].HeaderText = @"Tên ncc";
            dgvNSX.Columns["ten"].Width = 80;
            dgvNSX.Columns["diachi"].HeaderText = @"Địa chỉ";
            dgvNSX.Columns["diachi"].Width = 100;
            dgvNSX.Columns["sodienthoai"].HeaderText = @"Số điện thoại";
            dgvNSX.Columns["sodienthoai"].Width = 50;
            dgvNSX.Columns["email"].HeaderText = @"Email";
            dgvNSX.Columns["email"].Width = 100;
        }
        private void dgvNSX_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaNSX.Text = dgvNSX.CurrentRow.Cells[0].Value.ToString();
            txtTenNSX.Text = dgvNSX.CurrentRow.Cells[1].Value.ToString();
            txtDiaChiNSX.Text = dgvNSX.CurrentRow.Cells[2].Value.ToString();
            txtSoDienThoaiNSX.Text = dgvNSX.CurrentRow.Cells[3].Value.ToString();
            txtEmailNSX.Text = dgvNSX.CurrentRow.Cells[4].Value.ToString();
        }
        #endregion

        private void btnInsert_NSX_Click(object sender, EventArgs e)
        {

        }

        private void btnUpdate_NSX_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_NSX_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_NSX_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSearch_NSX_Click(object sender, EventArgs e)
        {

        }
        #endregion

        #region Nhập Kho
#region View nhập kho

        private void btnView_NK_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            ViewNhapKho();
        }

        void ViewNhapKho()
        {
            dgvNK.DataSource = NhapKhoController.Instance.XemNhapKho();
            dgvNK.Columns["ma"].HeaderText = @"Mã nk";
            dgvNK.Columns["ma"].Width = 45;
            dgvNK.Columns["makhohang"].HeaderText = @"Mã kho hàng";
            dgvNK.Columns["makhohang"].Width = 50;
            dgvNK.Columns["ngaynhap"].HeaderText = @"Ngày nhập";
            dgvNK.Columns["ngaynhap"].Width = 80;
            dgvNK.Columns["tonggiatri"].HeaderText = @"Tổng giá trị";
            dgvNK.Columns["tonggiatri"].Width = 80;
            dgvNK.Columns["manhacungcap"].HeaderText = @"Mã ncc";
            dgvNK.Columns["manhacungcap"].Width = 60;
            dgvNK.Columns["manhanvien"].HeaderText = @"Mã nv";
            dgvNK.Columns["manhanvien"].Width = 60;
        }
        private void dgvNK_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaNK.Text = dgvNK.CurrentRow.Cells[0].Value.ToString();
            cbMaKhoHangNk.Text = dgvNK.CurrentRow.Cells[1].Value.ToString();
            dtpNgayLapNk.Text = dgvNK.CurrentRow.Cells[2].Value.ToString();
            txtTongGiaTriNK.Text = dgvNK.CurrentRow.Cells[3].Value.ToString();
            cbMaNCCNk.Text = dgvNK.CurrentRow.Cells[4].Value.ToString();
            cbMaNhanVienNK.Text = dgvNK.CurrentRow.Cells[5].Value.ToString();
        }
        
        #endregion
        private void btnInsert_NK_Click(object sender, EventArgs e)
        {

        }

        private void btnUpdate_NK_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_NK_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_NK_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSearch_Nk_Click(object sender, EventArgs e)
        {

        }

        private void btnDetail_NK_Click(object sender, EventArgs e)
        {
            ChiTiet_NhapKho f = new ChiTiet_NhapKho();
            f.ShowDialog();
        }
        #endregion

        #region Xuất kho
#region phiếu xuất kho
        private void btnView_XK_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            ViewXuatKho();
        }

        void ViewXuatKho()
        {
            dgvXK.DataSource = XuatKhoController.Instance.XemXuatKho();
            dgvXK.Columns["ma"].HeaderText = @"Mã xk";
            dgvXK.Columns["ma"].Width = 45;
            dgvXK.Columns["makhohang"].HeaderText = @"Mã kho hàng";
            dgvXK.Columns["makhohang"].Width = 50;
            dgvXK.Columns["ngayxuat"].HeaderText = @"Ngày xuất";
            dgvXK.Columns["ngayxuat"].Width = 80;
            dgvXK.Columns["tonggiatri"].HeaderText = @"Tổng giá trị";
            dgvXK.Columns["tonggiatri"].Width = 80;
            dgvXK.Columns["maquay"].HeaderText = @"Mã quầy";
            dgvXK.Columns["maquay"].Width = 60;
            dgvXK.Columns["manhanvien"].HeaderText = @"Mã nv";
            dgvXK.Columns["manhanvien"].Width = 60;
        }
        private void dgvXK_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaXk.Text = dgvXK.CurrentRow.Cells[0].Value.ToString();
            dtpNgayLapXk.Text = dgvXK.CurrentRow.Cells[1].Value.ToString();
            txtTongGiaTriXk.Text = dgvXK.CurrentRow.Cells[2].Value.ToString();
            cbMaKhoHangXk.Text = dgvXK.CurrentRow.Cells[3].Value.ToString();
            cbMaNhanVienXk.Text = dgvXK.CurrentRow.Cells[4].Value.ToString();
            cbMaQuayXK.Text = dgvXK.CurrentRow.Cells[5].Value.ToString();
        }
        #endregion
        private void btnInsert_XK_Click(object sender, EventArgs e)
        {

        }

        private void btnUpdate_XK_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_XK_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_XK_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSearch_XK_Click(object sender, EventArgs e)
        {

        }

        private void btnDetail_XK_Click(object sender, EventArgs e)
        {
            ChiTiet_XuatKho f = new ChiTiet_XuatKho();
            f.ShowDialog();
        }

        #endregion

        #region Kho quầy

        #region Kho hàng
#region View kho hàng
        private void btnView_KH_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            ViewKhoHang();
        }

        void ViewKhoHang()
        {
            dgvKhoHang.DataSource = KhoHangController.Instance.XemKhoHang();
            dgvKhoHang.Columns["ma"].HeaderText = @"Mã kho";
            dgvKhoHang.Columns["ma"].Width = 45;
            dgvKhoHang.Columns["ten"].HeaderText = @"Tên kho";
            dgvKhoHang.Columns["ten"].Width = 100;
            dgvKhoHang.Columns["diachi"].HeaderText = @"Địa chỉ";
            dgvKhoHang.Columns["diachi"].Width = 150;
        }
        private void dgvKhoHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaKho.Text = dgvKhoHang.CurrentRow.Cells[0].Value.ToString();
            txtTenKho.Text = dgvKhoHang.CurrentRow.Cells[1].Value.ToString();
            rtbDiaChiKho.Text = dgvKhoHang.CurrentRow.Cells[2].Value.ToString();
        }
        #endregion
        private void btnInsert_KH_Click(object sender, EventArgs e)
        {

        }

        private void btnUpdate_KH_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_KH_Click(object sender, EventArgs e)
        {

        }
        #endregion

        #region Quầy Hàng
#region View quầy hàng
        private void btnView_QH_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            ViewQuayHang();
        }
        void ViewQuayHang()
        {
            dgvQuayHang.DataSource = QuayHangController.Instance.XemQuayHang();
            dgvQuayHang.Columns["ma"].HeaderText = @"Mã quầy";
            dgvQuayHang.Columns["ma"].Width = 45;
            dgvQuayHang.Columns["ten"].HeaderText = @"Tên quầy";
            dgvQuayHang.Columns["ten"].Width = 80;
            dgvQuayHang.Columns["vitri"].HeaderText = @"Vị trí";
            dgvQuayHang.Columns["vitri"].Width = 80;
        }
        private void dgvQuayHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaQuayH.Text = dgvQuayHang.CurrentRow.Cells[0].Value.ToString();
            txtTenQuayH.Text = dgvQuayHang.CurrentRow.Cells[1].Value.ToString();
            rtbViTriQh.Text = dgvQuayHang.CurrentRow.Cells[2].Value.ToString();
        }
        #endregion
        private void btnInsert_QH_Click(object sender, EventArgs e)
        {

        }

        private void btnUpdate_QH_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_QH_Click(object sender, EventArgs e)
        {

        }
#endregion

        private void btnExit_KQ_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSearch_KQ_Click(object sender, EventArgs e)
        {

        }

        #endregion

        #region kiểm kê
#region View phiếu kiểm kê
        private void btnView_KK_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            ViewKiemKe();
        }
        void ViewKiemKe()
        {
            dgvKiemKe.DataSource = KiemKeController.Instance.XemKiemKe();
            dgvKiemKe.Columns["ma"].HeaderText = @"Mã kiểm kê";
            dgvKiemKe.Columns["ma"].Width = 45;
            dgvKiemKe.Columns["ngaylap"].HeaderText = @"Ngày lập";
            dgvKiemKe.Columns["ngaylap"].Width = 80;
            dgvKiemKe.Columns["mamathang"].HeaderText = @"Mã mặt hàng";
            dgvKiemKe.Columns["mamathang"].Width = 50;
            dgvKiemKe.Columns["soluong"].HeaderText = @"Số lượng";
            dgvKiemKe.Columns["soluong"].Width = 50;
            dgvKiemKe.Columns["makhohang"].HeaderText = @"Mã kho hàng";
            dgvKiemKe.Columns["makhohang"].Width = 50;
            dgvKiemKe.Columns["manhanvien"].HeaderText = @"Mã nhân viên";

        }
        private void dgvKiemKe_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaKK.Text = dgvKiemKe.CurrentRow.Cells[0].Value.ToString();
            dtpNgayLapKK.Text = dgvKiemKe.CurrentRow.Cells[1].Value.ToString();
            cbMaMatHangKK.Text = dgvKiemKe.CurrentRow.Cells[2].Value.ToString();
            txtSoLuongKK.Text = dgvKiemKe.CurrentRow.Cells[3].Value.ToString();
            cbMaNhanVienKK.Text = dgvKiemKe.CurrentRow.Cells[4].Value.ToString();
            cbMaKhoHangKK.Text = dgvKiemKe.CurrentRow.Cells[5].Value.ToString();
        }
        #endregion
        private void btnInsert_KK_Click(object sender, EventArgs e)
        {

        }

        private void btnUpdate_KK_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_KK_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_KK_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSearch_KK_Click(object sender, EventArgs e)
        {

        }






        #endregion

        private void HangHoa_Load(object sender, EventArgs e)
        {

        }
    }
}
