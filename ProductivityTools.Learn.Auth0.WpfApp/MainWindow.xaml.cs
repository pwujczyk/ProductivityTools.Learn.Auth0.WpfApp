using Auth0.OidcClient;
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

namespace ProductivityTools.Learn.Auth0.WpfApp
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

        private Auth0Client client;

        private async void Button_Click(object sender, RoutedEventArgs e)
        {
            string domain = "productivitytools-meeting-dev.eu.auth0.com";
            string clientId = "0ygl3UMljGseor6wYLAHlDPWSaoSB6gv";

            client = new Auth0Client(new Auth0ClientOptions
            {
                Domain = domain,
                ClientId = clientId
            });

            var extraParameters = new Dictionary<string, string>();

            extraParameters.Add("connection", "google-oauth2");
            await client.LoginAsync(extraParameters: extraParameters);
        }
    }
}
