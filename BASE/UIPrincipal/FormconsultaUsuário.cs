using BLL;
using System;
using System.Data;
using System.Windows.Forms;

namespace UIPrincipal
{
    public partial class FormconsultaUsuário : Form
    {
        public FormconsultaUsuário()
        {
            InitializeComponent();
        }//---------

        private void buttonSair_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        

        private void FormconsultaUsuário_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                Close();
            }
        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            UsuarioBLL usuarioBLL = new UsuarioBLL();
            usuarioBindingSource.DataSource =  usuarioBLL.Buscar(textBoxBuscar.Text);
        }

        private void textBoxBuscar_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonNovo_Click(object sender, EventArgs e)
        {
            using (FormCadastroUsuario frm = new FormCadastroUsuario())
            {
                frm.ShowDialog();
            }
        }

        private void buttonExcluir_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Deseja realmente excluir este registro?", "Ateção", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                return;
            }

            UsuarioBLL usuarioBLL = new UsuarioBLL();
            int id;
            id = Convert.ToInt32(((DataRowView)usuarioBindingSource.Current).Row["Id"]);
            usuarioBLL.Excluir(id);
            usuarioBindingSource.RemoveCurrent();

            MessageBox.Show("REGISTRO EXCLUIDO COM SUCESSO!");
        }

    }
}
