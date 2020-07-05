using System;
using System.Windows.Forms;
using ConsumindoServico.ClienteServiceReference;

namespace ConsumindoServico
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            string nome = txtNome.Text;
            string cpf = txtCpf.Text;

            try
            {
                ClienteServiceClient servico = new ClienteServiceClient();
                Cliente clienteCadastro = new Cliente();
                clienteCadastro.Nome = nome;
                clienteCadastro.Cpf = cpf;

                servico.Add(clienteCadastro);

                MessageBox.Show("Cliente cadastrado com sucesso.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Falha ao cadastrar cliente.\n" + ex.Message);
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string nome = txtNome.Text;

            try
            {
                ClienteServiceClient servico = new ClienteServiceClient();
                Cliente resultado = servico.Buscar(nome);

                txtCpf.Text = resultado.Cpf;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Falha ao buscar cliente.\n" + ex.Message);
            }
        }
    }
}
