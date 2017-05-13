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
    class XuatKhoController
    {
        private static XuatKhoController instance;
        public static XuatKhoController Instance
        {
            get
            {
                if (instance == null)
                    instance = new XuatKhoController();
                return XuatKhoController.instance;
            }
            private set { XuatKhoController.instance = value; }
        }

        private XuatKhoController() { }

        public List<phieuxuatkho> XemXuatKho()
        {
            List<phieuxuatkho> list = new List<phieuxuatkho>();
            string query = "select ma,makhohang,ngayxuat,tonggiatri,maquay,manhanvien from phieuxuatkho ";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                phieuxuatkho xk = new phieuxuatkho(item);
                list.Add(xk);
            }
            return list;
        }
    }
}
