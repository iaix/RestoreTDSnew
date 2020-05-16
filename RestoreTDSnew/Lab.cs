using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestoreTDSnew
{
    public class Lab
    {
        public ControlActivity ControlActivity { get; set; } = new ControlActivity();
        public int WhichLab { get; set; }
        public int WhichServer { get; set; }
        public string WhichDatabase { get; set; }


        public void SetLab1Activity()
        {
            ControlActivity.RadioSpik2_Active = true;
            ControlActivity.RadioSpik4_Active = true;
            ControlActivity.RadioSpik5_Active = true;
            ControlActivity.RadioSpik6_Active = false;
            ControlActivity.RadioSpik7_Active = false;
            ControlActivity.RadioSpik8_Active = false;

        }

        public void SetLab2Activity()
        {
            ControlActivity.RadioSpik2_Active = true;
            ControlActivity.RadioSpik4_Active = true;
            ControlActivity.RadioSpik5_Active = true;
            ControlActivity.RadioSpik6_Active = false;
            ControlActivity.RadioSpik7_Active = false;
            ControlActivity.RadioSpik8_Active = false;
        }

        public void SetLab3Activity()
        {
            ControlActivity.RadioSpik2_Active = true;
            ControlActivity.RadioSpik4_Active = true;
            ControlActivity.RadioSpik5_Active = true;
            ControlActivity.RadioSpik6_Active = true;
            ControlActivity.RadioSpik7_Active = true;
            ControlActivity.RadioSpik8_Active = true;
        }


    }
}

