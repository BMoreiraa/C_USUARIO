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
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                usuarioBindingSource.EndEdit();
                inserir();
                MessageBox.Show("Cadastro realizado com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(" Ocorreu um erro: " + ex.Message);

            }
        }//BOTÃO DE SALVAR COM MESSAGEM DE SUCESSO OU DE ERRO AO SALVAR

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

        private void FormCadastroUsuario_Load(object sender, EventArgs e)
        {

        }
        private void buttonSair_Click(object sender, EventArgs e)
        {
            Close();
        }//BOTÃO DE SAI 
    }
}//UIPRINCIPAL 
 //LOCAL PARA ORGANIZAR AS FUNÇÕES DOS BOTÕES