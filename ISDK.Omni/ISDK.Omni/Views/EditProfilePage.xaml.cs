using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ISDK.Omni.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ISDK.Omni.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class EditProfilePage : ContentPage
    {
        private EditProfileViewModel _vm;
        public EditProfilePage()
        {
            InitializeComponent();
            BindingContext = _vm = new EditProfileViewModel();
        }

        private void Save_Clicked(object sender, EventArgs e)
        {
        }
    }
}