using MovieCheck.Administradores.Infra;
using MovieCheck.Administradores.Modeling;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace MovieCheck.Administradores.View
{
    public partial class UnlockUser : Form
    {
        IList<Usuario> listaCliente;

        public UnlockUser()
        {
            InitializeComponent();

            VerificarLista();
        }

        private void unlock_Click(object sender, EventArgs e)
        {
            try
            {
                Desbloquear();
            }
            catch (LockFailedException exception)
            {
                MessageBox.Show(exception.Descricao, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            VerificarLista();
        }

        private void TrocarLabelNomeEmail()
        {
            var usuario = (Usuario)ComboUsuarios.SelectedItem;
            this.LabelNome.Text = usuario.Nome;
            this.LabelEmail.Text = usuario.Email;
        }

        private void VerificarLista()
        {
            using (var contexto = new MovieCheckContext())
            {
                this.listaCliente = contexto.Usuario.Where(u => u.Status == 2 && u.Email != Secao.Administrador.Email).ToList();
            }

            if (!listaCliente.Any(u => u.Status == 2))
            {
                MessageBox.Show("Não existem usuários bloqueados. ", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            var usuario = (Usuario)ComboUsuarios.SelectedItem;
            this.LabelNome.Text = usuario.Nome;
            this.LabelEmail.Text = usuario.Email;
        }

        private void Desbloquear()
        {
            var usuarioCombo = (Usuario)ComboUsuarios.SelectedItem;
            int id = usuarioCombo.Id;
            using (var contexto = new MovieCheckContext())
            {
                if (contexto.Usuario.Any(u => u.Id == id))
                {
                    var usuario = contexto.Usuario.Find(id);
                    usuario.ChangeStatus();
                    contexto.Usuario.Update(usuario);
                    MessageBox.Show("Usuário desbloqueado.", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
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
