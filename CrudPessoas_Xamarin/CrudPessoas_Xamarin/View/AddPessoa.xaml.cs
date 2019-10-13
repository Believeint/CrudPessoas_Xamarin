using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using CrudPessoas_Xamarin.Model;

namespace CrudPessoas_Xamarin.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AddPessoa : ContentPage
    {
        public AddPessoa()
        {
            InitializeComponent();
        }

        private void AddPessoaButtonClicked(object sender, EventArgs e)
        {
            var pessoa = (Pessoa)BindingContext;
            pessoa.Nome = entNom.Text;
            pessoa.Genero = entGen.Text;
            pessoa.DataNascimento = Convert.ToDateTime(dtpDtN.Date);
            pessoa.Cidade = entCid.Text;
            pessoa.Estado = entEst.Text;
            pessoa.Pais = entPais.Text;

            App.Db.SalvarPessoa(pessoa);
            Navigation.PopAsync();
        }
    }
}