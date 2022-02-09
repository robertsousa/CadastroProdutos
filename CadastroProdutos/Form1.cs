using CadastroProdutos.Forms;

namespace CadastroProdutos
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void menuSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void produtosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var forms = this.MdiChildren.Where(f => f.Name.Contains("FormCadastroProdutos"));
            FormCadastroProdutos frm = (FormCadastroProdutos)forms.FirstOrDefault();

            if(frm == null)
                frm = new FormCadastroProdutos();
            frm.MdiParent = this;
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();

        }
    }
}