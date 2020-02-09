using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace WindowsMediaCtrl
{
    /// <summary>
    /// Wrapper for utilizing the user32.dll SendMessage function to control media playing 
    /// applications and system volume.
    /// 
    /// Inspired by https://www.dotnetcurry.com/ShowArticle.aspx?ID=431
    /// </summary>
    public class WindowsAppCommand
    {
        readonly IntPtr handle;
        private const int WM_APPCOMMAND = 0x319;

        public WindowsAppCommand(IntPtr handle)
        {
            this.handle = handle;
        }

        //https://docs.microsoft.com/sv-se/windows/win32/api/winuser/nf-winuser-sendmessage
        [DllImport("user32.dll")]
        public static extern IntPtr SendMessageW(IntPtr hWnd, int Msg,
            IntPtr wParam, IntPtr lParam);

        private void SendMessage(int appCommand)
        {
            IntPtr cmd = (IntPtr)(appCommand << 16);
            SendMessageW(handle, WM_APPCOMMAND, handle, cmd);
        }


        public void Mute()
        {
            SendMessage(AppCommand.VolumeMute);
        }

        public void VolDown()
        {
            SendMessage(AppCommand.VolumeDown);
        }

        public void PlayPause()
        {
            SendMessage(AppCommand.MediaPlayPause);
        }

        public void VolUp()
        {
            SendMessage(AppCommand.VolumeUp);
        }

        public void PreviousTrack()
        {
            SendMessage(AppCommand.MediaPrevious);        
        }

        public void NextTrack()
        {
            SendMessage(AppCommand.MediaNext);
        }
    }
}
