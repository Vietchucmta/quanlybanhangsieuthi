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
    public partial class ChiTiet_XuatKho : Form
    {
        public ChiTiet_XuatKho()
        {
            InitializeComponent();
        }
#region View chi tiết xuất kho
        private void btnView_CTXK_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            ViewCtXuatKho();
        }
        void ViewCtXuatKho()
        {
            dgvCtXuatKho.DataSource = CtXuatKhoController.Instance.XemCtXuatKho();
            dgvCtXuatKho.Columns["stt"].Width = 45;
            dgvCtXuatKho.Columns["maxuat"].HeaderText = @"Mã xuất";
            dgvCtXuatKho.Columns["maxuat"].Width = 80;
            dgvCtXuatKho.Columns["mamathang"].HeaderText = @"Mã mặt hàng";
            dgvCtXuatKho.Columns["mamathang"].Width = 80;
            dgvCtXuatKho.Columns["soluong"].HeaderText = @"Số lượng";
            dgvCtXuatKho.Columns["soluong"].Width = 80;
            dgvCtXuatKho.Columns["dongia"].HeaderText = @"Đơng giá";
            dgvCtXuatKho.Columns["dongia"].Width = 80;
        }
#endregion 
        private void btnInsert_CTXK_Click(object sender, EventArgs e)
        {

        }

        private void btnUpdate_CTXK_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_CTXK_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_CTXK_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSearch_CTXK_Click(object sender, EventArgs e)
        {

        }

        private void dgvCtXuatKho_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtSTT.Text = dgvCtXuatKho.CurrentRow.Cells[0].Value.ToString();
            cbMaXuat.Text = dgvCtXuatKho.CurrentRow.Cells[1].Value.ToString();
            cbMaMatHang.Text = dgvCtXuatKho.CurrentRow.Cells[2].Value.ToString();
            txtSoLuong.Text = dgvCtXuatKho.CurrentRow.Cells[3].Value.ToString();
            txtDonGia.Text = dgvCtXuatKho.CurrentRow.Cells[4].Value.ToString();
        }
    }
}
