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
#region thêm phiếu xuất kho
        private void btnInsert_XK_Click(object sender, EventArgs e)
        {
            if (txtMaXk.Text == "" || cbMaKhoHangXk.Text == "" || cbMaNhanVienXk.Text == "" || cbMaQuayXK.Text == "")
            {
                if (txtMaXk.Text == "")
                    errorProvider1.SetError(txtMaXk, "Chưa có mã xuất kho");
                if (cbMaKhoHangXk.Text == "")
                    errorProvider1.SetError(cbMaKhoHangXk, "Chưa có mã kho hàng");
                if (cbMaNhanVienXk.Text == "")
                    errorProvider1.SetError(cbMaNhanVienXk, "Chưa có mã nhân viên");
                if (cbMaQuayXK.Text == "")
                    errorProvider1.SetError(cbMaQuayXK, "Chưa có mã quầy");
                MessageBox.Show("Phải điề đầy đủ thông tin!");
                return;
            }
            else
            {
                errorProvider1.Clear();
            }
            try
            {
                string ma = txtMaXk.Text;
                string makh = cbMaKhoHangXk.Text;
                string manv = cbMaNhanVienXk.Text;
                string maquay = cbMaQuayXK.Text;
                DateTime ngaylap = (DateTime)Convert.ToDateTime(dtpNgayLapXk.Value.ToString("MM/dd/yyyy"));
                if (MessageBox.Show("Bạn có muốn thêm hay không", "Thêm", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    if (XuatKhoController.Instance.InsertXuatKho(ma,makh,manv,maquay,ngaylap))
                    {
                        MessageBox.Show("Thêm thành công");
                        ViewKhoHang();
                    }
                }
                else
                {
                    MessageBox.Show("Không thành công!");
                }
            }
            catch
            {
                MessageBox.Show("Lỗi dữ liệu");
                return;
            }
        }
#endregion
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
#region thêm  kho hàng
        private void btnInsert_KH_Click(object sender, EventArgs e)
        {
            if (txtMaKho.Text == "" || txtTenKho.Text == "" || rtbDiaChiKho.Text == "")
            {
                if (txtMaKho.Text == "")
                    errorProvider1.SetError(txtMaKho, "Chưa có mã kho");
                if (txtTenKho.Text == "")
                    errorProvider1.SetError(txtTenKho, "Chưa có tên kho");
                if (rtbDiaChiKho.Text == "")
                    errorProvider1.SetError(rtbDiaChiKho, "Chưa có địa chỉ");
                MessageBox.Show("Phải điền thông tin đầy đủ!");
                return;
            }
            else
            {
                errorProvider1.Clear();
            }
            try
            {
                string ma = txtMaKho.Text;
                string ten = txtTenKho.Text;
                string diachi = rtbDiaChiKho.Text;

                if (MessageBox.Show("Bạn có muốn thêm hay không", "Thêm", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    if (KhoHangController.Instance.InsertKhoHang(ma, ten, diachi))
                    {
                        MessageBox.Show("Thêm thành công");
                        ViewKhoHang();
                    }
                }
                else
                {
                    MessageBox.Show("Không thành công!");
                }
            }
            catch
            {
                MessageBox.Show("Lỗi dữ liệu");
                return;
            }
        }
        #endregion
#region sửa kho hàng
        private void btnUpdate_KH_Click(object sender, EventArgs e)
        {
            if (txtTenKho.Text == "" || rtbDiaChiKho.Text == "")
            {
                if (txtTenKho.Text == "")
                    errorProvider1.SetError(txtTenKho, "Chưa có tên kho");
                if (rtbDiaChiKho.Text == "")
                    errorProvider1.SetError(rtbDiaChiKho, "Chưa có địa chỉ");
                MessageBox.Show("Phải điền thông tin sửa!");
                return;
            }
            else
            {
                errorProvider1.Clear();
            }
            try
            {
                string ma = txtMaKho.Text;
                string ten = txtTenKho.Text;
                string diachi = rtbDiaChiKho.Text;
                    if (MessageBox.Show("Bạn có muốn sửa hay không", "Sửa", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                    {
                        if (KhoHangController.Instance.UpdateKhoHang(ma, ten, diachi))
                        {
                            MessageBox.Show("Sửa thành công");
                            ViewKhoHang();
                        }
                    }
                else
                {
                    MessageBox.Show("Không thành công!");
                }
            }
            catch
            {
                MessageBox.Show("Lỗi dữ liệu");
                return;
            }
        }
#endregion
        private void btnDelete_KH_Click(object sender, EventArgs e)
        {
            if (txtMaKho.Text == "")
            {
                errorProvider1.SetError(txtMaKho, "Chưa có mã kho cần xóa");
                MessageBox.Show("Phải có mã kho cần xóa");
                return;
            }
            else
            {
                errorProvider1.Clear();
            }
            try
            {
                string ma = txtMaKho.Text;
                    if (MessageBox.Show("Bạn có muốn xóa hay không", "Sửa", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                    {
                        if (KhoHangController.Instance.DeleteKhoHang(ma))
                        {
                            MessageBox.Show("Xóa thành công");
                            ViewKhoHang();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Không thành công");
                    }
            }
            catch
            {
                MessageBox.Show("Lỗi dữ liệu");
                return;
            }
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
#region thêm quầy hàng
        private void btnInsert_QH_Click(object sender, EventArgs e)
        {
            if (txtMaQuayH.Text == "" || txtTenQuayH.Text == "" || rtbViTriQh.Text == "")
            {
                if (txtMaQuayH.Text == "")
                    errorProvider1.SetError(txtMaQuayH, "Chưa có mã quầy");
                if (txtTenQuayH.Text == "")
                    errorProvider1.SetError(txtTenQuayH, "Chưa có tên quầy");
                if (rtbViTriQh.Text == "")
                    errorProvider1.SetError(rtbViTriQh, "Chưa có địa chỉ");
                MessageBox.Show("Phải điền thông tin đầy đủ!");
                return;
            }
            else
            {
                errorProvider1.Clear();
            }
            try
            {
                string ma = txtMaQuayH.Text;
                string ten = txtTenQuayH.Text;
                string vitri= rtbViTriQh.Text;

                if (MessageBox.Show("Bạn có muốn thêm hay không", "Thêm", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    if (QuayHangController.Instance.InsertQuayHang(ma, ten, vitri))
                    {
                        MessageBox.Show("Thêm thành công");
                        ViewQuayHang();
                    }
                }
                else
                {
                    MessageBox.Show("Không thành công!");
                }
            }
            catch
            {
                MessageBox.Show("Lỗi dữ liệu");
                return;
            }
        }
#endregion
        private void btnUpdate_QH_Click(object sender, EventArgs e)
        {
            if (txtTenQuayH.Text == "" || rtbViTriQh.Text == "")
            {
                if (txtTenQuayH.Text == "")
                    errorProvider1.SetError(txtTenQuayH, "Chưa có tên quầy");
                if (rtbViTriQh.Text == "")
                    errorProvider1.SetError(rtbViTriQh, "Chưa có địa chỉ");
                MessageBox.Show("Phải điền thông tin đầy đủ!");
                return;
            }
            else
            {
                errorProvider1.Clear();
            }
            try
            {
                string ma = txtMaQuayH.Text;
                string ten = txtTenQuayH.Text;
                string vitri = rtbViTriQh.Text;

                if (MessageBox.Show("Bạn có muốn sửa hay không", "Sửa", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    if (QuayHangController.Instance.UpdateQuayHang(ma, ten, vitri))
                    {
                        MessageBox.Show("Sửa thành công");
                        ViewQuayHang();
                    }
                }
                else
                {
                    MessageBox.Show("Không thành công!");
                }
            }
            catch
            {
                MessageBox.Show("Lỗi dữ liệu");
                return;
            }
        }

        private void btnDelete_QH_Click(object sender, EventArgs e)
        {
            if (txtMaQuayH.Text == "")
            {
                errorProvider1.SetError(txtMaQuayH, "Chưa có mã cần xóa");
                MessageBox.Show("Phải nhập vào mã cần xóa");
                return;
            }
            else
            {
                errorProvider1.Clear();
            }
            try
            {
                string ma = txtMaQuayH.Text;
                if (MessageBox.Show("Bạn có muốn xóa hay không", "xóa", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    if (QuayHangController.Instance.DeleteQuayHang(ma))
                    {
                        MessageBox.Show("Sửa thành công");
                        ViewQuayHang();
                    }
                }
                else
                {
                    MessageBox.Show("Không thành công!");
                }
            }
            catch
            {
                MessageBox.Show("Lỗi dữ liệu");
                return;
            }
        }
#endregion

        private void btnExit_KQ_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSearch_KQ_Click(object sender, EventArgs e)
        {
            if(cbSearch.Text==@"Quầy hàng")
            {
                if (txtMaQuayH.Text == "" && txtTenQuayH.Text == "")
                {
                    if (txtMaQuayH.Text == "")
                        errorProvider1.SetError(txtMaQuayH, "Chưa nhập mã cần tìm");
                    if (txtTenQuayH.Text == "")
                        errorProvider1.SetError(txtTenQuayH, "Chưa nhập tên cần tìm");
                    MessageBox.Show("Phải nhập mã hoặc tên cần tìm");
                }
                else
                {
                    errorProvider1.Clear();
                }
                string ma = txtMaQuayH.Text;
                string ten = txtTenQuayH.Text;
                if (txtMaQuayH.Text != "" || txtTenQuayH.Text != "")
                {
                    dgvQuayHang.DataSource = QuayHangController.Instance.SearchQuayHang(ma, ten);
                }
            }
            else if(cbSearch.Text==@"Kho hàng")
            {
                if (txtMaKho.Text == "" && txtTenKho.Text == "")
                {
                    if (txtMaKho.Text == "")
                        errorProvider1.SetError(txtMaKho, "Chưa nhập mã cần tìm");
                    if (txtTenKho.Text == "")
                        errorProvider1.SetError(txtTenKho, "Chưa nhập tên cần tìm");
                    MessageBox.Show("Phải nhập vào mã hoặc tên cần tìm");
                    return;
                }
                else
                {
                    errorProvider1.Clear();
                }
                string ma = txtMaKho.Text;
                string ten = txtTenKho.Text;
                if (txtMaKho.Text != "" || txtTenKho.Text != "")
                {
                    dgvKhoHang.DataSource = KhoHangController.Instance.SearchKhoHang(ma, ten);
                }
            }
        }

        #endregion

        private void HangHoa_Load(object sender, EventArgs e)
        {

        }
    }
}
