using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

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
        private string _colors;
        private int _location;

        public int Location
        {
            set
            {
                swith (value)
                {
                    case "Lower Left": this._location = 1; break;
                    case "Lower Right": this._location = 2; break;
                    case "Upper Right": this._location = 3; break;
                    case "Upper Left": this._location = 4;
                    default: this._location = null;
                }
            }
        }

        public string Colors
        {
            set
            {
                swith (value)
                {
                    case 0: this._colors = "ffffff"; break;
                    case 1: this._colors = "000000"; break;
                    case 2: this._colors = "ff0000"; break;
                    case 3: this._colors = "8b0000"; break;
                    case 4: this._colors = "008000"; break;
                    case 5: this._colors = "006400"; break;
                    case 6: this._colors = "0000ff"; break;
                    case 7: this._colors = "00008b"; break;
                    case 8: this._colors = "00ffff"; break;
                    case 9: this._colors = "008b8b"; break;
                    case 10: this._colors = "ff00ff"; break;
                    case 11: this._colors = "8b008b"; break;
                    case 12: this._colors = "ffff00"; break;
                    case 13: this._colors = "808080"; break;
                    case 14: this._colors = "a9a9a9"; break;
                    case 15: this._colors = "d3d3d3"; break;
                    default: this._colors = null;
                }
            }
        }

        /*private void mtn(int Rows,int Coloumns,int Withs,int Wap,string Title,string Location,string Colors)
        {

        }*/


        private void start(string argu)
        {
            string file = Application.StartUpPath + @"Data/mtn/mtn.exe";
            System.Diagnostics.Process pro1 = new System.Diagnostics.Process();
            pro1.StartInfo.FileName = file;
            pro1.StartInfo.CreateNoWindow = true;
            pro1.StartInfo.UseShellExecute = false;
            pro1.StartInfo.RedirectStandardOutput = false;
            pro1.StartInfo.Arguments = argu;
            pro1.Start();
            pro1.Close();
        }


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
