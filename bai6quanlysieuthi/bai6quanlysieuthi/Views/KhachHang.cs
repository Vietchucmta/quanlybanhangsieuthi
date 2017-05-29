﻿using System;
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
using bai6quanlysieuthi.Bus;
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
            if (txtMakh.Text == ""||txtTenkh.Text=="")
            {
                if(txtTenkh.Text=="")
                    errorProvider1.SetError(txtMakh, "Chua co ma khach hang");
                if (txtTenkh.Text == "")
                    errorProvider1.SetError(txtTenkh, "Chưa có tên khách hàng");
            }
            else
            {
                errorProvider1.Clear();
            }
            try
            {
                string ma = txtMakh.Text;
                string ten = txtTenkh.Text;
                string diachi = txtDiachi.Text;
                string sodienthoai = txtSodt.Text;
                float uudai = (float)Convert.ToDouble(txtUudai.Text);
                if (txtMakh.Text == "" || txtTenkh.Text == "")
                {
                    MessageBox.Show("Phải có mã, tên khách hàng");
                    return;
                }
                if (KhachhangController.Instance.InsertKhachHang(ma, ten, diachi, sodienthoai, uudai))
                {
                    if(MessageBox.Show("Bạn có muốn thêm hay không", "Thêm", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                    {
                        MessageBox.Show("Thêm thành công!");
                        ViewKhachHang();

                    }
                }
                else
                {
                    MessageBox.Show("Không thành công!");
                }
            }
            catch
            {
                MessageBox.Show("Lỗi thêm dữ liệu");
                return;
            }
        }
#endregion

#region sửa khách hàng
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtTenkh.Text == "")
            {
                errorProvider1.SetError(txtTenkh, "Chưa có dữ liệu");
            }
            else
            {
                errorProvider1.Clear();
            }
            try
            {

                string ma = txtMakh.Text;
                string ten = txtTenkh.Text;
                string diachi = txtDiachi.Text;
                string sodienthoai = txtSodt.Text;
                float uudai = (float)Convert.ToDouble(txtUudai.Text);
                if (KhachhangController.Instance.UpdateKhachHang(ma, ten, diachi, sodienthoai, uudai))
                {
                    if (MessageBox.Show("Bạn có muốn sửa hay không", "Sửa", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                    {
                        MessageBox.Show("Sửa thành công!");
                        ViewKhachHang();                        
                    }
                }
                else
                {
                    MessageBox.Show("Không thành công");
                }
            }
            catch
            {
                MessageBox.Show("Chưa có thông tin sửa!");
                return;

            }
        }
        #endregion

#region xóa khách hàng
        private void btnDeleteKh_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            string ma = txtMakh.Text;
            if (KhachhangController.Instance.DeleteKhachHang(ma))
            {
                if (MessageBox.Show("Bạn có muốn xóa hay không", "Xóa", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {

                    MessageBox.Show("Xóa thành công!");
                    ViewKhachHang();
                }
            }
            else
            {
                MessageBox.Show("Không thành công!");
            }
        }
        #endregion

#region tìm khách hàng
        private void btnSearchKh_Click(object sender, EventArgs e)
        {
            if(cmbSearchKh.Text==@"Mã khách hàng")
            {
                if (txtSearchKh.Text != "")
                {
                    dgvKh.DataSource = KhachhangController.Instance.SearchKh(txtSearchKh.Text);
                }
            }
            else if(cmbSearchKh.Text==@"Số điện thoại")
            {
                if (txtSearchKh.Text != "")
                {
                    dgvKh.DataSource = KhachhangController.Instance.SearchKh1(txtSearchKh.Text);
                }
            }
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
            ViewHoaDon();
        }
        // xem hóa đơn
        void ViewHoaDon()
        {
            dgvHoaDon.DataSource = HoaDonController.Instance.XemHoaDon();
            dgvHoaDon.Columns["ma"].HeaderText = @"Mã";
            dgvHoaDon.Columns["ma"].Width = 45;
            dgvHoaDon.Columns["makhachhang"].HeaderText = @"Mã khách hàng";
            dgvHoaDon.Columns["makhachhang"].Width = 80;
            dgvHoaDon.Columns["manhanvien"].HeaderText = @"Mã nhân viên";
            dgvHoaDon.Columns["manhanvien"].Width = 80;
            dgvHoaDon.Columns["ngaylap"].HeaderText = @"Ngày lập";
            dgvHoaDon.Columns["ngaylap"].Width = 90;
            dgvHoaDon.Columns["tonggiatri"].HeaderText = @"Tổng giá trị";
            dgvHoaDon.Columns["tonggiatri"].Width = 80;
            dgvHoaDon.Columns["thanhtien"].HeaderText = @"Thành tiền";
            dgvHoaDon.Columns["thanhtien"].Width = 80;
        }

        private void dgvHoaDon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaHD.Text = dgvHoaDon.CurrentRow.Cells[0].Value.ToString();
            dtpNgayLap.Text = dgvHoaDon.CurrentRow.Cells[1].Value.ToString();
            txtMaNhanVien.Text = dgvHoaDon.CurrentRow.Cells[4].Value.ToString();
            txtTongGiaTri.Text = dgvHoaDon.CurrentRow.Cells[2].Value.ToString();
            txtThanhTien.Text = dgvHoaDon.CurrentRow.Cells[3].Value.ToString();
            txtMaKhachHang.Text = dgvHoaDon.CurrentRow.Cells[4].Value.ToString();
        }
        #endregion

        #region Thêm hóa đơn
        private void btnInsertHD_Click(object sender, EventArgs e)
        {
            if (txtMaHD.Text == ""||txtMaNhanVien.Text==""||txtMaKhachHang.Text=="")
            {
                if (txtMaHD.Text == "")
                    errorProvider1.SetError(txtMaHD, "Chưa có dữ liệu");
                if (txtMaNhanVien.Text == "")
                    errorProvider1.SetError(txtMaNhanVien, "Chưa có dữ liệu");
                if (txtMaKhachHang.Text == "")
                    errorProvider1.SetError(txtMaKhachHang, "Chưa có dữ liệu");
            }
            else
            {
                errorProvider1.Clear();
            }
            try
            {
                string ma = txtMaHD.Text;
                string manv = txtMaNhanVien.Text;
                DateTime ngaylap = (DateTime)Convert.ToDateTime(dtpNgayLap.Value.ToString("MM/dd/yyyy"));
                string makh = txtMaKhachHang.Text;
                if (txtMaHD.Text == "" || txtMaNhanVien.Text == ""||txtMaKhachHang.Text=="")
                {
                    MessageBox.Show("Phải điền thông tin");
                    return;
                }
                if (HoaDonController.Instance.InsertHoaDon(ma,ngaylap,manv,makh))
                {
                    if (MessageBox.Show("Bạn có muốn thêm hay không", "Thêm", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                    {
                        ViewHoaDon();
                        ChiTiet_HD f = new ChiTiet_HD();
                        f.ShowDialog();
                        MessageBox.Show("Thêm thành công!");
                    }
                }
                else
                {
                    MessageBox.Show("Không thành công");
                }
            }
            catch
            {
                MessageBox.Show("Lỗi thêm dữ liệu");
                return;
            }
        }
        #endregion

#region Sửa hóa đơn
        private void btnUpdateHD_Click(object sender, EventArgs e)
        {
            if (txtMaHD.Text == "" || txtMaNhanVien.Text == "" || txtMaKhachHang.Text == "")
            {
                if (txtMaHD.Text == "")
                    errorProvider1.SetError(txtMaHD, "Chưa có dữ liệu");
                if (txtMaNhanVien.Text == "")
                    errorProvider1.SetError(txtMaNhanVien, "Chưa có dữ liệu");
                if (txtMaKhachHang.Text == "")
                    errorProvider1.SetError(txtMaKhachHang, "Chưa có dữ liệu");
            }
            else
            {
                errorProvider1.Clear();
            }
            try
            {
                string ma = txtMaHD.Text;
                string manv = txtMaNhanVien.Text;
                DateTime ngaylap = (DateTime)Convert.ToDateTime(dtpNgayLap.Value.ToString("MM/dd/yyyy"));
                string makh = txtMaKhachHang.Text;
                if (txtMaHD.Text == "" || txtMaNhanVien.Text == "" || txtMaKhachHang.Text == "")
                {
                    MessageBox.Show("Phải điền thông tin");
                    return;
                }
                if (HoaDonController.Instance.UpdateHoaDon(ma, ngaylap, manv, makh))
                {
                    if (MessageBox.Show("Bạn có muốn sửahay không", "Thêm", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                    {
                        MessageBox.Show("Sửa thành công!");
                        ViewHoaDon();
                    }
                }
                else
                {
                    MessageBox.Show("Không thành công");
                }
            }
            catch
            {
                MessageBox.Show("Lỗi thêm dữ liệu");
                return;
            }
        }
        #endregion

#region Xóa hóa đơn
        private void btnDeleteHD_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            string ma = txtMaHD.Text;
            if (HoaDonController.Instance.DeleteHoaDon(ma))
            {   
                if (MessageBox.Show("Bạn có muốn xóa hay không", "Xóa", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {

                    MessageBox.Show("Xóa thành công!");
                    ViewHoaDon();
                }
            }
            else
            {
                MessageBox.Show("Không thành công!");
            }
        }
        #endregion

        private void btnExitHD_Click(object sender, EventArgs e)
        {
            this.Close();
        }

#region Tìm kiếm hóa đơn
        private void btnSearchHD_Click(object sender, EventArgs e)
        {
            if(cbbSeachHD.Text== @"Mã hóa đơn")
            {
                if (txtSearchHD.Text != "")
                {
                    dgvHoaDon.DataSource = HoaDonController.Instance.SearchHd(txtSearchHD.Text);

                }
            }
            else if(cbbSeachHD.Text==@"Mã nhân viên")
            {
                if (txtSearchHD.Text != "")
                {
                    dgvHoaDon.DataSource = HoaDonController.Instance.SearchHd1(txtSearchHD.Text);
                }
            }
            else if(cbbSeachHD.Text==@"Mã khách hàng")
            {
                if (txtSearchHD.Text != "")
                {
                    dgvHoaDon.DataSource = HoaDonController.Instance.SearchHd2(txtSearchHD.Text);
                }
            }
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
