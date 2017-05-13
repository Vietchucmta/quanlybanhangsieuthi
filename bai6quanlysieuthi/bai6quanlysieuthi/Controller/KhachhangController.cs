using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using bai6quanlysieuthi.Models;
using System.Data;
using bai6quanlysieuthi.Bus;
namespace bai6quanlysieuthi.Controller
{
    class KhachhangController
    {
        private static KhachhangController instance;
        public static KhachhangController Instance
        {
            get
            {
                if (instance == null)
                    instance = new KhachhangController();
                return KhachhangController.instance;
            }
            private set
            {
                KhachhangController.instance = value;
            }
        }
        private KhachhangController() { }
        // xem khach hang
        public List<khachhang> XemKhachHang()
        {
            List<khachhang> list = new List<khachhang>();
            string query = "select ma,ten,diachi,sodienthoai,uudai from khachhang";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach(DataRow item in data.Rows)
            {
                khachhang kh = new khachhang(item);
                list.Add(kh);
            }
            return list;
        }
        // them khach hang

    }
}
