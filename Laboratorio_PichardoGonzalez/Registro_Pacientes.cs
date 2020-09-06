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
    public partial class Registro_Pacientes : Form
    {
        public Registro_Pacientes()
        {
            InitializeComponent();
            
        }
            
        private void Registro_Pacientes_Load(object sender, EventArgs e)
        {         
            this.BringToFront();
        }

        private void Registro_Pacientes_Click(object sender, EventArgs e)
        {
            this.BringToFront();
        }
    }
}
