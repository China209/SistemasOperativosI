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
            this.tpRendimiento = new System.Windows.Forms.TabPage();
            this.tpHistorial = new System.Windows.Forms.TabPage();
            this.tpArranque = new System.Windows.Forms.TabPage();
            this.tpUsuarios = new System.Windows.Forms.TabPage();
            this.tpDetalles = new System.Windows.Forms.TabPage();
            this.tpServicios = new System.Windows.Forms.TabPage();
            this.tabTaskManager.SuspendLayout();
            this.tpProcesos.SuspendLayout();
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
            this.tabTaskManager.Location = new System.Drawing.Point(2, 1);
            this.tabTaskManager.Name = "tabTaskManager";
            this.tabTaskManager.SelectedIndex = 0;
            this.tabTaskManager.Size = new System.Drawing.Size(1333, 610);
            this.tabTaskManager.TabIndex = 0;
            // 
            // tpProcesos
            // 
            this.tpProcesos.BackColor = System.Drawing.Color.OldLace;
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
            this.tpProcesos.Location = new System.Drawing.Point(4, 25);
            this.tpProcesos.Name = "tpProcesos";
            this.tpProcesos.Padding = new System.Windows.Forms.Padding(3);
            this.tpProcesos.Size = new System.Drawing.Size(1325, 581);
            this.tpProcesos.TabIndex = 0;
            this.tpProcesos.Text = "Procesos";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1165, 14);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 17);
            this.label5.TabIndex = 19;
            this.label5.Text = "Red";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(890, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 17);
            this.label4.TabIndex = 18;
            this.label4.Text = "Disco";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(624, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 17);
            this.label3.TabIndex = 17;
            this.label3.Text = "Memoria";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(379, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 17);
            this.label2.TabIndex = 16;
            this.label2.Text = "CPU";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(98, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 17);
            this.label1.TabIndex = 15;
            this.label1.Text = "Procesos";
            // 
            // ltbxDisco
            // 
            this.ltbxDisco.BackColor = System.Drawing.Color.PeachPuff;
            this.ltbxDisco.FormattingEnabled = true;
            this.ltbxDisco.ItemHeight = 16;
            this.ltbxDisco.Location = new System.Drawing.Point(793, 49);
            this.ltbxDisco.Name = "ltbxDisco";
            this.ltbxDisco.Size = new System.Drawing.Size(235, 484);
            this.ltbxDisco.TabIndex = 14;
            // 
            // ltbxRed
            // 
            this.ltbxRed.BackColor = System.Drawing.Color.Bisque;
            this.ltbxRed.FormattingEnabled = true;
            this.ltbxRed.ItemHeight = 16;
            this.ltbxRed.Location = new System.Drawing.Point(1053, 49);
            this.ltbxRed.Name = "ltbxRed";
            this.ltbxRed.Size = new System.Drawing.Size(235, 484);
            this.ltbxRed.TabIndex = 13;
            // 
            // ltbxMemoria
            // 
            this.ltbxMemoria.BackColor = System.Drawing.Color.SandyBrown;
            this.ltbxMemoria.FormattingEnabled = true;
            this.ltbxMemoria.ItemHeight = 16;
            this.ltbxMemoria.Location = new System.Drawing.Point(535, 49);
            this.ltbxMemoria.Name = "ltbxMemoria";
            this.ltbxMemoria.Size = new System.Drawing.Size(235, 484);
            this.ltbxMemoria.TabIndex = 12;
            // 
            // ltbxCPU
            // 
            this.ltbxCPU.BackColor = System.Drawing.Color.Chocolate;
            this.ltbxCPU.FormattingEnabled = true;
            this.ltbxCPU.ItemHeight = 16;
            this.ltbxCPU.Location = new System.Drawing.Point(278, 49);
            this.ltbxCPU.Name = "ltbxCPU";
            this.ltbxCPU.Size = new System.Drawing.Size(235, 484);
            this.ltbxCPU.TabIndex = 11;
            // 
            // ltbxProcesos
            // 
            this.ltbxProcesos.BackColor = System.Drawing.Color.SaddleBrown;
            this.ltbxProcesos.FormattingEnabled = true;
            this.ltbxProcesos.ItemHeight = 16;
            this.ltbxProcesos.Location = new System.Drawing.Point(21, 49);
            this.ltbxProcesos.Name = "ltbxProcesos";
            this.ltbxProcesos.Size = new System.Drawing.Size(235, 484);
            this.ltbxProcesos.TabIndex = 10;
            // 
            // tpRendimiento
            // 
            this.tpRendimiento.BackColor = System.Drawing.Color.Azure;
            this.tpRendimiento.Location = new System.Drawing.Point(4, 25);
            this.tpRendimiento.Name = "tpRendimiento";
            this.tpRendimiento.Padding = new System.Windows.Forms.Padding(3);
            this.tpRendimiento.Size = new System.Drawing.Size(1325, 581);
            this.tpRendimiento.TabIndex = 1;
            this.tpRendimiento.Text = "Rendimiento";
            // 
            // tpHistorial
            // 
            this.tpHistorial.BackColor = System.Drawing.Color.LavenderBlush;
            this.tpHistorial.Location = new System.Drawing.Point(4, 25);
            this.tpHistorial.Name = "tpHistorial";
            this.tpHistorial.Padding = new System.Windows.Forms.Padding(3);
            this.tpHistorial.Size = new System.Drawing.Size(1325, 581);
            this.tpHistorial.TabIndex = 2;
            this.tpHistorial.Text = "Historial";
            // 
            // tpArranque
            // 
            this.tpArranque.BackColor = System.Drawing.Color.Linen;
            this.tpArranque.Location = new System.Drawing.Point(4, 25);
            this.tpArranque.Name = "tpArranque";
            this.tpArranque.Padding = new System.Windows.Forms.Padding(3);
            this.tpArranque.Size = new System.Drawing.Size(1325, 581);
            this.tpArranque.TabIndex = 3;
            this.tpArranque.Text = "Arranque";
            // 
            // tpUsuarios
            // 
            this.tpUsuarios.BackColor = System.Drawing.Color.Gainsboro;
            this.tpUsuarios.Location = new System.Drawing.Point(4, 25);
            this.tpUsuarios.Name = "tpUsuarios";
            this.tpUsuarios.Padding = new System.Windows.Forms.Padding(3);
            this.tpUsuarios.Size = new System.Drawing.Size(1325, 581);
            this.tpUsuarios.TabIndex = 4;
            this.tpUsuarios.Text = "Usuarios";
            // 
            // tpDetalles
            // 
            this.tpDetalles.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.tpDetalles.Location = new System.Drawing.Point(4, 25);
            this.tpDetalles.Name = "tpDetalles";
            this.tpDetalles.Padding = new System.Windows.Forms.Padding(3);
            this.tpDetalles.Size = new System.Drawing.Size(1325, 581);
            this.tpDetalles.TabIndex = 5;
            this.tpDetalles.Text = "Detalles";
            // 
            // tpServicios
            // 
            this.tpServicios.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.tpServicios.Location = new System.Drawing.Point(4, 25);
            this.tpServicios.Name = "tpServicios";
            this.tpServicios.Padding = new System.Windows.Forms.Padding(3);
            this.tpServicios.Size = new System.Drawing.Size(1325, 581);
            this.tpServicios.TabIndex = 6;
            this.tpServicios.Text = "Servicios";
            // 
            // Administrador_Tareas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1334, 698);
            this.Controls.Add(this.tabTaskManager);
            this.Name = "Administrador_Tareas";
            this.Text = "Administrador de Tareas";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabTaskManager.ResumeLayout(false);
            this.tpProcesos.ResumeLayout(false);
            this.tpProcesos.PerformLayout();
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
    }
}

