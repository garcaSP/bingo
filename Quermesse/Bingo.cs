using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quermesse
{
    public partial class Bingo : System.Windows.Forms.Form
    {
        public Bingo()
        {
            InitializeComponent();
        }

        private void btIniciar_Click(object sender, EventArgs e)
        {
            decimal qtd = numQtd.Value;
            DialogResult r = MessageBox.Show($"Deseja Inicar o bingo com {qtd} cartelas?", 
            "Bingo", MessageBoxButtons.YesNo);

            if(r == DialogResult.Yes)
            {
                Sorteador f = new Sorteador(this, (int) qtd);
                f.Show();
                this.Hide();
            }
        }
    }
}
