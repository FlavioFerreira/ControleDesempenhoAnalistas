using System;
using DesempenhoAnalistas.DTO.Cadastros.Usuarios;
using Npgsql;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DesempenhoAnalistas.UTIL;

namespace DesempenhoAnalistas.DAL.Cadastros.Usuarios
{
    public class UsuarioDAL
    {
        ConexaoDAL conexaoDAL;

        NpgsqlCommand cmd;

        NpgsqlDataReader dr;

        public void ValidaLoginUsuario(UsuarioDTO usuarioDTO)
        {
            conexaoDAL = new ConexaoDAL(DadosConexaoDAL.StringConexaoLocal);

            cmd = new NpgsqlCommand();

            try
            {
                cmd.CommandText = "SELECT login, senha FROM Usuarios where login = '"+
                    usuarioDTO.Login +  "' AND Senha = '"+ usuarioDTO.Senha +"'";

                cmd.Connection = conexaoDAL.ObjetoConexao;

                conexaoDAL.Conectar();

                dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    usuarioDTO.Login = Convert.ToString(dr["Login"]);
                    usuarioDTO.Senha = Convert.ToString(dr["Senha"]);

                    return;
                }
            }
            catch (NpgsqlException)
            {
                MessageBox.Show(MensagensUTIL.MsgErroConectarBD, "Mensagem do Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conexaoDAL.Desconectar();
            }
        }


    }
}
