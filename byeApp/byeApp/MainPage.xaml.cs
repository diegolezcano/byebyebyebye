using MediaManager;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace byeApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void playVideo(object sender, EventArgs e)
        {
            CrossMediaManager.Current.Play("file:///android_asset/main.mp4");
        }
    }
}
