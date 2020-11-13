using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lojaSenac
{
    public partial class tlMenu : Form
    {
        public tlMenu()
        {
            InitializeComponent();
        }

        private void tlMenu_Load(object sender, EventArgs e)
        {
            stripUsuario.Text = dados.Usuario;
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void funcionáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tlFuncionario funcionario = new tlFuncionario();
            funcionario.Show();
        }

        private void produtosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tlCursos cursos = new tlCursos();
            cursos.Show();
        }
    }
}
