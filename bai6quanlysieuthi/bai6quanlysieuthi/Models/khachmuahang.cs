namespace bai6quanlysieuthi.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data;
    using System.Data.Entity.Spatial;

    [Table("khachmuahang")]
    public partial class khachmuahang
    {
        [Key]
        public int stt { get; set; }

        [StringLength(20)]
        public string makhachhang { get; set; }

        [StringLength(20)]
        public string mahoadon { get; set; }

        public khachmuahang(int st,string makh,string mahd)
        {
            this.stt = st;
            this.makhachhang = makh;
            this.mahoadon = mahd;

        }
        public khachmuahang(DataRow row)
        {
            this.stt = (int)Convert.ToDouble(row["stt"].ToString());
            this.makhachhang = row["makhachhang"].ToString();
            this.mahoadon = row["mahoadon"].ToString();

        }

    }
}
