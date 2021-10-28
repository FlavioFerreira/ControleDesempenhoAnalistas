using System;
using DesempenhoAnalistas.DAL.Cadastros.Usuarios;
using DesempenhoAnalistas.DTO.Cadastros.Usuarios;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesempenhoAnalistas.UTIL;

namespace DesempenhoAnalistas.BLL.Cadastros.Usuarios
{
    public class UsuarioBLL
    {
        UsuarioDAL usuarioDAL;

        string mensagem = string.Empty;

        public void ValidaLoginUsuario(UsuarioDTO usuarioDTO)
        {
            usuarioDAL = new UsuarioDAL();

            if(usuarioDTO.NomeUsuario == string.Empty)
            {
                mensagem += MensagensUTIL.MsgCampoUsuarioObrigatorio;
            }
            else if(usuarioDTO.Senha == string.Empty)
            {
                mensagem += MensagensUTIL.MsgCampoSenhaObrigatorio;
            }
            if(mensagem != string.Empty)
            {
                throw new Exception(mensagem);
            }
            else
            {
                usuarioDAL.ValidaLoginUsuario(usuarioDTO);
            }
            
        }
    }
}
