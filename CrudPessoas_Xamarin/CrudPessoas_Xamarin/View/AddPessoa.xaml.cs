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
    public partial class AddPessoa : ContentPage
    {
        public AddPessoa()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            var pessoa = (Pessoa)BindingContext;
            pessoa.Nome = entNom.Text;
            pessoa.Genero = entGen.Text;
            pessoa.DataNascimento = Convert.ToDateTime(entDtN.Text);
            pessoa.Cidade = entCid.Text;
            pessoa.Estado = entEst.Text;
            pessoa.Pais = entPais.Text;

            App.Db.SalvarPessoa(pessoa);
            App.Current.MainPage = new NavigationPage(new ViewPessoa()); //
        }
    }
}