using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using bai6quanlysieuthi.Bus;
using bai6quanlysieuthi.Models;
using System.Data;

namespace bai6quanlysieuthi.Controller
{
    class NhanVienController
    {
        public static NhanVienController instance;
        public static NhanVienController Instance
        {
            get
            {
                if (instance == null)
                    instance = new NhanVienController();
                return NhanVienController.instance;
            }
            private set { NhanVienController.instance = value; }
        }

        public NhanVienController() { }

        public List<nhanvien> XemNhanVien()
        {
            List<nhanvien> list = new List<nhanvien>();
            string query = "select ma,ten,ngaysinh,diachi,sodienthoai,machucvu,taikhoan,matkhau from nhanvien";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                nhanvien hd = new nhanvien(item);
                list.Add(hd);
            }
            return list;
        }

    }
}
