using AppRRHH.Data;
using AppRRHH.models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AppRRHH.views.vistasAdmin
{
    public partial class UCConfiguracionAdmin : UserControl
    {
        public UCConfiguracionAdmin()
        {
            InitializeComponent();
            CargarEmpresa();
        }
        private void CargarEmpresa()
        {
            using (var db = new AppDbContext())
            {
                // Compruebo si existe una empresa en la bd
                var empresa = db.Empresas.FirstOrDefault();
                // Si existe, cargo sus datos en los campos de texto
                if (empresa != null)
                {
                    txtNombre.Text = empresa.Nombre;
                    txtCIF.Text = empresa.CIF;
                    txtDireccion.Text = empresa.Direccion;
                    txtMunicipio.Text = empresa.Municipio;
                    txtCodigoPostal.Text = empresa.CodigoPostal;
                    txtNumCuentaCotizacion.Text = empresa.NumCuentaCotizacion;
                }
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            // compruebo si los campos de nombre y cif estan vacíos 
            if (string.IsNullOrWhiteSpace(txtNombre.Text) || string.IsNullOrWhiteSpace(txtCIF.Text))
            {
                MessageBox.Show("El nombre y el CIF son obligatorios.",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (var db = new AppDbContext())
            {
                var empresa = db.Empresas.FirstOrDefault();
                // si no existe una empresa, la creo, si ya existe, la edito con los nuevos datos
                if (empresa == null)
                {
                    // doy de alta la nueva empresa
                    empresa = new Empresa
                    {
                        Nombre = txtNombre.Text,
                        CIF = txtCIF.Text,
                        Direccion = txtDireccion.Text,
                        Municipio = txtMunicipio.Text,
                        CodigoPostal = txtCodigoPostal.Text,
                        NumCuentaCotizacion = txtNumCuentaCotizacion.Text
                    };
                    db.Empresas.Add(empresa);
                }
                else
                {
                    // Edito la empresa qeu ya existe
                    empresa.Nombre = txtNombre.Text;
                    empresa.CIF = txtCIF.Text;
                    empresa.Direccion = txtDireccion.Text;
                    empresa.Municipio = txtMunicipio.Text;
                    empresa.CodigoPostal = txtCodigoPostal.Text;
                    empresa.NumCuentaCotizacion = txtNumCuentaCotizacion.Text;
                }

                db.SaveChanges();
                MessageBox.Show("Datos de la empresa guardados correctamente.",
                    "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
