#region License

// // Разработано: Коротенко Владимиром Николаевичем (Vladimir N. Korotenko)
// // email: koroten@ya.ru
// // skype:vladimir-korotenko
// // https://vkorotenko.ru
// // Создано:  20.12.2019 18:21

#endregion

using System.Threading.Tasks;

namespace ISDK.Omni.Core.Services
{
    public interface IUserLogoService
    {
        /// <summary>
        /// Take user photo. 
        /// </summary>
        /// <returns></returns>
        Task<byte[]> TakePhoto();
    }
}