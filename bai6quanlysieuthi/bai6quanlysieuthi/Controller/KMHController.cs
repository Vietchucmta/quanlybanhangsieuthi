
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using bai6quanlysieuthi.Models;
using bai6quanlysieuthi.Bus;
using System.Data;

namespace bai6quanlysieuthi.Controller
{
    class KMHController
    {
        private static KMHController instance;
        public static KMHController Instance
        {
            get
            {
                if (instance == null)
                    instance = new KMHController();
                return KMHController.instance;
            }
            private set
            {
                KMHController.instance = value;
            }
        }
        private KMHController() { }
        // xem khách mua hàng
        public List<khachmuahang> XemKhachMH()
        {
            List<khachmuahang> list = new List<khachmuahang>();
            string query = "select stt, makhachhang, mahoadon from khachmuahang";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                khachmuahang kmh = new khachmuahang(item);
                list.Add(kmh);
            }
            return list;
        }
    }
}
