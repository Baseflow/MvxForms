using Foundation;
using MvvmCross.Forms.Platforms.Ios.Core;
using UIKit;

namespace MvxForms.iOS
{
    [Register("AppDelegate")]
    public partial class AppDelegate : MvxFormsApplicationDelegate<Setup, Core.CoreApp, Core.App> 
    {
    }
}
