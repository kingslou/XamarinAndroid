using Android.App;
using Android.Widget;
using Android.OS;
using Android.Content;

namespace HelloAndroid
{
    [Activity(Label = "HelloAndroid", MainLauncher = true, Icon = "@mipmap/icon")]

    public class MainActivity : Activity
    {
        int count = 1;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            // Get our button from the layout resource,
            // and attach an event to it
            Button button = FindViewById<Button>(Resource.Id.myButton);

            Button button2 = FindViewById<Button>(Resource.Id.button1);

            button.Click += delegate { button.Text = $"{count++} clicks!"; };

            button2.Click += delegate
            {
                Intent intent = new Intent();
                intent.SetClass(this,typeof(SecondActivity));
                StartActivity(intent);
            };
        }
    }
}

