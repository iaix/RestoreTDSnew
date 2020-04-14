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
                    //Form1.textBoxSpik2.Enabled = true;
                    break;
                case 4:
                    break;
                case 5:
                    break;
            }
        }


        public void SetSpik2Activity()
        {
            ControlActivity.TextBoxSpik2_Active = true;
            ControlActivity.TextBoxSpik4_Active = false;
            ControlActivity.TextBoxSpik5_Active = false;
        }

        public void SetSpik4Activity()
        {
            throw new NotImplementedException();
        }
    }
}

