using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace forms3._1
{
    public partial class FormsPage : ContentPage
    {

        public static string ToNative = "to_native";

        void Handle_Clicked(object sender, System.EventArgs e)
        {
            MessagingCenter.Send(this, ToNative, "FormsPage To Native");
        }

        public FormsPage()
        {
            InitializeComponent();
        }
    }
}
