﻿using Microsoft.EntityFrameworkCore;
using MovieCheck.Administradores.Infra;
using MovieCheck.Administradores.Modeling;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace MovieCheck.Administradores.View
{
    public partial class UpdateUser : Form
    {
        public UpdateUser()
        {
            InitializeComponent();
            //PREPARA COMBO ESTADOS
            this.EnderecoEstado.DataSource = Secao.Estados;
            this.EnderecoEstado.DisplayMember = "NomeCompleto";
            //PREPARA COMBO USUÁRIOS
            PreparaComboUsuarios();
            InicializarCampos();
        }

        private void CadastrarUsuario_Click(object sender, EventArgs e)
        {
            string mensagem;
            Telefone fixoAntigo = null;
            Telefone fixoNovo = null;
            Telefone celularAntigo = null;
            Telefone celularNovo = null;
            try
            {
                using (var contexto = new MovieCheckContext())
                {
                    var cliente = EditarCliente();

                    fixoAntigo = cliente.ObterTelefoneFixo();
                    celularAntigo = cliente.ObterTelefoneCelular();

                    if (!(fixoAntigo is null))
                    {
                        if (this.DddFixo.Text.ToString() != string.Empty)
                        {
                            fixoNovo = CadastroUsuario.TrataTelefone(0, Convert.ToInt32(this.DddFixo.Text.ToString()), this.TelefoneFixo.Text.ToString());
                            cliente.AdicionarTelefone(fixoNovo);
                        }
                        else
                        {
                            cliente.RemoverTelefone(fixoAntigo);
                        }
                    }
                    else
                    {
                        if (this.DddFixo.Text.ToString() != string.Empty)
                        {
                            fixoNovo = CadastroUsuario.TrataTelefone(0, Convert.ToInt32(this.DddFixo.Text.ToString()), this.TelefoneFixo.Text.ToString());
                            cliente.AdicionarTelefone(fixoNovo);
                        }
                    }

                    if (!(celularAntigo is null))
                    {
                        if (this.DddCelular.Text.ToString() != string.Empty)
                        {
                            celularNovo = CadastroUsuario.TrataTelefone(1, Convert.ToInt32(this.DddCelular.Text.ToString()), this.TelefoneCelular.Text.ToString());
                            cliente.RemoverTelefone(celularAntigo);
                            cliente.AdicionarTelefone(celularNovo);
                        }
                        else
                        {
                            cliente.RemoverTelefone(celularAntigo);
                        }
                    }
                    else
                    {
                        if (this.DddCelular.Text.ToString() != string.Empty)
                        {
                            celularNovo = CadastroUsuario.TrataTelefone(1, Convert.ToInt32(this.DddCelular.Text.ToString()), this.TelefoneCelular.Text.ToString());
                            cliente.AdicionarTelefone(celularNovo);
                        }
                    }

                    contexto.Cliente.Update(cliente);
                    contexto.SaveChanges();

                    mensagem = "Usuário atualizado com sucesso.";

                    MessageBox.Show(mensagem, "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
            }
            catch (NewUserFailedException exception)
            {
                MessageBox.Show(exception.Desricao, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            PreparaComboUsuarios();
            InicializarCampos();
        }

        private IList<string> CamposVazios()
        {
            IList<string> listaCampo = new List<string>();

            if (this.Nome.Text.ToString() == string.Empty)
            {
                listaCampo.Add("Nome");
            }
            if (this.Email.Text.ToString() == string.Empty)
            {
                listaCampo.Add("E -mail");
            }
            if (this.Cpf.Text.ToString() == string.Empty)
            {
                listaCampo.Add("CPF");
            }
            if (this.EnderecoRua.Text.ToString() == string.Empty)
            {
                listaCampo.Add("Endereço - Rua");
            }
            if (this.EnderecoNumero.Text.ToString() == string.Empty)
            {
                listaCampo.Add("Endereço - Número");
            }
            if (this.EnderecoCidade.Text.ToString() == string.Empty)
            {
                listaCampo.Add("Endereço - Bairro");
            }
            if (this.EnderecoBairro.Text.ToString() == string.Empty)
            {
                listaCampo.Add("Endereço - Rua");
            }
            if (this.EnderecoCep.Text.ToString() == string.Empty)
            {
                listaCampo.Add("Endereço - CEP");
            }
            //if (this.Senha.Text.ToString() == string.Empty)
            //{
            //    listaCampo.Add("Senha");
            //}
            //if (this.SenhaConfirma.Text.ToString() == string.Empty)
            //{
            //    listaCampo.Add("Confirmação de senha");
            //}

            return listaCampo;

        }

        private Cliente EditarCliente()
        {
            //VERIFICA CAMPOS
            IList<string> listaCampo = CamposVazios();
            string mensagem = "";

            //VERIFICA CAMPOS
            if (listaCampo.Count == 0)
            {
                //VERIFICA E-MAIL
                if (Cliente.IsEmail(this.Email.Text.ToString()))
                {
                    //VERIFICA SE CPF É NUMÉRICO
                    if (Usuario.IsNumeric(this.Cpf.Text.ToString()))
                    {
                        //VERIFICA SE O CEP É NUMÉRICO
                        if (Endereco.IsNumeric(this.EnderecoCep.Text.ToString()))
                        {
                            //VERIFICA SE O NÚMERO É NUMÉRICO
                            if (Endereco.IsNumeric(this.EnderecoNumero.Text.ToString()))
                            {
                                var cliente = (Cliente)ComboUsuarios.SelectedItem;
                                cliente.Email = this.Email.Text.ToString();
                                cliente.AlterarEndereco(new Endereco() {
                                    Logradouro = this.EnderecoRua.Text.ToString(),
                                    Numero = Convert.ToInt32(this.EnderecoNumero.Text.ToString()),
                                    Complemento = this.EnderecoComplemento.Text.ToString(),
                                    Bairro = this.EnderecoBairro.Text.ToString(),
                                    Cidade = this.EnderecoCidade.Text.ToString(),
                                    Estado = this.EnderecoEstado.SelectedItem.ToString(),
                                    Cep = this.EnderecoCep.Text.ToString()
                                });
                                cliente.Cpf = this.Cpf.Text.ToString();

                                if (this.CheckSenha.Checked)
                                {
                                    CadastroUsuario.ValidaSenha(this.Senha.Text.ToString(), this.SenhaConfirma.Text.ToString());
                                    cliente.CadastrarSenha(this.Senha.Text.ToString());
                                }
                                
                                VerificaEmailCpf(cliente);

                                return cliente;
                            }
                            else
                            {
                                mensagem = "Existem caracteres não numéricos no número do endereço. ";
                                throw new NewUserFailedException(mensagem);
                            }
                        }
                        else
                        {
                            mensagem = "Existem caracteres não numéricos no CEP. ";
                            throw new NewUserFailedException(mensagem);
                        }
                    }
                    else
                    {
                        mensagem = "Existem caracteres não numéricos no CPF. ";
                        throw new NewUserFailedException(mensagem);
                    }
                }
                else
                {
                    mensagem = "Verificar: " + this.Email.Text.ToString() + " não é um e-mail válido. ";
                    throw new NewUserFailedException(mensagem);
                }
            }
            else
            {
                mensagem = "Os seguintes campos estão em branco: \n";
                foreach (string campo in listaCampo)
                {
                    mensagem += campo + "\n";
                }
                throw new NewUserFailedException(mensagem);
            }
        }

        private void VerificaEmailCpf(Cliente cliente)
        {
            using (var contexto = new MovieCheckContext())
            {
                if (contexto.Cliente.Any(c => c.Cpf != cliente.Cpf && c.Email == cliente.Email))
                {
                    throw new NewUserFailedException("Já existe um usuário com este e-mail cadastrado.");
                }
            }
        }

        private void InicializarCampos()
        {
            Cliente u = (Cliente)ComboUsuarios.SelectedItem;
            Telefone fixo = u.ObterTelefoneFixo();
            Telefone celular = u.ObterTelefoneCelular();

            this.Nome.Text = u.Nome;
            this.Email.Text = u.Email;
            this.Cpf.Text = u.Cpf;
            this.DddFixo.Text = (!(fixo is null) ? fixo.Ddd.ToString() : "");
            this.TelefoneFixo.Text = (!(fixo is null) ? fixo.Numero : "");
            this.DddCelular.Text = (!(celular is null) ? celular.Ddd.ToString() : "");
            this.TelefoneCelular.Text = (!(celular is null) ? celular.Numero : "");
            this.EnderecoRua.Text = u.Endereco.Logradouro;
            this.EnderecoNumero.Text = u.Endereco.Numero.ToString();
            this.EnderecoComplemento.Text = (!(u.Endereco.Complemento is null) ? u.Endereco.Complemento : "");
            this.EnderecoBairro.Text = u.Endereco.Bairro;
            this.EnderecoCidade.Text = u.Endereco.Cidade;
            this.EnderecoCep.Text = u.Endereco.Cep;
            if (!(u.Endereco is null))
            {
                this.EnderecoEstado.SelectedItem = Secao.Estados.Where(e => e.NomeAbreviado == u.Endereco.Estado).FirstOrDefault();
            }
        }

        private void AlterarCampos(object sender, EventArgs e)
        {
            Cliente u = (Cliente)ComboUsuarios.SelectedItem;
            Telefone fixo = u.ObterTelefoneFixo();
            Telefone celular = u.ObterTelefoneCelular();

            this.Nome.Text = u.Nome;
            this.Email.Text = u.Email;
            this.Cpf.Text = u.Cpf;
            this.DddFixo.Text = (!(fixo is null) ? fixo.Ddd.ToString() : "");
            this.TelefoneFixo.Text = (!(fixo is null) ? fixo.Numero : "");
            this.DddCelular.Text = (!(celular is null) ? celular.Ddd.ToString() : "");
            this.TelefoneCelular.Text = (!(celular is null) ? celular.Numero : "");
            this.EnderecoRua.Text = u.Endereco.Logradouro;
            this.EnderecoNumero.Text = u.Endereco.Numero.ToString();
            this.EnderecoComplemento.Text = (!(u.Endereco.Complemento is null) ? u.Endereco.Complemento : "");
            this.EnderecoBairro.Text = u.Endereco.Bairro;
            this.EnderecoCidade.Text = u.Endereco.Cidade;
            this.EnderecoCep.Text = u.Endereco.Cep;
            this.EnderecoEstado.SelectedItem = Secao.Estados.Where(est => est.NomeAbreviado == u.Endereco.Estado).FirstOrDefault();
        }

        private void CheckAlterarSenha(object sender, EventArgs e)
        {
            if (this.CheckSenha.Checked)
            {
                this.Senha.Enabled = true;
                this.SenhaConfirma.Enabled = true;
            }
            else
            {
                this.Senha.Enabled = false;
                this.SenhaConfirma.Enabled = false;
            }
        }

        private void PreparaComboUsuarios()
        {
            using (var contexto = new MovieCheckContext())
            {
                this.ComboUsuarios.DataSource = contexto.Cliente
                    .Include(ut => ut.Telefones)
                    .ThenInclude(t => t.Telefone)
                    .Include(e => e.Endereco)
                    .Where(c => c.Tipo == 0)
                    .ToList();
                this.ComboUsuarios.DisplayMember = "Nome";
            }
            
        }
    }
}
