using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
using CrudPessoas_Xamarin.Model;

namespace CrudPessoas_Xamarin.Data
{
    public class DBPessoas
    {
        readonly SQLiteConnection _db;

        // Conexão com o BD e Criação da Tabela
        public DBPessoas(string dbPath)
        {
            _db = new SQLiteConnection(dbPath);
            _db.CreateTable<Pessoa>();
        }

        // Retorna todas as pessoas do BD em forma de lista
        public List<Pessoa> GetPessoas()
        {
            return _db.Table<Pessoa>().ToList();
        }

        // Retorna a pessoa com o ID especificado
        public Pessoa GetPessoa(int id)
        {
            return _db.Table<Pessoa>().Where(i => i.Id == id).FirstOrDefault();
        }

        // Realiza um Insert do objeto no DB
        public int SalvarPessoa(Pessoa pessoa)
        {
            return _db.Insert(pessoa);
        }

        // Realiza um Delete do objeto no DB
        public int DeletarPessoa(Pessoa pessoa)
        {
            return _db.Delete(pessoa);
        }

        public int EditarPessoa(Pessoa pessoa)
        {
            return _db.Update(pessoa);
        }



    }
}
