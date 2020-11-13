using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prj16_assistencia_tecnica
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCadCliente_Click(object sender, EventArgs e)
        {
            tlCadCliente cadCliente = new tlCadCliente();
            cadCliente.Show();
        }

        private void btnCadEquipamento_Click(object sender, EventArgs e)
        {
            tlCadEquipamento cadEquipamento = new tlCadEquipamento();
            cadEquipamento.Show();
        }

        private void btnCadServiço_Click(object sender, EventArgs e)
        {
            tlCadServico cadServico = new tlCadServico();
            cadServico.Show();
        }
    }
}
