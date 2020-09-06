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
    public partial class Registro_Departamentos : Form
    {
        public Registro_Departamentos()
        {
            InitializeComponent();
        }

        private void Registro_Departamentos_Load(object sender, EventArgs e)
        {
            this.BringToFront();
            txtCodigo.Focus();
        }

        private void Registro_Departamentos_Click(object sender, EventArgs e)
        {
            this.BringToFront();
        }

       
    }
}
