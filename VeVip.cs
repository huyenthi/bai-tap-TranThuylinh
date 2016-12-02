using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BT2LTHDT
{
    public class VeVip : Vé
    {
        private string ve;

        public string Ve
        {

            get { return ve; }
            set
            {
                if (value != "")
                {
                    ve = value;
                }
                else ve = "";
            }
        }


        public VeVip(string ve)
            : base(giave, mave)
        {
            Ve = ve;

        }
    }

}