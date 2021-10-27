using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesempenhoAnalistas.DAL
{
    public class ConexaoDAL
    {
        #region Variaveis diversas  
        private String _StringConexao;
        private NpgsqlConnection _Conexao;
        #endregion

        public ConexaoDAL(String dadosConexao)
        {
            this._Conexao = new NpgsqlConnection();
            this.StringConexao = dadosConexao;
            this._Conexao.ConnectionString = dadosConexao;
        }

        public String StringConexao
        {
            get { return this._StringConexao; }
            set { this._StringConexao = value; }
        }

        public NpgsqlConnection ObjetoConexao
        {
            get { return this._Conexao; }
            set { this._Conexao = value; }
        }

        public void Conectar()
        {
            this._Conexao.Open();
        }

        public void Desconectar()
        {
            this._Conexao.Close();
        }
    }
}
}
