using jeyflix.Services.Implentations;
using jeyflix.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Controls;

namespace jeyflix.Logins
{
    public sealed partial class Login : Page
    {
        private readonly ISystemService _systemService;
        public Login()
        {
            this.InitializeComponent();
            _systemService = new SystemService();
        }

        private void lgn_changeserver_btn_Click(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {

        }

        private void lgn_enter_btn_Click(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {

        }
    }
}
