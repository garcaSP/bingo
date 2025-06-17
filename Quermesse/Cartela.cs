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
    public partial class Cartela : Form
    {
        Sorteador sorteador;
        public int id;
        int sorteados = 0;
        int[][] numeros;
        int[] escolhidos;
        int tamEscolhidos = 0;
        Label[][] posicoes;
        public Cartela(Sorteador sorteador, int id)
        {
            InitializeComponent();
            this.sorteador = sorteador;
            this.id = id;
            escolhidos = new int[25];
            numeros = new int[5][]
            {
                new int[5],
                new int[5],
                new int[5],
                new int[5],
                new int[5]
            };
            posicoes = new Label[5][]
            {
                new Label[5] {lbl1_1, lbl1_2, lbl1_3, lbl1_4, lbl1_5},
                new Label[5] {lbl2_1, lbl2_2, lbl2_3, lbl2_4, lbl2_5},
                new Label[5] {lbl3_1, lbl3_2, lbl3_3, lbl3_4, lbl3_5},
                new Label[5] {lbl4_1, lbl4_2, lbl4_3, lbl4_4, lbl4_5},
                new Label[5] {lbl5_1, lbl5_2, lbl5_3, lbl5_4, lbl5_5}
            };
            CriarCartela();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        void CriarCartela()
        {
            Random r = new Random();
            for(int i = 0; i < 5; i++)
            {
                for(int j = 0; j < 5; j++)
                {
                    if (!(i == j && i == 2))
                    {
                        int n = r.Next(1, 16) + i * 15;
                        while(Array.IndexOf(escolhidos, n) > -1)
                        {
                            n++;
                            if(n > (i+1) * 15)
                            {
                                n -= 15;
                            }
                        }
                        numeros[i][j] = n;

                        escolhidos[tamEscolhidos] = n;
                        tamEscolhidos++;

                        posicoes[i][j].Text = n.ToString();
                    }
                }
             }
        }

        public void ReceberNumero(int numero)
        {
            int i = (numero - 1) / 15;

            int j;
            for(j = 0; j < 5; j++)
            {
                if (numeros[i][j] == numero)
                {
                    posicoes[i][j].BackColor = Color.Green;
                    sorteados++;
                    
                    if(sorteados == 24)
                    {
                        lblVitória.Visible = true;
                        sorteador.AnunciarVitoria(this);
                    }
                }
            }
        }
    }
}
