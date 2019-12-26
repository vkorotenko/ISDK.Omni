using ISDK.Omni.Core.Models;
using ISDK.Omni.Core.Services;
using MvvmCross.Commands;
using MvvmCross.Logging;
using MvvmCross.Navigation;
using MvvmCross.ViewModels;
using System;

namespace ISDK.Omni.Core.ViewModels
{
    public class UserProfileViewModel : MvxNavigationViewModel
    {
        public UserProfileViewModel(IMvxLogProvider logProvider, IMvxNavigationService navigationService, IUserLogoService userLogo) : base(logProvider, navigationService)
        {
            _avatarService = userLogo;
            ShowRootViewModelCommand = new MvxAsyncCommand(async () => await NavigationService.Navigate<TabsViewModel>());
            CloseViewModelCommand = new MvxAsyncCommand(async () => await NavigationService.Close(this));
        }

        public IMvxAsyncCommand ShowRootViewModelCommand { get; private set; }

        public IMvxAsyncCommand CloseViewModelCommand { get; private set; }


        private readonly IUserLogoService _avatarService;


        #region Photo
        private string _photo = string.Empty;
        /// <summary>Path to user avatar</summary>
        public string Photo
        {
            get => _photo;
            set
            {
                _photo = value;
                RaisePropertyChanged(() => Photo);
            }
        }
        #endregion

        #region FirstName
        private string _firstName = string.Empty;
        /// <summary>First name</summary>
        public string FirstName
        {
            get => _firstName;
            set
            {
                _firstName = value;
                RaisePropertyChanged(() => FirstName);
            }
        }
        #endregion

        #region LastName

        private string _lastName = string.Empty;
        /// <summary>Last name</summary>
        public string LastName
        {
            get => _lastName;
            set
            {
                _lastName = value;
                RaisePropertyChanged(() => LastName);
            }
        }
        #endregion

        #region Email

        private string _email = string.Empty;
        /// <summary>Email</summary>
        public string Email
        {
            get => _email;
            set
            {
                _email = value;
                RaisePropertyChanged(() => Email);
            }
        }
        #endregion

        #region Gender

        private Gender _gender = Gender.Woman;
        /// <summary>Gender</summary>
        public Gender Gender
        {
            get => _gender;
            set
            {
                _gender = value;
                RaisePropertyChanged(() => Gender);
            }
        }
        #endregion

        #region Date of birth

        private DateTime _birthDay = DateTime.Now.AddYears(-21);
        /// <summary>Date of birth</summary>
        public DateTime BirthDay
        {
            get => _birthDay;
            set
            {
                _birthDay = value;
                RaisePropertyChanged(() => BirthDay);
            }
        }

        public IUserLogoService AvatarService => _avatarService;
        #endregion
    }
}
