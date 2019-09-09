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
            this.tabTaskManager = new System.Windows.Forms.TabControl();
            this.tpProcesos = new System.Windows.Forms.TabPage();
            this.btnFinTarea = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ltbxDisco = new System.Windows.Forms.ListBox();
            this.ltbxRed = new System.Windows.Forms.ListBox();
            this.ltbxMemoria = new System.Windows.Forms.ListBox();
            this.ltbxCPU = new System.Windows.Forms.ListBox();
            this.ltbxProcesos = new System.Windows.Forms.ListBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevaTareaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tpRendimiento = new System.Windows.Forms.TabPage();
            this.tpHistorial = new System.Windows.Forms.TabPage();
            this.tpArranque = new System.Windows.Forms.TabPage();
            this.tpUsuarios = new System.Windows.Forms.TabPage();
            this.tpDetalles = new System.Windows.Forms.TabPage();
            this.tpServicios = new System.Windows.Forms.TabPage();
            this.tabTaskManager.SuspendLayout();
            this.tpProcesos.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabTaskManager
            // 
            this.tabTaskManager.Controls.Add(this.tpProcesos);
            this.tabTaskManager.Controls.Add(this.tpRendimiento);
            this.tabTaskManager.Controls.Add(this.tpHistorial);
            this.tabTaskManager.Controls.Add(this.tpArranque);
            this.tabTaskManager.Controls.Add(this.tpUsuarios);
            this.tabTaskManager.Controls.Add(this.tpDetalles);
            this.tabTaskManager.Controls.Add(this.tpServicios);
            this.tabTaskManager.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabTaskManager.Location = new System.Drawing.Point(2, 1);
            this.tabTaskManager.Name = "tabTaskManager";
            this.tabTaskManager.SelectedIndex = 0;
            this.tabTaskManager.Size = new System.Drawing.Size(1333, 695);
            this.tabTaskManager.TabIndex = 0;
            // 
            // tpProcesos
            // 
            this.tpProcesos.BackColor = System.Drawing.Color.NavajoWhite;
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
            this.tpProcesos.Name = "tpProcesos";
            this.tpProcesos.Padding = new System.Windows.Forms.Padding(3);
            this.tpProcesos.Size = new System.Drawing.Size(1325, 659);
            this.tpProcesos.TabIndex = 0;
            this.tpProcesos.Text = "Procesos";
            // 
            // btnFinTarea
            // 
            this.btnFinTarea.BackColor = System.Drawing.Color.DarkOrange;
            this.btnFinTarea.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFinTarea.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFinTarea.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinTarea.Location = new System.Drawing.Point(1070, 575);
            this.btnFinTarea.Name = "btnFinTarea";
            this.btnFinTarea.Size = new System.Drawing.Size(185, 52);
            this.btnFinTarea.TabIndex = 21;
            this.btnFinTarea.Text = "Finalizar Tarea";
            this.btnFinTarea.UseVisualStyleBackColor = false;
            this.btnFinTarea.Click += new System.EventHandler(this.btnFinTarea_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(1154, 42);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 32);
            this.label5.TabIndex = 19;
            this.label5.Text = "Red";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(879, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 32);
            this.label4.TabIndex = 18;
            this.label4.Text = "Disco";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(613, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 32);
            this.label3.TabIndex = 17;
            this.label3.Text = "Memoria";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(368, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 32);
            this.label2.TabIndex = 16;
            this.label2.Text = "CPU";
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
            // 
            // ltbxDisco
            // 
            this.ltbxDisco.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ltbxDisco.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ltbxDisco.FormattingEnabled = true;
            this.ltbxDisco.ItemHeight = 28;
            this.ltbxDisco.Location = new System.Drawing.Point(795, 77);
            this.ltbxDisco.Name = "ltbxDisco";
            this.ltbxDisco.Size = new System.Drawing.Size(235, 480);
            this.ltbxDisco.TabIndex = 14;
            // 
            // ltbxRed
            // 
            this.ltbxRed.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ltbxRed.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ltbxRed.FormattingEnabled = true;
            this.ltbxRed.ItemHeight = 28;
            this.ltbxRed.Location = new System.Drawing.Point(1055, 77);
            this.ltbxRed.Name = "ltbxRed";
            this.ltbxRed.Size = new System.Drawing.Size(235, 480);
            this.ltbxRed.TabIndex = 13;
            // 
            // ltbxMemoria
            // 
            this.ltbxMemoria.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ltbxMemoria.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ltbxMemoria.FormattingEnabled = true;
            this.ltbxMemoria.ItemHeight = 28;
            this.ltbxMemoria.Location = new System.Drawing.Point(537, 77);
            this.ltbxMemoria.Name = "ltbxMemoria";
            this.ltbxMemoria.Size = new System.Drawing.Size(235, 480);
            this.ltbxMemoria.TabIndex = 12;
            // 
            // ltbxCPU
            // 
            this.ltbxCPU.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ltbxCPU.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ltbxCPU.FormattingEnabled = true;
            this.ltbxCPU.ItemHeight = 28;
            this.ltbxCPU.Location = new System.Drawing.Point(280, 77);
            this.ltbxCPU.Name = "ltbxCPU";
            this.ltbxCPU.Size = new System.Drawing.Size(235, 480);
            this.ltbxCPU.TabIndex = 11;
            // 
            // ltbxProcesos
            // 
            this.ltbxProcesos.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ltbxProcesos.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ltbxProcesos.FormattingEnabled = true;
            this.ltbxProcesos.ItemHeight = 28;
            this.ltbxProcesos.Location = new System.Drawing.Point(23, 77);
            this.ltbxProcesos.Name = "ltbxProcesos";
            this.ltbxProcesos.Size = new System.Drawing.Size(235, 480);
            this.ltbxProcesos.TabIndex = 10;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.White;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(3, 3);
            this.menuStrip1.Name = "menuStrip1";
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
            this.nuevaTareaToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.nuevaTareaToolStripMenuItem.Text = "Nueva Tarea";
            this.nuevaTareaToolStripMenuItem.Click += new System.EventHandler(this.nuevaTareaToolStripMenuItem_Click);
            // 
            // tpRendimiento
            // 
            this.tpRendimiento.BackColor = System.Drawing.Color.Azure;
            this.tpRendimiento.Location = new System.Drawing.Point(4, 32);
            this.tpRendimiento.Name = "tpRendimiento";
            this.tpRendimiento.Padding = new System.Windows.Forms.Padding(3);
            this.tpRendimiento.Size = new System.Drawing.Size(1325, 633);
            this.tpRendimiento.TabIndex = 1;
            this.tpRendimiento.Text = "Rendimiento";
            // 
            // tpHistorial
            // 
            this.tpHistorial.BackColor = System.Drawing.Color.LavenderBlush;
            this.tpHistorial.Location = new System.Drawing.Point(4, 32);
            this.tpHistorial.Name = "tpHistorial";
            this.tpHistorial.Padding = new System.Windows.Forms.Padding(3);
            this.tpHistorial.Size = new System.Drawing.Size(1325, 633);
            this.tpHistorial.TabIndex = 2;
            this.tpHistorial.Text = "Historial";
            // 
            // tpArranque
            // 
            this.tpArranque.BackColor = System.Drawing.Color.Linen;
            this.tpArranque.Location = new System.Drawing.Point(4, 32);
            this.tpArranque.Name = "tpArranque";
            this.tpArranque.Padding = new System.Windows.Forms.Padding(3);
            this.tpArranque.Size = new System.Drawing.Size(1325, 633);
            this.tpArranque.TabIndex = 3;
            this.tpArranque.Text = "Arranque";
            // 
            // tpUsuarios
            // 
            this.tpUsuarios.BackColor = System.Drawing.Color.Gainsboro;
            this.tpUsuarios.Location = new System.Drawing.Point(4, 32);
            this.tpUsuarios.Name = "tpUsuarios";
            this.tpUsuarios.Padding = new System.Windows.Forms.Padding(3);
            this.tpUsuarios.Size = new System.Drawing.Size(1325, 633);
            this.tpUsuarios.TabIndex = 4;
            this.tpUsuarios.Text = "Usuarios";
            // 
            // tpDetalles
            // 
            this.tpDetalles.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.tpDetalles.Location = new System.Drawing.Point(4, 32);
            this.tpDetalles.Name = "tpDetalles";
            this.tpDetalles.Padding = new System.Windows.Forms.Padding(3);
            this.tpDetalles.Size = new System.Drawing.Size(1325, 633);
            this.tpDetalles.TabIndex = 5;
            this.tpDetalles.Text = "Detalles";
            // 
            // tpServicios
            // 
            this.tpServicios.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.tpServicios.Location = new System.Drawing.Point(4, 32);
            this.tpServicios.Name = "tpServicios";
            this.tpServicios.Padding = new System.Windows.Forms.Padding(3);
            this.tpServicios.Size = new System.Drawing.Size(1325, 633);
            this.tpServicios.TabIndex = 6;
            this.tpServicios.Text = "Servicios";
            // 
            // Administrador_Tareas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1334, 698);
            this.Controls.Add(this.tabTaskManager);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Administrador_Tareas";
            this.Text = "Administrador de Tareas";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabTaskManager.ResumeLayout(false);
            this.tpProcesos.ResumeLayout(false);
            this.tpProcesos.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabTaskManager;
        private System.Windows.Forms.TabPage tpProcesos;
        private System.Windows.Forms.TabPage tpRendimiento;
        private System.Windows.Forms.TabPage tpHistorial;
        private System.Windows.Forms.TabPage tpArranque;
        private System.Windows.Forms.TabPage tpUsuarios;
        private System.Windows.Forms.TabPage tpDetalles;
        private System.Windows.Forms.TabPage tpServicios;
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
        private System.Windows.Forms.Button btnFinTarea;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevaTareaToolStripMenuItem;
    }
}

