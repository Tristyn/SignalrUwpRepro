using Microsoft.AspNetCore.SignalR.Client;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
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

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace App1
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();

            Init();

            Debug.Assert(true);
        }

        private async void Init()
        {
            Console.WriteLine("Test");
            Console.WriteLine("Test");
            Console.WriteLine("Test");
            await Task.Delay(4000);
            // Wait for server to listen

            var hub = new HubConnectionBuilder()
                .WithUrl("http://localhost:5000/api/v1/myhub")
                .ConfigureLogging(logging =>
                {
                    logging.AddDebug();
                    // Choose one of the below:

                    // This will set ALL logging to Debug level
                    logging.SetMinimumLevel(LogLevel.Debug);

        // Alternatively, you can set the default verbosity to something less noisy and
        // only turn up the SignalR loggers
                    //logging.SetMinimumLevel(LogLevel.Information);
                    //logging.AddFilter("Microsoft.AspNetCore.SignalR", LogLevel.Debug);
                    //logging.AddFilter("Microsoft.AspNetCore.Http.Connections", LogLevel.Debug);
                })
                .Build();

            await hub.StartAsync();
        }
    }
}
