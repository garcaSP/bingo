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
    public partial class Sorteador : Form
    {
        Form anterior;
        Cartela[] cartelas;

        int qtd;
        bool[] sorteados;
        public Sorteador(Form anterior, int qtd)
        {
            InitializeComponent();
            this.anterior = anterior;
            this.qtd = qtd;
            sorteados = new bool[76];
            for(int i = 0; i < sorteados.Length; i++)
            {
                sorteados[i] = false;
            }
            cartelas = new Cartela[qtd];

            for (int i = 0; i < qtd; i++)
            {
                // Aqui a resenha dos papáveis é instaurada
                cartelas[i] = new Cartela(this, i);
                cartelas[i].Show();

            }
        }

        private void btProximo_Click(object sender, EventArgs e)
        {
            Random r = new Random();
            int num;
            do
            {
                num = r.Next(1, 76);
            } while (sorteados[num]);
            sorteados[num] = true;

            foreach (Cartela cartela in cartelas)
                cartela.ReceberNumero(num);

            lblNumero.Text = num.ToString();
        }

        

        public void AnunciarVitoria(Cartela cartela)
        {
            foreach(Cartela c in cartelas)
            {
                if(c != cartela)
                {
                    c.Close();
                }
                cartela.Focus();
                btProximo.Enabled = false;
            }
        }

        private void btHistorico_Click(object sender, EventArgs e)
        {
            FormHistorico f = new FormHistorico(sorteados);
            f.ShowDialog();
        }

        private void Sorteador_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r = MessageBox.Show("Deseja encerrar esse sorteio?",
                "Sorteador", MessageBoxButtons.YesNo);
            if (r == DialogResult.Yes)
            { 
                foreach (Cartela cartela in cartelas)
                    cartela.Close();
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
