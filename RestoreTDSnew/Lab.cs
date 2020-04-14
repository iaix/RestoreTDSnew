using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestoreTDSnew
{
    public class Lab
    {
        public ControlActivity ControlActivity { get; set; } = new ControlActivity();
        public int WhichLab { get; set; }
        public int WhichServer { get; set; }

        public void pickLab()
        {
            switch(WhichLab)
            {
                case 1:
                    break;
                case 2:
                    break;
                case 3:
                    break;
            }     
        }

        public void pickServer()
        {
            switch (WhichServer)
            {
                case 2:
                    break;
                case 4:
                    break;
                case 5:
                    break;
            }
        }


        public void SetLab1Activity()
        {
            ControlActivity.RadioSpik2_Active = true;
            ControlActivity.RadioSpik4_Active = true;
            ControlActivity.RadioSpik5_Active = true;
            ControlActivity.RadioSpik6_Active = false;
            ControlActivity.TextBoxSpik6_Active = false;
            ControlActivity.RadioSpik7_Active = false;
            ControlActivity.TextBoxSpik7_Active = false;
            ControlActivity.RadioSpik8_Active = false;
            ControlActivity.TextBoxSpik8_Active = false;

        }

        public void SetLab2Activity()
        {
            ControlActivity.RadioSpik2_Active = true;
            ControlActivity.RadioSpik4_Active = true;
            ControlActivity.RadioSpik5_Active = true;
            ControlActivity.RadioSpik6_Active = false;
            ControlActivity.TextBoxSpik6_Active = false;
            ControlActivity.RadioSpik7_Active = false;
            ControlActivity.TextBoxSpik7_Active = false;
            ControlActivity.RadioSpik8_Active = false;
            ControlActivity.TextBoxSpik8_Active = false;

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

        public void SetSpik2Activity()
        {
            ControlActivity.TextBoxSpik2_Active = true;
            ControlActivity.TextBoxSpik4_Active = false;
            ControlActivity.TextBoxSpik5_Active = false;
            ControlActivity.TextBoxSpik6_Active = false;
            ControlActivity.TextBoxSpik7_Active = false;
            ControlActivity.TextBoxSpik8_Active = false;
        }

        public void SetSpik4Activity()
        {
            ControlActivity.TextBoxSpik2_Active = false;
            ControlActivity.TextBoxSpik4_Active = true;
            ControlActivity.TextBoxSpik5_Active = false;
            ControlActivity.TextBoxSpik6_Active = false;
            ControlActivity.TextBoxSpik7_Active = false;
            ControlActivity.TextBoxSpik8_Active = false;
        }
        public void SetSpik5Activity()
        {
            ControlActivity.TextBoxSpik2_Active = false;
            ControlActivity.TextBoxSpik4_Active = false;
            ControlActivity.TextBoxSpik5_Active = true;
            ControlActivity.TextBoxSpik6_Active = false;
            ControlActivity.TextBoxSpik7_Active = false;
            ControlActivity.TextBoxSpik8_Active = false;
        }

        public void SetSpik6Activity()
        {
            ControlActivity.TextBoxSpik2_Active = false;
            ControlActivity.TextBoxSpik4_Active = false;
            ControlActivity.TextBoxSpik5_Active = false;
            ControlActivity.TextBoxSpik6_Active = true;
            ControlActivity.TextBoxSpik7_Active = false;
            ControlActivity.TextBoxSpik8_Active = false;
        }

        public void SetSpik7Activity()
        {
            ControlActivity.TextBoxSpik2_Active = false;
            ControlActivity.TextBoxSpik4_Active = false;
            ControlActivity.TextBoxSpik5_Active = false;
            ControlActivity.TextBoxSpik6_Active = false;
            ControlActivity.TextBoxSpik7_Active = true;
            ControlActivity.TextBoxSpik8_Active = false;
        }

        public void SetSpik8Activity()
        {
            ControlActivity.TextBoxSpik2_Active = false;
            ControlActivity.TextBoxSpik4_Active = false;
            ControlActivity.TextBoxSpik5_Active = false;
            ControlActivity.TextBoxSpik6_Active = false;
            ControlActivity.TextBoxSpik7_Active = false;
            ControlActivity.TextBoxSpik8_Active = true;
        }
    }
}

