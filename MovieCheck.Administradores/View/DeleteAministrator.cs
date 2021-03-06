﻿using Microsoft.EntityFrameworkCore;
using MovieCheck.Administradores.Infra;
using MovieCheck.Administradores.Modeling;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace MovieCheck.Administradores.View
{
    public partial class DeleteAdministrator : Form
    {
        IList<Cliente> listaCliente;

        public DeleteAdministrator()
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
            var usuario = (Cliente) ComboUsuarios.SelectedItem;
            this.LabelNome.Text = usuario.Nome;
            this.LabelEmail.Text = usuario.Email;
        }

        private void VerificarLista()
        {
            using (var contexto = new MovieCheckContext())
            {
                this.listaCliente = contexto.Cliente.Where(u => u.Tipo == 1 && u.Email != Secao.Administrador.Email).ToList();
            }

            if (this.listaCliente.Any(u => u.Tipo == 1))
            {
                this.ComboUsuarios.DataSource = this.listaCliente;
                this.ComboUsuarios.DisplayMember = "Nome";
                TrocarLabelNomeEmail(null, null);
            }
            else
            {
                MessageBox.Show("Não existem administradores cadastrados. ", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        private void Excluir()
        {
            var usuario = (Cliente)ComboUsuarios.SelectedItem;
            int id = usuario.Id;
            using (var contexto = new MovieCheckContext())
            {
                if (contexto.Cliente.Any(u => u.Id == id))
                {
                    var administrador = contexto.Cliente.Include(a => a.Dependentes).Where(a => a.Id == id).FirstOrDefault();
                    if (administrador.Dependentes.Count > 0)
                    {
                        if (MessageBox.Show("Este administrador possui dependentes e todos eles também serão excluídos. \nDeseja realmente excluir este administrador?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            foreach (var dependente in administrador.Dependentes)
                            {
                                contexto.Dependente.Remove(dependente);
                            }
                            contexto.Cliente.Remove(administrador);
                            contexto.SaveChanges();
                            MessageBox.Show("Administrador e seus dependentes excluídos com sucesso.", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        }
                        else
                        {
                            MessageBox.Show("O administrador não foi excluído.", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        }
                    }
                    else
                    {
                        if (MessageBox.Show("Deseja realmente excluir este administrador?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            contexto.Cliente.Remove(administrador);
                            contexto.SaveChanges();
                            MessageBox.Show("Administrador excluído com sucesso.", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        }
                        else
                        {
                            MessageBox.Show("O administrador não foi excluído.", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        }
                            
                    }
                }
                else
                {
                    throw new DeleteUserFailedException("Administrador não encontrado.");
                }   
            }
        }
    }
}
