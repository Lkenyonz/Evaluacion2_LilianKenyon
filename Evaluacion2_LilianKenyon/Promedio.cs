using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Evaluacion2_LilianKenyon
{
    public partial class Promedio : Form
    {
        public Promedio()
        {
            InitializeComponent();
        }

        private void Calcubutton1_Click(object sender, EventArgs e)
        {
            promedio Lilian = new promedio();
            Lilian.Nombre = NomtextBox1.Text;
            Lilian.Numerodecuenta = Convert.ToInt32(numcuentatextBox1.Text);
            Lilian.Nota1= Convert.ToInt32(nota1textBox1.Text);
            Lilian.Nota2 = Convert.ToInt32(nota2textBox2.Text);
            Lilian.Nota3 = Convert.ToInt32(nota3textBox3.Text);
            Lilian.Nota4 = Convert.ToInt32(nota4textBox4.Text);

            MessageBox.Show(Lilian.devolverpromedio());

        }
    }
}
