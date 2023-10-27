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
    public partial class FormVerStock : Form
    {
        public FormVerStock()
        {
            InitializeComponent();
            dataGridView1.DataSource = Produccion.Materiales.Select(item => new { Componente = item.Key, Cantidad = item.Value }).ToList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
