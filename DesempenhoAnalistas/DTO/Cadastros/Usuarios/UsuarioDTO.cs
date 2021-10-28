using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesempenhoAnalistas.DTO.Cadastros.Usuarios
{
    public class UsuarioDTO
    {
        private int idUsuario;

        private string nomeUsuario;

        private string login;

        private string senha;

        private string dataCadastro;

        private char stAtivo;

        public int IdUsuario
        {
            get { return this.idUsuario; }
            set { this.idUsuario = value; }
        }

        public string NomeUsuario
        {
            get { return this.nomeUsuario; }
            set { this.nomeUsuario = value; }
        }

        public string Login
        {
            get { return this.login; }
            set { this.login = value; }
        }

        public string Senha
        {
            get { return this.senha; }
            set { this.senha = value; }
        }

        public string DataCadastro
        {
            get { return this.dataCadastro; }
            set { this.dataCadastro = value; }
        }

        public char StAtivo
        {
            get { return this.stAtivo; }
            set { this.stAtivo = value;}
        }
    }
}
