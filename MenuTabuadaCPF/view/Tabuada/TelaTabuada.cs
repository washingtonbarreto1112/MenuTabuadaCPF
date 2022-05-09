using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MenuTabuadaCPF.view.Tabuada
{
    public partial class TelaTabuada : Form
    {
        public TelaTabuada()
        {
            InitializeComponent();
        }

        private void CalcularTabuada()
        {
            int numero = 0;

            numero = Convert.ToInt32 (tbNumero.Text);

            for (int i = 0; i < 11; i++)
            {
                lbxResultado.Items.Add(numero + " x " + i + " = " + i * numero);
            }
            lbxResultado.Focus();
            
            
        }
        private void LimparTela()
        {
            lbxResultado.Items.Clear();
        }


        private void tbNumero_KeyPress(object sender, KeyPressEventArgs e)
        
        {
            if (e.KeyChar == 13)
            {
                lbxResultado.Items.Clear();
                CalcularTabuada();
            }
        }
    }
}
