using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.IO;
using System.Windows.Forms;
using System.Net;

namespace WpfLeech
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        /*private void txbinput_doubleclick(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            FolderBrowserDialog fd = new FolderBrowserDialog();
            fd.ShowDialog();
            if (fd.SelectedPath != "")
            {
                txbInput.Text = fd.SelectedPath;
            }
        }

        /*private void btLeech_click(object sender, System.Windows.RoutedEventArgs e)
        {
            txbUrl.Text = "http://javblog.org/2013/09/26/sero-0204%e3%80%90%e4%ba%88%e7%b4%84%e3%80%91%e3%81%99%e3%81%90%e3%81%ab%e7%a0%b4%e3%82%8c%e3%82%8b%e3%82%b3%e3%83%b3%e3%83%89%e3%83%bc%e3%83%a0x%e5%af%ba%e5%b4%8e%e6%b3%89/";
            string url = txbUrl.Text;
            //WebClient wc = new WebClient();
            //wc.Proxy = new WebProxy("150.65.32.68:3128");
            WebProxy proxy = new WebProxy("150.65.32.68:3128");
            Html ht = new Html();
            rtbleech.AppendText(ht.code(url, proxy));            
        }*/
    }
}
