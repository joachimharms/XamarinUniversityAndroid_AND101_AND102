using Android.App;
using Android.Widget;
using Android.OS;

namespace E001_TipCalcultor
{
    [Activity(Label = "E001_TipCalcultor", MainLauncher = true)]
    public class MainActivity : Activity
    {
        int count = 1;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            Button button = FindViewById<Button>(Resource.Id.myButton);

            button.Click += delegate
            {
                button.Text = string.Format($"{count++} clicks!");
            };
        }
    }
}

