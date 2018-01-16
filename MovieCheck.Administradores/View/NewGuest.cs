using Microsoft.EntityFrameworkCore;
using MovieCheck.Administradores.Infra;
using MovieCheck.Administradores.Modeling;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace MovieCheck.Administradores.View
{
    public partial class NewGuest : Form
    {
        public NewGuest()
        {
            InitializeComponent();
            //PREPARA COMBO ESTADOS
            this.EnderecoEstado.DataSource = Secao.Estados;
            this.EnderecoEstado.DisplayMember = "NomeCompleto";
            //PREPARA COMBO CLIENTES
            PreparaComboClientes();
        }

        private void CadastrarUsuario_Click(object sender, EventArgs e)
        {
            try
            {
                string mensagem;

                using (var contexto = new MovieCheckContext())
                {
                    var dependente = NovoDependente();
                    var cliente = ClienteResponsavel();

                    //VERIFICA TELEFONE FIXO
                    if (this.DddFixo.Text.ToString() != string.Empty)
                    {
                        var fixoNovo = CadastroUsuario.TrataTelefone(0, Convert.ToInt32(this.DddFixo.Text.ToString()), this.TelefoneFixo.Text.ToString());
                        if (contexto.Telefone.Any(t => t.Tipo == 0 && t.Ddd == fixoNovo.Ddd && t.Numero == fixoNovo.Numero))
                        {
                            dependente.AdicionarTelefone(contexto.Telefone.Where(t => t.Tipo == 0 && t.Ddd == fixoNovo.Ddd && t.Numero == fixoNovo.Numero).FirstOrDefault());
                        }
                        else
                        {
                            dependente.AdicionarTelefone(fixoNovo);
                        }
                    }

                    //VERIFICA TELEFONE CELULAR
                    if (this.DddCelular.Text.ToString() != string.Empty)
                    {
                        var celularNovo = CadastroUsuario.TrataTelefone(1, Convert.ToInt32(this.DddCelular.Text.ToString()), this.TelefoneCelular.Text.ToString());
                        if (contexto.Telefone.Any(t => t.Tipo == 1 && t.Ddd == celularNovo.Ddd && t.Numero == celularNovo.Numero))
                        {
                            dependente.AdicionarTelefone(contexto.Telefone.Where(t => t.Tipo == 1 && t.Ddd == celularNovo.Ddd && t.Numero == celularNovo.Numero).FirstOrDefault());
                        }
                        else
                        {
                            dependente.AdicionarTelefone(celularNovo);
                        }
                    }

                    cliente.Dependentes.Add(dependente);

                    contexto.Dependente.Add(dependente);
                    contexto.Cliente.Update(cliente);

                    contexto.SaveChanges();

                    if (dependente.Status == 0)
                    {
                        mensagem = "Novo dependente cadastrado com sucesso, aguardando autorização.";
                    }
                    else
                    {
                        mensagem = "Novo dependente cadastrado e autorizado com sucesso.";
                    }

                    MessageBox.Show(mensagem, "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
            }
            catch (NewUserFailedException exception)
            {
                MessageBox.Show(exception.Desricao, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
            //if (this.Cpf.Text.ToString() == string.Empty)
            //{
            //    listaCampo.Add("CPF");
            //}
            //if (this.EnderecoRua.Text.ToString() == string.Empty)
            //{
            //    listaCampo.Add("Endereço - Rua");
            //}
            //if (this.EnderecoNumero.Text.ToString() == string.Empty)
            //{
            //    listaCampo.Add("Endereço - Número");
            //}
            //if (this.EnderecoCidade.Text.ToString() == string.Empty)
            //{
            //    listaCampo.Add("Endereço - Bairro");
            //}
            //if (this.EnderecoBairro.Text.ToString() == string.Empty)
            //{
            //    listaCampo.Add("Endereço - Rua");
            //}
            //if (this.EnderecoCep.Text.ToString() == string.Empty)
            //{
            //    listaCampo.Add("Endereço - CEP");
            //}
            if (this.Senha.Text.ToString() == string.Empty)
            {
                listaCampo.Add("Senha");
            }
            if (this.SenhaConfirma.Text.ToString() == string.Empty)
            {
                listaCampo.Add("Confirmação de senha");
            }

            return listaCampo;

        }

        private Dependente NovoDependente()
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
                    //VERIFICA SE O CEP É NUMÉRICO
                    if (Endereco.IsNumeric(this.EnderecoCep.Text.ToString()))
                    {
                        //VERIFICA SE O NÚMERO É NUMÉRICO
                        if (Endereco.IsNumeric(this.EnderecoNumero.Text.ToString()))
                        {
                            var dependente = new Dependente()
                            {
                                Email = this.Email.Text.ToString(),
                                Nome = this.Nome.Text.ToString(),
                                Status = 0
                            };
                            dependente.CadastrarSenha(this.Senha.Text.ToString());
                            if (this.Autorizar.Checked)
                            {
                                dependente.ChangeStatus("allow");
                            }
                            if (this.EnderecoRua.Text.ToString() != string.Empty && this.EnderecoNumero.Text.ToString() != string.Empty && this.EnderecoBairro.Text.ToString() != string.Empty && this.EnderecoCidade.Text.ToString() != string.Empty && this.EnderecoCep.Text.ToString() != string.Empty)
                            {
                                dependente.Endereco = new Endereco()
                                {
                                    Logradouro = this.EnderecoRua.Text.ToString(),
                                    Numero = Convert.ToInt32(this.EnderecoNumero.Text.ToString()),
                                    Complemento = this.EnderecoComplemento.Text.ToString(),
                                    Bairro = this.EnderecoBairro.Text.ToString(),
                                    Cidade = this.EnderecoCidade.Text.ToString(),
                                    Estado = this.EnderecoEstado.SelectedItem.ToString(),
                                    Cep = this.EnderecoCep.Text.ToString()
                                };
                            }

                            CadastroUsuario.ValidaSenha(this.Senha.Text.ToString(), this.SenhaConfirma.Text.ToString());
                            VerificaEmail(dependente.Email);

                            return dependente;
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

        private void PreparaComboClientes()
        {
            using (var contexto = new MovieCheckContext())
            {
                this.ComboClientes.DataSource = contexto.Cliente.Where(c => (c.Tipo == 0 || c.Tipo == 1) && c.Status == 1).ToList();
                this.ComboClientes.DisplayMember = "Nome";
                this.ComboClientes.ValueMember = "Id";
            }
        }

        private Cliente ClienteResponsavel()
        {
            return (Cliente)ComboClientes.SelectedItem;
        }

        private void VerificaEmail(string email)
        {
            using (var contexto = new MovieCheckContext())
            {
                if (contexto.Usuario.Any(u => u.Email == email))
                {
                    throw new NewUserFailedException("Já existe um usuário com este e-mail cadastrado.");
                }
            }
        }
    }
}
