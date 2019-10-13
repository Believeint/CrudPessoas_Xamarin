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

        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            lvwPessoas.ItemsSource = App.Db.GetPessoas();
        }

        private void NavAddItemClicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new AddPessoa() { BindingContext = new Pessoa() });
        }

        private void ItemClicked(object sender, ItemTappedEventArgs e)
        {
            Navigation.PushAsync(new DetailPessoa() { BindingContext = e.Item as Pessoa });
        }
    }
}