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
        public int Grava(UsuarioDTO _Usuario)
        {
            string msg = string.Empty;

            if (_Usuario.Login == string.Empty)
                msg += "Login \n";

            if (_Usuario.NomeUsuario == string.Empty)
                msg += "Nome do Usuário \n";

            if (_Usuario.Senha == string.Empty)
                msg += "Senha \n";

            UsuarioDAL obj = new UsuarioDAL(_Usuario);
            return obj.Grava();

        }
    }
}
