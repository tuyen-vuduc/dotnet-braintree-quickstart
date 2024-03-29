﻿using Android.App;
using Android.OS;
using AndroidX.AppCompat.App;
using Android.Widget;
using Com.Braintreepayments.Api;

namespace XamarinAndroid.BraintreeDropInQs
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme.NoActionBar", MainLauncher = true)]
    public class MainActivity : AppCompatActivity, IDropInListener
    {
        public void OnDropInFailure(Java.Lang.Exception p0)
        {
            throw p0;
        }

        public void OnDropInSuccess(DropInResult p0)
        {
            System.Diagnostics.Debug.WriteLine(p0);
        }

        DropInClient _dropInClient;
        Button btnLaunchDropIn;

        protected override void OnCreate(Bundle? savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);

            btnLaunchDropIn = FindViewById<Button>(Resource.Id.btnLaunchDropIn);

            _dropInClient = new DropInClient(this, "YOUR_TOKENIZATION_KEY");

            _dropInClient.SetListener(this);

            btnLaunchDropIn.Click += (s, e) =>
            {
                var dropInRequest = new DropInRequest();
                // var payPalReqeuest = new PayPalVaultRequest();
                // dropInRequest.PayPalRequest = payPalReqeuest;

                _dropInClient.LaunchDropIn(dropInRequest);
            };
        }
    }
}
