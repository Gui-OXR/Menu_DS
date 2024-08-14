using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_Relatórios
{
    public partial class FrmInicializa : Form
    {
        public FrmInicializa()
        {
            InitializeComponent();
        }

        private void relatóriosFrutasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Formulários.frmVisualizaFrutas objVisualiza = new Formulários.frmVisualizaFrutas();
            objVisualiza.MdiParent = this;
            objVisualiza.Show();
        }
    }
}
