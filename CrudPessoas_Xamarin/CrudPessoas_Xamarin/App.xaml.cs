using CrudPessoas_Xamarin.Data;
using System;
using System.IO;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using CrudPessoas_Xamarin.View;

namespace CrudPessoas_Xamarin
{
    public partial class App : Application
    {
        static DBPessoas db;
        public static DBPessoas Db
        {
           // Verifica se já existe DB, Se não existir o BD é Criado
            get {
                if (db == null)
                {
                    db = new DBPessoas(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Pessoas.db3"));
                }
                return db;
            }
           
        }
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new ViewPessoa());
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
