using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace WpfLeech
{
    class Winrar
    {
        private string _input;
        private string _output;
        private int _compress;
        private int _slip;
        private string _pass;
        private int _rr;

        public void Rar()
        {
            string strtxtPath = @"E:\test";
            string strzipPath = @"E:\test.rar";
            System.Diagnostics.Process Process1 = new System.Diagnostics.Process();
            Process1.StartInfo.FileName = "Winrar.exe";
            Process1.StartInfo.CreateNoWindow = true;
            Process1.StartInfo.Arguments = "a " + strzipPath + " " + strtxtPath;
            Process1.Start();
        }

        private string random()
        {
            string letter = "q0wert1yuio3pas2dfg4hjkl5zxcv6bnmQW7ERTY8UIOPAS9DFGHJKLZXCVBNM";
            char[] pass = new char[10];
            Random rd = new Random();
            for (int i = 0; i < 10; i++)
            {
                pass[i] = letter[rd.Next(letter.Length)];
            }
            return new string(pass);
        }

        private string getfolder(string path)
        {
            var folder = Directory.GetDirectories(path);
            string kq = folder[0];
            for (int i = 1; i < folder.Length; i++)
            {
                kq = kq + "\n" + folder[i];
            }
            return kq;
        }
    }
}
