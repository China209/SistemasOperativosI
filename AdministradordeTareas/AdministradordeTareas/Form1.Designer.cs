﻿using System;

namespace AdministradordeTareas
{
    partial class Administrador_Tareas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend6 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series11 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series12 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Administrador_Tareas));
            this.pcRAM = new System.Diagnostics.PerformanceCounter();
            this.pcCPU = new System.Diagnostics.PerformanceCounter();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.tpServicios = new System.Windows.Forms.TabPage();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tpDetalles = new System.Windows.Forms.TabPage();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tpUsuarios = new System.Windows.Forms.TabPage();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.tpRendimiento = new System.Windows.Forms.TabPage();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.lblRAM = new System.Windows.Forms.Label();
            this.lblCPU = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.progressBarRAM = new System.Windows.Forms.ProgressBar();
            this.label7 = new System.Windows.Forms.Label();
            this.progressBarCPU = new System.Windows.Forms.ProgressBar();
            this.tpProcesos = new System.Windows.Forms.TabPage();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnFinTarea = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ltbxDisco = new System.Windows.Forms.ListBox();
            this.ltbxMemoriaVirtual = new System.Windows.Forms.ListBox();
            this.ltbxMemoria = new System.Windows.Forms.ListBox();
            this.ltbxCPU = new System.Windows.Forms.ListBox();
            this.ltbxProcesos = new System.Windows.Forms.ListBox();
            this.tabTaskManager = new System.Windows.Forms.TabControl();
            this.barra = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.iconoad = new System.Windows.Forms.PictureBox();
            this.cerrar = new System.Windows.Forms.PictureBox();
            this.minimizar = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pcRAM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcCPU)).BeginInit();
            this.tpServicios.SuspendLayout();
            this.tpDetalles.SuspendLayout();
            this.tpUsuarios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.tpRendimiento.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.tpProcesos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabTaskManager.SuspendLayout();
            this.barra.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconoad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            this.SuspendLayout();
            // 
            // pcRAM
            // 
            this.pcRAM.CategoryName = "Memory";
            this.pcRAM.CounterName = "% Committed Bytes In Use";
            // 
            // pcCPU
            // 
            this.pcCPU.CategoryName = "Processor";
            this.pcCPU.CounterName = "% Processor Time";
            this.pcCPU.InstanceName = "_Total";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // tpServicios
            // 
            this.tpServicios.BackColor = System.Drawing.Color.DarkSlateGray;
            this.tpServicios.Controls.Add(this.pictureBox7);
            this.tpServicios.Controls.Add(this.progressBar1);
            this.tpServicios.Controls.Add(this.button2);
            this.tpServicios.Controls.Add(this.button1);
            this.tpServicios.Controls.Add(this.comboBox1);
            this.tpServicios.Controls.Add(this.label9);
            this.tpServicios.ForeColor = System.Drawing.Color.OrangeRed;
            this.tpServicios.Location = new System.Drawing.Point(4, 31);
            this.tpServicios.Margin = new System.Windows.Forms.Padding(2);
            this.tpServicios.Name = "tpServicios";
            this.tpServicios.Padding = new System.Windows.Forms.Padding(2);
            this.tpServicios.Size = new System.Drawing.Size(988, 559);
            this.tpServicios.TabIndex = 6;
            this.tpServicios.Text = "Servicios";
            this.tpServicios.Click += new System.EventHandler(this.tpServicios_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(478, 331);
            this.progressBar1.Margin = new System.Windows.Forms.Padding(2);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(423, 66);
            this.progressBar1.TabIndex = 4;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.LightCoral;
            this.button2.Font = new System.Drawing.Font("Segoe UI Black", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.MistyRose;
            this.button2.Location = new System.Drawing.Point(497, 208);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(176, 68);
            this.button2.TabIndex = 3;
            this.button2.Text = "DETENER";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightCoral;
            this.button1.Font = new System.Drawing.Font("Segoe UI Black", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.MistyRose;
            this.button1.Location = new System.Drawing.Point(707, 208);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(158, 68);
            this.button1.TabIndex = 2;
            this.button1.Text = "INICIAR\r\n";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Segoe UI Black", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.ForeColor = System.Drawing.Color.LightSalmon;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(707, 110);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(179, 25);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI Black", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.LightCoral;
            this.label9.Location = new System.Drawing.Point(430, 105);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(273, 30);
            this.label9.TabIndex = 0;
            this.label9.Text = "SERVICIOS DE WINDOWS";
            // 
            // tpDetalles
            // 
            this.tpDetalles.BackColor = System.Drawing.Color.DarkSlateGray;
            this.tpDetalles.Controls.Add(this.button5);
            this.tpDetalles.Controls.Add(this.button4);
            this.tpDetalles.Controls.Add(this.button3);
            this.tpDetalles.Controls.Add(this.listBox1);
            this.tpDetalles.Controls.Add(this.label10);
            this.tpDetalles.ForeColor = System.Drawing.Color.Snow;
            this.tpDetalles.Location = new System.Drawing.Point(4, 31);
            this.tpDetalles.Margin = new System.Windows.Forms.Padding(2);
            this.tpDetalles.Name = "tpDetalles";
            this.tpDetalles.Padding = new System.Windows.Forms.Padding(2);
            this.tpDetalles.Size = new System.Drawing.Size(988, 559);
            this.tpDetalles.TabIndex = 5;
            this.tpDetalles.Text = "Detalles";
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Salmon;
            this.button5.Font = new System.Drawing.Font("Segoe UI Black", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(646, 342);
            this.button5.Margin = new System.Windows.Forms.Padding(2);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(217, 71);
            this.button5.TabIndex = 4;
            this.button5.Text = "Eliminar Proceso\r\n";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Salmon;
            this.button4.Font = new System.Drawing.Font("Segoe UI Black", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(646, 117);
            this.button4.Margin = new System.Windows.Forms.Padding(2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(217, 72);
            this.button4.TabIndex = 3;
            this.button4.Text = "Obtener Proceso\r\n";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Salmon;
            this.button3.Font = new System.Drawing.Font("Segoe UI Black", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(646, 225);
            this.button3.Margin = new System.Windows.Forms.Padding(2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(217, 69);
            this.button3.TabIndex = 2;
            this.button3.Text = "Detalles";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Segoe UI Black", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 25;
            this.listBox1.Location = new System.Drawing.Point(171, 81);
            this.listBox1.Margin = new System.Windows.Forms.Padding(2);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(376, 379);
            this.listBox1.TabIndex = 1;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI Black", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Salmon;
            this.label10.Location = new System.Drawing.Point(310, 27);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(129, 40);
            this.label10.TabIndex = 0;
            this.label10.Text = "Proceso";
            // 
            // tpUsuarios
            // 
            this.tpUsuarios.BackColor = System.Drawing.Color.DarkSlateGray;
            this.tpUsuarios.Controls.Add(this.pictureBox6);
            this.tpUsuarios.Controls.Add(this.listBox2);
            this.tpUsuarios.Location = new System.Drawing.Point(4, 31);
            this.tpUsuarios.Margin = new System.Windows.Forms.Padding(2);
            this.tpUsuarios.Name = "tpUsuarios";
            this.tpUsuarios.Padding = new System.Windows.Forms.Padding(2);
            this.tpUsuarios.Size = new System.Drawing.Size(988, 559);
            this.tpUsuarios.TabIndex = 4;
            this.tpUsuarios.Text = "Usuarios";
            this.tpUsuarios.Click += new System.EventHandler(this.tpUsuarios_Click);
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(579, 71);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(338, 404);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox6.TabIndex = 1;
            this.pictureBox6.TabStop = false;
            // 
            // listBox2
            // 
            this.listBox2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.listBox2.Font = new System.Drawing.Font("Segoe UI Black", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox2.ForeColor = System.Drawing.Color.Crimson;
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 25;
            this.listBox2.Location = new System.Drawing.Point(86, 71);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(411, 404);
            this.listBox2.TabIndex = 0;
            // 
            // tpRendimiento
            // 
            this.tpRendimiento.BackColor = System.Drawing.Color.DarkSlateGray;
            this.tpRendimiento.Controls.Add(this.chart1);
            this.tpRendimiento.Controls.Add(this.lblRAM);
            this.tpRendimiento.Controls.Add(this.lblCPU);
            this.tpRendimiento.Controls.Add(this.label8);
            this.tpRendimiento.Controls.Add(this.progressBarRAM);
            this.tpRendimiento.Controls.Add(this.label7);
            this.tpRendimiento.Controls.Add(this.progressBarCPU);
            this.tpRendimiento.Location = new System.Drawing.Point(4, 31);
            this.tpRendimiento.Margin = new System.Windows.Forms.Padding(2);
            this.tpRendimiento.Name = "tpRendimiento";
            this.tpRendimiento.Padding = new System.Windows.Forms.Padding(2);
            this.tpRendimiento.Size = new System.Drawing.Size(988, 559);
            this.tpRendimiento.TabIndex = 1;
            this.tpRendimiento.Text = "Rendimiento";
            this.tpRendimiento.Click += new System.EventHandler(this.tpRendimiento_Click);
            // 
            // chart1
            // 
            this.chart1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chart1.BackColor = System.Drawing.Color.LightCoral;
            this.chart1.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.DiagonalLeft;
            this.chart1.BackSecondaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.chart1.BorderlineColor = System.Drawing.Color.Gray;
            this.chart1.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            this.chart1.BorderlineWidth = 0;
            chartArea6.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea6);
            legend6.Name = "Legend1";
            this.chart1.Legends.Add(legend6);
            this.chart1.Location = new System.Drawing.Point(241, 218);
            this.chart1.Margin = new System.Windows.Forms.Padding(2);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Fire;
            this.chart1.PaletteCustomColors = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))))};
            series11.ChartArea = "ChartArea1";
            series11.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series11.Legend = "Legend1";
            series11.Name = "CPU";
            series12.ChartArea = "ChartArea1";
            series12.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series12.Legend = "Legend1";
            series12.Name = "RAM";
            this.chart1.Series.Add(series11);
            this.chart1.Series.Add(series12);
            this.chart1.Size = new System.Drawing.Size(542, 292);
            this.chart1.TabIndex = 6;
            this.chart1.Click += new System.EventHandler(this.chart1_Click);
            // 
            // lblRAM
            // 
            this.lblRAM.AutoSize = true;
            this.lblRAM.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRAM.ForeColor = System.Drawing.Color.Crimson;
            this.lblRAM.Location = new System.Drawing.Point(689, 132);
            this.lblRAM.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRAM.Name = "lblRAM";
            this.lblRAM.Size = new System.Drawing.Size(39, 25);
            this.lblRAM.TabIndex = 5;
            this.lblRAM.Text = "0%";
            // 
            // lblCPU
            // 
            this.lblCPU.AutoSize = true;
            this.lblCPU.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCPU.ForeColor = System.Drawing.Color.Yellow;
            this.lblCPU.Location = new System.Drawing.Point(689, 54);
            this.lblCPU.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCPU.Name = "lblCPU";
            this.lblCPU.Size = new System.Drawing.Size(39, 25);
            this.lblCPU.TabIndex = 4;
            this.lblCPU.Text = "0%";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Black", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Crimson;
            this.label8.Location = new System.Drawing.Point(257, 132);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 25);
            this.label8.TabIndex = 3;
            this.label8.Text = "RAM";
            // 
            // progressBarRAM
            // 
            this.progressBarRAM.Location = new System.Drawing.Point(329, 123);
            this.progressBarRAM.Margin = new System.Windows.Forms.Padding(2);
            this.progressBarRAM.Name = "progressBarRAM";
            this.progressBarRAM.Size = new System.Drawing.Size(326, 50);
            this.progressBarRAM.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Black", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Gold;
            this.label7.Location = new System.Drawing.Point(257, 54);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 25);
            this.label7.TabIndex = 1;
            this.label7.Text = "CPU";
            // 
            // progressBarCPU
            // 
            this.progressBarCPU.Location = new System.Drawing.Point(329, 45);
            this.progressBarCPU.Margin = new System.Windows.Forms.Padding(2);
            this.progressBarCPU.Name = "progressBarCPU";
            this.progressBarCPU.Size = new System.Drawing.Size(326, 50);
            this.progressBarCPU.TabIndex = 0;
            // 
            // tpProcesos
            // 
            this.tpProcesos.BackColor = System.Drawing.Color.DarkSlateGray;
            this.tpProcesos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tpProcesos.Controls.Add(this.pictureBox5);
            this.tpProcesos.Controls.Add(this.pictureBox4);
            this.tpProcesos.Controls.Add(this.pictureBox3);
            this.tpProcesos.Controls.Add(this.pictureBox2);
            this.tpProcesos.Controls.Add(this.pictureBox1);
            this.tpProcesos.Controls.Add(this.label6);
            this.tpProcesos.Controls.Add(this.btnFinTarea);
            this.tpProcesos.Controls.Add(this.label5);
            this.tpProcesos.Controls.Add(this.label4);
            this.tpProcesos.Controls.Add(this.label3);
            this.tpProcesos.Controls.Add(this.label2);
            this.tpProcesos.Controls.Add(this.label1);
            this.tpProcesos.Controls.Add(this.ltbxDisco);
            this.tpProcesos.Controls.Add(this.ltbxMemoriaVirtual);
            this.tpProcesos.Controls.Add(this.ltbxMemoria);
            this.tpProcesos.Controls.Add(this.ltbxCPU);
            this.tpProcesos.Controls.Add(this.ltbxProcesos);
            this.tpProcesos.ImeMode = System.Windows.Forms.ImeMode.KatakanaHalf;
            this.tpProcesos.Location = new System.Drawing.Point(4, 31);
            this.tpProcesos.Margin = new System.Windows.Forms.Padding(2);
            this.tpProcesos.Name = "tpProcesos";
            this.tpProcesos.Padding = new System.Windows.Forms.Padding(2);
            this.tpProcesos.Size = new System.Drawing.Size(988, 559);
            this.tpProcesos.TabIndex = 0;
            this.tpProcesos.Text = "Procesos";
            this.tpProcesos.Click += new System.EventHandler(this.tpProcesos_Click);
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox5.BackgroundImage")));
            this.pictureBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox5.Location = new System.Drawing.Point(834, 63);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(95, 70);
            this.pictureBox5.TabIndex = 27;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox4.BackgroundImage")));
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox4.Location = new System.Drawing.Point(637, 63);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(95, 70);
            this.pictureBox4.TabIndex = 26;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox3.BackgroundImage")));
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox3.Location = new System.Drawing.Point(432, 63);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(95, 70);
            this.pictureBox3.TabIndex = 25;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox2.Location = new System.Drawing.Point(256, 63);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(95, 70);
            this.pictureBox2.TabIndex = 24;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Location = new System.Drawing.Point(57, 63);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(95, 70);
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Black", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label6.Image = ((System.Drawing.Image)(resources.GetObject("label6.Image")));
            this.label6.Location = new System.Drawing.Point(305, 34);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 25);
            this.label6.TabIndex = 22;
            // 
            // btnFinTarea
            // 
            this.btnFinTarea.BackColor = System.Drawing.Color.DarkOrange;
            this.btnFinTarea.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFinTarea.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFinTarea.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinTarea.Location = new System.Drawing.Point(420, 495);
            this.btnFinTarea.Margin = new System.Windows.Forms.Padding(2);
            this.btnFinTarea.Name = "btnFinTarea";
            this.btnFinTarea.Size = new System.Drawing.Size(177, 42);
            this.btnFinTarea.TabIndex = 21;
            this.btnFinTarea.Text = "Finalizar Tarea";
            this.btnFinTarea.UseVisualStyleBackColor = false;
            this.btnFinTarea.Click += new System.EventHandler(this.btnFinTarea_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Black", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.Location = new System.Drawing.Point(802, 34);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(166, 25);
            this.label5.TabIndex = 19;
            this.label5.Text = "Memoria Virtual";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Black", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(647, 35);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 25);
            this.label4.TabIndex = 18;
            this.label4.Text = "Disco";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Black", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(430, 35);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 25);
            this.label3.TabIndex = 17;
            this.label3.Text = "Memoria";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Black", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(274, 34);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 25);
            this.label2.TabIndex = 16;
            this.label2.Text = "CPU";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Black", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(60, 34);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 25);
            this.label1.TabIndex = 15;
            this.label1.Text = "Procesos";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // ltbxDisco
            // 
            this.ltbxDisco.BackColor = System.Drawing.Color.LightSalmon;
            this.ltbxDisco.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ltbxDisco.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.ltbxDisco.FormattingEnabled = true;
            this.ltbxDisco.ItemHeight = 21;
            this.ltbxDisco.Location = new System.Drawing.Point(594, 145);
            this.ltbxDisco.Margin = new System.Windows.Forms.Padding(2);
            this.ltbxDisco.Name = "ltbxDisco";
            this.ltbxDisco.Size = new System.Drawing.Size(177, 340);
            this.ltbxDisco.TabIndex = 14;
            // 
            // ltbxMemoriaVirtual
            // 
            this.ltbxMemoriaVirtual.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ltbxMemoriaVirtual.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ltbxMemoriaVirtual.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.ltbxMemoriaVirtual.FormattingEnabled = true;
            this.ltbxMemoriaVirtual.ItemHeight = 21;
            this.ltbxMemoriaVirtual.Location = new System.Drawing.Point(788, 145);
            this.ltbxMemoriaVirtual.Margin = new System.Windows.Forms.Padding(2);
            this.ltbxMemoriaVirtual.Name = "ltbxMemoriaVirtual";
            this.ltbxMemoriaVirtual.Size = new System.Drawing.Size(177, 340);
            this.ltbxMemoriaVirtual.TabIndex = 13;
            // 
            // ltbxMemoria
            // 
            this.ltbxMemoria.BackColor = System.Drawing.Color.Thistle;
            this.ltbxMemoria.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ltbxMemoria.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.ltbxMemoria.FormattingEnabled = true;
            this.ltbxMemoria.ItemHeight = 21;
            this.ltbxMemoria.Location = new System.Drawing.Point(402, 145);
            this.ltbxMemoria.Margin = new System.Windows.Forms.Padding(2);
            this.ltbxMemoria.Name = "ltbxMemoria";
            this.ltbxMemoria.Size = new System.Drawing.Size(177, 340);
            this.ltbxMemoria.TabIndex = 12;
            // 
            // ltbxCPU
            // 
            this.ltbxCPU.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ltbxCPU.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ltbxCPU.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.ltbxCPU.FormattingEnabled = true;
            this.ltbxCPU.ItemHeight = 21;
            this.ltbxCPU.Location = new System.Drawing.Point(210, 145);
            this.ltbxCPU.Margin = new System.Windows.Forms.Padding(2);
            this.ltbxCPU.Name = "ltbxCPU";
            this.ltbxCPU.Size = new System.Drawing.Size(177, 340);
            this.ltbxCPU.TabIndex = 11;
            this.ltbxCPU.SelectedIndexChanged += new System.EventHandler(this.ltbxCPU_SelectedIndexChanged);
            // 
            // ltbxProcesos
            // 
            this.ltbxProcesos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ltbxProcesos.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ltbxProcesos.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.ltbxProcesos.FormattingEnabled = true;
            this.ltbxProcesos.ItemHeight = 21;
            this.ltbxProcesos.Location = new System.Drawing.Point(19, 145);
            this.ltbxProcesos.Margin = new System.Windows.Forms.Padding(2);
            this.ltbxProcesos.Name = "ltbxProcesos";
            this.ltbxProcesos.Size = new System.Drawing.Size(177, 340);
            this.ltbxProcesos.TabIndex = 10;
            // 
            // tabTaskManager
            // 
            this.tabTaskManager.AllowDrop = true;
            this.tabTaskManager.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tabTaskManager.Controls.Add(this.tpProcesos);
            this.tabTaskManager.Controls.Add(this.tpRendimiento);
            this.tabTaskManager.Controls.Add(this.tpUsuarios);
            this.tabTaskManager.Controls.Add(this.tpDetalles);
            this.tabTaskManager.Controls.Add(this.tpServicios);
            this.tabTaskManager.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabTaskManager.Location = new System.Drawing.Point(27, 102);
            this.tabTaskManager.Margin = new System.Windows.Forms.Padding(2);
            this.tabTaskManager.Multiline = true;
            this.tabTaskManager.Name = "tabTaskManager";
            this.tabTaskManager.SelectedIndex = 0;
            this.tabTaskManager.Size = new System.Drawing.Size(996, 594);
            this.tabTaskManager.TabIndex = 0;
            // 
            // barra
            // 
            this.barra.BackColor = System.Drawing.Color.DodgerBlue;
            this.barra.Controls.Add(this.label11);
            this.barra.Controls.Add(this.iconoad);
            this.barra.Controls.Add(this.cerrar);
            this.barra.Controls.Add(this.minimizar);
            this.barra.Location = new System.Drawing.Point(0, 1);
            this.barra.Name = "barra";
            this.barra.Size = new System.Drawing.Size(1055, 53);
            this.barra.TabIndex = 1;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(382, 13);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(288, 25);
            this.label11.TabIndex = 4;
            this.label11.Text = "ADMINISTRADOR DE TAREAS";
            // 
            // iconoad
            // 
            this.iconoad.Image = ((System.Drawing.Image)(resources.GetObject("iconoad.Image")));
            this.iconoad.InitialImage = ((System.Drawing.Image)(resources.GetObject("iconoad.InitialImage")));
            this.iconoad.Location = new System.Drawing.Point(12, 3);
            this.iconoad.Name = "iconoad";
            this.iconoad.Size = new System.Drawing.Size(60, 47);
            this.iconoad.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.iconoad.TabIndex = 3;
            this.iconoad.TabStop = false;
            // 
            // cerrar
            // 
            this.cerrar.Image = ((System.Drawing.Image)(resources.GetObject("cerrar.Image")));
            this.cerrar.InitialImage = ((System.Drawing.Image)(resources.GetObject("cerrar.InitialImage")));
            this.cerrar.Location = new System.Drawing.Point(1012, 8);
            this.cerrar.Name = "cerrar";
            this.cerrar.Size = new System.Drawing.Size(30, 30);
            this.cerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cerrar.TabIndex = 1;
            this.cerrar.TabStop = false;
            this.cerrar.Click += new System.EventHandler(this.cerrar_Click);
            // 
            // minimizar
            // 
            this.minimizar.Image = ((System.Drawing.Image)(resources.GetObject("minimizar.Image")));
            this.minimizar.InitialImage = ((System.Drawing.Image)(resources.GetObject("minimizar.InitialImage")));
            this.minimizar.Location = new System.Drawing.Point(976, 8);
            this.minimizar.Name = "minimizar";
            this.minimizar.Size = new System.Drawing.Size(30, 30);
            this.minimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.minimizar.TabIndex = 0;
            this.minimizar.TabStop = false;
            this.minimizar.Click += new System.EventHandler(this.minimizar_Click);
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox7.Image")));
            this.pictureBox7.Location = new System.Drawing.Point(65, 92);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(338, 404);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox7.TabIndex = 5;
            this.pictureBox7.TabStop = false;
            // 
            // Administrador_Tareas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(1054, 678);
            this.Controls.Add(this.tabTaskManager);
            this.Controls.Add(this.barra);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Administrador_Tareas";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Administrador de Tareas";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pcRAM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcCPU)).EndInit();
            this.tpServicios.ResumeLayout(false);
            this.tpServicios.PerformLayout();
            this.tpDetalles.ResumeLayout(false);
            this.tpDetalles.PerformLayout();
            this.tpUsuarios.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.tpRendimiento.ResumeLayout(false);
            this.tpRendimiento.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.tpProcesos.ResumeLayout(false);
            this.tpProcesos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabTaskManager.ResumeLayout(false);
            this.barra.ResumeLayout(false);
            this.barra.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconoad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            this.ResumeLayout(false);

        }

        private void tpUsuarios_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion
        private System.Diagnostics.PerformanceCounter pcRAM;
        private System.Diagnostics.PerformanceCounter pcCPU;
        private System.Windows.Forms.Timer timer1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TabPage tpServicios;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TabPage tpDetalles;
        private System.Windows.Forms.TabPage tpUsuarios;
        private System.Windows.Forms.TabPage tpRendimiento;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label lblRAM;
        private System.Windows.Forms.Label lblCPU;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ProgressBar progressBarRAM;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ProgressBar progressBarCPU;
        private System.Windows.Forms.TabPage tpProcesos;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnFinTarea;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox ltbxDisco;
        private System.Windows.Forms.ListBox ltbxMemoriaVirtual;
        private System.Windows.Forms.ListBox ltbxMemoria;
        private System.Windows.Forms.ListBox ltbxCPU;
        private System.Windows.Forms.ListBox ltbxProcesos;
        private System.Windows.Forms.TabControl tabTaskManager;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Panel barra;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.PictureBox iconoad;
        private System.Windows.Forms.PictureBox cerrar;
        private System.Windows.Forms.PictureBox minimizar;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox7;
    }
}

