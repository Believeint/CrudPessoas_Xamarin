using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CrudPessoas_Xamarin.Model;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CrudPessoas_Xamarin.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ViewPessoa : ContentPage
    {
        public ViewPessoa()
        {
            InitializeComponent();


           lvwPessoas.ItemsSource = App.Db.GetPessoas();
        }

        private void ToolbarItem_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new AddPessoa() { BindingContext = new Pessoa() });
        }
    }
}