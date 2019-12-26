using ISDK.Omni.Core.ViewModels;
using MvvmCross.IoC;
using MvvmCross.ViewModels;

namespace ISDK.Omni.Core
{
    public class App : MvxApplication
    {
        public override void Initialize()
        {
            CreatableTypes()
                .EndingWith("Service")
                .AsInterfaces()
                .RegisterAsLazySingleton();
            
            XamSvg.Shared.Config.ResourceAssembly = typeof(App).Assembly;
            RegisterAppStart<TabsViewModel>();
        }
    }
}