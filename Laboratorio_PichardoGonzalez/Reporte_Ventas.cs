using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laboratorio_PichardoGonzalez
{
    public partial class Reporte_Ventas : Form
    {
        public Reporte_Ventas()
        {
            InitializeComponent();
        }

        private void Reporte_Ventas_Load(object sender, EventArgs e)
        {
            this.BringToFront();
        }

        private void Reporte_Ventas_Click(object sender, EventArgs e)
        {
            this.BringToFront();
        }
    }
}
