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
    public partial class NuevaTarea : Form
    {
        public NuevaTarea()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void btnAbrir_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtIngresoTarea.Text))
            {
                try
                {
                    Process proceso = new Process();
                    proceso.StartInfo.FileName = txtIngresoTarea.Text;
                    proceso.Start();
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }
    }
}
