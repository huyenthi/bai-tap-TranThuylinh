using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BT2LTHDT
{
    public class Phim
    {
        private string diachi;
        private string rapchieu;
        private string tenphim;

        public string DiaChi
        {
            get

            { return diachi; }
            set
            {
                if (value != "")
                    diachi = value;
                else diachi = "";

            }


        }

        public string RapChieu
        {
            get

            { return rapchieu; }
            set
            {
                if (value != "")
                {
                    rapchieu = value;
                }
                else rapchieu = "";
            }
        }
        public string TenPhim
        {

            get { return tenphim; }
            set
            {
                if (value != "")
                {
                    tenphim = value;
                }
                else tenphim = "";
            }
        }
        public Phim(string diachi, string rapchieu, string tenphim)
        {
            this.diachi = diachi;
            this.rapchieu = rapchieu;
            this.tenphim = tenphim;
        }

    }
}

