using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestoreTDSnew
{
    public class ControlActivity
    {
        public bool RadioSpik2_Active { get; set; }
        public bool RadioSpik4_Active { get; set; }
        public bool RadioSpik5_Active { get; set; }
        public bool RadioSpik6_Active { get; set; }
        public bool RadioSpik7_Active { get; set; }
        public bool RadioSpik8_Active { get; set; }


        public ControlActivity()
        {
            RadioSpik2_Active = true;
            RadioSpik4_Active = true;
            RadioSpik5_Active = true;
            RadioSpik6_Active = false;
            RadioSpik7_Active = false;
            RadioSpik8_Active = false;
        }


        public void SetRadioButtonActivity(int spik, bool value)
        {
            switch (spik)
            {
                case 2:
                    RadioSpik2_Active = value;
                    break;
                case 4:
                    RadioSpik2_Active = value;
                    break;
                case 5:
                    RadioSpik2_Active = value;
                    break;
                case 6:
                    RadioSpik2_Active = value;
                    break;
                case 7:
                    RadioSpik2_Active = value;
                    break;
                case 8:
                    RadioSpik2_Active = value;
                    break;
                default:
                    throw new ArgumentException();
            }
        }

        
    }
}
