﻿using System;
using Acr.Notifications;
using Android.App;
using Android.Content.PM;
using Android.OS;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;


namespace Samples.Droid {

    [Activity(Label = "Samples", Icon = "@drawable/icon", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : FormsApplicationActivity {
        protected override void OnCreate(Bundle bundle) {
            base.OnCreate(bundle);
            Notifications.Init();

            Forms.Init(this, bundle);
            this.LoadApplication(new App());
        }
    }
}

