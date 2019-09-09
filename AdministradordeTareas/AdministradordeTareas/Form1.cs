using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
namespace AdministradordeTareas
{
    public partial class Administrador_Tareas : Form
    {
        public Administrador_Tareas()
        {
            InitializeComponent();
            this.Size = new System.Drawing.Size(1050, 600);
            this.StartPosition = FormStartPosition.CenterScreen;
            ActualizarProcesos();
        }
        Process[] procesos;
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void ltbxRed_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void ActualizarProcesos()
        {
            LimpiarContenedores();
            int iId = 1;
            procesos = Process.GetProcesses();
            foreach (Process p in procesos)
            {
                PerformanceCounter theCPUCounter = new PerformanceCounter("Process", "% Processor Time", p.ProcessName);
                ltbxProcesos.Items.Add(iId + ":" + p.ProcessName);
                ltbxCPU.Items.Add(iId + ":" + p.SessionId);
                ltbxMemoria.Items.Add(item: iId + ":" + p.WorkingSet64);
                iId++;
            }

        }
        private void FinalizarTarea()
        {
            try
            {
                procesos[ltbxProcesos.SelectedIndex].Kill();
                ActualizarProcesos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void LimpiarContenedores()
        {
            ltbxCPU.Items.Clear();
            ltbxDisco.Items.Clear();
            ltbxMemoria.Items.Clear();
            ltbxProcesos.Items.Clear();
            ltbxRed.Items.Clear();
        }

        private void btnFinTarea_Click(object sender, EventArgs e)
        {
            FinalizarTarea();
        }

        private void nuevaTareaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using(NuevaTarea frm=new NuevaTarea())
            {
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    ActualizarProcesos();
                }
            }
        }
    }
}
