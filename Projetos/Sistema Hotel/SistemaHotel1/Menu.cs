using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaHotel1 {
    public partial class FrmMenu : Form {
        public FrmMenu() {
            InitializeComponent();
        }

        private void FrmMenu_Resize(object sender, EventArgs e) 
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void SairToolStripMenuItem_Click(object sender, EventArgs e) {

        }

        private void LogoutToolStripMenuItem_Click(object sender, EventArgs e) 
        {
            Close();
        }

        private void FrmMenu_Load(object sender, EventArgs e) 
        {
            pnlTopo.BackColor = Color.FromArgb(12, 187, 188);
            pnlRight.BackColor = Color.FromArgb(105, 108, 111);
        
        }
        // adicionat a tela de funcinários
        // Cadastros = não está no mesmo diretório.
        // = para instanciar

        private void FuncionáriosToolStripMenuItem_Click(object sender, EventArgs e) 
        {
            Cadastros.FrmFuncionarios form = new Cadastros.FrmFuncionarios();
                form.Show();
        }
    } 
}
