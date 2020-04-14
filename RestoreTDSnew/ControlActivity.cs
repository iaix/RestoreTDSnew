using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestoreTDSnew
{
    public class ControlActivity
    {
        public bool TextBoxSpik2_Active { get; set; }
        public bool TextBoxSpik4_Active { get; set; }
        public bool TextBoxSpik5_Active { get; set; }
        public bool TextBoxSpik6_Active { get; set; }
        public bool TextBoxSpik7_Active { get; set; }
        public bool TextBoxSpik8_Active { get; set; }
        public bool RadioSpik2_Active { get; set; }
        public bool RadioSpik4_Active { get; set; }
        public bool RadioSpik5_Active { get; set; }
        public bool RadioSpik6_Active { get; set; }
        public bool RadioSpik7_Active { get; set; }
        public bool RadioSpik8_Active { get; set; }


        public ControlActivity()
        {
            TextBoxSpik2_Active = false;
            TextBoxSpik4_Active = false;
            TextBoxSpik5_Active = false;
            TextBoxSpik6_Active = false;
            TextBoxSpik7_Active = false;
            TextBoxSpik8_Active = false;
            RadioSpik2_Active = true;
            RadioSpik4_Active = true;
            RadioSpik5_Active = true;
            RadioSpik6_Active = false;
            RadioSpik7_Active = false;
            RadioSpik8_Active = false;

        }
    }
}
