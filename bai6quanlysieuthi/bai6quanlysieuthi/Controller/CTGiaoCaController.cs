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
        // thêm chi tiết phiếu giao ca
        public bool InsertCtGiaoCa(string magc,string mamh,int sl)
        {
            string query = string.Format("insert chitietphieugiaoca(magiaoca,mamathang,soluong) values(N'{0}',N'{1}',{2})", magc, mamh, sl);
            return DataProvider.Instance.ExecuteNonQuery(query) > 0;
        }
        // sửa chi tiết phiếu giao ca
        public bool UpdateCtGiaoCa(int stt,string magc, string mamh, int sl)
        {
            string query = string.Format("update chitietphieugiaoca set magiaoca=N'{0}',mamathang=N'{1}',soluong={2} where stt={3}", magc, mamh, sl, stt);
            return DataProvider.Instance.ExecuteNonQuery(query) > 0;
        }
        // xoas chi tiết phiếu giao ca
        public bool DeleteCtGiaoCa(int stt)
        {
            string query = string.Format("delete chitietphieugiaoca where stt={0}", stt);
            return DataProvider.Instance.ExecuteNonQuery(query) > 0;
        }
        // tìm kiếm chi tiết phiếu giao ca
        public List<chitietphieugiaoca> SearchCtGiaoCa(string magc,string mamh)
        {
            List<chitietphieugiaoca> list = new List<chitietphieugiaoca>();
            string query = string.Format("select * from chitietphieugiaoca ct where ct.magiaoca like N'%{0}%' and ct.mamathang like N'%{1}%'", magc, mamh);
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach(DataRow i in data.Rows)
            {
                chitietphieugiaoca ct = new chitietphieugiaoca(i);
                list.Add(ct);
            }
            return list;
        }
    }
}
