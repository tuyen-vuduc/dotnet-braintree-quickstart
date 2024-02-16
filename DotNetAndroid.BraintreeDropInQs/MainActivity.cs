using AndroidX.AppCompat.App;
using Com.Braintreepayments.Api;

namespace DotNetAndroid.BraintreeDropInQs;

[Activity(Label = "@string/app_name", MainLauncher = true, Theme = "@style/Theme.AppCompat.Light")]
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
