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
    public partial class ChiTiet_HD : Form
    {
        public ChiTiet_HD()
        {
            InitializeComponent();
        }
#region View chi tiết hóa đơn
        private void btnView_CTHD_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            ViewCtHoaDon();
        }
        void ViewCtHoaDon()
        {
            dgvCtHoaDon.DataSource = CtHoaDonController.Instance.XemCtHoaDon();
            dgvCtHoaDon.Columns["stt"].Width = 45;
            dgvCtHoaDon.Columns["mahoadon"].HeaderText = @"Mã hóa đơn";
            dgvCtHoaDon.Columns["mahoadon"].Width = 100;
            dgvCtHoaDon.Columns["mamathang"].HeaderText = @"Mã mặt hàng";
            dgvCtHoaDon.Columns["mamathang"].Width = 100;
            dgvCtHoaDon.Columns["soluong"].HeaderText = @"Số lượng";
            dgvCtHoaDon.Columns["soluong"].Width = 100;
            dgvCtHoaDon.Columns["dongia"].HeaderText = @"Đơn giá";
            dgvCtHoaDon.Columns["dongia"].Width = 100;
        }
#endregion
        private void btnInsert_CTHD_Click(object sender, EventArgs e)
        {

        }

        private void btnUpdate_CTHD_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_CTHD_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_CTHD_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSearch_CTHD_Click(object sender, EventArgs e)
        {

        }

        private void dgvCtHoaDon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtSTT.Text = dgvCtHoaDon.CurrentRow.Cells[0].Value.ToString();
            cbMaHoaDon.Text = dgvCtHoaDon.CurrentRow.Cells[1].Value.ToString();
            cbMaMatHang.Text = dgvCtHoaDon.CurrentRow.Cells[2].Value.ToString();
            txtSoLuong.Text = dgvCtHoaDon.CurrentRow.Cells[3].Value.ToString();
            txtDonGia.Text = dgvCtHoaDon.CurrentRow.Cells[4].Value.ToString();
        }
    }
}
