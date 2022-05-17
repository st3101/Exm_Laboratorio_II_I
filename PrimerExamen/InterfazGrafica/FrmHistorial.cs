using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InterfazGrafica
{
    public partial class FrmHistorial : Form
    {
        string historial;
        public string Historial { get => historial; set => historial = value; }
        public FrmHistorial(string historial)
        {
            InitializeComponent();
            Historial = historial;
        }
        private void FrmHistorial_Load(object sender, EventArgs e)
        {
            RtbHistorial.Text = Historial;
        }

        private void FrmHistorial_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult = DialogResult.OK;
        }
    }
}
