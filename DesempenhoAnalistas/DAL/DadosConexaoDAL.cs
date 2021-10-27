using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static DesempenhoAnalistas.UTIL.ParametrosUTIL;

namespace DesempenhoAnalistas.DAL
{
    public class DadosConexaoDAL
    {
        public static String StringConexaoLocal
        {
            get
            {
                return @"Server="+ NpgSQLLocal.Servidor + "; Port=" + NpgSQLLocal.Porta + "; User Id=" + NpgSQLLocal.Usuario + "; Password=" + NpgSQLLocal.Senha + "; Database=" + NpgSQLLocal.Banco;
            }
        }
    }
}
