using Android.App;
using Android.Content.PM;
using Android.OS;
using MvvmCross.Droid.Views;
using MvvmCross.Forms.Droid;
using MvvmCross.Forms.Presenters;
using MvvmCross.Platform;

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
