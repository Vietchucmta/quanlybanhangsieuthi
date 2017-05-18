using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bai6quanlysieuthi.Views
{
    public partial class HuongDan : Form
    {
        public HuongDan()
        {
            InitializeComponent();
            Gecko.Xpcom.Initialize(Application.StartupPath + "\\xulrunner");
            geckoWebBrowser1.Navigate(@"E:\3tailieu\thuctapnhom\quanlybanhangsieuthi\quanlybanhangsieuthi\HSD.html");
        }

       
       
    }
}
