using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using DBN.Views.Menu;

namespace DBN.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainTabs : TabbedPage
    {
        public MainTabs ()
        {
            InitializeComponent();

            Children.Add(new Dashboard());
            Children.Add(new SaveMe());
            Children.Add(new About());
            Children.Add(new SettingsPage());
        }
    }
}