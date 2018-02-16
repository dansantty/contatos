using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Contatos;
using System.Data.SqlClient;
using System.Data;

namespace Contatos
{
   public class NEGOCIO
    {
        public static string InserirContato(string nome, DateTime nasc, string celular, string residencia, string comercial, string fax, string pessoal, string profissional)
        {
            DADOS Obj = new DADOS();
            Obj.Nome = nome;
            Obj.Nasc = nasc;
            Obj.Celular = celular;
            Obj.Residencia = residencia;
            Obj.Comercial = comercial;
            Obj.Fax = fax;
            Obj.Pessoal = pessoal;
            Obj.Profissional = profissional;

            return Obj.InserirContato(Obj);
        }

        public static string AlterarDados(int idPessoa, string nome, DateTime nasc)
        {
            DADOS Obj = new DADOS();
            Obj.IdPessoa = idPessoa;
            Obj.Nome = nome;
            Obj.Nasc = nasc;

            return Obj.AlterarDados(Obj);

        }

        public static DataTable ListarContatos()
        {
            return new DADOS().ListarContatos();
        }

        public static DataTable BuscarContato(string nome)
        {
            DADOS Obj = new DADOS();
            Obj.Nome = nome;

            return Obj.BuscarContato(Obj);
        }

        public static string ExcluirContato(int idPessoa)
        {
            DADOS Obj = new DADOS();
            Obj.IdPessoa = idPessoa;

            return Obj.ExcluirContato(Obj);
        }

        public static string IncluirTel(int idPessoa, string cel, string come, string resid, string fax)
        {
            DADOS Obj = new DADOS();
            Obj.IdPessoa = idPessoa;
            Obj.Celular = cel;
            Obj.Comercial = come;
            Obj.Residencia = resid;
            Obj.Fax = fax;

            return Obj.InserirTel(Obj);

        }

        public static string AlterarTel(int idPessoa, string cel, string come, string resid, string fax)
        {
            DADOS Obj = new DADOS();
            Obj.IdPessoa = idPessoa;
            Obj.Celular = cel;
            Obj.Comercial = come;
            Obj.Residencia = resid;
            Obj.Fax = fax;

            return Obj.AlterarTel(Obj);
        }


        public static string ExcluirTel(int idPessoa, string cel, string come, string resid, string fax)
        {
            DADOS Obj = new DADOS();
            Obj.IdPessoa = idPessoa;
            Obj.Celular = cel;
            Obj.Comercial = come;
            Obj.Residencia = resid;
            Obj.Fax = fax;

            return Obj.ExcluirTel(Obj);
        }

    }
}
