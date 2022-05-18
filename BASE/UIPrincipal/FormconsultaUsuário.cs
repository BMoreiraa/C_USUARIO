using System;
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

        private void buttonNovo_Click(object sender, EventArgs e)
        {
            using (FormCadastroUsuario frm = new FormCadastroUsuario())
            {
                frm.ShowDialog();
            }
        }

        private void FormconsultaUsuário_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                Close();
            }
        }

    }
}
