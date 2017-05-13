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
    class KhoHangController
    {
        private static KhoHangController instance;
        public static KhoHangController Instance
        {
            get
            {
                if (instance == null)
                    instance = new KhoHangController();
                return KhoHangController.instance;
            }
            private set { KhoHangController.instance = value; }
        }
        public KhoHangController() { }

        public List<khohang> XemKhoHang()
        {
            List<khohang> list = new List<khohang>();
            string query = "select ma, ten, diachi from khohang";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                khohang kh = new khohang(item);
                list.Add(kh);
            }
            return list;
        }

    }
}
