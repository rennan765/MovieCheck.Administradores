using MovieCheck.Administradores.Infra;
using MovieCheck.Administradores.Modeling;
using System;
using System.Linq;
using System.Windows.Forms;

namespace MovieCheck.Administradores.View
{
    public partial class Main : Form
    {
        Cliente administrador;
        MovieCheckContext contexto;

        public Main()
        {
            InitializeComponent();

            administrador = Secao.Administrador;
            this.Nome.Text = administrador.Nome;

            contexto = new MovieCheckContext();

            MenuLiberarStrips();

            if (this.liberarNovoUsuárioToolStripMenuItem.Enabled)
            {
                MessageBox.Show("Existem clientes a autorizar. Verificar no menu Usuário -> Autorizar novo usuário.", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void sobreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new About().Show();
            MenuLiberarStrips();
        }

        private void contatoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Contact().Show();
            MenuLiberarStrips();
        }

        private void button1_Click(object sender, EventArgs e)
        {
             Application.Exit();
        }

        private void liberarNovoUsuárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.liberarNovoUsuárioToolStripMenuItem.Enabled)
            {
                if (contexto.Usuario.Any(u => u.Status == 0))
                {
                    new AllowUser().Show();
                }
                else
                {
                    MessageBox.Show("Não existem usuários a serem autorizados. ", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                MenuLiberarStrips();
            }
        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new NewUser().Show();
            MenuLiberarStrips();
        }

        private void MenuLiberarStrips()
        {
            //LIBERAR NOVO USUÁRIO
            if (contexto.Usuario.Any(u => u.Status == 0))
            {
                this.liberarNovoUsuárioToolStripMenuItem.Enabled = true;
            }
            else
            {
                this.liberarNovoUsuárioToolStripMenuItem.Enabled = false;
            }

            //BLOQUEAR
            if(contexto.Usuario.Any(u => u.Status == 1))
            {
                this.bloquearToolStripMenuItem.Enabled = true;
            }
            else
            {
                this.bloquearToolStripMenuItem.Enabled = false;
            }

            //DESBLOQUEAR
            if (contexto.Usuario.Any(u => u.Status == 2))
            {
                this.desbloquearToolStripMenuItem.Enabled = true;
            }
            else
            {
                this.desbloquearToolStripMenuItem.Enabled = false;
            }

            //EDITAR/EXCLUIR DEPENDENTE
            if (contexto.Dependente.ToList().Count > 0)
            {
                this.dependenteToolStripMenuItem1.Enabled = true;
                this.dependenteToolStripMenuItem2.Enabled = true;
            }
            else
            {
                this.dependenteToolStripMenuItem1.Enabled = false;
                this.dependenteToolStripMenuItem2.Enabled = false;
            }

            //EDITAR/EXCLUIR CLIENTE
            if (contexto.Cliente.Any(u => u.Tipo == 0))
            {
                this.clienteToolStripMenuItem1.Enabled = true;
                this.clienteToolStripMenuItem2.Enabled = true;
            }
            else
            {
                this.clienteToolStripMenuItem1.Enabled = false;
                this.clienteToolStripMenuItem2.Enabled = false;
            }

            //EDITAR/EXCLUIR ADMINISTRADOR
            if (contexto.Cliente.Any(u => u.Email != Secao.Administrador.Email && u.Tipo == 1))
            {
                this.administradorToolStripMenuItem1.Enabled = true;
                this.administradorToolStripMenuItem2.Enabled = true;
            }
            else
            {
                this.administradorToolStripMenuItem1.Enabled = false;
                this.administradorToolStripMenuItem2.Enabled = false;
            }
        }

        private void administradorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new NewAdministrator().Show();
            MenuLiberarStrips();
        }

        private void trocarDeUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Gostaria realmente de trocar de usuário?", "MovieCheckAdministrator", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Secao.Administrador = null;
                new Login().Show();
                this.Close();
            }
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Gostaria realmente de sair?", "MovieCheckAdministrator", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void bloquearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.bloquearToolStripMenuItem.Enabled)
            {
                if (contexto.Usuario.Any(u => u.Email != Secao.Administrador.Email && u.Status == 1))
                {
                    new BlockUser().Show();
                }
                else
                {
                    MessageBox.Show("Não existem usuários a serem bloqueados. ", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                MenuLiberarStrips();
            }
        }

        private void desbloquearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.desbloquearToolStripMenuItem.Enabled)
            {
                if (contexto.Usuario.Any(u => u.Email != Secao.Administrador.Email && u.Status == 2))
                {
                    new UnlockUser().Show();
                }
                else
                {
                    MessageBox.Show("Não existem usuários a serem desbloqueados. ", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                MenuLiberarStrips();
            }
        }

        private void dependenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new NewGuest().Show();
            MenuLiberarStrips();
        }

        private void clienteToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            if (this.clienteToolStripMenuItem2.Enabled)
            {
                if (contexto.Cliente.Any(u => u.Tipo == 0))
                {
                    new DeleteUser().Show();
                }
                else
                {
                    MessageBox.Show("Não existem clientes cadastrados. ", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                MenuLiberarStrips();
            }
        }

        private void dependenteToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            if (this.dependenteToolStripMenuItem2.Enabled)
            {
                if (contexto.Dependente.ToList().Count > 0)
                {
                    new DeleteGuest().Show();
                }
                else
                {
                    MessageBox.Show("Não existem dependentes cadastrados. ", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                MenuLiberarStrips();
            }
        }

        private void administradorToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            if (this.administradorToolStripMenuItem2.Enabled)
            {
                if (contexto.Cliente.Any(u => u.Email != Secao.Administrador.Email && u.Tipo == 1))
                {
                    new DeleteAdministrator().Show();
                }
                else
                {
                    MessageBox.Show("Não existem outros administradores cadastrados. ", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                MenuLiberarStrips();
            }
        }

        private void clienteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (contexto.Cliente.Any(c => c.Tipo == 0))
            {
                new UpdateUser().Show();
            }
            else
            {
                MessageBox.Show("Não existem clientes cadastrados. ", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            MenuLiberarStrips();
        }

        private void dependenteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (contexto.Dependente.Count() > 0)
            {
                new UpdateGuest().Show();
            }
            else
            {
                MessageBox.Show("Não existem dependentes cadastrados. ", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void administradorToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (contexto.Cliente.Any(a => a.Tipo == 1 && a.Email != Secao.Administrador.Email))
            {
                new UpdateAdministrator().Show();
            }
            else
            {
                MessageBox.Show("Não existem outros administradores cadastrados. ", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void usuárioAtualToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new UpdateLoggedAdministrator().Show();
        }
    }
}
