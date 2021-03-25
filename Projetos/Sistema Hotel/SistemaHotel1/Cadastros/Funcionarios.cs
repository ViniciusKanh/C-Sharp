using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaHotel1.Cadastros {
    public partial class FrmFuncionarios : Form {
        public FrmFuncionarios() 
        {
            InitializeComponent();
        }


        private void HabilitarCampos () 
        {
            TxtNome.Enabled = true;
            TxtCPF.Enabled = true;
            TxtEndereco.Enabled = true;
            CbCargo.Enabled = true;
            TxtTelefone.Enabled = true;
        }

        private void DesabilitarCampos() 
        {
            TxtNome.Enabled = false;
            TxtCPF.Enabled = false;
            TxtEndereco.Enabled = false;
            CbCargo.Enabled = false;
            TxtTelefone.Enabled = false;
        }
        // Text -> recebe o texto em vazio ""
        private void LimparCampos() 
        {
            TxtNome.Text = "";
            TxtCPF.Text = "";
            TxtEndereco.Text = "";
            CbCargo.Text = "";
            TxtTelefone.Text = "";
        }

        private void FrmFuncionarios_Load(object sender, EventArgs e) 
        {

        }


   
    }
}

