﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.ServiceProcess;

namespace AdministradordeTareas
{
    public partial class Administrador_Tareas : Form
    {
        public Administrador_Tareas()
        {
            InitializeComponent();
            this.Size = new System.Drawing.Size(1050, 800);
            this.StartPosition = FormStartPosition.CenterScreen;
            ActualizarProcesos();
            progressBar1.Style = ProgressBarStyle.Marquee;
            progressBar1.Visible = false;
            GetWindowServices();
        }

        private void GetWindowServices()
        {
            //throw new NotImplementedException();
            ServiceController[] service;
            service = ServiceController.GetServices();
            comboBox1.Items.Clear();
            for(int i =0; i<service.Length; i++)
            {
                comboBox1.Items.Add(service[i].ServiceName);
            }
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
                ltbxDisco.Items.Add(item: iId + ":" + p.PrivateMemorySize64);
                ltbxMemoriaVirtual.Items.Add(item: iId + ":" + p.VirtualMemorySize64);
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
            ltbxMemoriaVirtual.Items.Clear();
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ltbxCPU_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            float fCPU = pcCPU.NextValue();
            float fRAM = pcRAM.NextValue();
            progressBarCPU.Value = (int)fCPU;
            progressBarRAM.Value = (int)fRAM;
            lblCPU.Text = string.Format("{0:0.00}%", fCPU);
            lblRAM.Text = string.Format("{0:0.00}%", fRAM);
            chart1.Series["CPU"].Points.AddY(fCPU);
            chart1.Series["RAM"].Points.AddY(fRAM);
        }

        private void tpRendimiento_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            var singleservice = new ServiceController((string)e.Argument);
            if((singleservice.Status.Equals(ServiceControllerStatus.Stopped))|| (singleservice.Status.Equals(ServiceControllerStatus.StopPending)))
            {
                singleservice.Start();
            }
            else
            {
                singleservice.Stop();
            }
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            //this.button1.Enabled = false;
            this.progressBar1.Visible = false;
            if(e.Error!=null)
            {
                MessageBox.Show(e.Error.ToString(), "No se puede iniciar el servicio");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.button1.Enabled = false;
            this.button2.Enabled = true;
            this.progressBar1.Visible = true;
            this.backgroundWorker1.RunWorkerAsync(comboBox1.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.button2.Enabled = false;
            this.button1.Enabled = true;
            this.progressBar1.Visible = true;
            this.backgroundWorker1.RunWorkerAsync(comboBox1.Text);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ServiceController singleservice = new ServiceController(comboBox1.Text);
            if ((singleservice.Status.Equals(ServiceControllerStatus.Stopped)) || (singleservice.Status.Equals(ServiceControllerStatus.StopPending)))
            {
                button2.Enabled = false;
                button1.Enabled = true;
            }
            else
            {
                button2.Enabled = true;
                button1.Enabled = false;
            }
        }
    }
}
