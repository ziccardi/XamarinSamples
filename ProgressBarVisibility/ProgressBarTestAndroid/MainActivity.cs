using Android.App;
using Android.Widget;
using Android.OS;

namespace ProgressBarTestAndroid
{
    [Activity(Label = "ProgressBarTestAndroid", MainLauncher = true, Icon = "@mipmap/icon")]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            ProgressBar barOfProgression = FindViewById<ProgressBar>(Resource.Id.progressBarMap);
            CheckBox checkBox = FindViewById<CheckBox>(Resource.Id.checkbox1);

            checkBox.CheckedChange += (sender, evt) => {
                barOfProgression.Visibility = evt.IsChecked ? Android.Views.ViewStates.Visible : Android.Views.ViewStates.Invisible;
            };
        }
    }
}

