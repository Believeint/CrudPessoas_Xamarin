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
    public partial class DetailPessoa : ContentPage
    {
        public DetailPessoa()
        {
            InitializeComponent();

           
        }

        private void EditarClicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new EditPessoa() { BindingContext = BindingContext as Pessoa });
        }

        private void ExcluirClicked(object sender, EventArgs e)
        {
            Pessoa pessoa = (Pessoa)BindingContext;
            App.Db.DeletarPessoa(pessoa);
            Navigation.PopAsync();
        }
    }
}