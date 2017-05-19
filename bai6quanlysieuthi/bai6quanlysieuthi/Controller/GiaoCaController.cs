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
    class GiaoCaController
    {
        public static GiaoCaController instance;
        public static GiaoCaController Instance
        {
            get
            {
                if (instance == null)
                    instance = new GiaoCaController();
                return GiaoCaController.instance;
            }
            private set { GiaoCaController.instance = value; }
        }

        public GiaoCaController() { }

        public List<phieugiaoca> XemGiaoCa()
        {
            List<phieugiaoca> list = new List<phieugiaoca>();
            string query = "select ma,ngay,ca,maquay,manhanvien from phieugiaoca";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                phieugiaoca hd = new phieugiaoca(item);
                list.Add(hd);
            }
            return list;
        }
    }
}
