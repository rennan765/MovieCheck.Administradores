using Microsoft.EntityFrameworkCore;
using MovieCheck.Administradores.Infra;
using MovieCheck.Administradores.Modeling;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace MovieCheck.Administradores.View
{
    public partial class DeleteGuest : Form
    {
        IList<Dependente> listaDependente;

        public DeleteGuest()
        {
            InitializeComponent();

            VerificarLista();
        }

        private void delete_Click(object sender, EventArgs e)
        {
            try
            {
                Excluir();
            }
            catch (DeleteUserFailedException exception)
            {
                MessageBox.Show(exception.Descricao, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            VerificarLista();
        }

        private void TrocarLabelNomeEmail(object sender, EventArgs e)
        {
            var dependente = (Dependente) ComboUsuarios.SelectedItem;
            this.LabelNome.Text = dependente.Nome;
            this.LabelEmail.Text = dependente.Email;
            this.LabelCliente.Text = dependente.Cliente.Nome;
        }

        private void VerificarLista()
        {
            using (var contexto = new MovieCheckContext())
            {
                this.listaDependente = contexto.Dependente.Include(d => d.Cliente).ToList();
            }

            if (this.listaDependente.Count > 0)
            {
                this.ComboUsuarios.DataSource = this.listaDependente;
                this.ComboUsuarios.DisplayMember = "Nome";
                TrocarLabelNomeEmail(null, null);
            }
            else
            {
                MessageBox.Show("Não existem dependentes cadastrados. ", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        private void Excluir()
        {
            var usuario = (Dependente)ComboUsuarios.SelectedItem;
            int id = usuario.Id;
            using (var contexto = new MovieCheckContext())
            {
                var dependente = contexto.Dependente.Find(id);

                if (!(dependente is null))
                {
                    if (MessageBox.Show("Deseja realmente excluir este dependente?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        contexto.Dependente.Remove(dependente);
                        contexto.SaveChanges();
                        MessageBox.Show("Dependente excluído com sucesso.", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    }
                    else
                    {
                        MessageBox.Show("O dependente não foi excluído.", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    }
                }
                else
                {
                    throw new DeleteUserFailedException("Dependente não encontrado.");
                }
            }
        }
    }
}
