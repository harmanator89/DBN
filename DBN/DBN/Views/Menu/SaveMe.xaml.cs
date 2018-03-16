using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Windows.Input;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DBN.Views.Menu
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SaveMe : ContentPage
    {
        public SaveMe()
        {
            InitializeComponent();

        }

        
    }

    public class NavigationSMHelp
    {

        string address = "684 Winder Hwy, Lawrenceville, GA 30620";

        public static void Go(string address)
        {
            Console.Write("Attempting to save User:");
            switch (Device.RuntimePlatform)
            {
                case Device.iOS:
                    Device.OpenUri(
                      new Uri(string.Format("http://maps.apple.com/?q={0}", WebUtility.UrlEncode(address))));
                    break;
                case Device.Android:
                    Device.OpenUri(
                      new Uri(string.Format("geo:0,0?q={0}", WebUtility.UrlEncode(address))));
                    break;
                case Device.WinPhone:
                    Device.OpenUri(
                      new Uri(string.Format("bingmaps:?where={0}", Uri.EscapeDataString(address))));
                    break;
            }


        }
    }
}