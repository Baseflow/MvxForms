using MvvmCross.Forms.iOS;
using MvvmCross.Forms.Platform;
using MvxForms.Core;
using MvvmCross.Core.ViewModels;
using MvvmCross.iOS.Platform;
using UIKit;
using MvvmCross.Platform.Platform;

namespace MvxForms.iOS
{
    public class Setup : MvxFormsIosSetup
    {
        public Setup(IMvxApplicationDelegate applicationDelegate, UIWindow window)
            : base(applicationDelegate, window)
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
