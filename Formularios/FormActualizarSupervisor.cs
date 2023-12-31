﻿using Fabrica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rarug.Francisco.Parcial
{
    public partial class FormActualizarSupervisor : Form
    {
        private int id;
        public FormActualizarSupervisor(int id)
        {
            InitializeComponent();
            this.id = id;
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            string nombre = tbNombre.Text;
            string legajo = tbLegajo.Text;
            string password = tbPassword.Text;

            BaseDeDatosDAO.ModificarSupervisor(nombre, id, legajo, password);
            MessageBox.Show("Supervisor Actualizado correctamente", "Registrado!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

    }   
}
