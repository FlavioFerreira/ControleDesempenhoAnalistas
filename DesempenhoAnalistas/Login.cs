using DesempenhoAnalistas.BLL.Cadastros.Usuarios;
using DesempenhoAnalistas.DTO.Cadastros.Usuarios;
using DesempenhoAnalistas.UTIL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesempenhoAnalistas
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        UsuarioBLL usuarioBLL;

        UsuarioDTO usuarioDTO;

        string mensagem = string.Empty;

        public void ValidaLoginUsuario()
        {
            usuarioBLL = new UsuarioBLL();
            usuarioDTO = new UsuarioDTO();

            try
            {
                usuarioDTO.Login = txtUsuario.Text;
                usuarioDTO.Senha = txtSenha.Text;

                usuarioBLL.ValidaLoginUsuario(usuarioDTO);

                if(usuarioDTO.Login == txtUsuario.Text && usuarioDTO.Senha == txtSenha.Text)
                {
                    MessageBox.Show("Login efetuado!", "Mensagem do sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                    MenuPrincipal Principal = new MenuPrincipal();
                    Principal.ShowDialog();

                    
                }
                else
                {

                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Mensagem do sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            ValidaLoginUsuario();
        }

        private void Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
