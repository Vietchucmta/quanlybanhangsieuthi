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
    class QuayHangController
    {
        private static QuayHangController instance;
        public static QuayHangController Instance
        {
            get
            {
                if (instance == null)
                    instance = new QuayHangController();
                return QuayHangController.instance;
            }
            private set { QuayHangController.instance = value; }
        }

        private QuayHangController() { }

        public List<quayhang> XemQuayHang()
        {
            List<quayhang> list = new List<quayhang>();
            string query = "select ma,ten,vitri from quayhang";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                quayhang qh = new quayhang(item);
                list.Add(qh);
            }
            return list;
        }
    }
}
