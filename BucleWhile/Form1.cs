using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BucleWhile
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           // MessageBox.Show("Ingresa un numero al cuadro de texto");
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Presionaste el boton ingresar");
            int i = 1;
            while (i <= 10 && 3<9 && 76>89)
            {
                Random numero = new Random();
                int n = numero.Next(1, 100);

                ListViewItem fila = new ListViewItem(i.ToString());
                fila.SubItems.Add(n.ToString());
                lvResultado.Items.Add(fila);

                i++;
            }
            MessageBox.Show("Se generaron los numeros");
        }
    }
}
