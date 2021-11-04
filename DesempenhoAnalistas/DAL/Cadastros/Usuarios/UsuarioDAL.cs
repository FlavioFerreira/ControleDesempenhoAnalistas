using System;
using DesempenhoAnalistas.DTO.Cadastros.Usuarios;
using Npgsql;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DesempenhoAnalistas.UTIL;
using System.Data.SqlClient;

namespace DesempenhoAnalistas.DAL.Cadastros.Usuarios
{
    public class UsuarioDAL
    {
        Conexao conexao;

        SqlCommand cmd;

        String sql;

        String msg;

        UsuarioDTO Usuario;

        public UsuarioDAL(UsuarioDTO _Usuario)
        {
            this.Usuario = _Usuario;
        }


        public int Grava()
        {
            conexao = new Conexao();

            cmd = new SqlCommand();

            try
            {
                conexao.Abre_Conexao();

                if(Usuario.IdUsuario == 0)
                {
                    sql = "INSERT INTO Usuario ";
                    sql += "(Nome_Usuario, Login, Senha, StAtivo) ";
                    sql += "VALUES";
                    sql += "@Nome_Usuario, @Login, @Senha, @StAtivo ";
                    cmd.CommandText = sql;
                    cmd.Parameters.AddWithValue("@Nome_Usuario", Usuario.NomeUsuario);
                    cmd.Parameters.AddWithValue("@Login", Usuario.Login);
                    cmd.Parameters.AddWithValue("@Senha", Usuario.Senha);
                    cmd.Parameters.AddWithValue("@StAtivo", Usuario.StAtivo);

                    Usuario.IdUsuario = conexao.Executa_ComandoID(cmd);
                }
                else
                {
                    sql = "UPDATE ";
                    sql += "Usuario SET ";
                    sql += "Nome_Usuario = @Nome_Usuario, ";
                    sql += "Login = @Login, ";
                    sql += "Senha = @Senha, ";
                    sql += "StAtivo = @StAtivo ";
                    sql += "WHERE ";
                    sql += "IdUsuario = @IdUsuario ";
                    cmd.CommandText = sql;
                    cmd.Parameters.AddWithValue("@IdUsuario", Usuario.IdUsuario);
                    cmd.Parameters.AddWithValue("@Nome_Usuario", Usuario.NomeUsuario);
                    cmd.Parameters.AddWithValue("@Senha", Usuario.Senha);
                    cmd.Parameters.AddWithValue("@StAtivo", Usuario.StAtivo);

                    conexao.Executa_Comando(cmd);
                }

                return Usuario.IdUsuario;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                conexao.Fecha_Conexao();
            }
        }
    }
}
