using MovieCheck.Administradores.Infra;
using MovieCheck.Administradores.Modeling;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace MovieCheck.Administradores.View
{
    public partial class AllowUser : Form
    {
        IList<Usuario> listaCliente;

        public AllowUser()
        {
            InitializeComponent();

            VerificarLista();
        }

        private void allow_Click(object sender, EventArgs e)
        {
            var usuarioCombo = (Usuario)ComboUsuarios.SelectedItem;
            using (var contexto = new MovieCheckContext())
            {
                var usuario = contexto.Usuario.Find(usuarioCombo.Id);
                usuario.ChangeStatus("allow");
                contexto.Usuario.Update(usuario);
                contexto.SaveChanges();
                MessageBox.Show("Usuário autorizado. ", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }

            VerificarLista();
        }

        private void block_Click(object sender, EventArgs e)
        {
            var usuarioCombo = (Usuario)ComboUsuarios.SelectedItem;
            using (var contexto = new MovieCheckContext())
            {
                var usuario = contexto.Usuario.Find(usuarioCombo.Id);
                usuario.ChangeStatus("deny");
                contexto.Usuario.Update(usuario);

                if (MessageBox.Show("Usuário bloqueado. Deseja excluí-lo?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    contexto.Usuario.Remove(usuario);
                    MessageBox.Show("Usuário excluído.", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    contexto.SaveChanges();
                }
                else
                { 
                    MessageBox.Show("Usuário bloqueado. É possível desbloqueá-lo no menu Usuário -> Desbloquear. ", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    contexto.SaveChanges();
                }
            }

            VerificarLista();
        }

        private void TrocarLabelNomeEmail()
        {
            var usuario = (Usuario) ComboUsuarios.SelectedItem;
            this.LabelNome.Text = usuario.Nome;
            this.LabelEmail.Text = usuario.Email;
        }

        private void VerificarLista()
        {
            using (var contexto = new MovieCheckContext())
            {
                this.listaCliente = contexto.Usuario.Where(u => u.Status == 0).ToList();
            }

            if (!listaCliente.Any(u => u.Status == 0))
            {
                MessageBox.Show("Não existem usuários a serem autorizados. ", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
            else
            {
                this.ComboUsuarios.DataSource = this.listaCliente;
                this.ComboUsuarios.DisplayMember = "Nome";
                TrocarLabelNomeEmail();
            }
        }
    }
}
