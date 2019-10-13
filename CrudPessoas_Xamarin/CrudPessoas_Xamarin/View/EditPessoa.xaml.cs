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
    public partial class EditPessoa : ContentPage
    {
        public EditPessoa()
        {
            InitializeComponent();
        }

        private void EditarPessoaClicked(object sender, EventArgs e)
        {
            Pessoa pessoa = (Pessoa)BindingContext;
            App.Db.EditarPessoa(pessoa);
            Navigation.PopToRootAsync();
        }
    }
}