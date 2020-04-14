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

        public ControlActivity()
        {
            TextBoxSpik2_Active = false;
            TextBoxSpik4_Active = false;
            TextBoxSpik5_Active = false;
        }
    }
}
