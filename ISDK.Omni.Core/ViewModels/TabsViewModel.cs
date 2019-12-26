using MvvmCross.Commands;
using MvvmCross.Logging;
using MvvmCross.Navigation;
using MvvmCross.ViewModels;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ISDK.Omni.Core.ViewModels
{
    public class TabsViewModel : MvxViewModel
    {
        public TabsViewModel(IMvxLogProvider logProvider, IMvxNavigationService navigationService)
        {

        }
        private RequestsViewModel _requestModel;
        public RequestsViewModel RequestModel
        {
            get => _requestModel;
            set
            {
                _requestModel = value;
                RaisePropertyChanged(() => _requestModel);
            }
        }

        private UserProfileViewModel _userProfile;
        public UserProfileViewModel UserProfile
        {
            get => _userProfile;
            set
            {
                _userProfile = value;
                RaisePropertyChanged(() => _userProfile);
            }
        }
    }
}
