using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Loja_Top
{
    public partial class frmLoadLoja : Form
    {
        public frmLoadLoja()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void lblTime_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //incrementando progressbar e exibindo a porcentagem no label
            pgbLoading.Increment(1);
            lblTime.Text = pgbLoading.Value.ToString() + "%";

            //Desenvolvendo um if o progress bar no caso pgbLoading, chegar em 100% oq irá acontecer,
            // que no caso seria a exibição de uma caixa de texto exibindo carregamento e em seguida,
            //apos clicar Ok na mensagem irá abrir o programa em si.

            if (pgbLoading.Value == 100)
            {
                timer1.Stop();
                MessageBox.Show("Programa Carregado com Sucesso");
                this.Hide();
                frmLojaBike LojaBike = new frmLojaBike();
                LojaBike.Show();

                

            }

        }
    }
}
