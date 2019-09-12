using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaSena
{
    public partial class frmPrincipal : Form
    {
        int[] sorteado = new int[6];
        int[] tabela = new int[6];
        int Acertos;
        public frmPrincipal()
        {
            InitializeComponent();
        }
        private void Limpar()
        {
            Acertos = 0;
            btnJogardenovo.Enabled = false;
            btnJogardenovo.Visible = false;
            txtNome.Clear();
            txtN1.Clear();
            txtN2.Clear();
            txtN3.Clear();
            txtN4.Clear();
            txtN5.Clear();
            txtN6.Clear();
            for (int i = 0; i < tabela.Length; i++)
            {
                tabela[i] = 0;
            }
            for (int j = 0; j < sorteado.Length; j++)
            {
                sorteado[j] = 0;
            }

        }     
        private void Resultados()
        {
            if (Acertos == 4)
            {
                MessageBox.Show("Parabéns " +txtNome.Text+ " você acertou 4, mas ganhou pouco dinheiro\n Os Números sorteados foram: " + sorteado[0]+ ", " + sorteado[1]+ ", " + sorteado[2] +", " + sorteado[3]+ ", " + sorteado[4]+", " + sorteado[5]);
            }
            else if (Acertos == 5)
                    {
                MessageBox.Show("Parabéns " + txtNome.Text + " você acertou 5, quero um churrasco\n Os Números sorteados foram: " + sorteado[0] + ", " + sorteado[1] + ", " + sorteado[2] + ", " + sorteado[3] + ", " + sorteado[4] + ", " + sorteado[5]);
            }
            else if (Acertos == 6)
            {
                MessageBox.Show("Parabéns " +txtNome.Text+ " você acertou 6, você esta rico! Quero um carro!\n Os Números sorteados foram: " + sorteado[0] + ", " + sorteado[1] + ", " + sorteado[2] + ", " + sorteado[3] + ", " + sorteado[4] + ", " + sorteado[5]);
            }
            else
            {
                MessageBox.Show(txtNome.Text + " você acertou " + Acertos + " número(s), e não ganhou nada!\n Os Números sorteados foram: " + sorteado[0] + ", " + sorteado[1] + ", " + sorteado[2] + ", " + sorteado[3] + ", " + sorteado[4] + ", " + sorteado[5]);
            }
            btnJogardenovo.Visible = true;
            btnJogardenovo.Enabled = true;
        }
        private void Verificar()
        {
            for (int i = 0; i < sorteado.Length; i++) //ACERTAR AQUI
            {
                for (int j = 0; j < tabela.Length; j++)
                {
                   
                    if (sorteado[i] == tabela[j])
                    {
                        Acertos++;
                    }
                }
            }
            Resultados();
        }
        private bool NumeroIgual()
        {
            for (int i = 1; i < tabela.Length; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    if (tabela[i] == tabela[j])
                    {
                        return true;
                    }
                }
            }
            return false;
        }        
        private void Sortear(bool Nivel)
        {
            Random oRND = new Random();
            bool repetiraleat;
            if (Nivel == true)
            {

                for (int i = 0; i < sorteado.Length; i++)
                {
                    do
                    {
                        repetiraleat = false;
                        sorteado[i] = oRND.Next(1, 31);

                            for (int j = 0; j < i; j++)
                            {
                                if (sorteado[i] == sorteado[j])
                                {
                                    repetiraleat = true;
                                }
                            }
                    } while (repetiraleat);

                }
            }
            else
            {
                for (int i = 0; i < sorteado.Length; i++)
                {
                    do
                    {
                        repetiraleat = false;
                        sorteado[i] = oRND.Next(1, 61);

                        for (int j = 0; j < i; j++)
                        {
                            if (sorteado[i] == sorteado[j])
                            {
                                repetiraleat = true;
                            }
                        }
                    } while (repetiraleat);

                }
            }                
            }
        private void NumMax()
        {
            tabela[0] = Convert.ToInt32(txtN1.Text);
            tabela[1] = Convert.ToInt32(txtN2.Text);
            tabela[2] = Convert.ToInt32(txtN3.Text);
            tabela[3] = Convert.ToInt32(txtN4.Text);
            tabela[4] = Convert.ToInt32(txtN5.Text);
            tabela[5] = Convert.ToInt32(txtN6.Text);

            if (NumeroIgual())
            {
                MessageBox.Show("Não Digite números iguais");
            }
            else
            {

                if (rbtnN1.Checked == true)
                {
                    int repetir = 0;
                    for (int i = 0; i < 6; i++)
                    {
                        if (tabela[i] > 0 && tabela[i] <= 30) // ARRUMAR AQUI
                        {
                            Sortear(rbtnN1.Checked);
                        }
                        else
                        {
                            repetir++;
                        }

                    }
                    if (repetir != 0)
                    {
                        MessageBox.Show("Não digite números abaixo de 1 e acima de 30");
                    }
                }
                else
                {
                    int repetir = 0;
                    for (int i = 0; i < 6; i++)
                    {
                        if (tabela[i] > 0 && tabela[i] <= 60)
                        {
                            Sortear(rbtnN2.Checked = false);
                        }
                        else
                        {
                            repetir++;
                        }
                        if (repetir != 0)
                        {
                            MessageBox.Show("Não digite números abaixo e acima de 60");
                        }
                      
                    }

                }
                Verificar();
            }
            
        }
        private void txtN_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }
        private void btnSort_Click(object sender, EventArgs e)
        {            
            if(txtNome.Text == "")
            {
                MessageBox.Show("Digite seu nome!");
            }
            else
            {
                NumMax();
            }
        }
        private void btnJogardenovo_Click(object sender, EventArgs e)
        {
            Limpar();
        } 
    }
}
