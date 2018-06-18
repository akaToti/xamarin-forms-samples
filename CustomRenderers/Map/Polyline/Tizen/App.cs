﻿
namespace MapOverlay.Tizen
{
    class Program : global::Xamarin.Forms.Platform.Tizen.FormsApplication
    {
        protected override void OnCreate()
        {
            base.OnCreate();
            LoadApplication(new App());
        }

        static void Main(string[] args)
        {
            var app = new Program();
            global::Xamarin.Forms.Platform.Tizen.Forms.Init(app);
            global::Xamarin.FormsMaps.Init("HERE", "Please enter your HERE map key");
            app.Run(args);
        }
    }
}