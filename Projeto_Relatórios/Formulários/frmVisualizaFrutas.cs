﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_Relatórios.Formulários
{
    public partial class frmVisualizaFrutas : Form
    {
        public frmVisualizaFrutas()
        {
            InitializeComponent();
        }

        private void frmVisualizaFrutas_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'bdrelatoriosDataSet.tbfrutas'. Você pode movê-la ou removê-la conforme necessário.
            this.tbfrutasTableAdapter.Fill(this.bdrelatoriosDataSet.tbfrutas);

            this.reportViewer1.RefreshReport();
        }
    }
}
