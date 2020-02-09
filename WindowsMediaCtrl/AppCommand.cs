using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsMediaCtrl
{
    /// <summary>
    /// AppCommands used by Windows API SendMessage in user32.dll 
    /// https://docs.microsoft.com/en-us/windows/win32/inputdev/wm-appcommand
    /// </summary>
    public static class AppCommand
    {
        public static int BrowserBack { get; } = 1;
        public static int BrowserForward { get; } = 2;
        public static int BrowserRefresh { get; } = 3;
        public static int BrowserStop { get; } = 4;
        public static int BrowserSearch { get; } = 5;
        public static int BrowserFavorite { get; } = 6;
        public static int BrowserHome { get; } = 7;
        public static int VolumeMute { get; } = 8;
        public static int VolumeDown { get; } = 9;
        public static int VolumeUp { get; } = 10;
        public static int MediaNext { get; } = 11;
        public static int MediaPrevious { get; } = 12;
        public static int MediaStop { get; } = 13;
        public static int MediaPlayPause { get; } = 14;
        public static int LaunchMail { get; } = 15;
        public static int LaunchMediaSelect { get; } = 16;
        public static int LaunchApp1 { get; } = 17;
        public static int LaunchApp2 { get; } = 18;
        public static int BassDown { get; } = 19;
        public static int BassBoost { get; } = 20;
        public static int BassUp { get; } = 21;
        public static int TrebleUp { get; } = 22;
        public static int TrebleDown { get; } = 23;
        public static int MicrophoneMute { get; } = 24;
        public static int MicrophoneVolumeUp { get; } = 25;
        public static int MicrophoneVolumeDown { get; } = 26;
        public static int Help { get; } = 27;
        public static int Find { get; } = 28;
        public static int New { get; } = 29;
        public static int Open { get; } = 30;
        public static int Close { get; } = 31;
        public static int Save { get; } = 32;
        public static int Print { get; } = 33;
        public static int Undo { get; } = 34;
        public static int Redo { get; } = 35;
        public static int Copy { get; } = 36;
        public static int Cut { get; } = 37;
        public static int Paste { get; } = 38;
        public static int ReplyToMail { get; } = 39;
        public static int ForwardMail { get; } = 40;
        public static int SendMail { get; } = 41;
        public static int SpellCheck { get; } = 42;
        public static int Dictate { get; } = 43;
        public static int MicrophoneOnOff { get; } = 44;
        public static int CorrectionList { get; } = 45;
        public static int MediaPlay { get; } = 46;
        public static int MediaPause { get; } = 47;
        public static int MediaRecord { get; } = 48;
        public static int MediaFastForward { get; } = 49;
        public static int MediaRewind { get; } = 50;
        public static int MediaChannelUp { get; } = 51;
        public static int MediaChannelDown { get; } = 52;
        public static int Delete { get; } = 53;
        public static int Flip3D { get; } = 54;    
    }
}
