using MvvmCross.Platform.IoC;

namespace MvxForms.Core
{
    public class CoreApp : MvvmCross.Core.ViewModels.MvxApplication
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
