using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atividade_3_avaliativa
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnValidar_Click(object sender, EventArgs e)
        {
            int dataNascimento = 0;
            string nome= "";
            string sobrenome= "";
            int anoAtual = int.Parse(DateTime.Now.ToString("yyyy"));
            

            if (txtNome.Text != "" && txtSobrenome.Text != "" && txtDataNascimento.Text != "")
            {
               nome= txtNome.Text;
                sobrenome= txtSobrenome.Text;
                dataNascimento = int.Parse(txtDataNascimento.Text);
            }
            int idadeAtual = anoAtual - dataNascimento;


            //Filtrando idade +18
            if (anoAtual - dataNascimento >= 18)
                // MOSTRANDO NOME + SOBRE NOME + IDADE
            {
                lblResultado1.Text = "Bem Vindo " + nome.ToUpper() + " " + sobrenome.ToUpper() + " Idade" + " " +  idadeAtual;
                // TROCANDO IMAGEM
                pibGaloCego.Image = Properties.Resources.f1;

            }
            else
            {
                lblResultado1.Text = "Acesso Negado";
                //TROCANDO IMAGEM
                pibGaloCego.Image = Properties.Resources.f2;
            }


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        // CRIANDO BOTÃO PARA LIMPAR A TELA (VOLTAR AO INICIO)
        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtNome.Text = null;
            txtSobrenome.Text = null;
            txtDataNascimento.Text = null;
            lblResultado1.Text = " ";

            pibGaloCego.Image = Properties.Resources.f0;
            
        }

        // botão para fechar o programa
        private void btnFECHAR_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
