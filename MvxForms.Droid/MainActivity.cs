using Android.App;
using Android.Content.PM;
using Android.OS;
using MvvmCross.Forms.Droid.Views;

namespace MvxForms.Droid
{
    [Activity(Label = "MvxForms.Droid", Icon = "@drawable/icon", Theme = "@style/MyTheme", ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : MvxFormsAppCompatActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            TabLayoutResource = Resource.Layout.Tabbar;
            ToolbarResource = Resource.Layout.Toolbar;
        }
    }
}
