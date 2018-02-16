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

        internal static object InserirContato()
        {
            throw new NotImplementedException();
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

        //Construtor Sem Parametros
        public DADOS()
        {

        }

        //Construtor com Parametros
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

        //Metodo de Inserção
        public string InserirContato(DADOS Contato)
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

                SqlParameter parCelular = new SqlParameter();
                parCelular.ParameterName = "@celular";
                parCelular.SqlDbType = SqlDbType.VarChar;
                parCelular.Size = 15;
                parCelular.Value = Contato.Celular;
                sqlCmd.Parameters.Add(parCelular);

                SqlParameter parResidencia = new SqlParameter();
                parResidencia.ParameterName = "@residencial";
                parResidencia.SqlDbType = SqlDbType.VarChar;
                parResidencia.Size = 15;
                parResidencia.Value = Contato.Residencia;
                sqlCmd.Parameters.Add(parResidencia);

                SqlParameter parComercial = new SqlParameter();
                parComercial.ParameterName = "@comercial";
                parComercial.SqlDbType = SqlDbType.VarChar;
                parComercial.Size = 15;
                parComercial.Value = Contato.Comercial;
                sqlCmd.Parameters.Add(parComercial);

                SqlParameter parFax = new SqlParameter();
                parFax.ParameterName = "@fax";
                parFax.SqlDbType = SqlDbType.VarChar;
                parFax.Size = 15;
                parFax.Value = Contato.Fax;
                sqlCmd.Parameters.Add(parFax);

                SqlParameter parPessoal = new SqlParameter();
                parPessoal.ParameterName = "@pessoal";
                parPessoal.SqlDbType = SqlDbType.VarChar;
                parPessoal.Size = 50;
                parPessoal.Value = Contato.Pessoal;
                sqlCmd.Parameters.Add(parPessoal);

                SqlParameter parProssional = new SqlParameter();
                parProssional.ParameterName = "@profissional";
                parProssional.SqlDbType = SqlDbType.VarChar;
                parProssional.Size = 50;
                parProssional.Value = Contato.Profissional;
                sqlCmd.Parameters.Add(parProssional);



                //executar comando

                resp = sqlCmd.ExecuteNonQuery() == 1 ? "Contato Inserido" : "Contato não inserido";



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

        //Metodo de Alteração

        public string AlterarDados(DADOS Contato)
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
                sqlCmd.CommandText = "alterarContato";
                sqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter parPessoa = new SqlParameter();
                parPessoa.ParameterName = "@idPessoa";
                parPessoa.SqlDbType = SqlDbType.Int;
                parPessoa.Value = Contato.IdPessoa;
                sqlCmd.Parameters.Add(parPessoa);

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

                resp = sqlCmd.ExecuteNonQuery() == 1 ? "Contato Alterado" : "Contato não alterado";



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

        //listar todos

        public DataTable ListarContatos()
        {
            DataTable dtResultado = new DataTable("contato");
            SqlConnection sqlCon = new SqlConnection();
            try
            {
                sqlCon.ConnectionString = Conexao.Cn;
                sqlCon.Open();
                SqlCommand sqlCmd = new SqlCommand("listarContatos", sqlCon);
                sqlCmd.CommandType = CommandType.StoredProcedure;
                SqlDataReader sqlDat = sqlCmd.ExecuteReader();
                dtResultado.Load(sqlDat);
                sqlCon.Close();
            }
            catch (Exception ex)
            {
                dtResultado = null;
            }
            return dtResultado;
        }

        //buscar contato

        public DataTable BuscarContato(DADOS Contato)
        {
            DataTable dtResultado = new DataTable("contato");
            SqlConnection sqlCon = new SqlConnection();
            try
            {
                sqlCon.ConnectionString = Conexao.Cn;
                SqlCommand sqlCmd = new SqlCommand();
                sqlCmd.Connection = sqlCon;
                sqlCmd.CommandText = "buscarContato";
                sqlCmd.CommandType = CommandType.StoredProcedure;


                SqlParameter parNome  = new SqlParameter();
                parNome.ParameterName = "@nome";
                parNome.SqlDbType = SqlDbType.VarChar;
                parNome.Size = 25;
                parNome.Value = Contato.Nome;
                sqlCmd.Parameters.Add(parNome);

                SqlDataAdapter sqlDat = new SqlDataAdapter(sqlCmd);
                sqlDat.Fill(dtResultado);
            }
            catch (Exception)
            {
                dtResultado = null;
            }
            return dtResultado;
        }

        //Excluir Contato
        public string ExcluirContato(DADOS Contato)
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
                sqlCmd.CommandText = "excluirContato";
                sqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter parIdPessoa = new SqlParameter();
                parIdPessoa.ParameterName = "@idPessoa";
                parIdPessoa.SqlDbType = SqlDbType.Int;
                parIdPessoa.Value = Contato.IdPessoa;
                sqlCmd.Parameters.Add(parIdPessoa);



                //executar comando

                resp = sqlCmd.ExecuteNonQuery() == 1 ? "Contato excluido" : "Contato não excluido";

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

        //Inserindo novo Telefone

        //Metodo de Inserção
        public string InserirTel(DADOS Contato)
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
                sqlCmd.CommandText = "adicionarTel";
                sqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter parIdPessoa = new SqlParameter();
                parIdPessoa.ParameterName = "@idPessoa";
                parIdPessoa.SqlDbType = SqlDbType.Int;
                parIdPessoa.Value = Contato.IdPessoa;
                sqlCmd.Parameters.Add(parIdPessoa);

                SqlParameter parCelular = new SqlParameter();
                parCelular.ParameterName = "@celular";
                parCelular.SqlDbType = SqlDbType.VarChar;
                parCelular.Size = 15;
                parCelular.Value = Contato.Celular;
                sqlCmd.Parameters.Add(parCelular);

                SqlParameter parResidencia = new SqlParameter();
                parResidencia.ParameterName = "@residencial";
                parResidencia.SqlDbType = SqlDbType.VarChar;
                parResidencia.Size = 15;
                parResidencia.Value = Contato.Residencia;
                sqlCmd.Parameters.Add(parResidencia);

                SqlParameter parComercial = new SqlParameter();
                parComercial.ParameterName = "@comercial";
                parComercial.SqlDbType = SqlDbType.VarChar;
                parComercial.Size = 15;
                parComercial.Value = Contato.Comercial;
                sqlCmd.Parameters.Add(parComercial);

                SqlParameter parFax = new SqlParameter();
                parFax.ParameterName = "@fax";
                parFax.SqlDbType = SqlDbType.VarChar;
                parFax.Size = 15;
                parFax.Value = Contato.Fax;
                sqlCmd.Parameters.Add(parFax);

                



                //executar comando

                resp = sqlCmd.ExecuteNonQuery() == 1 ? "Contato Inserido" : "Contato não inserido";



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

        //Excluir Contato
        public string ExcluirTel(DADOS Contato)
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
                sqlCmd.CommandText = "excluirTel";
                sqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter parIdPessoa = new SqlParameter();
                parIdPessoa.ParameterName = "@idPessoa";
                parIdPessoa.SqlDbType = SqlDbType.Int;
                parIdPessoa.Value = Contato.IdPessoa;
                sqlCmd.Parameters.Add(parIdPessoa);

                SqlParameter parCelular = new SqlParameter();
                parCelular.ParameterName = "@celular";
                parCelular.SqlDbType = SqlDbType.VarChar;
                parCelular.Size = 15;
                parCelular.Value = Contato.Celular;
                sqlCmd.Parameters.Add(parCelular);

                SqlParameter parResidencia = new SqlParameter();
                parResidencia.ParameterName = "@residencial";
                parResidencia.SqlDbType = SqlDbType.VarChar;
                parResidencia.Size = 15;
                parResidencia.Value = Contato.Residencia;
                sqlCmd.Parameters.Add(parResidencia);

                SqlParameter parComercial = new SqlParameter();
                parComercial.ParameterName = "@comercial";
                parComercial.SqlDbType = SqlDbType.VarChar;
                parComercial.Size = 15;
                parComercial.Value = Contato.Comercial;
                sqlCmd.Parameters.Add(parComercial);

                SqlParameter parFax = new SqlParameter();
                parFax.ParameterName = "@fax";
                parFax.SqlDbType = SqlDbType.VarChar;
                parFax.Size = 15;
                parFax.Value = Contato.Fax;
                sqlCmd.Parameters.Add(parFax);



                //executar comando

                resp = sqlCmd.ExecuteNonQuery() == 1 ? "Telefone excluido" : "Telefone não excluido";

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

        //alterar TEL

        public string AlterarTel(DADOS Contato)
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
                sqlCmd.CommandText = "alterarTel";
                sqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter parPessoa = new SqlParameter();
                parPessoa.ParameterName = "@idPessoa";
                parPessoa.SqlDbType = SqlDbType.Int;
                parPessoa.Value = Contato.IdPessoa;
                sqlCmd.Parameters.Add(parPessoa);

                SqlParameter parCelular = new SqlParameter();
                parCelular.ParameterName = "@celular";
                parCelular.SqlDbType = SqlDbType.VarChar;
                parCelular.Size = 15;
                parCelular.Value = Contato.Celular;
                sqlCmd.Parameters.Add(parCelular);

                SqlParameter parResidencia = new SqlParameter();
                parResidencia.ParameterName = "@residencial";
                parResidencia.SqlDbType = SqlDbType.VarChar;
                parResidencia.Size = 15;
                parResidencia.Value = Contato.Residencia;
                sqlCmd.Parameters.Add(parResidencia);

                SqlParameter parComercial = new SqlParameter();
                parComercial.ParameterName = "@comercial";
                parComercial.SqlDbType = SqlDbType.VarChar;
                parComercial.Size = 15;
                parComercial.Value = Contato.Comercial;
                sqlCmd.Parameters.Add(parComercial);

                SqlParameter parFax = new SqlParameter();
                parFax.ParameterName = "@fax";
                parFax.SqlDbType = SqlDbType.VarChar;
                parFax.Size = 15;
                parFax.Value = Contato.Fax;
                sqlCmd.Parameters.Add(parFax);


                resp = sqlCmd.ExecuteNonQuery() == 1 ? "Telefone Alterado" : "Telefone não alterado";



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
