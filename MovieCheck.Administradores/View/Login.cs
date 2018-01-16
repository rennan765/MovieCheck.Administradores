using MovieCheck.Administradores.View;
using MovieCheck.Administradores.Modeling;
using MovieCheck.Administradores.Infra;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Linq;

namespace MovieCheck.Administradores
{
    public partial class Login : Form
    {
        IList<Telefone> telefones = new List<Telefone>();
        Endereco endereco;
        Cliente cliente;

        public Login()
        {
            InitializeComponent();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente();
            cliente.Email = this.Email.Text.ToString();
            cliente.CadastrarSenha(this.Password.Text.ToString());
            
            try
            {
                cliente.EfetuarLogin();
                new Main().Show();
                this.Hide();
            }
            catch (LoginFailedException exception)
            {
                MessageBox.Show(exception.Desricao, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BloquearLoginButton(object sender, EventArgs e)
        {
            if (this.Email.Text.ToString() != string.Empty && this.Password.Text.ToString() != string.Empty)
            {
                this.LoginButton.Enabled = true;
            }
            else
            {
                this.LoginButton.Enabled = false;
            }
        }

        private void ExisteAdministradorLiberado()
        {
            using (var contexto = new MovieCheckContext())
            {
                if (!contexto.Cliente.Any(a => a.Tipo == 1 && a.Status == 1))
                {
                    MessageBox.Show("Não existem administradores autorizados. Impossível prosseguir. \nContate o administrador do sistema.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Application.Exit();
                }
            }
        }

        private void FecharPrograma(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Gostaria realmente de sair?", "MovieCheckAdministrator", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
