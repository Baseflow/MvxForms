using Android.Content;
using MvvmCross.Forms.Platforms.Android.Core;
using MvvmCross.ViewModels;
using MvxForms.Core;

namespace MvxForms.Droid
{
    public class Setup : MvxFormsAndroidSetup
    {
        protected override Xamarin.Forms.Application CreateFormsApplication()
        {
            return new App();
        }

        protected override IMvxApplication CreateApp()
        {
            return new Core.CoreApp();
        }
    }
}
