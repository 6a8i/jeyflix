using jeyflix.Services;
using jeyflix.Services.Implentations;
using Windows.UI.Xaml.Controls;

namespace jeyflix.Pages
{
    public sealed partial class Home : Page
    {
        private readonly ISystemService _systemService;

        public Home()
        {
            this.InitializeComponent();
            _systemService = new SystemService();
        }

    }
}
