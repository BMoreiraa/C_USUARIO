using BLL;
using MODEL;
using System;
using System.Windows.Forms;

namespace UIPrincipal
{
    public partial class FormCadastroUsuario : Form
    {
        public FormCadastroUsuario()
        {
            InitializeComponent();
            usuarioBindingSource.AddNew();
            
        }
        private void inserir()
        {
            UsuarioBLL usuarioBLL = new UsuarioBLL();
            Usuario usuario = new Usuario();
            usuario.Id = Convert.ToInt32(idTextBox.Text);
            usuario.Nome = nomeTextBox.Text;
            usuario.Senha = senhaTextBox.Text;
            usuario.Ativo = ativoCheckBox.Checked;
            usuarioBLL.Inserir(usuario);

        }// GERADO AO CRIAR inserir();  

        private void button1_Click(object sender, EventArgs e) //salvar
        {
            try
            {
                usuarioBindingSource.EndEdit();
                inserir();
                MessageBox.Show("Cadastro realizado com sucesso!");
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(" Ocorreu um erro: " + ex.Message);

            }
        }//BOTÃO DE SALVAR COM MESSAGEM DE SUCESSO OU DE ERRO AO SALVAR

        private void buttonSair_Click(object sender, EventArgs e)
        {
            Close();

        }//BOTÃO DE SAI 

        

        private void buttonCadastraNovo_Click_1(object sender, EventArgs e)
        {
            usuarioBindingSource.EndEdit();
            inserir();
            MessageBox.Show("Cadastro realizado com sucesso!");
            usuarioBindingSource.AddNew();
            nomeTextBox.Focus();
        }


    }
}//UIPRINCIPAL 
 //LOCAL PARA ORGANIZAR AS FUNÇÕES DOS BOTÕES