using Android.Content;
using MvvmCross.Core.ViewModels;
using MvvmCross.Platform.Platform;
using MvxForms.Core;
using MvvmCross.Forms.Droid.Platform;
using MvvmCross.Forms.Platform;

namespace MvxForms.Droid
{
    public class Setup : MvxFormsAndroidSetup
    {
        public Setup(Context applicationContext) : base(applicationContext)
        {
        }

        protected override MvxFormsApplication CreateFormsApplication()
        {
            return new App();
        }

        protected override IMvxApplication CreateApp()
        {
            return new Core.CoreApp();
        }

        protected override IMvxTrace CreateDebugTrace()
        {
            return new DebugTrace();
        }
    }
}
