using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio5
{
    public partial class frmEj5 : Form
    {
        string[] aNombre = new string[10];
        double[] aPrecio = new double[10];
        double[] aCantidad = new double[10];
        double[] aTotal = new double[10];

        public frmEj5()
        {
            InitializeComponent();
        }

        private void frmEj5_Load(object sender, EventArgs e)
        {
            aNombre[0] = "Lápices";
            aPrecio[0] = 30;
            aCantidad[0] = 50;

            aNombre[1] = "Cartucheras";
            aPrecio[1] = 150;
            aCantidad[1] = 10;

            aNombre[2] = "Fibrones";
            aPrecio[2] = 50;
            aCantidad[2] = 40;

            aNombre[3] = "Hojas A4";
            aPrecio[3] = 10;
            aCantidad[3] = 500;

            aNombre[4] = "Mochilas";
            aPrecio[4] = 400;
            aCantidad[4] = 15;

            aNombre[5] = "Resaltador";
            aPrecio[5] = 70;
            aCantidad[5] = 50;

            aNombre[6] = "Lapicera Negra";
            aPrecio[6] = 40;
            aCantidad[6] = 150;

            aNombre[7] = "Cuadernos";
            aPrecio[7] = 60;
            aCantidad[7] = 60;

            aNombre[8] = "Goma de borrar";
            aPrecio[8] = 15;
            aCantidad[8] = 100;

            aNombre[9] = "Plasticola";
            aPrecio[9] = 100;
            aCantidad[9] = 30;

            for (int i = 0; i < 10; i++)
            {
                lstNombre.Items.Add(aNombre[i]);
                lstPrecio.Items.Add(aPrecio[i]);
                lstCantidad.Items.Add(aCantidad[i]);
            }

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            lstTotal.Items.Clear();
            double acu = 0;
            for (int i = 0; i < 10; i++)
            {
                aTotal[i] = aCantidad[i] * aPrecio[i];
                lstTotal.Items.Add(aTotal[i]);
                acu += aTotal[i];
            }
            txtTotal.Text = acu.ToString();
        }
    }
}
