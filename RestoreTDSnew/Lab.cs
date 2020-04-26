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
            ControlActivity.RadioSpik7_Active = false;
            ControlActivity.RadioSpik8_Active = false;
            SetAllSpikTextBoxesInactive();

        }

        public void SetLab2Activity()
        {
            ControlActivity.RadioSpik2_Active = true;
            ControlActivity.RadioSpik4_Active = true;
            ControlActivity.RadioSpik5_Active = true;
            ControlActivity.RadioSpik6_Active = false;
            ControlActivity.RadioSpik7_Active = false;
            ControlActivity.RadioSpik8_Active = false;
            SetAllSpikTextBoxesInactive();
        }

        public void SetLab3Activity()
        {
            ControlActivity.RadioSpik2_Active = true;
            ControlActivity.RadioSpik4_Active = true;
            ControlActivity.RadioSpik5_Active = true;
            ControlActivity.RadioSpik6_Active = true;
            ControlActivity.RadioSpik7_Active = true;
            ControlActivity.RadioSpik8_Active = true;
            SetAllSpikTextBoxesInactive();
        }

        public void SetSpik2Activity()
        {
            SetAllSpikTextBoxesInactive();
            ControlActivity.SetTextBoxActivity(2, true);
        }

        public void SetSpik4Activity()
        {
            SetAllSpikTextBoxesInactive();
            ControlActivity.SetTextBoxActivity(4, true);
        }
        public void SetSpik5Activity()
        {
            SetAllSpikTextBoxesInactive();
            ControlActivity.SetTextBoxActivity(5, true);
        }

        public void SetSpik6Activity()
        {
            SetAllSpikTextBoxesInactive();
            ControlActivity.SetTextBoxActivity(6, true);
        }

        public void SetSpik7Activity()
        {
            SetAllSpikTextBoxesInactive();
            ControlActivity.SetTextBoxActivity(7, true);
        }

        public void SetSpik8Activity()
        {
            SetAllSpikTextBoxesInactive();
            ControlActivity.SetTextBoxActivity(8, true);
        }

        private void SetAllSpikTextBoxesInactive()
        {
            ControlActivity.TextBoxSpik2_Active = false;
            ControlActivity.TextBoxSpik4_Active = false;
            ControlActivity.TextBoxSpik5_Active = false;
            ControlActivity.TextBoxSpik6_Active = false;
            ControlActivity.TextBoxSpik7_Active = false;
            ControlActivity.TextBoxSpik8_Active = false;
        }
    }
}

