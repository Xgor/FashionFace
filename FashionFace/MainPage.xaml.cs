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

using Tweetinvi;



// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace FashionFace
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    
    public sealed partial class MainPage : Page
    {
        const string CONSUMER_KEY = "WViyNST4uGb1cxtoUNm6kIreD";
        const string CONSUMER_SECRET = "wE1vANcHrhASvUTm7jOC0ItXgAnELNvK2OC5vi9MXWj5Rl0HUe";
        const string ACCESS_TOKEN = "1077212670-MwVEf6ryJSmqVjhW1q25UYck9j176k9qhQSV2GO";
        const string ACCESS_TOKEN_SECRET = "9tcQ39YWNo9Fnmt55yJvFhGupxfZg54tBla8Lin5JtAmk";

        public MainPage()
        {

            this.InitializeComponent();

            // Set up your credentials (https://apps.twitter.com)

            
      //      Console.WriteLine(user);
        //    Console.ReadKey();
            // Publish the Tweet "Hello World" on your Timeline

    //        
        }

        private void testi_Click(object sender, RoutedEventArgs e)
        {
            Auth.SetUserCredentials(CONSUMER_KEY, CONSUMER_SECRET, ACCESS_TOKEN, ACCESS_TOKEN_SECRET);
            var user = User.GetAuthenticatedUser();
            testi.Content = user.Name;
        }
    }
}
