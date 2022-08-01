using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projeto_perimetro_retangulo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //variáveis
            double b, h, area;

            b = double.Parse(VALORBASE.Text);
            h = double.Parse(VALORALTURA.Text);
            //proscessamento
            area = b * h;

            resultadoarea.Text = area.ToString();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            double b, h, perimetro;

            b = double.Parse(VALORBASE.Text);
            h = double.Parse (VALORALTURA.Text);    
            perimetro = 2 * (b + h);

            resultadoperimetro.Text = perimetro.ToString();





        }
    }
}
