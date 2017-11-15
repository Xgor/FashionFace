using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
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
using Windows.UI.Core;
using Tweetinvi.Events;


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
        string tweet = "test";

        public MainPage()
        {
            Auth.SetUserCredentials(CONSUMER_KEY, CONSUMER_SECRET, ACCESS_TOKEN, ACCESS_TOKEN_SECRET);

            var stream = Tweetinvi.Stream.CreateFilteredStream();

            
            stream.AddTrack("fashion");

            Console.WriteLine("I am listening to Twitter");

            this.InitializeComponent();


                 stream.MatchingTweetReceived += ChangeTextMethodAsync;





            
            
            stream.StartStreamMatchingAllConditionsAsync();


           

//            Task t = changeText("Test");
            
            
            
        }

        private async void ChangeTextMethodAsync(object sender, MatchedTweetReceivedEventArgs e)
        {
            tweet = "sgdfhj";
           await Windows.ApplicationModel.Core.CoreApplication.MainView.CoreWindow.Dispatcher.RunAsync(CoreDispatcherPriority.Normal,
            () =>
            {

                tweetText.Text = e.Tweet.Text;
                // Update UI 
            });
        }

        void test()
        {
            
        }

        private async Task<object> changeText(string text)
        {
            tweetText.Text = text;
            return Task.FromResult<object>(null);
        }



        private void testi_Click(object sender, RoutedEventArgs e)
        {
            tweetText.Text = "hello";
            //  var user = User.GetUserFromId(759251);
            //   testi.Content = user.Name;
            //       var user = User.GetAuthenticatedUser();


            //     testi.Content = user.Name;
        }
    }
}
