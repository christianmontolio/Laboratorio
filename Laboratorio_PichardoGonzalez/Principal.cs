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
    public partial class Principal : Form
    {
        
        Registro_Pacientes rg;
        Registro_Departamentos rd;
        Registro_Pruebas rp;
        Registro_Precios rpp;
        Facturacion f;
        Registro_Resultados rr;
        Registro_Seguros rs;
        Reporte_Ventas rv;

        public Principal()
        {
            InitializeComponent();
        }
      
        //Hora y fecha en la ventana
        private void HourandMore_Tick(object sender, EventArgs e)
        {
            LabelTime.Text = DateTime.Now.ToLongTimeString();
            LabelDate.Text = DateTime.Now.ToShortDateString();
        }
        
        private void LinkRPacientes_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LinkRPacientes.LinkColor = Color.DarkBlue;
            //Permite agregar la instancia de la clase Registro_Pacientes al MDI
            if (rg == null)
            {
                rg = new Registro_Pacientes();
                rg.MdiParent = this;
                this.splitPrincipal.Panel2.Controls.Add(rg); //se anade la instancia al split
                rg.FormClosed += new FormClosedEventHandler(Rg_FormClosed); //si la ventana abierta se cierra, abre el metodo debajo
                rg.Show();
            }
            else
            {
                rg.Activate();
            }
        }        
        private void Rg_FormClosed(object sender, FormClosedEventArgs e)
        {           
            //Se quita el valor del objeto RG para poder abrirlas una vez esta sea cerrada
            rg = null;
            LinkRPacientes.LinkColor = Color.White;
        }
        private void LinkRDepartamentos_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LinkRDepartamentos.LinkColor = Color.DarkBlue;         
            if (rd == null)
            {
                rd = new Registro_Departamentos();
                rd.MdiParent = this;
                
                this.splitPrincipal.Panel2.Controls.Add(rd);
                rd.FormClosed += new FormClosedEventHandler(Rd_FormClosed);
                rd.Show();
                rd.Size = new Size(600, 320);
            }
            else
            {
                rd.Activate();
            }
        }
        private void Rd_FormClosed(object sender, FormClosedEventArgs e)
        {
            rd = null;
            LinkRDepartamentos.LinkColor = Color.White;
        }
        private void LinkRPruebas_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LinkRPruebas.LinkColor = Color.DarkBlue;
            if (rp == null)
            {
                rp = new Registro_Pruebas();
                rp.MdiParent = this;
                this.splitPrincipal.Panel2.Controls.Add(rp);
                rp.FormClosed += new FormClosedEventHandler(Rp_FormClosed);
                rp.Show();
            }
            else
            {
                rp.Activate();
            }
        }
        private void Rp_FormClosed(object sender, FormClosedEventArgs e)
        {
            rp = null;
            LinkRPruebas.LinkColor = Color.White;
        }
        private void LinkRPrecio_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LinkRPrecio.LinkColor = Color.DarkBlue;
            if (rpp == null)
            {
                rpp = new Registro_Precios();
                rpp.MdiParent = this;
                this.splitPrincipal.Panel2.Controls.Add(rpp);
                rpp.FormClosed += new FormClosedEventHandler(Rpp_FormClosed);
                rpp.Show();
            }
            else
            {
                rpp.Activate();
            }
        }
        private void Rpp_FormClosed(object sender, FormClosedEventArgs e)
        {
            rpp = null;
            LinkRPrecio.LinkColor = Color.White;
        }
        private void LinkRSeguro_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LinkRSeguro.LinkColor = Color.DarkBlue;
            if (rs == null)
            {
                rs = new Registro_Seguros();
                rs.MdiParent = this;
                this.splitPrincipal.Panel2.Controls.Add(rs);
                rs.FormClosed += new FormClosedEventHandler(Rs_FormClosed);
                rs.Show();
                rs.Size = new Size(600, 320);
            }
            else
            {
                rs.Activate();
            }
        }
        private void Rs_FormClosed(object sender, FormClosedEventArgs e)
        {
            rs = null;
            LinkRSeguro.LinkColor = Color.White;
        }
        private void LinkFactura_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LinkFactura.LinkColor = Color.DarkBlue;
            if (f == null)
            {
                f = new Facturacion();
                f.MdiParent = this;
                this.splitPrincipal.Panel2.Controls.Add(f);
                f.FormClosed += new FormClosedEventHandler(f_FormClosed);
                f.Show();
            }
            else
            {
                f.Activate();
            }
        }
        private void f_FormClosed(object sender, FormClosedEventArgs e)
        {
            f = null;
            LinkFactura.LinkColor = Color.White;
        }
        private void LinkResultados_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LinkResultados.LinkColor = Color.DarkBlue;
            if (rr == null)
            {
                rr = new Registro_Resultados();
                rr.MdiParent = this;
                this.splitPrincipal.Panel2.Controls.Add(rr);
                rr.FormClosed += new FormClosedEventHandler(rr_FormClosed);
                rr.Show();
            }
            else
            {
                rr.Activate();
            }
        }
        private void rr_FormClosed(object sender, FormClosedEventArgs e)
        {
            rr = null;
            LinkResultados.LinkColor = Color.White;
        }
        private void LinkRVentas_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LinkRVentas.LinkColor = Color.DarkBlue;
            if (rv == null)
            {
                rv = new Reporte_Ventas();
                rv.MdiParent = this;
                this.splitPrincipal.Panel2.Controls.Add(rv);
                rv.FormClosed += new FormClosedEventHandler(rv_FormClosed);
                rv.Show();
                rv.Size = new Size(600, 320);
            }
            else
            {
                rv.Activate();
            }
        }
        private void rv_FormClosed(object sender, FormClosedEventArgs e)
        {
            rv = null;
            LinkRVentas.LinkColor = Color.White;
        }

        private void Principal_Load(object sender, EventArgs e)
        {
            LinkRPacientes.Focus();
        }
    }
}
