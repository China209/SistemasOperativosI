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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Administrador_Tareas));
            this.pcRAM = new System.Diagnostics.PerformanceCounter();
            this.pcCPU = new System.Diagnostics.PerformanceCounter();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.tpServicios = new System.Windows.Forms.TabPage();
            this.label9 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.tpDetalles = new System.Windows.Forms.TabPage();
            this.tpUsuarios = new System.Windows.Forms.TabPage();
            this.tpRendimiento = new System.Windows.Forms.TabPage();
            this.progressBarCPU = new System.Windows.Forms.ProgressBar();
            this.label7 = new System.Windows.Forms.Label();
            this.progressBarRAM = new System.Windows.Forms.ProgressBar();
            this.label8 = new System.Windows.Forms.Label();
            this.lblCPU = new System.Windows.Forms.Label();
            this.lblRAM = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tpProcesos = new System.Windows.Forms.TabPage();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevaTareaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ltbxProcesos = new System.Windows.Forms.ListBox();
            this.ltbxCPU = new System.Windows.Forms.ListBox();
            this.ltbxMemoria = new System.Windows.Forms.ListBox();
            this.ltbxRed = new System.Windows.Forms.ListBox();
            this.ltbxDisco = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnFinTarea = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.tabTaskManager = new System.Windows.Forms.TabControl();
            ((System.ComponentModel.ISupportInitialize)(this.pcRAM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcCPU)).BeginInit();
            this.tpServicios.SuspendLayout();
            this.tpRendimiento.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.tpProcesos.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.tabTaskManager.SuspendLayout();
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
            this.tpServicios.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.tpServicios.Controls.Add(this.progressBar1);
            this.tpServicios.Controls.Add(this.button2);
            this.tpServicios.Controls.Add(this.button1);
            this.tpServicios.Controls.Add(this.comboBox1);
            this.tpServicios.Controls.Add(this.label9);
            this.tpServicios.Location = new System.Drawing.Point(4, 32);
            this.tpServicios.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tpServicios.Name = "tpServicios";
            this.tpServicios.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tpServicios.Size = new System.Drawing.Size(1325, 757);
            this.tpServicios.TabIndex = 6;
            this.tpServicios.Text = "Servicios";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(322, 128);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(207, 23);
            this.label9.TabIndex = 0;
            this.label9.Text = "SERVICIOS DE WINDOWS";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(595, 120);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(237, 31);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(395, 222);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 49);
            this.button1.TabIndex = 2;
            this.button1.Text = "INICIAR\r\n";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(638, 222);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(105, 49);
            this.button2.TabIndex = 3;
            this.button2.Text = "DETENER";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(335, 371);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(506, 81);
            this.progressBar1.TabIndex = 4;
            // 
            // tpDetalles
            // 
            this.tpDetalles.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.tpDetalles.Location = new System.Drawing.Point(4, 32);
            this.tpDetalles.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tpDetalles.Name = "tpDetalles";
            this.tpDetalles.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tpDetalles.Size = new System.Drawing.Size(1325, 757);
            this.tpDetalles.TabIndex = 5;
            this.tpDetalles.Text = "Detalles";
            // 
            // tpUsuarios
            // 
            this.tpUsuarios.BackColor = System.Drawing.Color.Gainsboro;
            this.tpUsuarios.Location = new System.Drawing.Point(4, 32);
            this.tpUsuarios.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tpUsuarios.Name = "tpUsuarios";
            this.tpUsuarios.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tpUsuarios.Size = new System.Drawing.Size(1325, 757);
            this.tpUsuarios.TabIndex = 4;
            this.tpUsuarios.Text = "Usuarios";
            // 
            // tpRendimiento
            // 
            this.tpRendimiento.BackColor = System.Drawing.Color.Azure;
            this.tpRendimiento.Controls.Add(this.chart1);
            this.tpRendimiento.Controls.Add(this.lblRAM);
            this.tpRendimiento.Controls.Add(this.lblCPU);
            this.tpRendimiento.Controls.Add(this.label8);
            this.tpRendimiento.Controls.Add(this.progressBarRAM);
            this.tpRendimiento.Controls.Add(this.label7);
            this.tpRendimiento.Controls.Add(this.progressBarCPU);
            this.tpRendimiento.Location = new System.Drawing.Point(4, 32);
            this.tpRendimiento.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tpRendimiento.Name = "tpRendimiento";
            this.tpRendimiento.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tpRendimiento.Size = new System.Drawing.Size(1325, 757);
            this.tpRendimiento.TabIndex = 1;
            this.tpRendimiento.Text = "Rendimiento";
            this.tpRendimiento.Click += new System.EventHandler(this.tpRendimiento_Click);
            // 
            // progressBarCPU
            // 
            this.progressBarCPU.Location = new System.Drawing.Point(162, 34);
            this.progressBarCPU.Name = "progressBarCPU";
            this.progressBarCPU.Size = new System.Drawing.Size(434, 61);
            this.progressBarCPU.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(66, 46);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 23);
            this.label7.TabIndex = 1;
            this.label7.Text = "CPU";
            // 
            // progressBarRAM
            // 
            this.progressBarRAM.Location = new System.Drawing.Point(162, 130);
            this.progressBarRAM.Name = "progressBarRAM";
            this.progressBarRAM.Size = new System.Drawing.Size(434, 61);
            this.progressBarRAM.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(66, 142);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 23);
            this.label8.TabIndex = 3;
            this.label8.Text = "RAM";
            // 
            // lblCPU
            // 
            this.lblCPU.AutoSize = true;
            this.lblCPU.Location = new System.Drawing.Point(642, 46);
            this.lblCPU.Name = "lblCPU";
            this.lblCPU.Size = new System.Drawing.Size(33, 23);
            this.lblCPU.TabIndex = 4;
            this.lblCPU.Text = "0%";
            // 
            // lblRAM
            // 
            this.lblRAM.AutoSize = true;
            this.lblRAM.Location = new System.Drawing.Point(642, 142);
            this.lblRAM.Name = "lblRAM";
            this.lblRAM.Size = new System.Drawing.Size(33, 23);
            this.lblRAM.TabIndex = 5;
            this.lblRAM.Text = "0%";
            // 
            // chart1
            // 
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(329, 220);
            this.chart1.Name = "chart1";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series3.Legend = "Legend1";
            series3.Name = "CPU";
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series4.Legend = "Legend1";
            series4.Name = "RAM";
            this.chart1.Series.Add(series3);
            this.chart1.Series.Add(series4);
            this.chart1.Size = new System.Drawing.Size(609, 450);
            this.chart1.TabIndex = 6;
            // 
            // tpProcesos
            // 
            this.tpProcesos.BackColor = System.Drawing.Color.NavajoWhite;
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
            this.tpProcesos.Controls.Add(this.ltbxRed);
            this.tpProcesos.Controls.Add(this.ltbxMemoria);
            this.tpProcesos.Controls.Add(this.ltbxCPU);
            this.tpProcesos.Controls.Add(this.ltbxProcesos);
            this.tpProcesos.Controls.Add(this.menuStrip1);
            this.tpProcesos.Location = new System.Drawing.Point(4, 32);
            this.tpProcesos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tpProcesos.Name = "tpProcesos";
            this.tpProcesos.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tpProcesos.Size = new System.Drawing.Size(1325, 757);
            this.tpProcesos.TabIndex = 0;
            this.tpProcesos.Text = "Procesos";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.White;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(3, 2);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1319, 33);
            this.menuStrip1.TabIndex = 20;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevaTareaToolStripMenuItem});
            this.archivoToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(88, 29);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // nuevaTareaToolStripMenuItem
            // 
            this.nuevaTareaToolStripMenuItem.Name = "nuevaTareaToolStripMenuItem";
            this.nuevaTareaToolStripMenuItem.Size = new System.Drawing.Size(194, 30);
            this.nuevaTareaToolStripMenuItem.Text = "Nueva Tarea";
            this.nuevaTareaToolStripMenuItem.Click += new System.EventHandler(this.nuevaTareaToolStripMenuItem_Click);
            // 
            // ltbxProcesos
            // 
            this.ltbxProcesos.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ltbxProcesos.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ltbxProcesos.FormattingEnabled = true;
            this.ltbxProcesos.ItemHeight = 28;
            this.ltbxProcesos.Location = new System.Drawing.Point(25, 178);
            this.ltbxProcesos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ltbxProcesos.Name = "ltbxProcesos";
            this.ltbxProcesos.Size = new System.Drawing.Size(235, 424);
            this.ltbxProcesos.TabIndex = 10;
            // 
            // ltbxCPU
            // 
            this.ltbxCPU.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ltbxCPU.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ltbxCPU.FormattingEnabled = true;
            this.ltbxCPU.ItemHeight = 28;
            this.ltbxCPU.Location = new System.Drawing.Point(280, 178);
            this.ltbxCPU.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ltbxCPU.Name = "ltbxCPU";
            this.ltbxCPU.Size = new System.Drawing.Size(235, 424);
            this.ltbxCPU.TabIndex = 11;
            this.ltbxCPU.SelectedIndexChanged += new System.EventHandler(this.ltbxCPU_SelectedIndexChanged);
            // 
            // ltbxMemoria
            // 
            this.ltbxMemoria.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ltbxMemoria.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ltbxMemoria.FormattingEnabled = true;
            this.ltbxMemoria.ItemHeight = 28;
            this.ltbxMemoria.Location = new System.Drawing.Point(536, 178);
            this.ltbxMemoria.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ltbxMemoria.Name = "ltbxMemoria";
            this.ltbxMemoria.Size = new System.Drawing.Size(235, 424);
            this.ltbxMemoria.TabIndex = 12;
            // 
            // ltbxRed
            // 
            this.ltbxRed.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ltbxRed.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ltbxRed.FormattingEnabled = true;
            this.ltbxRed.ItemHeight = 28;
            this.ltbxRed.Location = new System.Drawing.Point(1051, 178);
            this.ltbxRed.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ltbxRed.Name = "ltbxRed";
            this.ltbxRed.Size = new System.Drawing.Size(235, 424);
            this.ltbxRed.TabIndex = 13;
            // 
            // ltbxDisco
            // 
            this.ltbxDisco.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ltbxDisco.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ltbxDisco.FormattingEnabled = true;
            this.ltbxDisco.ItemHeight = 28;
            this.ltbxDisco.Location = new System.Drawing.Point(792, 178);
            this.ltbxDisco.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ltbxDisco.Name = "ltbxDisco";
            this.ltbxDisco.Size = new System.Drawing.Size(235, 424);
            this.ltbxDisco.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(87, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 32);
            this.label1.TabIndex = 15;
            this.label1.Text = "Procesos";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(365, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 32);
            this.label2.TabIndex = 16;
            this.label2.Text = "CPU";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(584, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 32);
            this.label3.TabIndex = 17;
            this.label3.Text = "Memoria";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(873, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 32);
            this.label4.TabIndex = 18;
            this.label4.Text = "Disco";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(1149, 42);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 32);
            this.label5.TabIndex = 19;
            this.label5.Text = "Red";
            // 
            // btnFinTarea
            // 
            this.btnFinTarea.BackColor = System.Drawing.Color.DarkOrange;
            this.btnFinTarea.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFinTarea.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFinTarea.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinTarea.Location = new System.Drawing.Point(1101, 649);
            this.btnFinTarea.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnFinTarea.Name = "btnFinTarea";
            this.btnFinTarea.Size = new System.Drawing.Size(185, 52);
            this.btnFinTarea.TabIndex = 21;
            this.btnFinTarea.Text = "Finalizar Tarea";
            this.btnFinTarea.UseVisualStyleBackColor = false;
            this.btnFinTarea.Click += new System.EventHandler(this.btnFinTarea_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Image = ((System.Drawing.Image)(resources.GetObject("label6.Image")));
            this.label6.Location = new System.Drawing.Point(417, 42);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 32);
            this.label6.TabIndex = 22;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Location = new System.Drawing.Point(76, 78);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(127, 86);
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox2.Location = new System.Drawing.Point(341, 78);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(127, 86);
            this.pictureBox2.TabIndex = 24;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox3.BackgroundImage")));
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox3.Location = new System.Drawing.Point(576, 78);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(127, 86);
            this.pictureBox3.TabIndex = 25;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox4.BackgroundImage")));
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox4.Location = new System.Drawing.Point(849, 78);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(127, 86);
            this.pictureBox4.TabIndex = 26;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox5.BackgroundImage")));
            this.pictureBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox5.Location = new System.Drawing.Point(1112, 78);
            this.pictureBox5.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(127, 86);
            this.pictureBox5.TabIndex = 27;
            this.pictureBox5.TabStop = false;
            // 
            // tabTaskManager
            // 
            this.tabTaskManager.Controls.Add(this.tpProcesos);
            this.tabTaskManager.Controls.Add(this.tpRendimiento);
            this.tabTaskManager.Controls.Add(this.tpUsuarios);
            this.tabTaskManager.Controls.Add(this.tpDetalles);
            this.tabTaskManager.Controls.Add(this.tpServicios);
            this.tabTaskManager.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabTaskManager.Location = new System.Drawing.Point(3, 1);
            this.tabTaskManager.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabTaskManager.Name = "tabTaskManager";
            this.tabTaskManager.SelectedIndex = 0;
            this.tabTaskManager.Size = new System.Drawing.Size(1333, 793);
            this.tabTaskManager.TabIndex = 0;
            // 
            // Administrador_Tareas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1339, 799);
            this.Controls.Add(this.tabTaskManager);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Administrador_Tareas";
            this.Text = "Administrador de Tareas";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pcRAM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcCPU)).EndInit();
            this.tpServicios.ResumeLayout(false);
            this.tpServicios.PerformLayout();
            this.tpRendimiento.ResumeLayout(false);
            this.tpRendimiento.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.tpProcesos.ResumeLayout(false);
            this.tpProcesos.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.tabTaskManager.ResumeLayout(false);
            this.ResumeLayout(false);

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
        private System.Windows.Forms.ListBox ltbxRed;
        private System.Windows.Forms.ListBox ltbxMemoria;
        private System.Windows.Forms.ListBox ltbxCPU;
        private System.Windows.Forms.ListBox ltbxProcesos;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevaTareaToolStripMenuItem;
        private System.Windows.Forms.TabControl tabTaskManager;
    }
}

