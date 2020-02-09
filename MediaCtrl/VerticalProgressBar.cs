using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MediaCtrl
{
    //https://stackoverflow.com/questions/597411/how-do-i-make-a-winforms-progress-bar-move-vertically-in-c
    public class VerticalProgressBar:ProgressBar
    {
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.Style |= 0x04;
                return cp;
            }
        }
    }
}
