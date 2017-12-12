using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace Arvestus_Lauri_Mäe
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {

        int tries = 0;
        string username = "user";
        string password = "SecretPassword"; //not anymore

        public MainPage()
        {
            this.InitializeComponent();
        }

        private void signInBtn_Click(object sender, RoutedEventArgs e)
        {
            string inputUsername = usernameBox.Text;
            string inputPassword = passwordBox.Password;


            if (tries >= 3)
            {
                errorLabel.Text = "Sisselogimine ebaõnnestus. Rohkem katseid sisenemiseks ei ole!";
            } else
            {
                if (inputUsername != username && inputPassword != password)
                {
                    tries++;
                    errorLabel.Text = "Vale kasutajanimi või parool!";
                } else
                {
                    this.Frame.Navigate(typeof(Content));
                }
            }
        }
    }
}
