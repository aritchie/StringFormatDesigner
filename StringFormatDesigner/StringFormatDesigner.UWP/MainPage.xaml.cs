using System;


namespace StringFormatDesigner.UWP
{
    public sealed partial class MainPage
    {
        public MainPage()
        {
            this.InitializeComponent();
            this.LoadApplication(new StringFormatDesigner.App());
        }
    }
}
