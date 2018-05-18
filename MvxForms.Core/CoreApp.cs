using MvvmCross.IoC;
using MvvmCross.ViewModels;

namespace MvxForms.Core
{
    public class CoreApp : MvxApplication
    {
        public override void Initialize()
        {
            CreatableTypes()
                .EndingWith("Service")
                .AsInterfaces()
                .RegisterAsLazySingleton();

            RegisterAppStart<ViewModels.MvxFormsViewModel>();
        }
    }
}
