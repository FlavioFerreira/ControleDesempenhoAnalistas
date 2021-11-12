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

        public void Inicia_Acesso()
        {
            try
            {
                frmMenuPrincipal frmMenuPrincipal;

            if(string.IsNullOrEmpty(txtUsuario.Text) || string.IsNullOrEmpty(txtSenha.Text))
            {
                MessageBox.Show(MensagensUTIL.msg_Erro_Usuario_Senha_Nulo, this.Text);
                txtUsuario.Focus();

                return;
            }

                usuarioBLL = new UsuarioBLL();
                usuarioDTO = new UsuarioDTO();

                usuarioDTO.Login = txtUsuario.Text;
                usuarioDTO.Senha = txtSenha.Text;

                frmMenuPrincipal = new frmMenuPrincipal();
                frmMenuPrincipal.Show();
                this.Hide();

                txtUsuario.Clear();
                txtSenha.Clear();

            }
            catch (Exception ex)
            {
                MessageBox.Show(MensagensUTIL.msg_Erro + ex.Message, this.Text);
            }
        }


        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Inicia_Acesso();
        }

        private void Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
