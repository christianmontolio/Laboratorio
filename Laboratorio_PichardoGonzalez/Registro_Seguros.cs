﻿using System;
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
    public partial class Registro_Seguros : Form
    {
        public Registro_Seguros()
        {
            InitializeComponent();
        }

        private void Registro_Seguros_Load(object sender, EventArgs e)
        {
            this.BringToFront();
            TxtCodigo.Focus();
        }

        private void Registro_Seguros_Click(object sender, EventArgs e)
        {
            this.BringToFront();
        }

        
    }
}
