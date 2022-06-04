using BLL;
using MODEL;
using System;
using System.Windows.Forms;

namespace UIPrincipal
{
    public partial class FormCadastroUsuario : Form
    {
        private bool inserindoNovo;

        public FormCadastroUsuario()
        {
            InitializeComponent();
            usuarioBindingSource.AddNew();
            inserindoNovo = true;
        }

        public FormCadastroUsuario(object _current)
        {
            InitializeComponent();
            usuarioBindingSource.DataSource = _current;
            inserindoNovo = false;
        }

        private void inserir()
        {
            UsuarioBLL usuarioBLL = new UsuarioBLL();
            Usuario usuario = new Usuario();

            usuario.Id = Convert.ToInt32(idTextBox.Text);
            usuario.NomeUsuario = nomeTextBox.Text;
            usuario.Senha = senhaTextBox.Text;
            usuario.Ativo = ativoCheckBox.Checked;

            if (inserindoNovo )        
                usuarioBLL.Inserir(usuario);
            else
                usuarioBLL.Alterar(usuario);

        }// GERADO AO CRIAR inserir();  

        private void button1_Click(object sender, EventArgs e) //salvar
        {
            try
            {
                usuarioBindingSource.EndEdit();
                inserir();
                if (inserindoNovo)          
                    MessageBox.Show("Cadastro realizado com sucesso!");
                else
                    MessageBox.Show("alteração feita com sucesso!");
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
            usuarioBindingSource.DataSource = typeof(Usuario);
            usuarioBindingSource.AddNew();
            inserindoNovo = true;
            nomeTextBox.Focus();
        }

        private void FormCadastroUsuario_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                Close();
            }
        }

        private void FormCadastroUsuario_Load(object sender, EventArgs e)
        {

        }
    }
}//UIPRINCIPAL 
 //LOCAL PARA ORGANIZAR AS FUNÇÕES DOS BOTÕES