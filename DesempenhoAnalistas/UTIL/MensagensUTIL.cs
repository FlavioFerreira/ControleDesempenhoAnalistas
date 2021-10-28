using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesempenhoAnalistas.UTIL
{
    public class MensagensUTIL
    {
        // Mensagens de login/usuário
        public static string MsgCampoUsuarioObrigatorio = "O campo Usuário é obrigatório!";
        public static string MsgCampoSenhaObrigatorio = "O campo Senha é obrigatório!";
        public static string MsgUsuarioNaoConfere = "Usuário não confere!\nPor favor, verificar.";
        public static string MsgSenhaNaoConfere = "Senha não confere!\nPor favor, verificar.";
        public static string MsgCampoUsuarioMinimoCaracteres = "O campo usuário tem que ter mínimo 4 caracteres.";
        public static string MsgCampoSenhaMinimoCaracteres = "O campo senha tem que ter mínimo 8 caracteres.";
        public static string MsgCadastroUsuarioEfetuadoSucesso = "Cadastro do usuário salvo com sucesso!";
        public static string MsgCancelarCadastroUsuario = "Deseja cancelar o cadastro do usuário?";
        public static string MsgSalvarCadastroUsuario = "Deseja salvar o cadastro de usuário? ";

        // Mensagens de conexão
        public static string MsgErroConectarBD = "Não foi possível conectar ao banco de dados!\nPor favor, entre em contato com o suporte.";
        public static string MsgSemConexaoInternet = "Não existe conexão com a internet!\nPara finalizar o cadastro, por favor verificar.";

        // Mensagens diversas
        public static string MsgEncerrarSistema = "Deseja encerrar o sistema?";
        public static string MsgTrocarUsuario = "Deseja trocar de usuário?";
        //public static string Msg = "";
    }
}
