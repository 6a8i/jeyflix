using jeyflix.Commons;
using jeyflix.Services;
using jeyflix.Services.Implentations;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Threading.Tasks;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

namespace jeyflix.Logins
{
    public sealed partial class Server : Page
    {
        private readonly ISystemService _systemService;
        public Server()
        {
            this.InitializeComponent();
            _systemService = new SystemService();
        }

        private async void srv_enter_btn_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(srv_serverhost_tbox.Text))
            {
                srv_error_txt.Text = "Ip or host must be informed.";
                return;
            }
            var splitList = srv_serverhost_tbox.Text.Split(':');
            if (splitList.Length > 1)
            {
                HttpClientCommon.SetBaseUrl(splitList[0], splitList[1]);
            }
            else
            { 
                HttpClientCommon.SetBaseUrl(splitList[0], string.Empty);
            }
            var serverInfo = await _systemService.GetServerPublicInformationAsync();

            Frame rootFrame = Window.Current.Content as Frame;
            if (rootFrame != null)
            { 
                rootFrame.Navigate(typeof(Login));
            }

            srv_error_txt.Text = serverInfo.ServerName;
        }
    }
}
