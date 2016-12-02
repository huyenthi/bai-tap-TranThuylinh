using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BT2LTHDT
{
    public class Vé : Phim
    {
        private string giave;
        private string mave;

        public string Giave
        {


            get
            { return giave; }
            set
            {
                if (value != "")
                {
                    giave = value;
                }
                else giave = "";
            }

        }

        public string Mave
        {
            get { return mave; }
            set
            {
                if (value != "")
                {
                    mave = value;
                }
                else mave = "";
            }
        }


        public Vé(string giave, string mave)
            : base(diachi, rapchieu, tenphim)
        {
            Giave = giave;
            Mave = mave;
        }
    }

}