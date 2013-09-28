using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfLeech
{
    class mtn
    {
        private int _rows;
        private int _coloumns;
        private int _with;
        private int _gap;
        private string _title;
        private bool _infotext;
        private bool _timestamp;
        private enum _colors
        {
            _ffffff,
            _000000,
            _ff0000,
            _8b0000,
            _008000,
            _006400,
            _0000ff,
            _00008b,
            _00ffff,
            _008b8b,
            _ff00ff,
            _8b008b,
            _ffff00,
            _808080,
            _a9a9a9,
            _d3d3d3,
        }
        private enum _localtion
        {
            Lower_Left = 1,
            Lower_Right = 2,
            Upper_Right = 3,
            Upper_Left = 4,
        }

        /*private string RGB(string Colors) 
        {
            Dictionary<string, string> _colors = new Dictionary<string, string>();
            _colors.Add("White", "ffffff");
            _colors.Add("Black", "000000");
            _colors.Add("Red", "ff0000");
            _colors.Add("DarkRed", "8b0000");
            _colors.Add("Green", "008000");
            _colors.Add("DarkGreen", "006400");
            _colors.Add("Blue", "0000ff");
            _colors.Add("DarkBlue", "00008b");
            _colors.Add("Cyan", "00ffff");
            _colors.Add("DarkCyan", "008b8b");
            _colors.Add("Magenta", "ff00ff");
            _colors.Add("DarkMagenta", "8b008b");
            _colors.Add("Yellow", "ffff00");
            _colors.Add("Gray", "808080");
            _colors.Add("DarkGray", "a9a9a9");
            _colors.Add("LightGray", "d3d3d3");
            return _colors[Colors];
        }

        /*private void mtn(int Rows,int Coloumns,int Withs,int Wap,string Title,string Location,string Colors)
        {

        }*/
        

        public void epx1()
        {
            string agu = @"E:\viettorent\Journey.2.The.Mysterious.Island.2012.720p.Bluray.DD5.1.x264-DON";
            System.Diagnostics.Process Process1 = new System.Diagnostics.Process();
            Process1.StartInfo.FileName = @"C:\Users\quang\Desktop\mtn-200808a-win32\mtn.exe";
            Process1.StartInfo.CreateNoWindow = true;
            Process1.StartInfo.UseShellExecute = false;
            Process1.StartInfo.RedirectStandardOutput = false;
            Process1.StartInfo.Arguments = "-P -c 4 -r 4 -h 100 -j 90 -T texttest -O \"C:\\Users\\quang\\Desktop\\Thumbnail me 3.0\" \"" + agu + "\"";
            Process1.Start();
        }
    }
}
