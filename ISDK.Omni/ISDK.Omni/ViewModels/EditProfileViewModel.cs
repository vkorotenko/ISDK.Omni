#region License
// // Разработано: Коротенко Владимиром Николаевичем (Vladimir N. Korotenko)
// // email: koroten@ya.ru
// // skype:vladimir-korotenko
// // https://vkorotenko.ru
// // Создано:  18.12.2019 16:07
#endregion

using ISDK.Omni.Models;
using System;

namespace ISDK.Omni.ViewModels
{
    public class EditProfileViewModel : BaseViewModel
    {
        public EditProfileViewModel()
        {
            Title = "Edit profile";
        }
        #region Photo
        private string _photo = string.Empty;
        /// <summary>Path to user avatar</summary>
        public string Photo
        {
            get => _photo;
            set => SetProperty(ref _photo, value);
        }
        #endregion

        #region FirstName
        private string _firstName = string.Empty;
        /// <summary>First name</summary>
        public string FirstName
        {
            get => _firstName;
            set => SetProperty(ref _firstName, value);
        }
        #endregion

        #region LastName

        private string _lastName = string.Empty;
        /// <summary>Last name</summary>
        public string LastName
        {
            get => _lastName;
            set => SetProperty(ref _lastName, value);
        }
        #endregion

        #region Email

        private string _email = string.Empty;
        /// <summary>Email</summary>
        public string Email
        {
            get => _email;
            set => SetProperty(ref _email, value);
        }
        #endregion

        #region Gender

        private Gender _gender = Gender.Woman;
        /// <summary>Gender</summary>
        public Gender Gender
        {
            get => _gender;
            set => SetProperty(ref _gender, value);
        }
        #endregion

        #region Date of birth

        private DateTime _birthDay = DateTime.Now.AddYears(-21);
        /// <summary>Date of birth</summary>
        public DateTime BirthDay
        {
            get => _birthDay;
            set => SetProperty(ref _birthDay, value);
        }
        #endregion
    }
}
