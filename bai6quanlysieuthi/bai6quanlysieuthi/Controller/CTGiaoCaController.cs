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
    class CTGiaoCaController
    {
        public static CTGiaoCaController instance;
        public static CTGiaoCaController Instance
        {
            get
            {
                if (instance == null)
                    instance = new CTGiaoCaController();
                return CTGiaoCaController.instance;
            }
            private set { CTGiaoCaController.instance = value; }
        }

        public CTGiaoCaController() { }

        public List<chitietphieugiaoca> XemCtGiaoCa()
        {
            List<chitietphieugiaoca> list = new List<chitietphieugiaoca>();
            string query = "select stt, magiaoca,mamathang,soluong from chitietphieugiaoca";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                chitietphieugiaoca hd = new chitietphieugiaoca(item);
                list.Add(hd);
            }
            return list;
        }
    }
}
