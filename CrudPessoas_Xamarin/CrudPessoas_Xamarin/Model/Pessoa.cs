using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace CrudPessoas_Xamarin.Model
{
    public class Pessoa
    {
        // Propriedades classe Pessoa
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Genero { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public string Pais { get; set; }
    }
}
