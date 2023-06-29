using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pyControlesComunes_Variables
{
    public partial class frmLista : Form
    {
        public string[,] matrizTareas= new string[5,5];
        int indicefila, indiceColumna;
        public frmLista()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
         
        }

        private void frmLista_Load(object sender, EventArgs e)
        {
            indiceColumna = 0;
            indicefila = 0;

            while (indicefila < matrizTareas.GetLength(0))
            {
                dgvLista.Rows.Add(matrizTareas[indicefila, 0],
                    matrizTareas[indicefila, 1],
                    matrizTareas[indicefila, 2],
                    matrizTareas[indicefila, 3],
                    matrizTareas[indicefila, 4]);

                indicefila++;
            }
        }
    }
}
