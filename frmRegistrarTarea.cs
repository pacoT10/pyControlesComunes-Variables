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
    public partial class frmRegistrarTarea : Form
    {
        public frmRegistrarTarea()
        {
            InitializeComponent();
        }

        //zona de declaracion global para el formulario
        readonly int indiceRegistro = 0;
        frmLista lista = new frmLista();
        
        int indiceFilaR;
        

        private void frmRegistrarTarea_Load(object sender, EventArgs e)
        {
            cboTareas.Items.Add("Tarea 1");
            cboTareas.Items.Add("Tarea 2");
            cboTareas.Items.Add("Tarea 3");
            cboTareas.Items.Add("Tarea 4");
            cboTareas.Items.Add("Tarea 5");
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            string varTareas = "";
            string varReunion = "";
            if (dtpFecha.Value >= DateTime.Today)
            {
                
                if (cboTipoActividad.SelectedIndex != -1)
                {
                    
                    if (txtDetalle.Text != "")
                    {
                        MessageBox.Show("Vamos a grabar...");


                        if (optSI.Checked == true)
                        {
                            varReunion = "Si";
                        }
                        else
                        {
                            varReunion = "No";
                        }
                        if (chkDebate.Checked)
                        {
                            varTareas = "Debate, ";
                        }
                        if (chkInvestigacion.Checked)
                        {
                            varTareas = varTareas + "Investigacion, ";
                        }
                        if (chkNotasReunion.Checked)
                        {
                            varTareas = varTareas + "Notas, ";

                        }
                        if (chkrepositorio.Checked)
                        {
                            varTareas = varTareas + "Repositorio, ";
                        }

                        lista.matrizTareas[indiceFilaR, 0] = dtpFecha.Value.ToString();
                        lista.matrizTareas[indiceFilaR,1] = cboTipoActividad.Text;
                        lista.matrizTareas[indiceFilaR,2] = txtDetalle.Text;
                        lista.matrizTareas[indiceFilaR, 3] = varReunion;
                        lista.matrizTareas[indiceFilaR,4] = varTareas;

                        indiceFilaR++;

                        if (indiceFilaR==lista.matrizTareas.GetLength(0))
                        {
                            cmdGrabar.Enabled = false;
                        }
                        
                    }
                    else
                    {
                        MessageBox.Show("te falta completa el detalle...");
                        txtDetalle.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("Seleccione una actividad...");
                    cboTipoActividad.Focus();
                }
            }
            else
            {
                MessageBox.Show("Seleccione una fecha actual o posterior a la de hoy", "Carga de Tarea",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                
                dtpFecha.Value = DateTime.Today;
                dtpFecha.Focus();
            }
        }

        private void cmdMostrar_Click(object sender, EventArgs e)
        {
            lista.ShowDialog();
            this.Hide();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {

        }
    }

}
