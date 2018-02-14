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
    public class DADOS
    {
        private int _idPessoa;
        private string _nome;
        private DateTime _nasc;
        private string celular;
        private string residencia;
        private string comercial;
        private string fax;
        private string pessoal;
        private string profissional;

        public int IdPessoa
        {
            get
            {
                return _idPessoa;
            }

            set
            {
                _idPessoa = value;
            }
        }

        public string Nome
        {
            get
            {
                return _nome;
            }

            set
            {
                _nome = value;
            }
        }

        public DateTime Nasc
        {
            get
            {
                return _nasc;
            }

            set
            {
                _nasc = value;
            }
        }

        public string Celular
        {
            get
            {
                return celular;
            }

            set
            {
                celular = value;
            }
        }

        public string Residencia
        {
            get
            {
                return residencia;
            }

            set
            {
                residencia = value;
            }
        }

        public string Comercial
        {
            get
            {
                return comercial;
            }

            set
            {
                comercial = value;
            }
        }

        public string Fax
        {
            get
            {
                return fax;
            }

            set
            {
                fax = value;
            }
        }

        public string Pessoal
        {
            get
            {
                return pessoal;
            }

            set
            {
                pessoal = value;
            }
        }

        public string Profissional
        {
            get
            {
                return profissional;
            }

            set
            {
                profissional = value;
            }
        }

        public DADOS()
        {

        }

        public DADOS(int idPessoa, string nome, DateTime nasc, string celular, string residencial, string comercial,
            string fax, string pessoal, string profissional)
        {
            this.IdPessoa = idPessoa;
            this.Nome = nome;
            this.Nasc = nasc;
            this.Celular = celular;
            this.Residencia = residencial;
            this.Comercial = comercial;
            this.Fax = fax;
            this.Pessoal = pessoal;
            this.Profissional = profissional;
          
        }

        public string InserirMorador(DADOS Contato)
        {
            string resp = "";
            SqlConnection sqlCon = new SqlConnection();

            try
            {
                //codigo
                sqlCon.ConnectionString = Conexao.Cn;
                sqlCon.Open();

                SqlCommand sqlCmd = new SqlCommand();
                sqlCmd.Connection = sqlCon;
                sqlCmd.CommandText = "inserirContato";
                sqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter parIdPessoa = new SqlParameter();
                parIdPessoa.ParameterName = "@idPessoa";
                parIdPessoa.SqlDbType = SqlDbType.Int;
                parIdPessoa.Direction = ParameterDirection.InputOutput;
                sqlCmd.Parameters.Add(parIdPessoa);

                SqlParameter parNome = new SqlParameter();
                parNome.ParameterName = "@nome";
                parNome.SqlDbType = SqlDbType.VarChar;
                parNome.Size = 25;
                parNome.Value = Contato.Nome;
                sqlCmd.Parameters.Add(parNome);

                SqlParameter parNasc = new SqlParameter();
                parNasc.ParameterName = "@nasc";
                parNasc.SqlDbType = SqlDbType.Date;
                parNasc.Value = Contato.Nasc;
                sqlCmd.Parameters.Add(parNasc);

                SqlParameter parNome = new SqlParameter();
                parNome.ParameterName = "@nome";
                parNome.SqlDbType = SqlDbType.VarChar;
                parNome.Size = 25;
                parNome.Value = Contato.Nome;
                sqlCmd.Parameters.Add(parNome);

                SqlParameter parNome = new SqlParameter();
                parNome.ParameterName = "@nome";
                parNome.SqlDbType = SqlDbType.VarChar;
                parNome.Size = 25;
                parNome.Value = Contato.Nome;
                sqlCmd.Parameters.Add(parNome);

                SqlParameter parNome = new SqlParameter();
                parNome.ParameterName = "@nome";
                parNome.SqlDbType = SqlDbType.VarChar;
                parNome.Size = 25;
                parNome.Value = Contato.Nome;
                sqlCmd.Parameters.Add(parNome);

                SqlParameter parNome = new SqlParameter();
                parNome.ParameterName = "@nome";
                parNome.SqlDbType = SqlDbType.VarChar;
                parNome.Size = 25;
                parNome.Value = Contato.Nome;
                sqlCmd.Parameters.Add(parNome);


                //executar comando

                resp = sqlCmd.ExecuteNonQuery() == 1 ? "Contato Inserido" : "Xonttato não inserido";



            }
            catch (Exception ex)
            {
                resp = ex.Message;
            }
            finally
            {
                if (sqlCon.State == ConnectionState.Open)
                    sqlCon.Close();
            }
            return resp;
        }

    }
}
