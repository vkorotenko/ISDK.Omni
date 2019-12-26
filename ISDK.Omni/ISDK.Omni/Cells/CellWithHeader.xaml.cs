using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ISDK.Omni.Cells
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CellWithHeader : ViewCell
    {
        public static readonly BindableProperty TextProperty =
            BindableProperty.Create ("Text", typeof(string), typeof(CellWithHeader), default(string));
        
        public static readonly BindableProperty HeaderTextProperty =
            BindableProperty.Create ("HeaderText", typeof(string), typeof(CellWithHeader), default(string));

        public string Text
        {
            get => (string) GetValue(TextProperty);
            set
            {
                SetValue(TextProperty, value);
                OnPropertyChanged("Text");
            }
        }

        public string HeaderText
        {
            get => (string) GetValue(HeaderTextProperty);
            set
            {
                SetValue(HeaderTextProperty, value);  
                OnPropertyChanged("HeaderText");
            }

        }
        public CellWithHeader()
        {
            InitializeComponent();
            this.BindingContext = this;

            entry.SetBinding (Entry.TextProperty, "Text");
            entry.SetBinding (Entry.PlaceholderProperty, "HeaderText");
            TitleLabel.SetBinding(Label.TextProperty,"HeaderText");
        }
    }
}