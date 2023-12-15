using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using choque14.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace choque14.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CompraView : ContentPage
    {
        public CompraView()
        {
            InitializeComponent();
            this.BindingContext = new CompraViewModel();
        }
    }
}