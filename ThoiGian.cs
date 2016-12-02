using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BT2LTHDT
{
    public class ThoiGian : Phim
    {
        private string gia;
        private string nam;
        private string ngay;
        private string phut;
        private string thang;

        public string Gia
        {
            get

            { return gia; }
            set
            {
                if (value != "")
                    gia = value;
                else gia = "";
            }
        }


        public string Nam
        {

            get
            { return nam; }
            set
            {
                if (value != "")
                {
                    nam = value;
                }
                else nam = "";
            }
        }

        public string Ngay
        {

            get
            { return ngay; }
            set
            {
                if (value != "")
                {
                    ngay = value;
                }
                else ngay = "";
            }
        }

        public string Phut
        {
            get { return phut; }
            set
            {
                if (value != "")
                {
                    phut = value;
                }
                else phut = "";
            }
        }

        public string Thang
        {
            get { return thang; }
            set
            {
                if (value != "")
                {
                    thang = value;
                }
                else thang = "";
            }
        }

        public ThoiGian(string gia, string nam, string ngay, string phut, string thang)
            : base(diachi, rapchieu, tenphim)
        {
            this.gia = gia;
            this.nam = nam;
            this.ngay = ngay;
            this.phut = phut;
            this.thang = thang;
        }
    }
}

    
        

       
    



