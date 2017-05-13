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
    class HoaDonController
    {
        private static  HoaDonController instance;
        public static HoaDonController Instance
        {
            get
            {
                if (instance == null)
                    instance = new HoaDonController();
                return HoaDonController.instance;
            }
            private set { HoaDonController.instance = value; }
        }

        private HoaDonController() { }

        public List<hoadon> XemHoaDon()
        {
            List<hoadon> list = new List<hoadon>();
            string query = "select ma,manhanvien,ngaylap,tonggiatri,thanhtien from hoadon";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach(DataRow item in data.Rows)
            {
                hoadon hd = new hoadon(item);
                list.Add(hd);
            }
            return list;
        }
    }
}
