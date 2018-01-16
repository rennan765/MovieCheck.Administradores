using MovieCheck.Administradores.Infra;
using MovieCheck.Administradores.Modeling;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace MovieCheck.Administradores.View
{
    public partial class BlockUser : Form
    {
        IList<Usuario> listaCliente;

        public BlockUser()
        {
            InitializeComponent();

            VerificarLista();
        }

        private void block_Click(object sender, EventArgs e)
        {
            try
            {
                Bloquear();
            }
            catch (LockFailedException exception)
            {
                MessageBox.Show(exception.Descricao, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            VerificarLista();
        }
        
        private void VerificarLista()
        {
            using (var contexto = new MovieCheckContext())
            {
                this.listaCliente = contexto.Usuario.Where(u => u.Status == 1 && u.Email != Secao.Administrador.Email).ToList();
            }

            if (!listaCliente.Any(u => u.Status == 1))
            {
                MessageBox.Show("Não existem usuários desbloqueados. ", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
            else
            {
                this.ComboUsuarios.DataSource = this.listaCliente;
                this.ComboUsuarios.DisplayMember = "Nome";
                TrocarLabelNomeEmail(null, null);
            }
        }

        private void TrocarLabelNomeEmail(object sender, EventArgs e)
        {
            var usuario = (Usuario) ComboUsuarios.SelectedItem;
            this.LabelNome.Text = usuario.Nome;
            this.LabelEmail.Text = usuario.Email;
        }

        private void Bloquear()
        {
            var usuarioCombo = (Usuario) ComboUsuarios.SelectedItem;
            using (var contexto = new MovieCheckContext())
            {
                if (contexto.Usuario.Any(u => u.Id == usuarioCombo.Id))
                {
                    var usuario = contexto.Usuario.Find(usuarioCombo.Id);
                    usuario.ChangeStatus();
                    contexto.Usuario.Update(usuario);
                    MessageBox.Show("Usuário bloqueado.", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    contexto.SaveChanges();
                }
                else
                {
                    throw new LockFailedException("Usuário não encontrado. ");
                }
            }
        }
    }
}
