﻿using Fabrica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rarug.Francisco.Parcial
{
    public partial class FormFabricaSupervisor : Form

    {
        private ModoOscuro modoOscuro;
        public FormFabricaSupervisor()
        {
            InitializeComponent();
            modoOscuro = new ModoOscuro(this);
        }

        /// <summary>
        /// Crea un producto utilizando un método específico y muestra un mensaje de éxito o error.
        /// </summary>
        /// <param name="crearMetodo">Función que realiza la creación del producto y devuelve un resultado booleano.</param>
        /// <param name="exitoMensaje">Mensaje a mostrar en caso de éxito.</param>
        /// <param name="errorMensaje">Mensaje a mostrar en caso de error.</param>
        public void CrearProductoDefault(Func<bool> crearMetodo, string exitoMensaje, string errorMensaje)
        {
            try
            {
                if (crearMetodo())
                {
                    FormModal1 formProduct = new FormModal1();
                    formProduct.ShowDialog();

                    MessageBox.Show($"{exitoMensaje} exitosamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                Archivos<string>.Errores(DateTime.Now, MethodBase.GetCurrentMethod().DeclaringType.Name, MethodBase.GetCurrentMethod().Name, ex.Message);
            }
        }

        private void btnChocolateDefault_Click(object sender, EventArgs e)
        {
            Chocolate nuevoChocolate;
            CrearProductoDefault(() => Chocolate.CrearChocolateDefault(out nuevoChocolate), "Chocolate creado", "Ha ocurrido un error al crear el chocolate");
        }
         
        private void btnDonaDefault_Click(object sender, EventArgs e)
        {
            Dona nuevaDona;
            CrearProductoDefault(() => Dona.CrearDonaDefault(out nuevaDona), "Dona creada", "Ha ocurrido un error al crear la dona");
        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            FormCrearProducto formProduct = new FormCrearProducto();
            Hide();
            DialogResult result = formProduct.ShowDialog();

            if (result == DialogResult.Cancel)
            {
                Show();
            }
        }
        private void btnVerStock_Click(object sender, EventArgs e)
        {
            FormVerStock formVerStock = new FormVerStock();
            Hide();
            DialogResult result = formVerStock.ShowDialog();

            if (result == DialogResult.Cancel)
            {
                Show();
            }
        }
        private void btnVerProductos_Click(object sender, EventArgs e)
        {
            FormProductosCreados formProductosCreados = new FormProductosCreados();
            Hide();
            DialogResult result = formProductosCreados.ShowDialog();

            if (result == DialogResult.Cancel)
            {
                Show();
            }
        }
        private void btnRellenarStock_Click(object sender, EventArgs e)
        {
            FormRellenarMateriaPrima formRellenarMateriaPrima = new FormRellenarMateriaPrima();
            Hide();
            DialogResult result = formRellenarMateriaPrima.ShowDialog();

            if (result == DialogResult.Cancel)
            {
                Show();
            }
        }
        private void btnOperariosConectados_Click(object sender, EventArgs e)
        {
            VerOperarios formOperarios = new VerOperarios();
            Hide();
            DialogResult result = formOperarios.ShowDialog();

            if (result == DialogResult.Cancel)
            {
                Show();
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCrud_Click(object sender, EventArgs e)
        {
            FormCrud crud = new FormCrud();
            Hide();
            DialogResult result = crud.ShowDialog();

            if (result == DialogResult.Cancel)
            {
                Show();
            }
        }

        private void btnOscuro_Click(object sender, EventArgs e)
        {
            modoOscuro.AplicarModoOscuro();
        }

        private void btnClaro_Click(object sender, EventArgs e)
        {
            modoOscuro.AplicarModoClaro();
        }
    }
}



